
namespace Kargoo
{
    partial class TeslimatDurum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeslimatDurum));
            this.listbox_veri = new System.Windows.Forms.ListBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.kargo_listele_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_harita = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // listbox_veri
            // 
            this.listbox_veri.BackColor = System.Drawing.SystemColors.ControlDark;
            this.listbox_veri.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listbox_veri.ForeColor = System.Drawing.SystemColors.InfoText;
            this.listbox_veri.FormattingEnabled = true;
            this.listbox_veri.ItemHeight = 40;
            this.listbox_veri.Location = new System.Drawing.Point(12, 34);
            this.listbox_veri.Name = "listbox_veri";
            this.listbox_veri.Size = new System.Drawing.Size(532, 124);
            this.listbox_veri.TabIndex = 0;
            this.listbox_veri.SelectedIndexChanged += new System.EventHandler(this.listbox_veri_SelectedIndexChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(550, 35);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(238, 123);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(580, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Müşteri Bilgisi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(182, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kargo Bilgisi";
            // 
            // kargo_listele_btn
            // 
            this.kargo_listele_btn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kargo_listele_btn.Location = new System.Drawing.Point(562, 174);
            this.kargo_listele_btn.Name = "kargo_listele_btn";
            this.kargo_listele_btn.Size = new System.Drawing.Size(171, 39);
            this.kargo_listele_btn.TabIndex = 6;
            this.kargo_listele_btn.Text = "Kargo Listele";
            this.kargo_listele_btn.UseVisualStyleBackColor = true;
            this.kargo_listele_btn.Click += new System.EventHandler(this.kargo_listele_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeight = 25;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Location = new System.Drawing.Point(13, 174);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(531, 264);
            this.dataGridView1.TabIndex = 7;
            // 
            // btn_harita
            // 
            this.btn_harita.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_harita.Location = new System.Drawing.Point(617, 393);
            this.btn_harita.Name = "btn_harita";
            this.btn_harita.Size = new System.Drawing.Size(171, 45);
            this.btn_harita.TabIndex = 8;
            this.btn_harita.Text = "Harita Ekranı";
            this.btn_harita.UseVisualStyleBackColor = true;
            this.btn_harita.Click += new System.EventHandler(this.btn_harita_Click);
            // 
            // TeslimatDurum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_harita);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.kargo_listele_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.listbox_veri);
            this.Name = "TeslimatDurum";
            this.Text = "TeslimatDurum";
            this.Load += new System.EventHandler(this.TeslimatDurum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ListBox listbox_veri;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button kargo_listele_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_harita;
    }
}