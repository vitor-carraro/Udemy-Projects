using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioArquivos.Entities
{
    internal class Requests
    {
        public string Name { get; set; }
        public int Amount { get; set; }
        public double Price { get; set; }

        public Requests(string name, double price, int amount)
        {
            Name = name;
            Amount = amount;
            Price = price;
        }

        public double SubTotal()
        {
            return Price * Amount;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1:F2}", Name, SubTotal().ToString(CultureInfo.InvariantCulture));
        }

    }
}
