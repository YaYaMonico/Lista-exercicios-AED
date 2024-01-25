using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMin
{
    class MaxMin
    {

        // Operação relevante: TESTES (if)
        // T(n) = 2n - 2
        public void MaxMin1(int[] vet, out int ma, out int me)
        {
            ma = me = vet[0];
            for (int i = 1; i < vet.Length; i++)
            {
                if (vet[i] < me)
                    me = vet[i];
                if (vet[i] > ma)
                    ma = vet[i];
            }
        }

        // Melhor caso: T(n) = n - 1
        // Pior caso: T(n) = 2n - 2
        // Caso médio: T(n) = 3n/2 - 3/2
        public void MaxMin2(int[] vet, out int ma, out int me)
        {
            ma = me = vet[0];
            for (int i = 1; i < vet.Length; i++)
            {
                if (vet[i] < me)
                    me = vet[i];
                else     
                    if (vet[i] > ma)
                        ma = vet[i];
                
            }
        }

        // T(n) = 3n/2 - 2
        public void MaxMin3(int[] vet, out int ma, out int me)
        {
            if (vet[0] < vet[1])
            {
                me = vet[0];
                ma = vet[1];
            }
            else
            {
                me = vet[1];
                ma = vet[0];
            }
            for (int i = 2; i < vet.Length; i += 2)
            {
                if (vet[i] < vet[i + 1])
                {
                    if (vet[i] < me)
                        me = vet[i];
                    if (vet[i + 1] > ma)
                        ma = vet[i + 1];
                }
                else
                {
                    if (vet[i + 1] < me)
                        me = vet[i + 1];
                    if (vet[i] > ma)
                        ma = vet[i];
                }
            }
        }
    }
}
