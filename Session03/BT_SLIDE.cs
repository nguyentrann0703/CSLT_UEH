internal class SLIDE
{
    private static void Main1(string[] args)
    {
        // BT 1: convert celsius into kelvin and fahrenheit
        Console.Write("Please enter a number: ");
        string input = Console.ReadLine();
        float cels;

        if (float.TryParse(input, out cels)){
            float kelvin = cels + 273;
            float fahr = cels * 18 / 10 + 32;
            Console.WriteLine($"Output: kelvin - {kelvin}, fahrenheit - {fahr}");
        } else
        {
            Console.WriteLine("Input is wrong!");
        }
        // BT 2: calculate surface and volume of a sphere
        const float PI = 3.14f;
        Console.Write("Enter radius: ");
        float radius = float.Parse(Console.ReadLine());
        float surface = 4 * PI * radius * radius;
        float volume = 4 / 3 * PI * radius * radius * radius;
        Console.WriteLine($"Surface: {surface:F2}\nVolume: {volume:F2}");

        // BT 3: calculate the result of adding, subtracting, multiplying and dividing two numbers entered by the user
        Console.Write("Enter number 1: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Enter number 2: ");
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine($"{num1} + {num2} = {num1+num2}");
        Console.WriteLine($"{num1} - {num2} = {num1-num2}");
        Console.WriteLine($"{num1} * {num2} = {num1*num2}");
        Console.WriteLine($"{num1} / {num2} = {num1/num2}");
        Console.WriteLine($"{num1} mod {num2} = {num1%num2}");

        Console.ReadKey();
        
    }
}
