namespace telefonrehberi
{
    public class KayıtlıNumaralar
    {
        public static List<Rehber> _telefonRehberim;

        static KayıtlıNumaralar()
        {
            _telefonRehberim = new List<Rehber>()
            {
                new Rehber {isim = "Ceren",   soyisim = "Koç",     numara = "01234567891"},
                new Rehber {isim = "Kaan",    soyisim = "Kocaman", numara = "01234567892"},
                new Rehber {isim = "Elif",    soyisim = "Aydın",   numara = "01234567893"},
                new Rehber {isim = "Türkan",  soyisim = "Tuna",    numara = "01234567894"},
                new Rehber {isim = "Leyla ",  soyisim = "Kösegil", numara = "01234567895"},
            };
        }

        public static List<Rehber> telefonRehberim
        {
            get { return _telefonRehberim; }
        }

        public static void RehberYazdır()
        {
            foreach (var item in telefonRehberim)
            {
                Console.WriteLine(item.isim + " " + item.soyisim + " " + item.numara);
            }
        }

        
    }

}