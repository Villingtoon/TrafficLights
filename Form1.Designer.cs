﻿namespace TrafficLights
{
    partial class TrafficLights
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
            this.Red = new System.Windows.Forms.PictureBox();
            this.Yellow = new System.Windows.Forms.PictureBox();
            this.Green = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Yellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Green)).BeginInit();
            this.SuspendLayout();
            // 
            // Red
            // 
            this.Red.Location = new System.Drawing.Point(10, 128);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(139, 136);
            this.Red.TabIndex = 0;
            this.Red.TabStop = false;
            // 
            // Yellow
            // 
            this.Yellow.Location = new System.Drawing.Point(12, 270);
            this.Yellow.Name = "Yellow";
            this.Yellow.Size = new System.Drawing.Size(139, 136);
            this.Yellow.TabIndex = 1;
            this.Yellow.TabStop = false;
            // 
            // Green
            // 
            this.Green.Location = new System.Drawing.Point(12, 414);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(139, 136);
            this.Green.TabIndex = 2;
            this.Green.TabStop = false;
            // 
            // TrafficLights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 560);
            this.Controls.Add(this.Green);
            this.Controls.Add(this.Yellow);
            this.Controls.Add(this.Red);
            this.Name = "TrafficLights";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Yellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Green)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Red;
        private System.Windows.Forms.PictureBox Yellow;
        private System.Windows.Forms.PictureBox Green;
    }
}

