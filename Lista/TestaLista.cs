using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposAbstratosDeDados
{
    class TestaLista
    {
        static void Main(string[] args)
        {
            Lista l = new Lista();
            int c;

            Console.Write("Digite um nº (-1 para sair): ");
            c = Convert.ToInt32(Console.ReadLine());

            while (c != -1)
            {
                l.Inserir(new NoLista(c));
                Console.Write("Digite outro nº (-1 para sair): ");
                c = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Digite um nº a ser pesquisado: ");
            c = Convert.ToInt32(Console.ReadLine());

            NoLista n = l.Pesquisar(c);
            if (n == null)
                Console.WriteLine("Valor não encontrado!");
            else
                Console.WriteLine("Achou: " + n.chave);

            l.Imprimir();

            Console.ReadKey();
        }
    }
}
