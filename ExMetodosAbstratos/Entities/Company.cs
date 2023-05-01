using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExMetodosAbstratos.Entities
{
    class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company()
        {

        }

        public Company(string name, double anualincome, int numberOfEmployees)
            : base(name, anualincome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double tax()
        {
            if (NumberOfEmployees > 10)
            {
                return anualIncome * 0.14;
            }
            else
            {
                return anualIncome * 0.16;
            }
        }
    }
}
