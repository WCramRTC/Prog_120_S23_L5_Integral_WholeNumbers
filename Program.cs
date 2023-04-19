namespace Prog_120_S23_L5_Integral_WholeNumbers
{
    internal class Program
    { // Start of class block
      // Global Variable
        //static string stringNum1 = "65";
        //static string stringNum2 = "87";
        //static string stringResult = stringNum1 + stringNum2; // "65" + "87" = "6587"

        static void Main(string[] args)
        {
            //IntegerExample(); // Uncomment to run
            //MathExample(); // Uncomment to run

            // parse
            // Parsing is a method used to tell the computer to check if a string is actually a type of number
            // type.Parse(string)

            string string52 = "52";
            string number7 = "7";
            string result = string52 + number7;

            // using parse
            int num52 = int.Parse("52");
            int num7 = int.Parse("7");
            int numResult = num52 + num7;
            Console.WriteLine(numResult);

            // using Convert
            int con52 = Convert.ToInt32("52");
            int con7 = Convert.ToInt32("7");
            Console.WriteLine(con52 + con7);


            Console.Write("Please enter a number: ");
            string userString1 = Console.ReadLine();
            Console.Write("Please enter another number: ");
            string userString2 = Console.ReadLine();
            int userNum1 = int.Parse(userString1);
            int userNum2 = int.Parse(userString2);
            int userResult = userNum1 + userNum2;

            Console.WriteLine($"{userNum1} + {userNum2} = {userResult}");

        } // Main

        public static void FormattedMathString(int num1, int num2 , double result, string operation)
        {
            Console.WriteLine($"{num1} {operation} {num2} = {result}");
        }

        public static void MathExample()
        {
            // Math Operations - +, -, *, /, %
            // Assignment Operations
            // Comparison Operation
            // Compound Operations

            // Perform the math ( store as variables, use math operator )
            int num1 = 123;
            int num2 = 654;
            int add = num1 + num2;
            string symbol = "+";
            // Display to user - Output: Display Result
            Console.WriteLine($"{num1} {symbol} {num2} = {add}");


            int sub1 = 98734;
            int sub2 = 1283754;
            int subResult = sub1 - sub2;
            symbol = "-";
            // Display to user - Output: Display Result
            FormattedMathString(sub1, sub2, subResult, symbol);

            // Multiply *
            int multi1 = 98734;
            int mult2 = 1283754;
            int multiResult = multi1 * mult2;
            symbol = "*";
            // Display to user - Output: Display Result
            FormattedMathString(multi1, mult2, multiResult, symbol);

            // Divide /
            int div1 = 98734;
            int div2 = 98734;
            symbol = "/";
            // If you do division with two ints, it will resolve to an int, before assigning to the variable.
            double divResult = div1 / (div2 * 1.0);
            // PEMDAS

            symbol = "/";
            // Display to user - Output: Display Result
            FormattedMathString(div1, div2, divResult, symbol);

            // Mod %

            int mod1 = 20;
            int mod2 = 15;
            int modResult = mod1 % mod2;
            int divMod1 = mod1;
            int divMod2 = mod2;
            int divModResult = divMod1 / divMod2;

            Console.WriteLine("How division and mod compliment one another");
            symbol = "%";
            FormattedMathString(mod1, mod2, modResult, symbol);
            symbol = "/";
            // Display to user - Output: Display Result
            FormattedMathString(divMod1, divMod2, divModResult, symbol);
            //string numToString = number1.ToString();
            // .ToString()

            //// HOw to get a random number
            //Random rand = new Random();
            //rand.Next(0, 100) % 5 == 0; // Every time a number generated is divisible by 5, return true

            // math operators : + , - , * , / , %
            // operations change depending on the types were working with
            // string + string : Contatenates
            // number + number : does math

        }

        public static void IntegerExample()
        {
            // Different Size buckets
            // int, unit
            // short, ushort
            // byte, sbyte

            // Integral - Whole number
            // to declare a variable that will hold a whole number
            
            string stringNum1 = "65";
            string stringNum2 = "87";
            string stringResult = stringNum1 + stringNum2; // "65" + "87" = "6587"

            // number values cant use double quotes
            int number1 = 65;
            int number2 = 87;
            int result = number1 + number2; // 65 + 87 = 152
            Console.WriteLine(stringResult);


            // sbyte range is -128 - 127
            sbyte sbyteNumber = 123;
            sbyte sbyte2 = 123;
            //sbyte sbResult = sbyteNumber + sbyte2;
        }

    } // class

} // namespace