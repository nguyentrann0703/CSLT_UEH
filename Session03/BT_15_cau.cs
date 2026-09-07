using System.Collections.Specialized;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Globalization;
using System.Text;
using Microsoft.VisualBasic;
enum CurrencyType
    {
        USD, EUR, JPY, GBP
    }

internal class BAI_TAP
{   
    static void BT_1()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("--- INPUT ---");
        Console.Write("Nhập chỉ số điện cũ (kWh): ");
        float chi_so_dien_cu = float.Parse(Console.ReadLine());
        float chi_so_dien_moi;
    

        const decimal bac_1 = 1806M;
        const decimal bac_2 = 1866M;
        const decimal bac_3 = 2167M;
        const decimal bac_4 = 2729M;
        const decimal bac_5 = 3050M;

        
        do
        {
        Console.Write("Nhập chỉ số điện mới (kWh): ");
        chi_so_dien_moi = float.Parse(Console.ReadLine());
        if (chi_so_dien_moi >= chi_so_dien_cu)
            break;
        else
            Console.WriteLine("Chỉ số mới phải lớn hơn chỉ số cũ. Hãy nhập lại\n");
        } while(true);
        
        decimal luong_dien = (decimal)(chi_so_dien_moi - chi_so_dien_cu);
        decimal luong_dien_tinh_tien = luong_dien;
        decimal tien_dien;

        if (luong_dien <= 50)
        {
            tien_dien = luong_dien_tinh_tien * bac_1;
        } 
        else if (luong_dien <= 100)
        {
            luong_dien_tinh_tien  -= 50;
            tien_dien = 50 * bac_1 + luong_dien_tinh_tien * bac_2;
        } 
        else if (luong_dien <= 200)
        {
            luong_dien_tinh_tien  -= 100;
            tien_dien = 50 * bac_1 + 50 * bac_2 + luong_dien_tinh_tien * bac_3;
        }
        else if (luong_dien <= 300)
        {
            luong_dien_tinh_tien  -= 200;
            tien_dien = 50 * bac_1 + 50 * bac_2 + 100 * bac_3 + luong_dien_tinh_tien * bac_4;
        }
        else
        {
            luong_dien_tinh_tien -= 300;
            tien_dien = 50 * bac_1 + 50 * bac_2 + 100 * bac_3 + 100 * bac_4 + luong_dien_tinh_tien * bac_5;
        }
        decimal thue_VAT = tien_dien * 0.08M;
        decimal tong_gia = tien_dien + thue_VAT;
        
        Console.WriteLine("--- OUTPUT ---");
        Console.WriteLine($"Số điện tiêu thụ: {luong_dien} kWh");
        Console.WriteLine($"Tiền điện chưa thuế: {tien_dien:#,##0} VNĐ");
        Console.WriteLine($"Thuế VAT (8%): {thue_VAT:#,##0} VNĐ");
        Console.WriteLine($"Tổng thanh toán: {tong_gia:#,##0} VNĐ");
    }
    static void BT_2()
    {
        Console.WriteLine("--- INPUT ---");
        Console.Write("Chiều cao (m): "); double height = double.Parse(Console.ReadLine());
        Console.Write("Cân nặng (kg): "); double weight = double.Parse(Console.ReadLine());

        double BMI = weight / Math.Pow(height,2);
        string classifier;
        if (BMI < 18.5)
        {
            classifier = "Gầy (Thiếu cân)";
        }
        else if (BMI <= 23.0)
        {
            classifier = "Bình thường (Lý tưởng)";
        }
        else if (BMI <= 25.0)
        {
            classifier = "Thừa cân (Tiền béo phì)";
        }
        else
        {
            classifier = "Béo phì";
        }
        Console.WriteLine("--- OUTPUT ---");
        Console.WriteLine($"Chỉ số BMI của bạn: {BMI:F2}");
        Console.WriteLine($"Phân loại sức khỏe: {classifier}");
        Console.WriteLine($"Khuyên dùng: Cân nặng lý tưởng của bạn nên từ {18.5 * Math.Pow(height,2):F2} kg đến {22.9 * Math.Pow(height,2):F2} kg.");
    }
    static void BT_3()
    {
        Console.Write("Nhập số tiền VNĐ: "); decimal amount = decimal.Parse(Console.ReadLine());
        Console.Write("Chọn ngoại tệ (1-USD, 2-EUR, 3-JPY, 4-GBP): "); int choice = int.Parse(Console.ReadLine());

        CurrencyType currency;
        decimal exchange_rate;

        switch (choice)
        {
            case 1:
                currency = CurrencyType.USD;
                exchange_rate = 25400m;
                break;
            case 2:
                currency = CurrencyType.EUR;
                exchange_rate = 27200m;
                break;
            case 3:
                currency = CurrencyType.JPY;
                exchange_rate = 165m;
                break;
            case 4:
                currency = CurrencyType.GBP;
                exchange_rate = 32100m;
                break;
            default:
                Console.WriteLine("Lựa chọn ngoại tệ không hợp lệ!");
                return;

        }

        decimal fee_rate = 0.005m;
        decimal fee_total = amount * fee_rate;
        amount -= fee_total;

        Console.WriteLine("--- OUTPUT ---");
        Console.WriteLine($"Phí dịch vụ (0.5%): {fee_total:N0} VNĐ");
        Console.WriteLine($"Số tiền VNĐ tính đổi: {amount:N0} VNĐ");
        Console.WriteLine($"Số tiền {currency} nhận được: {amount / exchange_rate:N2} {currency}");
    }
    static void BT_4()
    {

        DateTime birth_date;
        DateTime today = DateTime.Now.Date;
        Console.WriteLine("--- INPUT ---");
        Console.Write("Nhập ngày sinh (dd/MM/yyyy): "); string input = Console.ReadLine();
        if (!DateTime.TryParseExact(
            input,
            "dd/MM/yyyy",
            null,
            DateTimeStyles.None,
            out birth_date
        ) || birth_date > today)
        {
            Console.WriteLine("Ngày sinh không hợp lệ!");
            return;
        }
        
    
        int age = today.Year - birth_date.Year;
        if (today < birth_date.AddYears(age))
        {
            age--;
        }

        TimeSpan lived_time = today - birth_date;
        int total_days = (int)lived_time.TotalDays;

        DateTime next_birthday = birth_date.AddYears(today.Year - birth_date.Year);
        if (next_birthday < today)
        {
            next_birthday = next_birthday.AddYears(1);
        }
        int days_to_next_birthday = (int)(next_birthday - today).TotalDays;

        Console.WriteLine("--- OUTPUT ---");
        Console.WriteLine($"Tuổi hiện tại: {age} tuổi");
        Console.WriteLine($"Bạn đã sống tổng cộng: {total_days:N0} ngày");
        Console.WriteLine($"Sinh nhật tiếp theo còn: {days_to_next_birthday} ngày nữa");

    }


    static void BT_5()
    {

        int tc_csharp = 4;
        int tc_toan = 3;
        int tc_tienganh = 2;

        Console.WriteLine("--- INPUT ---");
        Console.Write($"C# ({tc_csharp} TC): "); double diem_csharp = double.Parse(Console.ReadLine());
        Console.Write($"Toán ({tc_toan} TC): ");
        double diem_toan = double.Parse(Console.ReadLine());
        Console.Write($"Tiếng Anh ({tc_tienganh} TC): ");
        double diem_tienganh = double.Parse(Console.ReadLine());

        if (diem_csharp < 0 || diem_csharp > 10 || 
            diem_toan < 0 || diem_toan > 10 || 
            diem_tienganh < 0 || diem_tienganh > 10)
        {
            Console.WriteLine("Điểm không hợp lệ.Phải nằm trong khoảng từ 0 đến 10!");
            return;
        }

        int tong_tc = tc_csharp + tc_toan + tc_tienganh;
        double diem_tb = (diem_csharp * tc_csharp + diem_toan * tc_toan + diem_tienganh * tc_tienganh) / tong_tc;
        char diem_chu;
        double gpa;
        string xep_loai;

        if (diem_tb >= 8.5)
        {
            diem_chu = 'A';
            gpa = 4.0;
            xep_loai = "Xuất sắc / Giỏi";
        }
        else if (diem_tb >= 7.0)
        {
            diem_chu = 'B';
            gpa = 3.0;
            xep_loai = "Khá";
        }
        else if (diem_tb >= 5.5)
        {
            diem_chu = 'C';
            gpa = 2.0;
            xep_loai = "Trung bình";
        }
        else if (diem_tb >= 4.0)
        {
            diem_chu = 'D';
            gpa = 1.0;
            xep_loai = "Yếu";
        }
        else
        {
            diem_chu = 'F';
            gpa = 0.0;
            xep_loai = "Kém (Trượt)";
        }

        Console.WriteLine("--- OUTPUT ---");
        Console.WriteLine($"Điểm TB Thang 10: {diem_tb:F2}");
        Console.WriteLine($"Điểm Chữ Quy Đổi: {diem_chu}");
        Console.WriteLine($"Điểm GPA Thang 4: {gpa:F2}");
        Console.WriteLine($"Xếp Loại Học Lực: {xep_loai}");
    }
    private static void Main2(string[] args)
    {   
        // BT_1();
        // BT_2();
        // BT_3();
        // BT_4();
        BT_5();
    }
}