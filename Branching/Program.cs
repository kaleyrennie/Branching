using System;


namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("What is your favorite number?");
            //int favNum = Convert.ToInt32(Console.ReadLine());

            //string result = favNum == 12 ? "You have an awesome favorite number." : "You do not have an awesome favorite number.";

            //Console.WriteLine(result);
            //Console.ReadLine();










            //int roomTemperature = 70;

            //Console.WriteLine("Hi, what is your name?");
            //string name = Console.ReadLine();

            //Console.WriteLine("Hi, " + name + ", what is the temperature where you are?");
            //int currentTemperature = Convert.ToInt32(Console.ReadLine());

            //if (currentTemperature == roomTemperature)
            //{
            //    Console.WriteLine("It is exactly room temperature.");
            //}
            //else if (currentTemperature > roomTemperature)
            //{
            //    Console.WriteLine("It is warmer than room temperature.");
            //}
            //else if (roomTemperature > currentTemperature)
            //{
            //    Console.WriteLine("It is colder than room temperature.");
            //}
            //else
            //{
            //    Console.WriteLine("Uhhhhhh.... something went wrong.");

            //}

            //Console.ReadLine();


            //int currentTemperature = 70;
            //int roomTemperature = 70;

            //string comparisonResult = currentTemperature == roomTemperature ? "It is not room temp." : "It is not room temp.";

            //Console.WriteLine(comparisonResult);
            //Console.ReadLine();

            //if (currentTemperature == roomTemperature)
            //{
            //    Console.WriteLine("It is ecxactly room temperature.");
            //}
            //else if (currentTemperature > roomTemperature)
            //{
            //    Console.WriteLine("It is warmer than room temperature.");       
            //}
            //else if (roomTemperature > currentTemperature)
            //{
            //    Console.WriteLine("Room temperature is warmer than current temperature.");
            //}
            //else
            //{
            //    Console.WriteLine("It is not exactly room temperature.");
            //}



            

            int maxWeight = 50;
            int maxHeight = 50;
            int maxLength = 50;

            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Weight:");
            int currentWeight = Convert.ToInt32(Console.ReadLine());
            if (currentWeight <= maxWeight)
            {
               Console.WriteLine("Height:");
                int currentHeight = Convert.ToInt32(Console.ReadLine());
                if (currentHeight <= maxHeight)
                {
                    Console.WriteLine("Length:");
                    int currentLength = Convert.ToInt32(Console.ReadLine());
                    if (currentLength <= maxLength)
                    {
                        Console.WriteLine("Your estimated total for shipping this package is: " + currentWeight * currentHeight * currentLength / 100m);
                       
                    }
                    else if (currentLength > maxLength)
                    {
                        Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");
                    }
                }
                else if (currentHeight > maxHeight)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");
                }

            }
            else if (currentWeight > maxWeight)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");  
            }
            




            Console.ReadLine();

     








        }
    }
}
