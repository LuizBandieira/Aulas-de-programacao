using System;
using Geometria;
using CriadorDeFormas;

namespace Resolução_Esdra
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declara um objeto da classe forma que eh determinado pelo
            // metodo estatico da classe formador
            forma poligono = formador.formarTriangulo(50); // O objeto eh um triangulo
            // Armazena os valores dos atributos do objeto
            int numLados;   // numero de lados do poligono regular
            int comLados;   // comprimento dos lados 
            int perimetro;  // perimetro 
            int angInterno; // comprimento dos angulos internos
            
            // Atribui o numero de lados do poligono a variavel 
            numLados   = poligono.getLados(); 
            Console.WriteLine("O poligono regular possui " + numLados + " lados.");
            // Atribui o comprimeto dos lados do poligono a variavel 
            comLados   = poligono.getTamanho();
            Console.WriteLine("O lado possui comprimento de " + comLados + " u.c");
            // Obtem o perimetro da figura
            perimetro  = calculo_forma.perimetro(poligono);
            Console.WriteLine("O perimetro mede " + perimetro + " u.c");
            
            // Associa e exibe o comprimento do angulo interno do poligono regular
            angInterno = calculo_forma.angulosI(poligono);
            Console.WriteLine("O angulo interno do poligono mede " + angInterno + " graus");
        }
    }
}
