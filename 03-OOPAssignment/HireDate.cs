namespace _03_OOPAssignment
{
     class HireDate
     {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public HireDate(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }
        public DateTime DateTime()
        {
            return new DateTime(Year, Month, Day);
        }
        public override string ToString()
        {
            return $"{Day}//{Month}//{Year}";
        }
    }

}

