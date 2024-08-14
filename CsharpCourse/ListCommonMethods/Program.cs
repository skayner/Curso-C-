using System;

namespace ListCommonMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>()
            {
                4,3,5,19
            };

            Show(numbers);

            // Insert
            numbers.Insert(1, 6);

            Show(numbers);

            // Contains
            if (numbers.Contains(19))
                Console.WriteLine("existe");
            else
                Console.WriteLine("no existe");

            // IndexOf
            int pos = numbers.IndexOf(19);
            Console.WriteLine(pos);
            pos = numbers.IndexOf(20);
            Console.WriteLine(pos);

            // Sort
            numbers.Sort();
            Show(numbers);

            string name = "Hector";
            name = name.ToUpper();
            Console.WriteLine(name);

            // Add Range
            numbers.AddRange(new List<int>() 
            {
                200, 300, 400
            
            });

            Show(numbers);
        }

        public static void Show(List<int> numbers)
        {
            Console.WriteLine("-- Numeros --");
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }
        }
    }
}