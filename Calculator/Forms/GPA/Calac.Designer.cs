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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.GpaNameLab = new System.Windows.Forms.Label();
            this.UnitTBox = new System.Windows.Forms.TextBox();
            this.LabNumberofUnit = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CalculateTotalbtn = new System.Windows.Forms.Button();
            this.UnitbeforeTxT = new System.Windows.Forms.TextBox();
            this.uBeforeLab = new System.Windows.Forms.Label();
            this.GPA_TxT = new System.Windows.Forms.TextBox();
            this.GPABeforeLab = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TotalGPALab = new System.Windows.Forms.Label();
            this.TotalUnitLab = new System.Windows.Forms.Label();
            this.GPAbeforLab = new System.Windows.Forms.Label();
            this.UnitBeforeLab = new System.Windows.Forms.Label();
            this.GPAlab = new System.Windows.Forms.Label();
            this.UnitSumation = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.line5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.line4 = new System.Windows.Forms.Label();
            this.line3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.line2 = new System.Windows.Forms.Label();
            this.line1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BackImg = new System.Windows.Forms.PictureBox();
            this.DeletetImg = new System.Windows.Forms.PictureBox();
            this.DiscardImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackImg)).BeginInit();
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
            this.dataGridView1.Location = new System.Drawing.Point(6, 186);
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
            // GpaNameLab
            // 
            this.GpaNameLab.AutoSize = true;
            this.GpaNameLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GpaNameLab.ForeColor = global::Calculator.Properties.Settings.Default.FBgColorSet;
            this.GpaNameLab.Location = new System.Drawing.Point(228, 16);
            this.GpaNameLab.Name = "GpaNameLab";
            this.GpaNameLab.Size = new System.Drawing.Size(79, 17);
            this.GpaNameLab.TabIndex = 17;
            this.GpaNameLab.Text = "GpaName";
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
            // panel1
            // 
            this.panel1.Controls.Add(this.CalculateTotalbtn);
            this.panel1.Controls.Add(this.UnitbeforeTxT);
            this.panel1.Controls.Add(this.uBeforeLab);
            this.panel1.Controls.Add(this.GPA_TxT);
            this.panel1.Controls.Add(this.GPABeforeLab);
            this.panel1.Location = new System.Drawing.Point(6, 450);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 168);
            this.panel1.TabIndex = 18;
            // 
            // CalculateTotalbtn
            // 
            this.CalculateTotalbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(166)))), ((int)(((byte)(255)))));
            this.CalculateTotalbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CalculateTotalbtn.Location = new System.Drawing.Point(77, 79);
            this.CalculateTotalbtn.Name = "CalculateTotalbtn";
            this.CalculateTotalbtn.Size = new System.Drawing.Size(143, 43);
            this.CalculateTotalbtn.TabIndex = 4;
            this.CalculateTotalbtn.Text = "Calculate Total";
            this.CalculateTotalbtn.UseVisualStyleBackColor = false;
            this.CalculateTotalbtn.Click += new System.EventHandler(this.CalculateTotalbtn_Click);
            // 
            // UnitbeforeTxT
            // 
            this.UnitbeforeTxT.Location = new System.Drawing.Point(77, 43);
            this.UnitbeforeTxT.Name = "UnitbeforeTxT";
            this.UnitbeforeTxT.Size = new System.Drawing.Size(143, 20);
            this.UnitbeforeTxT.TabIndex = 3;
            this.UnitbeforeTxT.TextChanged += new System.EventHandler(this.UnitbeforeTxT_TextChanged);
            // 
            // uBeforeLab
            // 
            this.uBeforeLab.AutoSize = true;
            this.uBeforeLab.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uBeforeLab.ForeColor = global::Calculator.Properties.Settings.Default.FBgColorSet;
            this.uBeforeLab.Location = new System.Drawing.Point(5, 46);
            this.uBeforeLab.Name = "uBeforeLab";
            this.uBeforeLab.Size = new System.Drawing.Size(76, 15);
            this.uBeforeLab.TabIndex = 2;
            this.uBeforeLab.Text = "Unit before : ";
            // 
            // GPA_TxT
            // 
            this.GPA_TxT.Location = new System.Drawing.Point(77, 12);
            this.GPA_TxT.Name = "GPA_TxT";
            this.GPA_TxT.Size = new System.Drawing.Size(143, 20);
            this.GPA_TxT.TabIndex = 1;
            this.GPA_TxT.TextChanged += new System.EventHandler(this.GPA_TxT_TextChanged);
            // 
            // GPABeforeLab
            // 
            this.GPABeforeLab.AutoSize = true;
            this.GPABeforeLab.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPABeforeLab.ForeColor = global::Calculator.Properties.Settings.Default.FBgColorSet;
            this.GPABeforeLab.Location = new System.Drawing.Point(5, 15);
            this.GPABeforeLab.Name = "GPABeforeLab";
            this.GPABeforeLab.Size = new System.Drawing.Size(75, 15);
            this.GPABeforeLab.TabIndex = 0;
            this.GPABeforeLab.Text = "GPA before : ";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.TotalGPALab);
            this.panel3.Controls.Add(this.TotalUnitLab);
            this.panel3.Controls.Add(this.GPAbeforLab);
            this.panel3.Controls.Add(this.UnitBeforeLab);
            this.panel3.Controls.Add(this.GPAlab);
            this.panel3.Controls.Add(this.UnitSumation);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.line5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.line4);
            this.panel3.Controls.Add(this.line3);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.line2);
            this.panel3.Controls.Add(this.line1);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(302, 187);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(295, 196);
            this.panel3.TabIndex = 25;
            // 
            // TotalGPALab
            // 
            this.TotalGPALab.AutoSize = true;
            this.TotalGPALab.ForeColor = global::Calculator.Properties.Settings.Default.FBgColorSet;
            this.TotalGPALab.Location = new System.Drawing.Point(248, 148);
            this.TotalGPALab.Name = "TotalGPALab";
            this.TotalGPALab.Size = new System.Drawing.Size(13, 13);
            this.TotalGPALab.TabIndex = 35;
            this.TotalGPALab.Text = "0";
            // 
            // TotalUnitLab
            // 
            this.TotalUnitLab.AutoSize = true;
            this.TotalUnitLab.ForeColor = global::Calculator.Properties.Settings.Default.FBgColorSet;
            this.TotalUnitLab.Location = new System.Drawing.Point(248, 82);
            this.TotalUnitLab.Name = "TotalUnitLab";
            this.TotalUnitLab.Size = new System.Drawing.Size(13, 13);
            this.TotalUnitLab.TabIndex = 34;
            this.TotalUnitLab.Text = "0";
            // 
            // GPAbeforLab
            // 
            this.GPAbeforLab.AutoSize = true;
            this.GPAbeforLab.ForeColor = global::Calculator.Properties.Settings.Default.FBgColorSet;
            this.GPAbeforLab.Location = new System.Drawing.Point(169, 148);
            this.GPAbeforLab.Name = "GPAbeforLab";
            this.GPAbeforLab.Size = new System.Drawing.Size(13, 13);
            this.GPAbeforLab.TabIndex = 33;
            this.GPAbeforLab.Text = "0";
            // 
            // UnitBeforeLab
            // 
            this.UnitBeforeLab.AutoSize = true;
            this.UnitBeforeLab.ForeColor = global::Calculator.Properties.Settings.Default.FBgColorSet;
            this.UnitBeforeLab.Location = new System.Drawing.Point(169, 82);
            this.UnitBeforeLab.Name = "UnitBeforeLab";
            this.UnitBeforeLab.Size = new System.Drawing.Size(13, 13);
            this.UnitBeforeLab.TabIndex = 32;
            this.UnitBeforeLab.Text = "0";
            // 
            // GPAlab
            // 
            this.GPAlab.AutoSize = true;
            this.GPAlab.ForeColor = global::Calculator.Properties.Settings.Default.FBgColorSet;
            this.GPAlab.Location = new System.Drawing.Point(81, 148);
            this.GPAlab.Name = "GPAlab";
            this.GPAlab.Size = new System.Drawing.Size(13, 13);
            this.GPAlab.TabIndex = 31;
            this.GPAlab.Text = "0";
            // 
            // UnitSumation
            // 
            this.UnitSumation.AutoSize = true;
            this.UnitSumation.ForeColor = global::Calculator.Properties.Settings.Default.FBgColorSet;
            this.UnitSumation.Location = new System.Drawing.Point(79, 82);
            this.UnitSumation.Name = "UnitSumation";
            this.UnitSumation.Size = new System.Drawing.Size(13, 13);
            this.UnitSumation.TabIndex = 30;
            this.UnitSumation.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = global::Calculator.Properties.Settings.Default.FBgColorSet;
            this.label12.Location = new System.Drawing.Point(242, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 15);
            this.label12.TabIndex = 29;
            this.label12.Text = "Total";
            // 
            // line5
            // 
            this.line5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.line5.ForeColor = global::Calculator.Properties.Settings.Default.FBgColorSet;
            this.line5.Location = new System.Drawing.Point(228, -2);
            this.line5.Name = "line5";
            this.line5.Size = new System.Drawing.Size(2, 196);
            this.line5.TabIndex = 28;
            this.line5.Text = "label9";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = global::Calculator.Properties.Settings.Default.FBgColorSet;
            this.label6.Location = new System.Drawing.Point(164, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 15);
            this.label6.TabIndex = 27;
            this.label6.Text = "Before";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = global::Calculator.Properties.Settings.Default.FBgColorSet;
            this.label5.Location = new System.Drawing.Point(66, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 26;
            this.label5.Text = "Semester";
            // 
            // line4
            // 
            this.line4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.line4.ForeColor = global::Calculator.Properties.Settings.Default.FBgColorSet;
            this.line4.Location = new System.Drawing.Point(140, -2);
            this.line4.Name = "line4";
            this.line4.Size = new System.Drawing.Size(2, 196);
            this.line4.TabIndex = 25;
            this.line4.Text = "label4";
            // 
            // line3
            // 
            this.line3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.line3.ForeColor = global::Calculator.Properties.Settings.Default.FBgColorSet;
            this.line3.Location = new System.Drawing.Point(49, 0);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(2, 196);
            this.line3.TabIndex = 24;
            this.line3.Text = "label3";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = global::Calculator.Properties.Settings.Default.FBgColorSet;
            this.label11.Location = new System.Drawing.Point(3, 141);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 17);
            this.label11.TabIndex = 21;
            this.label11.Text = "GPA";
            // 
            // line2
            // 
            this.line2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.line2.ForeColor = global::Calculator.Properties.Settings.Default.FBgColorSet;
            this.line2.Location = new System.Drawing.Point(1, 120);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(300, 2);
            this.line2.TabIndex = 20;
            this.line2.Text = "label10";
            // 
            // line1
            // 
            this.line1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.line1.ForeColor = global::Calculator.Properties.Settings.Default.FBgColorSet;
            this.line1.Location = new System.Drawing.Point(1, 56);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(300, 2);
            this.line1.TabIndex = 2;
            this.line1.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = global::Calculator.Properties.Settings.Default.FBgColorSet;
            this.label7.Location = new System.Drawing.Point(3, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Uints";
            // 
            // BackImg
            // 
            this.BackImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackImg.Image = global::Calculator.Properties.Resources.Exit;
            this.BackImg.Location = new System.Drawing.Point(10, 12);
            this.BackImg.Name = "BackImg";
            this.BackImg.Size = new System.Drawing.Size(40, 35);
            this.BackImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackImg.TabIndex = 26;
            this.BackImg.TabStop = false;
            this.BackImg.Click += new System.EventHandler(this.BackImg_Click);
            // 
            // DeletetImg
            // 
            this.DeletetImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeletetImg.Image = ((System.Drawing.Image)(resources.GetObject("DeletetImg.Image")));
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
            this.DiscardImg.Image = ((System.Drawing.Image)(resources.GetObject("DiscardImg.Image")));
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
            this.ClientSize = new System.Drawing.Size(613, 632);
            this.Controls.Add(this.BackImg);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GpaNameLab);
            this.Controls.Add(this.DeletetImg);
            this.Controls.Add(this.DiscardImg);
            this.Controls.Add(this.UnitTBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CB_Degree);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.LabNumberofUnit);
            this.Controls.Add(this.labDegree);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(629, 671);
            this.MinimumSize = new System.Drawing.Size(629, 671);
            this.Name = "Calac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calc";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Calac_FormClosed);
            this.Load += new System.EventHandler(this.Calac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackImg)).EndInit();
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
        private PictureBox DiscardImg;
        private PictureBox DeletetImg;
        private ToolTip toolTip1;
        private Label GpaNameLab;
        private TextBox UnitTBox;
        private Label LabNumberofUnit;
        private Panel panel1;
        private TextBox GPA_TxT;
        private Label GPABeforeLab;
        private TextBox UnitbeforeTxT;
        private Label uBeforeLab;
        private Button CalculateTotalbtn;
        private Panel panel3;
        private Label line3;
        private Label label11;
        private Label line2;
        private Label line1;
        private Label label7;
        private Label GPAlab;
        private Label UnitSumation;
        private Label label12;
        private Label line5;
        private Label label6;
        private Label label5;
        private Label line4;
        private Label TotalGPALab;
        private Label TotalUnitLab;
        private Label GPAbeforLab;
        private Label UnitBeforeLab;
        private PictureBox BackImg;
    }
}

