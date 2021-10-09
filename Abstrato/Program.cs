using System;
using System.Collections.Generic;
using System.Text;
using Abstrato.Entities;

namespace Abstrato
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> TaxPayer = new List<TaxPayer>();
            int NumberTaxPayer, i, CompanyEmployeesNumb;
            char IndOrComp;
            string NameTaxPayer;
            double IncomeTaxPayer, HealthExpendituresInd, SumTaxP = 0;

            Console.Write("Enter the number of tax payers: ");
            NumberTaxPayer = int.Parse(Console.ReadLine());
            for(i = 1; i <= NumberTaxPayer; i++)
            {
                Console.WriteLine($"Tax Payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                IndOrComp = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                NameTaxPayer = Console.ReadLine();
                Console.Write("Anual income: ");
                IncomeTaxPayer = double.Parse(Console.ReadLine());
                switch (IndOrComp)
                {
                    case 'i':
                        Console.Write("Health expenditures: ");
                        HealthExpendituresInd = double.Parse(Console.ReadLine());
                        TaxPayer.Add(new Individual(NameTaxPayer, IncomeTaxPayer, HealthExpendituresInd));
                        break;
                    case 'c':
                        Console.Write("Number of Employees: ");
                        CompanyEmployeesNumb = int.Parse(Console.ReadLine());
                        TaxPayer.Add(new Company(NameTaxPayer, IncomeTaxPayer, CompanyEmployeesNumb));
                        break;
                }
            }

            Console.WriteLine("\nTAXES PAID:");
            foreach(TaxPayer taxp in TaxPayer)
            {
                SumTaxP += taxp.tax();
                Console.WriteLine(taxp);
            }
            Console.WriteLine($"\nTOTAL TAXES: $ {SumTaxP:F2}");
        }
    }
}
