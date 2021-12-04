using System;
using System.Windows.Forms;

namespace E_160420016_John_Tiket
{
    public partial class FormDisplayTicket : Form
    {
        private FormMenu formMenu;

        public FormDisplayTicket()
        {
            InitializeComponent();
        }

        private void FormDisplayTicket_Load(object sender, EventArgs e)
        {
            formMenu = (FormMenu)this.Owner;
            radioButtonSemuaTiket.Checked = true;
        }

        private void radioButtonSemuaTiket_CheckedChanged(object sender, EventArgs e)
        {
            listBoxData.Items.Clear();
            foreach(JohnTiket tiket in formMenu.listOfTickets)
            {
                listBoxData.Items.AddRange(tiket.DisplayData().Split('\n'));
                listBoxData.Items.Add("");
            }
        }

        private void radioButtonTiketBus_CheckedChanged(object sender, EventArgs e)
        {
            listBoxData.Items.Clear();
            foreach (JohnTiket tiket in formMenu.listOfTickets)
            {
                if (tiket is JohnTiketBus)
                {
                    listBoxData.Items.AddRange(tiket.DisplayData().Split('\n'));
                    listBoxData.Items.Add("");
                }
            }
        }

        private void radioButtonTiketKeretaApi_CheckedChanged(object sender, EventArgs e)
        {
            listBoxData.Items.Clear();
            foreach (JohnTiket tiket in formMenu.listOfTickets)
            {
                if (tiket is JohnTiketKeretaApi)
                {
                    listBoxData.Items.AddRange(tiket.DisplayData().Split('\n'));
                    listBoxData.Items.Add("");
                }
            }
        }

        private void radioButtonTiketPesawat_CheckedChanged(object sender, EventArgs e)
        {
            listBoxData.Items.Clear();
            foreach (JohnTiket tiket in formMenu.listOfTickets)
            {
                if (tiket is JohnTiketPesawat)
                {
                    listBoxData.Items.AddRange(tiket.DisplayData().Split('\n'));
                    listBoxData.Items.Add("");
                }
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
