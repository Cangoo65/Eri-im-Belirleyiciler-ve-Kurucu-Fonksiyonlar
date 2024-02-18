namespace Erişim_Belirleyiciler_ve_Kurucu_Fonksiyonlar
{
    internal class Calisan
    {
        public string Ad;
        public string Soyad;
        public int? No;
        public string? Departman;

        public Calisan(string ad, string soyad, int no, string departman)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.No = no;
            this.Departman = departman;
        }
        public Calisan(string ad, string soyad)
        {
            this.Ad = ad;
            this.Soyad = soyad;
        }
        public void CalisanBilgileriGoster()
        {
            Console.WriteLine("***************************************");
            Console.WriteLine("Çalışanın Adı :" + Ad);
            Console.WriteLine("Çalışanın Soyadı :" + Soyad);
            if (No != null) 
            {
                Console.WriteLine("Çalışanın Numarası :" + No);
            }
            if (Departman != null) 
            { 
                Console.WriteLine("çalışanın Departmanı :" + Departman); 
            }
            Console.WriteLine();
        }
    }
}
