namespace OOP1
{
    public class Date
    {
        protected string Year;
        protected string Month;
        protected string Day;
        protected string Hours;
        protected string Minutes;

        public Date(string year, string month, string day, string hours, string minutes)
        {
            Year = year;
            Month = month;
            Day = day;
            Hours = hours;
            Minutes = minutes;
        }

        public string GetYear() { return Year; }
        public string GetMonth() { return Month; }
        public string GetDay() { return Day; }
        public string GetHours() { return Hours; }
        public string GetMinutes() { return Minutes; }

        public void SetYear(string year) { Year = year; }
        public void SetMonth(string month) { Month = month; }
        public void SetDay(string day) { Day = day; }
        public void SetHours(string hours) { Hours = hours; }
        public void SetMinutes(string minutes) { Minutes = minutes; }

        public string GetFullDate()
        {
            return $"{Year}{"."}{Month}, {Day}, {Hours}{":"}{Minutes}";
        }

        public Date(Date date)                
        {
            Year = date.Year;
            Month = date.Month;
            Day = date.Day;
            Hours = date.Hours;
            Minutes = date.Minutes;
        }
    }
}
