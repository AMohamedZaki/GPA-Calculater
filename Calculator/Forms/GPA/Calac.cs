using System;
using System.CodeDom;
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
        private string _unitIDlab;
        public Calac()
        {
            InitializeComponent();
            _gp = new Gpa();
            _db = new GPA_DBEntities();
            _gpaHelper = new GpaHelper();
            _lGpa = new List<GpaHelper>();
        }

        #region Values

        private decimal _gpaSemestar = 0, _totalUnits=0 , _gpabefore;
        #endregion
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
            //dataGridView1.CellValueChanged += Changethevalue;
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
                Grid.BindGrid(dataGridView1, GpaHelper.EditItem(_lGpa, UnitTBox, CB_Degree, _unitIDlab));
                //Change Grid Color
                Grid.GridColor(dataGridView1);
                UnitTBox.Text = "";
                UnitSumation.Text = GpaHelper.UnitSumation(_lGpa).ToString(CultureInfo.CurrentCulture);
                TotalUnitLab.Text = (Convert.ToDecimal(UnitBeforeLab.Text) + Convert.ToDecimal(UnitSumation.Text)).ToString(CultureInfo.InvariantCulture);
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
                TotalUnitLab.Text = (Convert.ToDecimal(UnitBeforeLab.Text) + Convert.ToDecimal(UnitSumation.Text)).ToString(CultureInfo.InvariantCulture);
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
            if (btnAdd.Text == @"Edit")
            {
                //bind grid
                Grid.BindGrid(dataGridView1, GpaHelper.EditItem(_lGpa, UnitTBox, CB_Degree, _unitIDlab));
                //Change Grid Color
                Grid.GridColor(dataGridView1);
                UnitTBox.Text = "";
                UnitSumation.Text = GpaHelper.UnitSumation(_lGpa).ToString(CultureInfo.CurrentCulture);
                TotalUnitLab.Text = (Convert.ToDecimal(UnitBeforeLab.Text) + Convert.ToDecimal(UnitSumation.Text)).ToString(CultureInfo.InvariantCulture);
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
            TotalUnitLab.Text = (Convert.ToDecimal(UnitBeforeLab.Text) + Convert.ToDecimal(UnitSumation.Text)).ToString(CultureInfo.InvariantCulture);
            btnAdd.Enabled = true;
        }
        
        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            UnitSumation.Text = GpaHelper.UnitSumation(_lGpa).ToString(CultureInfo.CurrentCulture);
            TotalUnitLab.Text = (Convert.ToDecimal(UnitBeforeLab.Text) + Convert.ToDecimal(UnitSumation.Text)).ToString(CultureInfo.InvariantCulture);
        }

        //private void Changethevalue(object sender, EventArgs e)
        //{
        //    UnitSumation.Text = GpaHelper.UnitSumation(_lGpa).ToString(CultureInfo.CurrentCulture);
        //}

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
                    _unitIDlab = gpaItem.Id.ToString(CultureInfo.CurrentCulture);
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
                    _unitIDlab = gpaItem.Id.ToString(CultureInfo.CurrentCulture);
                    CB_Degree.Text = gpaItem.Mark;
                }
                GpaHelper.ConvertButton(btnAdd, true, toolTip1);
                DiscardImg.Visible = true;
                DeletetImg.Visible = true;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (GpaHelper.CaulculateGpa(_lGpa, GpaHelper.UnitSumation(_lGpa)) == null)
                MessageBox.Show(@"Please Enter the Subject That You Want to Calculate", @"Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);

            GPAlab.Text = GpaHelper.CaulculateGpa(_lGpa, GpaHelper.UnitSumation(_lGpa)).ToString();
            //panel1.Enabled = true;
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
            _lGpa.Remove(_lGpa.FirstOrDefault(val => val.Id == Convert.ToInt32(_unitIDlab)));
            Grid.BindGrid(dataGridView1, _lGpa);
            Grid.GridColor(dataGridView1);
        }
        

        private void UnitbeforeTxT_TextChanged(object sender, EventArgs e)
        {
            UnitbeforeTxT.BackColor = Color.White;
            if (!GpaHelper.CheckStringUnitInput(UnitbeforeTxT, UnitbeforeTxT.Text))
            {
                UnitBeforeLab.Text = @"0";
                TotalUnitLab.Text = (Convert.ToDecimal(UnitBeforeLab.Text) + Convert.ToDecimal(UnitSumation.Text)).ToString(CultureInfo.InvariantCulture);
                return;
            }
            UnitBeforeLab.Text = UnitbeforeTxT.Text;
            TotalUnitLab.Text  = (Convert.ToDecimal(UnitBeforeLab.Text) + Convert.ToDecimal(UnitSumation.Text)).ToString(CultureInfo.InvariantCulture);

        }

        private void GPA_TxT_TextChanged(object sender, EventArgs e)
        {
            GPA_TxT.BackColor = Color.White;
        }

        private void CalculateTotalbtn_Click(object sender, EventArgs e)
        {
            if (GpaHelper.CaulculateGpa(_lGpa, GpaHelper.UnitSumation(_lGpa)) == null)
            {
                MessageBox.Show(@"Please Enter the Subject That You Want to Calculate", @"Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!GpaHelper.GpaInputChecker(GPA_TxT))
            {
                GPA_TxT.BackColor = Color.Red;
                return;
            }

            if (!GpaHelper.CheckStringUnitInput(UnitbeforeTxT, UnitbeforeTxT.Text))
            {
                UnitbeforeTxT.BackColor = Color.Red;
                UnitBeforeLab.Text = @"0";
                TotalUnitLab.Text = (Convert.ToDecimal(UnitBeforeLab.Text) + Convert.ToDecimal(UnitSumation.Text)).ToString(CultureInfo.InvariantCulture);
                return;
            }

            if (GPAlab.Text == @"0")
            {
                MessageBox.Show(@"Please Calculate Your GPA in This Semeter to be able To Calulate The Total ..",
                    @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }


            GPAbeforLab.Text = GPA_TxT.Text;
            _gpaSemestar = Convert.ToDecimal(GPAlab.Text) * Convert.ToDecimal(UnitSumation.Text);
            _gpabefore = Convert.ToDecimal(GPA_TxT.Text) * Convert.ToDecimal(UnitBeforeLab.Text);
            _totalUnits = Convert.ToDecimal(TotalUnitLab.Text);


            TotalGPALab.Text = Math.Round(((_gpaSemestar + _gpabefore) /_totalUnits) , 2).ToString(CultureInfo.InvariantCulture);

        }

    }
 
}
