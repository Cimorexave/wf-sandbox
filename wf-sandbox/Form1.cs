namespace wf_sandbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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