using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvoreBinaria
{
    class Arvore
    {
        public NoArvore raiz = null;

        public void inserir(int chave)
        {
            if (raiz == null)
            {
                raiz = new NoArvore(chave);
            }
            else
            {
                raiz.inserir(chave);
            }
        }

        public void emOrdem(NoArvore x)
        {
            if (x != null)
            {
                emOrdem(x.esq);
                Console.Write(x.chave + " ");
                emOrdem(x.dir);
            }
        }

        public void preOrdem(NoArvore x)
        {
            if (x != null)
            {
                Console.Write(x.chave + " ");
                preOrdem(x.esq);
                preOrdem(x.dir);
            }
        }

        public void posOrdem(NoArvore x)
        {
            if (x != null)
            {
                posOrdem(x.esq);
                posOrdem(x.dir);
                Console.Write(x.chave + " ");
            }
        }

        public NoArvore pesquisar(int c, NoArvore x)
        {
            if (x == null || x.chave == c)
                return x;
            else if (c < x.chave)
                return pesquisar(c, x.esq);
            else
                return pesquisar(c, x.dir);

        }
    }

    public class NoArvore
    {
        public int chave;
        public NoArvore esq, dir;

        public NoArvore(int c)
        {
            chave = c;
            esq = dir = null;
        }

        public void inserir(int c)
        {
            if (c < chave)
            {
                if (esq == null)
                    esq = new NoArvore(c);
                else
                    esq.inserir(c);
            }
            else if (c > chave)
            {
                if (dir == null)
                    dir = new NoArvore(c);
                else
                    dir.inserir(c);
            }
            else
                Console.Write("Chave duplicada. Impossível inserir!");
        } // fim do metodo inserir
    }
}

