namespace JogoDaVelha1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            lblVez.Text = "X";
            lblVenceu.Text = "";
            O1.Visible = false;
            O2.Visible = false;
            O3.Visible = false;
            O4.Visible = false;
            O5.Visible = false;
            O6.Visible = false;
            O7.Visible = false;
            O8.Visible = false;
            O9.Visible = false;
            X1.Visible = false;
            X2.Visible = false;
            X3.Visible = false;
            X4.Visible = false;
            X5.Visible = false;
            X6.Visible = false;
            X7.Visible = false;
            X8.Visible = false;
            X9.Visible = false;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (lblVez.Text == "X")
            {
                X1.Visible = true;
                lblVez.Text = "O";
            }
            else 
            {
                O1.Visible = true;
                lblVez.Text = "X";
            }
            if (X1.Visible == true && X2.Visible == true && X3.Visible == true
                || X1.Visible == true && X5.Visible == true && X7.Visible == true
                || X1.Visible == true && X5.Visible == true && X9.Visible == true)
            {
                lblVenceu.Text = "X Venceu";
            }

            else if (O1.Visible == true && O2.Visible == true && O3.Visible == true
                || O1.Visible == true && O5.Visible == true && O7.Visible == true
                || O1.Visible == true && O5.Visible == true && O9.Visible == true)
            {
                lblVenceu.Text = "O Venceu";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (lblVez.Text == "X")
            {
                X2.Visible = true;
                lblVez.Text = "O";
            }
            else 
            {
                O2.Visible = true;
                lblVez.Text = "X";
            }
            if (X1.Visible == true && X2.Visible == true && X3.Visible == true
                || X2.Visible == true && X5.Visible == true && X8.Visible == true)
            {
                lblVenceu.Text = "X Venceu";
            }

            else if (O1.Visible == true && O2.Visible == true && O3.Visible == true
                || O2.Visible == true && O5.Visible == true && O8.Visible == true)
            {
                lblVenceu.Text = "O Venceu";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (lblVez.Text == "X")
            {
                X3.Visible = true;
                lblVez.Text = "O";
            }
            else
            {
                O3.Visible = true;
                lblVez.Text = "X";
            }
            if (X1.Visible == true && X2.Visible == true && X3.Visible == true
                || X3.Visible == true && X5.Visible == true && X7.Visible == true
                || X3.Visible == true && X6.Visible == true && X9.Visible == true)
            {
                lblVenceu.Text = "X Venceu";
            }

            else if (O1.Visible == true && O2.Visible == true && O3.Visible == true
                || O3.Visible == true && O5.Visible == true && O7.Visible == true
                || O3.Visible == true && O6.Visible == true && O9.Visible == true)
            {
                lblVenceu.Text = "O Venceu";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (lblVez.Text == "X")
            {
                X4.Visible = true;
                lblVez.Text = "O";
            }
            else
            {
                O4.Visible = true;
                lblVez.Text = "X";
            }
            if (X4.Visible == true && X5.Visible == true && X6.Visible == true
                || X4.Visible == true && X1.Visible == true && X7.Visible == true)
            {
                lblVenceu.Text = "X Venceu";
            }

            else if (O4.Visible == true && O5.Visible == true && O6.Visible == true
                || O4.Visible == true && O1.Visible == true && O7.Visible == true)
            {
                lblVenceu.Text = "O Venceu";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (lblVez.Text == "X")
            {
                X5.Visible = true;
                lblVez.Text = "O";
            }
            else
            {
                O5.Visible = true;
                lblVez.Text = "X";
            }
            if (X4.Visible == true && X5.Visible == true && X6.Visible == true
                || X2.Visible == true && X5.Visible == true && X8.Visible == true
                || X1.Visible == true && X5.Visible == true && X9.Visible == true
                || X3.Visible == true && X5.Visible == true && X7.Visible == true)
            {
                lblVenceu.Text = "X Venceu";
            }

            else if (O4.Visible == true && O5.Visible == true && O6.Visible == true
                || O2.Visible == true && O5.Visible == true && O8.Visible == true
                || O1.Visible == true && O5.Visible == true && O9.Visible == true
                || O3.Visible == true && O5.Visible == true && O7.Visible == true)
            {
                lblVenceu.Text = "O Venceu";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (lblVez.Text == "X")
            {
                X6.Visible = true;
                lblVez.Text = "O";
            }
            else
            {
                O6.Visible = true;
                lblVez.Text = "X";
            }
            if (X3.Visible == true && X6.Visible == true && X9.Visible == true
                || X4.Visible == true && X5.Visible == true && X6.Visible == true)
            {
                lblVenceu.Text = "X Venceu";
            }

            else if (O3.Visible == true && O6.Visible == true && O9.Visible == true
                || O4.Visible == true && O5.Visible == true && O6.Visible == true)
            {
                lblVenceu.Text = "O Venceu";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (lblVez.Text == "X")
            {
                X7.Visible = true;
                lblVez.Text = "O";
            }
            else
            {
                O7.Visible = true;
                lblVez.Text = "X";
            }
            if (X7.Visible == true && X8.Visible == true && X9.Visible == true
                || X1.Visible == true && X4.Visible == true && X7.Visible == true
                || X3.Visible == true && X5.Visible == true && X7.Visible == true)
            {
                lblVenceu.Text = "X Venceu";
            }

            else if (O7.Visible == true && O8.Visible == true && O9.Visible == true
                || O1.Visible == true && O4.Visible == true && O7.Visible == true
                || O3.Visible == true && O5.Visible == true && O7.Visible == true)
            {
                lblVenceu.Text = "O Venceu";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (lblVez.Text == "X")
            {
                X8.Visible = true;
                lblVez.Text = "O";
            }
            else
            {
                O8.Visible = true;
                lblVez.Text = "X";
            }
            if (X2.Visible == true && X5.Visible == true && X8.Visible == true
                || X7.Visible == true && X8.Visible == true && X9.Visible == true)
            {
                lblVenceu.Text = "X Venceu";
            }

            else if (O2.Visible == true && O5.Visible == true && O8.Visible == true
                || O7.Visible == true && O8.Visible == true && O9.Visible == true)
            {
                lblVenceu.Text = "O Venceu";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (lblVez.Text == "X")
            {
                X9.Visible = true;
                lblVez.Text = "O";
            }
            else
            {
                O9.Visible = true;
                lblVez.Text = "X";
            }
            if (X7.Visible == true && X8.Visible == true && X9.Visible == true
                || X1.Visible == true && X5.Visible == true && X9.Visible == true
                || X3.Visible == true && X6.Visible == true && X9.Visible == true)
            {
                lblVenceu.Text = "X Venceu";
            }

            else if (O7.Visible == true && O8.Visible == true && O9.Visible == true
                || O1.Visible == true && O5.Visible == true && O9.Visible == true
                || O3.Visible == true && O6.Visible == true && O9.Visible == true)
            {
                lblVenceu.Text = "O Venceu";
            }
        }
    }
}