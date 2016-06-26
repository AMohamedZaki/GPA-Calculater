using System;
using System.Linq;
using System.Windows.Forms;
using Calculator.Forms.GPA;
using Calculator.Lib;
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
        }

        private void Option_Load(object sender, EventArgs e)
        {
            var data = _db.Gpas.ToList();
            cbDegree.DataSource = data;
            cbDegree.DisplayMember = "Name";
            cbDegree.ValueMember = "Id";
            cbDegree.SelectedIndex = data.FindIndex(item => item.Id == Settings.Default.GPA_Id);
        }

        private void GBAbtn_Click_1(object sender, EventArgs e)
        {
            Hide();
            new CreateGpa().ShowDialog();
            Close();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            Hide();
            new EditGpa().ShowDialog();
            Close();
        }

        private void cbDegree_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbDegree.ValueMember == "" || cbDegree.DisplayMember == "") return;
                Settings.Default.GPA_Id = Convert.ToInt32(cbDegree.SelectedValue);
                DoneImg.Visible = true;
            }
            catch(Exception ex)
            {
                RemoveImg.Visible = true;
                MessageBox.Show(ex.Message);

            }

        }
    }
}
