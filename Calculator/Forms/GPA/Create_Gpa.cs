using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Calculator.Model;

namespace Calculator.Forms.GPA
{
    public partial class CreateGpa : Form
    {
        private GPA_DBEntities _db;
        private List<Grade> _grades;
        private List<int> _error;
        // defualt false
        public bool? Dirtychecked;
        public CreateGpa()
        {
            InitializeComponent();
            _db = new GPA_DBEntities();
        }

        private void Create_Gpa_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(Checkbtn, "Check The Table of Degrees and the Values");
            toolTip1.SetToolTip(Savebtn, "Save The Data");
        }

        private void DegreedataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case -1:
                    break;

                case 1:
                    if (string.IsNullOrEmpty(DegreedataGridView[e.ColumnIndex, e.RowIndex].EditedFormattedValue.ToString()))
                        return;

                    double number;
                    DegreedataGridView[e.ColumnIndex, e.RowIndex].Style.BackColor = double.TryParse(DegreedataGridView[e.ColumnIndex, e.RowIndex].EditedFormattedValue.ToString(), out number) ? Color.Bisque : Color.Red;
                    break;

                default:
                    if (!string.IsNullOrEmpty(DegreedataGridView[e.ColumnIndex, e.RowIndex].EditedFormattedValue.ToString()))
                    {
                        double number1;
                        DegreedataGridView[e.ColumnIndex, e.RowIndex].Style.BackColor = double.TryParse(DegreedataGridView[e.ColumnIndex, e.RowIndex].EditedFormattedValue.ToString(), out number1) ? Color.Red :
                            Color.Bisque;
                    }
                    break;
            }

            #region comment
            //DegreedataGridView[e.ColumnIndex, e.RowIndex].b
            //check the cell(0,1) not empty
            //DegreedataGridView[e.ColumnIndex, e.RowIndex].Style.BackColor =
            //    string.IsNullOrEmpty(DegreedataGridView[e.ColumnIndex, e.RowIndex].EditedFormattedValue.ToString())
            //        ? Color.Red
            //        : Color.Bisque;
            #endregion

        }

        private void Checkbtn_Click(object sender, EventArgs e)
        {
            #region try
            try
            {
                CheckData();
                if (Dirtychecked == false)
                MessageBox.Show("No Problem");
            }
            #endregion
            #region catch
            catch (Exception ex)
            {
                MessageBox.Show(@"An Error Occured Please Try again", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {

            Savebtn.Enabled = false;
            if (string.IsNullOrEmpty(GpaCreateTxT.Text))
            {
                MessageBox.Show(@"Please Enter The Gpa Name ", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Dirtychecked == null || Dirtychecked == true)
                CheckData();
            
            if (Dirtychecked == true)
                return;

            if (_grades.Count <= 0)
            {
                MessageBox.Show(@"Please Enter Your Grades !!", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var gpA = new Gpa { Name = GpaCreateTxT.Text, DateTime = DateTime.Now };
            _db.Gpas.Add(gpA);
            _db.SaveChanges();

            var lastGpa = _db.Gpas.ToList().Last();
            for (var i = 0; i < _grades.Count; i++)
            {
                var grade = new Grade
                {
                    Name = _grades[i].Name,
                    Value = _grades[i].Value,
                    GpaId = Convert.ToInt32(lastGpa.Id)
                };
                _db.Grades.Add(grade);
            }
            _db.SaveChanges();


            Savebtn.Enabled = true;
            panel1.Visible = true;
            GpaCreateTxT.Text = "";
            _grades = null;
            DegreedataGridView.DataSource = new BindingSource { DataSource = null };

        }

        private void GpaCreateTxT_TextChanged(object sender, EventArgs e)
        {
            Savebtn.Enabled = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
           // new Sgpa().Show();
            this.Close();
        }


        public void CheckData()
        {
            Dirtychecked = false;
            _grades = new List<Grade>();
            _error = new List<int>();
            Grade grade;
            Savebtn.Enabled = true;

            for (var i = 0; i < DegreedataGridView.RowCount; i++)
            {
                if (DegreedataGridView.Rows[i].Cells["Degree_Name"].Value == null || DegreedataGridView.Rows[i].Cells["Value"].Value == null || DegreedataGridView.Rows[i].Cells["Degree_Name"].Style.BackColor != Color.Bisque || DegreedataGridView.Rows[i].Cells["Value"].Style.BackColor != Color.Bisque)
                {
                    _error.Add(i);
                    continue;
                }

                grade = new Grade
                {
                    Name = DegreedataGridView.Rows[i].Cells["Degree_Name"].Value.ToString(),
                    Value = Convert.ToDecimal(DegreedataGridView.Rows[i].Cells["Value"].Value)
                };
                _grades.Add(grade);
            }

            // Remove the Unused Rows
            #region Unused Rows
            if (_error.Count > 1)
            {
                var result = MessageBox.Show(@" Remove The Un-used Rows... ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result != DialogResult.Yes)
                {
                    Dirtychecked = true;
                    return;
                }

                _error.Remove(_error[_error.Count - 1]);

                for (var i = _error.Count - 1; i >= 0; i--) { DegreedataGridView.Rows.RemoveAt(_error[i]); }

            }
            #endregion

            //to check the Duplicated Names
            #region Duplicated Names
            var gradenameList = _grades.Select(name => name.Name).ToList().GroupBy(item => item).Where(group => group.Count() > 1).Select(group => group.Key);

            var gradeValueList = _grades.Select(name => name.Value).ToList().GroupBy(item => item).Where(group => group.Count() > 1).Select(group => group.Key);

            if (gradenameList.Count() != 0 || gradeValueList.Count() != 0)
            {
                // you can use $ instead Of string.format
                MessageBox.Show($"You Have duplicated Values In Grade Column. {Environment.NewLine} Please review Your Data ", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Dirtychecked = true;
            }
            #endregion

        }
    }
}
