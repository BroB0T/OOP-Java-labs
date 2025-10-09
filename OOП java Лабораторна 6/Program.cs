namespace OOП_java_Лабораторна_6
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            IDictionary<string,string> trains = new Dictionary<string, string>()
            {
                {"Kyiv — Lviv", "06:30"},
                {"Kyiv — Odesa", "07:15"},
                {"Kyiv — Kharkiv", "08:00"},
                {"Lviv — Ivano-Frankivsk", "09:45"},
                {"Odesa — Dnipro", "10:00"},
                {"Kharkiv — Poltava", "10:30"},
                {"Dnipro — Zaporizhzhia", "11:15"},
                {"Kyiv — Chernihiv", "12:00"},
                {"Lviv — Ternopil", "13:20"},
                {"Odesa — Mykolaiv", "14:00"}
            };

            while (true)
            {
                Console.WriteLine("\nEnter the desired item" +
                    "1 - Show all routes" +
                    "2 - Add a route" +
                    "3 - Search for a route" +
                    "4 - Remove a route" +
                    "0 - Exit");

                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        ShowAll(trains);
                        break;

                    case "2":
                        Add(trains);
                        break;

                    case "3":
                        Search(trains);
                        break;

                    case "4":
                        Remove(trains);
                        break;

                    case "0":
                        Console.WriteLine("goodbye");
                        return;

                    default:
                        Console.WriteLine("invalid input, try again");
                        break;
                }
            }
        }
        #region Show
        static void ShowAll(IDictionary<string, string> trains)
        {
            if (trains.Count == 0)
            {
                Console.WriteLine("the train schedule is empty");
                return;
            }

            Console.WriteLine("list of train record: ");
            foreach (var record in trains)
            {
                Console.WriteLine(record.Key + "— departure at " + record.Value);
            }
        }
        #endregion


        #region Add
        static void Add(IDictionary<string, string> trains)
        {
            Console.Write("Enter route: ");
            string route = Console.ReadLine();

            if (trains.ContainsKey(route))
            {
                Console.WriteLine("this record already exists!");
                return;
            }

            Console.Write("enter departure time");
            string time = Console.ReadLine();

            trains.Add(route, time);
            Console.WriteLine("record added successfully");
        }
        #endregion


        #region search
        static void Search(IDictionary<string, string> trains)
        {
            Console.Write("Enter the record to search for: ");
            string record = Console.ReadLine();

            if (trains.TryGetValue(record, out string time))
            {
                Console.WriteLine(record + "— departure at" + time);
            }
            else
            {
                Console.WriteLine("record not found");
            }
        }
        #endregion


        #region remove
        static void Remove(IDictionary<string, string> trains)
        {
            Console.Write("Enter the record to remove: ");
            string record = Console.ReadLine();

            if (trains.Remove(record))
            {
                Console.WriteLine("record removed successfully");
            }
            else
            {
                Console.WriteLine("record not found");
            }
        }
        #endregion
    }
}
