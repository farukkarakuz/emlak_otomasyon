using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakClasses
{
    public class KiralikEv : Ev
    {
        private string depozito;
        private int kira;


        public KiralikEv()
        {
            Yas = 2;
            OdaSayisi = 3;
            KatNumarasi = 1;
            Semti = "Yazır Mahallesi";
            Alan = "40";
            YapimTarihi = DateTime.Now;
            Aktif = false;
            EmlakNumarasi = sonraki_id();
            Turu = EvTuru.Daire;
            Satisturu = "Kiralık";
            depozito = "2500";
            kira = 12500;
        }

        public KiralikEv(int odaSayisi, int katNumarasi, string semti, string alan, DateTime yapimTarihi, bool aktif, EvTuru turu, string satisturu, string depozito)
        : base(odaSayisi, katNumarasi, semti, alan, yapimTarihi, aktif, turu, satisturu)
        {
            Yas = ev_yas_hesapla();
            this.depozito = depozito;
            this.kira = KiraHesapla();
        }

        public string Depozito
        {
            get { return depozito; } set { depozito = value; }
        }

        public int Kira
        {
            get { return kira; }
            set { kira = value; }
        }

        public int KiraHesapla()
        {
            if (File.Exists("room_cost.txt"))
            {
                string[] katsayi = File.ReadAllLines("room_cost.txt");
                int katsayi2 = Convert.ToInt32(katsayi[0]);
                return katsayi2 * OdaSayisi;
            }
            else
            {
                return 3000 * OdaSayisi; // varsayılan katsayı ile çarpım
            }
        }


        public string EvBilgileri()
        {
            return string.Format(
                "Emlak Numarası: {0}\n" +
                "Oda Sayısı: {1}\n" +
                "Kat Numarası: {2}\n" +
                "Semti: {3}\n" +
                "Alan: {4} m²\n" +
                "Yapım Tarihi: {5:dd.MM.yyyy}\n" +
                "Aktif: {6}\n" +
                "Türü: {7}\n" +
                "Satış Türü: {8}\n" +
                "Depozito: {9} TL\n" +
                "Kira: {10} TL\n" +
                "Ev Yaşı: {11}",
                EmlakNumarasi,
                OdaSayisi,
                KatNumarasi,
                Semti,
                Alan,
                YapimTarihi,
                Aktif ? "Evet, işlem yapıldı" : "Hayır, işlem yapılmadı.",
                Turu,
                Satisturu,
                Depozito,
                Kira,
                Yas
            );
        }

        public void TxtFormatYazdir()
        {
            using (StreamWriter sw = new StreamWriter("kiralik.txt",true))
            {
                sw.WriteLine($"{EmlakNumarasi},{OdaSayisi},{KatNumarasi},{Semti},{Alan},{YapimTarihi:dd.MM.yyyy},{Aktif},{Turu},{Satisturu},{Depozito},{Kira},{Yas}");
            }
        }

    }
}
