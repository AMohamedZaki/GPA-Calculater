using System.Drawing;

namespace Calculator.Forms
{
    partial class PleaseWait
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PleaseWait));
            this.LoadingImg = new System.Windows.Forms.PictureBox();
            this.PleaseWaitLab = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingImg)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadingImg
            // 
            this.LoadingImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoadingImg.Image = global::Calculator.Properties.Resources.l7Wu1Bn;
            this.LoadingImg.Location = new System.Drawing.Point(0, 0);
            this.LoadingImg.MaximumSize = new System.Drawing.Size(311, 268);
            this.LoadingImg.MinimumSize = new System.Drawing.Size(311, 268);
            this.LoadingImg.Name = "LoadingImg";
            this.LoadingImg.Size = new System.Drawing.Size(311, 268);
            this.LoadingImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LoadingImg.TabIndex = 0;
            this.LoadingImg.TabStop = false;
            // 
            // PleaseWaitLab
            // 
            this.PleaseWaitLab.AutoSize = true;
            this.PleaseWaitLab.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PleaseWaitLab.Location = new System.Drawing.Point(115, 220);
            this.PleaseWaitLab.Name = "PleaseWaitLab";
            this.PleaseWaitLab.Size = new System.Drawing.Size(76, 13);
            this.PleaseWaitLab.TabIndex = 1;
            this.PleaseWaitLab.Text = "Please Wait .. ";
            this.PleaseWaitLab.Click += new System.EventHandler(this.PleaseWaitLab_Click);
            // 
            // PleaseWait
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(311, 268);
            this.Controls.Add(this.PleaseWaitLab);
            this.Controls.Add(this.LoadingImg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(311, 268);
            this.MinimumSize = new System.Drawing.Size(311, 268);
            this.Name = "PleaseWait";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PleaseWait";
            this.Load += new System.EventHandler(this.PleaseWait_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LoadingImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LoadingImg;
        private System.Windows.Forms.Label PleaseWaitLab;
    }
}