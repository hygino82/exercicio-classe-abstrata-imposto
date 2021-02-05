using System;
using System.Collections.Generic;
using System.Text;

namespace ClasseAbstrataImposto.Entities
{
    class Individual:TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double anualIncome, double healthExpenditures)
            :base(name,anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            double totalTax;
            if (AnualIncome < 20000.0)
            {
                totalTax = AnualIncome * 0.15;
            }
            else
            {
                totalTax = AnualIncome * 0.25;
            }
            totalTax -= HealthExpenditures * 0.5;
            return totalTax;
        }
    }
}
