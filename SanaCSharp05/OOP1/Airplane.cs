namespace OOP1
{
    class Airplane
    {
        private string StartCity;
        private string FinishCity;
        protected Date StartDate;
        protected Date FinishDate;
        public Airplane(string startCity, string finishCity, Date startDate, Date finishDate)
        {
            StartCity = startCity;
            FinishCity = finishCity;
            StartDate = new Date(startDate);
            FinishDate = new Date(finishDate);
        }
        public void PrintInfo()
        {
            Console.WriteLine("StartCity:  {0}", StartCity);
            Console.WriteLine("FinishCity: {0}", FinishCity);
            Console.WriteLine("StartDate:  {0}", StartDate.GetFullDate());
            Console.WriteLine("FinishDate: {0}", FinishDate.GetFullDate());
        }
        public Airplane(Airplane airplane)
        {
            StartCity = airplane.StartCity;
            FinishCity = airplane.FinishCity;
            StartDate =  new Date(airplane.StartDate);
            FinishDate = new Date(airplane.FinishDate);
        }

        public string GetStartCity() { return StartCity; }
        public string GetFinishCity() { return FinishCity; }    
        public string GetStartDate() { return StartDate.GetFullDate(); }
        public string GetFinishDate() { return FinishDate.GetFullDate(); }

        public void SetStartCity(string startCity) { StartCity = startCity; }
        public void SetFinishCity(string finishCity) { FinishCity = finishCity; }
        public void SetStartDate(Date startDate) { StartDate = new Date(startDate); }
        public void SetFinishDate(Date finishDate) { FinishDate = new Date(finishDate); }

        //public int GetTotalTime(Date startDate, Date finishDate) {  }

        public bool IsArrivingToday(string startDay, string finishDay) 
        {
            if(startDay == finishDay)
                return true;
            return false; 
        }
    }
}
