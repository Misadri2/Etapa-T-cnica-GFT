using System;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14;

            Console.Write("Informe o lado do quadrado: ");
            double lado = double.Parse(Console.ReadLine());
            double areaquadrado = lado * lado;

            Console.Write("Informe a largura do Retângulo : ");
            double largura = double.Parse(Console.ReadLine());
            Console.Write("Informe a altura do Retângulo : ");
            double altura = double.Parse(Console.ReadLine());
            double arearetangulo = largura * altura;

            Console.Write("Informe o raio do círculo: ");
            double raio = int.Parse(Console.ReadLine());
            double areacirculo = pi * (Math.Pow(raio,2));

            Console.WriteLine("A área do quadrado é: " + areaquadrado.ToString("F2"));
            Console.WriteLine("A área do retângulo é: " + arearetangulo.ToString("F2"));
            Console.WriteLine("A área do círculo é: " + areacirculo.ToString("F2"));



        }
    }
}
