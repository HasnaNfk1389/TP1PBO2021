using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasPraktikum_1
{
    class menuUtama
    {
        public string harga { get; set; }
        public string namaBarang { get; set; }
        public string nama { get; set; }
        public string tanggal { get; set; }
        public string jmlBarang { get; set; }
        public int totalBayar { get; set; }
        public int hargaBarang { get; set; }

        public menuUtama(string harga, string namaBarang, string nama, string tanggal, string jmlBayar, int totalBayar)
        {
            this.harga = harga;
            this.namaBarang = namaBarang;
            this.jmlBarang = jmlBarang;
            this.totalBayar = totalBayar;
        }

        public menuUtama() { }


        
    }
}
