using System;
using System.Collections.Generic;
using System.Text;

namespace Abstrato.Entities
{
    abstract class TaxPayer
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        public TaxPayer()
        {
        }

        public TaxPayer(string name, double anualincome)
        {
            Name = name;
            AnualIncome = anualincome;
        }

        public override string ToString()
        {
            return $"{Name}: $ {tax():F2}";
        }

        public abstract double tax();
    }
}
