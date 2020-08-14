using System;
using Geometria;
namespace CriadorDeFormas
{
    class formador
    {
        public static forma formarTriangulo(int TamanhoLados)
        {
            forma triangulo;
            triangulo = new forma();
            triangulo.setLados(3);
            triangulo.setTamanho(TamanhoLados);
            return triangulo;
        } 
    }
}