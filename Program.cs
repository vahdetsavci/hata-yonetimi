using System;

namespace hata_yonetimi;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(sayi);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Hata: " + ex.Message.ToString());
        }
        finally
        {
            Console.Write("İşlem tamamlandı.");
        }

        try
        {
            // int a = int.Parse(null);
            // int a = int.Parse("test");
            int a = int.Parse("-20000000000");
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine("Boş değer girdiniz");
            Console.WriteLine(ex);
        }
        catch(FormatException fex)
        {
            Console.WriteLine("Veri tipi uygun değil.");
            Console.WriteLine(fex);
        }
        catch(OverflowException oex)
        {
            Console.WriteLine("Çok küçük veya çok büyük bir değer girdiniz.");
            Console.WriteLine(oex);
        }
        finally
        {
            Console.WriteLine("İşlem başarıyla tamamlandı.");
        }
    }
}
