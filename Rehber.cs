using System;

namespace telefonrehberi
{
    public class Rehber
    {
        private string İsim;
        private string Soyisim;
        private string Numara;

        public string isim { get => İsim; set => İsim = value; }
        public string soyisim { get => Soyisim; set => Soyisim = value; }
        public string numara { get => Numara;set => Numara = value; }

        public Rehber(string isim, string soyisim, string numara)
        {
            İsim = isim;
            Soyisim = soyisim;
            Numara = numara;
        }
        public Rehber() { }
    }
}
