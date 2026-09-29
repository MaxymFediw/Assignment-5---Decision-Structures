using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5___Decision_Structures
{
    internal class Program //Maxym F.
    {
        static void Main(string[] args)
        {

            int charge;
            double bearing, timeParked, choice;

            charge = 0;

            Console.WriteLine("What would You Like To Do?");
            Console.WriteLine("1 - Compass Bearings");
            Console.WriteLine("2 - Parking Gerage");
            Console.WriteLine("3 - Hurricane");
            Double.TryParse(Console.ReadLine(), out choice);

            if (choice == 1) 
            {
                //Comapss bearings:

                Console.WriteLine("Give me a bearing on a compass (0°-360°)");
                if (Double.TryParse(Console.ReadLine(), out bearing))
                {
                    bearing = bearing % 360;

                    if ((bearing > 315 && bearing <= 360) || (bearing >= 0 && bearing < 45))
                    {
                        Console.WriteLine($"The bearing {bearing}° puts us looking North!");
                    }

                    else if (bearing > 45 && bearing < 135)
                    {
                        Console.WriteLine($"The bearing {bearing}° puts us looking East!");
                    }

                    else if (bearing > 135 && bearing < 225)
                    {
                        Console.WriteLine($"The bearing {bearing}° puts us looking South!");
                    }

                    else if (bearing > 225 && bearing < 315)
                    {
                        Console.WriteLine($"The bearing {bearing}° puts us looking West!");
                    }

                    else if (bearing < 0)
                    {
                        Console.WriteLine("I said somewhere between 0° and 360°. Real funny, big guy.");
                    }

                    else if (bearing == 45)
                    {
                        Console.WriteLine($"The bearing {bearing}° puts us looking North East.");
                    }

                    else if (bearing == 135)
                    {
                        Console.WriteLine($"The bearing {bearing}° puts us looking South East.");
                    }

                    else if (bearing == 225)
                    {
                        Console.WriteLine($"The bearing {bearing}° puts us looking South West.");
                    }

                    else if (bearing == 315)
                    {
                        Console.WriteLine($"The bearing {bearing}° puts us looking North West.");
                    }

                }

                else
                {
                    Console.WriteLine("I said somewhere between 0° and 360°. Real funny, big guy.");
                }
            }

            ////Comapss bearings:

            //Console.WriteLine("Give me a bearing on a compass (0°-360°)");
            //if (Double.TryParse(Console.ReadLine(), out bearing))
            //{
            //    bearing = bearing % 360;

            //    if ((bearing > 315 && bearing <= 360) || (bearing >= 0 && bearing < 45))
            //    {
            //        Console.WriteLine($"The bearing {bearing}° puts us looking North!");
            //    }

            //    else if (bearing > 45 && bearing < 135)
            //    {
            //        Console.WriteLine($"The bearing {bearing}° puts us looking East!");
            //    }

            //    else if (bearing > 135 && bearing < 225)
            //    {
            //        Console.WriteLine($"The bearing {bearing}° puts us looking South!");
            //    }

            //    else if (bearing > 225 && bearing < 315)
            //    {
            //        Console.WriteLine($"The bearing {bearing}° puts us looking West!");
            //    }

            //    else if (bearing < 0)
            //    {
            //        Console.WriteLine("I said somewhere between 0° and 360°. Real funny, big guy.");
            //    }

            //    else if (bearing == 45)
            //    {
            //        Console.WriteLine($"The bearing {bearing}° puts us looking North East.");
            //    }

            //    else if (bearing == 135)
            //    {
            //        Console.WriteLine($"The bearing {bearing}° puts us looking South East.");
            //    }

            //    else if (bearing == 225)
            //    {
            //        Console.WriteLine($"The bearing {bearing}° puts us looking South West.");
            //    }

            //    else if (bearing == 315) 
            //    {
            //        Console.WriteLine($"The bearing {bearing}° puts us looking North West.");
            //    }

            //}

            //else 
            //{
            //    Console.WriteLine("I said somewhere between 0° and 360°. Real funny, big guy.");
            //}

            //Parking Gerage:

            Console.WriteLine("How long were you parked in Sam's Gerage while you were shopping (In Minutes)?");
            if (Double.TryParse(Console.ReadLine(), out timeParked))
            {

                if (timeParked <= 60 && timeParked >= 1)
                {
                    charge = 4;
                }

                else if (timeParked > 60 && timeParked <= 120)
                {
                    charge = 6;
                }

                else if (timeParked > 120 && timeParked <= 180)
                {
                    charge = 8;
                }

                else if (timeParked > 180 && timeParked <= 240)
                {
                    charge = 10;
                }

                else if (timeParked > 240 && timeParked <= 300)
                {
                    charge = 12;
                }

                else if (timeParked > 300 && timeParked <= 360)
                {
                    charge = 14;
                }

                else if (timeParked > 360 && timeParked <= 420)
                {
                    charge = 16;
                }

                else if (timeParked > 420 && timeParked <= 480)
                {
                    charge = 18;
                }

                else if (timeParked > 480 && timeParked <= 540)
                {
                    charge = 20;
                }

                else if (timeParked > 540)
                {
                    charge = 20;
                }

                else if (timeParked <= 0)
                {
                    charge = 0;
                }

                Console.WriteLine($"You Have been Parked for: {timeParked} minutes.");
                Console.WriteLine($"You have been charged: ${charge}");

            }

            else 
            {
                Console.WriteLine("I said Put in a NUMBER in miutes, big guy. REALLLL funny.");
            }

            //Hurricane:

























        }
        public static void Bearing()
        {

        }
        public static void Parking()
        {

        }
        public static void Hurricane()
        {

        }
    }
}
