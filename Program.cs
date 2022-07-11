using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checks
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget, fishAmount;
            string season;
            double total=0;
            double rest;

            Console.WriteLine("Budget: ");
            budget = int.Parse(Console.ReadLine());
            if(budget<1 || budget > 8000)
            {
                throw new ArgumentException("Invalid budget.");
            }

            Console.WriteLine("Season: ");
            season = Console.ReadLine();

            Console.WriteLine("Fishermen amount: ");
            fishAmount = int.Parse(Console.ReadLine());
            if(fishAmount<4 || fishAmount > 18)
            {
                throw new ArgumentException("Invalid amount.");
            }

            switch(season)
            {
                case "Spring":
                    {
                        total = 3000;

                        

                        break;
                    }

                case "Summer":
                    {
                        total = 4200;
                        break;
                    }

                case "Autumn":
                    {
                        total = 4200;
                        break;
                    }

                case "Winter":
                    {
                        total = 2600;
                        break;
                    }
            }

            if (fishAmount <= 6)
            {
                total = total * 0.9;
            }

            if (fishAmount >= 7 && fishAmount <= 11)
            {
                total = total * 0.85;
            }

            if(fishAmount>=12)
            {
                total = total * 0.75;
            }


            if (budget >= total)
            {
                rest = budget - total;
                Console.WriteLine("Yes! You have {0} leva left.",rest);
            }

            else
            {
                rest = total - budget;
                Console.WriteLine("Not enough money! You need {0} leva.",rest);
            }

            Console.ReadLine();
        }
    }
}
