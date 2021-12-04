using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace E_160420016_John_Tiket
{
    [Serializable]
    public class JohnTiketPesawat : JohnTiket
    {
        #region DATA FIELDS
        private string nomorPenerbangan;
        private string kota;
        private string kelas;
        #endregion

        #region CONSTRUCTORS
        public JohnTiketPesawat(string nomor, DateTime tanggal, string nomorKursi, long harga, string nomorPenerbangan, string kota, string kelas) : base(nomor, tanggal, nomorKursi, harga)
        {
            this.NomorPenerbangan = nomorPenerbangan;
            this.Kota = kota;
            this.Kelas = kelas;
        }
        #endregion

        #region PROPERTIES
        public string NomorPenerbangan
        {
            get => nomorPenerbangan;
            set => nomorPenerbangan = value;
        }
        public string Kota
        {
            get => kota;
            set => kota = value;
        }
        public string Kelas
        {
            get => kelas;
            set => kelas = value;
        }
        #endregion

        #region METHODS
        public long HitungConvenienceFee()
        {
            if (this.Kelas is "Bisnis")
            {
                return (long) (0.5 * this.Harga);
            }
            else
            {
                return 0;
            }
        }

        public override long HitungPPN()
        {
            return (long) (0.1 * this.Harga);
        }

        public override long HitungTotalBayar()
        {
            return this.Harga + this.HitungConvenienceFee() + this.HitungPPN();
        }

        public override string DisplayData()
        {
            return base.DisplayData()
                + "Nomor Penerbangan : " + this.NomorPenerbangan + "\n"
                + "Kota : " + this.Kota + "\n"
                + "Kelas : " + this.Kelas + "\n"
                + "Harga : " + this.Harga + "\n"
                + "PPN : " + this.HitungPPN() + "\n"
                + "Convenience Fee : " + this.HitungConvenienceFee() + "\n"
                + "Total Bayar : " + this.HitungTotalBayar();
        }
        #endregion
    }
}