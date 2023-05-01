
namespace ExMetodosAbstratos.Entities
{
    abstract class TaxPayer
    {
        public string Name { get; set; }
        public double anualIncome { get; set; }

        public TaxPayer() { }

        public TaxPayer(string name, double anualincome)
        {
            Name = name;
            anualIncome = anualincome;
        }

        public abstract double tax();
    }
}
