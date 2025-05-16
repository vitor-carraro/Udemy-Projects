namespace ExercicioAbstract.Entities
{
    class Company : TaxPayer
    {
        public int NumberOfEmployes { get; set; }

        public Company(string name, double anualIncome, int numberOfEmployes)
            : base(name, anualIncome)
        {
            NumberOfEmployes = numberOfEmployes;
        }

        public override double Tax()
        {
            if (NumberOfEmployes < 11)
                return AnualIncome * 0.16;
            else
                return AnualIncome * 0.14;
        }

    }
}
