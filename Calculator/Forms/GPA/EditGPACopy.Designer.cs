using System.Drawing;
using Calculator.Properties;
using System.Windows.Forms;
namespace Calculator.Forms.GPA
{
    partial class EditGpaCopy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditGpa));
            this.label1 = new System.Windows.Forms.Label();
            this.GPAcomboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Cancelbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DoneImg = new System.Windows.Forms.PictureBox();
            this.Savebtn = new System.Windows.Forms.Button();
            this.Gpa_NameTXT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DegreeTxT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ValueTxT = new System.Windows.Forms.TextBox();
            this.Addbtn = new System.Windows.Forms.Button();
            this.DeletetImg = new System.Windows.Forms.PictureBox();
            this.DiscardImg = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.GradesGridView = new System.Windows.Forms.DataGridView();
            this.gradeIdLab = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoneImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeletetImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiscardImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GradesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit Your GPA";
            // 
            // GPAcomboBox
            // 
            this.GPAcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GPAcomboBox.FormattingEnabled = true;
            this.GPAcomboBox.Location = new System.Drawing.Point(156, 69);
            this.GPAcomboBox.Name = "GPAcomboBox";
            this.GPAcomboBox.Size = new System.Drawing.Size(159, 21);
            this.GPAcomboBox.TabIndex = 1;
            this.GPAcomboBox.SelectedIndexChanged += new System.EventHandler(this.GPAcomboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Your GPA Calculater :";
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.Cancelbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cancelbtn.Location = new System.Drawing.Point(370, 370);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(68, 35);
            this.Cancelbtn.TabIndex = 6;
            this.Cancelbtn.Text = "Cancel";
            this.Cancelbtn.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Calculator.Properties.Resources.matticonssoftwareinstallerpurge;
            this.pictureBox1.Location = new System.Drawing.Point(492, 370);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // DoneImg
            // 
            this.DoneImg.Image = global::Calculator.Properties.Resources.Done;
            this.DoneImg.Location = new System.Drawing.Point(451, 370);
            this.DoneImg.Name = "DoneImg";
            this.DoneImg.Size = new System.Drawing.Size(35, 35);
            this.DoneImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DoneImg.TabIndex = 4;
            this.DoneImg.TabStop = false;
            this.DoneImg.Click += new System.EventHandler(this.DoneImg_Click);
            // 
            // Savebtn
            // 
            this.Savebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(0)))));
            this.Savebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Savebtn.Location = new System.Drawing.Point(290, 370);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(75, 35);
            this.Savebtn.TabIndex = 3;
            this.Savebtn.Text = "Save All";
            this.Savebtn.UseVisualStyleBackColor = false;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // Gpa_NameTXT
            // 
            this.Gpa_NameTXT.Location = new System.Drawing.Point(352, 118);
            this.Gpa_NameTXT.Name = "Gpa_NameTXT";
            this.Gpa_NameTXT.Size = new System.Drawing.Size(160, 20);
            this.Gpa_NameTXT.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(280, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "GPA Name :";
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(290, 154);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(237, 2);
            this.label10.TabIndex = 21;
            this.label10.Text = "label10";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(290, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 2);
            this.label4.TabIndex = 22;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(288, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Degree :";
            // 
            // DegreeTxT
            // 
            this.DegreeTxT.Location = new System.Drawing.Point(352, 186);
            this.DegreeTxT.Name = "DegreeTxT";
            this.DegreeTxT.Size = new System.Drawing.Size(160, 20);
            this.DegreeTxT.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(296, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "Value :";
            // 
            // ValueTxT
            // 
            this.ValueTxT.Location = new System.Drawing.Point(352, 239);
            this.ValueTxT.Name = "ValueTxT";
            this.ValueTxT.Size = new System.Drawing.Size(160, 20);
            this.ValueTxT.TabIndex = 26;
            // 
            // Addbtn
            // 
            this.Addbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(166)))), ((int)(((byte)(255)))));
            this.Addbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Addbtn.Location = new System.Drawing.Point(370, 281);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(68, 35);
            this.Addbtn.TabIndex = 27;
            this.Addbtn.Text = "Add";
            this.Addbtn.UseVisualStyleBackColor = false;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // DeletetImg
            // 
            this.DeletetImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeletetImg.Image = global::Calculator.Properties.Resources.metro_icon;
            this.DeletetImg.Location = new System.Drawing.Point(476, 288);
            this.DeletetImg.Name = "DeletetImg";
            this.DeletetImg.Size = new System.Drawing.Size(23, 24);
            this.DeletetImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DeletetImg.TabIndex = 29;
            this.DeletetImg.TabStop = false;
            this.DeletetImg.Visible = false;
            this.DeletetImg.Click += new System.EventHandler(this.DeletetImg_Click);
            // 
            // DiscardImg
            // 
            this.DiscardImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DiscardImg.Image = global::Calculator.Properties.Resources.matticonssoftwareinstallerpurge1;
            this.DiscardImg.Location = new System.Drawing.Point(445, 289);
            this.DiscardImg.Name = "DiscardImg";
            this.DiscardImg.Size = new System.Drawing.Size(23, 23);
            this.DiscardImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DiscardImg.TabIndex = 28;
            this.DiscardImg.TabStop = false;
            this.DiscardImg.Visible = false;
            this.DiscardImg.Click += new System.EventHandler(this.DiscardImg_Click);
            // 
            // GradesGridView
            // 
            this.GradesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GradesGridView.Location = new System.Drawing.Point(17, 120);
            this.GradesGridView.Name = "GradesGridView";
            this.GradesGridView.RowHeadersVisible = false;
            this.GradesGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GradesGridView.Size = new System.Drawing.Size(247, 236);
            this.GradesGridView.TabIndex = 30;
            // 
            // gradeIdLab
            // 
            this.gradeIdLab.AutoSize = true;
            this.gradeIdLab.Location = new System.Drawing.Point(25, 411);
            this.gradeIdLab.Name = "gradeIdLab";
            this.gradeIdLab.Size = new System.Drawing.Size(43, 13);
            this.gradeIdLab.TabIndex = 31;
            this.gradeIdLab.Text = "gradeId";
            this.gradeIdLab.Visible = false;
            // 
            // EditGpa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::Calculator.Properties.Settings.Default.BgColorSet;
            this.ClientSize = new System.Drawing.Size(543, 433);
            this.Controls.Add(this.gradeIdLab);
            this.Controls.Add(this.GradesGridView);
            this.Controls.Add(this.DeletetImg);
            this.Controls.Add(this.DiscardImg);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.ValueTxT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DegreeTxT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Cancelbtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DoneImg);
            this.Controls.Add(this.GPAcomboBox);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Gpa_NameTXT);
            this.Controls.Add(this.label3);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.Name = "EditGpa";
            this.Text = "EditGPA";
            this.Load += new System.EventHandler(this.EditGpa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoneImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeletetImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiscardImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GradesGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox GPAcomboBox;
        private Label label2;
        private Button Savebtn;
        private TextBox Gpa_NameTXT;
        private Label label3;
        private PictureBox DoneImg;
        private PictureBox pictureBox1;
        private Button Cancelbtn;
        private Label label10;
        private Label label4;
        private Label label5;
        private TextBox DegreeTxT;
        private Label label6;
        private TextBox ValueTxT;
        private Button Addbtn;
        private PictureBox DeletetImg;
        private PictureBox DiscardImg;
        private ToolTip toolTip1;
        private DataGridView GradesGridView;
        private Label gradeIdLab;
    }
}