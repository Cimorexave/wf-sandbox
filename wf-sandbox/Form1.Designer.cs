namespace wf_sandbox
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
            components = new System.ComponentModel.Container();
            welcomeLabel = new Label();
            docLink = new LinkLabel();
            button1 = new Button();
            button2 = new Button();
            dropDownButton1 = new DevExpress.XtraEditors.DropDownButton();
            barCheckItem2 = new DevExpress.XtraBars.BarCheckItem();
            barCheckItem3 = new DevExpress.XtraBars.BarCheckItem();
            popupMenu1 = new DevExpress.XtraBars.PopupMenu(components);
            barCheckItem1 = new DevExpress.XtraBars.BarCheckItem();
            barCheckItem4 = new DevExpress.XtraBars.BarCheckItem();
            barCheckItem5 = new DevExpress.XtraBars.BarCheckItem();
            barManager1 = new DevExpress.XtraBars.BarManager(components);
            barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            comboBox1 = new ComboBox();
            lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)popupMenu1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)barManager1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)comboBoxEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lookUpEdit1.Properties).BeginInit();
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
            // button1
            // 
            button1.Location = new Point(534, 47);
            button1.Name = "button1";
            button1.Size = new Size(130, 23);
            button1.TabIndex = 2;
            button1.Text = "New Control";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(113, 122);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "New Form";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dropDownButton1
            // 
            dropDownButton1.Location = new Point(194, 122);
            dropDownButton1.Name = "dropDownButton1";
            dropDownButton1.Size = new Size(135, 23);
            dropDownButton1.TabIndex = 4;
            dropDownButton1.Text = "Profile";
            // 
            // barCheckItem2
            // 
            barCheckItem2.Name = "barCheckItem2";
            // 
            // barCheckItem3
            // 
            barCheckItem3.Name = "barCheckItem3";
            // 
            // popupMenu1
            // 
            popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(barCheckItem1), new DevExpress.XtraBars.LinkPersistInfo(barCheckItem4), new DevExpress.XtraBars.LinkPersistInfo(barCheckItem5) });
            popupMenu1.Manager = barManager1;
            popupMenu1.Name = "popupMenu1";
            // 
            // barCheckItem1
            // 
            barCheckItem1.Caption = "barCheckItem1";
            barCheckItem1.Id = 0;
            barCheckItem1.Name = "barCheckItem1";
            // 
            // barCheckItem4
            // 
            barCheckItem4.Caption = "barCheckItem4";
            barCheckItem4.Id = 1;
            barCheckItem4.Name = "barCheckItem4";
            // 
            // barCheckItem5
            // 
            barCheckItem5.Caption = "barCheckItem5";
            barCheckItem5.Id = 2;
            barCheckItem5.Name = "barCheckItem5";
            // 
            // barManager1
            // 
            barManager1.DockControls.Add(barDockControlTop);
            barManager1.DockControls.Add(barDockControlBottom);
            barManager1.DockControls.Add(barDockControlLeft);
            barManager1.DockControls.Add(barDockControlRight);
            barManager1.Form = this;
            barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { barCheckItem1, barCheckItem4, barCheckItem5 });
            barManager1.MaxItemId = 3;
            // 
            // barDockControlTop
            // 
            barDockControlTop.CausesValidation = false;
            barDockControlTop.Dock = DockStyle.Top;
            barDockControlTop.Location = new Point(0, 0);
            barDockControlTop.Manager = barManager1;
            barDockControlTop.Size = new Size(800, 0);
            // 
            // barDockControlBottom
            // 
            barDockControlBottom.CausesValidation = false;
            barDockControlBottom.Dock = DockStyle.Bottom;
            barDockControlBottom.Location = new Point(0, 450);
            barDockControlBottom.Manager = barManager1;
            barDockControlBottom.Size = new Size(800, 0);
            // 
            // barDockControlLeft
            // 
            barDockControlLeft.CausesValidation = false;
            barDockControlLeft.Dock = DockStyle.Left;
            barDockControlLeft.Location = new Point(0, 0);
            barDockControlLeft.Manager = barManager1;
            barDockControlLeft.Size = new Size(0, 450);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = DockStyle.Right;
            barDockControlRight.Location = new Point(800, 0);
            barDockControlRight.Manager = barManager1;
            barDockControlRight.Size = new Size(0, 450);
            // 
            // comboBoxEdit1
            // 
            comboBoxEdit1.Location = new Point(335, 124);
            comboBoxEdit1.MenuManager = barManager1;
            comboBoxEdit1.Name = "comboBoxEdit1";
            comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            comboBoxEdit1.Properties.Items.AddRange(new object[] { "AKU - Monatsjournal", "New Template", "Untitled Template1" });
            comboBoxEdit1.Size = new Size(122, 20);
            comboBoxEdit1.TabIndex = 9;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "AKU - Monatsjournal", "Untitled Template 1", "Untitle Template 2", "New Template" });
            comboBox1.Location = new Point(476, 122);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 14;
            // 
            // lookUpEdit1
            // 
            lookUpEdit1.Location = new Point(624, 123);
            lookUpEdit1.MenuManager = barManager1;
            lookUpEdit1.Name = "lookUpEdit1";
            lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            lookUpEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] { new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name1", "Name1"), new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name2", "Name2") });
            lookUpEdit1.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            lookUpEdit1.Size = new Size(100, 20);
            lookUpEdit1.TabIndex = 19;
            // 
            // button3
            // 
            button3.Location = new Point(677, 415);
            button3.Name = "button3";
            button3.Size = new Size(111, 23);
            button3.TabIndex = 24;
            button3.Text = "Open Grid Form";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(lookUpEdit1);
            Controls.Add(comboBox1);
            Controls.Add(comboBoxEdit1);
            Controls.Add(dropDownButton1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(docLink);
            Controls.Add(welcomeLabel);
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)popupMenu1).EndInit();
            ((System.ComponentModel.ISupportInitialize)barManager1).EndInit();
            ((System.ComponentModel.ISupportInitialize)comboBoxEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)lookUpEdit1.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label welcomeLabel;
        private LinkLabel docLink;
        private Button button1;
        private Button button2;
        private DevExpress.XtraEditors.DropDownButton dropDownButton1;
        private DevExpress.XtraBars.BarCheckItem barCheckItem2;
        private DevExpress.XtraBars.BarCheckItem barCheckItem3;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarCheckItem barCheckItem1;
        private DevExpress.XtraBars.BarCheckItem barCheckItem4;
        private DevExpress.XtraBars.BarCheckItem barCheckItem5;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private ComboBox comboBox1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private Button button3;
    }
}