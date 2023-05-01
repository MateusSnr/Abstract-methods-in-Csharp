using System;
using ExMetodosAbstratos.Entities;

namespace ExMetodosAbstratos.Entities
{
    class Individual:TaxPayer
    {
        public double healthExpenditures { get; set; }

        public Individual() 
        {

        }

        public Individual(string name, double anualincome,double healthexpenditures)
            :base(name, anualincome)
        {
            healthExpenditures = healthexpenditures;
        }

        public override double tax()
        {
            if (anualIncome < 20000.00)
            {
                return anualIncome * 0.15 - healthExpenditures * 0.50;
            }
            else
            {
                return anualIncome * 0.25 - healthExpenditures * 0.50;
            }
            
        }
    }
}
