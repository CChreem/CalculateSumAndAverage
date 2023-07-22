using CalculateSumAndAverage.Operations.Users.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateSumAndAverage.Operations.Users.Classes
{
    public class ControlNumbers : IControlNumbers
    {
        public int GetTotalQuantity()
        {
            int quantity;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out quantity) && quantity >= 3 && quantity <= 10)
                {
                    return quantity;
                }
                else
                {
                    Console.WriteLine("Quantidade inválida. Digite um número entre 3 e 10.");
                }
            }
        }

        public double GetNumbers()
        {
            double numero;
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out numero))
                {
                    return numero;
                }
                else
                {
                    Console.WriteLine("Número inválido. Digite um valor numérico válido.");
                }
            }
        }
    }
}
