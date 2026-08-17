int a = 45;
int b = 65;
// Ex 1: Add/ Sum two number
Console.WriteLine($"a + b = {a+b}");

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
const double converted = 0.3048;
Console.Write("Enter length in feet: ");
double feet  = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Your length in meter is: {feet * converted}");

// Ex 5: convert Celsius to Fahrenheit and vice versa
Console.WriteLine("Enter a number in celsius degree: ");
double celsius = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Your number in Fahrenheit is {1.8 * celsius + 32}");

Console.WriteLine("Enter a number in Fahrenheit degree: ");
double fahr = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Your number in Celsius is {(fahr - 32) * 1.8}");

// Ex 6: c


Console.WriteLine("Type anything to continue...");
Console.ReadKey();



