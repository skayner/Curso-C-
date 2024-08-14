using System;
using System.Text;
using System.Xml;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] friends = new string[7]
            {
                "Pancho",
                "Paco",
                "Ana",
                "Ruben",
                "Karla",
                "Luis",
                "Manuel"
            };

            int  index = 0;
            while (index < friends.Length)
            {
                Console.WriteLine(friends[index]);
                index++;
            }

            bool run  = false;
            do
            {
                Show();
            } while (run);
        }
        
        static void Show()
        {
            Console.WriteLine("Entro una vez y ya");
        }
    }
}