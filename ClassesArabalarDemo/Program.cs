using System.Globalization;

namespace ClassesArabalarDemo
{
    internal class Program
    {
        static Araba _araba; // Değişken : Field (alan)
                             // _araba referans değişkeni herhangi bir yerde new'lenmeden
                             // kullanmaya çalışılırsa null referance exception
                             // (hata yabi beklenmeyen durum) oluşur ve fırlatılır
        static void Main(string[] args)
        {
            ArabaOlustur();
            ArabaGoster();
        }



        static void ArabaOlustur()
        {

            // 1. güzel yol
            // _araba = new Araba
            // Console.Write("Marka: ");
            // _araba.Marka = Console.ReadLine();
            //Console.Write("Model: ");
            // _araba.Model = Console.ReadLine();
            //....






            Console.Write("Marka: ");
            string marka = Console.ReadLine();
            Console.Write("Model: ");
            string model = Console.ReadLine();
            Console.Write("Kapı Sayısı: ");
            byte kapiSayisi = Convert.ToByte(Console.ReadLine());
            Console.Write("Beygir Gücü (HP): ");
            short beygirGucu = Convert.ToInt16(Console.ReadLine());
            if (beygirGucu >= 2001)
            {
                Console.WriteLine("Yanlış Beygir Gücü Girdiniz!");
            }
            Console.Write("Maksimum Hız (km/h): ");
            short maksimumHiz = short.Parse(Console.ReadLine());
            Console.Write("Çekiş Tipi (" + CekisTipleri.ÖndenÇekiş + ": "
                + (int)CekisTipleri.ÖndenÇekiş + ", " + CekisTipleri.Arkadanİtiş + ": "
                + (int)CekisTipleri.Arkadanİtiş + ", " + CekisTipleri.DörtÇeker + ": "
                + (int)CekisTipleri.DörtÇeker + "): ");
            // Console.Write($"Çekiş Tipi: ( {CekisTipleri.ÖndenÇekiş}  :
            // {(int)CekisTipleri.ÖndenÇekiş} :{CekisTipleri.Arkadanİtiş}  :
            // {(int)CekisTipleri.Arkadanİtiş} : {CekisTipleri.DörtÇeker}  :
            // {(int)CekisTipleri.DörtÇeker} ): ");
            string cekisTipiInput = Console.ReadLine();
            int cekisTipi = Convert.ToInt32(cekisTipiInput);
            Console.Write("Ağırlık: ");
            double agirlik = double.Parse(Console.ReadLine());

            bool ikinciElMi = IkinciElAta();

            Console.Write("0 - 100 Hızlanma (sn) : ");
            decimal sifirYuzHizlanma = decimal.Parse(Console.ReadLine());
            Console.Write("Trafiğe Çıkış Tarihi (gg.aa.yyyy): ");
            DateTime trafigeCikisTarihi = DateTime.Parse(Console.ReadLine(), new CultureInfo("tr-TR"));

            _araba = new Araba()
            {
                Agirlik = agirlik,
                BeygirGucu = beygirGucu,
                Id = 1,
                IkinciElMi = ikinciElMi,
                KapiSayisi = kapiSayisi,
                MaksimumHiz = maksimumHiz,
                Marka = marka,
                Model = model,
                SifirYüzHizlanma = sifirYuzHizlanma,
                TrafigeCikisTarihi = trafigeCikisTarihi,
                CekisTipi = (CekisTipleri)cekisTipi
            };

        }

        static bool IkinciElAta()
        {
            string ikinciElInput;
            bool ikinciElMi = false;
            do
            {
                Console.Write("İkinci El (e: evet, h: hayır): ");
                ikinciElInput = Console.ReadLine().ToLower().Trim();
                if (ikinciElInput == "e")
                    ikinciElMi = true;
            }
            while (!(ikinciElInput == "e" || ikinciElInput == "h"));
            return ikinciElMi;
        }
        static void ArabaGoster()
        {
            Console.WriteLine("*** Oluşturulan Araba ***");

            Console.WriteLine($"Id: {_araba.Id}\n" +
                $"Marka: {_araba.Marka}\n" +
                $"Model: {_araba.Model}\n" +
                $"Kapı Sayısı: {_araba.KapiSayisi} Kapı\n" +
                $"Beygir Gücü: {_araba.BeygirGucu} HP\n" +
                $"Maksimum Hız: {_araba.MaksimumHiz} km/h\n" +
                $"Çekiş Tipi: {_araba.CekisTipi}({(int)_araba.CekisTipi})\n" +
                $"Ağırlık: {_araba.Agirlik.ToString(new CultureInfo("tr-TR"))} kg\n" +
                $"İkinci El: {_araba.IkinciEl}\n" +
                $"0 - 100 Hızlanma: {_araba.SifirYüzHizlanma} sn\n" +
                $"Trafiğe Çıkış Tarihi: {_araba.TrafigeCikisTarihi.ToString("dd.mm.yyyy", new CultureInfo("tr-TR"))}"
                //$"İkinci El: {(_araba.IkinciElMi ? "Evet" : "Hayır")}" 1. yöntem
                ); 

        }
    }
}