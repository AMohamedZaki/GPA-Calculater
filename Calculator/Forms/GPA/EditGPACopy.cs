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
    public partial class EditGpaCopy: Form
    {
        private GPA_DBEntities _db ;
        private int _lastGardId;
        private List<Grades> _grades;
        public EditGpaCopy()
        {
            InitializeComponent();
            _db = new GPA_DBEntities();
            _lastGardId = _db.Grades.ToList().Last().Id + 1;
        }

        private void EditGpa_Load(object sender, EventArgs e)
        {
            var gp = _db.Gpas.ToList();
            gp.Insert(0 , new Gpa {Name = "Choose "});
            GPAcomboBox.DataSource = gp;
            GPAcomboBox.DisplayMember = "Name";
            GPAcomboBox.ValueMember = "Id";
            GPAcomboBox.SelectedIndex = 0;
            GradesGridView.CellClick += Editbtn_Click;
        }
        
        private void GPAcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(GPAcomboBox.SelectedIndex == 0)
            return;

            var selectedValue = Convert.ToInt32(GPAcomboBox.SelectedValue);
            var gpa = _db.Gpas.FirstOrDefault(item => selectedValue == item.Id);

            if (gpa != null)Gpa_NameTXT.Text = gpa.Name;

            _grades = _db.Grades.Where(item => item.GpaId == gpa.Id).Select(item => new Grades
            {
                Name = item.Name ,
                Value = item.Value ,
                Id = item.Id ,
                Dirty = false ,
                NewItem = false
            }).ToList();

            Bind(_grades);
        }
        
        private void DoneImg_Click(object sender, EventArgs e)
        {

        }
        
        public void Editbtn_Click(object sender, DataGridViewCellEventArgs e)
        {
            var dataGridViewColumn = GradesGridView.Columns[""];
            if (dataGridViewColumn != null && (e.ColumnIndex != dataGridViewColumn.Index || e.RowIndex < 0))
                return;

            var id = GradesGridView.Rows[e.RowIndex].Cells["Id"].Value;
            if (id == null)
                return;

            var gpaItem = _grades.SingleOrDefault(item => item.Id == Convert.ToDecimal(id));
            if (gpaItem != null)
            {
                DegreeTxT.Text = gpaItem.Name.ToString(CultureInfo.CurrentCulture);
                ValueTxT.Text = gpaItem.Value.ToString(CultureInfo.CurrentCulture);
            }
            GpaHelper.ConvertButton(Addbtn , true, toolTip1);
            DiscardImg.Visible = true;
            DeletetImg.Visible = true;

        }

        private void Savebtn_Click(object sender, EventArgs e)
        {

        }
        
        public class Grades
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public decimal Value { get; set; }
            public bool Dirty { get; set; }
            public bool NewItem { get; set; }
        }

        private void Bind<T> (List<T> grades)
        {
            var editBtn = new DataGridViewButtonColumn
            {
                Name = "",
                Width = 50,
                DefaultCellStyle = { BackColor = Color.FromArgb(0, 166, 255) }
            };

            GradesGridView.DataSource = grades;
            GradesGridView.Columns.Insert(0, editBtn);

            if (GradesGridView.Columns["Id"] != null)
                GradesGridView.Columns["Id"].Visible = false;

            if (GradesGridView.Columns["Dirty"] != null)
                GradesGridView.Columns["Dirty"].Visible = false;

            for (var rows = 0; rows < GradesGridView.RowCount; rows++)
            { GradesGridView.Rows[rows].Cells[0].Value = "Edit"; }

        }
        
        private void Addbtn_Click(object sender, EventArgs e)
        {
            _lastGardId++;
            var data = new Grades
            {
                Name = DegreeTxT.Text ,
                Value = Convert.ToDecimal(ValueTxT.Text),
                Id = _lastGardId ,
                NewItem = true
            };
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
            GpaHelper.ConvertButton(Addbtn, false, toolTip1);
            DegreeTxT.Text = "";
            ValueTxT.Text = "";
            DeletetImg.Visible = false;
            DiscardImg.Visible = false;
            //_grades.Remove(_lGpa.FirstOrDefault(val => val.Id == Convert.ToInt32(UnitIDlab.Text)));
            //Grid.BindGrid(dataGridView1, _lGpa);
            ////Change Grid Color
            //Grid.GridColor(dataGridView1);
        }

    }
}
