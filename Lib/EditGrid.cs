using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Calculator.Model;
using Calculator.Properties;

namespace Calculator.Lib
{
    class Grid
    {
        public static void GridColor(DataGridView gridView)
        {
            for (var rows = 0; rows < gridView.RowCount ; rows++)
            {
                if (rows%2 != 0)
                    gridView.Rows[rows].Cells[1].Style.BackColor = Color.Gray ;
               
                gridView.Rows[rows].Cells[0].Value = "Edit";
            }
            gridView.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridView.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridView.BackgroundColor = Settings.Default.BgColorSet;
            if (gridView.Rows.Count >= 11)
                gridView.BackgroundColor = Color.White;
        }

        public static void BindGrid<TDataValue>(DataGridView gridView , List<TDataValue> item)
        {
            var cbtn = new DataGridViewButtonColumn { Name = "Options" };
            gridView.DataSource = new BindingSource { DataSource = item };
            gridView.Columns.Insert(0,cbtn);
            if (gridView.Columns["Id"] != null)
            gridView.Columns["Id"].Visible = false;
            if (gridView.Columns["DateTime"] != null)
            gridView.Columns["DateTime"].Visible = false;
            gridView.Columns[0].Width = 90;
            if (gridView.Columns["UValue"] != null)
                gridView.Columns["UValue"].Visible = false;
            if (typeof (TDataValue) == typeof (GpaHelper))
            gridView.Columns[1].Visible = false;
            gridView.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridView.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridView.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridView.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
    }
    

    public class GpaHelper
    {
        public int Id { get; set; }

        public string Mark { get; set; }

        public decimal Unit { get; set; }
        
        public decimal UValue { get; set; }

        public static bool  CheckStringUnitInput<T>(T btn , string text) where T : Control
        { 
            if (string.IsNullOrEmpty(text) && typeof(T) == typeof(Button))
            {
                btn.Focus();
                MessageBox.Show(@"Please Enter the number Of Units");
                return false;
            }

            if (CheckDecimal(text) == false)
            {
                btn.Focus();
                MessageBox.Show(@"Please Enter Numbers not characters");
                return false;
            }

            if (Convert.ToDecimal(text) < 1)
            {
                btn.Focus();
                MessageBox.Show(@"Please Enter the number Of Units more than 0");
                return false;
            }

           return true;
        }

        public static bool CheckStringUnitInput(Button btn, string numbertOfUnits , string degree)
        {
            decimal number1;
            if (string.IsNullOrEmpty(numbertOfUnits) || string.IsNullOrEmpty(degree))
            {
                btn.Focus();
                MessageBox.Show(@"Make Sure You Entered All DAta..", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (CheckDecimal(numbertOfUnits) == false)
            {
                btn.Focus();
                MessageBox.Show(@"Please Enter the Value Numbers not characters", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //if (Convert.ToDecimal(numbertOfUnits) < 1)
            //{
            //    btn.Focus();
            //    MessageBox.Show(@"Please Enter the number Of Units more than 0..", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return false;
            //}

            if (decimal.TryParse(degree, out number1))
            {
                MessageBox.Show(@"Please Enter Degree Contain at least one charcter ..", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public static GpaHelper AddItem(TextBox unit ,Button btnAdd ,ComboBox cbDegree , int cont)
        {
            
           btnAdd.Enabled = false;
           return new GpaHelper
           {
               Mark = cbDegree.Text,
               Unit = Convert.ToDecimal(unit.Text),
               UValue = Convert.ToDecimal(cbDegree.SelectedValue),
               Id = cont
           };
           
        }

        public static List<GpaHelper> EditItem(List<GpaHelper> lGpa , TextBox unit , ComboBox cbDegree , string id)
        {
            var gpaItem = lGpa.SingleOrDefault(item => item.Id == Convert.ToDecimal(id));

            if (gpaItem == null) return null;

                gpaItem.Mark = cbDegree.Text;
                gpaItem.Unit = Convert.ToDecimal(unit.Text);
                gpaItem.UValue = Convert.ToDecimal(cbDegree.SelectedValue);
                return lGpa;
        }

        public static decimal UnitSumation(List<GpaHelper> collection)
        {return collection.Sum(gpa => gpa.Unit);}

        public static bool CheckDecimal(string theWord , decimal x = 8)
        {
            return decimal.TryParse(theWord , out x);
        }

        /// <summary>
        /// <param name="btn"></param>
        /// <param name="convert">T to Edit and F to Add </param>
        /// <param name="toolTip"></param>
        /// </summary>
        
        public static void ConvertButton(Button btn , bool convert , ToolTip toolTip)
        {
            if (convert)
            {
                btn.Text = @"Edit";
                btn.BackColor = Color.FromArgb(103, 193, 0); ;
                toolTip.SetToolTip(btn , "Edit Item");
                return;
            }
            btn.Text =@"Add";
            toolTip.SetToolTip(btn, "Add Item");
            btn.BackColor = Color.FromArgb(0, 193, 0);
        }

        public static decimal ?  CaulculateGpa(List<GpaHelper> collectionList , decimal unitCollection)
        {
            if (collectionList.Count == 0)
                return null;
            
            return Math.Round((collectionList.Sum(item => (item.Unit * item.UValue)) / unitCollection), 2);
        }

        public static void ConvertTheSameColor<TControl>(TControl control , Color color 
            ,Color dColor) where TControl : Control
        {
            if (control.ForeColor == color && control.ForeColor != Color.White)
            {
                control.ForeColor = Color.White;
                return;
            }
            control.ForeColor = dColor;
        }

        //From DB
        public static void Dropdawnlist(ComboBox cbDegree , GPA_DBEntities db)
        {
            cbDegree.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDegree.DataSource = db.Grades.Where(item => item.GpaId == Settings.Default.GPA_Id).ToList();
            cbDegree.DisplayMember = "Name";
            cbDegree.ValueMember = "Value";
            cbDegree.SelectedIndex = 0;
        }

        public static bool  GpaInputChecker<T>(T btn) where T : Control
        { 
            
            if (string.IsNullOrEmpty(btn.Text) )
            {
                MessageBox.Show(@"Please Enter the GPA");
                return false;
            }

            if (CheckDecimal(btn.Text) == false)
            {
                MessageBox.Show(@"Please Enter Numbers not characters");
                return false;
            }

            if (Convert.ToDecimal(btn.Text) < 1)
            {
                MessageBox.Show(@"Please Enter the number Of Units more than 0");
                return false;
            }

            if (Convert.ToDecimal(btn.Text) > 4)
            {
                MessageBox.Show(@"Please Enter the number Of Units less than 4");
                return false;
            }
           return true;
        }

    }
    

}

