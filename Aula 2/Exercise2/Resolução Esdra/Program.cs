using System;
using Geometria;

namespace Resolução_Esdra
{
    class Program
    {
        static void Main(string[] args)
        {   
           
           forma poligono;          // Determina o objeyto poligono da clase forma da biblioteca geometria
           poligono = new forma();  // Instanciamento do objeto
           int nladosLidos;         // Variável que armazena o numero de lados do poligono
           int cladosLidos;         // Variavel que armazena o comprimento dos lados do poligono regular

           Console.WriteLine("Digite o numero de lados do poligono regular"); // msg no terminal
           // atribui o numero de lados conforme escolha do usuario
           nladosLidos = int.Parse(Console.ReadLine()); 
           // seta o numero de lados associando o valor a um atributo privado do objeto atraves de um metodo publico
           poligono.setLados(nladosLidos); 
             
           Console.WriteLine("Digite o comprimento do lado"); // msg no terminal
           // atribui o comprimentos dos lados conforme escolha do usuario
           cladosLidos = int.Parse(Console.ReadLine()); // Console.ReadLine() retorna um string, deve-se converter com parse
           // sete o comprimento dos lados associando o valor a um atributo privado do objeto atraves de um metodo publico
           poligono.setTamanho(cladosLidos);

           poligono.perimetro(); // Metodo que retorna o perimetro do poligono
           poligono.angulosI();  // Metodo que retorna a medida dos angulos internos do poligono


        }
    }
}
