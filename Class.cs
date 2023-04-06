using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobil
{
    public class Class
    {
        private string Warna;
        private int Pintu;
        private string Merek;
        private string Model;
        private int Tahun;
        private int Cepat;
        private string Suara;

        public string warna
        {
            get
            {
                return Warna;
            }
            set
            {
                Warna = value;
            }
        }
        public int jumlahPintu
        {
            get
            {
                return Pintu;
            }
            set
            {
                Pintu = value;
            }
        }
        public string merek
        {
            get
            {
                return Merek;
            }
            set
            {
                Merek = value;
            }
        }
        public string model
        {
            get
            {
                return Model;
            }
            set
            {
                Model = value;
            }
        }
        public int tahunKeluaran
        {
            get
            {
                return Tahun;
            }
            set
            {
                Tahun = value;
            }
        }
        public int kecepatan
        {
            get
            {
                return Cepat;
            }
            set
            {
                Cepat = value;
            }
        }
        public string suara
        {
            get
            {
                return Suara;
            }
            set
            {
                Suara = value;
            }
        }

        public void Gas(int a)
        {
            Console.WriteLine("Mobil {0} berjalan dengan kecepatan {1}\n", model, a);
        }
        public void Klakson(string a)
        {
            Console.WriteLine("{0}\n", a);
        }
        public void TampilaknInfo()
        {
            Console.WriteLine("Mobil saya berwarna {0}, merek {1} model {2} keluaran tahun {3}" +
                "dengan jumlah pintu sebanyak {4}", warna, merek, model, tahunKeluaran, jumlahPintu);
        }
    }
}