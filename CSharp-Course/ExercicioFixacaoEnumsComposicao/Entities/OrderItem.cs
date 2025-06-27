namespace ExercicioFixacaoEnumsComposicao.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double SubTotal()
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            return string.Format("{0}, ${1}, Quantity: {2}, Subtotal: ${3:F2}", Product.Name, Price, Quantity, SubTotal());
        }
    }
}
