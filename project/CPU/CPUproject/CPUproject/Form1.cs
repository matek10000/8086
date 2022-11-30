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
            ax1.Enabled = false;
            bx1.Enabled = false;
            cx1.Enabled = false;
            dx1.Enabled = false;
            ax2.Enabled = false;
            bx2.Enabled = false;
            cx2.Enabled = false;
            dx2.Enabled = false;
            
            ax1.BackColor = Color.Gray;
            bx1.BackColor = Color.Gray;
            cx1.BackColor = Color.Gray;
            dx1.BackColor = Color.Gray;
            ax2.BackColor = Color.Gray;
            bx2.BackColor = Color.Gray;
            cx2.BackColor = Color.Gray;
            dx2.BackColor = Color.Gray;
            resetbut.Visible = false;
        }

        private void wybor1_Click(object sender, EventArgs e)
        {
            wybor = 1;
            ax1.Enabled = true;
            bx1.Enabled = true;
            cx1.Enabled = true;
            dx1.Enabled = true;
            ax1.BackColor = Color.WhiteSmoke;
            bx1.BackColor = Color.WhiteSmoke;
            cx1.BackColor = Color.WhiteSmoke;
            dx1.BackColor = Color.WhiteSmoke;
        }

        private void wybor2_Click(object sender, EventArgs e)
        {
            wybor = 2;
            ax1.Enabled = true;
            bx1.Enabled = true;
            cx1.Enabled = true;
            dx1.Enabled = true;
            ax1.BackColor = Color.WhiteSmoke;
            bx1.BackColor = Color.WhiteSmoke;
            cx1.BackColor = Color.WhiteSmoke;
            dx1.BackColor = Color.WhiteSmoke;
        }

        private void ax1_Click(object sender, EventArgs e)
        {
            from = 1;
            ax2.Enabled = true;
            bx2.Enabled = true;
            cx2.Enabled = true;
            dx2.Enabled = true;

            ax2.BackColor = Color.WhiteSmoke;
            bx2.BackColor = Color.WhiteSmoke;
            cx2.BackColor = Color.WhiteSmoke;
            dx2.BackColor = Color.WhiteSmoke;
        }

        private void bx1_Click(object sender, EventArgs e)
        {
            from = 2;
            ax2.Enabled = true;
            bx2.Enabled = true;
            cx2.Enabled = true;
            dx2.Enabled = true;

            ax2.BackColor = Color.WhiteSmoke;
            bx2.BackColor = Color.WhiteSmoke;
            cx2.BackColor = Color.WhiteSmoke;
            dx2.BackColor = Color.WhiteSmoke;
        }

        private void cx1_Click(object sender, EventArgs e)
        {
            from = 3;
            ax2.Enabled = true;
            bx2.Enabled = true;
            cx2.Enabled = true;
            dx2.Enabled = true;

            ax2.BackColor = Color.WhiteSmoke;
            bx2.BackColor = Color.WhiteSmoke;
            cx2.BackColor = Color.WhiteSmoke;
            dx2.BackColor = Color.WhiteSmoke;
        }

        private void dx1_Click(object sender, EventArgs e)
        {
            from = 4;
            ax2.Enabled = true;
            bx2.Enabled = true;
            cx2.Enabled = true;
            dx2.Enabled = true;

            ax2.BackColor = Color.WhiteSmoke;
            bx2.BackColor = Color.WhiteSmoke;
            cx2.BackColor = Color.WhiteSmoke;
            dx2.BackColor = Color.WhiteSmoke;
        }

        private void ax2_Click(object sender, EventArgs e)
        {
            to = 1;
        }

        private void bx2_Click(object sender, EventArgs e)
        {
            to = 2;
        }

        private void cx2_Click(object sender, EventArgs e)
        {
            to = 3;
        }

        private void dx2_Click(object sender, EventArgs e)
        {
            to = 4;
        }

        private void resetbut_Click(object sender, EventArgs e)
        {
            resetbut.Visible = false;
            wykonbut.Visible = true;
            wybor = 0;
            from = 0;
            to = 0;
            wynik1.Text = "1";
            wynik2.Text = "2";
            wynik3.Text = "3";
            wynik4.Text = "4";
            ax1.Enabled = false;
            bx1.Enabled = false;
            cx1.Enabled = false;
            dx1.Enabled = false;
            ax2.Enabled = false;
            bx2.Enabled = false;
            cx2.Enabled = false;
            dx2.Enabled = false;
            ax1.BackColor = Color.Gray;
            bx1.BackColor = Color.Gray;
            cx1.BackColor = Color.Gray;
            dx1.BackColor = Color.Gray;
            ax2.BackColor = Color.Gray;
            bx2.BackColor = Color.Gray;
            cx2.BackColor = Color.Gray;
            dx2.BackColor = Color.Gray;
        }

        private void wykonbut_Click(object sender, EventArgs e)
        {
            resetbut.Visible = true;
            wykonbut.Visible = false;
            if (wybor == 1 && from == 1 && to == 1)
            {
                wynik1.Text = "1";
                wynik2.Text = "2";
                wynik3.Text = "3";
                wynik4.Text = "4";
            }
            if (wybor == 1 && from == 1 && to == 2)
            {
                wynik1.Text = "1";
                wynik2.Text = "1";
                wynik3.Text = "3";
                wynik4.Text = "4";
            }
            if (wybor == 1 && from == 1 && to == 3)
            {
                wynik1.Text = "1";
                wynik2.Text = "2";
                wynik3.Text = "1";
                wynik4.Text = "4";
            }
            if (wybor == 1 && from == 1 && to == 4)
            {
                wynik1.Text = "1";
                wynik2.Text = "2";
                wynik3.Text = "3";
                wynik4.Text = "1";
            }
                ///////////////////////////////////////////
                if (wybor == 1 && from == 2 && to == 1)
                {
                    wynik1.Text = "2";
                    wynik2.Text = "2";
                    wynik3.Text = "3";
                    wynik4.Text = "4";
                }
                if (wybor == 1 && from == 2 && to == 2)
                {
                    wynik1.Text = "1";
                    wynik2.Text = "2";
                    wynik3.Text = "3";
                    wynik4.Text = "4";
                }
                if (wybor == 1 && from == 2 && to == 3)
                {
                    wynik1.Text = "1";
                    wynik2.Text = "2";
                    wynik3.Text = "2";
                    wynik4.Text = "4";
                }
                if (wybor == 1 && from == 2 && to == 4)
                {
                    wynik1.Text = "1";
                    wynik2.Text = "2";
                    wynik3.Text = "3";
                    wynik4.Text = "2";
                }
                /////////////////////////////////////////
                if (wybor == 1 && from == 3 && to == 1)
                {
                    wynik1.Text = "3";
                    wynik2.Text = "2";
                    wynik3.Text = "3";
                    wynik4.Text = "4";
                }
                if (wybor == 1 && from == 3 && to == 2)
                {
                    wynik1.Text = "1";
                    wynik2.Text = "3";
                    wynik3.Text = "3";
                    wynik4.Text = "4";
                }
                if (wybor == 1 && from == 3 && to == 3)
                {
                    wynik1.Text = "1";
                    wynik2.Text = "2";
                    wynik3.Text = "3";
                    wynik4.Text = "4";
                }
                if (wybor == 1 && from == 3 && to == 4)
                {
                    wynik1.Text = "1";
                    wynik2.Text = "2";
                    wynik3.Text = "3";
                    wynik4.Text = "3";
                }
                ///////////////////////////////////////
                if (wybor == 1 && from == 4 && to == 1)
                {
                    wynik1.Text = "4";
                    wynik2.Text = "2";
                    wynik3.Text = "3";
                    wynik4.Text = "4";
                }
                if (wybor == 1 && from == 4 && to == 2)
                {
                    wynik1.Text = "1";
                    wynik2.Text = "4";
                    wynik3.Text = "3";
                    wynik4.Text = "4";
                }
                if (wybor == 1 && from == 4 && to == 3)
                {
                    wynik1.Text = "1";
                    wynik2.Text = "2";
                    wynik3.Text = "4";
                    wynik4.Text = "4";
                }
                if (wybor == 1 && from == 4 && to == 4)
                {
                    wynik1.Text = "1";
                    wynik2.Text = "2";
                    wynik3.Text = "3";
                    wynik4.Text = "4";
                }
                /////////////////////////////////////////
                ////////////////////////////////////////
                if (wybor == 2 && from == 1 && to == 1)
                {
                    wynik1.Text = "1";
                    wynik2.Text = "2";
                    wynik3.Text = "2";
                    wynik4.Text = "4";
                }
                if (wybor == 2 && from == 1 && to == 2)
                {
                    wynik1.Text = "2";
                    wynik2.Text = "1";
                    wynik3.Text = "3";
                    wynik4.Text = "4";
                }
                if (wybor == 2 && from == 1 && to == 3)
                {
                    wynik1.Text = "3";
                    wynik2.Text = "2";
                    wynik3.Text = "1";
                    wynik4.Text = "4";
                }
                if (wybor == 2 && from == 1 && to == 4)
                {
                    wynik1.Text = "4";
                    wynik2.Text = "2";
                    wynik3.Text = "3";
                    wynik4.Text = "1";
                }
                if (wybor == 2 && from == 2 && to == 1)
                {
                    wynik1.Text = "2";
                    wynik2.Text = "1";
                    wynik3.Text = "3";
                    wynik4.Text = "4";
                }
                if (wybor == 2 && from == 2 && to == 2)
                {
                    wynik1.Text = "1";
                    wynik2.Text = "2";
                    wynik3.Text = "3";
                    wynik4.Text = "4";
                }
                if (wybor == 2 && from == 2 && to == 3)
                {
                    wynik1.Text = "1";
                    wynik2.Text = "3";
                    wynik3.Text = "2";
                    wynik4.Text = "4";
                }
                if (wybor == 2 && from == 2 && to == 4)
                {
                    wynik1.Text = "1";
                    wynik2.Text = "4";
                    wynik3.Text = "3";
                    wynik4.Text = "2";
                }
                if (wybor == 2 && from == 3 && to == 1)
                {
                    wynik1.Text = "3";
                    wynik2.Text = "2";
                    wynik3.Text = "1";
                    wynik4.Text = "4";
                }
                if (wybor == 2 && from == 3 && to == 2)
                {
                    wynik1.Text = "1";
                    wynik2.Text = "3";
                    wynik3.Text = "2";
                    wynik4.Text = "4";
                }
            if (wybor == 2 && from == 3 && to == 3)
            {
                wynik1.Text = "1";
                wynik2.Text = "2";
                wynik3.Text = "3";
                wynik4.Text = "4";
            }
            if (wybor == 2 && from == 3 && to == 4)
            {
                wynik1.Text = "1";
                wynik2.Text = "2";
                wynik3.Text = "4";
                wynik4.Text = "3";
            }
            if (wybor == 2 && from == 4 && to == 1)
            {
                wynik1.Text = "4";
                wynik2.Text = "2";
                wynik3.Text = "3";
                wynik4.Text = "1";
            }
            if (wybor == 2 && from == 4 && to == 2)
            {
                wynik1.Text = "1";
                wynik2.Text = "4";
                wynik3.Text = "3";
                wynik4.Text = "2";
            }
            if (wybor == 2 && from == 4 && to == 3)
            {
                wynik1.Text = "1";
                wynik2.Text = "2";
                wynik3.Text = "4";
                wynik4.Text = "3";
            }
            if (wybor == 2 && from == 3 && to == 2)
            {
                wynik1.Text = "1";
                wynik2.Text = "2";
                wynik3.Text = "3";
                wynik4.Text = "4";
            }

        }
        }
    }
