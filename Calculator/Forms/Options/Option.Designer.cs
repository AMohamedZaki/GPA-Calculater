using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Calculator.Properties;

namespace Calculator.Forms.Options
{
    partial class Option
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Option));
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.RemoveImg = new System.Windows.Forms.PictureBox();
            this.DoneImg = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDegree = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.GBAbtn = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RemoveImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoneImg)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 22);
            this.label5.TabIndex = 25;
            this.label5.Text = "Setting";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.RemoveImg);
            this.panel3.Controls.Add(this.DoneImg);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.cbDegree);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.GBAbtn);
            this.panel3.Location = new System.Drawing.Point(22, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(442, 196);
            this.panel3.TabIndex = 24;
            // 
            // RemoveImg
            // 
            this.RemoveImg.Image = global::Calculator.Properties.Resources.matticonssoftwareinstallerpurge1;
            this.RemoveImg.Location = new System.Drawing.Point(379, 139);
            this.RemoveImg.Name = "RemoveImg";
            this.RemoveImg.Size = new System.Drawing.Size(35, 31);
            this.RemoveImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RemoveImg.TabIndex = 26;
            this.RemoveImg.TabStop = false;
            this.RemoveImg.Visible = false;
            // 
            // DoneImg
            // 
            this.DoneImg.Image = global::Calculator.Properties.Resources.Done;
            this.DoneImg.Location = new System.Drawing.Point(379, 139);
            this.DoneImg.Name = "DoneImg";
            this.DoneImg.Size = new System.Drawing.Size(35, 31);
            this.DoneImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DoneImg.TabIndex = 25;
            this.DoneImg.TabStop = false;
            this.DoneImg.Visible = false;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(189, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2, 196);
            this.label1.TabIndex = 24;
            this.label1.Text = "label1";
            // 
            // cbDegree
            // 
            this.cbDegree.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDegree.FormattingEnabled = true;
            this.cbDegree.Location = new System.Drawing.Point(224, 139);
            this.cbDegree.Name = "cbDegree";
            this.cbDegree.Size = new System.Drawing.Size(149, 21);
            this.cbDegree.TabIndex = 22;
            this.cbDegree.SelectedIndexChanged += new System.EventHandler(this.cbDegree_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 141);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(150, 17);
            this.label11.TabIndex = 21;
            this.label11.Text = "Default Gpa Calculater";
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(1, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(565, 2);
            this.label10.TabIndex = 20;
            this.label10.Text = "label10";
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(1, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(565, 2);
            this.label8.TabIndex = 2;
            this.label8.Text = "label8";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(224, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 34);
            this.button2.TabIndex = 19;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Edit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Edit GPA Calculater";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Create GPA Calculater";
            // 
            // GBAbtn
            // 
            this.GBAbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(255)))));
            this.GBAbtn.Location = new System.Drawing.Point(224, 12);
            this.GBAbtn.Name = "GBAbtn";
            this.GBAbtn.Size = new System.Drawing.Size(103, 34);
            this.GBAbtn.TabIndex = 17;
            this.GBAbtn.Text = "CreateGPA";
            this.GBAbtn.UseVisualStyleBackColor = false;
            this.GBAbtn.Click += new System.EventHandler(this.GBAbtn_Click_1);
            // 
            // Option
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::Calculator.Properties.Settings.Default.BgColorSet;
            this.ClientSize = new System.Drawing.Size(486, 275);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(502, 314);
            this.MinimumSize = new System.Drawing.Size(502, 314);
            this.Name = "Option";
            this.Text = "Option";
            this.Load += new System.EventHandler(this.Option_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RemoveImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoneImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label5;
        private Panel panel3;
        private Button button2;
        private Label label7;
        private Label label6;
        private Button GBAbtn;
        private Label label8;
        private ComboBox cbDegree;
        private Label label11;
        private Label label10;
        private Label label1;
        private PictureBox DoneImg;
        private PictureBox RemoveImg;
    }
}