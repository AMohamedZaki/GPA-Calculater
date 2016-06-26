using System.ComponentModel;
using System.Windows.Forms;
using Calculator.Properties;

namespace Calculator.Forms
{
    partial class Welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            this.UserNametxt = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Datelab = new System.Windows.Forms.Label();
            this.facebookimg = new System.Windows.Forms.PictureBox();
            this.Githubimg = new System.Windows.Forms.PictureBox();
            this.GPA_Calc = new System.Windows.Forms.PictureBox();
            this.OptionImg = new System.Windows.Forms.PictureBox();
            this.ColorPiker = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.facebookimg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Githubimg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GPA_Calc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OptionImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorPiker)).BeginInit();
            this.SuspendLayout();
            // 
            // UserNametxt
            // 
            this.UserNametxt.AutoSize = true;
            this.UserNametxt.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNametxt.ForeColor = global::Calculator.Properties.Settings.Default.FBgColorSet;
            this.UserNametxt.Location = new System.Drawing.Point(9, 52);
            this.UserNametxt.Name = "UserNametxt";
            this.UserNametxt.Size = new System.Drawing.Size(67, 16);
            this.UserNametxt.TabIndex = 6;
            this.UserNametxt.Text = "UserName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SketchFlow Print", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 29);
            this.label1.TabIndex = 18;
            this.label1.Text = "GPA";
            // 
            // Datelab
            // 
            this.Datelab.AutoSize = true;
            this.Datelab.Location = new System.Drawing.Point(9, 377);
            this.Datelab.Name = "Datelab";
            this.Datelab.Size = new System.Drawing.Size(44, 13);
            this.Datelab.TabIndex = 19;
            this.Datelab.Text = "Datelab";
            // 
            // facebookimg
            // 
            this.facebookimg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.facebookimg.Image = global::Calculator.Properties.Resources.facebook;
            this.facebookimg.Location = new System.Drawing.Point(232, 362);
            this.facebookimg.Name = "facebookimg";
            this.facebookimg.Size = new System.Drawing.Size(32, 34);
            this.facebookimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.facebookimg.TabIndex = 22;
            this.facebookimg.TabStop = false;
            // 
            // Githubimg
            // 
            this.Githubimg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Githubimg.Image = global::Calculator.Properties.Resources.github;
            this.Githubimg.Location = new System.Drawing.Point(197, 362);
            this.Githubimg.Name = "Githubimg";
            this.Githubimg.Size = new System.Drawing.Size(32, 34);
            this.Githubimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Githubimg.TabIndex = 21;
            this.Githubimg.TabStop = false;
            // 
            // GPA_Calc
            // 
            this.GPA_Calc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GPA_Calc.Image = global::Calculator.Properties.Resources.GPAUnits;
            this.GPA_Calc.Location = new System.Drawing.Point(12, 90);
            this.GPA_Calc.Name = "GPA_Calc";
            this.GPA_Calc.Size = new System.Drawing.Size(157, 223);
            this.GPA_Calc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GPA_Calc.TabIndex = 20;
            this.GPA_Calc.TabStop = false;
            this.GPA_Calc.Click += new System.EventHandler(this.GPA_Calc_Click);
            // 
            // OptionImg
            // 
            this.OptionImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OptionImg.Image = global::Calculator.Properties.Resources.Setting;
            this.OptionImg.Location = new System.Drawing.Point(220, 196);
            this.OptionImg.Name = "OptionImg";
            this.OptionImg.Size = new System.Drawing.Size(32, 34);
            this.OptionImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OptionImg.TabIndex = 16;
            this.OptionImg.TabStop = false;
            this.OptionImg.Click += new System.EventHandler(this.OptionImg_Click);
            // 
            // ColorPiker
            // 
            this.ColorPiker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ColorPiker.Image = global::Calculator.Properties.Resources.stocktoolcolorpicker;
            this.ColorPiker.Location = new System.Drawing.Point(220, 143);
            this.ColorPiker.Name = "ColorPiker";
            this.ColorPiker.Size = new System.Drawing.Size(32, 34);
            this.ColorPiker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ColorPiker.TabIndex = 14;
            this.ColorPiker.TabStop = false;
            this.ColorPiker.Click += new System.EventHandler(this.ColorPiker_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::Calculator.Properties.Settings.Default.BgColorSet;
            this.ClientSize = new System.Drawing.Size(264, 408);
            this.Controls.Add(this.facebookimg);
            this.Controls.Add(this.Githubimg);
            this.Controls.Add(this.GPA_Calc);
            this.Controls.Add(this.Datelab);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OptionImg);
            this.Controls.Add(this.ColorPiker);
            this.Controls.Add(this.UserNametxt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(280, 447);
            this.MinimumSize = new System.Drawing.Size(280, 447);
            this.Name = "Welcome";
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.Welcome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.facebookimg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Githubimg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GPA_Calc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OptionImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorPiker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label UserNametxt;
        private PictureBox ColorPiker;
        private PictureBox OptionImg;
        private ToolTip toolTip;
        private Label label1;
        private Label Datelab;
        private PictureBox GPA_Calc;
        private PictureBox Githubimg;
        private PictureBox facebookimg;
    }
}