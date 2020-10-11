using System;

namespace Inheritence
{
    class AlunoDeMaior : Aluno 
    {
        private int insuficiencias;
        public override void resultado ()
        {
            if ( base.aprovado == true )
                Console.WriteLine("O aluno foi aprovado.");
            else
            {
                Console.WriteLine("O aluno teve nota insuficiente. \nSerá recordado em seu histórico, mas não será reprovado por ser de maior.");
                insuficiencias++;
            }
        }
    }
}