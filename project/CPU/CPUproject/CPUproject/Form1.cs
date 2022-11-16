namespace CPUproject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text.ToString() + " ";
            label1.Text += textBox2.Text.ToString() + " ";
            label1.Text += textBox3.Text.ToString();

        }
    }
}