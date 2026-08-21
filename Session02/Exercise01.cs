internal class Program
{
    private static void Main1(string[] args)
    {
        int a = 45;
        int b = 65;
        // Ex 1: Add/ Sum two number
        Console.WriteLine($"a + b = {a + b}");

        // Ex 2: Swap values of two variables
        int c = a;
        a = b;
        b = c;
        Console.WriteLine(a);
        Console.WriteLine(b);

        // Ex 3: Multiply two floating point numbers
        double e = 3.14;
        double f = 3.12;
        Console.WriteLine($"Multiply two floating point numbers: {f * e}");

        // Ex 4: Convert feet to meter
        const double rate = 0.3048;
        Console.Write("Enter length in feet: ");
        double feet = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Your length in meter is: {feet * rate}");

        // Ex 5: convert Celsius to Fahrenheit and vice versa
        Console.WriteLine("Enter a number in celsius degree: ");
        double celsius = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Your number in Fahrenheit is {1.8 * celsius + 32}");
        

        Console.WriteLine("Enter a number in Fahrenheit degree: ");
        double fahr = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Your number in Celsius is {(fahr - 32) / 1.8}");

        // Ex 6: find the size of datatype 
        Console.WriteLine($"Size of int: {sizeof(int)}");
        Console.WriteLine($"Size of float: {sizeof(float)}");
        
        // Ex 7: print ASCII value (tip: read character, print number of this char)
        Console.WriteLine("Enter a character in alphabet: ");
        int ascii_char = Console.Read();
        Console.ReadLine();
        Console.WriteLine($"Ascii value of the character is: {ascii_char}");

        // Ex 8: calculate area of a circle
        const double pi = 3.14;
        double r = 3, s = 5;
        Console.WriteLine($"With radius = 3, area of the circle is: {pi * r * r}");

        // Ex 9: to Calculate Area of Square 
        Console.WriteLine($"With side = 5, area of the square is: {s * s}");

        // Ex 10: to convert days to years, weeks and days
        Console.WriteLine("Enter number of days: ");
        int days = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Converted into {days / 365 } years, {days % 365 / 7} weeks, {days % 365 % 7} days");

        Console.WriteLine("Type anything to continue...");
        Console.ReadKey();
        
    }
}
