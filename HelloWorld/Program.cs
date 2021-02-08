using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a palavra World: ");
            string A = Console.ReadLine();
            Console.Write("Digite a palavra Hello: ");
            string B = Console.ReadLine();
            string C = null;
             C =  A;
             A =  B;
             B =  C;

            Console.WriteLine( A + " "+ B );

        
        }
    }
}
