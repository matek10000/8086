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
            info1.Text = "MOV ";
        }

        private void wybor2_Click(object sender, EventArgs e)
        {
            wybor = 2;
            info1.Text = "XCHG ";
        }

        private void ax1_Click(object sender, EventArgs e)
        {
            from = 1;
            info1.Text += "from AX to ";
        }

        private void bx1_CheckedChanged(object sender, EventArgs e)
        {
            from = 2;
            info1.Text += "from BX to ";
        }

        private void cx1_CheckedChanged(object sender, EventArgs e)
        {
            from = 3;
            info1.Text += "from CX to ";
        }

        private void dx1_CheckedChanged(object sender, EventArgs e)
        {
            from = 4;
            info1.Text += "from DX to ";
        }

        private void ax2_CheckedChanged(object sender, EventArgs e)
        {
            to = 1;
            info1.Text += "AX";
        }

        private void bx2_CheckedChanged(object sender, EventArgs e)
        {
            to = 2;
            info1.Text += "BX";
        }

        private void cx2_CheckedChanged(object sender, EventArgs e)
        {
            to = 3;
            info1.Text += "CX";
        }

        private void dx2_CheckedChanged(object sender, EventArgs e)
        {
            to = 4;
            info1.Text += "DX";
        }

        private void resetbut_Click(object sender, EventArgs e)
        {
            wybor = 0;
            from = 0;
            to = 0;
            wynik1.Text = "1";
            wynik2.Text = "2";
            wynik3.Text = "3";
            wynik4.Text = "4";
            info1.Text += "";
        }

        private void wykonbut_Click(object sender, EventArgs e)
        {
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

            }
        }
    }
