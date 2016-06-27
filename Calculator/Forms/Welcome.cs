using System;
using System.DirectoryServices;
using System.Drawing;
using System.Windows.Forms;
using Calculator.Forms.GPA;
using Calculator.Forms.Options;
using Calculator.Lib;
using Calculator.Properties;
using System.Diagnostics;

namespace Calculator.Forms
{
    public partial class Welcome : Form
    {
        public void Welcome_Load(object sender , EventArgs e)
        {
            Datelab.Text = @"Mn3M Copyright Version 2.0.0 © " + DateTime.Now.Year;
        }

        public Welcome()
        {
            InitializeComponent();
            try
            {
            UserNametxt.Text = "";
            var de = new DirectoryEntry("WinNT://" +
                              Environment.UserDomainName + "/" +
                              Environment.UserName);
            UserNametxt.Text = @"Hi" + @" "+ de.Properties["fullName"].Value ;
            }
            catch (Exception)
            {
                UserNametxt.Text = @" ";
                //throw;
            }     

            this.BackColor = Settings.Default.BgColorSet;

            toolTip.SetToolTip(ColorPiker , "Background Color ");
            toolTip.SetToolTip(OptionImg , "Setting");
            toolTip.SetToolTip(fontImg, "Font Color ");
            toolTip.SetToolTip(UserNametxt , "Your Name In Your Pc");
            toolTip.SetToolTip(GPA_Calc, "Calculate GPA");
            toolTip.SetToolTip(facebookimg , "Facebook");
            toolTip.SetToolTip(Githubimg , "Project Source Code (GitHub)");
            // toolTip.SetToolTip(C_GPA, "Calculate Your GPA using Your Subject");
          

        }

        private void ColorPiker_Click(object sender, EventArgs e)
        {
            var colorDialog = new ColorDialog
            {
            AllowFullOpen = true,
            AnyColor = true,
            Color = Settings.Default.BgColorSet,
            FullOpen = false,
            ShowHelp = false,
            SolidColorOnly =false
            };

            if (colorDialog.ShowDialog() == DialogResult.OK)
            Settings.Default.BgColorSet = colorDialog.Color;
            Settings.Default.Save();
            BackColor = Settings.Default.BgColorSet;
            colorDialog.Dispose();
          // Settings.Default.FBgColorSet = GpaHelper.ConvertTheSameColor(Settings.Default.BgColorSet);
            //panel1.BackColor = ControlPaint.LightLight(Settings.Default.BgColorSet);
        }

        private void OptionImg_Click(object sender, EventArgs e)
        {
            Hide();
            new Option().ShowDialog();
            Show();
        }

        private void GPA_Calc_Click(object sender, EventArgs e)
        {
            Hide();
            new Calac().ShowDialog();
            Show();
        }

        private void Githubimg_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/AMohamedZaki/GPA-Calculater/");
        }

        private void facebookimg_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/n3n2mohamed");
        }

        private void fontImg_Click(object sender, EventArgs e)
        {
            var colorDialog = new ColorDialog
            {
                AllowFullOpen = true,
                AnyColor = true,
                Color = Settings.Default.BgColorSet,
                FullOpen = false,
                ShowHelp = false,
                SolidColorOnly = false
            };


            if (colorDialog.ShowDialog() == DialogResult.OK)
                Settings.Default.FBgColorSet = colorDialog.Color;
            Settings.Default.Save();

            colorDialog.Dispose();
            GpaName.ForeColor = Settings.Default.FBgColorSet;
            Datelab.ForeColor = Settings.Default.FBgColorSet;

        }

       
    }
}
