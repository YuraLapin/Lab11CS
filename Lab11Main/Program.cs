namespace Lab11Main
{
    public class Program
    {
        public static Random rand = new Random();

        public static int Main()
        {
            var testCollections = new TestCollections(5);            

            Console.WriteLine(testCollections.Collection1.Contains(new Transport("0", 0)));
            Console.WriteLine(testCollections.Collection1.Contains(new Transport("2", 2)));
            Console.WriteLine(testCollections.Collection1.Contains(new Transport("4", 4)));
            Console.WriteLine(testCollections.Collection1.Contains(new Transport("5", 5)));
            Console.WriteLine();

            Console.WriteLine(testCollections.Collection2.Contains((new Transport("0", 0).ToString())));
            Console.WriteLine(testCollections.Collection2.Contains((new Transport("2", 2).ToString())));
            Console.WriteLine(testCollections.Collection2.Contains((new Transport("4", 4).ToString())));
            Console.WriteLine(testCollections.Collection2.Contains((new Transport("5", 5).ToString())));
            Console.WriteLine();

            Console.WriteLine(testCollections.Collection3.ContainsKey(new Transport("0", 0)));
            Console.WriteLine(testCollections.Collection3.ContainsKey(new Transport("2", 2)));
            Console.WriteLine(testCollections.Collection3.ContainsKey(new Transport("4", 4)));
            Console.WriteLine(testCollections.Collection3.ContainsKey(new Transport("5", 5)));
            Console.WriteLine();

            Console.WriteLine(testCollections.Collection4.ContainsKey((new Train("0", 0, 0)).ToString()));
            Console.WriteLine(testCollections.Collection4.ContainsKey((new Train("2", 2, 2)).ToString()));
            Console.WriteLine(testCollections.Collection4.ContainsKey((new Train("4", 4, 4)).ToString()));
            Console.WriteLine(testCollections.Collection4.ContainsKey((new Train("5", 5, 5)).ToString()));

            Console.WriteLine();

            Console.WriteLine(testCollections.Collection3.ContainsValue(new Train("0", 0, 0)));
            Console.WriteLine(testCollections.Collection3.ContainsValue(new Train("2", 2, 2)));
            Console.WriteLine(testCollections.Collection3.ContainsValue(new Train("4", 4, 4)));
            Console.WriteLine(testCollections.Collection3.ContainsValue(new Train("5", 5, 5)));
            Console.WriteLine();

            Console.WriteLine(testCollections.Collection4.ContainsValue(new Train("0", 0, 0)));
            Console.WriteLine(testCollections.Collection4.ContainsValue(new Train("2", 2, 2)));
            Console.WriteLine(testCollections.Collection4.ContainsValue(new Train("4", 4, 4)));
            Console.WriteLine(testCollections.Collection4.ContainsValue(new Train("5", 5, 5)));

            return 0;
        }
    }
}