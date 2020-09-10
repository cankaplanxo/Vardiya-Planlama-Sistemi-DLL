using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VardiyaDLL
{
    public class Personel
    {
        string kullaniciadi, sifre, adisoyadi,sicilno,vardiyasaat,durak;
        DateTime vardiyatarih;
        int kullaniciid;
        byte durumu;
        public string SicilNo
        {
            get { return sicilno; }
            set { sicilno = value; }
        }
        public string VardiyaSaati
        {
            get { return vardiyasaat; }
            set { vardiyasaat = value; }
        }

        public DateTime VardiyaTarihi
        {
            get { return vardiyatarih; }
            set { vardiyatarih = value; }
        }

        public string Durak
        {
            get { return durak; }
            set { durak = value; }
        }

        public byte Durumu
        {
            get { return durumu; }
            set { durumu = value; }
        }

    }
}
