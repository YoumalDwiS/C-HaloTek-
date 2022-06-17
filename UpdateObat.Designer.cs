namespace HaloTek
{
    partial class UpdateObat
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
            this.components = new System.ComponentModel.Container();
            this.tbJenis = new System.Windows.Forms.TextBox();
            this.haloTekDataSet = new HaloTek.HaloTekDataSet();
            this.mKategoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mKategoriTableAdapter = new HaloTek.HaloTekDataSetTableAdapters.mKategoriTableAdapter();
            this.cbNamaKategori = new System.Windows.Forms.ComboBox();
            this.tbHarga = new System.Windows.Forms.TextBox();
            this.tbStok = new System.Windows.Forms.TextBox();
            this.tbKandungan = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNamaObat = new System.Windows.Forms.TextBox();
            this.tbIdObat = new System.Windows.Forms.TextBox();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnCari = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.haloTekDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mKategoriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbJenis
            // 
            this.tbJenis.Location = new System.Drawing.Point(387, 371);
            this.tbJenis.Name = "tbJenis";
            this.tbJenis.Size = new System.Drawing.Size(225, 22);
            this.tbJenis.TabIndex = 40;
            // 
            // haloTekDataSet
            // 
            this.haloTekDataSet.DataSetName = "HaloTekDataSet";
            this.haloTekDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mKategoriBindingSource
            // 
            this.mKategoriBindingSource.DataMember = "mKategori";
            this.mKategoriBindingSource.DataSource = this.haloTekDataSet;
            // 
            // mKategoriTableAdapter
            // 
            this.mKategoriTableAdapter.ClearBeforeFill = true;
            // 
            // cbNamaKategori
            // 
            this.cbNamaKategori.DataSource = this.mKategoriBindingSource;
            this.cbNamaKategori.DisplayMember = "nama_kategori";
            this.cbNamaKategori.FormattingEnabled = true;
            this.cbNamaKategori.Location = new System.Drawing.Point(387, 272);
            this.cbNamaKategori.Name = "cbNamaKategori";
            this.cbNamaKategori.Size = new System.Drawing.Size(225, 24);
            this.cbNamaKategori.TabIndex = 39;
            this.cbNamaKategori.ValueMember = "id_kategori";
            // 
            // tbHarga
            // 
            this.tbHarga.Location = new System.Drawing.Point(387, 475);
            this.tbHarga.Name = "tbHarga";
            this.tbHarga.Size = new System.Drawing.Size(225, 22);
            this.tbHarga.TabIndex = 38;
            // 
            // tbStok
            // 
            this.tbStok.Location = new System.Drawing.Point(387, 419);
            this.tbStok.Name = "tbStok";
            this.tbStok.Size = new System.Drawing.Size(225, 22);
            this.tbStok.TabIndex = 37;
            // 
            // tbKandungan
            // 
            this.tbKandungan.Location = new System.Drawing.Point(387, 324);
            this.tbKandungan.Name = "tbKandungan";
            this.tbKandungan.Size = new System.Drawing.Size(225, 22);
            this.tbKandungan.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(189, 480);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 17);
            this.label8.TabIndex = 35;
            this.label8.Text = "Harga :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(189, 424);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 34;
            this.label7.Text = "Stok :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(189, 376);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 17);
            this.label6.TabIndex = 33;
            this.label6.Text = "Jenis";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(189, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "Kandungan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "Nama Kategori :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(448, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "Update Obat";
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(520, 542);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(71, 26);
            this.btnBatal.TabIndex = 29;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(409, 542);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(71, 26);
            this.btnHapus.TabIndex = 28;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Nama Obat :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "ID Obat :";
            // 
            // tbNamaObat
            // 
            this.tbNamaObat.Location = new System.Drawing.Point(387, 199);
            this.tbNamaObat.Name = "tbNamaObat";
            this.tbNamaObat.Size = new System.Drawing.Size(225, 22);
            this.tbNamaObat.TabIndex = 25;
            // 
            // tbIdObat
            // 
            this.tbIdObat.Location = new System.Drawing.Point(387, 143);
            this.tbIdObat.Name = "tbIdObat";
            this.tbIdObat.Size = new System.Drawing.Size(225, 22);
            this.tbIdObat.TabIndex = 24;
            // 
            // btnUbah
            // 
            this.btnUbah.Location = new System.Drawing.Point(303, 542);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(71, 26);
            this.btnUbah.TabIndex = 41;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = true;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // btnCari
            // 
            this.btnCari.Location = new System.Drawing.Point(634, 141);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(71, 26);
            this.btnCari.TabIndex = 42;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // UpdateObat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 642);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.tbJenis);
            this.Controls.Add(this.cbNamaKategori);
            this.Controls.Add(this.tbHarga);
            this.Controls.Add(this.tbStok);
            this.Controls.Add(this.tbKandungan);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNamaObat);
            this.Controls.Add(this.tbIdObat);
            this.Name = "UpdateObat";
            this.Text = "UpdateObat";
            ((System.ComponentModel.ISupportInitialize)(this.haloTekDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mKategoriBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbJenis;
        private HaloTekDataSet haloTekDataSet;
        private System.Windows.Forms.BindingSource mKategoriBindingSource;
        private HaloTekDataSetTableAdapters.mKategoriTableAdapter mKategoriTableAdapter;
        private System.Windows.Forms.ComboBox cbNamaKategori;
        private System.Windows.Forms.TextBox tbHarga;
        private System.Windows.Forms.TextBox tbStok;
        private System.Windows.Forms.TextBox tbKandungan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNamaObat;
        private System.Windows.Forms.TextBox tbIdObat;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnCari;
    }
}