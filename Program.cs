using System;

namespace deMilhasPraKm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nfale a unidade em milhas que eu mostrarei o resultado em Km: ");
            double ValorMilhas = Convert.ToDouble(Console.ReadLine());

            double ValorKm = ValorMilhas * 1.609;

            Console.WriteLine($"\nvalor em Km: {ValorKm}\n");
        }
    }
}
