using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Calculator.Forms.GPA;
using Calculator.Model;
using Calculator.Properties;

namespace Calculator.Forms.Options
{
    public partial class Option : Form
    {
        private GPA_DBEntities _db;
        public Option()
        {
            InitializeComponent();
            _db= new GPA_DBEntities();
            DropDawn();

        }

        private void Option_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(BackImg, "Back");
            toolTip1.SetToolTip(RemoveImg, "Yoy didn't Choose You Default GPA");

            if (Settings.Default.GPA_Id == 0 )
                RemoveImg.Visible = true;
        }

        private void GBAbtn_Click_1(object sender, EventArgs e)
        {
            Hide();
            new CreateGpa().ShowDialog();
            DropDawn();
            Show();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            Hide();
            new EditGpa().ShowDialog();
            _db = new GPA_DBEntities();
            DropDawn();
            Show();
        }

        private void cbDegree_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbDegree.ValueMember == "" || cbDegree.DisplayMember == "") return;
                Settings.Default.GPA_Id = Convert.ToInt32(cbDegree.SelectedValue);
                Settings.Default.Save();
                DoneImg.Visible = true;
                RemoveImg.Visible = false;
            }
            catch(Exception ex)
            {
                RemoveImg.Visible = true;
                MessageBox.Show(ex.Message);
            }
        }

        
        private void BackImg_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Restorebtn_Click(object sender, EventArgs e)
        {
            Settings.Default.BgColorSet = Color.FromArgb(37, 148, 233);
            Settings.Default.Save();
            BackColor = Settings.Default.BgColorSet;
        }

        private void DropDawn()
        {
            cbDegree.ValueMember = "";
            cbDegree.DisplayMember = "";
            cbDegree.DataSource = null;
            var data = _db.Gpas.ToList();
            cbDegree.DataSource = data;
            if (Settings.Default.GPA_Id != 0)
                cbDegree.SelectedIndex = data.FindIndex(item => item.Id == Settings.Default.GPA_Id);
       
            cbDegree.DisplayMember = "Name";
            cbDegree.ValueMember = "Id";
            RemoveImg.Visible = false;
            DoneImg.Visible = false;
        }
    }
}
