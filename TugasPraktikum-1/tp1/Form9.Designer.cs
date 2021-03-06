
namespace TugasPraktikum_1
{
    partial class Form9
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
            this.lblNama = new System.Windows.Forms.Label();
            this.lblNamaBarang = new System.Windows.Forms.Label();
            this.lblTanggal = new System.Windows.Forms.Label();
            this.lblHarga = new System.Windows.Forms.Label();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.tbNamaBarang = new System.Windows.Forms.TextBox();
            this.tbTanggal = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBaru = new System.Windows.Forms.Button();
            this.btnBayar = new System.Windows.Forms.Button();
            this.tbHarga = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblJumlahBayar = new System.Windows.Forms.Label();
            this.btnHitung = new System.Windows.Forms.Button();
            this.tbjmlBarang = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(59, 87);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(55, 20);
            this.lblNama.TabIndex = 0;
            this.lblNama.Text = "Nama ";
            this.lblNama.Click += new System.EventHandler(this.lblNama_Click);
            // 
            // lblNamaBarang
            // 
            this.lblNamaBarang.AutoSize = true;
            this.lblNamaBarang.Location = new System.Drawing.Point(59, 145);
            this.lblNamaBarang.Name = "lblNamaBarang";
            this.lblNamaBarang.Size = new System.Drawing.Size(107, 20);
            this.lblNamaBarang.TabIndex = 1;
            this.lblNamaBarang.Text = "Nama Barang";
            this.lblNamaBarang.Click += new System.EventHandler(this.lblNamaBarang_Click);
            // 
            // lblTanggal
            // 
            this.lblTanggal.AutoSize = true;
            this.lblTanggal.Location = new System.Drawing.Point(61, 200);
            this.lblTanggal.Name = "lblTanggal";
            this.lblTanggal.Size = new System.Drawing.Size(66, 20);
            this.lblTanggal.TabIndex = 2;
            this.lblTanggal.Text = "Tanggal";
            this.lblTanggal.Click += new System.EventHandler(this.lblTanggal_Click);
            // 
            // lblHarga
            // 
            this.lblHarga.AutoSize = true;
            this.lblHarga.Location = new System.Drawing.Point(59, 256);
            this.lblHarga.Name = "lblHarga";
            this.lblHarga.Size = new System.Drawing.Size(104, 20);
            this.lblHarga.TabIndex = 3;
            this.lblHarga.Text = "Biaya Barang";
            this.lblHarga.Click += new System.EventHandler(this.lblHarga_Click);
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(208, 84);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(182, 26);
            this.tbNama.TabIndex = 4;
            this.tbNama.TextChanged += new System.EventHandler(this.tbNama_TextChanged);
            // 
            // tbNamaBarang
            // 
            this.tbNamaBarang.Location = new System.Drawing.Point(208, 145);
            this.tbNamaBarang.Name = "tbNamaBarang";
            this.tbNamaBarang.Size = new System.Drawing.Size(182, 26);
            this.tbNamaBarang.TabIndex = 5;
            this.tbNamaBarang.TextChanged += new System.EventHandler(this.tbNamaBarang_TextChanged);
            // 
            // tbTanggal
            // 
            this.tbTanggal.Location = new System.Drawing.Point(208, 194);
            this.tbTanggal.Name = "tbTanggal";
            this.tbTanggal.Size = new System.Drawing.Size(182, 26);
            this.tbTanggal.TabIndex = 6;
            this.tbTanggal.TextChanged += new System.EventHandler(this.tbTanggal_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::TugasPraktikum_1.Properties.Resources.download__1_;
            this.panel1.Controls.Add(this.tbjmlBarang);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnBaru);
            this.panel1.Controls.Add(this.btnBayar);
            this.panel1.Controls.Add(this.tbHarga);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.lblJumlahBayar);
            this.panel1.Controls.Add(this.btnHitung);
            this.panel1.Controls.Add(this.lblHarga);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 641);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Jumlah Barang";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(314, 529);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 39);
            this.button1.TabIndex = 12;
            this.button1.Text = "Kembali";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBaru
            // 
            this.btnBaru.Location = new System.Drawing.Point(280, 12);
            this.btnBaru.Name = "btnBaru";
            this.btnBaru.Size = new System.Drawing.Size(206, 29);
            this.btnBaru.TabIndex = 11;
            this.btnBaru.Text = "Buat Pesanan Baru";
            this.btnBaru.UseVisualStyleBackColor = true;
            this.btnBaru.Click += new System.EventHandler(this.btnBaru_Click);
            // 
            // btnBayar
            // 
            this.btnBayar.Location = new System.Drawing.Point(208, 529);
            this.btnBayar.Name = "btnBayar";
            this.btnBayar.Size = new System.Drawing.Size(100, 39);
            this.btnBayar.TabIndex = 10;
            this.btnBayar.Text = "Bayar";
            this.btnBayar.UseVisualStyleBackColor = true;
            this.btnBayar.Click += new System.EventHandler(this.btnBayar_Click);
            // 
            // tbHarga
            // 
            this.tbHarga.Location = new System.Drawing.Point(208, 256);
            this.tbHarga.Name = "tbHarga";
            this.tbHarga.Size = new System.Drawing.Size(182, 26);
            this.tbHarga.TabIndex = 9;
            this.tbHarga.TextChanged += new System.EventHandler(this.tbHarga_TextChanged);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(208, 383);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(89, 44);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblJumlahBayar
            // 
            this.lblJumlahBayar.AutoSize = true;
            this.lblJumlahBayar.Location = new System.Drawing.Point(58, 462);
            this.lblJumlahBayar.Name = "lblJumlahBayar";
            this.lblJumlahBayar.Size = new System.Drawing.Size(105, 20);
            this.lblJumlahBayar.TabIndex = 1;
            this.lblJumlahBayar.Text = "Jumlah Bayar";
            this.lblJumlahBayar.Click += new System.EventHandler(this.lblJumlahBayar_Click);
            // 
            // btnHitung
            // 
            this.btnHitung.Location = new System.Drawing.Point(303, 383);
            this.btnHitung.Name = "btnHitung";
            this.btnHitung.Size = new System.Drawing.Size(96, 44);
            this.btnHitung.TabIndex = 0;
            this.btnHitung.Text = "Hitung";
            this.btnHitung.UseVisualStyleBackColor = true;
            this.btnHitung.Click += new System.EventHandler(this.btnHitung_Click);
            // 
            // tbjmlBarang
            // 
            this.tbjmlBarang.Location = new System.Drawing.Point(208, 306);
            this.tbjmlBarang.Name = "tbjmlBarang";
            this.tbjmlBarang.Size = new System.Drawing.Size(182, 26);
            this.tbjmlBarang.TabIndex = 14;
            this.tbjmlBarang.TextChanged += new System.EventHandler(this.tbjmlBarang_TextChanged);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 640);
            this.Controls.Add(this.tbTanggal);
            this.Controls.Add(this.tbNamaBarang);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.lblTanggal);
            this.Controls.Add(this.lblNamaBarang);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.panel1);
            this.Name = "Form9";
            this.Text = "Hitung Pembayaran";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblNamaBarang;
        private System.Windows.Forms.Label lblTanggal;
        private System.Windows.Forms.Label lblHarga;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.TextBox tbNamaBarang;
        private System.Windows.Forms.TextBox tbTanggal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHitung;
        private System.Windows.Forms.Label lblJumlahBayar;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox tbHarga;
        private System.Windows.Forms.Button btnBayar;
        private System.Windows.Forms.Button btnBaru;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbjmlBarang;
    }
}