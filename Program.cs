using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Mobil
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class mobil = new Class();

            mobil.warna = "kuning";
            mobil.jumlahPintu = 4;
            mobil.merek = "Honda";
            mobil.model = "Brio RS";
            mobil.tahunKeluaran = 2022;

            int kecepatan = mobil.kecepatan = 120;
            string suara = mobil.suara = "Tiitttt";

            mobil.Gas(kecepatan);
            mobil.Klakson(suara);
            mobil.TampilaknInfo();

            Console.ReadKey();
        }
    }
}