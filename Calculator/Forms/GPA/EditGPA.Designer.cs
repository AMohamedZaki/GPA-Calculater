using System.Drawing;
using Calculator.Properties;
namespace Calculator.Forms.GPA
{
    partial class EditGpa
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
            this.EditGpaLab = new System.Windows.Forms.Label();
            this.GPAcomboBox = new System.Windows.Forms.ComboBox();
            this.YGpaCalcaLab = new System.Windows.Forms.Label();
            this.Gpa_NameTXT = new System.Windows.Forms.TextBox();
            this.GNameLab = new System.Windows.Forms.Label();
            this.Linelab = new System.Windows.Forms.Label();
            this.DegreeLab = new System.Windows.Forms.Label();
            this.DegreeTxT = new System.Windows.Forms.TextBox();
            this.ValueLab = new System.Windows.Forms.Label();
            this.ValueTxT = new System.Windows.Forms.TextBox();
            this.Addbtn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.GradesGridView = new System.Windows.Forms.DataGridView();
            this.editGpImg = new System.Windows.Forms.PictureBox();
            this.removeGpImg = new System.Windows.Forms.PictureBox();
            this.DeletetImg = new System.Windows.Forms.PictureBox();
            this.DiscardImg = new System.Windows.Forms.PictureBox();
            this.BackImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GradesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editGpImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.removeGpImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeletetImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiscardImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackImg)).BeginInit();
            this.SuspendLayout();
            // 
            // EditGpaLab
            // 
            this.EditGpaLab.AutoSize = true;
            this.EditGpaLab.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditGpaLab.ForeColor = global::Calculator.Properties.Settings.Default.FBgColorSet;
            this.EditGpaLab.Location = new System.Drawing.Point(244, 9);
            this.EditGpaLab.Name = "EditGpaLab";
            this.EditGpaLab.Size = new System.Drawing.Size(104, 19);
            this.EditGpaLab.TabIndex = 0;
            this.EditGpaLab.Text = "Edit Your GPA";
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
            // YGpaCalcaLab
            // 
            this.YGpaCalcaLab.AutoSize = true;
            this.YGpaCalcaLab.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YGpaCalcaLab.ForeColor = global::Calculator.Properties.Settings.Default.FBgColorSet;
            this.YGpaCalcaLab.Location = new System.Drawing.Point(8, 68);
            this.YGpaCalcaLab.Name = "YGpaCalcaLab";
            this.YGpaCalcaLab.Size = new System.Drawing.Size(143, 19);
            this.YGpaCalcaLab.TabIndex = 2;
            this.YGpaCalcaLab.Text = "Your GPA Calculater :";
            // 
            // Gpa_NameTXT
            // 
            this.Gpa_NameTXT.Location = new System.Drawing.Point(352, 120);
            this.Gpa_NameTXT.Name = "Gpa_NameTXT";
            this.Gpa_NameTXT.Size = new System.Drawing.Size(160, 20);
            this.Gpa_NameTXT.TabIndex = 1;
            this.Gpa_NameTXT.TextChanged += new System.EventHandler(this.Gpa_NameTXT_TextChanged);
            // 
            // GNameLab
            // 
            this.GNameLab.AutoSize = true;
            this.GNameLab.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GNameLab.ForeColor = global::Calculator.Properties.Settings.Default.FBgColorSet;
            this.GNameLab.Location = new System.Drawing.Point(280, 123);
            this.GNameLab.Name = "GNameLab";
            this.GNameLab.Size = new System.Drawing.Size(70, 15);
            this.GNameLab.TabIndex = 0;
            this.GNameLab.Text = "GPA Name :";
            // 
            // Linelab
            // 
            this.Linelab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Linelab.Location = new System.Drawing.Point(264, 154);
            this.Linelab.Name = "Linelab";
            this.Linelab.Size = new System.Drawing.Size(316, 2);
            this.Linelab.TabIndex = 21;
            this.Linelab.Text = "label10";
            // 
            // DegreeLab
            // 
            this.DegreeLab.AutoSize = true;
            this.DegreeLab.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DegreeLab.ForeColor = global::Calculator.Properties.Settings.Default.FBgColorSet;
            this.DegreeLab.Location = new System.Drawing.Point(288, 189);
            this.DegreeLab.Name = "DegreeLab";
            this.DegreeLab.Size = new System.Drawing.Size(61, 17);
            this.DegreeLab.TabIndex = 23;
            this.DegreeLab.Text = "Degree :";
            // 
            // DegreeTxT
            // 
            this.DegreeTxT.Enabled = false;
            this.DegreeTxT.Location = new System.Drawing.Point(352, 192);
            this.DegreeTxT.Name = "DegreeTxT";
            this.DegreeTxT.Size = new System.Drawing.Size(160, 20);
            this.DegreeTxT.TabIndex = 24;
            // 
            // ValueLab
            // 
            this.ValueLab.AutoSize = true;
            this.ValueLab.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValueLab.ForeColor = global::Calculator.Properties.Settings.Default.FBgColorSet;
            this.ValueLab.Location = new System.Drawing.Point(296, 239);
            this.ValueLab.Name = "ValueLab";
            this.ValueLab.Size = new System.Drawing.Size(52, 17);
            this.ValueLab.TabIndex = 25;
            this.ValueLab.Text = "Value :";
            // 
            // ValueTxT
            // 
            this.ValueTxT.Enabled = false;
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
            // GradesGridView
            // 
            this.GradesGridView.AllowUserToAddRows = false;
            this.GradesGridView.AllowUserToDeleteRows = false;
            this.GradesGridView.AllowUserToResizeColumns = false;
            this.GradesGridView.AllowUserToResizeRows = false;
            this.GradesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GradesGridView.Location = new System.Drawing.Point(15, 118);
            this.GradesGridView.Name = "GradesGridView";
            this.GradesGridView.ReadOnly = true;
            this.GradesGridView.RowHeadersVisible = false;
            this.GradesGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GradesGridView.Size = new System.Drawing.Size(247, 236);
            this.GradesGridView.TabIndex = 30;
            // 
            // editGpImg
            // 
            this.editGpImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editGpImg.Image = global::Calculator.Properties.Resources.Eidt1;
            this.editGpImg.Location = new System.Drawing.Point(522, 118);
            this.editGpImg.Name = "editGpImg";
            this.editGpImg.Size = new System.Drawing.Size(23, 24);
            this.editGpImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.editGpImg.TabIndex = 33;
            this.editGpImg.TabStop = false;
            this.editGpImg.Visible = false;
            this.editGpImg.Click += new System.EventHandler(this.editGpImg_Click);
            // 
            // removeGpImg
            // 
            this.removeGpImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeGpImg.Image = ((System.Drawing.Image)(resources.GetObject("removeGpImg.Image")));
            this.removeGpImg.Location = new System.Drawing.Point(551, 118);
            this.removeGpImg.Name = "removeGpImg";
            this.removeGpImg.Size = new System.Drawing.Size(23, 24);
            this.removeGpImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.removeGpImg.TabIndex = 32;
            this.removeGpImg.TabStop = false;
            this.removeGpImg.Visible = false;
            this.removeGpImg.Click += new System.EventHandler(this.removeGpImg_Click);
            // 
            // DeletetImg
            // 
            this.DeletetImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeletetImg.Image = ((System.Drawing.Image)(resources.GetObject("DeletetImg.Image")));
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
            this.DiscardImg.Image = ((System.Drawing.Image)(resources.GetObject("DiscardImg.Image")));
            this.DiscardImg.Location = new System.Drawing.Point(445, 289);
            this.DiscardImg.Name = "DiscardImg";
            this.DiscardImg.Size = new System.Drawing.Size(23, 23);
            this.DiscardImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DiscardImg.TabIndex = 28;
            this.DiscardImg.TabStop = false;
            this.DiscardImg.Visible = false;
            this.DiscardImg.Click += new System.EventHandler(this.DiscardImg_Click);
            // 
            // BackImg
            // 
            this.BackImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackImg.Image = global::Calculator.Properties.Resources.Exit;
            this.BackImg.Location = new System.Drawing.Point(15, 9);
            this.BackImg.Name = "BackImg";
            this.BackImg.Size = new System.Drawing.Size(40, 35);
            this.BackImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackImg.TabIndex = 34;
            this.BackImg.TabStop = false;
            this.BackImg.Click += new System.EventHandler(this.BackImg_Click);
            // 
            // EditGpa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::Calculator.Properties.Settings.Default.BgColorSet;
            this.ClientSize = new System.Drawing.Size(578, 374);
            this.Controls.Add(this.BackImg);
            this.Controls.Add(this.editGpImg);
            this.Controls.Add(this.removeGpImg);
            this.Controls.Add(this.GradesGridView);
            this.Controls.Add(this.DeletetImg);
            this.Controls.Add(this.DiscardImg);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.ValueTxT);
            this.Controls.Add(this.ValueLab);
            this.Controls.Add(this.DegreeTxT);
            this.Controls.Add(this.DegreeLab);
            this.Controls.Add(this.Linelab);
            this.Controls.Add(this.YGpaCalcaLab);
            this.Controls.Add(this.GPAcomboBox);
            this.Controls.Add(this.EditGpaLab);
            this.Controls.Add(this.Gpa_NameTXT);
            this.Controls.Add(this.GNameLab);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(594, 413);
            this.MinimumSize = new System.Drawing.Size(594, 413);
            this.Name = "EditGpa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditGPA";
            this.Load += new System.EventHandler(this.EditGpa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GradesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editGpImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.removeGpImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeletetImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiscardImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EditGpaLab;
        private System.Windows.Forms.ComboBox GPAcomboBox;
        private System.Windows.Forms.Label YGpaCalcaLab;
        private System.Windows.Forms.TextBox Gpa_NameTXT;
        private System.Windows.Forms.Label GNameLab;
        private System.Windows.Forms.Label Linelab;
        private System.Windows.Forms.Label DegreeLab;
        private System.Windows.Forms.TextBox DegreeTxT;
        private System.Windows.Forms.Label ValueLab;
        private System.Windows.Forms.TextBox ValueTxT;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.PictureBox DeletetImg;
        private System.Windows.Forms.PictureBox DiscardImg;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridView GradesGridView;
        private System.Windows.Forms.PictureBox removeGpImg;
        private System.Windows.Forms.PictureBox editGpImg;
        private System.Windows.Forms.PictureBox BackImg;
    }
}