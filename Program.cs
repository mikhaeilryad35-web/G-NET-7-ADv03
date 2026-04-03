namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercise 1:
            //List<int> grades = new List<int> { 85, 92, 78, 95, 88, 70, 100, 65 };
            //Console.WriteLine("Grades: " + string.Join(", ", grades));
            //Console.WriteLine("Count: " + grades.Count);
            //Console.WriteLine("first: " + grades.Max());
            //Console.WriteLine("last: " + grades.Min());
            //grades.Sort();
            //Console.WriteLine("sort: " + string.Join(", ", grades));
            //foreach (var item in grades)
            //{
            //   if(item>90)
            //        Console.WriteLine("first grades : " + string.Join(", ", item));
            //}
            //foreach (var item in grades)
            //{
            //    if (item < 75) {
            //        Console.WriteLine("failing grades : " + string.Join(", ", item));
            //    }

            //}
            //foreach (var item in grades)
            //{
            //    if (item < 75)
            //    {
            //        Console.WriteLine("After Remove:" + string.Join(", ",  grades.RemoveAll));
            //    }

            //}
            //Console.WriteLine("Contains 100: " + grades.Contains(100));
            #endregion

            #region Exercise 2:
            //       SortedDictionary<int, string> leaderboard = new SortedDictionary<int, string>()
            //    {
            //        {500, "Ahmed"},
            //        {200, "Sara"},
            //        {800, "Ali"},
            //        {350, "Mona"}
            //    };


            //foreach (var item in leaderboard)
            //    Console.WriteLine($"{item.Key} = {item.Value}");

            //Console.WriteLine("First Key: " + leaderboard.First().Key);
            //Console.WriteLine("First Value: " + leaderboard.First().Value);


            //Console.WriteLine("Contains 500: " + leaderboard.ContainsKey(500));


            //if (leaderboard.TryGetValue(999, out string player))
            //    Console.WriteLine(player);
            //else
            //    Console.WriteLine("Score 999 not found");


            //leaderboard.Remove(200);

            //Console.WriteLine("After remove:");
            //foreach (var item in leaderboard)
            //    Console.WriteLine($"{item.Key} = {item.Value}");
            #endregion

            #region Exercise 3:
            //  Dictionary<string, string> phoneBook = new Dictionary<string, string>()
            //{
            //    {"Ahmed", "010"},
            //    {"Sara", "011"},
            //    {"Ali", "012"},
            //    {"Mona", "015"}
            //};

             
            //phoneBook["John"] = "016";

             
            //try
            //{
            //    phoneBook.Add("Ahmed", "999");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Error: " + ex.Message);
            //}

             
            //bool added = phoneBook.TryAdd("Ahmed", "999");
            //Console.WriteLine("TryAdd success: " + added);

            
            //if (!phoneBook.ContainsKey("Khaled"))
            //    Console.WriteLine("Not found");

             
            //string value = phoneBook.GetValueOrDefault("Khaled", "Not Found");
            //Console.WriteLine(value);

           
            //Console.WriteLine(string.Join(", ", phoneBook.Keys));

            
            //Console.WriteLine(string.Join(", ", phoneBook.Values));
            #endregion
        }
    }
}
