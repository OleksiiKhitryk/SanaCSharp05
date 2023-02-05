namespace OOP1
{
    internal class Currency
    {
        protected string Name;
        protected double ExRate;

        public Currency(string name, double exRate)
        {
            Name = name;
            ExRate = exRate;
        }

        public Currency(Currency currency) 
        {
            Name = currency.Name;
            ExRate = currency.ExRate;
        }

        public string GetFullCost()
        {
            return $"{ExRate}{" "}{Name}";
        }

        public void SetName(string name) { Name = name; }
        public void SetExRate(double exRate) { ExRate = exRate; }
        public string GetName() { return Name; }
        public double GetExRate() { return ExRate; }
    }
}
