using System;
using CriadorDeFormas;
using Geometria;
namespace Resolução_Esdra
{
    class CriaTriangulos
    {
        static void Main(string[] args)
        {
            // Nao eh necessaria instanciar um objeto da classe formador 
            // pois o metodo formarTriangulo eh estatico e sendo assim, 
            // eh atrelado a classe e nao ao objeto
            forma poligono = formador.formarTriangulo(15);
            poligono.perimetro();

        }
    }
}
