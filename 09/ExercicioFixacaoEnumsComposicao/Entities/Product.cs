namespace ExercicioFixacaoEnumsComposicao.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; } //Duplicate to have the price history of the products

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

    }
}
