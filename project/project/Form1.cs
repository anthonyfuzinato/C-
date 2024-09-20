namespace project
{
    public partial class Form1 : Form
    {

        int jogador = 0, empate = 0, adversario = 0, rodadas = 0;
        bool turno = true, jogo_final = false;
        string[] texto = new string[9];

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int buttonIndex = btn.TabIndex;


            // ADICIONAR X OU O NO GAME

            if (btn.Text == "" && jogo_final == false)
            {
                if (turno)
                {
                    btn.Text = "X";
                    texto[buttonIndex] = btn.Text;
                    rodadas += 1;
                    turno = false;
                    Checagem(1);
                }

                else
                {
                    btn.Text = "O";
                    texto[buttonIndex] = btn.Text;
                    rodadas += 1;
                    turno = true;
                    Checagem(2);
                } // Estrutura final
            }


            void Ganhador(int PlayerGanhador)
            {
                jogo_final = true;
                if (PlayerGanhador == 1)
                {
                    jogador += 1;
                    lbl_jogador.Text = Convert.ToString(jogador);
                    MessageBox.Show("Jogador X que ganhou", "Parabens", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    turno = true;
                }
                else
                {
                    adversario += 1;
                    lbl_adversario.Text = Convert.ToString(adversario);
                    MessageBox.Show("Jogador O que ganhou", "Parabens", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    turno = false;
                }
            }


            void Checagem(int ChecagemPlayer)
            {
                string suporte = "";

                if (ChecagemPlayer == 1)
                {
                    suporte = "X";
                }
                else
                {
                    suporte = "O";
                } // final sup

                for (int horizontal = 0; horizontal < 8; horizontal += 3)
                {
                    if (suporte == texto[horizontal]) // checar horizontal
                    {
                        // vai checar se o conteudo do indice 0 e igual ao do indice 1 e o do indice 2
                        if (texto[horizontal] == texto[horizontal + 1] && texto[horizontal] == texto[horizontal + 2])
                        {
                            Ganhador(ChecagemPlayer);
                            return;
                        }
                    }
                } // final for

                // vertical
                for (int vertical = 0; vertical < 3; vertical += 1)
                {
                    if (suporte == texto[vertical]) // checar vertical
                    {
                        // vai checar se o conteudo do indice 0 e igual ao do indice 3 e o do indice 6
                        if (texto[vertical] == texto[vertical + 3] && texto[vertical] == texto[vertical + 6])
                        {
                            Ganhador(ChecagemPlayer);
                            return;
                        }
                    }
                } // final for

                // verificaçao diagonal

                if (texto[0] == suporte)
                {
                    if (texto[0] == texto[4] && texto[0] == texto[8])
                    {
                        Ganhador(ChecagemPlayer);
                        return;
                    } // diagonal esquerda pra direitá
                }
                if (texto[2] == suporte)
                {
                    if (texto[2] == texto[4] && texto[4] == texto[6])
                    {
                        Ganhador(ChecagemPlayer);
                        return;
                    }// diagonal reversa
                }
            }
            if (rodadas == 9 && jogo_final == false)
            {
                empate += 1;
                lbl_empate.Text = Convert.ToString(empate);
                MessageBox.Show("Empate!", "Quase", MessageBoxButtons.OK, MessageBoxIcon.Information);
                jogo_final = true;
                return;
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            btn.Text = "";
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";

            jogo_final = false;
            for (int i = 0; i < 9; i += 1)
            {
                texto[i] = "";
            }
        }

        private void btn_limparpontuaçao_Click(object sender, EventArgs e)
        {
            lbl_adversario.Text = "0";
            lbl_empate.Text = "0";
            lbl_jogador.Text = "0";


        }
    }
}
