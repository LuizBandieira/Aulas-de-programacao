using System;

namespace Inheritence
{
    class Aluno
    {
        protected bool aprovado; 

        protected string resultadoEscrito; // Não pode ser acessado lá fora mas pode ser acessado pelas filhas

        public void aprovacao(int status)
        {
            if(status == 1)
                this.aprovado = true;
            else
                this.aprovado = false;
        }
        public virtual void resultado()
        {
            if ( aprovado == true )
                this.resultadoEscrito = "O aluno foi aprovado";
            else
                this.resultadoEscrito = "O aluno foi reprovado";
        }

        public string getResultadoEscrito()
        {
            return resultadoEscrito;
        }
    }
}