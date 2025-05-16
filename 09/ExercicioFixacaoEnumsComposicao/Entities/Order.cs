using ExercicioFixacaoEnumsComposicao.Entities.Enums;
using System.Text;

namespace ExercicioFixacaoEnumsComposicao.Entities
{
    class Order
    {
        public DateTime Date { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; private set; } = new List<OrderItem>();
        public Client Client { get; set; }

        public Order() { }

        public Order(DateTime date, OrderStatus status, Client client)
        {
            Date = date;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double sum = 0;
            foreach (OrderItem item in Items)
            {
                sum += item.SubTotal();
            }

            return sum;
        }

        public override string ToString()
        {
            StringBuilder SB = new();
            SB.AppendLine("Order moment: " + Date);
            SB.AppendLine("Order status: " + Status);
            SB.AppendLine("Client: " + Client);
            SB.AppendLine("Order items:");
            SB.AppendLine("Order items:");
            foreach (OrderItem item in Items)
            {
                SB.AppendLine(item.ToString());
            }
            SB.Append("Total price: $" + Total().ToString("F2"));
            return SB.ToString();
        }

    }
}
