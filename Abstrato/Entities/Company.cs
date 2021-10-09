using System;
using System.Collections.Generic;
using System.Text;

namespace Abstrato.Entities
{
    class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company()
        {
        }

        public Company(string name, double anualincome, int numberofemployees) : base(name, anualincome)
        {
            NumberOfEmployees = numberofemployees;
        }

        public override double tax()
        {
            if(NumberOfEmployees > 10)
            {
                return AnualIncome * 0.14;
            }
            else
            {
                return AnualIncome * 0.16;
            }
        }
    }
}
