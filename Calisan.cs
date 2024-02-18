namespace Erişim_Belirleyiciler_ve_Kurucu_Fonksiyonlar
{
    internal class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public Calisan(string ad, string soyad, int no, string departman)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.No = no;
            this.Departman = departman;
        }
        public void CalisanBilgileriGoster()
        {
            Console.WriteLine("Çalışanın Adı :" + Ad);
            Console.WriteLine("Çalışanın Soyadı :" + Soyad);
            Console.WriteLine("Çalışanın Numarası :" + No);
            Console.WriteLine("çalışanın Departmanı :" + Departman);
        }
    }
}
