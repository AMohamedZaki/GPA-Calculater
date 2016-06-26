using System;
using System.DirectoryServices;
using System.Drawing;
using System.Windows.Forms;
using Calculator.Forms.GPA;
using Calculator.Forms.Options;
using Calculator.Lib;
using Calculator.Properties;

namespace Calculator.Forms
{
    public partial class Welcome : Form
    {
        public void Welcome_Load(object sender , EventArgs e)
        {
            Datelab.Text = DateTime.Now.Year.ToString();
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
            UserNametxt.Text = "Hi" + " "+ de.Properties["fullName"].Value ;
            }
            catch (Exception)
            {
                UserNametxt.Text = " ";
                //throw;
            }     

            BackColor = Settings.Default.BgColorSet;

            toolTip.SetToolTip(ColorPiker , "Background Color ");
            toolTip.SetToolTip(OptionImg , "Setting");
            toolTip.SetToolTip(UserNametxt , "Your Name In Your Pc");
            toolTip.SetToolTip(GPA_Calc, "Calculate GPA");
            toolTip.SetToolTip(facebookimg , "Facebook");
            toolTip.SetToolTip(Githubimg , "Project Source Code (GitHub)");
           // toolTip.SetToolTip(C_GPA, "Calculate Your GPA using Your Subject");
            GpaHelper.ConvertTheSameColor(label1, Settings.Default.BgColorSet , Color.Black);

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
            GpaHelper.ConvertTheSameColor(label1, Settings.Default.BgColorSet, Color.Black);
        }

 
        //restart
        #region restart
        //    private void button4_Click(object sender, EventArgs e)
        //{
        //    System.Diagnostics.Process.Start(Application.ExecutablePath); // to start new instance of application
        //    Close();
        //}
        #endregion

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

      
    }
}
