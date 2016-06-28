using System.Drawing;
using Calculator.Properties;
namespace Calculator.Forms.GPA
{
    partial class CreateGpa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateGpa));
            this.DegreedataGridView = new System.Windows.Forms.DataGridView();
            this.Degree_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GpaCreateTxT = new System.Windows.Forms.TextBox();
            this.GpaNameLab = new System.Windows.Forms.Label();
            this.GpaCreateLab = new System.Windows.Forms.Label();
            this.Savebtn = new System.Windows.Forms.Button();
            this.Checkbtn = new System.Windows.Forms.Button();
            this.GPAIdlab = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DoneMessageLab = new System.Windows.Forms.Label();
            this.BackImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DegreedataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackImg)).BeginInit();
            this.SuspendLayout();
            // 
            // DegreedataGridView
            // 
            this.DegreedataGridView.AllowUserToResizeColumns = false;
            this.DegreedataGridView.AllowUserToResizeRows = false;
            this.DegreedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DegreedataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Degree_Name,
            this.Value});
            this.DegreedataGridView.Location = new System.Drawing.Point(97, 125);
            this.DegreedataGridView.Name = "DegreedataGridView";
            this.DegreedataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DegreedataGridView.Size = new System.Drawing.Size(260, 170);
            this.DegreedataGridView.TabIndex = 14;
            this.DegreedataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.DegreedataGridView_CellValidating);
            // 
            // Degree_Name
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Degree_Name.DefaultCellStyle = dataGridViewCellStyle1;
            this.Degree_Name.HeaderText = "Degree Name";
            this.Degree_Name.Name = "Degree_Name";
            this.Degree_Name.Width = 105;
            // 
            // Value
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Value.DefaultCellStyle = dataGridViewCellStyle2;
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            this.Value.Width = 111;
            // 
            // GpaCreateTxT
            // 
            this.GpaCreateTxT.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GpaCreateTxT.Location = new System.Drawing.Point(99, 81);
            this.GpaCreateTxT.Name = "GpaCreateTxT";
            this.GpaCreateTxT.Size = new System.Drawing.Size(258, 21);
            this.GpaCreateTxT.TabIndex = 10;
            this.GpaCreateTxT.TextChanged += new System.EventHandler(this.GpaCreateTxT_TextChanged);
            // 
            // GpaNameLab
            // 
            this.GpaNameLab.AutoSize = true;
            this.GpaNameLab.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GpaNameLab.ForeColor = global::Calculator.Properties.Settings.Default.FBgColorSet;
            this.GpaNameLab.Location = new System.Drawing.Point(15, 82);
            this.GpaNameLab.Name = "GpaNameLab";
            this.GpaNameLab.Size = new System.Drawing.Size(82, 17);
            this.GpaNameLab.TabIndex = 9;
            this.GpaNameLab.Text = "GPA Name :";
            // 
            // GpaCreateLab
            // 
            this.GpaCreateLab.AutoSize = true;
            this.GpaCreateLab.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GpaCreateLab.ForeColor = global::Calculator.Properties.Settings.Default.FBgColorSet;
            this.GpaCreateLab.Location = new System.Drawing.Point(124, 20);
            this.GpaCreateLab.Name = "GpaCreateLab";
            this.GpaCreateLab.Size = new System.Drawing.Size(136, 19);
            this.GpaCreateLab.TabIndex = 8;
            this.GpaCreateLab.Text = "Create Your GPA :-";
            // 
            // Savebtn
            // 
            this.Savebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(166)))), ((int)(((byte)(255)))));
            this.Savebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Savebtn.Location = new System.Drawing.Point(97, 306);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(73, 33);
            this.Savebtn.TabIndex = 15;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = false;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // Checkbtn
            // 
            this.Checkbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(0)))));
            this.Checkbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Checkbtn.Location = new System.Drawing.Point(179, 306);
            this.Checkbtn.Name = "Checkbtn";
            this.Checkbtn.Size = new System.Drawing.Size(65, 33);
            this.Checkbtn.TabIndex = 16;
            this.Checkbtn.Text = "Check";
            this.Checkbtn.UseVisualStyleBackColor = false;
            this.Checkbtn.Click += new System.EventHandler(this.Checkbtn_Click);
            // 
            // GPAIdlab
            // 
            this.GPAIdlab.AutoSize = true;
            this.GPAIdlab.Location = new System.Drawing.Point(407, 9);
            this.GPAIdlab.Name = "GPAIdlab";
            this.GPAIdlab.Size = new System.Drawing.Size(38, 13);
            this.GPAIdlab.TabIndex = 17;
            this.GPAIdlab.Text = "GPAId";
            this.GPAIdlab.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Calculator.Properties.Resources.Done;
            this.pictureBox1.Location = new System.Drawing.Point(3, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DoneMessageLab);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(99, 348);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 82);
            this.panel1.TabIndex = 19;
            this.panel1.Visible = false;
            // 
            // DoneMessageLab
            // 
            this.DoneMessageLab.AutoSize = true;
            this.DoneMessageLab.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoneMessageLab.ForeColor = global::Calculator.Properties.Settings.Default.FBgColorSet;
            this.DoneMessageLab.Location = new System.Drawing.Point(39, 23);
            this.DoneMessageLab.Name = "DoneMessageLab";
            this.DoneMessageLab.Size = new System.Drawing.Size(217, 17);
            this.DoneMessageLab.TabIndex = 19;
            this.DoneMessageLab.Text = "Done your GPA has been Created \r\n";
            // 
            // BackImg
            // 
            this.BackImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackImg.Image = global::Calculator.Properties.Resources.Exit;
            this.BackImg.Location = new System.Drawing.Point(12, 9);
            this.BackImg.Name = "BackImg";
            this.BackImg.Size = new System.Drawing.Size(40, 35);
            this.BackImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackImg.TabIndex = 20;
            this.BackImg.TabStop = false;
            this.BackImg.Click += new System.EventHandler(this.BackImg_Click);
            // 
            // CreateGpa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::Calculator.Properties.Settings.Default.BgColorSet;
            this.ClientSize = new System.Drawing.Size(447, 445);
            this.Controls.Add(this.BackImg);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GPAIdlab);
            this.Controls.Add(this.Checkbtn);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.DegreedataGridView);
            this.Controls.Add(this.GpaCreateTxT);
            this.Controls.Add(this.GpaNameLab);
            this.Controls.Add(this.GpaCreateLab);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(463, 484);
            this.MinimumSize = new System.Drawing.Size(463, 484);
            this.Name = "CreateGpa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create_Gpa";
            this.Load += new System.EventHandler(this.Create_Gpa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DegreedataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DegreedataGridView;
        private System.Windows.Forms.TextBox GpaCreateTxT;
        private System.Windows.Forms.Label GpaNameLab;
        private System.Windows.Forms.Label GpaCreateLab;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.Button Checkbtn;
        private System.Windows.Forms.Label GPAIdlab;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Degree_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label DoneMessageLab;
        private System.Windows.Forms.PictureBox BackImg;
    }
}