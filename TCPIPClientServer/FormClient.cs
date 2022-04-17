using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;
using System.IO;

namespace TCPIPClientServer
{
    public partial class FormClient : Form
    {
        Thread thread;
        TcpClient baglantikur;
        NetworkStream ag;
        StreamReader oku;
        StreamWriter yaz;
        public delegate void ricdegis(string text);

        public FormClient()
        {
            InitializeComponent();
        }

        public void ekranabas(string s)
        {
            if (this.InvokeRequired)
            {
                ricdegis degis = new ricdegis(ekranabas);
                this.Invoke(degis, s);
            }
            else
            {
                s = "ServerToldUs:" + s;
                txtEkran.AppendText(s + "\r\n");
            }
        }

        public void okumayabasla()
        {
            ag = baglantikur.GetStream();
            oku = new StreamReader(ag);
            while (true)
            {
                try
                {
                    string yazi = oku.ReadLine();
                    ekranabas(yazi);
                }
                catch (Exception)
                {
                    return;
                }
            }
        }

        public void baglanti_kur()
        {
            try
            {
                int intPortNo;
                int.TryParse(txtHost.Text, out intPortNo);
                string strIp = txtPort.Text;
                //baglantikur = new TcpClient("127.0.0.1", 80);
                baglantikur = new TcpClient(txtHost.Text, Convert.ToInt32(txtPort.Text));
                thread = new Thread(new ThreadStart(okumayabasla));
                thread.Start();
                txtEkran.AppendText(DateTime.Now.ToString() + "Bağlantı kuruldu..\r\n");
            }
            catch (Exception)
            {

                MessageBox.Show("Server ile bağlantı kurulurken hata oluştu!");
            }
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            if (txtGonder.Text == "") //Burda boş alan göndermeyi önlüyoruz
            {
                return;
            }
            else
            {
                yaz = new StreamWriter(ag);
                yaz.WriteLine(txtGonder.Text);
                yaz.Flush();
                txtEkran.AppendText(txtGonder.Text + "\r\n");
                txtGonder.Text = "";
            }
        }

        private void btnBaglan_Click(object sender, EventArgs e)
        {
            baglanti_kur();
        }

        private void btnKes_Click(object sender, EventArgs e)
        {
            baglantikur.Client.Close();
        }

        private void FormClient_Load(object sender, EventArgs e)
        {

        }
    }
}
