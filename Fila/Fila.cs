using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * CLASSE FILA - IMPLEMENTA O TIPO ABSTRATO DE DADOS FILA ESTÁTICA CIRCULAR
 * OPERAÇÕES: *
 *	Vazia() -> retorna true se a fila está vazia.
 *	Cheia() -> returna true se a fila  está cheia.
 *	Enfileirar(x) -> coloca o elemento x no fim da fila.
 *	Desenfileirar() -> retorna o elemento situado no inicio da fila.
 */

namespace TiposAbstratosDeDados
{
    class Fila
    {
        private int[] vet;
        private int inicio;
        private int fim;

        public Fila(int tam)
        {
            vet = new int[tam + 1];
            inicio = fim = 0;
        }

        public void Enfileirar(int i)
        {
            vet[fim] = i;
            fim = (fim + 1) % vet.Length;
        }

        public int Desenfileirar()
        {
            int item = vet[inicio];
            inicio = (inicio + 1) % vet.Length;
            return item;
        }

        public bool Vazia()
        {
            return inicio == fim;
        }

        public bool Cheia()
        {
            return ((fim + 1) % vet.Length) == inicio;
        }
    }
}
