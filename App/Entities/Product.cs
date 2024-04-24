using System.Globalization;
using System.Text;

namespace App.Entities
{
    internal class Product
    {
        public string Name { get; private set; } = string.Empty;
        public double Price { get; protected set; }

        public Product() { }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag()
        {
            return Name
                 + " $ "
                 + Price.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
