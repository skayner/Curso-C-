using System;

namespace Static
{
    class Program
    {
        static void Main(string[] args)
        {
            People foo = new People()
            {
                Name = "Foo",
                Age = 1
            };
            People faa = new People()
            {
                Name = "Faa",
                Age = 5
            };
            
            Console.Write(People.GetCount());
        }

        public static class A
        {
            public static void Some()
            {
                Console.WriteLine("algo");

            }
        }

        public class People
        {
            public static int Count = 0;
            public string Name { get; set; }
            public int Age { get; set; }

            public People()
            {
                Count++;
            }

            public static string GetCount()
            {
                return $"Esta clase se ha utilizado {Count} veces";
            }
        }
    }
}