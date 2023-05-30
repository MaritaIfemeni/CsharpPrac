namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test();
            Console.WriteLine($"Sum of numbers 1 and 2 is: {test.Testi(1, 2)}");
            Console.WriteLine($"Sum of numbers 3 and 6 is: {test.Testi(3, 6)}");

            int myNumber = 5;
            double myDouble = 5.5;
            char myChar = 'a';
            string myString = "Hello World";
            bool myBool = true;

            Console.WriteLine($"Variables must be specified with a type. Int: {myNumber}");
            Console.WriteLine($"Double: {myDouble}");
            Console.WriteLine($"Char: {myChar}");
            Console.WriteLine($"String: {myString}");
            Console.WriteLine($"Bool: {myBool}");

            Console.WriteLine("--------------------");

            Console.WriteLine("Here is a simble celciust ot franheit converter");
            Console.WriteLine("Enter a number in celcius");
            double celsius = Convert.ToDouble(Console.ReadLine());
            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine($"The temperature in fahrenheit is {fahrenheit}");

            Console.WriteLine("--------------------");

            Console.WriteLine("Here is a simble area of a circle calculator");
            Console.WriteLine("Enter a radius");
            double radius = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * radius * radius;
            Console.WriteLine($"The area of the circle is {area}");

            Console.WriteLine("--------------------");

            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            var currentDate = DateTime.Now;
            Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");
            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}