using System;

namespace Exercise_2
{
    class Forma
    {
        private int qntLados;
        private int tamanhoLados;
        private int perimetro;
        private int somaAngulos;
        private int umAngulo;

        public int lerLados (int lados)
        {
            try
            {
                if ( lados <= 2 )
                {
                    throw new Exception("Apenas números positivos!");
                }

                else
                {
                    qntLados = lados;
                }
            }

            catch (System.Exception)
            {
                Console.WriteLine ("Entrada inválida.");
                Console.WriteLine ("Insira outro valor: ");
                lados = int.Parse (Console.ReadLine());
                this.lerLados (lados);
            }

            return qntLados;
        }
        
        public int lerTamanho (int tamanho)
        {            
            try
            {
                if ( tamanho < 0 )
                {
                    throw new Exception("Apenas números positivos!");
                }

                else
                {
                    tamanhoLados = tamanho;
                }
            }         
            
            catch (System.Exception)
            {
                Console.WriteLine ("Entrada inválida.");
                Console.WriteLine ("Insira outro valor: ");
                tamanho = int.Parse (Console.ReadLine());
                this.lerTamanho (tamanho);
            }

            return tamanhoLados;
        }

        public int calculaPerimetro ()
        {
            perimetro = qntLados * tamanhoLados;

            return perimetro;
        }

        public int angulosInternos (int lados)
        {
            int angulo = 0;
            int totalAngulos = 0;
            totalAngulos = ((lados - 2) * 180);
            angulo = (totalAngulos / lados);

            umAngulo = angulo;
            somaAngulos = totalAngulos;

            return angulo;
        }
    }
        
    class Program
    {
        static void Main(string[] args)
        {   
            Forma calculos = new Forma();

            int lados = int.Parse (Console.ReadLine());
            calculos.lerLados (lados);

            int tamanho = int.Parse (Console.ReadLine());
            calculos.lerTamanho (tamanho);

            int perimetro = calculos.calculaPerimetro ();
            int angulosInternos = calculos.angulosInternos (lados);

            Console.WriteLine ("A forma tem " + lados + " lados");
            Console.WriteLine ("O perímetro possui " + perimetro + " centímetros.");
            Console.WriteLine ("O ângulo dessa joça é: " + angulosInternos);

            Console.ReadKey();
        }
    }
}
