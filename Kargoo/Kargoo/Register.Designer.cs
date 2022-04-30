
namespace Kargoo
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.register_btn = new System.Windows.Forms.Button();
            this.sifre_tbox = new System.Windows.Forms.TextBox();
            this.kul_ad_tbox = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // register_btn
            // 
            this.register_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.register_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.register_btn.Location = new System.Drawing.Point(184, 298);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(154, 44);
            this.register_btn.TabIndex = 11;
            this.register_btn.Text = "KAYIT OL";
            this.register_btn.UseVisualStyleBackColor = false;
            this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
            // 
            // sifre_tbox
            // 
            this.sifre_tbox.Location = new System.Drawing.Point(231, 203);
            this.sifre_tbox.Name = "sifre_tbox";
            this.sifre_tbox.PasswordChar = '*';
            this.sifre_tbox.Size = new System.Drawing.Size(165, 23);
            this.sifre_tbox.TabIndex = 10;
            this.sifre_tbox.TextChanged += new System.EventHandler(this.sifre_tbox_TextChanged);
            // 
            // kul_ad_tbox
            // 
            this.kul_ad_tbox.Location = new System.Drawing.Point(231, 160);
            this.kul_ad_tbox.Name = "kul_ad_tbox";
            this.kul_ad_tbox.Size = new System.Drawing.Size(165, 23);
            this.kul_ad_tbox.TabIndex = 9;
            this.kul_ad_tbox.TextChanged += new System.EventHandler(this.kul_ad_label_TextChanged);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.BackColor = System.Drawing.Color.Transparent;
            this.password.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.password.Location = new System.Drawing.Point(129, 198);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(96, 25);
            this.password.TabIndex = 8;
            this.password.Text = "Şifre Gir: ";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.name.Location = new System.Drawing.Point(65, 158);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(160, 25);
            this.name.TabIndex = 7;
            this.name.Text = "Kullanıcı Adı Gir:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(162, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 62);
            this.label1.TabIndex = 6;
            this.label1.Text = "KAYIT OL";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(545, 424);
            this.Controls.Add(this.register_btn);
            this.Controls.Add(this.sifre_tbox);
            this.Controls.Add(this.kul_ad_tbox);
            this.Controls.Add(this.password);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.TextBox sifre_tbox;
        private System.Windows.Forms.TextBox kul_ad_tbox;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label1;
    }
}