using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;

namespace MovieHue.Logic
{
    public class GDI
    {
        public static List<ScreenZone> Get(List<ScreenZone> ScreenZones)
        {
            var sc = new ScreenCapture();
            Image image = sc.CaptureScreen();


            var sections = new List<Section>();
            sections.Add(new Section
                             {
                                 Name = "Top",
                                 Width = image.Width,
                                 Height = Convert.ToInt32(image.Height*0.1d),
                                 X = 0,
                                 Y = 0,
                                 Bitmap = new Bitmap(image.Width, Convert.ToInt32(image.Height*0.1d)),
                             });
            sections.Add(new Section
                             {
                                 Name = "Left",
                                 Width = Convert.ToInt32(image.Width*0.1d),
                                 Height = image.Height,
                                 X = 0,
                                 Y = 0,
                                 Bitmap = new Bitmap(Convert.ToInt32(image.Width*0.1d), image.Height)
                             });
            sections.Add(new Section
                             {
                                 Name = "Right",
                                 Width = Convert.ToInt32(image.Width*0.1d),
                                 Height = image.Height,
                                 X = image.Width - Convert.ToInt32(image.Width*0.1d),
                                 Y = 0,
                                 Bitmap = new Bitmap(Convert.ToInt32(image.Width*0.1d), image.Height),
                             });
            sections.Add(new Section
                             {
                                 Name = "Bottom",
                                 Width = image.Width,
                                 Height = Convert.ToInt32(image.Height*0.1d),
                                 X = 0,
                                 Y = image.Height - Convert.ToInt32(image.Height*0.1d),
                                 Bitmap = new Bitmap(image.Width, Convert.ToInt32(image.Height*0.1d))
                             });

            foreach (Section section in sections)
            {
                var bm = new Bitmap(sc.CaptureScreen(section));
                bm.Dispose();
                bm = null;

                section.Bitmap = new Bitmap(sc.CaptureScreen(section));
                section.Bitmap.Save(section.Name + ".bmp");

                using (var bmp = new Bitmap(1, 1))
                {
                    using (Graphics g = Graphics.FromImage(bmp))
                    {
                        // updated: the Interpolation mode needs to be set to 
                        // HighQualityBilinear or HighQualityBicubic or this method
                        // doesn't work at all.  With either setting, the results are
                        // slightly different from the averaging method.
                        g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                        g.DrawImage(section.Bitmap, new Rectangle(0, 0, 1, 1));
                    }
                    Color pixel = bmp.GetPixel(0, 0);
                    // pixel will contain average values for entire orig Bitmap
                    section.AvgRed = pixel.R;
                    section.AvgBlue = pixel.B;
                    section.AvgGreen = pixel.G;
                    //section.Dispose();
                }
            }
        

            foreach (ScreenZone screenZone in ScreenZones)
            {
                Section tempScetion = sections.Where(x => x.Name.Equals(screenZone.Name)).Select(x => x).FirstOrDefault();
                if (tempScetion != null)
                {
                    screenZone.Color = Color.FromArgb(tempScetion.AvgRed, tempScetion.AvgGreen, tempScetion.AvgBlue);
                }
            }
            
            sc = null;
            sections = null;
            image.Dispose();
            image = null;
            GC.Collect();

            GC.WaitForPendingFinalizers();

            return ScreenZones;
        }
    }
}