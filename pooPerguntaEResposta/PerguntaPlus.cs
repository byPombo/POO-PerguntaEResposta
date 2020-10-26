using System;
using System.Collections.Generic;
using System.Text;

namespace pooPerguntaEResposta
{
    public class PerguntaPlus : Pergunta
    {
        public PerguntaPlus() : base()
        {
            this.Dica = "";
        }
        public PerguntaPlus(string texto, string resposta, string dica):base(texto, resposta)
        {
            this.Dica = dica;
        }

        public string Dica { get; set; }
    }
}
