using test_test;
using System.Diagnostics;


namespace test_kez
{
    class program 
    {

        public static void Main(string[] args)
        {
            DoublyLinkedList<int> List = new DoublyLinkedList<int> { };
            Console.WriteLine("------------");
            List.AddFirst(15);
            List.Add(20);
            List.Add(30);
            List.Add(40);

            foreach (int i in List) { Console.WriteLine(i); }

            LinkedList<int> list = new LinkedList<int>();

            list.AddFirst(10);
            list.AddFirst(20);
            list.AddFirst(30);
 
            int a = 15;
            try { list.AddAfter(list.Find(6), a); }
            catch (ArgumentNullException) { Console.WriteLine("Искомого числа нет в списке."); }
            finally { list.AddFirst(a); }

            foreach (int i in list) { Console.WriteLine(i); }

            int[] testarray = new int[100];
            Random rnd = new Random();
            for (int i = 0; i < testarray.Length; i++)
            {
                testarray[i] = rnd.Next(50);
            }
            Array.Sort(testarray);
            Array.BinarySearch(testarray, 11);

            int z = 0;

            foreach (int i in testarray) { Console.WriteLine(" Порядковый номер : " + (z++) + ", Число : " + i); }
            Console.WriteLine("-----------------");
            Stopwatch sw = Stopwatch.StartNew();

            Array.Sort(testarray);

            Search search = new Search();

            
            sw.Start();
            Console.WriteLine(search.CasualSearch(testarray, 30));
            Console.WriteLine("----Времени затрачено----");
            Console.WriteLine(sw.Elapsed);
            sw.Stop();
            Console.WriteLine("-----------------");
            sw.Start();
            Console.WriteLine(search.BinarySearch(testarray, 30));
            Console.WriteLine("----Времени затрачено----");
            Console.WriteLine(sw.Elapsed);
            sw.Stop();         
            Console.WriteLine("-----------------");
            sw.Start();
            Console.WriteLine(search.InterpolationSearch(testarray, 30));
            Console.WriteLine("----Времени затрачено----");
            Console.WriteLine(sw.Elapsed);
            sw.Stop();
            Console.WriteLine("-----------------");


        }
        
     

    }
}