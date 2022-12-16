using System.Diagnostics;

namespace Lab11Main
{
    public class Program
    {
        public static Random rand = new Random();

        public static int Main()
        {
            var testCollections = new TestCollections(5);
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            testCollections.Collection1.Contains(new Transport("0", 0));
            Console.WriteLine("Первый элемент в коллекции 1: " + stopwatch.ElapsedTicks);
            stopwatch.Restart();
            testCollections.Collection1.Contains(new Transport("2", 2));
            Console.WriteLine("Средний элемент в коллекции 1: " + stopwatch.ElapsedTicks);
            stopwatch.Restart();
            testCollections.Collection1.Contains(new Transport("4", 4));
            Console.WriteLine("Последний элемент в коллекции 1: " + stopwatch.ElapsedTicks);
            stopwatch.Restart();
            testCollections.Collection1.Contains(new Transport("5", 5));            
            Console.WriteLine("Отсутствующий элемент в коллекции 1: " + stopwatch.ElapsedTicks + "\n");
            stopwatch.Restart();

            testCollections.Collection2.Contains((new Transport("0", 0).ToString()));
            Console.WriteLine("Первый элемент в коллекции 2: " + stopwatch.ElapsedTicks);
            stopwatch.Restart();
            testCollections.Collection2.Contains((new Transport("2", 2).ToString()));
            Console.WriteLine("Средний элемент в коллекции 2: " + stopwatch.ElapsedTicks);
            stopwatch.Restart();
            testCollections.Collection2.Contains((new Transport("4", 4).ToString()));
            Console.WriteLine("Последний элемент в коллекции 2: " + stopwatch.ElapsedTicks);
            stopwatch.Restart();
            testCollections.Collection2.Contains((new Transport("5", 5).ToString()));            
            Console.WriteLine("Отсутствующий элемент в коллекции 2: " + stopwatch.ElapsedTicks + "\n");
            stopwatch.Restart();

            testCollections.Collection3.ContainsKey(new Transport("0", 0));
            Console.WriteLine("Первый элемент по ключу в коллекции 3: " + stopwatch.ElapsedTicks);
            stopwatch.Restart();
            testCollections.Collection3.ContainsKey(new Transport("2", 2));
            Console.WriteLine("Средний элемент по ключу в коллекции 3: " + stopwatch.ElapsedTicks);
            stopwatch.Restart();
            testCollections.Collection3.ContainsKey(new Transport("4", 4));
            Console.WriteLine("Последний элемент по ключу в коллекции 3: " + stopwatch.ElapsedTicks);
            stopwatch.Restart();
            testCollections.Collection3.ContainsKey(new Transport("5", 5));
            Console.WriteLine("Отсутвующий элемент по ключу в коллекции 3: " + stopwatch.ElapsedTicks + "\n");
            stopwatch.Restart();

            testCollections.Collection4.ContainsKey((new Train("0", 0, 0)).ToString());
            Console.WriteLine("Первый элемент по ключу в коллекции 4: " + stopwatch.ElapsedTicks);
            stopwatch.Restart();
            testCollections.Collection4.ContainsKey((new Train("2", 2, 2)).ToString());
            Console.WriteLine("Средний элемент по ключу в коллекции 4: " + stopwatch.ElapsedTicks);
            stopwatch.Restart();
            testCollections.Collection4.ContainsKey((new Train("4", 4, 4)).ToString());
            Console.WriteLine("Последний элемент по ключу в коллекции 4: " + stopwatch.ElapsedTicks);
            stopwatch.Restart();
            testCollections.Collection4.ContainsKey((new Train("5", 5, 5)).ToString());
            Console.WriteLine("Отсутвующий элемент по ключу в коллекции 4: " + stopwatch.ElapsedTicks + "\n");
            stopwatch.Restart();

            testCollections.Collection3.ContainsValue(new Train("0", 0, 0));
            Console.WriteLine("Первый элемент по значению в коллекции 3: " + stopwatch.ElapsedTicks);
            stopwatch.Restart();
            testCollections.Collection3.ContainsValue(new Train("2", 2, 2));
            Console.WriteLine("Средний элемент по значению в коллекции 3: " + stopwatch.ElapsedTicks);
            stopwatch.Restart();
            testCollections.Collection3.ContainsValue(new Train("4", 4, 4));
            Console.WriteLine("Последний элемент по значению в коллекции 3: " + stopwatch.ElapsedTicks);
            stopwatch.Restart();
            testCollections.Collection3.ContainsValue(new Train("5", 5, 5));
            Console.WriteLine("Отсутвующий элемент по значению в коллекции 3: " + stopwatch.ElapsedTicks + "\n");
            stopwatch.Restart();

            testCollections.Collection4.ContainsValue(new Train("0", 0, 0));
            Console.WriteLine("Первый элемент по значению в коллекции 4: " + stopwatch.ElapsedTicks);
            stopwatch.Restart();
            testCollections.Collection4.ContainsValue(new Train("2", 2, 2));
            Console.WriteLine("Средний элемент по значению в коллекции 4: " + stopwatch.ElapsedTicks);
            stopwatch.Restart();
            testCollections.Collection4.ContainsValue(new Train("4", 4, 4));
            Console.WriteLine("Последний элемент по значению в коллекции 4: " + stopwatch.ElapsedTicks);
            stopwatch.Restart();
            testCollections.Collection4.ContainsValue(new Train("5", 5, 5));
            Console.WriteLine("Отсутвующий элемент по значению в коллекции 4: " + stopwatch.ElapsedTicks + "\n");

            stopwatch.Stop();

            return 0;
        }
    }
}