using System.Configuration.Assemblies;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;

internal class InClassExcercise
{
    
    /// <summary>
    ///  Write a C# Sharp program that takes two numbers as input and performs an operation (+,-,*,%,/) on them and displays the result of that operation.
    /// </summary>
    static void BT_1()
    {
        Console.Write("Enter number a: "); int a = int.Parse(Console.ReadLine());
        Console.Write("Enter number b: "); int b = int.Parse(Console.ReadLine());

        Console.WriteLine($"{a} + {b} = {a + b} ");
        Console.WriteLine($"{a} - {b} = {a - b} ");
        Console.WriteLine($"{a} * {b} = {a * b} ");
        Console.WriteLine($"{a} % {b} = {a % b} ");
        Console.WriteLine($"{a} / {b} = {a / b} ");

    }
    /// <summary>
    /// Write a C# Sharp program to display certain values of the function x = y^2 + 2y + 1 (using integer numbers for y, ranging from -5 to +5).
    /// </summary>
    static void BT_2()
    {

        for (int y = -5; y <=5; y++)
        {
            int x = y * y + 2*y + 1;
            Console.WriteLine($"With y = {y,2} => {x}");
        }

    }
    /// <summary>
    /// Write a C# Sharp program that takes distance and time (hours, minutes, seconds) as input and displays speed in kilometers per hour (km/h) and miles per hour (miles/h).
    /// </summary>
    static void BT_3()
    {
        Console.Write("Enter distance in kilometers: "); float dis = float.Parse(Console.ReadLine());
        Console.Write("Enter time in hours: "); float hours = float.Parse(Console.ReadLine());
        Console.Write("Enter time in minutes: "); float mins = float.Parse(Console.ReadLine());
        Console.Write("Enter time in seconds : "); float secs = float.Parse(Console.ReadLine());

        float time = hours + mins / 60 + secs / 3600;
        float km_per_hour = dis / time;
        float miles = dis * 0.62137f;
        float miles_per_hour = miles / time;

        Console.WriteLine($"Your speed in km/h: {km_per_hour} and in miles/h {miles_per_hour}");



    }

/// <summary>
/// Write a C# Sharp program that takes the radius of a sphere as input and calculates and displays the surface and volume of the sphere. V = 4/3*π*r^3
/// </summary>
    static void BT_4()
    {
        Console.Write("Enter radius: "); double rad = double.Parse(Console.ReadLine());
        double surface = 4.0 * Math.PI * Math.Pow(rad, 2);
        double volume = 4.0/3.0 * Math.PI * Math.Pow(rad, 3);
        Console.WriteLine($"With radius = {rad} => sphere surface: {surface:F2} - sphere volume: {volume:F2}");


    }
    /// <summary>
    /// Write a C# Sharp program that takes a character as input and checks if it is a vowel, a digit, or any other symbol.
    /// </summary>
    static void BT_5()
    {
        int character = Console.Read();
        Console.WriteLine(character);
        int []vowel_list = [65, 69, 73, 79, 85, 97, 101, 105, 111, 117];
        if (vowel_list.Contains(character))
        {
            Console.WriteLine("The input is a vowel!");
        } 
        else if (character >= 48 && character <= 57)
        {
            Console.WriteLine("The input is a digit!");
        }
        else
        {
            Console.WriteLine("The input is another symbol!");
        }
    }
    static void GiaiPT(double a, double b, double c)
    {
        

        if (a == 0)
        {
            if (b == 0)
            {
                if (c == 0)
                {
                    Console.WriteLine("Phương trình có vô số nghiệm");
                }
                else // c!=0
                {
                    Console.WriteLine("Phương trình vô lý");
                }
            }

            else //b!=0
            {
                if (c==0)
                {
                    Console.WriteLine("bx = 0 => x = 0");
                }
                else //c!=0
                {
                    Console.WriteLine($"x = {-c / b}");
                }

            }
        }
        else //a!=0
        {
            double delta = Math.Pow(b,2) - 4 * a * c;
                        if (delta==0)
                        {
                            Console.WriteLine($"x = {-b/(2*a)}");
                        }
                        else if (delta<0)
                        {
                            Console.WriteLine("Phương trình vô nghiệm");
                        }
                        else
                        {
                            Console.WriteLine($"x_1 = {(-b + Math.Sqrt(delta)) / (2*a)}, x_2 = {(-b - Math.Sqrt(delta)) / (2*a)} ");
                        }
        } 



        
    }
    private static void Main(string[] args)
    {
        // BT_1();
        // BT_2();
        // BT_3();
        // BT_4();
        BT_5();
        // Console.Write("Nhập a: "); double a = double.Parse(Console.ReadLine());
        // Console.Write("Nhập b: "); double b = double.Parse(Console.ReadLine());
        // Console.Write("Nhập c: "); double c = double.Parse(Console.ReadLine());
        // GiaiPT(a, b, c);

        
    }
}