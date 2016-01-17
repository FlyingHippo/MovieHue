namespace MovieHue.GUI
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.tabOptions = new System.Windows.Forms.TabPage();
            this.tabSetup = new System.Windows.Forms.TabPage();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ddlTopLeftZone = new System.Windows.Forms.ComboBox();
            this.lblDdlTopLeftZone = new System.Windows.Forms.Label();
            this.lblDdlLeftZone = new System.Windows.Forms.Label();
            this.ddlLeftZone = new System.Windows.Forms.ComboBox();
            this.lblDdlbottomLeftZone = new System.Windows.Forms.Label();
            this.ddlBottomLeftZone = new System.Windows.Forms.ComboBox();
            this.lblDdlBottomZone = new System.Windows.Forms.Label();
            this.ddlBottomZone = new System.Windows.Forms.ComboBox();
            this.lblDdlTopZone = new System.Windows.Forms.Label();
            this.ddlTopZone = new System.Windows.Forms.ComboBox();
            this.lblDdlTopRightZone = new System.Windows.Forms.Label();
            this.ddlTopRightZone = new System.Windows.Forms.ComboBox();
            this.lblDdlRightZone = new System.Windows.Forms.Label();
            this.ddlRightZone = new System.Windows.Forms.ComboBox();
            this.lblDdlBottomRightZone = new System.Windows.Forms.Label();
            this.ddlBottomRightZone = new System.Windows.Forms.ComboBox();
            this.lblThresholdValue = new System.Windows.Forms.Label();
            this.lblTurnOffThreshold = new System.Windows.Forms.Label();
            this.sliderBlackThreshold = new System.Windows.Forms.TrackBar();
            this.chkAutoTurnOff = new System.Windows.Forms.CheckBox();
            this.lblMaxBrightnessValue = new System.Windows.Forms.Label();
            this.lblMaxBrughtness = new System.Windows.Forms.Label();
            this.sliderMaxBrightness = new System.Windows.Forms.TrackBar();
            this.tabControlMain.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabOptions.SuspendLayout();
            this.tabSetup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderBlackThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderMaxBrightness)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(43, 54);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(130, 52);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(255, 54);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(130, 52);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabMain);
            this.tabControlMain.Controls.Add(this.tabOptions);
            this.tabControlMain.Controls.Add(this.tabSetup);
            this.tabControlMain.Location = new System.Drawing.Point(12, 12);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(428, 185);
            this.tabControlMain.TabIndex = 2;
            // 
            // tabMain
            // 
            this.tabMain.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabMain.Controls.Add(this.btnStart);
            this.tabMain.Controls.Add(this.btnStop);
            this.tabMain.Location = new System.Drawing.Point(4, 22);
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabMain.Size = new System.Drawing.Size(420, 159);
            this.tabMain.TabIndex = 0;
            this.tabMain.Text = "Main";
            // 
            // tabOptions
            // 
            this.tabOptions.Controls.Add(this.lblThresholdValue);
            this.tabOptions.Controls.Add(this.lblTurnOffThreshold);
            this.tabOptions.Controls.Add(this.sliderBlackThreshold);
            this.tabOptions.Controls.Add(this.chkAutoTurnOff);
            this.tabOptions.Controls.Add(this.lblMaxBrightnessValue);
            this.tabOptions.Controls.Add(this.lblMaxBrughtness);
            this.tabOptions.Controls.Add(this.sliderMaxBrightness);
            this.tabOptions.Location = new System.Drawing.Point(4, 22);
            this.tabOptions.Name = "tabOptions";
            this.tabOptions.Padding = new System.Windows.Forms.Padding(3);
            this.tabOptions.Size = new System.Drawing.Size(420, 159);
            this.tabOptions.TabIndex = 1;
            this.tabOptions.Text = "Options";
            this.tabOptions.UseVisualStyleBackColor = true;
            // 
            // tabSetup
            // 
            this.tabSetup.Controls.Add(this.lblDdlBottomRightZone);
            this.tabSetup.Controls.Add(this.ddlBottomRightZone);
            this.tabSetup.Controls.Add(this.lblDdlRightZone);
            this.tabSetup.Controls.Add(this.ddlRightZone);
            this.tabSetup.Controls.Add(this.lblDdlTopRightZone);
            this.tabSetup.Controls.Add(this.ddlTopRightZone);
            this.tabSetup.Controls.Add(this.lblDdlTopZone);
            this.tabSetup.Controls.Add(this.ddlTopZone);
            this.tabSetup.Controls.Add(this.lblDdlBottomZone);
            this.tabSetup.Controls.Add(this.ddlBottomZone);
            this.tabSetup.Controls.Add(this.lblDdlbottomLeftZone);
            this.tabSetup.Controls.Add(this.ddlBottomLeftZone);
            this.tabSetup.Controls.Add(this.lblDdlLeftZone);
            this.tabSetup.Controls.Add(this.ddlLeftZone);
            this.tabSetup.Controls.Add(this.lblDdlTopLeftZone);
            this.tabSetup.Controls.Add(this.ddlTopLeftZone);
            this.tabSetup.Location = new System.Drawing.Point(4, 22);
            this.tabSetup.Name = "tabSetup";
            this.tabSetup.Size = new System.Drawing.Size(420, 159);
            this.tabSetup.TabIndex = 2;
            this.tabSetup.Text = "Setup";
            this.tabSetup.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ddlTopLeftZone
            // 
            this.ddlTopLeftZone.FormattingEnabled = true;
            this.ddlTopLeftZone.Location = new System.Drawing.Point(6, 27);
            this.ddlTopLeftZone.Name = "ddlTopLeftZone";
            this.ddlTopLeftZone.Size = new System.Drawing.Size(121, 21);
            this.ddlTopLeftZone.TabIndex = 0;
            this.ddlTopLeftZone.SelectedIndexChanged += new System.EventHandler(this.ddlTopLeftZone_SelectedIndexChanged);
            // 
            // lblDdlTopLeftZone
            // 
            this.lblDdlTopLeftZone.AutoSize = true;
            this.lblDdlTopLeftZone.Location = new System.Drawing.Point(3, 11);
            this.lblDdlTopLeftZone.Name = "lblDdlTopLeftZone";
            this.lblDdlTopLeftZone.Size = new System.Drawing.Size(43, 13);
            this.lblDdlTopLeftZone.TabIndex = 1;
            this.lblDdlTopLeftZone.Text = "Top left";
            // 
            // lblDdlLeftZone
            // 
            this.lblDdlLeftZone.AutoSize = true;
            this.lblDdlLeftZone.Location = new System.Drawing.Point(3, 63);
            this.lblDdlLeftZone.Name = "lblDdlLeftZone";
            this.lblDdlLeftZone.Size = new System.Drawing.Size(25, 13);
            this.lblDdlLeftZone.TabIndex = 3;
            this.lblDdlLeftZone.Text = "Left";
            // 
            // ddlLeftZone
            // 
            this.ddlLeftZone.FormattingEnabled = true;
            this.ddlLeftZone.Location = new System.Drawing.Point(6, 79);
            this.ddlLeftZone.Name = "ddlLeftZone";
            this.ddlLeftZone.Size = new System.Drawing.Size(121, 21);
            this.ddlLeftZone.TabIndex = 2;
            this.ddlLeftZone.SelectedIndexChanged += new System.EventHandler(this.ddlLeftZone_SelectedIndexChanged);
            // 
            // lblDdlbottomLeftZone
            // 
            this.lblDdlbottomLeftZone.AutoSize = true;
            this.lblDdlbottomLeftZone.Location = new System.Drawing.Point(3, 112);
            this.lblDdlbottomLeftZone.Name = "lblDdlbottomLeftZone";
            this.lblDdlbottomLeftZone.Size = new System.Drawing.Size(57, 13);
            this.lblDdlbottomLeftZone.TabIndex = 5;
            this.lblDdlbottomLeftZone.Text = "Bottom left";
            // 
            // ddlBottomLeftZone
            // 
            this.ddlBottomLeftZone.FormattingEnabled = true;
            this.ddlBottomLeftZone.Location = new System.Drawing.Point(6, 128);
            this.ddlBottomLeftZone.Name = "ddlBottomLeftZone";
            this.ddlBottomLeftZone.Size = new System.Drawing.Size(121, 21);
            this.ddlBottomLeftZone.TabIndex = 4;
            this.ddlBottomLeftZone.SelectedIndexChanged += new System.EventHandler(this.ddlBottomLeftZone_SelectedIndexChanged);
            // 
            // lblDdlBottomZone
            // 
            this.lblDdlBottomZone.AutoSize = true;
            this.lblDdlBottomZone.Location = new System.Drawing.Point(144, 112);
            this.lblDdlBottomZone.Name = "lblDdlBottomZone";
            this.lblDdlBottomZone.Size = new System.Drawing.Size(40, 13);
            this.lblDdlBottomZone.TabIndex = 7;
            this.lblDdlBottomZone.Text = "Bottom";
            // 
            // ddlBottomZone
            // 
            this.ddlBottomZone.FormattingEnabled = true;
            this.ddlBottomZone.Location = new System.Drawing.Point(147, 128);
            this.ddlBottomZone.Name = "ddlBottomZone";
            this.ddlBottomZone.Size = new System.Drawing.Size(121, 21);
            this.ddlBottomZone.TabIndex = 6;
            this.ddlBottomZone.SelectedIndexChanged += new System.EventHandler(this.ddlBottomZone_SelectedIndexChanged);
            // 
            // lblDdlTopZone
            // 
            this.lblDdlTopZone.AutoSize = true;
            this.lblDdlTopZone.Location = new System.Drawing.Point(144, 11);
            this.lblDdlTopZone.Name = "lblDdlTopZone";
            this.lblDdlTopZone.Size = new System.Drawing.Size(29, 13);
            this.lblDdlTopZone.TabIndex = 9;
            this.lblDdlTopZone.Text = "Top ";
            // 
            // ddlTopZone
            // 
            this.ddlTopZone.FormattingEnabled = true;
            this.ddlTopZone.Location = new System.Drawing.Point(147, 27);
            this.ddlTopZone.Name = "ddlTopZone";
            this.ddlTopZone.Size = new System.Drawing.Size(121, 21);
            this.ddlTopZone.TabIndex = 8;
            this.ddlTopZone.SelectedIndexChanged += new System.EventHandler(this.ddlTopZone_SelectedIndexChanged);
            // 
            // lblDdlTopRightZone
            // 
            this.lblDdlTopRightZone.AutoSize = true;
            this.lblDdlTopRightZone.Location = new System.Drawing.Point(286, 11);
            this.lblDdlTopRightZone.Name = "lblDdlTopRightZone";
            this.lblDdlTopRightZone.Size = new System.Drawing.Size(49, 13);
            this.lblDdlTopRightZone.TabIndex = 11;
            this.lblDdlTopRightZone.Text = "Top right";
            // 
            // ddlTopRightZone
            // 
            this.ddlTopRightZone.FormattingEnabled = true;
            this.ddlTopRightZone.Location = new System.Drawing.Point(289, 27);
            this.ddlTopRightZone.Name = "ddlTopRightZone";
            this.ddlTopRightZone.Size = new System.Drawing.Size(121, 21);
            this.ddlTopRightZone.TabIndex = 10;
            this.ddlTopRightZone.SelectedIndexChanged += new System.EventHandler(this.ddlTopRightZone_SelectedIndexChanged);
            // 
            // lblDdlRightZone
            // 
            this.lblDdlRightZone.AutoSize = true;
            this.lblDdlRightZone.Location = new System.Drawing.Point(286, 63);
            this.lblDdlRightZone.Name = "lblDdlRightZone";
            this.lblDdlRightZone.Size = new System.Drawing.Size(32, 13);
            this.lblDdlRightZone.TabIndex = 13;
            this.lblDdlRightZone.Text = "Right";
            // 
            // ddlRightZone
            // 
            this.ddlRightZone.FormattingEnabled = true;
            this.ddlRightZone.Location = new System.Drawing.Point(289, 79);
            this.ddlRightZone.Name = "ddlRightZone";
            this.ddlRightZone.Size = new System.Drawing.Size(121, 21);
            this.ddlRightZone.TabIndex = 12;
            this.ddlRightZone.SelectedIndexChanged += new System.EventHandler(this.ddlRightZone_SelectedIndexChanged);
            // 
            // lblDdlBottomRightZone
            // 
            this.lblDdlBottomRightZone.AutoSize = true;
            this.lblDdlBottomRightZone.Location = new System.Drawing.Point(286, 112);
            this.lblDdlBottomRightZone.Name = "lblDdlBottomRightZone";
            this.lblDdlBottomRightZone.Size = new System.Drawing.Size(63, 13);
            this.lblDdlBottomRightZone.TabIndex = 15;
            this.lblDdlBottomRightZone.Text = "Bottom right";
            // 
            // ddlBottomRightZone
            // 
            this.ddlBottomRightZone.FormattingEnabled = true;
            this.ddlBottomRightZone.Location = new System.Drawing.Point(289, 128);
            this.ddlBottomRightZone.Name = "ddlBottomRightZone";
            this.ddlBottomRightZone.Size = new System.Drawing.Size(121, 21);
            this.ddlBottomRightZone.TabIndex = 14;
            this.ddlBottomRightZone.SelectedIndexChanged += new System.EventHandler(this.ddlBottomRightZone_SelectedIndexChanged);
            // 
            // lblThresholdValue
            // 
            this.lblThresholdValue.AutoSize = true;
            this.lblThresholdValue.Location = new System.Drawing.Point(333, 105);
            this.lblThresholdValue.Name = "lblThresholdValue";
            this.lblThresholdValue.Size = new System.Drawing.Size(13, 13);
            this.lblThresholdValue.TabIndex = 15;
            this.lblThresholdValue.Text = "0";
            // 
            // lblTurnOffThreshold
            // 
            this.lblTurnOffThreshold.AutoSize = true;
            this.lblTurnOffThreshold.Location = new System.Drawing.Point(6, 105);
            this.lblTurnOffThreshold.Name = "lblTurnOffThreshold";
            this.lblTurnOffThreshold.Size = new System.Drawing.Size(80, 13);
            this.lblTurnOffThreshold.TabIndex = 14;
            this.lblTurnOffThreshold.Text = "Black threshold";
            // 
            // sliderBlackThreshold
            // 
            this.sliderBlackThreshold.BackColor = System.Drawing.SystemColors.ControlDark;
            this.sliderBlackThreshold.Location = new System.Drawing.Point(115, 92);
            this.sliderBlackThreshold.Maximum = 100;
            this.sliderBlackThreshold.Name = "sliderBlackThreshold";
            this.sliderBlackThreshold.Size = new System.Drawing.Size(212, 45);
            this.sliderBlackThreshold.TabIndex = 13;
            this.sliderBlackThreshold.TickFrequency = 5;
            this.sliderBlackThreshold.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.sliderBlackThreshold.ValueChanged += new System.EventHandler(this.sliderBlackThreshold_ValueChanged);
            // 
            // chkAutoTurnOff
            // 
            this.chkAutoTurnOff.AutoSize = true;
            this.chkAutoTurnOff.Location = new System.Drawing.Point(9, 64);
            this.chkAutoTurnOff.Name = "chkAutoTurnOff";
            this.chkAutoTurnOff.Size = new System.Drawing.Size(184, 17);
            this.chkAutoTurnOff.TabIndex = 12;
            this.chkAutoTurnOff.Text = "Turn off lights when zone is black";
            this.chkAutoTurnOff.UseVisualStyleBackColor = true;
            this.chkAutoTurnOff.CheckedChanged += new System.EventHandler(this.chkAutoTurnOff_CheckedChanged);
            // 
            // lblMaxBrightnessValue
            // 
            this.lblMaxBrightnessValue.AutoSize = true;
            this.lblMaxBrightnessValue.Location = new System.Drawing.Point(333, 26);
            this.lblMaxBrightnessValue.Name = "lblMaxBrightnessValue";
            this.lblMaxBrightnessValue.Size = new System.Drawing.Size(13, 13);
            this.lblMaxBrightnessValue.TabIndex = 11;
            this.lblMaxBrightnessValue.Text = "0";
            // 
            // lblMaxBrughtness
            // 
            this.lblMaxBrughtness.AutoSize = true;
            this.lblMaxBrughtness.Location = new System.Drawing.Point(6, 26);
            this.lblMaxBrughtness.Name = "lblMaxBrughtness";
            this.lblMaxBrughtness.Size = new System.Drawing.Size(103, 13);
            this.lblMaxBrughtness.TabIndex = 10;
            this.lblMaxBrughtness.Text = "Maximum Brightness";
            // 
            // sliderMaxBrightness
            // 
            this.sliderMaxBrightness.BackColor = System.Drawing.SystemColors.ControlDark;
            this.sliderMaxBrightness.Location = new System.Drawing.Point(115, 13);
            this.sliderMaxBrightness.Maximum = 100;
            this.sliderMaxBrightness.Name = "sliderMaxBrightness";
            this.sliderMaxBrightness.Size = new System.Drawing.Size(212, 45);
            this.sliderMaxBrightness.TabIndex = 9;
            this.sliderMaxBrightness.TickFrequency = 5;
            this.sliderMaxBrightness.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.sliderMaxBrightness.ValueChanged += new System.EventHandler(this.sliderMaxBrightness_ValueChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 208);
            this.Controls.Add(this.tabControlMain);
            this.Name = "FormMain";
            this.Text = "Main";
            this.tabControlMain.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabOptions.ResumeLayout(false);
            this.tabOptions.PerformLayout();
            this.tabSetup.ResumeLayout(false);
            this.tabSetup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderBlackThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderMaxBrightness)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabMain;
        private System.Windows.Forms.TabPage tabOptions;
        private System.Windows.Forms.TabPage tabSetup;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblThresholdValue;
        private System.Windows.Forms.Label lblTurnOffThreshold;
        private System.Windows.Forms.TrackBar sliderBlackThreshold;
        private System.Windows.Forms.CheckBox chkAutoTurnOff;
        private System.Windows.Forms.Label lblMaxBrightnessValue;
        private System.Windows.Forms.Label lblMaxBrughtness;
        private System.Windows.Forms.TrackBar sliderMaxBrightness;
        private System.Windows.Forms.Label lblDdlBottomRightZone;
        private System.Windows.Forms.ComboBox ddlBottomRightZone;
        private System.Windows.Forms.Label lblDdlRightZone;
        private System.Windows.Forms.ComboBox ddlRightZone;
        private System.Windows.Forms.Label lblDdlTopRightZone;
        private System.Windows.Forms.ComboBox ddlTopRightZone;
        private System.Windows.Forms.Label lblDdlTopZone;
        private System.Windows.Forms.ComboBox ddlTopZone;
        private System.Windows.Forms.Label lblDdlBottomZone;
        private System.Windows.Forms.ComboBox ddlBottomZone;
        private System.Windows.Forms.Label lblDdlbottomLeftZone;
        private System.Windows.Forms.ComboBox ddlBottomLeftZone;
        private System.Windows.Forms.Label lblDdlLeftZone;
        private System.Windows.Forms.ComboBox ddlLeftZone;
        private System.Windows.Forms.Label lblDdlTopLeftZone;
        private System.Windows.Forms.ComboBox ddlTopLeftZone;
    }
}