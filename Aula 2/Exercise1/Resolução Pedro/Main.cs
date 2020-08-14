using System;
using System.Collections.Generic;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();
            List<int> primos = new List<int>();

            int maiorValor = 0;
            int posicaoMaior = 0;
            int menorValor = 0;
            int posicaoMenor = 0;
            
            int quantPar = 0;
            int quantImpar = 0;
            int quantNegativos = 0;

            ComparacaoTamanho comparador;
            MediaArtimetica calcMedia;
            ParImpar contaParImpar;
            Negativos contaNegativos;
            Primos exibePrimos;

            Console.WriteLine ("Números aleatórios gerados: ");
            var rand = new Random();
            for ( int loop = 0; loop < 50; loop++ )
            {
                numeros.Add (rand.Next (-25, 50) );
                Console.Write (numeros [loop] + " ");
                if ( loop % 25 == 0 && loop > 0) Console.WriteLine("");
            }
            Console.WriteLine("\n");

            comparador  = new ComparacaoTamanho();
            (maiorValor, posicaoMaior) = comparador.maior (numeros);
            (menorValor, posicaoMenor) = comparador.menor (numeros);

            calcMedia = new MediaArtimetica();
            float media = calcMedia.media(numeros);

            contaParImpar = new ParImpar();
            (quantPar, quantImpar) = contaParImpar.contagemParImpar (numeros);

            contaNegativos = new Negativos();
            quantNegativos = contaNegativos.contagemNegativos (numeros);

            exibePrimos = new Primos();
            primos = exibePrimos.guardaPrimos(numeros);

            
            Console.WriteLine ("O maior valor é " + maiorValor + " e ele está na posição " + posicaoMaior + ".");
            Console.WriteLine ("O menor valor é " + menorValor + " e ele está na posição " + posicaoMenor + ".");
            Console.WriteLine ("A média aritmética é " + media + ".");
            Console.WriteLine ("Existem "+ quantPar + " números pares e " + quantImpar + " números ímpares.");
            Console.WriteLine ("Existem " + quantNegativos + " números negativos.");
            Console.Write ("\nNúmeros primos encontrados: ");
            foreach (int valor in primos)
            {
                Console.Write (valor + " ");
            }
            
            Console.ReadKey();
        }
    }

    class ComparacaoTamanho
    {
        public (int, int) maior (List<int> numeros)
        {
            int maior = 0;
            int posicao = 0;
            for (int loop = 0; loop < numeros.Count; loop++)
            {
                if ( numeros [loop] > maior )
                {
                    maior = numeros [loop];
                    posicao = loop;
                }
            }           
            return (maior, posicao);
        }

        public (int, int) menor (List<int> numeros)
        {
            int menor = 0;
            int posicao = 0;
            for (int loop = 0; loop < numeros.Count; loop++)
            {
                if ( numeros [loop] < menor )
                {
                    menor = numeros [loop];
                    posicao = loop;
                }
            }
            return (menor, posicao);
        }        
    }

    class MediaArtimetica
    {
        public float media (List<int> numeros)
        {
            float media = 0;
            foreach (int valor in numeros)
            {
                media += valor;
            }
            media /= numeros.Count;

            return media;
        }
    }

    class ParImpar
    {
        public (int, int) contagemParImpar (List<int> numeros)
        {
            int contaPar = 0;
            int contaImpar = 0;
            foreach (int valor in numeros)
            {
                if (valor % 2 == 0)
                {
                    contaPar++;
                }

                else
                {
                    contaImpar++;
                }
            }

            return (contaPar, contaImpar);
        }
    }

    class Negativos
    {
        public int contagemNegativos (List<int> numeros)
        {
            int negativos = 0;
            foreach (int valor in numeros)
            {
                if ( valor < 0 )
                {
                    negativos++;
                }
            }

            return negativos;
        }
    }

    //Estou com sono, pare de me julgar
    class Primos
    {
        public List<int> guardaPrimos (List<int> numeros)
        {
            List<int> primos = new List<int>();
            bool primo = true;

            foreach (int valor in numeros)
            {
                primo = true;
                /*
                if ( valor < 0  )
                    {
                        continue;
                    }
                */    
                
                for ( int loop = 2; loop < Math.Abs(valor); loop++ )
                {                                             
                    if (Math.Abs(valor) < 1)
                    {
                        int i = Math.Abs(valor);

                        if ( i % loop > 0 )
                        {
                            primo = true;
                        }

                        else
                        {
                            primo = false;
                            break;
                        }
                    }

                    else if ( Math.Abs(valor) > 1 && valor % loop == 0)
                    {                  
                        primo = false;
                        continue;
                    }
                }
                
                if ( primo == true && valor != 0)
                {
                    if ( Math.Abs(valor) < 1 || Math.Abs(valor) > 1)
                    {
                        primos.Add(valor);      
                    }                    
                }                
            }

            return primos;
        }
    }
}