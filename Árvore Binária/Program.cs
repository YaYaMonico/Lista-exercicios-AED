using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvoreBinaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Arvore v = new Arvore();
            v.inserir(4);
            v.inserir(2);
            v.inserir(10);
            v.inserir(3);
            v.emOrdem(v.raiz);
            //		v.preOrdem(v.raiz);
            //		v.posOrdem(v.raiz);
            NoArvore resp = v.pesquisar(7, v.raiz);
            if (resp == null)
            {
                Console.WriteLine("Chave não encontrada!");
            }
            else
            {
                Console.WriteLine("Chave encontrada: " + resp.chave);
            }
            Console.ReadKey();
        }
    }
}
