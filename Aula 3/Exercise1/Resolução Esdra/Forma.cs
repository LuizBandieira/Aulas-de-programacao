using System;

namespace Geometria
{
    class forma
    {
        // atributos privados dos objetos pertencente a classe forma
        private int tLados;       // Comprimento dos lados em u.c
        private int qLados;       // Quantidade de lados do polígono
        private int cPerimetro;   // Comprimento do perimetro do poligono
        private int medidaAngulo; // Medida calculada do angulo interno
        
        /// <Summary>
        ///  Método que exibe a quantidade de lados do poligono determinado
        /// </Summary>
        private void briefer()    
        {
            Console.WriteLine("Essa forma possui " + qLados + " lados");
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
        /// <Summary>
        /// Calcula e exibe o valor do perimetro do poligono
        /// </Summary>
        public void perimetro()
        {
            cPerimetro = qLados * tLados; // Calcula o perimetro
            // Exibe o valor calculado
            Console.WriteLine("O comprimento do perimetro eh " + cPerimetro + " u.c");
        }

        /// <Summary>
        /// Calcula o valor dos angulos internos do poligono regular
        /// </Summary>
        public void angulosI()
        {
           // Valor dos angulos internos em funcao do numero de lados
           medidaAngulo = (qLados - 2)*180/qLados; 
           // Exibe o valor dos angulos internos
           Console.WriteLine("A medida dos angulos internos do poligono regular eh " + medidaAngulo + " graus");
        }
    }
}