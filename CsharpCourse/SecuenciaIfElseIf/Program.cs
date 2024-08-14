using System;

namespace SecuenciaIfElseIf
{
    class Program
    {
        static void Main(string[] args)
        {

            bool areYouHungry = true;
            bool youHaveMoney = true;

            if (areYouHungry && youHaveMoney && IsOpenRestaurant("lonches pepe", 11))
            {

                Console.WriteLine("Come");

            }
            else
            {
                Console.WriteLine("No comes");
            }
        }

        static bool IsOpenRestaurant(string name, int hour = 0)
        {
        
            if (name == "lonches pepe" && hour > 8 && hour < 23)
            {
                return true;
            }
            else if (name == "Restaurant 24 horas")
            {
                return true;
            }
            else
            {
                return false;
            }
        
        }
    }
}