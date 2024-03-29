﻿namespace DollarComputers
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.startNewOrderBtn = new System.Windows.Forms.Button();
            this.loadSavedOrderBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // startNewOrderBtn
            // 
            this.startNewOrderBtn.Location = new System.Drawing.Point(65, 128);
            this.startNewOrderBtn.Name = "startNewOrderBtn";
            this.startNewOrderBtn.Size = new System.Drawing.Size(184, 51);
            this.startNewOrderBtn.TabIndex = 0;
            this.startNewOrderBtn.Text = "Start a new order";
            this.startNewOrderBtn.UseVisualStyleBackColor = true;
            this.startNewOrderBtn.Click += new System.EventHandler(this.StartNewOrderBtn_Click);
            // 
            // loadSavedOrderBtn
            // 
            this.loadSavedOrderBtn.Location = new System.Drawing.Point(65, 244);
            this.loadSavedOrderBtn.Name = "loadSavedOrderBtn";
            this.loadSavedOrderBtn.Size = new System.Drawing.Size(184, 51);
            this.loadSavedOrderBtn.TabIndex = 1;
            this.loadSavedOrderBtn.Text = "Load a saved order";
            this.loadSavedOrderBtn.UseVisualStyleBackColor = true;
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(65, 364);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(184, 51);
            this.exitBtn.TabIndex = 2;
            this.exitBtn.Text = "Exit Program";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox.BackgroundImage")));
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox.Location = new System.Drawing.Point(303, 114);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(375, 325);
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 544);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.loadSavedOrderBtn);
            this.Controls.Add(this.startNewOrderBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StartForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startNewOrderBtn;
        private System.Windows.Forms.Button loadSavedOrderBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.PictureBox pictureBox;
    }

}