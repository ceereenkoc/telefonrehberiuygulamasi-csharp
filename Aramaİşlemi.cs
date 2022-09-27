namespace telefonrehberi
{
    public class Aramaİşlemi : KayıtlıNumaralar
    {
        public static void Arama()
        {
            Console.WriteLine("Arama yapmak istediğiniz yöntemi seçiniz:");
            Console.WriteLine("*****************************************");
            Console.WriteLine("İsim veya soy isime göre arama yapmak için: (1)");
            Console.WriteLine("Numaraya göre arama yapmak için: (2)");
            int input = Convert.ToInt32(Console.ReadLine());

            if (input == 1)
            {
                Console.WriteLine("Lütfen isim  veya soyisim giriniz:");
                string input1 = Console.ReadLine();
                foreach (var item in telefonRehberim)
                {
                    if (input1 == item.isim || input1 == item.soyisim)
                    {
                        Console.WriteLine("İsim            : " + item.isim);
                        Console.WriteLine("Soyisim         : " + item.soyisim);
                        Console.WriteLine("Telefon Numarası: " + item.numara);
                        Console.WriteLine("-");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Aradığınız kişi rehberde kayıtlı değil.");
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Lütfen numarayı giriniz:");
                string input2 = Console.ReadLine();
                foreach (var item in telefonRehberim)
                {
                    if (input2 == item.numara)
                    {
                        Console.WriteLine("İsim            : " + item.isim);
                        Console.WriteLine("Soyisim         : " + item.soyisim);
                        Console.WriteLine("Telefon Numarası: " + item.numara);
                        Console.WriteLine("-");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Aradığınız kişi rehberde kayıtlı değil.");
                        break;
                    }
                }
            }


        }
    }
}