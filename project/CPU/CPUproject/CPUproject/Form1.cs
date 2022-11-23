namespace CPUproject
{
    public partial class Form1 : Form
    {
        int wybor;
        int from;
        int to;
        public Form1()
        {
            InitializeComponent();
        }

        private void wybor1_Click(object sender, EventArgs e)
        {
            wybor = 1;
        }

        private void wybor2_Click(object sender, EventArgs e)
        {
            wybor = 2;
        }

        private void ax1_Click(object sender, EventArgs e)
        {
            from = 1;
        }

        private void bx1_CheckedChanged(object sender, EventArgs e)
        {
            from = 2;
        }

        private void cx1_CheckedChanged(object sender, EventArgs e)
        {
            from = 3;
        }

        private void dx1_CheckedChanged(object sender, EventArgs e)
        {
            from = 4;
        }

        private void ax2_CheckedChanged(object sender, EventArgs e)
        {
            to = 1;
        }

        private void bx2_CheckedChanged(object sender, EventArgs e)
        {
            to = 2;
        }

        private void cx2_CheckedChanged(object sender, EventArgs e)
        {
            to = 3;
        }

        private void dx2_CheckedChanged(object sender, EventArgs e)
        {
            to = 4;
        }

        private void resetbut_Click(object sender, EventArgs e)
        {
            wybor = 0;
            from = 0;
            to = 0;
        }
    }
}