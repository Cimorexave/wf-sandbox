namespace wf_sandbox
{
    partial class UserControl2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            pdfViewer1 = new DevExpress.XtraPdfViewer.PdfViewer();
            SuspendLayout();
            // 
            // splitterControl1
            // 
            splitterControl1.Location = new Point(0, 0);
            splitterControl1.Name = "splitterControl1";
            splitterControl1.Size = new Size(10, 401);
            splitterControl1.TabIndex = 0;
            splitterControl1.TabStop = false;
            // 
            // pdfViewer1
            // 
            pdfViewer1.Dock = DockStyle.Fill;
            pdfViewer1.Location = new Point(10, 0);
            pdfViewer1.Name = "pdfViewer1";
            pdfViewer1.Size = new Size(469, 401);
            pdfViewer1.TabIndex = 1;
            // 
            // UserControl2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pdfViewer1);
            Controls.Add(splitterControl1);
            Name = "UserControl2";
            Size = new Size(479, 401);
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraPdfViewer.PdfViewer pdfViewer1;
    }
}
