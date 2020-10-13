using System;
using System.Collections.Generic;

namespace Zahlenmanipulation
{
    class Primos
    {
        public List<int> encontrar(List<int> lista)
        {   
            int ndiv = 0;
            List<int> listaPrimos;
            listaPrimos = new List<int>();

            for(int i = 0; i < lista.Count; i++)
            {
                for(int d = 1; d < Math.Abs(lista[i]); d++)
                {   
                    
                    if(Math.Abs(lista[i]) % d == 0)
                    ndiv++;
                }
                
                if(ndiv < 2 && Math.Abs(lista[i]) > 1)
                    listaPrimos.Add(lista[i]);
                ndiv = 0;
            }

            return listaPrimos;
        }
    }
    class Contador
    {
        public int pares(List<int> lista)
        {   
            int npares = 0;

            foreach(int element in lista)
            {
                if(element % 2 == 0)
                    npares++;
            }

            return npares;
        }
        public int impares(List<int> lista)
        {
            int nimpares = 0;

             foreach(int element in lista)
            {
                if(element % 2 != 0)
                    nimpares++;
            }
            
            return nimpares;
        }

        public int negativos (List<int> lista)
        {
            int nNegativos = 0;

            foreach (int element in lista)
            {
                if(element < 0)
                nNegativos++;
            }

            return nNegativos;
        }
       
    }
    class MediaAritmetica
    {
        public int calcular(List<int> lista)
        {   
            int media = 0;

            foreach(int element in lista)
                media += element;
            
            media /= lista.Count;

            return media; // parenteses necessarios para retornar tuplas, nur!
        }
    }
    class Numero
    {
        int inMaior;
        int inMenor;
        public (int, int, int, int) NummerPosition(List<int> lista)
        {
            
            List<int> aux = new List<int>();
           /// aux = lista; apontando a lista pra outra lista !!!
            aux.AddRange(lista); 

            aux.Sort();

            //MaiorValor = lista[lista.Count - 1];
            //MenorValor = lista[0];

            for(int j = 0; j < lista.Count; j++)
            {
                if(lista[j] == aux[lista.Count - 1])
                inMaior = j;
                
                if(lista[j] == aux[0])
                inMenor = j;
            }
            
            return(aux[lista.Count - 1], aux[0], inMaior, inMenor);

        }
    }
}