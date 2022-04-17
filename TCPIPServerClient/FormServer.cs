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
using System.Net;
using System.IO;

namespace TCPIPServerClient
{
    public partial class FormServer : Form
    {
        Thread thread; //Thread sınıfı aynı anda 2-3 processi birlikte yürütmeyi sağlar.
        IPAddress ip; //Hangi ip adresini dinleyeceğimizi bu sınıfla sağlıyoruz.
        TcpListener listener; //Portları dinlemeye yarayan C# sınıfı
        TcpClient client;
        NetworkStream ag; //Ağ erişimini sağlar.
        StreamReader oku;
        StreamWriter yaz;

        

        public delegate void ricdegis(string text);

        public FormServer()
        {
            InitializeComponent();
        }
        private bool stopTheThread = false;
        public void OkuBasla() //Porttaki verileri okumak için hazırlanan fonksiyon
        {
            while (!stopTheThread)
            {
                try
                {
                    client = listener.AcceptTcpClient();
                    ag = client.GetStream();
                    oku = new StreamReader(ag);
                    while (ag.CanRead)
                    {
                        try
                        {
                            string yazi = oku.ReadLine();
                            ekranabas(yazi);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Okuma başlatılamadı");
                            break;
                        }
                    }
                }
                catch
                {

                }
            }
            ag.Close();
            client.Close();
            MessageBox.Show("Durdurma başarılı..");
        }

        public void ekranabas(string yazi)
        {
            if (this.InvokeRequired)
            {
                ricdegis degis = new ricdegis(ekranabas);
                this.Invoke(degis, yazi);
            }
            else
            {
                yazi = "ClientSaidThat:" + yazi;
                txtEkran.AppendText(yazi + "\r\n");
            }
        }

        private void dinlemeye_basla() //Bu fonksiyon localhostun 80 numaralı portunu dinler bize orda neler olduğuu gösterir
        {
            try
            {
                ip = IPAddress.Parse("127.0.0.1");
                //System.Net.IPAddress ip = System.Net.IPAddress.Parse(txtHost.Text);
                listener = new TcpListener(ip, 80);
                listener.Start();
                thread = new Thread(new ThreadStart(OkuBasla));
                stopTheThread = false;
                thread.Start();
                txtEkran.AppendText(DateTime.Now.ToString() + "Dinleme başlatıldı..\r\n");
            }
            catch (Exception exx)
            {
                MessageBox.Show("Dinleme başlatılamadı..\r\n" + exx.ToString());
            }
        }

        private void FormServer_Load(object sender, EventArgs e)
        {

        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            dinlemeye_basla();
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            if (txtGonder.Text == "")
            {
                //Burada boş alan göndermeyi önlüyoruz.
                return;
            }
            else
            {
                yaz = new StreamWriter(ag);
                yaz.WriteLine(txtGonder.Text); //Ağdaki streamlari ekrana yazdıran işlem 
                yaz.Flush();
                txtEkran.AppendText(txtGonder.Text + "\r\n");
                txtGonder.Text = "";
            }
        }

        private void btnDurdur_Click(object sender, EventArgs e)
        {
            stopTheThread = true;
            listener.Stop();

            if (thread.IsAlive)
            {
                
                MessageBox.Show("Çalışan thread var..");
            }
            else
            {
                MessageBox.Show("Çalışan bir thread yok..");
            }

        }
    }
}
