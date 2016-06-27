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
            this.settinglab = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.RemoveImg = new System.Windows.Forms.PictureBox();
            this.DoneImg = new System.Windows.Forms.PictureBox();
            this.line3 = new System.Windows.Forms.Label();
            this.cbDegree = new System.Windows.Forms.ComboBox();
            this.DefualtgpaLab = new System.Windows.Forms.Label();
            this.line2 = new System.Windows.Forms.Label();
            this.line1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.gpacalcLab = new System.Windows.Forms.Label();
            this.CreagpaclacLab = new System.Windows.Forms.Label();
            this.GBAbtn = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RemoveImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoneImg)).BeginInit();
            this.SuspendLayout();
            // 
            // settinglab
            // 
            this.settinglab.AutoSize = true;
            this.settinglab.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settinglab.ForeColor = global::Calculator.Properties.Settings.Default.FBgColorSet;
            this.settinglab.Location = new System.Drawing.Point(26, 9);
            this.settinglab.Name = "settinglab";
            this.settinglab.Size = new System.Drawing.Size(64, 22);
            this.settinglab.TabIndex = 25;
            this.settinglab.Text = "Setting";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.RemoveImg);
            this.panel3.Controls.Add(this.DoneImg);
            this.panel3.Controls.Add(this.line3);
            this.panel3.Controls.Add(this.cbDegree);
            this.panel3.Controls.Add(this.DefualtgpaLab);
            this.panel3.Controls.Add(this.line2);
            this.panel3.Controls.Add(this.line1);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.gpacalcLab);
            this.panel3.Controls.Add(this.CreagpaclacLab);
            this.panel3.Controls.Add(this.GBAbtn);
            this.panel3.Location = new System.Drawing.Point(22, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(442, 196);
            this.panel3.TabIndex = 24;
            // 
            // RemoveImg
            // 
            this.RemoveImg.Image = global::Calculator.Properties.Resources.matticonssoftwareinstallerpurge1;
            this.RemoveImg.Location = new System.Drawing.Point(379, 138);
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
            // line3
            // 
            this.line3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.line3.Location = new System.Drawing.Point(189, 0);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(2, 196);
            this.line3.TabIndex = 24;
            this.line3.Text = "label1";
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
            // DefualtgpaLab
            // 
            this.DefualtgpaLab.AutoSize = true;
            this.DefualtgpaLab.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DefualtgpaLab.ForeColor = global::Calculator.Properties.Settings.Default.FBgColorSet;
            this.DefualtgpaLab.Location = new System.Drawing.Point(3, 141);
            this.DefualtgpaLab.Name = "DefualtgpaLab";
            this.DefualtgpaLab.Size = new System.Drawing.Size(150, 17);
            this.DefualtgpaLab.TabIndex = 21;
            this.DefualtgpaLab.Text = "Default Gpa Calculater";
            // 
            // line2
            // 
            this.line2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.line2.ForeColor = System.Drawing.Color.Red;
            this.line2.Location = new System.Drawing.Point(1, 120);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(565, 2);
            this.line2.TabIndex = 20;
            this.line2.Text = "label10";
            // 
            // line1
            // 
            this.line1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.line1.Location = new System.Drawing.Point(1, 56);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(565, 2);
            this.line1.TabIndex = 2;
            this.line1.Text = "label8";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(0)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(224, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 34);
            this.button2.TabIndex = 19;
            this.button2.Text = "Show / Edit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Edit_Click);
            // 
            // gpacalcLab
            // 
            this.gpacalcLab.AutoSize = true;
            this.gpacalcLab.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpacalcLab.ForeColor = global::Calculator.Properties.Settings.Default.FBgColorSet;
            this.gpacalcLab.Location = new System.Drawing.Point(3, 78);
            this.gpacalcLab.Name = "gpacalcLab";
            this.gpacalcLab.Size = new System.Drawing.Size(102, 17);
            this.gpacalcLab.TabIndex = 18;
            this.gpacalcLab.Text = "GPA Calculater";
            // 
            // CreagpaclacLab
            // 
            this.CreagpaclacLab.AutoSize = true;
            this.CreagpaclacLab.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreagpaclacLab.ForeColor = global::Calculator.Properties.Settings.Default.FBgColorSet;
            this.CreagpaclacLab.Location = new System.Drawing.Point(3, 12);
            this.CreagpaclacLab.Name = "CreagpaclacLab";
            this.CreagpaclacLab.Size = new System.Drawing.Size(148, 17);
            this.CreagpaclacLab.TabIndex = 17;
            this.CreagpaclacLab.Text = "Create GPA Calculater";
            // 
            // GBAbtn
            // 
            this.GBAbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(255)))));
            this.GBAbtn.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.Controls.Add(this.settinglab);
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
        private Label settinglab;
        private Panel panel3;
        private Button button2;
        private Label gpacalcLab;
        private Label CreagpaclacLab;
        private Button GBAbtn;
        private Label line1;
        private ComboBox cbDegree;
        private Label DefualtgpaLab;
        private Label line2;
        private Label line3;
        private PictureBox DoneImg;
        private PictureBox RemoveImg;
    }
}