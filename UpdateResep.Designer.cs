namespace HaloTek
{
    partial class UpdateResep
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
            this.mObatTableAdapter = new HaloTek.HaloTekDataSet2TableAdapters.mObatTableAdapter();
            this.haloTekDataSet2 = new HaloTek.HaloTekDataSet2();
            this.mObatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbNamaObat = new System.Windows.Forms.ComboBox();
            this.haloTekDataSet1 = new HaloTek.HaloTekDataSet1();
            this.mCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbNamaCustomer = new System.Windows.Forms.ComboBox();
            this.mCustomerTableAdapter = new HaloTek.HaloTekDataSet1TableAdapters.mCustomerTableAdapter();
            this.haloTekDataSet = new HaloTek.HaloTekDataSet();
            this.dtTglInput = new System.Windows.Forms.DateTimePicker();
            this.tbPenyakit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mKategoriTableAdapter = new HaloTek.HaloTekDataSetTableAdapters.mKategoriTableAdapter();
            this.tbIdResep = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mKategoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.btnCari = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.haloTekDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mObatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.haloTekDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mCustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.haloTekDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mKategoriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mObatTableAdapter
            // 
            this.mObatTableAdapter.ClearBeforeFill = true;
            // 
            // haloTekDataSet2
            // 
            this.haloTekDataSet2.DataSetName = "HaloTekDataSet2";
            this.haloTekDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mObatBindingSource
            // 
            this.mObatBindingSource.DataMember = "mObat";
            this.mObatBindingSource.DataSource = this.haloTekDataSet2;
            // 
            // cbNamaObat
            // 
            this.cbNamaObat.DataSource = this.mObatBindingSource;
            this.cbNamaObat.DisplayMember = "nama_obat";
            this.cbNamaObat.FormattingEnabled = true;
            this.cbNamaObat.Location = new System.Drawing.Point(387, 237);
            this.cbNamaObat.Name = "cbNamaObat";
            this.cbNamaObat.Size = new System.Drawing.Size(218, 24);
            this.cbNamaObat.TabIndex = 88;
            this.cbNamaObat.ValueMember = "id_obat";
            // 
            // haloTekDataSet1
            // 
            this.haloTekDataSet1.DataSetName = "HaloTekDataSet1";
            this.haloTekDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mCustomerBindingSource
            // 
            this.mCustomerBindingSource.DataMember = "mCustomer";
            this.mCustomerBindingSource.DataSource = this.haloTekDataSet1;
            // 
            // cbNamaCustomer
            // 
            this.cbNamaCustomer.DataSource = this.mCustomerBindingSource;
            this.cbNamaCustomer.DisplayMember = "nama_customer";
            this.cbNamaCustomer.FormattingEnabled = true;
            this.cbNamaCustomer.Location = new System.Drawing.Point(387, 191);
            this.cbNamaCustomer.Name = "cbNamaCustomer";
            this.cbNamaCustomer.Size = new System.Drawing.Size(218, 24);
            this.cbNamaCustomer.TabIndex = 87;
            this.cbNamaCustomer.ValueMember = "id_customer";
            // 
            // mCustomerTableAdapter
            // 
            this.mCustomerTableAdapter.ClearBeforeFill = true;
            // 
            // haloTekDataSet
            // 
            this.haloTekDataSet.DataSetName = "HaloTekDataSet";
            this.haloTekDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtTglInput
            // 
            this.dtTglInput.Location = new System.Drawing.Point(387, 340);
            this.dtTglInput.Name = "dtTglInput";
            this.dtTglInput.Size = new System.Drawing.Size(200, 22);
            this.dtTglInput.TabIndex = 86;
            // 
            // tbPenyakit
            // 
            this.tbPenyakit.Location = new System.Drawing.Point(387, 286);
            this.tbPenyakit.Name = "tbPenyakit";
            this.tbPenyakit.Size = new System.Drawing.Size(225, 22);
            this.tbPenyakit.TabIndex = 85;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(189, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 17);
            this.label6.TabIndex = 84;
            this.label6.Text = "Tanggal Input";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(189, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 83;
            this.label5.Text = "Penyakit";
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(541, 388);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(71, 26);
            this.btnBatal.TabIndex = 80;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(418, 388);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(71, 26);
            this.btnHapus.TabIndex = 79;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 78;
            this.label2.Text = "Nama Customer :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 77;
            this.label1.Text = "ID Resep :";
            // 
            // mKategoriTableAdapter
            // 
            this.mKategoriTableAdapter.ClearBeforeFill = true;
            // 
            // tbIdResep
            // 
            this.tbIdResep.Location = new System.Drawing.Point(387, 135);
            this.tbIdResep.Name = "tbIdResep";
            this.tbIdResep.Size = new System.Drawing.Size(225, 22);
            this.tbIdResep.TabIndex = 76;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 82;
            this.label4.Text = "Nama Obat :";
            // 
            // mKategoriBindingSource
            // 
            this.mKategoriBindingSource.DataMember = "mKategori";
            this.mKategoriBindingSource.DataSource = this.haloTekDataSet;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(415, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 81;
            this.label3.Text = "Update Resep";
            // 
            // btnCari
            // 
            this.btnCari.Location = new System.Drawing.Point(637, 133);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(71, 26);
            this.btnCari.TabIndex = 89;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // btnUbah
            // 
            this.btnUbah.Location = new System.Drawing.Point(304, 388);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(71, 26);
            this.btnUbah.TabIndex = 90;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = true;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // UpdateResep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.cbNamaObat);
            this.Controls.Add(this.cbNamaCustomer);
            this.Controls.Add(this.dtTglInput);
            this.Controls.Add(this.tbPenyakit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbIdResep);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "UpdateResep";
            this.Text = "UpdateResep";
            ((System.ComponentModel.ISupportInitialize)(this.haloTekDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mObatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.haloTekDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mCustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.haloTekDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mKategoriBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HaloTekDataSet2TableAdapters.mObatTableAdapter mObatTableAdapter;
        private HaloTekDataSet2 haloTekDataSet2;
        private System.Windows.Forms.BindingSource mObatBindingSource;
        private System.Windows.Forms.ComboBox cbNamaObat;
        private HaloTekDataSet1 haloTekDataSet1;
        private System.Windows.Forms.BindingSource mCustomerBindingSource;
        private System.Windows.Forms.ComboBox cbNamaCustomer;
        private HaloTekDataSet1TableAdapters.mCustomerTableAdapter mCustomerTableAdapter;
        private HaloTekDataSet haloTekDataSet;
        private System.Windows.Forms.DateTimePicker dtTglInput;
        private System.Windows.Forms.TextBox tbPenyakit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private HaloTekDataSetTableAdapters.mKategoriTableAdapter mKategoriTableAdapter;
        private System.Windows.Forms.TextBox tbIdResep;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource mKategoriBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.Button btnUbah;
    }
}