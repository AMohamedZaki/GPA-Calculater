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
        private int _count = 0;

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
            timer1.Start();
            

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
            BackColor = Settings.Default.BgColorSet;
            Show();
        }

       private void GPA_Calc_Click(object sender, EventArgs e)
        {
            if (Settings.Default.GPA_Id == 0)
            {
                MessageBox.Show(
                    @"You Remove You Default GPA Please Select New One As Default To be able to Calculate Your GPA",
                    @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 return;
            }
            PleaseWait.ShowSplashScreen();
            var mainForm = new Calac(); //this takes ages
            mainForm.Show();
            PleaseWait.CloseForm(); 
            Hide();
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
            UserNametxt.ForeColor = Settings.Default.FBgColorSet;
            GpaCalcLab.ForeColor = Settings.Default.FBgColorSet;

        }

        private void Welcome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
             
            _count ++;
            if (_count == 20)
            {
                timer1.Stop();
                LeftArrowImg.Hide();
                return;
            }

            if (_count%2 == 0)
              LeftArrowImg.Location = new Point(LeftArrowImg.Location.X + 2 , 170); 
            

            if (_count % 2 == 1)
                LeftArrowImg.Location = new Point(LeftArrowImg.Location.X - 2, 170);

            // _count%2 == 0 ? LeftArrowImg.Location.X += 1 : LeftArrowImg.Location.X -= 1;


        }
    }
}
