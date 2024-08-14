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

            bool run = false;
            for (int i = 0; i < friends.Length; i++)
            {
                Console.WriteLine(friends[i]);
            }
        }
        
    }
}