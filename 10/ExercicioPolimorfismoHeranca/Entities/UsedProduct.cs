namespace ExercicioPolimorfismoHeranca.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct(string name, double price, DateTime manufactureDate)
            : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return string.Format("{0} (used) $ {1:F2} (Manufacture date: {2})", Name, Price, ManufactureDate.ToShortDateString());
        }
    }
}
