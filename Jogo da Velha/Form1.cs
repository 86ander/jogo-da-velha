namespace Jogo_da_Velha
{
    public partial class Form1 : Form
    {
        private int numero = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (btn1.Text == "")
            {
                numero++;
                if (numero % 2 != 0)
                {
                    btn1.Text = "X";
                    jogadorXVenceu();
                }
                else
                {
                    btn1.Text = "O";
                    jogadorOVenceu();
                }
            }
        }

        private void jogadorXVenceu()
        {
            Boolean venceu = false;
            if (btn1.Text == "X" && btn2.Text == "X" && btn3.Text == "X")
                venceu = true;
            else if (btn4.Text == "X" && btn5.Text == "X" && btn6.Text == "X")
                venceu = true;
            else if (btn7.Text == "X" && btn8.Text == "X" && btn9.Text == "X")
                venceu = true;
            else if (btn1.Text == "X" && btn4.Text == "X" && btn7.Text == "X")
                venceu = true;
            else if (btn2.Text == "X" && btn5.Text == "X" && btn8.Text == "X")
                venceu = true;
            else if (btn3.Text == "X" && btn6.Text == "X" && btn9.Text == "X")
                venceu = true;
            else if (btn1.Text == "X" && btn5.Text == "X" && btn9.Text == "X")
                venceu = true;
            else if (btn3.Text == "X" && btn5.Text == "X" && btn7.Text == "X")
                venceu = true;
            if (venceu == true)
            {
                MessageBox.Show("O jogador X venceu!", "Jogador X", MessageBoxButtons.OK, MessageBoxIcon.Information);
                recomecar();
            }
            else if (numero == 9)
            {
                MessageBox.Show("Nenhum jogador venceu a partida!", "Partida empatou", MessageBoxButtons.OK, MessageBoxIcon.Information);
                recomecar();
            }

        }

        private void jogadorOVenceu()
        {
            Boolean venceu = false;
            if (btn1.Text == "O" && btn2.Text == "O" && btn3.Text == "O")
                venceu = true;
            else if (btn4.Text == "O" && btn5.Text == "O" && btn6.Text == "O")
                venceu = true;
            else if (btn7.Text == "O" && btn8.Text == "O" && btn9.Text == "O")
                venceu = true;
            else if (btn1.Text == "O" && btn4.Text == "O" && btn7.Text == "O")
                venceu = true;
            else if (btn2.Text == "O" && btn5.Text == "O" && btn8.Text == "O")
                venceu = true;
            else if (btn3.Text == "O" && btn6.Text == "O" && btn9.Text == "O")
                venceu = true;
            else if (btn1.Text == "O" && btn5.Text == "O" && btn9.Text == "O")
                venceu = true;
            else if (btn3.Text == "O" && btn5.Text == "O" && btn7.Text == "O")
                venceu = true;
            if (venceu == true)
            {
                MessageBox.Show("O jogador O venceu!", "Jogador O", MessageBoxButtons.OK, MessageBoxIcon.Information);
                recomecar();
            }

        }

        private void recomecar()
        {
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
            numero = 0;
        }

        private void btnRecomecar_Click(object sender, EventArgs e)
        {
            recomecar();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (btn2.Text == "")
            {
                numero++;
                if (numero % 2 != 0)
                {
                    btn2.Text = "X";
                    jogadorXVenceu();
                }
                else
                {
                    btn2.Text = "O";
                    jogadorOVenceu();
                }
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (btn3.Text == "")
            {
                numero++;
                if (numero % 2 != 0)
                {
                    btn3.Text = "X";
                    jogadorXVenceu();
                }
                else
                {
                    btn3.Text = "O";
                    jogadorOVenceu();
                }
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (btn4.Text == "")
            {
                numero++;
                if (numero % 2 != 0)
                {
                    btn4.Text = "X";
                    jogadorXVenceu();
                }
                else
                {
                    btn4.Text = "O";
                    jogadorOVenceu();
                }
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (btn5.Text == "")
            {
                numero++;
                if (numero % 2 != 0)
                {
                    btn5.Text = "X";
                    jogadorXVenceu();
                }
                else
                {
                    btn5.Text = "O";
                    jogadorOVenceu();
                }
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (btn6.Text == "")
            {
                numero++;
                if (numero % 2 != 0)
                {
                    btn6.Text = "X";
                    jogadorXVenceu();
                }
                else
                {
                    btn6.Text = "O";
                    jogadorOVenceu();
                }
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (btn7.Text == "")
            {
                numero++;
                if (numero % 2 != 0)
                {
                    btn7.Text = "X";
                    jogadorXVenceu();
                }
                else
                {
                    btn7.Text = "O";
                    jogadorOVenceu();
                }
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (btn8.Text == "")
            {
                numero++;
                if (numero % 2 != 0)
                {
                    btn8.Text = "X";
                    jogadorXVenceu();
                }
                else
                {
                    btn8.Text = "O";
                    jogadorOVenceu();
                }
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (btn9.Text == "")
            {
                numero++;
                if (numero % 2 != 0)
                {
                    btn9.Text = "X";
                    jogadorXVenceu();
                }
                else
                {
                    btn9.Text = "O";
                    jogadorOVenceu();
                }
            }
        }
    }
}