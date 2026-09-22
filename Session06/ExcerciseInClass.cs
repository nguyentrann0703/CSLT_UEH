using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Text;

internal partial class Session06
{   
    // 1. Write a C# function to find the maximum of three numbers.
    // - Improve the next version that accept at least 1 parameter.
    /// <summary>
    /// 1. Write a C# function to find the maximum of three numbers.
    /// - Improve the next version that accept at least 1 parameter.
    /// </summary>
    static int tim_max(int a, int b, int c)
    {
        int max = a;
        if (b > max)
        max = b;
        if (c > max)
        max = c;
        return max;
    }

    static int tim_max_nhieu_tham_so(int a, params int[] pars)
    {   
        int max = a;
        foreach (int i in pars)
        {
            if (i > max)
            max = i;
        }
        return max;
    }

    /// <summary>
    /// 2. Write a C# function to calculate the factorial of a number (a non-negative integer). The function accepts the number as an argument.
    /// </summary>
    /// <param name="args"></param>
    static int tinh_giai_thua(int a)
    {
        int factorial = 1;
        for (int i = 1; i <= a; i++)
        {
            factorial *= i;
        }
        return factorial;
    }
    
    /// <summary>
    /// 3. Write a C# function that takes a number as a parameter and checks whether the number is prime or not.
    /// </summary>
    /// <param name="args"></param>
    static bool kiem_tra_so_nguyen_to(int num)
    {
        if (num < 2) return false;
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i ==0) return false;
        }
        return true;
    }
    /// <summary>
    /// 4. Write a C# function to print
    /// 1. all prime numbers that less than a number (enter prompt keyboard).
    /// 2. the first N prime numbers
    /// </summary>
    /// <param name="args"></param>
    static void so_nguyen_to_thu_n(int num)
    {
        
    }

    private static void Main2(string[] args)
    {   
        Console.OutputEncoding = Encoding.UTF8;
        // Bài 1: Tìm giá trị max của 3 số
        // Console.Write("Nhập a: "); int a = int.Parse(Console.ReadLine());
        // Console.Write("Nhập b: "); int b = int.Parse(Console.ReadLine());
        // Console.Write("Nhập c: "); int c = int.Parse(Console.ReadLine());
        // Console.WriteLine($"Giá trị max của a, b, c là: {tim_max(a, b, c)}");
        
        // Bài 1 (cải thiện): Lập hàm tính max nhận ít nhất 1 tham số
        // Console.WriteLine($"Giá trị max của a, b, c là: {tim_max_nhieu_tham_so(6,2,3,4,5)}");
        
        // Bài 2: Lập hàm tính giai thừa của một số
        // Console.Write("Nhập số cần tính giai thừa: "); int a = int.Parse(Console.ReadLine());
        // Console.WriteLine($"Giá trị giai thừa của {a} là: {tinh_giai_thua(a)}");

        // Bài 3: Kiểm tra số nguyên tố
        Console.Write("Nhập số cần kiểm tra: "); int num = int.Parse(Console.ReadLine());
        if (kiem_tra_so_nguyen_to(num))
        {
            Console.WriteLine($"Số {num} là số nguyên tố");
        }
        else
        Console.WriteLine($"Số {num} không là số nguyên tố");
        
        // 
        
    
    
    
    
    // 5. Write a C# function to check whether a number is "Perfect" or not. Then print
    // all perfect number that less than 1000.
    // 6. Write a C# function to check whether a string is a pangram or not.
    // (Note : Pangrams are words or sentences containing every letter of the alphabet at
    // least once. For example : "The quick brown fox jumps over the lazy dog"


    }
}