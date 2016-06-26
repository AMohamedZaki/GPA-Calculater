using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Calculator.Lib;
using Calculator.Model;
using Calculator.Properties;

namespace Calculator.Forms.GPA
{
    public partial class Calac : Form
    {
        private List<GpaHelper> _lGpa;
        private GPA_DBEntities _db;
        private GpaHelper _gpaHelper;
        private Gpa _gp;
        public Calac()
        {
            InitializeComponent();
            _gp = new Gpa();
            _db = new GPA_DBEntities();
            _gpaHelper = new GpaHelper();
            _lGpa = new List<GpaHelper>();
        }

        private void Calac_Load(object sender, EventArgs e)
        {
            _gp = _db.Gpas.FirstOrDefault(item => item.Id == Settings.Default.GPA_Id);
            if (_gp != null)
            {
            GpaNameLab.Text = _gp.Name;
            Text = _gp.Name;
            }
            UnitTBox.KeyUp += UnitTBoxKeyup;
            GpaHelper.Dropdawnlist(CB_Degree , _db);
            dataGridView1.CellValueChanged += Changethevalue;
            dataGridView1.CellClick += EditBtn_Click;
            dataGridView1.CellDoubleClick += EditBtn_dblClick; 

            toolTip1.SetToolTip(btnAdd , "Add Item You can use Enter ");
            toolTip1.SetToolTip(btnCalculate , "Calculate GPA");
            toolTip1.SetToolTip(DeletetImg , "Delete Item");
            toolTip1.SetToolTip(DiscardImg, "Discard");
        }

        //add Edit item
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!GpaHelper.CheckStringUnitInput(btnAdd, UnitTBox.Text))return;

               btnAdd.Enabled = false;
                //Edit item 
               if (btnAdd.Text == @"Edit")
                {
                //bind grid
                Grid.BindGrid(dataGridView1, GpaHelper.EditItem(_lGpa, UnitTBox, CB_Degree, UnitIDlab.Text));
                //Change Grid Color
                Grid.GridColor(dataGridView1);
                UnitTBox.Text = "";
                UnitSumation.Text = GpaHelper.UnitSumation(_lGpa).ToString(CultureInfo.CurrentCulture);
                UnitSumation.Visible = true;
                GpaHelper.ConvertButton(btnAdd, false, toolTip1);
                btnAdd.Enabled = true;
                UnitTBox.Text = "";
                CB_Degree.SelectedIndex = 0;
                DeletetImg.Visible = false;
                DiscardImg.Visible = false;
                return;
                }

                //add item
                _gpaHelper = GpaHelper.AddItem(UnitTBox, btnAdd, CB_Degree, (_lGpa.Count + 1));
                if (_gpaHelper == null)
                    return;

                _lGpa.Add(_gpaHelper);
                 //bind grid
                 Grid.BindGrid(dataGridView1, _lGpa);
                 //Change Grid Color
                 Grid.GridColor(dataGridView1);
                UnitTBox.Text = "";
                UnitSumation.Text = GpaHelper.UnitSumation(_lGpa).ToString(CultureInfo.CurrentCulture);
                UnitSumation.Visible = true;
                btnAdd.Enabled = true;
                CB_Degree.SelectedIndex = 0;
        }

        #region comment 
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter) return true;
            return base.ProcessCmdKey(ref msg, keyData);
        }

        #endregion

        //add item
        private void UnitTBoxKeyup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;

            if (!GpaHelper.CheckStringUnitInput(btnAdd, UnitTBox.Text)) return;
            btnAdd.Enabled = false;
            //Edit item 
            if (btnAdd.Text == "Edit")
            {
                //bind grid
                Grid.BindGrid(dataGridView1, GpaHelper.EditItem(_lGpa, UnitTBox, CB_Degree, UnitIDlab.Text));
                //Change Grid Color
                Grid.GridColor(dataGridView1);
                UnitTBox.Text = "";
                UnitSumation.Text = GpaHelper.UnitSumation(_lGpa).ToString(CultureInfo.CurrentCulture);
                UnitSumation.Visible = true;
                GpaHelper.ConvertButton(btnAdd, false, toolTip1);
                btnAdd.Enabled = true;
                DeletetImg.Visible = false;
                DiscardImg.Visible = false;
                return;
            }

            //add item
            _gpaHelper = GpaHelper.AddItem(UnitTBox, btnAdd, CB_Degree, (_lGpa.Count + 1));
            if (_gpaHelper == null)
                return;
            _lGpa.Add(_gpaHelper);
            //bind grid
            Grid.BindGrid(dataGridView1, _lGpa);
            //Change Grid Color
            Grid.GridColor(dataGridView1);
            UnitTBox.Text = "";
            UnitSumation.Text = GpaHelper.UnitSumation(_lGpa).ToString(CultureInfo.CurrentCulture);
            UnitSumation.Visible = true;
            btnAdd.Enabled = true;
        }
        
        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            UnitSumation.Text = GpaHelper.UnitSumation(_lGpa).ToString(CultureInfo.CurrentCulture);
        }

        private void Changethevalue(object sender, EventArgs e)
        {
            UnitSumation.Text = GpaHelper.UnitSumation(_lGpa).ToString(CultureInfo.CurrentCulture);
        }

        public void EditBtn_Click(object sender , DataGridViewCellEventArgs e)
        {
            var dataGridViewColumn = dataGridView1.Columns["Options"];
            if (dataGridViewColumn != null && (e.ColumnIndex != dataGridViewColumn.Index || e.RowIndex < 0))
                return;

            var id = dataGridView1.Rows[e.RowIndex].Cells["Id"].Value;
            if (id == null) 
                return;
            
                var gpaItem = _lGpa.SingleOrDefault(item => item.Id == Convert.ToDecimal(id));
                if (gpaItem != null)
                {
                    UnitTBox.Text = gpaItem.Unit.ToString(CultureInfo.CurrentCulture);
                    UnitIDlab.Text = gpaItem.Id.ToString(CultureInfo.CurrentCulture);
                    CB_Degree.Text = gpaItem.Mark ;
                }
                GpaHelper.ConvertButton(btnAdd, true, toolTip1);
                DiscardImg.Visible = true;
                DeletetImg.Visible = true;
        }

        public void EditBtn_dblClick(object sender , DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            
                var id = dataGridView1.Rows[e.RowIndex].Cells["Id"].Value;
                if (id == null)
                    return;

                var gpaItem = _lGpa.SingleOrDefault(item => item.Id == Convert.ToDecimal(id));
                if (gpaItem != null)
                {
                    UnitTBox.Text = gpaItem.Unit.ToString(CultureInfo.CurrentCulture);
                    UnitIDlab.Text = gpaItem.Id.ToString(CultureInfo.CurrentCulture);
                    CB_Degree.Text = gpaItem.Mark;
                }
                GpaHelper.ConvertButton(btnAdd, true, toolTip1);
                DiscardImg.Visible = true;
                DeletetImg.Visible = true;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ClaculateGpa();
        }

        private void DiscardImg_Click(object sender, EventArgs e)
        {
            GpaHelper.ConvertButton(btnAdd, false, toolTip1);
            btnAdd.Enabled = true;
            UnitTBox.Text = "";
            CB_Degree.SelectedIndex = 0;
            DeletetImg.Visible = false;
            DiscardImg.Visible = false;
        }

        private void DeletetImg_Click(object sender, EventArgs e)
        {
            GpaHelper.ConvertButton(btnAdd, false, toolTip1);
            btnAdd.Enabled = true;
            UnitTBox.Text = "";
            CB_Degree.SelectedIndex = 0;
            DeletetImg.Visible = false;
            DiscardImg.Visible = false;
            _lGpa.Remove(_lGpa.FirstOrDefault(val => val.Id == Convert.ToInt32(UnitIDlab.Text)));
            Grid.BindGrid(dataGridView1, _lGpa);
            //Change Grid Color
            Grid.GridColor(dataGridView1);
        }

        private void ClaculateGpa()
        {
            if (GpaHelper.CaulculateGpa(_lGpa, GpaHelper.UnitSumation(_lGpa)) == null)
                MessageBox.Show(@"Please Enter the Subject That You Want to Calculate", @"Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);

            GPAlab.Text = GpaHelper.CaulculateGpa(_lGpa, GpaHelper.UnitSumation(_lGpa)).ToString();
            GPAlab.Visible = true;
        }

        private void CalculationbyC(object sender, KeyEventArgs e)
        {

        }

        private void GpaNameLab_Click(object sender, EventArgs e)
        {

        }
    }
 
}
