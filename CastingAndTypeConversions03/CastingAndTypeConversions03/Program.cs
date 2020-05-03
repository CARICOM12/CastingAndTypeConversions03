using System;

namespace CastingAndTypeConversions03
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            decimal NumberOfRefugeesPerDay = 50_000;
            int numOfRefIntercepted = 2_000;
            decimal result;
            result = NumberOfRefugeesPerDay - numOfRefIntercepted;
            Console.WriteLine(result);

            float NumberOfSardinesPerBox = 120.3F;
            int NumberOfBoxes = 200;
            float result2;
            result2 = NumberOfSardinesPerBox * NumberOfBoxes;
            Console.WriteLine(result2);

            ulong NumberOfShips = 5;
            double numberOfRenovatedShips = 2;
            double result3;
            result3 = NumberOfShips - numberOfRenovatedShips;
            Console.WriteLine(result3);

            long numberOfAmberInKG = 120;
            int numberOfClients = 7;
            long result4;
            result4 = numberOfAmberInKG / numberOfClients;

            uint numberOfEstonians = 100;
            sbyte numberOfRussians = 50;
            short result5;
            result5 = numberOfEstonians + numberOfRussians;

             
             

                      







        }
    }
}
