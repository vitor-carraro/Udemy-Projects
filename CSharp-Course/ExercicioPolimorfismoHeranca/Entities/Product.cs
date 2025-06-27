namespace ExercicioPolimorfismoHeranca.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag()
        {

            return string.Format("{0} $ {1:F2}", Name, Price);
        }
    }
}
