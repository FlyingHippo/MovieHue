using System;
using System.Linq;
using System.Windows.Forms;
using SharpHue;

namespace MovieHue.GUI
{
    public partial class FormMain : Form
    {
        public MovieHue.Logic.Logic Logic { get; set; }
        
        public FormMain()
        {
            Logic=new Logic.Logic();
            InitializeComponent();
            setValues();
        }

        private void setValues()
        {
            sliderMaxBrightness.Value = Logic.MaxBrightness;
            sliderBlackThreshold.Value = Logic.MinBrightness;

            ddlTopLeftZone.Items.Add(new ComboBoxItem("-1","(Not used)"));
            ddlTopZone.Items.Add(new ComboBoxItem("-1", "(Not used)"));
            ddlTopRightZone.Items.Add(new ComboBoxItem("-1", "(Not used)"));
            ddlRightZone.Items.Add(new ComboBoxItem("-1", "(Not used)"));
            ddlBottomRightZone.Items.Add(new ComboBoxItem("-1", "(Not used)"));
            ddlBottomZone.Items.Add(new ComboBoxItem("-1", "(Not used)"));
            ddlBottomLeftZone.Items.Add(new ComboBoxItem("-1", "(Not used)"));
            ddlLeftZone.Items.Add(new ComboBoxItem("-1", "(Not used)"));
            
            foreach (Light light in Logic.Lights)
            {
                ddlTopLeftZone.Items.Add(new ComboBoxItem(light.ID.ToString(),light.Name));
                ddlTopZone.Items.Add(new ComboBoxItem(light.ID.ToString(), light.Name));
                ddlTopRightZone.Items.Add(new ComboBoxItem(light.ID.ToString(), light.Name));
                ddlRightZone.Items.Add(new ComboBoxItem(light.ID.ToString(), light.Name));
                ddlBottomRightZone.Items.Add(new ComboBoxItem(light.ID.ToString(), light.Name));
                ddlBottomZone.Items.Add(new ComboBoxItem(light.ID.ToString(), light.Name));
                ddlBottomLeftZone.Items.Add(new ComboBoxItem(light.ID.ToString(), light.Name));
                ddlLeftZone.Items.Add(new ComboBoxItem(light.ID.ToString(), light.Name));
            }

            ddlTopLeftZone.SelectedIndex = 0;
            ddlTopZone.SelectedIndex = 0;
            ddlTopRightZone.SelectedIndex = 0;
            ddlRightZone.SelectedIndex = 0;
            ddlBottomRightZone.SelectedIndex = 0;
            ddlBottomZone.SelectedIndex = 0;
            ddlBottomLeftZone.SelectedIndex = 0;
            ddlLeftZone.SelectedIndex = 0;
        }

        private void sliderMaxBrightness_ValueChanged(object sender, EventArgs e)
        {
            lblMaxBrightnessValue.Text = sliderMaxBrightness.Value.ToString();
            Logic.MaxBrightness = sliderMaxBrightness.Value;
        }

        private void sliderBlackThreshold_ValueChanged(object sender, EventArgs e)
        {
            lblThresholdValue.Text = sliderBlackThreshold.Value.ToString();
            Logic.MinBrightness= sliderBlackThreshold.Value;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Logic.doStuff();
        }

        private void ddlTopLeftZone_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = ((ComboBoxItem) ((ComboBox) sender).SelectedItem);
            if (selectedItem.Value.Equals("-1"))
            {
                Logic.ScreenZones.First(x => x.Name.Equals("Top left")).LightNames.Clear();    
            }
            else
            {
                Logic.ScreenZones.First(x => x.Name.Equals(".Clear()")).LightNames.Clear();
                Logic.ScreenZones.First(x => x.Name.Equals(".Clear()")).LightNames.Add(selectedItem.Text);    
            }
        }

        private void ddlTopZone_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = ((ComboBoxItem)((ComboBox)sender).SelectedItem);
            if (selectedItem.Value.Equals("-1"))
            {
                Logic.ScreenZones.First(x => x.Name.Equals("Top")).LightNames.Clear();
            }
            else
            {
                Logic.ScreenZones.First(x => x.Name.Equals("Top")).LightNames.Clear();
                Logic.ScreenZones.First(x => x.Name.Equals("Top")).LightNames.Add(selectedItem.Text);
            }
        }

        private void ddlTopRightZone_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = ((ComboBoxItem)((ComboBox)sender).SelectedItem);
            if (selectedItem.Value.Equals("-1"))
            {
                Logic.ScreenZones.First(x => x.Name.Equals("Top right")).LightNames.Clear();
            }
            else
            {
                Logic.ScreenZones.First(x => x.Name.Equals("Top right")).LightNames.Clear();
                Logic.ScreenZones.First(x => x.Name.Equals("Top right")).LightNames.Add(selectedItem.Text);
            }
        }

        private void ddlRightZone_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = ((ComboBoxItem)((ComboBox)sender).SelectedItem);
            if (selectedItem.Value.Equals("-1"))
            {
                Logic.ScreenZones.First(x => x.Name.Equals("Right")).LightNames.Clear();
            }
            else
            {
                Logic.ScreenZones.First(x => x.Name.Equals("Right")).LightNames.Clear();
                Logic.ScreenZones.First(x => x.Name.Equals("Right")).LightNames.Add(selectedItem.Text);
            }
        }

        private void ddlBottomRightZone_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = ((ComboBoxItem)((ComboBox)sender).SelectedItem);
            if (selectedItem.Value.Equals("-1"))
            {
                Logic.ScreenZones.First(x => x.Name.Equals("Bottom right")).LightNames.Clear();
            }
            else
            {
                Logic.ScreenZones.First(x => x.Name.Equals("Bottom right")).LightNames.Clear();
                Logic.ScreenZones.First(x => x.Name.Equals("Bottom right")).LightNames.Add(selectedItem.Text);
            }
        }

        private void ddlBottomZone_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = ((ComboBoxItem)((ComboBox)sender).SelectedItem);
            if (selectedItem.Value.Equals("-1"))
            {
                Logic.ScreenZones.First(x => x.Name.Equals("Bottom")).LightNames.Clear();
            }
            else
            {
                Logic.ScreenZones.First(x => x.Name.Equals("Bottom")).LightNames.Clear();
                Logic.ScreenZones.First(x => x.Name.Equals("Bottom")).LightNames.Add(selectedItem.Text);
            }
        }

        private void ddlBottomLeftZone_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = ((ComboBoxItem)((ComboBox)sender).SelectedItem);
            if (selectedItem.Value.Equals("-1"))
            {
                Logic.ScreenZones.First(x => x.Name.Equals("Bottom left")).LightNames.Clear();
            }
            else
            {
                Logic.ScreenZones.First(x => x.Name.Equals("Bottom left")).LightNames.Clear();
                Logic.ScreenZones.First(x => x.Name.Equals("Bottom left")).LightNames.Add(selectedItem.Text);
            }
        }

        private void ddlLeftZone_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = ((ComboBoxItem)((ComboBox)sender).SelectedItem);
            if (selectedItem.Value.Equals("-1"))
            {
                Logic.ScreenZones.First(x => x.Name.Equals("Left")).LightNames.Clear();
            }
            else
            {
                Logic.ScreenZones.First(x => x.Name.Equals("Left")).LightNames.Clear();
                Logic.ScreenZones.First(x => x.Name.Equals("Left")).LightNames.Add(selectedItem.Text);
            }
        }

        private void chkAutoTurnOff_CheckedChanged(object sender, EventArgs e)
        {
            Logic.TurnOffLights = chkAutoTurnOff.Checked;
        }
    }
}
