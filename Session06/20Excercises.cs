using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Text;

internal partial class Excercise_20
{
    /// <summary>
    /// Tính tổng 2 số nguyên
    /// </summary>
    /// <param name="args"></param>
    static int TinhTong(int a, int b)
    {
        return a + b;
    }

    /// <summary>
    /// Kiểm tra số chẵn lẻ
    /// </summary>
    /// <param name="args"></param>
    static bool KiemTraChan(int n)
    {
        return n % 2 == 0;
    }

    static int TimMax(int a, int b, int c)
    {
        int max = a;
        if (max < b)
        {
            max = b;
        }
        else if (max < c)
        {
            max = c;
        }
        return max;
    }

    static long TinhGiaiThua(int n)
    {
        long fact = 1;
        for (int i = 2; i <= n; i++)
        {
            fact *= i;
        }
        return fact;
    }

    static string DaoNguocChuoiKyTu(string input)
    {
        char[] mangKyTu = input.ToCharArray();
        Array.Reverse(mangKyTu);
        return new string(mangKyTu);
    }

    static bool KiemTraSoNguyenTo(int n)
    {
        if (n<2) return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0) return false;
        }
        return true;
    }

    static void InFibonacci(int n)
    {
        int F_2 = 0;
        int F_1= 1;
        for (int i = 0; i < n; i++)
        {
            Console.Write($"{F_2}\t");
            int F = F_2 + F_1;
            F_2 = F_1;
            F_1 = F;

        }
    }

    static int DemNguyenAm(string s)
    {
        int dem = 0;
        string nguyenAm =  "aeiou";
        foreach (char c in s)
        {
            if (nguyenAm.Contains(char.ToLower(c)))
            dem++;
        }
        return dem;
    }

    static double TinhLuyThua(double x, int y)
    {
        double luyThua=x;
        for (int i=1; i < y; i++)
        {
            luyThua *= x;
        }
        return luyThua;
    }
    static int[] NhapMang(int[] arr, int n)
    { 

        for (int i=0; i < n; i++)
        {
            Console.Write($"Nhập phần tử thứ {i+1}: "); int element = int.Parse(Console.ReadLine());
            arr[i] = element;
        }
        return arr;
    }
    static double TinhTrungBinh(int[] arr)
    {
        int sum = 0;
        foreach (int v in arr)
        {
            sum += v;
        }
        return (double) sum/ arr.Length;
    }
    static bool KiemTraDoiXung(string s)
    {
        return s == DaoNguocChuoiKyTu(s);
    }

    static double CelsiusToFahrenheit(double c)
    {
        return (1.8 * c) + 32;
    }
    
    static int TimMin(int[] arr)
    {
        int min = arr[0];
        for (int i= 1; i < arr.Length; i++)
        {
            if (min > arr[i])
            {
                min = arr[i];
            }
        }
        return min;

    }

    static int TongCacChuSo(int n)
    {
        string chuoiSo = Math.Abs(n).ToString();
        int sum = 0;
        foreach (char c in chuoiSo)
        {
            sum += c - '0';
        }
        return sum;
    }

    static void SapXepMang(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] > arr[j])
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write($"{arr[i]}\t");
        }
        Console.WriteLine();
        
    }
    static string XoaTrungLap(string s)
    {
        List<char> mangChuoi = new List<char>();
        // string -> duyệt qua từng phần tử -> append vào một cái char array  -> khi duyệt vào hỏi đã có chưa = cách dùng contain
        foreach (char c in s)
        {
            if (! mangChuoi.Contains(c)) mangChuoi.Add(c);
        }
        return string.Join("", mangChuoi);
    }

    static int UCLN(int a, int b)
    {
        a = Math.Abs(a);
        b = Math.Abs(b);

        while (b != 0)
        {
            int phanDu = a % b;
            a = b;
            b = phanDu;
        }

        return a;
    }
    static string DecimalToBinary(int n)
    {
        // chia lấy phần dư xong bỏ vào chuỗi
        string result = "";
        while (n > 0)
        {
            int phanDu = n % 2;
            result += phanDu;
            n = n/2;
        }
        return DaoNguocChuoiKyTu(result);
    }

    static bool KiemTraNamNhuan(int year)
    {
        return (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0); 
    }

    static int DemSoTu(string sentence)
    {
        string[] tu = sentence.Split(" ");
        return tu.Length;
    }
    private static void Main2(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        // Bài 1: Tính tổng
        // Console.Write("Nhập a: "); int a = int.Parse(Console.ReadLine());
        // Console.Write("Nhập b: "); int b = int.Parse(Console.ReadLine());
        // Console.WriteLine($"Tổng của {a} và {b} là {TinhTong(a, b)}");

        // Bài 2: Kiểm tra số chẵn lẽ
        // Console.Write("Nhập n: "); int n = int.Parse(Console.ReadLine());
        // if (KiemTraChan(n))
        // {
        //     Console.WriteLine($"n = {n} là số chẵn");
        // }
        // else Console.WriteLine($"n = {n} là số lẻ");

        // Bài 3: Tìm số lớn nhất trong 3 số
        // Console.Write("Nhập a: "); int a = int.Parse(Console.ReadLine());
        // Console.Write("Nhập b: "); int b = int.Parse(Console.ReadLine());
        // Console.Write("Nhập c: "); int c = int.Parse(Console.ReadLine());
        // Console.WriteLine($"Số lớn nhất là {TimMax(a, b, c)}");

        // Bài 4: Tính giai thừa
        // Console.Write("Nhập số muốn tính giai thừa: "); int n = int.Parse(Console.ReadLine());
        // Console.WriteLine($"Giai thừa của {n} là {TinhGiaiThua(n)}");

        // Bài 5: Đảo ngược chuỗi ký tự
        // Console.Write("Nhập một chuỗi: "); string input = Console. ReadLine();
        // Console.WriteLine($"Chuỗi ngược là: {DaoNguocChuoiKyTu(input)}");

        // Bài 6: Kiểm tra số nguyên tố
        // Console.Write("Nhập một số để kiểm tra: "); int n = int.Parse(Console.ReadLine());
        // if (KiemTraSoNguyenTo(n))
        // Console.WriteLine($"{n} là số nguyên tố");
        // else Console.WriteLine($"{n} KHÔNG là số nguyên tố");

        // Bài 7: In dãy Fibonacci
        // Console.Write("Nhập số lượng số cần in: "); int n = int.Parse(Console.ReadLine());
        // InFibonacci(n);

        // Bài 8: Đếm nguyên âm trong chuỗi
        // Console.Write("Nhập một chuỗi: "); string input = Console.ReadLine();
        // Console.WriteLine($"Số nguyên âm trong chuỗi {input} là {DemNguyenAm(input)}");

        // Bài 9: Tính lũy thừa
        // Console.Write("Nhập x: "); double x = double.Parse(Console.ReadLine());
        // Console.Write("Nhập y: "); int y = int.Parse(Console.ReadLine());
        // Console.WriteLine($"Lũy thừa của {x}^{y} là {TinhLuyThua(x, y)}");
        
        // Bài 10: Tính trung bình mảng số nguyên
        
        // Console.Write("Nhập số lượng phần tử trong mảng: "); int n = int.Parse(Console.ReadLine());
        // int[] arr = new int[n];
        // Console.WriteLine($"Trung bình của mảng trên là {TinhTrungBinh(NhapMang(arr, n))}");

        // Bài 11: Kiểm tra chuỗi đối xứng (Palindrome)
        // Console.Write("Nhập một chuỗi: "); string s = Console.ReadLine();
        // if (KiemTraDoiXung(s))
        // Console.WriteLine("Chuỗi đối xứng");
        // else Console.WriteLine("Chuỗi KHÔNG đối xứng");

        // Bài 12: Chuyển đổi nhiệt độ
        // Console.Write("Nhập độ C: "); double c = double.Parse(Console.ReadLine());
        // Console.WriteLine($"{c} độ Celsius = {CelsiusToFahrenheit(c)} độ Fahrenheit");

        // Bài 13: Tìm giá trị nhỏ nhất trong mảng
        // Console.Write("Nhập số lượng phần tử trong mảng: "); int n = int.Parse(Console.ReadLine());
        // int[] arr = new int[n];
        // Console.WriteLine($"Giá trị nhỏ nhất trong mảng là {TimMin(NhapMang(arr, n))}");

        // Bài 14: Tính tổng các chữ số của một số nguyên
        // Console.Write("Nhập một số nguyên: "); int n = int.Parse(Console.ReadLine());
        // Console.WriteLine($"Tổng các chữ số là {TongCacChuSo(n)}");

        // Bài 15: Sắp xếp mảng tăng dần
        // Console.Write("Nhập số lượng phần tử trong mảng: "); int n = int.Parse(Console.ReadLine());
        // int[] arr = new int[n];
        // SapXepMang(NhapMang(arr, n));


        // Bài 16: Xóa ký tự trùng lặp
        // Console.Write("Nhập một chuỗi ký tự: "); string s = Console.ReadLine();
        // Console.WriteLine($"Chuỗi kí tự không trùng lặp là {XoaTrungLap(s)}");

        // Bài 17: Tìm ước chung lớn nhất (UCLN)

        // Console.Write("Nhập a: "); int a = int.Parse(Console.ReadLine());
        // Console.Write("Nhập b: "); int b = int.Parse(Console.ReadLine());
        // Console.WriteLine($"Ước chung lớn nhất của {a} và {b} là {UCLN(a, b)}");

        // Bài 18: Chuyển đổi hệ thập phân sang hệ nhị phân
        // Console.Write("Nhập một số: "); int n = int.Parse(Console.ReadLine());
        // Console.WriteLine($"Hệ nhị phân của số {n} là {DecimalToBinary(n)}");

        // Bài 19: Kiểm tra năm nhuận
        // Console.Write("Nhập năm muốn kiểm tra: "); int year = int.Parse(Console.ReadLine());
        // if (KiemTraNamNhuan(year))
        // Console.WriteLine($"Năm {year} là năm nhuận");
        // else Console.WriteLine($"Năm {year} không là năm nhuận");

        // Bài 20: Đếm số từ trong câu
        Console.Write("Nhập một câu: "); string sentence = Console.ReadLine();
        Console.WriteLine($"Số từ trong câu {sentence} là {DemSoTu(sentence)}");
    
    }
        
}