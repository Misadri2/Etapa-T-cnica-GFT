using System;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcQuadrado q = new CalcQuadrado();
            CalcCirculo c = new CalcCirculo();
            CalcRetangulo r = new CalcRetangulo();


            Console.Write("Informe o lado do quadrado: ");
            q.Lado = double.Parse(Console.ReadLine());

            Console.Write("Informe o raio do círculo: ");
            c.Raio = double.Parse(Console.ReadLine());
            c.Pi = 3.14;

            Console.Write("Informe a largura do Retângulo : ");
            r.Largura = double.Parse(Console.ReadLine());
            Console.Write("Informe a altura do Retângulo : ");
            r.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine("A área do quadrado é: " + q);
            Console.WriteLine("A área do círculo é: " + c);
            Console.WriteLine("A área do retângulo é: " + r);
        }
    }
}
