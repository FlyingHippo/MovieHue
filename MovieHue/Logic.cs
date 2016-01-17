using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using SharpHue;
using Configuration = System.Configuration.Configuration;

namespace MovieHue.Logic
{
    public class Logic
    {
        public List<ScreenZone> ScreenZones { get; set; }
        public LightCollection Lights { get; set; }
        public DxScreenCapture DxScreenCapture { get; set; }
        public Configuration Configuration { get; set; }
        public int MaxBrightness { get; set; }
        public int MinBrightness { get; set; }
        public bool TurnOffLights { get; set; }


        public Logic()
        {
            {
                setupScreenZones();
                setupProgramSettings();
                setupHUE();
                setupLights();

                
                DxScreenCapture = new DxScreenCapture();

                //var timer = new System.Timers.Timer(200);
                //timer.Enabled = true;
                //timer.Elapsed += timer_Elapsed;
                //while (true)
                //{
                //    timer_Elapsed();
                //    Thread.Sleep(150);
                //}
            }
        }

        private void TestCycle()
        {
            new LightStateBuilder()
                .For(Lights["Spisebord"]) // Specifies one or more lights which this new state is for
                // Or .For(lights, 1, 3)
                .TurnOn() // Turns on the light(s)
                .Color(Color.Red) // Sets the color temperature to 6500K
                .Brightness(150) // Set the brightness to maximum
                .TransitionTime(0)
                .Apply();

            new LightStateBuilder()
                .For(Lights["Spisebord"]) // Specifies one or more lights which this new state is for
                // Or .For(lights, 1, 3)
                .TurnOn() // Turns on the light(s)
                .Color(Color.Blue) // Sets the color temperature to 6500K
                .Brightness(150) // Set the brightness to maximum
                .TransitionTime(0)
                .Apply();
        }

        private void setupScreenZones()
        {
            ScreenZones = new List<ScreenZone>();
            ScreenZones.Add(new ScreenZone { ID = 1, Name = "Top left", LightNames = new List<string>() });
            ScreenZones.Add(new ScreenZone { ID = 2, Name = "Top", LightNames = new List<string>() });
            ScreenZones.Add(new ScreenZone { ID = 3, Name = "Top right", LightNames = new List<string>() });
            ScreenZones.Add(new ScreenZone { ID = 4, Name = "Right", LightNames = new List<string>() });
            ScreenZones.Add(new ScreenZone { ID = 5, Name = "Bottom right", LightNames = new List<string>() });
            ScreenZones.Add(new ScreenZone { ID = 6, Name = "Bottom", LightNames = new List<string>() });
            ScreenZones.Add(new ScreenZone { ID = 7, Name = "Bottom left", LightNames = new List<string>() });
            ScreenZones.Add(new ScreenZone { ID = 8, Name = "Left", LightNames = new List<string>() });
        }

        private void setupLights()
        {
            Lights = new LightCollection(); 
            
            foreach (Light light in Lights)
            {
                Console.WriteLine(light.Name);
                Console.WriteLine("--------Enter ID of screen portion to sync with and press ENTER or 0 to skip--------");
                foreach (ScreenZone screenZone in ScreenZones)
                {
                    Console.WriteLine("ID: {0} Name: {1}", screenZone.ID, screenZone.Name);
                }
                int chosenID = -1;
                string inputString = null;

                while (chosenID == -1 && (inputString == null || !inputString.Trim().Equals("0")))
                {
                    inputString = Console.ReadLine();
                    int.TryParse(inputString, out chosenID);
                }
                if (chosenID != 0)
                {
                    ScreenZone sz = ScreenZones.FirstOrDefault(x => x.ID == chosenID);
                    if (sz != null)
                    {
                        sz.LightNames.Add(light.Name);
                    }
                }
                Console.WriteLine();
            }
        }


        private void setupProgramSettings()
        {
            Configuration = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            KeyValueConfigurationElement MaxBrightnessConfig = Configuration.AppSettings.Settings["MaxBrightness"];
            KeyValueConfigurationElement MinBrightnessConfig = Configuration.AppSettings.Settings["MinBrightness"];
            KeyValueConfigurationElement TurnOffLightsConfig = Configuration.AppSettings.Settings["TurnOffLights"];

            if (TurnOffLightsConfig != null)
            {
                TurnOffLights = Convert.ToBoolean(TurnOffLightsConfig.Value);
            }
            else
            {
                TurnOffLights = true;
                Configuration.AppSettings.Settings.Add("TurnOffLightsConfig", TurnOffLights.ToString());
                Configuration.Save(ConfigurationSaveMode.Minimal);
            }

            if (MaxBrightnessConfig != null)
            {
                MaxBrightness = Convert.ToInt16(MaxBrightnessConfig.Value.Replace('.', ','));
            }
            else
            {
                MaxBrightness = 80;
                Configuration.AppSettings.Settings.Add("MaxBrightness", MaxBrightness.ToString());
                Configuration.Save(ConfigurationSaveMode.Minimal);
            }

            if (MinBrightnessConfig != null)
            {
                MinBrightness = Convert.ToInt16(MinBrightnessConfig.Value.Replace('.', ','));
            }
            else
            {
                MinBrightness = 80;
                Configuration.AppSettings.Settings.Add("MinBrightness", MinBrightness.ToString());
                Configuration.Save(ConfigurationSaveMode.Minimal);
            }
        }

        private void setupHUE()
        {
            KeyValueConfigurationElement DeviceIP = Configuration.AppSettings.Settings["DeviceIP"];
            KeyValueConfigurationElement Username = Configuration.AppSettings.Settings["Username"];

            if (DeviceIP == null || Username == null)
            {
                bool LinkButtonPressed = false;
                while (!LinkButtonPressed)
                {
                    Console.WriteLine("Press the link button on your HUE bridge before continuing");
                    try
                    {
                        SharpHue.Configuration.AddUser();
                        LinkButtonPressed = true;
                    }
                    catch (Exception ex)
                    {
                        if (!ex.Message.Equals("link button not pressed"))
                        {
                            throw;
                        }
                    }
                }

                Configuration.AppSettings.Settings.Add("DeviceIP", SharpHue.Configuration.DeviceIP.ToString());
                Configuration.AppSettings.Settings.Add("Username", SharpHue.Configuration.Username);
                Configuration.Save(ConfigurationSaveMode.Minimal);
            }
            else
            {
                SharpHue.Configuration.Initialize(Username.Value, IPAddress.Parse(DeviceIP.Value));
            }
        }

        public static byte GetBrightness(Color color)
        {
            float num = (color.R)/255f;
            float num2 = (color.G)/255f;
            float num3 = (color.B)/255f;
            float num4 = num;
            float num5 = num;
            if (num2 > num4)
                num4 = num2;
            if (num3 > num4)
                num4 = num3;
            if (num2 < num5)
                num5 = num2;
            if (num3 < num5)
                num5 = num3;
            return Convert.ToByte(((num4 + num5)/2f));
        }

        public void doStuff()
        {
            ScreenZones = DxScreenCapture.Calculate(ScreenZones);
            //ScreenZones = GDI.Get(ScreenZones);

            foreach (ScreenZone screenZone in ScreenZones)
            {
                if (screenZone.Color != null && screenZone.LightNames.Count > 0)
                {
                    var colorBrightness = ((Color) screenZone.Color).GetBrightness();
                    double convertedMaxGrightness  = (Convert.ToDouble(MaxBrightness) / 100);
                    double brightness = colorBrightness*convertedMaxGrightness;
                    if (brightness > 0.05 || !TurnOffLights)
                    {
                        byte brightnessbyte = Convert.ToByte(brightness*255);
                        foreach (string lightName in screenZone.LightNames)
                        {
                            new LightStateBuilder()
                                .For(Lights[lightName])
                                // Specifies one or more lights which this new state is for
                                // Or .For(lights, 1, 3)
                                .TurnOn() // Turns on the light(s)
                                .Color((Color) screenZone.Color) // Sets the color temperature to 6500K
                                .Brightness(brightnessbyte) // Set the brightness to maximum
                                .TransitionTime(3)
                                .Apply();
                        }
                    }
                    else
                    {
                        foreach (string lightName in screenZone.LightNames)
                        {
                            new LightStateBuilder()
                                .For(Lights[lightName])
                                // Specifies one or more lights which this new state is for
                                // Or .For(lights, 1, 3)
                                .TurnOff() // Turns on the light(s)
                                .TransitionTime(3)
                                .Apply();
                        }
                    }
                }
            }
        }
    }
}