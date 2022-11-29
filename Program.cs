using System;

namespace Operators_Hamilton_Dakota
{
    class Program
    {
        static void Main(string[] args)
        {
            /*MIN AND MAX*/
            Console.WriteLine("INTEGERS");
            // Multiplies Two Integers
            int intMult = 6 * 45;
            // Adds Two Integers
            int intAdd = 55 + 66;
            // Displays the Minmum of the two integer variables
            Console.WriteLine($"The max of {intMult} and {intAdd} is {Math.Max(intMult, intAdd)}. " + 
                $"the min of the two is {Math.Min(intMult, intAdd)}");
            
            // Determines if intMult is greater than intAdd
            bool isIntGreater = intMult > intAdd;
            // Displays whether if intMult is greater than intAdd
            Console.WriteLine($"{intMult} is greater than {intAdd}, {isIntGreater}.\n");

            /*SHORT*/
            Console.WriteLine("SHORTS");
            // Multiplies Two short
            short shortMult = 6 * 45;
            // Adds Two short
            short shortAdd = 55 + 66;
            // Displays the Minmum of the two short variables
            Console.WriteLine($"The max of {shortMult} and {shortAdd} is {Math.Max(shortMult, shortAdd)}. " +
                $"the min of the two is {Math.Min(shortMult, shortAdd)}");
            
            // Determines if shortMult is greater than shortAdd
            bool isshortGreater = shortMult > shortAdd;
            // Displays whether if shortMult is greater than shortAdd
            Console.WriteLine($"{shortMult} is greater than {shortAdd}, {isshortGreater}.\n");

            /*LONG*/
            Console.WriteLine("LONGS");
            // Multiplies Two long
            long longMult = 6 * 45;
            // Adds Two long
            long longAdd = 55 + 66;
            // Displays the Minmum of the two long variables
            Console.WriteLine($"The max of {longMult} and {longAdd} is {Math.Max(longMult, longAdd)}. " +
                $"the min of the two is {Math.Min(longMult, longAdd)}");
            
            // Determines if longMult is greater than longAdd
            bool islongGreater = longMult > longAdd;
            // Displays whether if longMult is greater than longAdd
            Console.WriteLine($"{longMult} is greater than {longAdd}, {islongGreater}.\n");

            /*FLOAT*/
            Console.WriteLine("FLOATS");
            // Multiplies Two float
            float floatMult = 6.5f * 45.24f;
            // Adds Two float
            float floatAdd = 55.35f + 66.15f;
            // Displays the Minmum of the two floateger variables
            Console.WriteLine($"The max of {floatMult} and {floatAdd} is {Math.Max(floatMult, floatAdd)}. " +
                $"the min of the two is {Math.Min(floatMult, floatAdd)}");

            // Determines if floatMult is greater than floatAdd
            bool isfloatGreater = floatMult > floatAdd;
            // Displays whether if floatMult is greater than floatAdd
            Console.WriteLine($"{floatMult} is greater than {floatAdd}, {isfloatGreater}.\n");

            /*DOUBLE*/
            Console.WriteLine("DOUBLES");
            // Multiplies Two double
            double doubleMult = 6.69 * 45.58;
            // Adds Two double
            double doubleAdd = 55.48 + 66.15;
            // Displays the Minmum of the two doubleeger variables
            Console.WriteLine($"The max of {doubleMult} and {doubleAdd} is {Math.Max(doubleMult, doubleAdd)}. " +
                $"the min of the two is {Math.Min(doubleMult, doubleAdd)}");

            // Determines if doubleMult is greater than doubleAdd
            bool isdoubleGreater = doubleMult > doubleAdd;
            // Displays whether if doubleMult is greater than doubleAdd
            Console.WriteLine($"{doubleMult} is greater than {doubleAdd}, {isdoubleGreater}.\n");

            /*DECIMAL*/
            Console.WriteLine("DECIMALS");
            // Multiplies Two decimal
            decimal decimalMult = (decimal)(6.25 * 45.15);
            // Adds Two decimal
            decimal decimalAdd = (decimal)(55.66 + 66.55);
            // Displays the Minmum of the two decimal variables
            Console.WriteLine($"The max of {decimalMult} and {decimalAdd} is {Math.Max(decimalMult, decimalAdd)}. " +
                $"the min of the two is {Math.Min(decimalMult, decimalAdd)}");

            // Determines if decimalMult is greater than decimalAdd
            bool isdecimalGreater = decimalMult > decimalAdd;
            // Displays whether if decimalMult is greater than decimalAdd
            Console.WriteLine($"{decimalMult} is greater than {decimalAdd}, {isdecimalGreater}.\n");
        }
    }
}
