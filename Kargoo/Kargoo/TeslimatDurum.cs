using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using System.Xml;
using Kargoo.Entity;
using Newtonsoft.Json;

namespace Kargoo
{
    public partial class TeslimatDurum : Form
    {
        Harita harita;
        
        public TeslimatDurum()
        {
            InitializeComponent();
        }



        private void listbox_veri_SelectedIndexChanged(object sender, EventArgs e)
        {
            XmlTextReader okuyucu = new XmlTextReader("http://ip-api.com/xml");
            while (okuyucu.Read())
            {
                if(okuyucu.NodeType == XmlNodeType.Element) { 
                if(okuyucu.Name == "country")
                {
                    okuyucu.Read();
                    richTextBox1.Text += "Ülke:  " +okuyucu.Value.ToString() + "\n";
                }
                if (okuyucu.Name == "regionName")
                {
                    okuyucu.Read();
                    richTextBox1.Text += "Şehir:  " + okuyucu.Value.ToString() + "\n";
                }

                if (okuyucu.Name == "city")
                {
                    okuyucu.Read();
                    richTextBox1.Text += "İlçe:  " +okuyucu.Value.ToString() + "\n";
                }   
                
                if (okuyucu.Name == "lat")
                {
                    okuyucu.Read();
                    richTextBox1.Text += "Enlem:  " +okuyucu.Value.ToString() + "\n";
                }
                if (okuyucu.Name == "lon")
                {
                    okuyucu.Read();
                    richTextBox1.Text += "Boylam:  " +okuyucu.Value.ToString() + "\n";
                }

                }
            }
            okuyucu.Close();
        }


        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "3qcYMOrQtTChczi4dnxzDqFaZ2p4BNvo5zzWJEtE",
            BasePath = "https://teslimat-1f80d-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;
        

        void DataGridDoldur(Dictionary<string, Teslimat> kayitlar)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("Tanım", "Teslim Sırası");
            dataGridView1.Columns.Add("EnlemBilgisi", "Enlem Bilgisi");
            dataGridView1.Columns.Add("BoylamBilgisi", "Boylam Bilgisi");

            foreach(var item in kayitlar)
            {
                dataGridView1.Rows.Add("Kargo Şubesi", item.Value.EnlemBilgisi1, item.Value.BoylamBilgisi1, item.Value.Tanim1);
                dataGridView1.Rows.Add("1. Sıra", item.Value.EnlemBilgisi2, item.Value.BoylamBilgisi2, item.Value.Tanim2);
                dataGridView1.Rows.Add("2. Sıra", item.Value.EnlemBilgisi3, item.Value.BoylamBilgisi3, item.Value.Tanim3);
                dataGridView1.Rows.Add("3. Sıra", item.Value.EnlemBilgisi4, item.Value.BoylamBilgisi4, item.Value.Tanim4);
                dataGridView1.Rows.Add("4. Sıra", item.Value.EnlemBilgisi5, item.Value.BoylamBilgisi5, item.Value.Tanim5);
            }
        }

        private void TeslimatDurum_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(ifc);
            }
            catch
            {
                MessageBox.Show("Bağlantı Hatası!!!");
            }
        }

        private void kargo_listele_btn_Click(object sender, EventArgs e)
        {
            FirebaseResponse res = client.Get(@"Teslimat");
            Dictionary<string, Teslimat> veri = JsonConvert.DeserializeObject<Dictionary<string, Teslimat>>(res.Body.ToString());
            DataGridDoldur(veri);
        }

        private void btn_harita_Click(object sender, EventArgs e)
        {
            harita = new Harita();
            harita.Owner = this;
            harita.Show();
        }


    }
}
