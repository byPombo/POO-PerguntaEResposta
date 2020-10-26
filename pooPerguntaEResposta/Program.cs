using System;

namespace pooPerguntaEResposta
{
    class Program
    {
        static void Main(string[] args)
        {
            PerguntaPlus p = new PerguntaPlus();
            p.Texto = "QUal é o seu nome?";
            p.Resposta = "Daniel";
            p.Dica = "O mais lindo.";

            Console.WriteLine("Tente adivinhar a pergunta");
            Console.WriteLine("Pergunta: " + p.Texto);
            Console.WriteLine("Dica: " + p.Dica);
            Console.Write("Pergunta: ");
            string resposta = Console.ReadLine();

            if (p.Resposta == resposta)
            {
                Console.WriteLine("Você acertou!");
            }
            else
            {
                Console.WriteLine("Você errou!");
            }
            Console.ReadKey();
        }
    }
}
