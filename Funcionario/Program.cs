using System;

namespace Funcionario
{
    class Program
    {
        static void Main(string[] args)
        {

            Pessoa p1 = new Pessoa();

           Console.Write("Digite o nome do(a) funcionário(a): ");
           p1.Nome = Console.ReadLine();
           Console.Write("Digite o RG do(a) funcionário(a): ");
           p1.Rg = Console.ReadLine();


            double salarioinicial = 10000;

            double salario2017 = (salarioinicial + (salarioinicial * 1.50 / 100));

            double salario2018 = (salario2017 + (salario2017 * 3.00 / 100));

            double salario2019 = (salario2018 + (salario2018 * 3.00 / 100));

            double salario2020 = (salario2019 + (salario2019 * 3.00 / 100));


        Console.WriteLine("O nome do funcionário é: " + p1.Nome + " / O rg é: " + p1.Rg + " / O salario em 2020 é: " + salario2020.ToString("F2") + " reais");
            


        }
    }
}
