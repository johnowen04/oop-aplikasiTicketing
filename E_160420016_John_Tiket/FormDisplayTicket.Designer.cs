
namespace E_160420016_John_Tiket
{
    partial class FormDisplayTicket
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
            this.radioButtonSemuaTiket = new System.Windows.Forms.RadioButton();
            this.listBoxData = new System.Windows.Forms.ListBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonTiketPesawat);
            this.groupBox1.Controls.Add(this.radioButtonTiketKeretaApi);
            this.groupBox1.Controls.Add(this.radioButtonTiketBus);
            this.groupBox1.Controls.Add(this.radioButtonSemuaTiket);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 45);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Jenis Ticket";
            // 
            // radioButtonTiketPesawat
            // 
            this.radioButtonTiketPesawat.AutoSize = true;
            this.radioButtonTiketPesawat.Location = new System.Drawing.Point(337, 19);
            this.radioButtonTiketPesawat.Name = "radioButtonTiketPesawat";
            this.radioButtonTiketPesawat.Size = new System.Drawing.Size(93, 17);
            this.radioButtonTiketPesawat.TabIndex = 3;
            this.radioButtonTiketPesawat.TabStop = true;
            this.radioButtonTiketPesawat.Text = "Tiket Pesawat";
            this.radioButtonTiketPesawat.UseVisualStyleBackColor = true;
            this.radioButtonTiketPesawat.CheckedChanged += new System.EventHandler(this.radioButtonTiketPesawat_CheckedChanged);
            // 
            // radioButtonTiketKeretaApi
            // 
            this.radioButtonTiketKeretaApi.AutoSize = true;
            this.radioButtonTiketKeretaApi.Location = new System.Drawing.Point(214, 19);
            this.radioButtonTiketKeretaApi.Name = "radioButtonTiketKeretaApi";
            this.radioButtonTiketKeretaApi.Size = new System.Drawing.Size(101, 17);
            this.radioButtonTiketKeretaApi.TabIndex = 2;
            this.radioButtonTiketKeretaApi.TabStop = true;
            this.radioButtonTiketKeretaApi.Text = "Tiket Kereta Api";
            this.radioButtonTiketKeretaApi.UseVisualStyleBackColor = true;
            this.radioButtonTiketKeretaApi.CheckedChanged += new System.EventHandler(this.radioButtonTiketKeretaApi_CheckedChanged);
            // 
            // radioButtonTiketBus
            // 
            this.radioButtonTiketBus.AutoSize = true;
            this.radioButtonTiketBus.Location = new System.Drawing.Point(125, 19);
            this.radioButtonTiketBus.Name = "radioButtonTiketBus";
            this.radioButtonTiketBus.Size = new System.Drawing.Size(70, 17);
            this.radioButtonTiketBus.TabIndex = 1;
            this.radioButtonTiketBus.TabStop = true;
            this.radioButtonTiketBus.Text = "Tiket Bus";
            this.radioButtonTiketBus.UseVisualStyleBackColor = true;
            this.radioButtonTiketBus.CheckedChanged += new System.EventHandler(this.radioButtonTiketBus_CheckedChanged);
            // 
            // radioButtonSemuaTiket
            // 
            this.radioButtonSemuaTiket.AutoSize = true;
            this.radioButtonSemuaTiket.Location = new System.Drawing.Point(17, 19);
            this.radioButtonSemuaTiket.Name = "radioButtonSemuaTiket";
            this.radioButtonSemuaTiket.Size = new System.Drawing.Size(85, 17);
            this.radioButtonSemuaTiket.TabIndex = 0;
            this.radioButtonSemuaTiket.TabStop = true;
            this.radioButtonSemuaTiket.Text = "Semua Tiket";
            this.radioButtonSemuaTiket.UseVisualStyleBackColor = true;
            this.radioButtonSemuaTiket.CheckedChanged += new System.EventHandler(this.radioButtonSemuaTiket_CheckedChanged);
            // 
            // listBoxData
            // 
            this.listBoxData.FormattingEnabled = true;
            this.listBoxData.Location = new System.Drawing.Point(12, 74);
            this.listBoxData.Name = "listBoxData";
            this.listBoxData.Size = new System.Drawing.Size(452, 342);
            this.listBoxData.TabIndex = 1;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(368, 425);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(96, 23);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.Text = "Back to Menu";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // FormDisplayTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 462);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.listBoxData);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormDisplayTicket";
            this.Text = "Display Ticket";
            this.Load += new System.EventHandler(this.FormDisplayTicket_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonTiketPesawat;
        private System.Windows.Forms.RadioButton radioButtonTiketKeretaApi;
        private System.Windows.Forms.RadioButton radioButtonTiketBus;
        private System.Windows.Forms.RadioButton radioButtonSemuaTiket;
        private System.Windows.Forms.ListBox listBoxData;
        private System.Windows.Forms.Button buttonBack;
    }
}