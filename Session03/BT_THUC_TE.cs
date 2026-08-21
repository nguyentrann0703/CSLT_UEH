using System.Security.Cryptography;
using System.Text;

internal partial class BAI_TAP
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        const decimal bac_1 = 1806;
        const decimal bac_2 = 1866;
        const decimal bac_3 = 2167;
        const decimal bac_4 = 2729;
        const decimal bac_5 = 3050;

        Console.Write("Nhập chỉ số điện cũ (kWh): ");
        float chi_so_dien_cu = float.Parse(Console.ReadLine());
        float chi_so_dien_moi;
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
        decimal tien_dien;

        if (luong_dien <= 50)
        {
            tien_dien = luong_dien * bac_1;
        } 
        else if (luong_dien <= 100)
        {
            luong_dien  -= 50;
            tien_dien = 50 * bac_1 + luong_dien * bac_2;
        } 
        else if (luong_dien <= 200)
        {
            luong_dien  -= 100;
            tien_dien = 50 * bac_1 + 50 * bac_2 + luong_dien * bac_3;
        }
        else if (luong_dien <= 300)
        {
            luong_dien  -= 200;
            tien_dien = 50 * bac_1 + 50 * bac_2 + 100 * bac_3 + luong_dien * bac_4;
        }
        else
        {
            luong_dien  -= 300;
            tien_dien = 50 * bac_1 + 50 * bac_2 + 100 * bac_3 + 100 * bac_4 + luong_dien * bac_5;
        }
        Console.WriteLine("Tổng tiền điện là: " + tien_dien);
        Console.ReadKey();


    }
}