using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_160420016_John_Tiket
{
    public partial class FormMenu : Form
    {
        public string filename = "TicketData.dat";
        public List<JohnTiket> listOfTickets = new List<JohnTiket>();

        public FormMenu()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddTicket formAddTicket = new FormAddTicket();
            formAddTicket.Owner = this;
            formAddTicket.ShowDialog();
        }

        private void displayTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDisplayTicket formDisplayTicket = new FormDisplayTicket();
            formDisplayTicket.Owner = this;
            formDisplayTicket.ShowDialog();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            if (File.Exists(filename))
            {
                FileStream fileStream = new FileStream(filename, FileMode.Open, FileAccess.Read);

                BinaryFormatter binaryFormatter = new BinaryFormatter();

                listOfTickets = binaryFormatter.Deserialize(fileStream) as List<JohnTiket>;

                fileStream.Close();
            }
        }
    }
}
