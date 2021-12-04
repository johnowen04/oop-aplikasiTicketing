using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace E_160420016_John_Tiket
{
    [Serializable]
    public class JohnTiketBus : JohnTiket
    {
        #region DATA FIELDS
        private string tujuan;
        private bool makanMalam;
        #endregion

        #region CONSTRUCTORS
        public JohnTiketBus(string nomor, DateTime tanggal, string nomorKursi, long harga, string tujuan, bool makanMalam) : base(nomor, tanggal, nomorKursi, harga)
        {
            this.Tujuan = tujuan;
            this.MakanMalam = makanMalam;
        }
        #endregion

        #region PROPERTIES
        public string Tujuan { get => tujuan; set => tujuan = value; }
        public bool MakanMalam { get => makanMalam; set => makanMalam = value; }
        #endregion

        #region METHODS
        private string CekPesanMakanMalam()
        {
            if (this.MakanMalam)
                return "ya";
            else
                return "tidak";
        }

        public override long HitungPPN()
        {
            return (long) (0.15 * this.Harga);
        }

        public override long HitungTotalBayar()
        {
            if (this.MakanMalam)
                return this.Harga + this.HitungPPN() + 30000;
            else
                return this.Harga + this.HitungPPN();
        }

        public override string DisplayData()
        {
            return base.DisplayData()
                + "Tujuan : " + this.Tujuan + "\n"
                + "Harga : " + this.Harga + "\n"
                + "Pesan Makan Malam : " + this.CekPesanMakanMalam() + "\n"
                + "PPN : " + this.HitungPPN() + "\n"
                + "Total Bayar : " + this.HitungTotalBayar();
        }
        #endregion
    }
}