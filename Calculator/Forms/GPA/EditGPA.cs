using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Calculator.Lib;
using Calculator.Model;
namespace Calculator.Forms.GPA
{
    public partial class EditGpa : Form
    {
        private GPA_DBEntities _db;

        //  private List<Grades> _grades;

        private Gpa _gpaItem;
        private int _selectedGpaValue;
        private int _gradeId;
        public EditGpa()
        {
            InitializeComponent();
            _db = new GPA_DBEntities();
        }

        private void EditGpa_Load(object sender, EventArgs e)
        {
            DropDawnBind();
            toolTip1.SetToolTip(editGpImg, "Edit Gpa Calculater Name");
            toolTip1.SetToolTip(removeGpImg, "Delete Gpa Calculater");
            toolTip1.SetToolTip(DiscardImg, "Discard");
            toolTip1.SetToolTip(DeletetImg, "Delete Degree");
        }

        private void GPAcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GPAcomboBox.SelectedIndex == 0)
            {
                DegreeTxT.Enabled = false;
                ValueTxT.Enabled = false;
                DeletetImg.Enabled = false;
                removeGpImg.Visible = false;
                removeGpImg.Enabled = false;
                Addbtn.Enabled = false;
                Gpa_NameTXT.Enabled = false;

                return;
            }
            Gpa_NameTXT.Enabled = true;
            removeGpImg.Visible = true;
            removeGpImg.Enabled = true;
            DegreeTxT.Enabled = true;

            ValueTxT.Enabled = true;
            DeletetImg.Enabled = true;
            Addbtn.Enabled = true;

            _selectedGpaValue = Convert.ToInt32(GPAcomboBox.SelectedValue);

            _gpaItem = _db.Gpas.FirstOrDefault(item => _selectedGpaValue == item.Id);

            if (_gpaItem != null) Gpa_NameTXT.Text = _gpaItem.Name;

            var grades = _db.Grades.Where(item => item.GpaId == _gpaItem.Id)
                        .Select(val => new Grades { Name = val.Name, Value = val.Value, Id = val.Id })
                        .OrderByDescending(item1 => item1.Value)
                        .ToList();

            Bind(grades);
        }

        public class Grades
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public decimal Value { get; set; }
        }

        private void Bind<T>(List<T> grades)
        {
            var editBtn = new DataGridViewButtonColumn
            {
                Name = "",
                Width = 50
            };

            GradesGridView.DataSource = grades;
            GradesGridView.Columns.Insert(0, editBtn);

            if (GradesGridView.Columns["Id"] != null)
                GradesGridView.Columns["Id"].Visible = false;

            for (var rows = 0; rows < GradesGridView.RowCount; rows++)
            {
                GradesGridView.Rows[rows].Cells[0].Value = "Edit";
            }
            GradesGridView.Columns[1].Visible = false;
        }

        //The Button on The GridView
        public void Editbtn_Click(object sender, DataGridViewCellEventArgs e)
        {
            var dataGridViewColumn = GradesGridView.Columns[""];
            if (dataGridViewColumn != null && (e.ColumnIndex != dataGridViewColumn.Index || e.RowIndex < 0))
                return;

            var id = GradesGridView.Rows[e.RowIndex].Cells["Id"].Value;
            if (id == null)
                return;

            var gradeId = Convert.ToDecimal(id);
            var gpadItem = _db.Grades.FirstOrDefault(item => item.Id == gradeId);
            if (gpadItem != null)
            {
                DegreeTxT.Text = gpadItem.Name.ToString(CultureInfo.CurrentCulture);
                ValueTxT.Text = gpadItem.Value.ToString(CultureInfo.CurrentCulture);
                _gradeId = gpadItem.Id;
            }

            GpaHelper.ConvertButton(Addbtn, true, toolTip1);
            DiscardImg.Visible = true;
            DeletetImg.Visible = true;

        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!GpaHelper.CheckStringUnitInput(Addbtn, ValueTxT.Text, DegreeTxT.Text)) return;
                Grade data;
                var val = Convert.ToDecimal(ValueTxT.Text);

                #region if
                if (Addbtn.Text == @"Edit")
                {
                    var check = _db.Grades.Where(item => item.Id != _gradeId).ToList().Any(item1 => item1.Name == DegreeTxT.Text || item1.Value == val);
                    if (check)
                    {
                        MessageBox.Show(@"Please Make Sure That Degree Or Value Not Repeated !",
                            @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    data = _db.Grades.FirstOrDefault(item => item.Id == _gradeId);
                    if (data != null)
                    {
                        data.Name = DegreeTxT.Text;
                        data.Value = Convert.ToDecimal(ValueTxT.Text);
                    }
                    DeletetImg.Visible = false;
                    DiscardImg.Visible = false;
                    GpaHelper.ConvertButton(Addbtn, false, toolTip1);
                }
                #endregion
                #region else
                else
                {
                    var check = _db.Grades.FirstOrDefault(item => item.Name == DegreeTxT.Text || item.Value == val);
                    if (check != null)
                    {
                        MessageBox.Show(@"Please Make Sure That Degree Or Value Not Repeated !",
                            @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    data = new Grade
                    {
                        Name = DegreeTxT.Text,
                        Value = Convert.ToDecimal(ValueTxT.Text),
                        GpaId = _selectedGpaValue
                    };
                    _db.Grades.Add(data);
                }
                #endregion
                _db.SaveChanges();
                var dataGrid = _db.Grades.Where(item => item.GpaId == _selectedGpaValue).OrderByDescending(item => item.Value).ToList();
                Bind(dataGrid);
                DegreeTxT.Text = "";
                ValueTxT.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An Error Occured the Application Will Close {Environment.CommandLine}" + ex.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                throw;
            }
        }

        private void DiscardImg_Click(object sender, EventArgs e)
        {
            GpaHelper.ConvertButton(Addbtn, false, toolTip1);
            DegreeTxT.Text = "";
            ValueTxT.Text = "";
            DeletetImg.Visible = false;
            DiscardImg.Visible = false;
        }

        private void DeletetImg_Click(object sender, EventArgs e)
        {
            try
            {
                GpaHelper.ConvertButton(Addbtn, false, toolTip1);
                DegreeTxT.Text = "";
                ValueTxT.Text = "";
                DeletetImg.Visible = false;
                DiscardImg.Visible = false;

                _db.Grades.Remove(_db.Grades.FirstOrDefault(item => item.Id == _gradeId));
                _db.SaveChanges();
                var data = _db.Grades.Where(item => item.GpaId == _selectedGpaValue).ToList();
                Bind(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

        }

        private void removeGpImg_Click(object sender, EventArgs e)
        {
            var reuslt = MessageBox.Show(@"Are You Sure You Want To Remove This Calculater ?", @"Are You Sure You Want To Remove This Calculater ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (reuslt == DialogResult.No)
                return;

            // var data = _db.Gpas.FirstOrDefault(item => item.Id == _selectedGpaValue);
            _db.Gpas.Remove(_db.Gpas.FirstOrDefault(item => item.Id == _selectedGpaValue));
            _db.Grades.RemoveRange(_db.Grades.Where(item => item.GpaId == _selectedGpaValue));
            _db.SaveChanges();
            DropDawnBind();
            Gpa_NameTXT.Text = "";
            GradesGridView.DataSource = new BindingSource { DataSource = null };
        }

        private void DropDawnBind()
        {
            var gp = _db.Gpas.ToList();
            gp.Insert(0, new Gpa { Name = "Choose..." });
            GPAcomboBox.DataSource = gp;
            GPAcomboBox.DisplayMember = "Name";
            GPAcomboBox.ValueMember = "Id";
            GPAcomboBox.SelectedIndex = 0;
            GradesGridView.CellClick += Editbtn_Click;
        }

        private void editGpImg_Click(object sender, EventArgs e)
        {
            var gp = _db.Gpas.FirstOrDefault(item => item.Id == _selectedGpaValue);
            if (gp != null) gp.Name = Gpa_NameTXT.Text;
            _db.SaveChanges();
            DropDawnBind();
            Gpa_NameTXT.Text = "";
            editGpImg.Visible = false;
        }

        private void Gpa_NameTXT_TextChanged(object sender, EventArgs e)
        {
            if (GPAcomboBox.Text == Gpa_NameTXT.Text)
            {
                editGpImg.Visible = false;
                return;
            }

            editGpImg.Visible = true;
        }
    }
}
