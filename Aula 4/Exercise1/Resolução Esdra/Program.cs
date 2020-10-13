using System;
using System.Collections.Generic;

namespace Inheritence
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Aluno> escola = new List<Aluno>();
            for (int count = 0; count < 3; count ++)
                escola.Add( gerador() );

            foreach(Aluno estudante in escola)
            {
                estudante.resultado();
                Console.WriteLine(estudante.getResultadoEscrito());
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        public static Aluno gerador( ) 
        {
            Aluno gerado;
            Console.WriteLine("Insira a idade do aluno");
            int idade = int.Parse(Console.ReadLine());
            if (idade > 17)
                gerado = new AlunoDeMaior();
            else   
                gerado = new Aluno();

            Console.WriteLine("Esse aluno foi reprovado ou aprovado?");
            Console.WriteLine("1. Aprovado\n2. Reprovado");
            int status = int.Parse(Console.ReadLine());
            
            gerado.aprovacao(status);
            
           /* if (status == 1)
                gerado.aprovacao(true);
            else
                gerado.aprovacao(false);*/
                
            return gerado;
        }
    }
}
