using System;

namespace Geometria
{
    class forma
    {
        // atributos privados dos objetos pertencente a classe forma
        private int tLados = 0;       // Comprimento dos lados em u.c
        private int qLados = 0;       // Quantidade de lados do polígono
        
        /// <Summary>
        ///  Método que retorna a quantidade de lados do poligono regular
        /// </Summary>
        public int getLados()    
        {   
            // Tratamento para quando o atributo quantidade de lados do poligono nao foi determinado
            if(qLados == 0)
            {
                Console.WriteLine("A quantidade de lados nao foi configurada, dê um valor:");
                int quant_lados;
                quant_lados = int.Parse(Console.ReadLine());
                this.setLados(quant_lados);
            }
            return qLados;
        }
        /// <Summary>
        ///  Método que retorna o tamanho dos lados do poligono regular
        /// </Summary>
        public int getTamanho()
        {   
            // Tratamento para quando o atributo comprimento de lados do poligono nao foi determinado
            if(tLados == 0)
            {
                Console.WriteLine("O comprimento de lados nao foi configurado, dê um valor:");
                int tam_lados;
                tam_lados = int.Parse(Console.ReadLine());
                this.setLados(tam_lados);
            }
            return tLados;
        }

        /// <Summary>
        /// Seta o comprimento no atributo privado do objeto
        /// </Summary>
        public void setTamanho(int tamanhoLados) 
        {
            if ( tamanhoLados < 0 )
            {
                Console.WriteLine( "Digite um comprimento de lado que exista, por favor" );
                int nlados;
                // recebe um novo valor valido de comprimento de lado 
                nlados = int.Parse(Console.ReadLine()); 
                // se refere ao próprio objeto
                this.setTamanho(nlados); // efetua a recursao do metodo para setar o comprimento       
            }
            else
            this.tLados = tamanhoLados;  // seta o tamanho dos lados no atributo do objeto
      

        }
        /// <Summary>
        /// Seta o numero de lados no atributo privado do objeto
        /// </Summary>
        public void setLados(int numeroDeLados)
        {
            if ( numeroDeLados < 3 ) // Nao existe poligono com numeros de lados menor que 3
            {
                Console.WriteLine( "O numero de lados minimo eh 3. Setando valor para 3." );
                numeroDeLados = 3;  
            }
            
            qLados = numeroDeLados; // Seta o numero de lados associando ao atributo do poligono (objeto)
        }
       
    }

    class calculo_forma
    {
        /// <Summary>
        /// Calcula e retorna o valor do perimetro do poligono
        /// </Summary>
        public static int perimetro(forma poligono)
        {   
            int quantLados;
            int tamLados;
            int cPerimetro;
            quantLados = poligono.getLados();    // obtem o numero de lados
            tamLados   = poligono.getTamanho();  // obtem o comprimento dos lados
            cPerimetro =  quantLados * tamLados; // Calcula o perimetro
            return cPerimetro;
        }

        /// <Summary>
        /// Calcula e retorna o valor dos angulos internos do poligono regular
        /// </Summary>
        public static int angulosI(forma poligono)
        {
           int quantLados;
           int medidaAngulo;
           // obtem o numero de lados
           quantLados = poligono.getLados();   
           // Valor dos angulos internos em funcao do numero de lados
           medidaAngulo = (quantLados - 2)*180/quantLados; 
           return medidaAngulo;
        }
    }
}