using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VardiyaDLL
{

    public class Admin
    {
        string kullaniciadi, sifre, adisoyadi;
        DateTime sistemegiris, kayittarihi;
        int kullaniciid;
        byte durumu;
        public string KullaniciAdi
        {
            get { return kullaniciadi; }
            set { kullaniciadi = value; }
        }
        public string Sifre
        {
            get { return sifre; }
            set { sifre = value; }
        }

        public int KullaniciID
        {
            get { return kullaniciid; }
            set { kullaniciid = value; }
        }

        public string AdiSoyadi
        {
            get { return adisoyadi; }
            set { adisoyadi = value; }
        }

        public byte Durumu
        {
            get { return durumu; }
            set { durumu = value; }
        }

        public DateTime KayitTarihi
        {
            get { return kayittarihi; }
            set { kayittarihi = value; }
        }
        public DateTime SistemGiris
        {
            get { return sistemegiris; }
            set { sistemegiris = value; }
        }
    }

}
