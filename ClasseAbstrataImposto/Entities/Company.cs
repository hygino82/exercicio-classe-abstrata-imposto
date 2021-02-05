using System;
using System.Collections.Generic;
using System.Text;

namespace ClasseAbstrataImposto.Entities
{
    class Company:TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company(string name, double anualIncome, int numberOfEmployees)
            :base(name,anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            double totalTax;
            if (NumberOfEmployees < 10)
            {
                totalTax = AnualIncome * 0.16;
            }
            else
            {
                totalTax = AnualIncome * 0.14;
            }
            return totalTax;
        }
    }
}
