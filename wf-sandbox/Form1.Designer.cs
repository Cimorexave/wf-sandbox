﻿namespace wf_sandbox
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            welcomeLabel = new Label();
            docLink = new LinkLabel();
            SuspendLayout();
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Location = new Point(100, 51);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(266, 15);
            welcomeLabel.TabIndex = 0;
            welcomeLabel.Text = "Welcome To PDF Explain (Monatsjournal version)";
            // 
            // docLink
            // 
            docLink.AutoSize = true;
            docLink.Location = new Point(100, 79);
            docLink.Name = "docLink";
            docLink.Size = new Size(162, 15);
            docLink.TabIndex = 1;
            docLink.TabStop = true;
            docLink.Text = "Visit our Documentation here";
            docLink.LinkClicked += redirectToDocs;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(docLink);
            Controls.Add(welcomeLabel);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label welcomeLabel;
        private LinkLabel docLink;
    }
}