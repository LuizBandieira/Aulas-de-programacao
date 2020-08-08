using System; // system é uma namespace que atua como as bibliotecas do C 
using System.Collections.Generic; // bibliota das listas
using Geometria; 
using Zahlenmanipulation; // manipulação de numeros

namespace Aula3
{
    class Program  
    { 
        
        static void Main(string[] args)
        {
            
            List<int> lista;          // Declara um objeto do tipo lista de inteiros para os valores aleatorios
            lista = new List<int>();  // Intânciamento 
            List<int> listaPrimos;    // Declara um objeto do tipo lista de inteiros para os numeros primos
           
            Numero comparador;        // Declarando um objeto da classe Numero
            MediaAritmetica Mediador; // Declarando um objeto da classe MediaAritmetica
            Contador definidor;       // Declarando um objeto da classe Contador
            Primos   anzeigen;        // Declarando um objeto da classe Primos

            var rand = new Random();  // Seedando para gerar numeros aleatorios
            
            // Declarando as variáveis
            int maiorNumero, menorNumero, imin, imax, media; 
            int nPares, nImpares, nNegativos;
        
            Console.WriteLine("Lista de numeros aleatorios");
            for(int i = 0; i < 50; i++)       // laço de repetição
            {
                lista.Add(rand.Next(-50,50)); // adiciona valores aleatorios de -50 a 50 na lista
                if(i % 10 == 0)               
                Console.Write("\n");

                Console.Write(lista[i] + " "); // printando no console os elementos da lista
            }

            comparador = new Numero();         // instanciamento do objeto à classe 
            (maiorNumero, menorNumero, imax, imin) = comparador.NummerPosition(lista);  
            Console.WriteLine("\nO valor máximo é {0} e está na posição {1}", maiorNumero, imax);
            Console.WriteLine("\nO valor minimo é {0} e está na posição {1}", menorNumero, imin);

            Mediador = new MediaAritmetica();
            media = Mediador.calcular(lista);
            Console.WriteLine("\nA media dos números é {0}", media);

            definidor  = new Contador();

            nPares     = definidor.pares(lista);
            Console.WriteLine("\nO número de pares é {0}", nPares);
            nImpares   = definidor.impares(lista);
            Console.WriteLine("\nO número de impares é {0}", nImpares);
            nNegativos = definidor.negativos(lista);
            Console.WriteLine("\nO número de negativos é {0}", nNegativos);

            listaPrimos = new List<int>();
            anzeigen = new Primos();
            listaPrimos.AddRange(anzeigen.encontrar(lista));

            Console.WriteLine("\nLista de numeros primos");
            foreach(int element in listaPrimos)
                Console.Write(element + " ");
        
            Console.ReadKey();
        
        }

    }
}
