
namespace Kargoo
{
    partial class Harita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Harita));
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btn_Cikar = new System.Windows.Forms.Button();
            this.txtBoylam = new System.Windows.Forms.TextBox();
            this.txtEnlem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_alan = new System.Windows.Forms.Button();
            this.btnRota = new System.Windows.Forms.Button();
            this.lbldistance = new System.Windows.Forms.Label();
            this.lblkm = new System.Windows.Forms.Label();
            this.teslimat_Btn = new System.Windows.Forms.Button();
            this.kargo_ekle_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gMapControl1
            // 
            this.gMapControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(0, -2);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(749, 657);
            this.gMapControl1.TabIndex = 0;
            this.gMapControl1.Zoom = 0D;
            this.gMapControl1.Load += new System.EventHandler(this.gMapControl1_Load);
            this.gMapControl1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gMapControl1_MouseDoubleClick);
            // 
            // btnEkle
            // 
            this.btnEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEkle.BackColor = System.Drawing.Color.LightGreen;
            this.btnEkle.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEkle.Location = new System.Drawing.Point(777, 108);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 45);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btn_Cikar
            // 
            this.btn_Cikar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cikar.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Cikar.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Cikar.Location = new System.Drawing.Point(872, 108);
            this.btn_Cikar.Name = "btn_Cikar";
            this.btn_Cikar.Size = new System.Drawing.Size(75, 45);
            this.btn_Cikar.TabIndex = 2;
            this.btn_Cikar.Text = "ÇIKAR";
            this.btn_Cikar.UseVisualStyleBackColor = false;
            this.btn_Cikar.Click += new System.EventHandler(this.btn_Cikar_Click);
            // 
            // txtBoylam
            // 
            this.txtBoylam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoylam.Location = new System.Drawing.Point(777, 79);
            this.txtBoylam.Name = "txtBoylam";
            this.txtBoylam.Size = new System.Drawing.Size(170, 23);
            this.txtBoylam.TabIndex = 4;
            // 
            // txtEnlem
            // 
            this.txtEnlem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEnlem.Location = new System.Drawing.Point(777, 27);
            this.txtEnlem.Name = "txtEnlem";
            this.txtEnlem.Size = new System.Drawing.Size(170, 23);
            this.txtEnlem.TabIndex = 5;
            this.txtEnlem.TextChanged += new System.EventHandler(this.txtEnlem_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(777, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Enlem: ";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(777, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Boylam:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(755, 212);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(212, 223);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.KayıtSec);
            // 
            // btn_alan
            // 
            this.btn_alan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_alan.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btn_alan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_alan.Location = new System.Drawing.Point(755, 455);
            this.btn_alan.Name = "btn_alan";
            this.btn_alan.Size = new System.Drawing.Size(105, 62);
            this.btn_alan.TabIndex = 10;
            this.btn_alan.Text = "Alanı Sınırlandır";
            this.btn_alan.UseVisualStyleBackColor = false;
            this.btn_alan.Click += new System.EventHandler(this.btn_alan_Click);
            // 
            // btnRota
            // 
            this.btnRota.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRota.BackColor = System.Drawing.Color.Tomato;
            this.btnRota.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRota.Location = new System.Drawing.Point(866, 455);
            this.btnRota.Name = "btnRota";
            this.btnRota.Size = new System.Drawing.Size(101, 62);
            this.btnRota.TabIndex = 11;
            this.btnRota.Text = "Rota Hesapla";
            this.btnRota.UseVisualStyleBackColor = false;
            this.btnRota.Click += new System.EventHandler(this.btnRota_Click);
            // 
            // lbldistance
            // 
            this.lbldistance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbldistance.AutoSize = true;
            this.lbldistance.BackColor = System.Drawing.Color.Transparent;
            this.lbldistance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbldistance.Location = new System.Drawing.Point(756, 535);
            this.lbldistance.Name = "lbldistance";
            this.lbldistance.Size = new System.Drawing.Size(104, 17);
            this.lbldistance.TabIndex = 12;
            this.lbldistance.Text = "Gidilen Yol: [KM]";
            // 
            // lblkm
            // 
            this.lblkm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblkm.AutoSize = true;
            this.lblkm.BackColor = System.Drawing.Color.Transparent;
            this.lblkm.Location = new System.Drawing.Point(872, 537);
            this.lblkm.Name = "lblkm";
            this.lblkm.Size = new System.Drawing.Size(12, 15);
            this.lblkm.TabIndex = 13;
            this.lblkm.Text = "-";
            // 
            // teslimat_Btn
            // 
            this.teslimat_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.teslimat_Btn.Location = new System.Drawing.Point(817, 605);
            this.teslimat_Btn.Name = "teslimat_Btn";
            this.teslimat_Btn.Size = new System.Drawing.Size(105, 33);
            this.teslimat_Btn.TabIndex = 15;
            this.teslimat_Btn.Text = "Teslimat Ekranı";
            this.teslimat_Btn.UseVisualStyleBackColor = true;
            this.teslimat_Btn.Click += new System.EventHandler(this.teslimat_Btn_Click);
            // 
            // kargo_ekle_btn
            // 
            this.kargo_ekle_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kargo_ekle_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kargo_ekle_btn.Location = new System.Drawing.Point(792, 159);
            this.kargo_ekle_btn.Name = "kargo_ekle_btn";
            this.kargo_ekle_btn.Size = new System.Drawing.Size(130, 37);
            this.kargo_ekle_btn.TabIndex = 16;
            this.kargo_ekle_btn.Text = "Yeni Kargo Ekle";
            this.kargo_ekle_btn.UseVisualStyleBackColor = true;
            this.kargo_ekle_btn.Click += new System.EventHandler(this.kargo_ekle_btn_Click);
            // 
            // Harita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(979, 654);
            this.Controls.Add(this.kargo_ekle_btn);
            this.Controls.Add(this.teslimat_Btn);
            this.Controls.Add(this.lblkm);
            this.Controls.Add(this.lbldistance);
            this.Controls.Add(this.btnRota);
            this.Controls.Add(this.btn_alan);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEnlem);
            this.Controls.Add(this.txtBoylam);
            this.Controls.Add(this.btn_Cikar);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.gMapControl1);
            this.Name = "Harita";
            this.Text = "Harita";
            this.Load += new System.EventHandler(this.Harita_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btn_Cikar;
        private System.Windows.Forms.TextBox txtBoylam;
        private System.Windows.Forms.TextBox txtEnlem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_alan;
        private System.Windows.Forms.Button btnRota;
        private System.Windows.Forms.Label lbldistance;
        private System.Windows.Forms.Label lblkm;
        public GMap.NET.WindowsForms.GMapControl gMapControl1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button teslimat_Btn;
        private System.Windows.Forms.Button kargo_ekle_btn;
    }
}