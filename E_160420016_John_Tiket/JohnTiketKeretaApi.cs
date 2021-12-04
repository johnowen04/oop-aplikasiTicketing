using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace E_160420016_John_Tiket
{
    [Serializable]
    public class JohnTiketKeretaApi : JohnTiket
    {
        #region DATA FIELDS
        private string stasiun;
        #endregion
        
        #region CONSTRUCTORS
        public JohnTiketKeretaApi(string nomor, DateTime tanggal, string nomorKursi, long harga, string stasiun) : base(nomor, tanggal, nomorKursi, harga)
        {
            this.Stasiun = stasiun;
        }
        #endregion

        #region PROPERTIES
        public string Stasiun { get => stasiun; set => stasiun = value; }
        #endregion

        #region METHODS
        public override long HitungTotalBayar()
        {
            return this.Harga;
        }

        public override string DisplayData()
        {
            return base.DisplayData()
                + "Stasiun : " + this.Stasiun + "\n"
                + "Harga : " + this.Harga + "\n"
                + "Total Bayar : " + this.HitungTotalBayar();
        }
        #endregion
    }
}