using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace E_160420016_John_Tiket
{
    public partial class FormAddTicket : Form
    {
        private FormMenu formMenu;
        private string dateTimeFormat = "dd/MM/yyyy hh:mm";
        private int ticketCounter;

        public FormAddTicket()
        {
            InitializeComponent();
        }

        private void FormAddTicket_Load(object sender, EventArgs e)
        {
            formMenu = (FormMenu)this.Owner;
            ticketCounter = formMenu.listOfTickets.Count();

            radioButtonTiketBus.Checked = true;
            radioButtonTiketKeretaApi.Checked = false;
            radioButtonTiketPesawat.Checked = false;

            dateTimePickerTanggalDanJamTiket.Format = DateTimePickerFormat.Custom;
            dateTimePickerTanggalDanJamTiket.CustomFormat = dateTimeFormat;

            PopulateNomorKursi(comboBoxNomorKursiBus, comboBoxNomorKursiKeretaApi, comboBoxNomorKursiPesawat);
            PopulateStasiunKeretaApi(comboBoxStasiunAsalKeretaApi, comboBoxStasiunTujuanKeretaApi);
            PopulateKotaPesawat(comboBoxKotaAsalPesawat, comboBoxKotaTujuanPesawat);
            PopulateKelasPesawat(comboBoxKelasPesawat);

            radioButtonPesanMakanMalam.Checked = true;

        }

        private void radioButtonTiketBus_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxTiketBus.Enabled = true;
            groupBoxTiketKeretaApi.Enabled = false;
            groupBoxTiketPesawat.Enabled = false;
        }

        private void radioButtonTiketKeretaApi_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxTiketBus.Enabled = false;
            groupBoxTiketKeretaApi.Enabled = true;
            groupBoxTiketPesawat.Enabled = false;
        }

        private void radioButtonTiketPesawat_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxTiketBus.Enabled = false;
            groupBoxTiketKeretaApi.Enabled = false;
            groupBoxTiketPesawat.Enabled = true;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            if (radioButtonTiketBus.Checked)
            {
                comboBoxNomorKursiBus.SelectedIndex = 0;
                textBoxKotaTujuanBus.Text = "";
                radioButtonPesanMakanMalam.Checked = true;
                textBoxHargaTiketBus.Text = "";
            }
            else if (radioButtonTiketKeretaApi.Checked)
            {
                comboBoxNomorKursiKeretaApi.SelectedIndex = 0;
                comboBoxStasiunAsalKeretaApi.SelectedIndex = 0;
                comboBoxStasiunTujuanKeretaApi.SelectedIndex = 1;
                textBoxHargaTiketKeretaApi.Text = "";
            }
            else
            {
                comboBoxNomorKursiPesawat.SelectedIndex = 0;
                comboBoxKotaAsalPesawat.SelectedIndex = 0;
                comboBoxKotaTujuanPesawat.SelectedIndex = 1;
                textBoxNomorPenerbangan.Text = "";
                textBoxHargaTiketPesawat.Text = "";
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            SaveData(formMenu.listOfTickets);
            this.Close();
        }

        private void PopulateNomorKursi(ComboBox comboBoxBus, ComboBox comboBoxKeretaApi, ComboBox comboBoxPesawat)
        {
			comboBoxBus.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBoxBus.IntegralHeight = false;
			comboBoxBus.MaxDropDownItems = 10;

			List<string> nomorKursiBus = new List<string>();

			for (int i = 1; i <= 30; i++)
			{
				nomorKursiBus.Add(i + "A");
				nomorKursiBus.Add(i + "B");
			}

			comboBoxBus.DataSource = nomorKursiBus;
			
			comboBoxKeretaApi.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBoxKeretaApi.IntegralHeight = false;
			comboBoxKeretaApi.MaxDropDownItems = 10;

			List<string> nomorKursiKeretaApi = new List<string>();
			string temp = "";

			for (int i = 1; i <= 2; i++)
			{
				for (int j = 1; j <= 15; j++)
				{
					temp = "Gerbong " + i + " - " + j + "A";
					nomorKursiKeretaApi.Add(temp);

					temp = "Gerbong " + i + " - " + j + "B";
					nomorKursiKeretaApi.Add(temp);

					temp = "Gerbong " + i + " - " + j + "C";
					nomorKursiKeretaApi.Add(temp);
				}
			}

			comboBoxKeretaApi.DataSource = nomorKursiKeretaApi;
			
			comboBoxPesawat.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBoxPesawat.IntegralHeight = false;
			comboBoxPesawat.MaxDropDownItems = 10;

			List<string> nomorKursiPesawat = new List<string>();

			for (int i = 1; i <= 20; i++)
			{
				nomorKursiPesawat.Add(i + "A");
				nomorKursiPesawat.Add(i + "B");
				nomorKursiPesawat.Add(i + "C");
				nomorKursiPesawat.Add(i + "D");
			}

			comboBoxPesawat.DataSource = nomorKursiPesawat;
            
        }

        private void PopulateStasiunKeretaApi(ComboBox comboBoxStasiunAsal, ComboBox comboBoxStasiunTujuan)
        {
            comboBoxStasiunAsal.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStasiunAsal.IntegralHeight = false;
            comboBoxStasiunAsal.MaxDropDownItems = 10;

            comboBoxStasiunTujuan.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStasiunTujuan.IntegralHeight = false;
            comboBoxStasiunTujuan.MaxDropDownItems = 10;

            List<string> stasiunAsal = new List<string>();

            stasiunAsal.Add("Surabaya Gubeng");
            stasiunAsal.Add("Surabaya Pasar Turi");
            stasiunAsal.Add("Lamongan Lamongan");
            stasiunAsal.Add("Yogyakarta Tugu");
            stasiunAsal.Add("Yogyakarta Yogyakarta");
            stasiunAsal.Add("Yogyakarta Lempuyangan");
            stasiunAsal.Add("Yogyakarta Klaten");
            stasiunAsal.Add("Babat Babat");
            stasiunAsal.Add("Jakarta Gambir");
            stasiunAsal.Add("Jakarta Pasar Senen");
            stasiunAsal.Add("Jakarta Manggarai");
            stasiunAsal.Add("Jakarta Mangga Besar");
            stasiunAsal.Add("Bandung Bandung");
            stasiunAsal.Add("Semarang Tawang");
            stasiunAsal.Add("Semarang Poncol");

            List<string> stasiunTujuan = new List<string>(stasiunAsal);

            comboBoxStasiunAsal.DataSource = stasiunAsal;
            comboBoxStasiunTujuan.DataSource = stasiunTujuan;

            comboBoxStasiunAsal.SelectedIndex = 0;
            comboBoxStasiunTujuan.SelectedIndex = 1;
        }

        private void PopulateKotaPesawat(ComboBox comboBoxKotaAsal, ComboBox comboBoxKotaTujuan)
        {
            comboBoxKotaAsal.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxKotaAsal.IntegralHeight = false;
            comboBoxKotaAsal.MaxDropDownItems = 10;

            comboBoxKotaTujuan.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxKotaTujuan.IntegralHeight = false;
            comboBoxKotaTujuan.MaxDropDownItems = 10;

            List<string> kotaAsal = new List<string>();

            kotaAsal.Add("SUB");
            kotaAsal.Add("JKT");
            kotaAsal.Add("YOG");
            kotaAsal.Add("SMG");
            kotaAsal.Add("BDG");
            kotaAsal.Add("BLI");
            kotaAsal.Add("MDN");

            List<string> kotaTujuan = new List<string>(kotaAsal);

            comboBoxKotaAsal.DataSource = kotaAsal;
            comboBoxKotaTujuan.DataSource = kotaTujuan;

            comboBoxKotaAsal.SelectedIndex = 0;
            comboBoxKotaTujuan.SelectedIndex = 1;
        }

        private void PopulateKelasPesawat(ComboBox comboBoxKelas)
        {
            comboBoxKelas.DropDownStyle = ComboBoxStyle.DropDownList;

            List<string> kelas = new List<string>();

            kelas.Add("Ekonomi");
            kelas.Add("Bisnis");

            comboBoxKelas.DataSource = kelas;
        }

        private void SaveData(List<JohnTiket> listOfTickets)
        {
            try
            {
                FileStream fileStream = new FileStream(formMenu.filename, FileMode.Create, FileAccess.Write);

                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fileStream, formMenu.listOfTickets);

                fileStream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAddTicket_Click(object sender, EventArgs e)
        {
            try
            {
                ticketCounter += 1;
                DateTime tanggal = dateTimePickerTanggalDanJamTiket.Value;
                string nomorTiket = tanggal.ToString("yyyy''MM''dd");
                
                if (ticketCounter < 10)
                {
                    nomorTiket += "00" + ticketCounter;
                }
                else if (ticketCounter < 100)
                {
                    nomorTiket += "0" + ticketCounter;
                }


                if (radioButtonTiketBus.Checked)
                {
                    string nomorKursi = comboBoxNomorKursiBus.Text;
                    string kotaTujuan = textBoxKotaTujuanBus.Text;
                    int hargaTiket = int.Parse(textBoxHargaTiketBus.Text);

                    bool pesanMakanMalam = false;

                    if (radioButtonPesanMakanMalam.Checked)
                    {
                        pesanMakanMalam = true;
                    }

                    JohnTiketBus tiketBus = new JohnTiketBus(nomorTiket, tanggal, nomorKursi, hargaTiket, kotaTujuan, pesanMakanMalam);
                    formMenu.listOfTickets.Add(tiketBus);
                    listBoxData.Items.AddRange(tiketBus.DisplayData().Split('\n'));
                }
                else if (radioButtonTiketKeretaApi.Checked)
                {
                    string nomorKursi = comboBoxNomorKursiKeretaApi.Text;
                    int hargaTiket = int.Parse(textBoxHargaTiketKeretaApi.Text);

                    string stasiun = comboBoxStasiunAsalKeretaApi.Text + " - " + comboBoxStasiunTujuanKeretaApi.Text;

                    JohnTiketKeretaApi tiketKeretaApi = new JohnTiketKeretaApi(nomorTiket, tanggal, nomorKursi, hargaTiket, stasiun);
                    formMenu.listOfTickets.Add(tiketKeretaApi);
                    listBoxData.Items.AddRange(tiketKeretaApi.DisplayData().Split('\n'));
                }
                else
                {
                    string nomorKursi = comboBoxNomorKursiPesawat.Text;
                    string nomorPenerbangan = textBoxNomorPenerbangan.Text;
                    string kota = comboBoxKotaAsalPesawat.Text + " - " + comboBoxKotaTujuanPesawat.Text;
                    int hargaTiket = int.Parse(textBoxHargaTiketPesawat.Text);
                    string kelas = comboBoxKelasPesawat.Text;

                    JohnTiketPesawat tiketPesawat = new JohnTiketPesawat(nomorTiket, tanggal, nomorKursi, hargaTiket, nomorPenerbangan, kota, kelas);
                    formMenu.listOfTickets.Add(tiketPesawat);
                    listBoxData.Items.AddRange(tiketPesawat.DisplayData().Split('\n'));
                }

                listBoxData.Items.Add("");

                SaveData(formMenu.listOfTickets);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
