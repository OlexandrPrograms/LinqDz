namespace LinqDz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Firm> firms = new List<Firm>
            {
                new Firm(
                    "TechCorp",
                    new DateOnly(2018, 5, 20),
                    Profile.IT,
                    "Lionel Messi",
                    new Employee[]
                    {
                        new Employee("Lionel Messi", Position.CEO, "234-567-890", "direct.messi@techcorp.com", 15000),
                        new Employee("Diana Prince", Position.Manager, "239-111-222", "diana.p@techcorp.com", 4500),
                        new Employee("Alex Turner", Position.Worker, "098-333-444", "alex.t@techcorp.com", 2200)
                    },
                    "Kyiv, Ukraine"
                ),

                new Firm(
                    "Global Food",
                    new DateOnly(2020, 3, 15),
                    Profile.Food,
                    "John White",
                    new Employee[]
                    {
                        new Employee("Dmitry Ivanov", Position.Manager, "231-999-888", "dimon@food.com", 3800),
                        new Employee("Sarah Connor", Position.Worker, "050-444-555", "sarah.c@food.com", 1800)
                    },
                    "London, UK"
                ),

                new Firm(
                    "Marketing Pro",
                    new DateOnly(2019, 9, 30),
                    Profile.Marketing,
                    "Sarah White",
                    new Employee[]
                    {
                        new Employee("Diego Maradona", Position.Manager, "067-123-456", "diego@mpro.com", 5000),
                        new Employee("Lionel Richie", Position.Employer, "230-000-111", "lionel.r@mpro.com", 6200)
                    },
                    "Manchester, UK"
                ),

                new Firm(
                    "FinFinance",
                    new DateOnly(2015, 4, 18),
                    Profile.Finance,
                    "James Green",
                    new Employee[]
                    {
                        new Employee("Diana Ross", Position.Worker, "235-777-666", "diana.ross@fin.com", 2900),
                        new Employee("Bruce Wayne", Position.Manager, "093-888-999", "bruce.w@fin.com", 7000)
                    },
                    "London, UK"
                ),

                new Firm(
                    "EduSmart",
                    new DateOnly(2023, 2, 1),
                    Profile.Education,
                    "Elena Taylor",
                    new Employee[]
                    {
                        new Employee("Lionel Scaloni", Position.Worker, "063-222-333", "direct.scaloni@edusmart.com", 2100),
                        new Employee("Dirk Nowitzki", Position.Worker, "238-444-111", "dirk@edusmart.com", 3100)
                    },
                    "Odesa, Ukraine"
                )
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




            //// ======== TASK 3 ========
            //Console.Write("Введіть назву фірми: ");
            //string name = Console.ReadLine() ?? "";
            //var e1 = firms.FirstOrDefault(f => f.Name == name)?.Employees;
            //Print(e1);

            //Console.Write("Введіть назву фірми: ");
            //string name2 = Console.ReadLine() ?? "";
            //Console.Write("Введіть мінімальну зарплату: ");
            //int minSalary = int.TryParse(Console.ReadLine() ?? "0", out int salary) ? salary : 0;
            //var e2 = firms.FirstOrDefault(f => f.Name == name2)?.Employees.Where(e => e.Salary > minSalary);
            //Print(e2);

            //var e3 = firms.SelectMany(f => f.Employees).Where(e => e.Position == Position.Manager);
            //Print(e3);

            //var e4 = firms.SelectMany(f => f.Employees).Where(e => e.Phone.StartsWith("23"));
            //Print(e4);

            //var e5 = firms.SelectMany(f => f.Employees).Where(e => e.Email.StartsWith("di"));
            //Print(e5);

            //var e6 = firms.SelectMany(f => f.Employees).Where(e => e.Pib.StartsWith("Lionel"));
            //Print(e6);




            //// ======== TASK 4 ========
            //Console.WriteLine("Введіть масив цілих чисел через кому:");
            //List<int> nums = Console.ReadLine().Split(",").Select(x => int.Parse(x.Trim())).ToList();

            //Console.Write(
            //    "Сортувати за\n" +
            //    "1. Зростанням\n" +
            //    "2. Спаданням\n" +
            //    "> ");
            //string choice = Console.ReadLine() ?? "1";

            //IEnumerable<int> res;
            //if (choice == "2")
            //    res = nums.OrderByDescending(n => Math.Abs(n).ToString().Sum(c => c - '0'));
            //else
            //    res = nums.OrderBy(n => Math.Abs(n).ToString().Sum(c => c - '0'));

            //foreach (int num in res)
            //    Console.Write(num + ", ");
        }

        static void Print(IEnumerable<Employee>? firms)
        {
            if (firms == null)
            {
                Console.WriteLine("Не знайдено!");
                return;
            }
            foreach (var firm in firms)
                Console.WriteLine(firm);
            Console.WriteLine("=========================================");
        }
    }
}
