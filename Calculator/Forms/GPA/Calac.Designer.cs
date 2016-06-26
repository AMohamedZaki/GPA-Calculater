using Calculator.Properties;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Calculator.Forms.GPA
{
    partial class Calac
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calac));
            this.labDegree = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.CB_Degree = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TotalUnits = new System.Windows.Forms.Label();
            this.UnitSumation = new System.Windows.Forms.Label();
            this.UnitIDlab = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GPAlab = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.GpaNameLab = new System.Windows.Forms.Label();
            this.UnitTBox = new System.Windows.Forms.TextBox();
            this.LabNumberofUnit = new System.Windows.Forms.Label();
            this.DeletetImg = new System.Windows.Forms.PictureBox();
            this.DiscardImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeletetImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiscardImg)).BeginInit();
            this.SuspendLayout();
            // 
            // labDegree
            // 
            this.labDegree.AutoSize = true;
            this.labDegree.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDegree.ForeColor = global::Calculator.Properties.Settings.Default.FBgColorSet;
            this.labDegree.Location = new System.Drawing.Point(6, 87);
            this.labDegree.Name = "labDegree";
            this.labDegree.Size = new System.Drawing.Size(93, 19);
            this.labDegree.TabIndex = 0;
            this.labDegree.Text = "Your Degree";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(0)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 5;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnAdd.Location = new System.Drawing.Point(367, 126);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 36);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(166)))), ((int)(((byte)(255)))));
            this.btnCalculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculate.Location = new System.Drawing.Point(457, 126);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 36);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // CB_Degree
            // 
            this.CB_Degree.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Degree.FormattingEnabled = true;
            this.CB_Degree.Location = new System.Drawing.Point(6, 135);
            this.CB_Degree.Name = "CB_Degree";
            this.CB_Degree.Size = new System.Drawing.Size(121, 21);
            this.CB_Degree.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = global::Calculator.Properties.Settings.Default.BgColorSet;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(6, 176);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 35;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(290, 258);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView1_RowsRemoved);
            // 
            // TotalUnits
            // 
            this.TotalUnits.AutoSize = true;
            this.TotalUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalUnits.ForeColor = global::Calculator.Properties.Settings.Default.FBgColorSet;
            this.TotalUnits.Location = new System.Drawing.Point(364, 196);
            this.TotalUnits.Name = "TotalUnits";
            this.TotalUnits.Size = new System.Drawing.Size(77, 13);
            this.TotalUnits.TabIndex = 9;
            this.TotalUnits.Text = "TotalUnits : ";
            // 
            // UnitSumation
            // 
            this.UnitSumation.AutoSize = true;
            this.UnitSumation.ForeColor = global::Calculator.Properties.Settings.Default.FBgColorSet;
            this.UnitSumation.Location = new System.Drawing.Point(438, 196);
            this.UnitSumation.Name = "UnitSumation";
            this.UnitSumation.Size = new System.Drawing.Size(70, 13);
            this.UnitSumation.TabIndex = 10;
            this.UnitSumation.Text = "UnitSumation";
            this.UnitSumation.Visible = false;
            // 
            // UnitIDlab
            // 
            this.UnitIDlab.AutoSize = true;
            this.UnitIDlab.Location = new System.Drawing.Point(7, 452);
            this.UnitIDlab.Name = "UnitIDlab";
            this.UnitIDlab.Size = new System.Drawing.Size(37, 13);
            this.UnitIDlab.TabIndex = 11;
            this.UnitIDlab.Text = "UnitID";
            this.UnitIDlab.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = global::Calculator.Properties.Settings.Default.FBgColorSet;
            this.label1.Location = new System.Drawing.Point(364, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Your GPA  :";
            // 
            // GPAlab
            // 
            this.GPAlab.AutoSize = true;
            this.GPAlab.ForeColor = global::Calculator.Properties.Settings.Default.FBgColorSet;
            this.GPAlab.Location = new System.Drawing.Point(438, 223);
            this.GPAlab.Name = "GPAlab";
            this.GPAlab.Size = new System.Drawing.Size(43, 13);
            this.GPAlab.TabIndex = 13;
            this.GPAlab.Text = "GPAlab";
            this.GPAlab.Visible = false;
            // 
            // GpaNameLab
            // 
            this.GpaNameLab.AutoSize = true;
            this.GpaNameLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GpaNameLab.ForeColor = global::Calculator.Properties.Settings.Default.FBgColorSet;
            this.GpaNameLab.Location = new System.Drawing.Point(182, 21);
            this.GpaNameLab.Name = "GpaNameLab";
            this.GpaNameLab.Size = new System.Drawing.Size(79, 17);
            this.GpaNameLab.TabIndex = 17;
            this.GpaNameLab.Text = "GpaName";
            this.GpaNameLab.Click += new System.EventHandler(this.GpaNameLab_Click);
            // 
            // UnitTBox
            // 
            this.UnitTBox.Location = new System.Drawing.Point(146, 133);
            this.UnitTBox.Multiline = true;
            this.UnitTBox.Name = "UnitTBox";
            this.UnitTBox.Size = new System.Drawing.Size(115, 23);
            this.UnitTBox.TabIndex = 8;
            // 
            // LabNumberofUnit
            // 
            this.LabNumberofUnit.AutoSize = true;
            this.LabNumberofUnit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabNumberofUnit.ForeColor = global::Calculator.Properties.Settings.Default.FBgColorSet;
            this.LabNumberofUnit.Location = new System.Drawing.Point(142, 87);
            this.LabNumberofUnit.Name = "LabNumberofUnit";
            this.LabNumberofUnit.Size = new System.Drawing.Size(123, 19);
            this.LabNumberofUnit.TabIndex = 1;
            this.LabNumberofUnit.Text = "Number of Unit\'s";
            // 
            // DeletetImg
            // 
            this.DeletetImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeletetImg.Image = global::Calculator.Properties.Resources.metro_icon;
            this.DeletetImg.Location = new System.Drawing.Point(319, 133);
            this.DeletetImg.Name = "DeletetImg";
            this.DeletetImg.Size = new System.Drawing.Size(23, 23);
            this.DeletetImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DeletetImg.TabIndex = 15;
            this.DeletetImg.TabStop = false;
            this.DeletetImg.Visible = false;
            this.DeletetImg.Click += new System.EventHandler(this.DeletetImg_Click);
            // 
            // DiscardImg
            // 
            this.DiscardImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DiscardImg.Image = global::Calculator.Properties.Resources.matticonssoftwareinstallerpurge1;
            this.DiscardImg.Location = new System.Drawing.Point(284, 133);
            this.DiscardImg.Name = "DiscardImg";
            this.DiscardImg.Size = new System.Drawing.Size(23, 23);
            this.DiscardImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DiscardImg.TabIndex = 14;
            this.DiscardImg.TabStop = false;
            this.DiscardImg.Visible = false;
            this.DiscardImg.Click += new System.EventHandler(this.DiscardImg_Click);
            // 
            // Calac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::Calculator.Properties.Settings.Default.BgColorSet;
            this.ClientSize = new System.Drawing.Size(542, 472);
            this.Controls.Add(this.GpaNameLab);
            this.Controls.Add(this.DeletetImg);
            this.Controls.Add(this.DiscardImg);
            this.Controls.Add(this.GPAlab);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UnitIDlab);
            this.Controls.Add(this.UnitSumation);
            this.Controls.Add(this.TotalUnits);
            this.Controls.Add(this.UnitTBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CB_Degree);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.LabNumberofUnit);
            this.Controls.Add(this.labDegree);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(558, 511);
            this.MinimumSize = new System.Drawing.Size(558, 511);
            this.Name = "Calac";
            this.Text = "Calc";
            this.Load += new System.EventHandler(this.Calac_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CalculationbyC);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CalculationbyC);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeletetImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiscardImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labDegree;
        private Button btnAdd;
        private Button btnCalculate;
        private ComboBox CB_Degree;
        private DataGridView dataGridView1;
        private Label TotalUnits;
        private Label UnitSumation;
        private Label UnitIDlab;
        private Label label1;
        private Label GPAlab;
        private PictureBox DiscardImg;
        private PictureBox DeletetImg;
        private ToolTip toolTip1;
        private Label GpaNameLab;
        private TextBox UnitTBox;
        private Label LabNumberofUnit;
    }
}

