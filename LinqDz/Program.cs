namespace LinqDz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Firm> firms = new List<Firm>
            {
                new Firm("Global Food Marketing", new DateOnly(2020, 3, 15), Profile.Marketing, "John White", 250, "London, UK"),
                new Firm("Fast Food Express", new DateOnly(2022, 11, 10), Profile.Food, "Alice Smith", 150, "London, UK"),
                new Firm("Tech Solutions", new DateOnly(2018, 5, 20), Profile.IT, "Robert Johnson", 450, "Kyiv, Ukraine"),
                new Firm("White Star Logistics", new DateOnly(2021, 8, 12), Profile.Finance, "David Black", 80, "London, UK"),
                new Firm("Fresh Food Lab", new DateOnly(2026, 6, 7), Profile.Food, "Emma Watson", 45, "Lviv, Ukraine"),
                new Firm("Cyber Shield", new DateOnly(2025, 1, 15), Profile.IT, "Michael Brown", 90, "Kyiv, Ukraine"),
                new Firm("Creative Agency", new DateOnly(2019, 9, 30), Profile.Marketing, "Sarah White", 60, "Manchester, UK"),
                new Firm("Capital Finance", new DateOnly(2015, 4, 18), Profile.Finance, "James Green", 600, "London, UK"),
                new Firm("EduSmart Academy", new DateOnly(2023, 2, 1), Profile.Education, "Elena Taylor", 120, "Odesa, Ukraine"),
                new Firm("Soft Food Digital", new DateOnly(2025, 11, 5), Profile.IT, "Oleh Black", 30, "Kharkiv, Ukraine")
            };



            //// ======== TASK 1 ========
            //var res1 = from f in firms
            //           select f;
            //Print(res1);

            //var res2 = from f in firms
            //           where f.Name.Contains("Food", StringComparison.OrdinalIgnoreCase)
            //           select f;
            //Print(res2);

            //var res3 = from f in firms
            //           where f.Profile == Profile.Marketing
            //           select f;
            //Print(res3);

            //var res4 = from f in firms
            //           where f.Profile == Profile.Marketing
            //              || f.Profile == Profile.IT
            //           select f;
            //Print(res4);

            //var res5 = from f in firms
            //           where f.EmployeesCount > 100
            //           select f;
            //Print(res5);

            //var res6 = from f in firms
            //           where f.EmployeesCount >= 100
            //              && f.EmployeesCount <= 300
            //           select f;
            //Print(res6);

            //var res7 = from f in firms
            //           where f.Address.Contains("London", StringComparison.OrdinalIgnoreCase)
            //           select f;
            //Print(res7);

            //var res8 = from f in firms
            //           where f.CEO.Contains("White", StringComparison.OrdinalIgnoreCase)
            //           select f;
            //Print(res8);

            //DateTime today = DateTime.Today;
            //DateOnly todayDateOnly = DateOnly.FromDateTime(today);
            //var res9 = from f in firms
            //           where f.Date < todayDateOnly.AddYears(-2)
            //           select f;
            //Print(res9);

            //var res10 = from f in firms
            //            where todayDateOnly.DayNumber - f.Date.DayNumber == 123
            //            select f;
            //Print(res10);

            //var res11 = from f in firms
            //            where f.CEO.Contains("Black", StringComparison.OrdinalIgnoreCase)
            //               && f.Name.Contains("White", StringComparison.OrdinalIgnoreCase)
            //            select f;
            //Print(res11);



            //// ======== TASK 2 ========
            //var firms1 = firms.Select(f => f);
            //Print(firms1);

            //var firms2 = firms.Where(f => f.Name.Contains("Food", StringComparison.OrdinalIgnoreCase));
            //Print(firms2);

            //var firms3 = firms.Where(f => f.Profile == Profile.Marketing);
            //Print(firms3);

            //var firms4 = firms.Where(f => f.Profile == Profile.Marketing || f.Profile == Profile.IT);
            //Print(firms4);

            //var firms5 = firms.Where(f => f.EmployeesCount > 100);
            //Print(firms5);

            //var firms6 = firms.Where(f => f.EmployeesCount >= 100 && f.EmployeesCount <= 300);
            //Print(firms6);

            //var firms7 = firms.Where(f => f.Address.Contains("London", StringComparison.OrdinalIgnoreCase));
            //Print(firms7);

            //var firms8 = firms.Where(f => f.CEO.Contains("White", StringComparison.OrdinalIgnoreCase));
            //Print(firms8);

            //DateTime today = DateTime.Today;
            //DateOnly todayDateOnly = DateOnly.FromDateTime(today);
            //var firms9 = firms.Where(f => f.Date < todayDateOnly.AddYears(-2));
            //Print(firms9);

            //var firms10 = firms.Where(f => todayDateOnly.DayNumber - f.Date.DayNumber == 123);
            //Print(firms10);

            //var firms11 = firms.Where(f => f.CEO.Contains("Black", StringComparison.OrdinalIgnoreCase) && f.Name.Contains("White", StringComparison.OrdinalIgnoreCase));
            //Print(firms11);
        }

        static void Print(IEnumerable<Firm> firms)
        {
            foreach (var firm in firms)
                Console.WriteLine(firm);
            Console.WriteLine("=========================================");
        }
    }
}
