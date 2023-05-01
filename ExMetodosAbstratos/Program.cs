using ExMetodosAbstratos.Entities;
using System;
using System.Globalization;

namespace ExMetodosAbstratos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();//Criando a lista de produtos

            double totalTaxes = 0;

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Taxer payer # {i} data:");

                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Anual Income: ");
                double anualincome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthexpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Individual(name, anualincome, healthexpenditures));
                }
                else
                {
                    Console.Write("Number of employees:");
                    int numberofemployees = int.Parse(Console.ReadLine());

                    list.Add(new Company(name, anualincome, numberofemployees));
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID: ");
            foreach (TaxPayer txp in list)
            {
                Console.WriteLine(txp.Name + "$ " + txp.tax().ToString("F2", CultureInfo.InvariantCulture));
                totalTaxes += txp.tax();
            }

            Console.WriteLine("TOTAL TAXES: " + totalTaxes.ToString("F2", CultureInfo.InvariantCulture)) ;

        }
    }
}