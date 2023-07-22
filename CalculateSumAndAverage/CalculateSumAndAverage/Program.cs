using CalculateSumAndAverage.Operations.Users.Classes;
using CalculateSumAndAverage.Operations.Users.Interfaces;
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var controlNumbers = new ControlNumbers();
        var control = true;

        while (control)
        {
            Console.WriteLine("Digite de quantos números você quer calcular a soma e a média (entre 3 e 10):");
            var quantity = controlNumbers.GetTotalQuantity();

            var numbers = new double[quantity];
            for (int i = 0; i < quantity; i++)
            {
                Console.WriteLine($"Digite o número {i + 1}:");
                numbers[i] = controlNumbers.GetNumbers();
            }

            Console.WriteLine($"A soma dos números é: {numbers.Sum()}");
            Console.WriteLine($"A média dos números é: {numbers.Average()}");
            Console.WriteLine("Aperte 0 para sair ou qualquer tecla para continuar\n");
            var response = Console.ReadLine();

            if (response == "0")
            {
                break;
            }
        }       
    }
}
