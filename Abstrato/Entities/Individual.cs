using System;
using System.Collections.Generic;
using System.Text;

namespace Abstrato.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual()
        {
        }

        public Individual(string name, double anualincome, double healthexpenditures) : base(name, anualincome)
        {
            HealthExpenditures = healthexpenditures;
        }

        public override double tax()
        {
            if(AnualIncome < 20000)
            {
                return (AnualIncome * 0.15) - (HealthExpenditures * 0.5);
            }
            else
            {
                return (AnualIncome * 0.25) - (HealthExpenditures * 0.5);
            }
        }
    }
}
