using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakClasses
{
    public class SatilikEv : Ev
    {
        private string fiyat;

        public SatilikEv()
        {
            Yas = 2;
            OdaSayisi = 3;
            KatNumarasi = 1;
            Semti = "Bosna Hersek Mahallesi";
            Alan = "40";
            YapimTarihi = DateTime.Now;
            Aktif = false;
            EmlakNumarasi = sonraki_id();
            Turu = EvTuru.Daire;
            Satisturu = "Satılık";
            fiyat = "2000000";
        }

        public SatilikEv(int odaSayisi, int katNumarasi, string semti, string alan, DateTime yapimTarihi, bool aktif, EvTuru turu, string satisturu, string fiyat)
        : base(odaSayisi, katNumarasi, semti, alan, yapimTarihi, aktif, turu, satisturu)
        {
            Yas = ev_yas_hesapla();
            this.fiyat = fiyat;

        }

        public string Fiyat
        {
            get { return fiyat; }
            set { fiyat = value; }
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
                "Fiyat: {9} TL\n" +
                "Ev Yaşı: {10}",
                EmlakNumarasi,
                OdaSayisi,
                KatNumarasi,
                Semti,
                Alan,
                YapimTarihi,
                Aktif ? "Evet, işlem yapıldı" : "Hayır, işlem yapılmadı.",
                Turu,
                Satisturu,
                Fiyat,
                Yas
            );
        }

        public void TxtFormatYazdir()
        {
            using (StreamWriter sw = new StreamWriter("satilik.txt",true))
            {
                sw.WriteLine($"{EmlakNumarasi},{OdaSayisi},{KatNumarasi},{Semti},{Alan},{YapimTarihi:dd.MM.yyyy},{Aktif},{Turu},{Satisturu},{Fiyat},{Yas}");
            }
        }
    }
}
