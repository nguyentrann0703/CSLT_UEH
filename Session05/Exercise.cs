using System.Linq.Expressions;
using System.Net;
using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks.Dataflow;

internal class Session05
{
    static void doan_so()
    {

        bool cont_play = true;
        int tong_so_van_choi = 0;
        int so_lan_thang = 0;
        int so_lan_doan;

        do
        {
            tong_so_van_choi++;
            // Tạo số ngẫu nhiên
            Console.OutputEncoding = Encoding.UTF8;
            Random rnd = new Random();
            int com_num = rnd.Next(10) +1;
            
            // Chọn độ khó
            while (true)
            {
                Console.Write("Hãy chọn độ khó cho trò chơi <1 - dễ | 2 - trung bình | 3 - khó>: ");
                int level = int.Parse(Console.ReadLine());
                if (level == 1)
                {
                    so_lan_doan = 9;
                    break;
                }
                else if (level == 2)
                {
                    so_lan_doan = 6;
                    break;
                }
                else if (level == 3)
                {
                    so_lan_doan = 3;
                    break;
                }
                else
                {
                    
                    Console.WriteLine("Nhập độ khó không hợp lệ (1-3). Hãy chọn lại!");
                }

            }   

             // Đoán số
            for(int i = 1; i <= so_lan_doan; i++)
            {
                Console.Write("Bạn đoán số mấy?: "); int user_input = int.Parse(Console.ReadLine());
                if (user_input == com_num)
                {
                    Console.WriteLine("Bạn đoán đúng rồi!!!!");
                    so_lan_thang++;
                    break;
                }
                else if (user_input < com_num)
                {
                    Console.WriteLine("Số bạn đoán bé hơn con số ngẫu nhiên");
                }
                else
                {
                    Console.WriteLine("Số bạn đoán lớn hơn con số ngẫu nhiên");
                }

            }
            // xong một lần chơi
            Console.WriteLine($"Con số ngẫu nhiên là {com_num}");

            // chơi tiếp hay thoát
            string opt;
            while (true)
            {
                Console.Write("Ván chơi kết thúc! Bạn muốn chơi lại chứ? (y/n): "); opt = Console.ReadLine().ToLower();
                if (opt == "y" || opt == "n") break;
                Console.WriteLine("Nhập sai ký tự xác nhận. Hãy nhập lại!");
            }
    
            if (opt == "y")
            {
                Console.WriteLine("Khởi động lại ván chơi.... \n");
            }
            else
            {   
                cont_play = false;
                Console.WriteLine("Thoát khỏi trò chơi. Hẹn gặp bạn lần sau...!");
            }

        }
        while (cont_play);
        Console.WriteLine($"Trong số {tong_so_van_choi} ván chơi, bạn đã thắng {so_lan_thang}. Tỉ lệ thắng của bạn là {(double) so_lan_thang/tong_so_van_choi:P}");
    }


    static void bang_cuu_chuong()
    {
        for (int i = 1; i <= 9; i++)
        {
            for (int j = 1; j <= 9; j++)
            {
                Console.Write($"{j} x {i,2} = {j * i,2}\t");
            }
            Console.WriteLine();
        }
    }

    /// <summary>
    /// Write a program to check whether a triangle is Equilateral, Isosceles or Scalene
    /// </summary>
    static void ex1()
    {
        Console.Write("Enter side a: "); int a = int.Parse(Console.ReadLine());
        Console.Write("Enter side b: "); int b = int.Parse(Console.ReadLine());
        Console.Write("Enter side c: "); int c = int.Parse(Console.ReadLine());

        if (a + b > c || a + c > b || b + c > a)
        {
            if (a == b || b == c || a == c)
            {
                Console.WriteLine("The triangle is Isosceles");
            }
            else if (a == b && b == c)
            {
                Console.WriteLine("The triangle is Equilateral");
            }
            else
            {
                Console.WriteLine("The triangle is Scalence");
            }
        }
        else
        {
            Console.WriteLine("Cannot form a triangle!");
        }

    }

    /// <summary>
    /// Write a program to read 10 numbers and find their average and sum.
    /// </summary>
    static void ex2()
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("You will enter 10 numbers consecutively... \n");
        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"Enter num {i,2}: "); int input = int.Parse(Console.ReadLine());
            numbers.Add(input);
        }

        Console.WriteLine($"\nThe average of 10 input num: {numbers.Average()}");
        Console.WriteLine($"Thesum of 10 input num: {numbers.Sum()}");

    }
    
    /// <summary>
    /// Write a program to display the multiplication table of a given integer
    /// </summary>
    static void ex3()
    {
        Console.Write("Please enter a number (int type): "); int num = int.Parse(Console.ReadLine());
        for (int i = 1; i <=9; i++)
        {
            Console.WriteLine($" {num} * {i} = {num * i}");
        }   
    }

    /// <summary>
    /// Write a program to display a pattern like triangles with a number
    /// </summary>
    static void ex4()
    {
        List<int> numbers = new List<int>{1,2,3,4,5,6,7,8,9,10};

        for (int i = 0; i <=3; i++)
        {
            for (int j=0; j <= i; j++)
            {
                Console.Write(numbers[j] + " ");
            }
            Console.WriteLine();
        }

        int temp1 = 0;
        for (int i = 0; i <=3; i++)
        {
            for (int j=0; j <= i; j++)
            {
                Console.Write(numbers[temp1++] + " ");
                
            }
            Console.WriteLine();
        }
        int temp2 = 0;
        int row_num = 4;

        for (int i = 0; i <=3; i++)
        {   
            Console.Write(new string(' ', row_num - 1 - i));
            for (int j=0; j <= i; j++)
            {
                
                Console.Write(numbers[temp2++] + " ");
            }

            Console.WriteLine();
            
        }
        
    }
    /// <summary>
    /// Write a program to display the n terms of harmonic series and their sum
    /// </summary>
    static void ex5()
    {   
        Console.Write("Please input n: "); int n = int.Parse(Console.ReadLine());
        Console.Write("Harmonic Series: ");
        double sum = 0;
        

        for (int i = 1; i <= n; i++)
        {
            if (i == 1) Console.Write("1");
            else
            {
                
                Console.Write($" + 1/{i}");
            }
            sum += 1.0/i;

        }
        Console.WriteLine();
        Console.WriteLine($"Sum of the above series = {sum:F3}");
    }

    /// <summary>
    /// Write a program to find the ‘perfect’ numbers within a given number range
    /// </summary>
    static void ex6()
    {
        


        Console.Write("Enter the upper limit for the examined range: "); int end = int.Parse(Console.ReadLine());
        Console.Write($"Perfect numbers within the range of 1 to {end} are: ");

        int dem = 0;     
        for (int num = 1; num <= end; num++)
        {
            int sum = 0;
            for (int i = 1; i <= num/2; i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                }
            }
            if (sum == num)
            {
                dem++;
                Console.Write(num + " ");
            }
    
        }
        if (dem > 0) 
            Console.WriteLine();
        else 
        {   
            Console.WriteLine("\n.........");
            Console.WriteLine($"There are NO perfect numbers within the range of 1 to {end} ");
        }
       
    }

    
    /// <summary>
    /// Write a program to determine whether a given number is prime or not
    /// </summary>
    static void ex7()
    {
        Console.Write("Please enter the number of prime number you want to find: "); int N = int.Parse(Console.ReadLine());
        Console.WriteLine($"The first {N} prime numbers are:");

        int dem = 1;
        int so = 2;
        while (dem <= N)
        {
            bool kt = true;
            for (int i = 2; i <= Math.Sqrt(so); i++)
            {
                if (so % i == 0)
                {
                    kt = false;
                    break;
                }

            }
            if (kt)
            {
                Console.Write($"{so,2} ");
                if (dem % 10 == 0)
                {
                    Console.WriteLine();
                }
                dem++;
            }
            so++;

        }
        
        
    }
    


    private static void Main(string[] args)
    {   
        doan_so();
        // bang_cuu_chuong();
        // ex1();
        // ex2();
        // ex3();
        // ex4();
        // ex5();
        // ex6();
        // ex7();



        
    
        


    }
}