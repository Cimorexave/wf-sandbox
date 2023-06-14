namespace wf_sandbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dropDownButton1.DropDownControl = popupMenu1;
            FillLookUpEdit();
        }

        private void FillLookUpEdit()
        {
            // Create a list of items
            List<string> items = new List<string> { "Item 1", "Item 2", "Item 3", "Item 4" };

            // Assign the list as the data source of the LookUpEdit
            lookUpEdit1.Properties.DataSource = items;
        }
        private void redirectToDocs(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Load the user control and add it to the frame
            var myUserControl = new UserControl1
            {
                Name = "testUserControl",
                Left = 500,
                Top = 75,
                // put it on the form1
                Parent = this
            };
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _ = new Form2().ShowDialog();
        }
    }
}