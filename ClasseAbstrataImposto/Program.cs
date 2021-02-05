using ClasseAbstrataImposto.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ClasseAbstrataImposto
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();
            
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char type = Console.ReadLine()[0];
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (type == 'i' || type == 'I')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, anualIncome, healthExpenditures));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, anualIncome, numberOfEmployees));
                }
            }
            Console.WriteLine("\nTAXES PAID:");

            double sum = 0.0;
            foreach(TaxPayer taxPayer in list)
            {
                Console.WriteLine(taxPayer);
                sum += taxPayer.Tax();
            }
            Console.WriteLine($"\nTOTAL TAXES: $ {sum.ToString("F2",CultureInfo.InvariantCulture)}");

        }
    }
}
