namespace ExercicioAbstract.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double anualIncome, double healthExpenditures)
            : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            double TotalTax = AnualIncome < 20000.0 ? (AnualIncome * 0.15) : (AnualIncome * 0.25);
            if (HealthExpenditures > 0)
            {
                TotalTax -= HealthExpenditures * 0.5;
            }
            return TotalTax;
        }
    }
}
