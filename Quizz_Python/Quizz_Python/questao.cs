using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizz_Python
{
    class questao
    {
        public questao (string pergunta, string resposta1, string resposta2, string resposta3, string resposta4, char respostaCerta)
        {
            this.pergunta = pergunta;
            this.resposta1 = resposta1;
            this.resposta2 = resposta2;
            this.resposta3 = resposta3;
            this.resposta4 = resposta4;
            this.respostaCerta = respostaCerta;
        }
    


        public string pergunta {  get; set; }
        public string resposta1 { get; set; }
        public string resposta2 { get; set; }
        public string resposta3 { get; set; }
        public string resposta4 { get; set; }
        public char respostaCerta { get; set; }

    }
}
