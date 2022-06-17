namespace HaloTek
{
    partial class InputObat
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNamaObat = new System.Windows.Forms.TextBox();
            this.tbIdObat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbKandungan = new System.Windows.Forms.TextBox();
            this.tbStok = new System.Windows.Forms.TextBox();
            this.tbHarga = new System.Windows.Forms.TextBox();
            this.cbNamaKategori = new System.Windows.Forms.ComboBox();
            this.haloTekDataSet = new HaloTek.HaloTekDataSet();
            this.mKategoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mKategoriTableAdapter = new HaloTek.HaloTekDataSetTableAdapters.mKategoriTableAdapter();
            this.tbJenis = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.haloTekDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mKategoriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(364, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Input Obat";
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(436, 521);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(71, 26);
            this.btnBatal.TabIndex = 12;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(303, 521);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(71, 26);
            this.btnSimpan.TabIndex = 11;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nama Obat :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID Obat :";
            // 
            // tbNamaObat
            // 
            this.tbNamaObat.Location = new System.Drawing.Point(303, 178);
            this.tbNamaObat.Name = "tbNamaObat";
            this.tbNamaObat.Size = new System.Drawing.Size(225, 22);
            this.tbNamaObat.TabIndex = 8;
            // 
            // tbIdObat
            // 
            this.tbIdObat.Location = new System.Drawing.Point(303, 122);
            this.tbIdObat.Name = "tbIdObat";
            this.tbIdObat.Size = new System.Drawing.Size(225, 22);
            this.tbIdObat.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Nama Kategori :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Kandungan";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(105, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Jenis";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(105, 403);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Stok :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(105, 459);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Harga :";
            // 
            // tbKandungan
            // 
            this.tbKandungan.Location = new System.Drawing.Point(303, 303);
            this.tbKandungan.Name = "tbKandungan";
            this.tbKandungan.Size = new System.Drawing.Size(225, 22);
            this.tbKandungan.TabIndex = 19;
            // 
            // tbStok
            // 
            this.tbStok.Location = new System.Drawing.Point(303, 398);
            this.tbStok.Name = "tbStok";
            this.tbStok.Size = new System.Drawing.Size(225, 22);
            this.tbStok.TabIndex = 20;
            // 
            // tbHarga
            // 
            this.tbHarga.Location = new System.Drawing.Point(303, 454);
            this.tbHarga.Name = "tbHarga";
            this.tbHarga.Size = new System.Drawing.Size(225, 22);
            this.tbHarga.TabIndex = 21;
            // 
            // cbNamaKategori
            // 
            this.cbNamaKategori.DataSource = this.mKategoriBindingSource;
            this.cbNamaKategori.DisplayMember = "nama_kategori";
            this.cbNamaKategori.FormattingEnabled = true;
            this.cbNamaKategori.Location = new System.Drawing.Point(303, 251);
            this.cbNamaKategori.Name = "cbNamaKategori";
            this.cbNamaKategori.Size = new System.Drawing.Size(225, 24);
            this.cbNamaKategori.TabIndex = 22;
            this.cbNamaKategori.ValueMember = "id_kategori";
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
            // tbJenis
            // 
            this.tbJenis.Location = new System.Drawing.Point(303, 350);
            this.tbJenis.Name = "tbJenis";
            this.tbJenis.Size = new System.Drawing.Size(225, 22);
            this.tbJenis.TabIndex = 23;
            // 
            // InputObat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 568);
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
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNamaObat);
            this.Controls.Add(this.tbIdObat);
            this.Name = "InputObat";
            this.Text = "InputObat";
            this.Load += new System.EventHandler(this.InputObat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.haloTekDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mKategoriBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNamaObat;
        private System.Windows.Forms.TextBox tbIdObat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbKandungan;
        private System.Windows.Forms.TextBox tbStok;
        private System.Windows.Forms.TextBox tbHarga;
        private System.Windows.Forms.ComboBox cbNamaKategori;
        private HaloTekDataSet haloTekDataSet;
        private System.Windows.Forms.BindingSource mKategoriBindingSource;
        private HaloTekDataSetTableAdapters.mKategoriTableAdapter mKategoriTableAdapter;
        private System.Windows.Forms.TextBox tbJenis;
    }
}