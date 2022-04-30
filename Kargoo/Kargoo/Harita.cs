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
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using Kargoo.Entity;

namespace Kargoo
{
    public partial class Harita : Form
    {
        TeslimatDurum teslimat;
        GMarkerGoogle marker;
        GMapOverlay markerOverlay;
        DataTable dt;

        int secilenSatir = 0;
        double enlemSelect = 40.766666;
        double boylamSelect = 29.916668;

        public Harita()
        {
            InitializeComponent();
        }

        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "",
            BasePath = ""
        };



        IFirebaseClient client;
        private void Harita_Load(object sender, EventArgs e)
        {
            

            GMapProviders.GoogleMap.ApiKey = @"";
            try
            {
                client = new FireSharp.FirebaseClient(ifc);
            }
            catch
            {
                MessageBox.Show("Bağlantı Hatası!!!");
            }

            dt = new DataTable();
            dt.Columns.Add(new DataColumn("Lokasyon: ", typeof(string)));
            dt.Columns.Add(new DataColumn("Enlem: ", typeof(double)));
            dt.Columns.Add(new DataColumn("Boylam: ", typeof(double)));


            //Listede görüntülemek için tabloya ekliyoruz.
            dt.Rows.Add("Kuryenin Konumu", enlemSelect, boylamSelect);
            dataGridView1.DataSource = dt;

            //Enlem ve boylam bilgilerini görüntülenmesini istemiyoruz.
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;


            // Haritanın görünümü için ayarlar yapıyoruz.
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(enlemSelect, boylamSelect);
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 9;
            gMapControl1.AutoScroll = true;


            //Konum işaretleyici
            markerOverlay = new GMapOverlay("İşaretleyici");
            marker = new GMarkerGoogle(new PointLatLng(enlemSelect, boylamSelect), GMarkerGoogleType.green);
            markerOverlay.Markers.Add(marker);


            //Mouse, konum işaretleyicisini üzerine geldiğinde lokasyon bilgileri yazacak.
            marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker.ToolTipText = string.Format("Kuryenin Konumu");



            //Haritayı ve işaretçiyi ekliyoruz.
            gMapControl1.Overlays.Add(markerOverlay);

            client = new FireSharp.FirebaseClient(ifc);

        }

        

        private void KayıtSec(object sender, DataGridViewCellMouseEventArgs e)
        {
            secilenSatir = e.RowIndex;

            // Verileri alıyoruz ve metin kutularına atıyoruz.
            txtEnlem.Text = dataGridView1.Rows[secilenSatir].Cells[1].Value.ToString();
            txtBoylam.Text = dataGridView1.Rows[secilenSatir].Cells[2].Value.ToString();

            // Değerleri işaretçiye atıyoruz.
            marker.Position = new PointLatLng(Convert.ToDouble(txtEnlem.Text), Convert.ToDouble(txtBoylam.Text));

            // Haritayı o noktaya konumlandırılır.
            gMapControl1.Position = marker.Position;


        }
       

        private void gMapControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            // Kullanıcının tıkladığı konum enlem ve boylam bilgilerini alıyoruz.
            double enlem = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat;
            double boylam = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng;

            //Konumları textBoxlara atıyoruz.
            txtEnlem.Text = enlem.ToString();
            txtBoylam.Text = boylam.ToString();


            //Seçilen yere atamak için işaretçi oluşturuyoruz.
            marker.Position = new PointLatLng(enlem, boylam);

        }



        int tiklamaSayisi = 0;
        private void btnEkle_Click(object sender, EventArgs e)
        {
            tiklamaSayisi +=1;
            // Tabloya, belirlenen konumu ekler.
            dt.Rows.Add("Kargo-" + tiklamaSayisi, txtEnlem.Text, txtBoylam.Text);


            //Konum eklendiğinde yeşil işaretçi atıyoruz.
            double enlem = Convert.ToDouble(txtEnlem.Text);
            double boylam = Convert.ToDouble(txtBoylam.Text);

            PointLatLng point = new PointLatLng(enlem, boylam);
            GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.green);


            //İşaretçde konum bilgisi çıkar.
            GMapOverlay markers = new GMapOverlay("markers");
            markers.Markers.Add(marker);
            gMapControl1.Overlays.Add(markers);

            marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker.ToolTipText = string.Format("Konum: Kargo" + tiklamaSayisi);


        }


        private void btn_Cikar_Click(object sender, EventArgs e)
        {
            //Tablodan seçilen satırı siler.
            try
            {
                dataGridView1.Rows.RemoveAt(secilenSatir);
            }
            catch
            {
                
            }
        }


        private void btn_alan_Click(object sender, EventArgs e)
        {
            GMapOverlay Alan = new GMapOverlay("Alan");
            List<PointLatLng> sinir = new List<PointLatLng>();

            double enlem, boylam;

            //Konum verilerini haritadan alıyoruz.
            for (int satir = 0; satir < dataGridView1.Rows.Count; satir++)
            {
                enlem = Convert.ToDouble(dataGridView1.Rows[satir].Cells[1].Value);
                boylam = Convert.ToDouble(dataGridView1.Rows[satir].Cells[2].Value);
                sinir.Add(new PointLatLng(enlem, boylam));
            }

            GMapPolygon alanSinir = new GMapPolygon(sinir, "Alan");
            Alan.Polygons.Add(alanSinir);
            gMapControl1.Overlays.Add(Alan);

            //Haritayı sınırlı alan için güncelliyoruz.
            gMapControl1.Zoom = gMapControl1.Zoom + 1;
            gMapControl1.Zoom = gMapControl1.Zoom - 1;
        }

        private void btnRota_Click(object sender, EventArgs e)
        {

           
            GMapOverlay Rota = new GMapOverlay("Rota");
            List<PointLatLng> nokta = new List<PointLatLng>();

            double enlem, boylam;

            //Konum verilerini haritadan alıyoruz.
            for (int satir = 0; satir < dataGridView1.Rows.Count; satir++)
            {
                enlem = Convert.ToDouble(dataGridView1.Rows[satir].Cells[1].Value);
                boylam = Convert.ToDouble(dataGridView1.Rows[satir].Cells[2].Value);
                nokta.Add(new PointLatLng(enlem, boylam));
            }

            GMapRoute rotaNokta = new GMapRoute(nokta, "Rota");
            Rota.Routes.Add(rotaNokta);
            gMapControl1.Overlays.Add(Rota);

            //Haritayı sınırlı alan için güncelliyoruz.
            gMapControl1.Zoom = gMapControl1.Zoom + 1;
            gMapControl1.Zoom = gMapControl1.Zoom - 1;

            lblkm.Text = rotaNokta.Distance + " KM";

            Teslimat teslimat = new Teslimat()
            {
                EnlemBilgisi1 = Convert.ToString((dataGridView1.Rows[0].Cells[1].Value)),
                BoylamBilgisi1 = Convert.ToString((dataGridView1.Rows[0].Cells[2].Value)),
                Tanim1 = "1. Kargo",

                EnlemBilgisi2 = Convert.ToString((dataGridView1.Rows[1].Cells[1].Value)),
                BoylamBilgisi2 = Convert.ToString((dataGridView1.Rows[1].Cells[2].Value)),
                Tanim2 = "2. Kargo",

                EnlemBilgisi3 = Convert.ToString((dataGridView1.Rows[2].Cells[1].Value)),
                BoylamBilgisi3 = Convert.ToString((dataGridView1.Rows[2].Cells[2].Value)),
                Tanim3 = "3. Kargo",

                EnlemBilgisi4 = Convert.ToString((dataGridView1.Rows[3].Cells[1].Value)),
                BoylamBilgisi4 = Convert.ToString((dataGridView1.Rows[3].Cells[2].Value)),
                Tanim4 = "4. Kargo",

                EnlemBilgisi5 = Convert.ToString((dataGridView1.Rows[4].Cells[1].Value)),
                BoylamBilgisi5 = Convert.ToString((dataGridView1.Rows[4].Cells[2].Value)),
                Tanim5 = "5. Kargo",

            };
            SetResponse set = client.Set(@"Teslimat/" + Convert.ToString("Kargolar"), teslimat);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {

        }

      
       
        private void teslimat_Btn_Click(object sender, EventArgs e)
        {
            
            teslimat = new TeslimatDurum();
            teslimat.Owner = this;
            teslimat.Show();

            
            teslimat.listbox_veri.Items.Add("Gidilecek Mesafe:              " + lblkm.Text);
            
        }


        private void kargo_ekle_btn_Click(object sender, EventArgs e)
        {
            txtEnlem.Text = "";
            txtBoylam.Text = "";

            if(gMapControl1.Overlays.Count > 0)
            {
                gMapControl1.Overlays.RemoveAt(0);
                gMapControl1.Refresh();
            }

            dt.Clear();
            dataGridView1.DataSource = dt;
            lblkm.Text = " - ";





        }

        private void txtEnlem_TextChanged(object sender, EventArgs e)
        {

        }

        

    }
}
