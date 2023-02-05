namespace OOP1
{
    internal class Product
    {
        protected string Name;
        protected uint Price;
        protected Currency Cost;
        protected uint Quantity;
        protected string Producer;
        protected uint Weight;

        public Product(string name, uint price, Currency cost, uint quantity, string producer, uint weight)
        {
            Name = name;
            Price = price;
            Cost = new Currency(cost);
            Quantity = quantity;
            Producer = producer;
            Weight = weight;
        }

        public Product(Product product)
        {
            Name = product.Name;
            Price = product.Price;
            Cost = new Currency(product.Cost);
            Quantity = product.Quantity;
            Producer = product.Producer;
            Weight = product.Weight;
        }
        public void PrintInfo()
        {
            Console.WriteLine("Name:  {0}", Name);
            Console.WriteLine("Price: {0}", Price);
            Console.WriteLine("Cost:  {0}", Cost.GetFullCost());
            Console.WriteLine("Producer: {0}", Producer);
            Console.WriteLine("Weight: {0}", Weight);
        }

        public void SetName(string name) { Name = name; }
        public void SetPrice(uint price) { Price = price; }
        public void SetCost(Currency cost) { Cost = new Currency(cost); }
        public void SetQuantity(uint quantity) { Quantity = quantity; }
        public void SetProducer(string producer) { Producer = producer; }
        public void SetWeight(uint weight) { Weight = weight; }

        public string GetName() { return Name; }
        public uint GetPrice() { return Price; }
        public string GetCost() { return Cost.GetFullCost(); }
        public uint GetQuantity() { return Quantity; }
        public string GetProducer() { return Producer; }
        public uint GetWeight() { return Weight; }

        public string GetPriceInUAH(Product product) { return product.GetCost(); }

        public uint GetTotalPriceInUAH(Product product) { return product.GetPrice() * product.GetQuantity(); }

        public uint GetTotalWeight(Product product) {return product.GetWeight() * product.GetQuantity(); }
    }
}
