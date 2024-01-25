class Program
    {
        static void Main(string[] args)
        {
            int questao;
            Console.WriteLine("LIsta de AED(Algoritimo e Estrutura de Dados) - Digite o número de uma questão para visualizá-la: ");
            questao = Convert.ToInt32(Console.ReadLine());

            switch (questao)
            {
                case 1:
                    Q1(args);
                    break;
                case 2:
                    Q2(args);
                    break;
                case 3:
                    Q3();
                    break;
            }

            Console.ReadKey();
        }
        static void Q1(string[] args)
        { //Questão 1, Escreva um programa que preencha um vetor de N elementos inteiros, calcule a soma, a média
          //aritmética, a quantidade de elementos abaixo da média, o índice do maior e o índice do menor.
          //O valor de N deverá ser informado pelo usuário no início da execução.
            Console.Write("Digite um tamanho N para o vetor: ");
            
            int tamanho = Convert.ToInt32(Console.ReadLine()),  
                soma = default, abaixoMedia = default, 
                maior = int.MinValue, indiceMaior = default,
                menor = int.MaxValue, indiceMenor = default;
            double media;

            int[] vet = new int[tamanho];
            
            Random random = new Random();
            for(int i = 0; i < vet.Length; i++)
            {
                vet[i] = random.Next(-1000, 1000);
                soma += vet[i];
               
                if(vet[i] > maior)
                {
                    maior = vet[i];
                    indiceMaior = i;
                }
              
                if (vet[i] < menor)
                {
                    menor = vet[i];
                    indiceMenor = i;
                }
            }
            
            media = soma / vet.Length;
                 
            for (int i = 0; i < vet.Length; i++)
                if (vet[i] < media)
                    abaixoMedia++;

            Console.WriteLine($"Soma: {soma}");
            Console.WriteLine($"Média: {media}");
            Console.WriteLine($"Quantidade de números abaixo da média: {abaixoMedia}");
            Console.WriteLine($"Índice do maior número: {indiceMaior}");
            Console.WriteLine($"Índice do menor número: {indiceMenor}");

            Console.ReadKey();
        }
    }

        static void Q2(string[] args)
        {  //Questão 2, Escreva um programa que preencha aleatoriamente uma matriz real de 6x6, calcule a soma e a média
            //dos elementos situados acima da diagonal secundária, incluindo a própria diagonal.
            /* Faça um programa que preencha uma 
             * matriz de 6x6 do tipo int da seguinte forma:
             *   0 1 2 3 4 5
             * 0|0 1 1 1 1 1
             * 1|2 0 1 1 1 1
             * 2|2 2 0 1 1 1
             * 3|2 2 2 0 1 1
             * 4|2 2 2 2 0 1
             * 5|2 2 2 2 2 0
             * */
           double soma = default, media;
            int acimaDiagonal = default;
            
            int[,] matriz = new int[6, 6];
            Random random = new Random();
            int colPos;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {         
                colPos = matriz.GetLength(1) - i - 1;

                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = random.Next(0, 100);
                    if(j <= colPos)
                    {
                        soma += matriz[i, j];
                        acimaDiagonal++;
                    }
                }
            }

            media = soma / acimaDiagonal;
            Console.WriteLine($"Soma: {soma}");
            Console.WriteLine($"Média: {media}");

            Console.ReadKey();
        }
        static void Q3()
        { 

        { /*Questão 1,Dê a codificação completa da classe Aluno, de acordo com o seguinte diagrama:
            O método GetNotaFinal() deverá calcular e retornar a nota final do aluno, que consiste na
            média aritmética das três notas.
            O método GetResultado() deverá retornar um string contendo o resultado final do aluno, de
            acordo com a seguinte tabela:
            o "Aprovado": nota final maior ou igual a 60 pontos.
            o "Recuperação": nota final entre 40 e 59 pontos, inclusive.
            o "Reprovado": nota inferior a 40 pontos.*/
            
            string nom;
            double med, n1, n2,n3;
            Console.WriteLine("Digite a primeira nota do aluno:");
            Console.ReadLine();
            Console.WriteLine("Digite a segunda nota do aluno:");
            Console.ReadLine();
            Console.WriteLine("Digite a terceira nota do aluno:");
            Console.ReadLine();
            if (med < 40)
            {
                Console.WriteLine("Reprovado" + med);
            }
            else if (med <= 59)
            {
                Console.WriteLine("Recuperação" + med);
            }
            else
            {
               Console.WriteLine("De acordo com a media calculada aluno está aprovado nota final maior ou igual a 60 pontos" + med);
            }
            
        }
        }
       
        

    