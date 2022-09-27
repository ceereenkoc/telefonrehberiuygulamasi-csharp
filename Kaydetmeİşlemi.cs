namespace telefonrehberi
{
    public class Kaydetmeİşlemi:KayıtlıNumaralar
    {
        public static void Kaydet()
        {
            Console.WriteLine("Lütfen isim giriniz            :");
            string ad = Console.ReadLine();
            Console.WriteLine("Lütfen soyisim giriniz         :");
            string soyad = Console.ReadLine();
            Console.WriteLine("Lütfen telefon numarası giriniz:");
            string no = Console.ReadLine();

            Rehber kişi = new Rehber();
            kişi.isim = ad;
            kişi.soyisim = soyad;
            kişi.numara = no;

            KayıtlıNumaralar.telefonRehberim.Add(kişi);

            

            
            
            


        }
    }
}