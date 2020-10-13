using System;
using Geometria;
namespace CriadorDeFormas
{
    class formador
    {
        ///<summary>
        /// Metodo estatico que retorna um triangulo 
        ///</summary>
        public static forma formarTriangulo(int TamanhoLados)
        {   
            // Declara um objeto do tipo forma
            forma triangulo;
            // Instancia o objeto
            triangulo = new forma();
            // Altera atributos privados do objeto atraves de metodos publicos
            triangulo.setLados(3);
            triangulo.setTamanho(TamanhoLados);
            // Retorna o objeto com os atributos setados
            return triangulo;
        } 
    }
}