using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace E_160420016_John_Tiket
{
    [Serializable]
    public abstract class JohnTiket
    {
        #region DATA FIELDS
        private string nomor;
        private DateTime tanggal;
        private string nomorKursi;
        private long harga;
        #endregion

        #region CONSTRUCTORS
        public JohnTiket(string nomor, DateTime tanggal, string nomorKursi, long harga)
        {
            this.Nomor = nomor;
            this.Tanggal = tanggal;
            this.NomorKursi = nomorKursi;
            this.Harga = harga;
        }
        #endregion

        #region PROPERTIES
        public string Nomor
        {
            get => nomor;
            set => nomor = value;
        }
        public DateTime Tanggal
        {
            get => tanggal;
            set
            {
                if (value >= DateTime.Now)
                {
                    tanggal = value;
                }
                else
                {
                    throw new ArgumentException("Tanggal keberangkatan setidaknya tanggal pada hari ini.");
                }
            }
        }
        public string NomorKursi { get => nomorKursi; set => nomorKursi = value; }
        public long Harga
        {
            get => harga;
            set
            {
                if (value > 0)
                {
                    harga = value;
                }
                else
                {
                    throw new ArgumentException("Harga tiket harus lebih dari nol.");
                }
            }
        }
        #endregion

        #region METHODS
        public abstract long HitungTotalBayar();

        public virtual string DisplayData()
        {
            return "No. Tiket : " + this.Nomor + "\n"
                + "Tanggal : " + this.Tanggal.ToString("dd'/'MM'/'yyyy hh:mm") + "\n"
                + "No. Kursi : " + this.NomorKursi + "\n";
        }

        public virtual long HitungPPN()
        {
            return 0;
        }
        #endregion
    }
}