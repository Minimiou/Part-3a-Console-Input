using System;

namespace Part_3a_Console_Input
{
    class Program
    {
        static void Greetings()
        {
            string name;
            string age;
            string year;
            DateTime currentYear = DateTime.Today;

            Console.WriteLine("Hello! What's your name?");
            name = Console.ReadLine();

            Console.WriteLine("Nice! Now how old are you?");
            age = Console.ReadLine();

            Console.WriteLine("And what year were you born?");
            year = Console.ReadLine();

            Console.WriteLine($"Ok {name}, you were born in {year}, we are currently in {currentYear.ToString("yyyy")} so you are {age} years old. Nice to meet you!");
        }
        static void Adder()
        {
            string first;
            string second;
            string third;
            int number1;
            int number2;
            int number3;

            Console.WriteLine("Please enter three numbers you wish to add together, the first number is:");
            first = Console.ReadLine();
            number1 = Convert.ToInt32(first);

            Console.WriteLine("The second number is:");
            second = Console.ReadLine();
            number2 = Convert.ToInt32(second);

            Console.WriteLine("And the third number is:");
            third = Console.ReadLine();
            number3 = Convert.ToInt32(third);

            Console.WriteLine($"The answer is: {number1 + number2 + number3}");
        }
        static void Distance()
        {
            string firstD;
            string secondD;
            string thirdD;
            decimal distance1;
            decimal distance2;
            decimal distance3;
            decimal answer;

            Console.WriteLine("Please enter three distances you wish to have the average of in km, the first distance is:");
            firstD = Console.ReadLine();
            distance1 = Convert.ToDecimal(firstD);

            Console.WriteLine("The second distance is:");
            secondD = Console.ReadLine();
            distance2 = Convert.ToDecimal(secondD);

            Console.WriteLine("And the third distance is:");
            thirdD = Console.ReadLine();
            distance3 = Convert.ToDecimal(thirdD);

            answer = (distance1 + distance2 + distance3) / 3;

            Console.WriteLine($"The average distance is: {Math.Round(answer, 2)} km.");
        }
        static void Hypotenuse()
        {
            string firstSide;
            string secondSide;
            double side1;
            double side2;
            double hypotenuse;

            Console.WriteLine("Please enter the lengths of two sides of a right triangle to get the hypotenuse, the first length is:");
            firstSide = Console.ReadLine();
            side1 = Convert.ToDouble(firstSide);

            Console.WriteLine("The second length is:");
            secondSide = Console.ReadLine();
            side2 = Convert.ToDouble(secondSide);
            
            hypotenuse = Math.Sqrt(Math.Pow(side1, 2) + Math.Pow(side2, 2));

            Console.WriteLine($"The hypotenuse is: {Math.Round(hypotenuse,2)}");
        }
        static void Main(string[] args)
        {
            //Greetings();
            //Adder();
            //Distance();
            Hypotenuse();
        }
    }
}
