using System;
using System.Collections.Generic;

namespace telefonrehberi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz.");
            Console.WriteLine("*****************************************");
            Console.WriteLine("(1) Yeni numara kaydetmek");
            Console.WriteLine("(2) Varolan numarayı silmek");
            Console.WriteLine("(3) Varolan numarayı güncellemek");
            Console.WriteLine("(4) Rehberi listelemek");
            Console.WriteLine("(5) Rehberde arama yapmak");
            int input = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                case 1:
                Kaydetmeİşlemi.Kaydet();
                break;
                case 2:
                Silmeİşlemi.Silme();
                break;
                case 3:
                Güncellemeİşlemi.Güncelleme();
                break;
                case 4:
                Listelemeİşlemi.Listeleme();
                break;
                case 5:
                Aramaİşlemi.Arama();
                break;
            }

        }
    }

}

