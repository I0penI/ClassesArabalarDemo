namespace ClassesArabalarDemo
{
    /// <summary>
    /// Arabaları modellemek için oluşturduğumuz model sınıftır.
    /// </summary>
    class Araba
    {
        /// <summary>
        /// Kayıtların Tekilliğini Sağlamak İçin Kullandığımız Özelliktir.
        /// </summary>
        public int Id { get; set; }

        public string Marka { get; set; }
        public string Model { get; set; }
        public byte KapiSayisi { get; set; }
        public short BeygirGucu { get; set; }
        public short MaksimumHiz { get; set; }
        public CekisTipleri CekisTipi { get; set; } = CekisTipleri.ÖndenÇekiş;
        public double Agirlik { get; set; }
        public bool IkinciElMi { get; set; }
        public decimal SifirYüzHizlanma { get; set; }
        public DateTime TrafigeCikisTarihi { get; set; }


        public string IkinciEl => IkinciElMi ? "Evet" : "Hayır"; // sadece get methodu var, readonly

    }
}
