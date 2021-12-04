
namespace E_160420016_John_Tiket
{
    partial class FormAddTicket
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonTiketPesawat = new System.Windows.Forms.RadioButton();
            this.radioButtonTiketKeretaApi = new System.Windows.Forms.RadioButton();
            this.radioButtonTiketBus = new System.Windows.Forms.RadioButton();
            this.groupBoxTiketBus = new System.Windows.Forms.GroupBox();
            this.comboBoxNomorKursiBus = new System.Windows.Forms.ComboBox();
            this.textBoxKotaTujuanBus = new System.Windows.Forms.TextBox();
            this.textBoxHargaTiketBus = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButtonTidakPesanMakanMalam = new System.Windows.Forms.RadioButton();
            this.radioButtonPesanMakanMalam = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerTanggalDanJamTiket = new System.Windows.Forms.DateTimePicker();
            this.groupBoxTiketKeretaApi = new System.Windows.Forms.GroupBox();
            this.comboBoxStasiunTujuanKeretaApi = new System.Windows.Forms.ComboBox();
            this.comboBoxStasiunAsalKeretaApi = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxNomorKursiKeretaApi = new System.Windows.Forms.ComboBox();
            this.textBoxHargaTiketKeretaApi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBoxTiketPesawat = new System.Windows.Forms.GroupBox();
            this.textBoxNomorPenerbangan = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBoxKotaTujuanPesawat = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxNomorKursiPesawat = new System.Windows.Forms.ComboBox();
            this.comboBoxKotaAsalPesawat = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.listBoxData = new System.Windows.Forms.ListBox();
            this.label15 = new System.Windows.Forms.Label();
            this.buttonAddTicket = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.textBoxHargaTiketPesawat = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.comboBoxKelasPesawat = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBoxTiketBus.SuspendLayout();
            this.groupBoxTiketKeretaApi.SuspendLayout();
            this.groupBoxTiketPesawat.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonTiketPesawat);
            this.groupBox1.Controls.Add(this.radioButtonTiketKeretaApi);
            this.groupBox1.Controls.Add(this.radioButtonTiketBus);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(753, 44);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Jenis Tiket";
            // 
            // radioButtonTiketPesawat
            // 
            this.radioButtonTiketPesawat.AutoSize = true;
            this.radioButtonTiketPesawat.Location = new System.Drawing.Point(527, 19);
            this.radioButtonTiketPesawat.Name = "radioButtonTiketPesawat";
            this.radioButtonTiketPesawat.Size = new System.Drawing.Size(93, 17);
            this.radioButtonTiketPesawat.TabIndex = 2;
            this.radioButtonTiketPesawat.TabStop = true;
            this.radioButtonTiketPesawat.Text = "Tiket Pesawat";
            this.radioButtonTiketPesawat.UseVisualStyleBackColor = true;
            this.radioButtonTiketPesawat.CheckedChanged += new System.EventHandler(this.radioButtonTiketPesawat_CheckedChanged);
            // 
            // radioButtonTiketKeretaApi
            // 
            this.radioButtonTiketKeretaApi.AutoSize = true;
            this.radioButtonTiketKeretaApi.Location = new System.Drawing.Point(238, 17);
            this.radioButtonTiketKeretaApi.Name = "radioButtonTiketKeretaApi";
            this.radioButtonTiketKeretaApi.Size = new System.Drawing.Size(101, 17);
            this.radioButtonTiketKeretaApi.TabIndex = 1;
            this.radioButtonTiketKeretaApi.TabStop = true;
            this.radioButtonTiketKeretaApi.Text = "Tiket Kereta Api";
            this.radioButtonTiketKeretaApi.UseVisualStyleBackColor = true;
            this.radioButtonTiketKeretaApi.CheckedChanged += new System.EventHandler(this.radioButtonTiketKeretaApi_CheckedChanged);
            // 
            // radioButtonTiketBus
            // 
            this.radioButtonTiketBus.AutoSize = true;
            this.radioButtonTiketBus.Location = new System.Drawing.Point(13, 17);
            this.radioButtonTiketBus.Name = "radioButtonTiketBus";
            this.radioButtonTiketBus.Size = new System.Drawing.Size(70, 17);
            this.radioButtonTiketBus.TabIndex = 0;
            this.radioButtonTiketBus.TabStop = true;
            this.radioButtonTiketBus.Text = "Tiket Bus";
            this.radioButtonTiketBus.UseVisualStyleBackColor = true;
            this.radioButtonTiketBus.CheckedChanged += new System.EventHandler(this.radioButtonTiketBus_CheckedChanged);
            // 
            // groupBoxTiketBus
            // 
            this.groupBoxTiketBus.Controls.Add(this.comboBoxNomorKursiBus);
            this.groupBoxTiketBus.Controls.Add(this.textBoxKotaTujuanBus);
            this.groupBoxTiketBus.Controls.Add(this.textBoxHargaTiketBus);
            this.groupBoxTiketBus.Controls.Add(this.label5);
            this.groupBoxTiketBus.Controls.Add(this.radioButtonTidakPesanMakanMalam);
            this.groupBoxTiketBus.Controls.Add(this.radioButtonPesanMakanMalam);
            this.groupBoxTiketBus.Controls.Add(this.label4);
            this.groupBoxTiketBus.Controls.Add(this.label3);
            this.groupBoxTiketBus.Controls.Add(this.label2);
            this.groupBoxTiketBus.Location = new System.Drawing.Point(12, 106);
            this.groupBoxTiketBus.Name = "groupBoxTiketBus";
            this.groupBoxTiketBus.Size = new System.Drawing.Size(197, 181);
            this.groupBoxTiketBus.TabIndex = 1;
            this.groupBoxTiketBus.TabStop = false;
            this.groupBoxTiketBus.Text = "Detil Tiket Bus";
            // 
            // comboBoxNomorKursiBus
            // 
            this.comboBoxNomorKursiBus.FormattingEnabled = true;
            this.comboBoxNomorKursiBus.Items.AddRange(new object[] {
            "1A",
            "1B",
            "2A",
            "2B",
            "3A",
            "3B",
            "4A",
            "4B",
            "5A",
            "5B",
            "6A",
            "6B",
            "7A",
            "7B",
            "8A",
            "8B",
            "9A",
            "9B",
            "10A",
            "10B",
            "11A",
            "11B",
            "12A",
            "12B",
            "13A",
            "13B",
            "14A",
            "14B",
            "15A",
            "15B",
            "16A",
            "16B",
            "17A",
            "17B",
            "18A",
            "18B",
            "19A",
            "19B",
            "20A",
            "20B"});
            this.comboBoxNomorKursiBus.Location = new System.Drawing.Point(85, 20);
            this.comboBoxNomorKursiBus.Name = "comboBoxNomorKursiBus";
            this.comboBoxNomorKursiBus.Size = new System.Drawing.Size(102, 21);
            this.comboBoxNomorKursiBus.TabIndex = 8;
            // 
            // textBoxKotaTujuanBus
            // 
            this.textBoxKotaTujuanBus.Location = new System.Drawing.Point(85, 55);
            this.textBoxKotaTujuanBus.Name = "textBoxKotaTujuanBus";
            this.textBoxKotaTujuanBus.Size = new System.Drawing.Size(102, 20);
            this.textBoxKotaTujuanBus.TabIndex = 7;
            // 
            // textBoxHargaTiketBus
            // 
            this.textBoxHargaTiketBus.Location = new System.Drawing.Point(85, 140);
            this.textBoxHargaTiketBus.Name = "textBoxHargaTiketBus";
            this.textBoxHargaTiketBus.Size = new System.Drawing.Size(102, 20);
            this.textBoxHargaTiketBus.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Harga Tiket :";
            // 
            // radioButtonTidakPesanMakanMalam
            // 
            this.radioButtonTidakPesanMakanMalam.AutoSize = true;
            this.radioButtonTidakPesanMakanMalam.Location = new System.Drawing.Point(100, 109);
            this.radioButtonTidakPesanMakanMalam.Name = "radioButtonTidakPesanMakanMalam";
            this.radioButtonTidakPesanMakanMalam.Size = new System.Drawing.Size(48, 17);
            this.radioButtonTidakPesanMakanMalam.TabIndex = 4;
            this.radioButtonTidakPesanMakanMalam.TabStop = true;
            this.radioButtonTidakPesanMakanMalam.Text = "tidak";
            this.radioButtonTidakPesanMakanMalam.UseVisualStyleBackColor = true;
            // 
            // radioButtonPesanMakanMalam
            // 
            this.radioButtonPesanMakanMalam.AutoSize = true;
            this.radioButtonPesanMakanMalam.Location = new System.Drawing.Point(33, 109);
            this.radioButtonPesanMakanMalam.Name = "radioButtonPesanMakanMalam";
            this.radioButtonPesanMakanMalam.Size = new System.Drawing.Size(36, 17);
            this.radioButtonPesanMakanMalam.TabIndex = 3;
            this.radioButtonPesanMakanMalam.TabStop = true;
            this.radioButtonPesanMakanMalam.Text = "ya";
            this.radioButtonPesanMakanMalam.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Pesan Makan Malam/Tidak :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kota Tujuan :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nomor Kursi :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tanggal dan Jam Tiket :";
            // 
            // dateTimePickerTanggalDanJamTiket
            // 
            this.dateTimePickerTanggalDanJamTiket.Location = new System.Drawing.Point(139, 72);
            this.dateTimePickerTanggalDanJamTiket.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerTanggalDanJamTiket.Name = "dateTimePickerTanggalDanJamTiket";
            this.dateTimePickerTanggalDanJamTiket.Size = new System.Drawing.Size(626, 20);
            this.dateTimePickerTanggalDanJamTiket.TabIndex = 3;
            // 
            // groupBoxTiketKeretaApi
            // 
            this.groupBoxTiketKeretaApi.Controls.Add(this.comboBoxStasiunTujuanKeretaApi);
            this.groupBoxTiketKeretaApi.Controls.Add(this.comboBoxStasiunAsalKeretaApi);
            this.groupBoxTiketKeretaApi.Controls.Add(this.label7);
            this.groupBoxTiketKeretaApi.Controls.Add(this.comboBoxNomorKursiKeretaApi);
            this.groupBoxTiketKeretaApi.Controls.Add(this.textBoxHargaTiketKeretaApi);
            this.groupBoxTiketKeretaApi.Controls.Add(this.label6);
            this.groupBoxTiketKeretaApi.Controls.Add(this.label8);
            this.groupBoxTiketKeretaApi.Controls.Add(this.label9);
            this.groupBoxTiketKeretaApi.Location = new System.Drawing.Point(237, 106);
            this.groupBoxTiketKeretaApi.Name = "groupBoxTiketKeretaApi";
            this.groupBoxTiketKeretaApi.Size = new System.Drawing.Size(265, 181);
            this.groupBoxTiketKeretaApi.TabIndex = 6;
            this.groupBoxTiketKeretaApi.TabStop = false;
            this.groupBoxTiketKeretaApi.Text = "Detil Tiket Kereta Api";
            // 
            // comboBoxStasiunTujuanKeretaApi
            // 
            this.comboBoxStasiunTujuanKeretaApi.FormattingEnabled = true;
            this.comboBoxStasiunTujuanKeretaApi.Location = new System.Drawing.Point(96, 99);
            this.comboBoxStasiunTujuanKeretaApi.Name = "comboBoxStasiunTujuanKeretaApi";
            this.comboBoxStasiunTujuanKeretaApi.Size = new System.Drawing.Size(153, 21);
            this.comboBoxStasiunTujuanKeretaApi.TabIndex = 13;
            // 
            // comboBoxStasiunAsalKeretaApi
            // 
            this.comboBoxStasiunAsalKeretaApi.FormattingEnabled = true;
            this.comboBoxStasiunAsalKeretaApi.Location = new System.Drawing.Point(96, 59);
            this.comboBoxStasiunAsalKeretaApi.Name = "comboBoxStasiunAsalKeretaApi";
            this.comboBoxStasiunAsalKeretaApi.Size = new System.Drawing.Size(153, 21);
            this.comboBoxStasiunAsalKeretaApi.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Stasiun Tujuan :";
            // 
            // comboBoxNomorKursiKeretaApi
            // 
            this.comboBoxNomorKursiKeretaApi.FormattingEnabled = true;
            this.comboBoxNomorKursiKeretaApi.Location = new System.Drawing.Point(96, 19);
            this.comboBoxNomorKursiKeretaApi.Name = "comboBoxNomorKursiKeretaApi";
            this.comboBoxNomorKursiKeretaApi.Size = new System.Drawing.Size(153, 21);
            this.comboBoxNomorKursiKeretaApi.TabIndex = 10;
            // 
            // textBoxHargaTiketKeretaApi
            // 
            this.textBoxHargaTiketKeretaApi.Location = new System.Drawing.Point(96, 139);
            this.textBoxHargaTiketKeretaApi.Name = "textBoxHargaTiketKeretaApi";
            this.textBoxHargaTiketKeretaApi.Size = new System.Drawing.Size(153, 20);
            this.textBoxHargaTiketKeretaApi.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Harga Tiket :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Stasiun Asal :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Nomor Kursi :";
            // 
            // groupBoxTiketPesawat
            // 
            this.groupBoxTiketPesawat.Controls.Add(this.comboBoxKelasPesawat);
            this.groupBoxTiketPesawat.Controls.Add(this.textBoxHargaTiketPesawat);
            this.groupBoxTiketPesawat.Controls.Add(this.label16);
            this.groupBoxTiketPesawat.Controls.Add(this.textBoxNomorPenerbangan);
            this.groupBoxTiketPesawat.Controls.Add(this.label14);
            this.groupBoxTiketPesawat.Controls.Add(this.comboBoxKotaTujuanPesawat);
            this.groupBoxTiketPesawat.Controls.Add(this.label10);
            this.groupBoxTiketPesawat.Controls.Add(this.comboBoxNomorKursiPesawat);
            this.groupBoxTiketPesawat.Controls.Add(this.comboBoxKotaAsalPesawat);
            this.groupBoxTiketPesawat.Controls.Add(this.label11);
            this.groupBoxTiketPesawat.Controls.Add(this.label12);
            this.groupBoxTiketPesawat.Controls.Add(this.label13);
            this.groupBoxTiketPesawat.Location = new System.Drawing.Point(528, 106);
            this.groupBoxTiketPesawat.Name = "groupBoxTiketPesawat";
            this.groupBoxTiketPesawat.Size = new System.Drawing.Size(237, 181);
            this.groupBoxTiketPesawat.TabIndex = 13;
            this.groupBoxTiketPesawat.TabStop = false;
            this.groupBoxTiketPesawat.Text = "Detil Tiket Pesawat";
            // 
            // textBoxNomorPenerbangan
            // 
            this.textBoxNomorPenerbangan.Location = new System.Drawing.Point(105, 48);
            this.textBoxNomorPenerbangan.Name = "textBoxNomorPenerbangan";
            this.textBoxNomorPenerbangan.Size = new System.Drawing.Size(124, 20);
            this.textBoxNomorPenerbangan.TabIndex = 14;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 51);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "No. Penerbangan :";
            // 
            // comboBoxKotaTujuanPesawat
            // 
            this.comboBoxKotaTujuanPesawat.FormattingEnabled = true;
            this.comboBoxKotaTujuanPesawat.Location = new System.Drawing.Point(105, 100);
            this.comboBoxKotaTujuanPesawat.Name = "comboBoxKotaTujuanPesawat";
            this.comboBoxKotaTujuanPesawat.Size = new System.Drawing.Size(124, 21);
            this.comboBoxKotaTujuanPesawat.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Kota Tujuan :";
            // 
            // comboBoxNomorKursiPesawat
            // 
            this.comboBoxNomorKursiPesawat.FormattingEnabled = true;
            this.comboBoxNomorKursiPesawat.Location = new System.Drawing.Point(105, 20);
            this.comboBoxNomorKursiPesawat.Name = "comboBoxNomorKursiPesawat";
            this.comboBoxNomorKursiPesawat.Size = new System.Drawing.Size(124, 21);
            this.comboBoxNomorKursiPesawat.TabIndex = 10;
            // 
            // comboBoxKotaAsalPesawat
            // 
            this.comboBoxKotaAsalPesawat.FormattingEnabled = true;
            this.comboBoxKotaAsalPesawat.Location = new System.Drawing.Point(105, 73);
            this.comboBoxKotaAsalPesawat.Name = "comboBoxKotaAsalPesawat";
            this.comboBoxKotaAsalPesawat.Size = new System.Drawing.Size(124, 21);
            this.comboBoxKotaAsalPesawat.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 131);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Kelas :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Kota Asal :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Nomor Kursi :";
            // 
            // listBoxData
            // 
            this.listBoxData.FormattingEnabled = true;
            this.listBoxData.Location = new System.Drawing.Point(15, 351);
            this.listBoxData.Name = "listBoxData";
            this.listBoxData.Size = new System.Drawing.Size(750, 134);
            this.listBoxData.TabIndex = 14;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 329);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 13);
            this.label15.TabIndex = 15;
            this.label15.Text = "Data Tiket :";
            // 
            // buttonAddTicket
            // 
            this.buttonAddTicket.Location = new System.Drawing.Point(218, 305);
            this.buttonAddTicket.Name = "buttonAddTicket";
            this.buttonAddTicket.Size = new System.Drawing.Size(87, 23);
            this.buttonAddTicket.TabIndex = 16;
            this.buttonAddTicket.Text = "Add Ticket";
            this.buttonAddTicket.UseVisualStyleBackColor = true;
            this.buttonAddTicket.Click += new System.EventHandler(this.buttonAddTicket_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(317, 305);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(87, 23);
            this.buttonClear.TabIndex = 17;
            this.buttonClear.Text = "Clear Fields";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(415, 305);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(87, 23);
            this.buttonClose.TabIndex = 18;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // textBoxHargaTiketPesawat
            // 
            this.textBoxHargaTiketPesawat.Location = new System.Drawing.Point(104, 154);
            this.textBoxHargaTiketPesawat.Name = "textBoxHargaTiketPesawat";
            this.textBoxHargaTiketPesawat.Size = new System.Drawing.Size(124, 20);
            this.textBoxHargaTiketPesawat.TabIndex = 16;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 156);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 13);
            this.label16.TabIndex = 15;
            this.label16.Text = "Harga Tiket :";
            // 
            // comboBoxKelasPesawat
            // 
            this.comboBoxKelasPesawat.FormattingEnabled = true;
            this.comboBoxKelasPesawat.Location = new System.Drawing.Point(104, 128);
            this.comboBoxKelasPesawat.Name = "comboBoxKelasPesawat";
            this.comboBoxKelasPesawat.Size = new System.Drawing.Size(124, 21);
            this.comboBoxKelasPesawat.TabIndex = 17;
            // 
            // FormAddTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 499);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonAddTicket);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.listBoxData);
            this.Controls.Add(this.groupBoxTiketPesawat);
            this.Controls.Add(this.groupBoxTiketKeretaApi);
            this.Controls.Add(this.dateTimePickerTanggalDanJamTiket);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxTiketBus);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormAddTicket";
            this.Text = "Add Ticket";
            this.Load += new System.EventHandler(this.FormAddTicket_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxTiketBus.ResumeLayout(false);
            this.groupBoxTiketBus.PerformLayout();
            this.groupBoxTiketKeretaApi.ResumeLayout(false);
            this.groupBoxTiketKeretaApi.PerformLayout();
            this.groupBoxTiketPesawat.ResumeLayout(false);
            this.groupBoxTiketPesawat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonTiketPesawat;
        private System.Windows.Forms.RadioButton radioButtonTiketKeretaApi;
        private System.Windows.Forms.RadioButton radioButtonTiketBus;
        private System.Windows.Forms.GroupBox groupBoxTiketBus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButtonTidakPesanMakanMalam;
        private System.Windows.Forms.RadioButton radioButtonPesanMakanMalam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerTanggalDanJamTiket;
        private System.Windows.Forms.ComboBox comboBoxNomorKursiBus;
        private System.Windows.Forms.TextBox textBoxKotaTujuanBus;
        private System.Windows.Forms.TextBox textBoxHargaTiketBus;
        private System.Windows.Forms.GroupBox groupBoxTiketKeretaApi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxNomorKursiKeretaApi;
        private System.Windows.Forms.TextBox textBoxHargaTiketKeretaApi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBoxTiketPesawat;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBoxKotaTujuanPesawat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxNomorKursiPesawat;
        private System.Windows.Forms.ComboBox comboBoxKotaAsalPesawat;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox listBoxData;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBoxStasiunTujuanKeretaApi;
        private System.Windows.Forms.ComboBox comboBoxStasiunAsalKeretaApi;
        private System.Windows.Forms.TextBox textBoxNomorPenerbangan;
        private System.Windows.Forms.Button buttonAddTicket;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.ComboBox comboBoxKelasPesawat;
        private System.Windows.Forms.TextBox textBoxHargaTiketPesawat;
        private System.Windows.Forms.Label label16;
    }
}