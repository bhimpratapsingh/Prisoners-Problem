using System;

namespace Prisoner_s_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int prisonersCount = 0, killPosition = 0, killCount = 0, counter = 0, arrayIndex = -1;
            bool prisonersCountValidationCheck, prisonersKillPositionValidationCheck;
            int[] prisoners;

            Console.WriteLine("Prisoner's problem");
            Console.WriteLine("Enter number of prisoners:");
            prisonersCountValidationCheck = Int32.TryParse(Console.ReadLine(), out prisonersCount);

            if (!prisonersCountValidationCheck || prisonersCount <=0)
            {
                Console.WriteLine("Please enter a valid number for prisoners count");
                return;
            }

            Console.WriteLine("Enter the position at which prisoner needs to be killed");
            prisonersKillPositionValidationCheck = Int32.TryParse(Console.ReadLine(), out killPosition);

            if (!prisonersKillPositionValidationCheck || killPosition <= 0)
            {
                Console.WriteLine("Please enter a valid number for prisoner kill position");
                return;
            }

            //initialise prisoners array (here we assign values to prisoners array starting from 1, 
            //and with each kill we update the value with 0, 
            //so that at the end, array will have only one value apart from zero's 
            //and we will be able to identify the position of prisoner who remained alive at the end.
            prisoners = new int[prisonersCount];

            for (int i = 0; i < prisonersCount; i++)
            {
                prisoners[i] = i + 1;
            }
            
            
            //Loop until the kill count reaches total prisoner - 1
            while (killCount != prisonersCount - 1)
            {
                //Increment in every loop
                counter++;
                arrayIndex++;

                //To start with first position of array, if moved out of index of array.
                if (arrayIndex > prisonersCount - 1)
                {
                    arrayIndex = 0;
                }

                //To handle already killed prisoner's
                if (prisoners[arrayIndex] == 0)
                {
                    counter--;
                    continue;
                }

                //To sync counter with kill position
                if (counter > killPosition)
                {
                    counter = 1;
                }

                //Killing of prisoner at the kill position
                if (counter % killPosition == 0)
                {
                    prisoners[arrayIndex] = 0;
                    //incrementing the kill count
                    killCount++;
                }
            }

            for (int i = 0; i < prisonersCount; i++)
            {
                if (prisoners[i] != 0)
                {
                    Console.WriteLine("Position of the prisoner left at the end: "+ prisoners[i]);
                }
            }

            Console.ReadKey();
        }
    }
}
