using System.Diagnostics;

namespace Lab11Main
{
    public class Program
    {
        public static Random rand = new Random();

        public static int Main()
        {
            int size = 1000;
            var testCollections = new TestCollections(size);
            var stopwatch = new Stopwatch();

            int first = 0;
            int last = size - 1;
            int middle = size / 2;
            int nonEx = size;

            stopwatch.Start();
            testCollections.Collection1.Contains(new Transport(first.ToString(), first));
            Console.WriteLine("Первый элемент в коллекции 1: " + stopwatch.ElapsedTicks);
            stopwatch.Restart();
            testCollections.Collection1.Contains(new Transport(middle.ToString(), middle));
            Console.WriteLine("Средний элемент в коллекции 1: " + stopwatch.ElapsedTicks);
            stopwatch.Restart();
            testCollections.Collection1.Contains(new Transport(last.ToString(), last));
            Console.WriteLine("Последний элемент в коллекции 1: " + stopwatch.ElapsedTicks);
            stopwatch.Restart();
            testCollections.Collection1.Contains(new Transport(nonEx.ToString(), nonEx));            
            Console.WriteLine("Отсутствующий элемент в коллекции 1: " + stopwatch.ElapsedTicks + "\n");
            stopwatch.Restart();

            testCollections.Collection2.Contains((new Transport(first.ToString(), first).ToString()));
            Console.WriteLine("Первый элемент в коллекции 2: " + stopwatch.ElapsedTicks);
            stopwatch.Restart();
            testCollections.Collection2.Contains((new Transport(middle.ToString(), middle).ToString()));
            Console.WriteLine("Средний элемент в коллекции 2: " + stopwatch.ElapsedTicks);
            stopwatch.Restart();
            testCollections.Collection2.Contains((new Transport(last.ToString(), last).ToString()));
            Console.WriteLine("Последний элемент в коллекции 2: " + stopwatch.ElapsedTicks);
            stopwatch.Restart();
            testCollections.Collection2.Contains((new Transport(nonEx.ToString(), nonEx).ToString()));            
            Console.WriteLine("Отсутствующий элемент в коллекции 2: " + stopwatch.ElapsedTicks + "\n");
            stopwatch.Restart();

            testCollections.Collection3.ContainsKey(new Transport(first.ToString(), first));
            Console.WriteLine("Первый элемент по ключу в коллекции 3: " + stopwatch.ElapsedTicks);
            stopwatch.Restart();
            testCollections.Collection3.ContainsKey(new Transport(middle.ToString(), middle));
            Console.WriteLine("Средний элемент по ключу в коллекции 3: " + stopwatch.ElapsedTicks);
            stopwatch.Restart();
            testCollections.Collection3.ContainsKey(new Transport(last.ToString(), last));
            Console.WriteLine("Последний элемент по ключу в коллекции 3: " + stopwatch.ElapsedTicks);
            stopwatch.Restart();
            testCollections.Collection3.ContainsKey(new Transport(nonEx.ToString(), nonEx));
            Console.WriteLine("Отсутвующий элемент по ключу в коллекции 3: " + stopwatch.ElapsedTicks + "\n");
            stopwatch.Restart();

            testCollections.Collection4.ContainsKey((new Train(first.ToString(), first, first)).ToString());
            Console.WriteLine("Первый элемент по ключу в коллекции 4: " + stopwatch.ElapsedTicks);
            stopwatch.Restart();
            testCollections.Collection4.ContainsKey((new Train(middle.ToString(), middle, middle)).ToString());
            Console.WriteLine("Средний элемент по ключу в коллекции 4: " + stopwatch.ElapsedTicks);
            stopwatch.Restart();
            testCollections.Collection4.ContainsKey((new Train(last.ToString(), last, last)).ToString());
            Console.WriteLine("Последний элемент по ключу в коллекции 4: " + stopwatch.ElapsedTicks);
            stopwatch.Restart();
            testCollections.Collection4.ContainsKey((new Train(nonEx.ToString(), nonEx, nonEx)).ToString());
            Console.WriteLine("Отсутвующий элемент по ключу в коллекции 4: " + stopwatch.ElapsedTicks + "\n");
            stopwatch.Restart();

            testCollections.Collection3.ContainsValue(new Train(first.ToString(), first, first));
            Console.WriteLine("Первый элемент по значению в коллекции 3: " + stopwatch.ElapsedTicks);
            stopwatch.Restart();
            testCollections.Collection3.ContainsValue(new Train(middle.ToString(), middle, middle));
            Console.WriteLine("Средний элемент по значению в коллекции 3: " + stopwatch.ElapsedTicks);
            stopwatch.Restart();
            testCollections.Collection3.ContainsValue(new Train(last.ToString(), last, last));
            Console.WriteLine("Последний элемент по значению в коллекции 3: " + stopwatch.ElapsedTicks);
            stopwatch.Restart();
            testCollections.Collection3.ContainsValue(new Train(nonEx.ToString(), nonEx, nonEx));
            Console.WriteLine("Отсутвующий элемент по значению в коллекции 3: " + stopwatch.ElapsedTicks + "\n");
            stopwatch.Restart();

            testCollections.Collection4.ContainsValue(new Train(first.ToString(), first, first));
            Console.WriteLine("Первый элемент по значению в коллекции 4: " + stopwatch.ElapsedTicks);
            stopwatch.Restart();
            testCollections.Collection4.ContainsValue(new Train(middle.ToString(), middle, middle));
            Console.WriteLine("Средний элемент по значению в коллекции 4: " + stopwatch.ElapsedTicks);
            stopwatch.Restart();
            testCollections.Collection4.ContainsValue(new Train(last.ToString(), last, last));
            Console.WriteLine("Последний элемент по значению в коллекции 4: " + stopwatch.ElapsedTicks);
            stopwatch.Restart();
            testCollections.Collection4.ContainsValue(new Train(nonEx.ToString(), nonEx, nonEx));
            Console.WriteLine("Отсутвующий элемент по значению в коллекции 4: " + stopwatch.ElapsedTicks + "\n");
            stopwatch.Stop();

            return 0;
        }
    }
}