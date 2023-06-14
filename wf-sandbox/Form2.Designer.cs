namespace wf_sandbox
{
    partial class Form2
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
            userControl11 = new UserControl1();
            button1 = new Button();
            progressBar1 = new ProgressBar();
            button2 = new Button();
            SuspendLayout();
            // 
            // userControl11
            // 
            userControl11.BackColor = SystemColors.ActiveCaption;
            userControl11.Location = new Point(12, 451);
            userControl11.Name = "userControl11";
            userControl11.Size = new Size(244, 37);
            userControl11.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(162, 23);
            button1.TabIndex = 1;
            button1.Text = "New Background Worker";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(221, 12);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(162, 23);
            progressBar1.Step = 1;
            progressBar1.TabIndex = 2;
            progressBar1.Visible = false;
            // 
            // button2
            // 
            button2.Location = new Point(423, 12);
            button2.Name = "button2";
            button2.Size = new Size(162, 23);
            button2.TabIndex = 3;
            button2.Text = "Run Blocking Task";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 500);
            Controls.Add(button2);
            Controls.Add(progressBar1);
            Controls.Add(button1);
            Controls.Add(userControl11);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private UserControl1 userControl11;
        private Button button1;
        private ProgressBar progressBar1;
        private Button button2;
    }
}