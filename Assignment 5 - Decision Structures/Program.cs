using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Assignment_5___Decision_Structures
{
    internal class Program //Maxym F.
    {
        static void Main(string[] args)
        {

            int charge;
            int category = 0;
            bool reset;

            reset = false;

            double bearing, timeParked, choice;

            charge = 0;
            while (!reset)
            {

                Console.WriteLine("What would You Like To Do?");
                Console.WriteLine("1 - Compass Bearings");
                Console.WriteLine("2 - Parking Gerage");
                Console.WriteLine("3 - Hurricane");
                Console.WriteLine("Press 4 To Exit");
                Double.TryParse(Console.ReadLine(), out choice);
                Console.Clear();

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

                        Console.WriteLine("Press ENTER To Continue");
                        Console.ReadKey();
                        Console.Clear();

                    }

                    else
                    {
                        Console.WriteLine("I said somewhere between 0° and 360°. Real funny, big guy.");
                        //reset = true;

                        Console.WriteLine("Press ENTER To Continue");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }

                else if (choice == 2)
                {
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

                        Console.WriteLine("Press ENTER To Continue");
                        Console.ReadKey();
                        Console.Clear();

                    }

                    else
                    {
                        Console.WriteLine("I said Put in a NUMBER in miutes, big guy. REALLLL funny.");
                        //reset = true;

                        Console.WriteLine("Press ENTER To Continue");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }


                else if (choice == 3)
                {
                    //Hurricane:

                    Console.WriteLine("What category of hurricane do you want (there are 5)?");

                    if (Int32.TryParse(Console.ReadLine(), out category) && category >= 1 && category <= 5)
                    {
                        switch (category)
                        {
                            case 1:
                                Console.WriteLine("Category 1 Hurricanes go 74-95 mph / 64-82 Kn / 119-153 km/h");
                                break;

                            case 2:
                                Console.WriteLine("Category 2 Hurricanes go 96-110 mph / 83-95 Kn / 154-277 km/h");
                                break;


                            case 3:
                                Console.WriteLine("Category 3 Hurricanes go 111-130 mph / 96-113 Kn / 178-209 km/h");
                                break;

                            case 4:
                                Console.WriteLine("Category 4 Hurricanes go 131-155 mph / 114-135 Kn / 210-249 km/h");
                                break;

                            case 5:
                                Console.WriteLine("Category 5 Hurricanes go 155+ mph / 135+ Kn / 249+ km/h");
                                break;

                        }

                        Console.WriteLine("Press ENTER To Continue");
                        Console.ReadKey();
                        Console.Clear();


                    }



                    else
                    {
                        Console.WriteLine("Please Enter a number 1-5.");
                        //reset = true;

                        Console.WriteLine("Press ENTER To Continue");
                        Console.ReadKey();
                        Console.Clear();
                    }

                }

                else if (choice == 4) 
                {
                    return;
                }



            }
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
