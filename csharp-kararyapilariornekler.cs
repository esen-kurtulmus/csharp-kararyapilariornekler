using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace birinciders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //karar yapıları

            //if else
            /*
             * if(şart)
             * {
             * işlem1
             * }
             * else
             * {
             * işlem2
             * }
             * 
            //operatörler
            //= + * - /
            //karar yapılarında == eşit mi, != eşit değilse, && ve ; || veya
            //% mod alma
            */
            string password;
            Console.Write("şifreyi giriniz");
            password = Console.ReadLine();
            if (password == "abcd")
            {
                Console.Write("şifre başarılı");
            }
            else
            {
                Console.Write("şifre hatalı");
            }

            int sayi;
            Console.Write("sayıyı giriniz");

            sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi == 5)
            {
                Console.WriteLine("doğru");
            }
            else
            {
                Console.WriteLine("yanlış");
            }

            int sayi1, sayi2, sonuc;
            sayi1 = Convert.ToInt32(Console.ReadLine());
            sayi2 = Convert.ToInt32(Console.ReadLine());
            sonuc = sayi1 + sayi2;
            Console.WriteLine(sonuc);
            if (sonuc > 50)
            {
                Console.WriteLine("sayi 50 den büyüktür");
            }
            else

            {
                Console.WriteLine("sayi 50 den küçüktür");
            }

            string username, userpassword;
            Console.Write("kullanıcı adınız:");
            username = Console.ReadLine();
            Console.Write("Şifreniz:");
            userpassword = Console.ReadLine();
            if (username == "admin" && userpassword == "1234")
            {
                Console.Write("hoşgeldiniz");
            }
            else
            {
                Console.WriteLine("hatalı giriş");
            }



            ////Console.Write("sayı:");
            ////int sayi=Convert.ToInt32(Console.ReadLine());
            ////Console.Write(sayi % 5);
            int sayi4, sayi5, sayi6, sayi7, toplam;
            sayi4 = 456;
            sayi5 = sayi4 % 10;
            sayi6 = sayi4 / 100;
            sayi7 = (sayi4 / 10) % 10;
            toplam = sayi5 + sayi6 + sayi7;
            Console.Write("basamak toplamları :" + toplam);

            Console.ReadLine();




        }
    }
}

