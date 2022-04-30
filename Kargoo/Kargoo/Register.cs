
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
using Kargoo.Entity;

namespace Kargoo
{
    public partial class Register : Form
    {

       
        public Register()
        {
            InitializeComponent();
        }

        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "Ja8rmYDsdhueToWjpkrmgBvGtilf9HXUIzUG2zYo",
            BasePath = "https://theusers-a27ec-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;

        
        // Veritabanına bağlanır.
        private void Register_Load(object sender, EventArgs e)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            #region Condition
            if (string.IsNullOrWhiteSpace(kul_ad_tbox.Text) &&
                string.IsNullOrWhiteSpace(sifre_tbox.Text))
            { 
                MessageBox.Show("Lütfen tüm alanları doldurunuz...");
                return;
            }
            #endregion

            //Veritabanına yeni kayıt ekler.
            User user = new User()
                {
                UserName = kul_ad_tbox.Text,
                Password = sifre_tbox.Text

                };

            SetResponse set = client.Set(@"Users/"+ kul_ad_tbox.Text,user);

            MessageBox.Show("Başarıyla Kaydolunuz!!");
        }

        private void kul_ad_label_TextChanged(object sender, EventArgs e)
        {

        }

        private void sifre_tbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
