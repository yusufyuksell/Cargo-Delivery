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
    public partial class LoginForm : Form
    {
        
        public LoginForm()
        {
            InitializeComponent();
        }


        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "Ja8rmYDsdhueToWjpkrmgBvGtilf9HXUIzUG2zYo",
            BasePath = "https://theusers-a27ec-default-rtdb.firebaseio.com/"
        };

        private void button1_Click(object sender, EventArgs e)
        {
            #region Condition
            if (string.IsNullOrWhiteSpace(kul_ad_tbox.Text) &&
                string.IsNullOrWhiteSpace(sifre_tbox.Text))
            {    
             MessageBox.Show("Lütfen tüm alanları doldurunuz...");
                return;
            }
            #endregion

            FirebaseResponse res = client.Get(@"Users/" + kul_ad_tbox.Text);
            User ResUser = res.ResultAs<User>(); //database result
            User CurUser = new User()
            {
                UserName = kul_ad_tbox.Text,
                Password = sifre_tbox.Text
            };

            //Veritabanına kayıt bulunduysa sonraki ekrana geçer.
            if (User.IsEqual(ResUser, CurUser))
            {
                Harita harita = new Harita();
                harita.ShowDialog();
            }
            else
            {
                User.ShowError();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Register reg = new Register();
            reg.Show();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        IFirebaseClient client;
        private void LoginForm_Load(object sender, EventArgs e)
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

        private void sifre_label_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
