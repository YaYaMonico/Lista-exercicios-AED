using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPilha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Ler 10 números e imprimí-los na ordem inversa */
            Pilha p = new Pilha(10);
            while(!p.Cheia())
            {
                Console.Write("Digite um nº: ");
                int num = Convert.ToInt32(Console.ReadLine());
                p.Empilhar(num);
            }
            Console.WriteLine("Valores na ordem inversa:");
            while(!p.Vazia())
            {
                int num = p.Desempilhar();
                Console.WriteLine(num);
            }
            Console.ReadKey();
        }
    }
}
