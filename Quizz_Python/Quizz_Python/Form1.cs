using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;

namespace Quizz_Python
{
    public partial class Quizz_Python : Form
    {
        int N_Perguntas_Certas = 0;
        // Variavel para definir o numero da pergunta a escolher
        int numero_pergunta;

        // Variavel para guardar resposta selecionada
        char resposta_seleciona;

        // Variavel com o numero de perguntas que ja sairam
        int numero_questoes = 0;

        // Lista para guardar perguntas
        List<questao> questoes = new List<questao>()
        {
           new questao("Qual fun��o converte um n�mero decimal para bin�rio?",
                       "a) hex()",
                       "b) oct()",
                       "c) bin()",
                       "d) int()",
                       'c'),
           new questao("Qual palavra-chave � usada para exce��es em Python?",
                       "a) catch",
                       "b) except",
                       "c) exception",
                       "d) error",
                       'b'),
           new questao("O que a fun��o isinstance() faz?",
                       "a) Verifica se um objeto � uma inst�ncia de uma classe",
                       "b) Verifica se uma classe herda de outra",
                       "c) Verifica se um objeto � um m�todo",
                       "d) Verifica se um objeto � uma vari�vel",
                       'a'),
           new questao("Qual � o resultado de 7 % 3?",
                       "a) 1",
                       "b) 2",
                       "c) 0",
                       "d) 3",
                       'b'),
           new questao("Qual � o operador de exponencia��o em Python?",
                       "a) ^",
                       "b) **",
                       "c) pow()",
                       "d) exp()",
                       'b'),

           new questao("Como voc� remove espa�os em branco no in�cio e no final de uma string?",
                       "a) strip()",
                       "b) remove()",
                       "c) trim()",
                       "d) clean()",
                       'a'),
           new questao("Qual dessas fun��es retorna a menor chave em um dicion�rio?",
                       "a) min()",
                       "b) smallest()",
                       "c) key()",
                       "d) dict_min()",
                       'a'),
           new questao("Qual � a sa�da de 'Hello'.upper()?",
                       "a) hello",
                       "b) HELLO",
                       "c) Hello",
                       "d) hELLO",
                       'b'),
           new questao("Como voc� copia uma lista em Python?",
                       "a) list.copy()",
                       "b) list()",
                       "c) copy()",
                       "d) clone()",
                       'a'),
           new questao("Como voc� verifica se uma chave existe em um dicion�rio?",
                       "a) 'chave' in dict",
                       "b) dict.has_key('chave')",
                       "c) dict.key_exists('chave')",
                       "d) 'chave' exists in dict",
                       'a'),
           new questao("Como voc� obt�m a �ltima letra de uma string?",
                       "a) str[-1]",
                       "b) str[len(str)-1]",
                       "c) str.last()",
                       "d) str[-2]",
                       'a'),
           new questao("Qual fun��o retorna o maior n�mero em uma lista?",
                       "a) max()",
                       "b) largest()",
                       "c) big()",
                       "d) top()",
                       'a'),
           new questao("Como voc� adiciona m�ltiplos itens a uma lista?",
                       "a) list.add()",
                       "b) list.append()",
                       "c) list.insert()",
                       "d) list.extend()",
                       'd'),
           new questao("Como voc� remove o primeiro item de uma lista?",
                       "a) list.remove(0)",
                       "b) list.pop(0)",
                       "c) list.delete(0)",
                       "d) list.drop(0)",
                       'b'),
           new questao("Qual dessas palavras-chave cria um la�o em Python?",
                       "a) for",
                       "b) while",
                       "c) do",
                       "d) loop",
                       'a'),
           new questao("Como voc� define uma fun��o an�nima em Python?",
                       "a) lambda",
                       "b) func",
                       "c) anon",
                       "d) def",
                       'a'),
           new questao("Qual � o resultado de True and False?",
                       "a) True",
                       "b) False",
                       "c) None",
                       "d) 0",
                       'b'),
           new questao("Como voc� converte uma lista em uma tupla?",
                       "a) tuple()",
                       "b) list()",
                       "c) convert()",
                       "d) change()",
                       'a'),
           new questao("Como voc� cria uma nova lista com os quadrados dos n�meros de 1 a 5?",
                       "a) [x**2 for x in range(1, 6)]",
                       "b) [x^2 for x in range(1, 6)]",
                       "c) [x**2 for x in range(1, 5)]",
                       "d) [x^2 for x in range(1, 5)]",
                       'a'),
           new questao("Como voc� escreve uma declara��o condicional em Python?",
                       "a) if x > y then",
                       "b) if x > y:",
                       "c) if x > y do",
                       "d) if (x > y):",
                       'b'),
           new questao("Qual fun��o pode ser usada para interromper um la�o?",
                       "a) exit()",
                       "b) stop()",
                       "c) break()",
                       "d) end()",
                       'c'),
           new questao("Qual fun��o pode ser usada para continuar a pr�xima itera��o de um la�o?",
                       "a) continue()",
                       "b) next()",
                       "c) skip()",
                       "d) pass()",
                       'a'),
           new questao("Como voc� define uma vari�vel local dentro de uma fun��o?",
                       "a) Apenas declare a vari�vel",
                       "b) Use a palavra-chave var",
                       "c) Use a palavra-chave local",
                       "d) Use a palavra-chave global",
                       'a'),
           new questao("Qual � a sa�da de [1, 2, 3] + [4, 5, 6]?",
                       "a) [1, 2, 3, 4, 5, 6]",
                       "b) [1, 2, 3, [4, 5, 6]]",
                       "c) [5, 7, 9]",
                       "d) [1, 2, 3, 4, 5, 6, 7]",
                       'a'),
           new questao("Qual fun��o retorna uma c�pia rasa de uma lista?",
                       "a) list.copy()",
                       "b) list.clone()",
                       "c) list.duplicate()",
                       "d) list.copy_of()",
                       'a')
       };

        public Quizz_Python()
        {
            InitializeComponent();
        }

        private void Quizz__Resize(object sender, EventArgs e)
        {
            lbl_Pergunta.Left = this.Width / 2;
            rdb_resposta1.Left = this.Width / 2;
            rdb_resposta2.Left = this.Width / 2;
            rdb_resposta3.Left = this.Width / 2;
            rdb_resposta4.Left = this.Width / 2;
        }
        private void escrever_pergunta()
        {
            // gerar um numero aleatorio da pergunta
            Random numero = new Random();
            numero_pergunta = numero.Next(questoes.Count);

            // preencher os controlos com os dados da pergunta
            lbl_Pergunta.Text = questoes[numero_pergunta].pergunta;
            rdb_resposta1.Text = questoes[numero_pergunta].resposta1;
            rdb_resposta2.Text = questoes[numero_pergunta].resposta2;
            rdb_resposta3.Text = questoes[numero_pergunta].resposta3;
            rdb_resposta4.Text = questoes[numero_pergunta].resposta4;

        }

        private void limpar_selecao()
        {
            rdb_resposta1.Checked = false;
            rdb_resposta2.Checked = false;
            rdb_resposta3.Checked = false;
            rdb_resposta4.Checked = false;
        }
       
        private void Quizz_Python_Load(object sender, EventArgs e)
        {
            limpar_selecao();
            escrever_pergunta();
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            // incrementar o numero de perguntas
            numero_questoes += 1;
            // Testar se a pergunta esta correta
            if (resposta_seleciona == questoes[numero_pergunta].respostaCerta)
            {
                MessageBox.Show("Parabens. A sua resposta est� correta", "Quizz Python", MessageBoxButtons.OK, MessageBoxIcon.Information);
                N_Perguntas_Certas += 1;
            }
            else
            {
                MessageBox.Show("A sua resposta est� errada. \n A resposta certa era(" + questoes[numero_pergunta].respostaCerta+(")"), "Quiz Python", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            // Retira a pergunta da lista
            questoes.RemoveAt(numero_pergunta);
            
            if (numero_questoes== 5)
            {
                this.Hide();
                frm_Saida frm = new frm_Saida();
                frm.Show(N_Perguntas_Certas);
            }

            // Passar para a proxima pergunta
            escrever_pergunta();
        }

        private void rdb_resposta1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_resposta1.Checked)
            {
                resposta_seleciona = 'a';
            }

        }

        private void rdb_resposta2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_resposta2.Checked)
            {
                resposta_seleciona = 'b';
            }
        }

        private void rdb_resposta3_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_resposta3.Checked)
            {
                resposta_seleciona = 'c';
            }
        }

        private void rdb_resposta4_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_resposta1.Checked)
            {
                resposta_seleciona = 'd';
            }
        }
    }
}
