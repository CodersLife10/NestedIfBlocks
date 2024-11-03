using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03112024_NestedIfBlocks_CodersLife
{
    internal class Program
    {//----------> [İç İçe if Blokları] <----------//
    /*
        * <------------------------------------------[IF]------------------------------------------>
        * 'if' yapısı: Belirtilen (koşul) **doğru (true)** ise, kod bloğu çalışır.
        * 
        * <------------------------------------------[ELSE IF]------------------------------------------>
        * 'else if' yapısı: Önceki 'if' veya başka bir 'else if' koşulu **yanlış (false)** ise,  
        * ve bu (koşul) **doğru (true)** olduğunda çalışır.
        * 
        * <------------------------------------------[ELSE]------------------------------------------>
        * 'else' yapısı: Herhangi bir koşul içermez.  
        * Yukarıdaki tüm koşullar **yanlış (false)** olduğunda çalışır.
        *
        * //Önemli Not (Bağımlılıklar):
        * - 'else if' ve 'else' yapıları **mutlaka bir 'if' yapısına bağlıdır.**
        * - Ancak 'if' yapısı, 'else if' veya 'else' yapılarına bağlı olmadan da tek başına çalışabilir.
        * - 'if', 'else if' ve 'else' yapıları, doğrudan veya dolaylı yoldan bool veri türüyle koşullandırılır.
        * 
        * [ÖRNEKLER]
        * 1-) Kullanıcıdan bir sayı alınacak ve sayının 0-100 arasında olup olmama durumu kontrol edilecek. Ardından 25-75 arasında olup olmama durumu kontrol edilecek ve ekrana çıktı verilecek.
        * 2-) Kullanıcıdan alınan; kullanıcı adı ve şifre durumlarına göre 2 farklı örnek yapılacak:
        * 2.1-) ilk örnek: kullanıcı adı ve şifresi doğru veya yanlış ise ekrana bir çıktı verilecek.
        * 2.2-) ikinci örnek: Kullanıcı adı doğru ise scope'a girecek ve ardından şifre kontrol edilecek ve ekrana çıktılar verilecek.
        * 3-) Kullanıcıdan alınan; doğum tarihi, ehliyet durumu, araba bulunma durumuna göre ehliyet alabilme ve trafiğe çıkabilme durumları çıktısı ekrana verilecek.
    */
        static void Main(string[] args)
        {
            #region Örnek 1
            //Console.Write("Lütfen bir sayı giriniz:");
            //int sayi = int.Parse(Console.ReadLine());

            //if (sayi > 0 && sayi < 100)
            //{
            //    Console.WriteLine($"Girdiğiniz {sayi} sayısı 0 ile 100 arasındadır.");
            //    if (sayi > 25 && sayi < 75)
            //    {
            //        Console.WriteLine($"Ayrıca girdiğiniz {sayi} sayısı 25 ile 75 arasındadır.");
            //    }
            //}
            #endregion
            #region Örnek 2.1
            //Console.Write("Lütfen kullanıcı adını giriniz:");
            //string kullaniciAdi = Console.ReadLine();
            //Console.Write("Lütfen şifrenizi giriniz:");
            //string sifre = Console.ReadLine();

            //if (kullaniciAdi == "ahmet" && sifre == "123")
            //{
            //    Console.WriteLine("Giriş başarılı!");
            //}
            //else
            //{
            //    Console.WriteLine("Kullanıcı adı veya şifre yanlış!");
            //}
            #endregion
            #region Örnek 2.2
            //Console.Write("Lütfen kullanıcı adını giriniz:");
            //string kullaniciAdi = Console.ReadLine();
            //Console.Write("Lütfen şifrenizi giriniz:");
            //string sifre = Console.ReadLine();

            //if (kullaniciAdi == "ahmet")
            //{
            //    if (sifre == "123")
            //    {
            //        Console.WriteLine("Giriş başarılı!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Şifre yanlış!");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Kullanıcı adını yanlış girdiniz!");
            //}
            #endregion
            #region Örnek 3
            //Console.Write("Ehliyetiniz var mı? (E/H)");
            //char ehliyet = char.Parse(Console.ReadLine());
            //Console.Write("Arabanız var mı? (E/H)");
            //char arabaSonuc = char.Parse(Console.ReadLine());
            //Console.Write("Lütfen doğum tarihini giriniz: (mm.DD.yy hh:MM:ss (PM or AM))");
            //DateTime dogumTarihi = DateTime.Parse(Console.ReadLine());
            //if ((DateTime.Now.Year - dogumTarihi.Year) >= 18)
            //{
            //    if (ehliyet == 'E')
            //    {
            //        Console.WriteLine("Ehliyetiniz var.");
            //        if (arabaSonuc == 'E')
            //        {
            //            Console.WriteLine("Trafiğe çıkabilirsiniz.");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Ehliyetiniz var fakat trafiğe çıkamazsınız. Çünkü arabanız yok.");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Ehliyetiniz yok, lütfen ehliyet sınavına giriniz.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Ehliyet alamazsınız, yaşınız 18'den küçüktür.");
            //}
            #endregion
            Console.ReadKey();
        }
    }
}