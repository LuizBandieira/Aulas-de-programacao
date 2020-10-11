using System;

namespace Inheritence
{
    class Aluno
    {
        public bool aprovado;
        public virtual void resultado()
        {
            if ( aprovado == true )
                Console.WriteLine("O aluno foi aprovado.");
            else
                Console.WriteLine("O aluno foi reprovado.");
        }
    }
}