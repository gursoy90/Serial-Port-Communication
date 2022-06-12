using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serial_Port_Communication
{
    public partial class FrmSerialPortsConnect : DevExpress.XtraEditors.XtraForm
    {
        public FrmSerialPortsConnect()
        {
            InitializeComponent();
        }
        SerialPort serialPort1;
        string port;
        int baud;
        int databit;
        Parity eslik;
        StopBits dur;
        private void FrmSerialPortsConnect_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            string[] portlar = SerialPort.GetPortNames();
            comboPortAdi.Items.Clear();
            foreach (string prt in portlar)
            {
                comboPortAdi.Items.Add(prt);
            }
            lblGonderilenVeri.Hide();
            lblAlinan.Hide();
            txtGonderilen.Hide();
            txtAlinan.Hide();
            btnGonder.Hide();
            btnTemizle.Hide();
            btnYeni.Hide();

            btnBaglan.Size = new System.Drawing.Size(310, 31);
            lblBaslik.Size = new System.Drawing.Size(313, 45);

            this.Size = new Size(342, 588);
            this.MaximumSize = new Size(342, 588);
            this.MinimumSize = new Size(342, 588);



            comboBaudRate.Items.AddRange(new string[] { "75", "110", "300", "1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200" });
            comboBaudRate.SelectedItem = "9600";

            comboDataBit.Items.AddRange(new string[] { "5", "6", "7", "8" });
            comboDataBit.SelectedItem = "8";

            comboParity.Items.AddRange(new string[] { "None", "Odd", "Even", "Mark", "Space" });
            comboParity.SelectedItem = "None";

            comboStopBiti.Items.AddRange(new string[] { "None", "One", "Two", "OnePointFive", "One" });
            comboStopBiti.SelectedItem = "One";
        }

        private void btnBaglan_Click(object sender, EventArgs e)
        {
            try
            {

                port = comboPortAdi.SelectedItem.ToString();
                baud = Convert.ToInt32(comboBaudRate.SelectedItem.ToString());
                databit = Convert.ToInt32(comboDataBit.SelectedItem.ToString());
                eslik = (Parity)Enum.Parse(typeof(Parity), comboParity.SelectedItem.ToString());
                dur = (StopBits)Enum.Parse(typeof(StopBits), comboStopBiti.SelectedItem.ToString());

                lstDurum.Items.Clear();
                lstDurum.Items.Add("Port: " + port);
                lstDurum.Items.Add("Veri Hızı: " + baud.ToString());
                lstDurum.Items.Add("Veri Biti Sayısı: " + databit);
                lstDurum.Items.Add("Parity: " + eslik);
                lstDurum.Items.Add("Stop Biti: " + dur);

                serialPort1 = new SerialPort(port, baud, eslik, databit, dur);
                serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);

                this.Size = new System.Drawing.Size(931, 588);
                this.MaximumSize = new Size(931, 588);
                this.MinimumSize = new Size(931, 588);

                serialPort1.Open();
                comboPortAdi.Enabled = false;
                comboBaudRate.Enabled = false;
                comboDataBit.Enabled = false;
                comboParity.Enabled = false;
                comboStopBiti.Enabled = false;
                btnBaglan.Enabled = false;

               
                btnBaglan.LookAndFeel.UseDefaultLookAndFeel = false;
                btnBaglan.Appearance.BackColor = Color.MediumSeaGreen;
                btnBaglan.Appearance.Options.UseBackColor = true;

                btnBaglan.Size = new Size(183, 31);
                lblBaslik.Size = new Size(903, 45);
                btnBaglan.Text = "BAĞLI: " + port;
                btnGonder.Show();
                btnTemizle.Show();
                btnYeni.Show();
                lblGonderilenVeri.Show();
                lblAlinan.Show();
                txtGonderilen.Show();
                txtAlinan.Show();


            }
            catch
            {
                lstDurum.Items.Add("Hata! Bağlantı gerçekleştirilemedi.");

            }
        }      

        private void btnYeni_Click(object sender, EventArgs e)
        {
            txtGonderilen.Clear();
            txtAlinan.Clear();
            btnYeni.Hide();
            serialPort1.Close();
            comboPortAdi.Enabled = true;
            comboBaudRate.Enabled = true;
            comboDataBit.Enabled = true;
            comboParity.Enabled = true;
            comboStopBiti.Enabled = true;
            btnBaglan.Enabled = true;
            
            btnBaglan.Size = new Size(310, 31);
            btnBaglan.Appearance.BackColor =Color.Gray;
            btnBaglan.Text = "BAĞLAN";
            lblGonderilenVeri.Hide();
            lblAlinan.Hide();
            txtGonderilen.Hide();
            txtAlinan.Hide();
            btnGonder.Hide();
            btnTemizle.Hide();
            btnYeni.Hide();
            lblBaslik.Size = new System.Drawing.Size(313, 45);
            this.Size = new Size(342, 588);
            this.MaximumSize = new Size(342, 588);
            this.MinimumSize = new Size(342, 588);
            lstDurum.Items.Clear();
            lstDurum.Items.Add("Bağlantı Kapatıldı!");
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtGonderilen.Clear();
            txtAlinan.Clear();            
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1 == null)
                {
                    MessageBox.Show("Lütfen Port Seçiniz ve 'BAĞLAN' butonuna tıklayınız.");
                }
                else
                {
                    serialPort1.Write(txtGonderilen.Text + "\n");
                    txtGonderilen.Clear();
                    lstDurum.Items.Add("Veri Gönderildi");
                }

            }
            catch
            {
                lstDurum.Items.Add("Hata! Veri gönderilemedi.");
            }
        }
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            txtAlinan.Text = txtAlinan.Text + serialPort1.ReadExisting() + "\r\n";
            txtAlinan.Select(txtAlinan.Text.Length, 0);
        }
    }
}