using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasPraktikum_1
{
    class pembayaran
    {
        public int HitungBayar (menuUtama menuUtama)
        {
            int biayaBarang = menuUtama.totalBayar * 100000;
            int jumlahTotal = biayaBarang + (menuUtama.hargaBarang * 100000);

            return jumlahTotal;
        }
    }
}
