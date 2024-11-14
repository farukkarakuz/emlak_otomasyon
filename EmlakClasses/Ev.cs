using System;
using System.IO;


public class Ev
{
    private static readonly string emlakidpath = "emlakNumarasi.txt"; 
    private int yas;
    private int odaSayisi;
    private string satisturu;
    private int katNumarasi;
    private string semti;
    private string alan;
    private DateTime yapimTarihi;
    private bool aktif;
    private int emlakNumarasi;
    private EvTuru turu;

    public Ev()
    {
        yas = 2;
        odaSayisi = 3;
        katNumarasi = 1;
        semti = "Horozluhan Mahallesi";
        alan = "40";
        yapimTarihi = DateTime.Now;
        aktif = false;
        emlakNumarasi = sonraki_id();
        turu = EvTuru.Daire;
        satisturu = "Kiralık";
    }

    public Ev(int odaSayisi, int katNumarasi, string semti, string alan, DateTime yapimTarihi, bool aktif, EvTuru turu,string satisturu)
    {
        this.odaSayisi = odaSayisi;
        this.katNumarasi = katNumarasi;
        this.semti = semti;
        this.alan = alan;
        this.yapimTarihi = yapimTarihi;
        this.yas = ev_yas_hesapla();
        this.aktif = aktif;
        this.emlakNumarasi = sonraki_id(); // Burada 'emlakNumarasi' parametre yok, bu yüzden 'this' gerekmez
        this.turu = turu;
        this.satisturu = satisturu;
    }
    public string EvBilgileri()
    {
        return string.Format(
            "Emlak Numarası: {0}\nTürü: {1}\nSatış Türü:{9}\nOda Sayısı: {2}\nKat Numarası: {3}\nSemti: {4}\nAlan: {5} m²\nYapım Tarihi: {6:dd.MM.yyyy}\nEv yaşı:{7} \nAktif: {8}",
            EmlakNumarasi,
            Turu,
            OdaSayisi,
            KatNumarasi,
            Semti,
            Alan,
            YapimTarihi,
            Yas,
            Aktif ? "Evet, işlem yapıldı" : "Hayır, işlem yapılmadı.",
            Satisturu
        );
    }


    public enum EvTuru
    {
        Daire,
        Bahceli,
        Dubleks,
        Mustakil,
        Triplex,
        Ofis
    }

    public string Satisturu
    {
        get { return satisturu; }
        set { satisturu = value; }
    }

    public int OdaSayisi
    {
        get { return odaSayisi; }
        set { odaSayisi = value > 0 ? value : 0; }
    }

    public int Yas
    {
        get { return yas; }
        set { yas = ev_yas_hesapla(); } // Sadece sınıf içinde ayarlanabilir
    }

    public int KatNumarasi
    {
        get { return katNumarasi; }
        set { katNumarasi = value > 0 ? value : 0; }
    }

    public string Semti
    {
        get { return semti; }
        set { semti = value; }
    }

    public string Alan
    {
        get { return alan; }
        set { alan = value; }
    }

    public DateTime YapimTarihi
    {
        get { return yapimTarihi; }
        set
        {
            yapimTarihi = value;
            ev_yas_hesapla(); // yapım tarihi değişirse tekrardan hesaplaması için
        }
    }

    public bool Aktif
    {
        get { return aktif; }
        set { aktif = value; }
    }

    public int EmlakNumarasi
    {
        get { return emlakNumarasi; }
        set { emlakNumarasi = value; }
    }

    public EvTuru Turu
    {
        get { return turu; }
        set { turu = value; }
    }

    // Evin yaşını hesaplayan metot
    protected int ev_yas_hesapla()
    {
        DateTime bugun = DateTime.Today;

        int hesaplananYas = bugun.Year - yapimTarihi.Year;

        if (bugun < yapimTarihi.AddYears(hesaplananYas)) // eğerki yapım tarihinin ayı bugünkü tarihinden ayından büyükse yastan 1 azaltılır çünkü daha tam 2 yaşına basmadı
        {
            hesaplananYas--;
        }

        return hesaplananYas;
    }

    // Benzersiz emlak numarası oluşturma metodu
    protected int sonraki_id()
    {
        int son_id = 0;

        if (File.Exists(emlakidpath))
        {
            string idText = File.ReadAllText(emlakidpath);
            int.TryParse(idText, out son_id);
        }

        int sonraki_id = son_id + 1;

        File.WriteAllText(emlakidpath, sonraki_id.ToString());

        return sonraki_id;
    }
}
