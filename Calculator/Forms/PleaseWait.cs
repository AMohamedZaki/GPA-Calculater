using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator.Forms
{
    //referance http://stackoverflow.com/questions/15836027/c-sharp-winform-loading-screen
    public partial class PleaseWait : Form
    {
        public PleaseWait()
        {
            InitializeComponent();
        }

        private void PleaseWait_Load(object sender, EventArgs e)
        {

        }
        private delegate void CloseDelegate();

        private static PleaseWait _splashForm;

        static public void ShowSplashScreen()
        {
            // Make sure it is only launched once.

            if (_splashForm != null)
                return;
            var thread = new Thread(ShowForm) { IsBackground = true };
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        static private void ShowForm()
        {
            _splashForm = new PleaseWait();
            Application.Run(_splashForm);
        }

        static public void CloseForm()
        {
            _splashForm.Invoke(new CloseDelegate(CloseFormInternal));
        }

        static private void CloseFormInternal()
        {
            _splashForm.Close();
            _splashForm = null;
        }

        private void PleaseWaitLab_Click(object sender, EventArgs e)
        {

        }
    }
}
