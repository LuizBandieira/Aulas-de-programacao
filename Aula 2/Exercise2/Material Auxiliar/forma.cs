using System;

namespace Geometria
{
    class forma
    {
        // tem um numero inteiro de lados.
        private int lados;

        private void briefer()
        {
            Console.WriteLine("Essa forma possui " + lados + " lados");
        }

        public void setLados(int numeroDeLados)
        {
            if ( numeroDeLados < 3 )
            {
                Console.WriteLine( "O numero de lados minimo eh 3. Setando valor para 3." );
                numeroDeLados = 3;
            }
            
            lados = numeroDeLados;
            briefer();

        }
    }
}