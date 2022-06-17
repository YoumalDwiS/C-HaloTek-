namespace HaloTek
{
    partial class UpdateSupplier
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
            this.tbAlamatSupplier = new System.Windows.Forms.TextBox();
            this.haloTekDataSet = new HaloTek.HaloTekDataSet();
            this.mKategoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mKategoriTableAdapter = new HaloTek.HaloTekDataSetTableAdapters.mKategoriTableAdapter();
            this.tbNoTelponSupplier = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNamaSupplier = new System.Windows.Forms.TextBox();
            this.tbIdSupplier = new System.Windows.Forms.TextBox();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnCari = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.haloTekDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mKategoriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbAlamatSupplier
            // 
            this.tbAlamatSupplier.Enabled = false;
            this.tbAlamatSupplier.Location = new System.Drawing.Point(387, 278);
            this.tbAlamatSupplier.Name = "tbAlamatSupplier";
            this.tbAlamatSupplier.Size = new System.Drawing.Size(225, 22);
            this.tbAlamatSupplier.TabIndex = 44;
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
            // tbNoTelponSupplier
            // 
            this.tbNoTelponSupplier.Enabled = false;
            this.tbNoTelponSupplier.Location = new System.Drawing.Point(387, 235);
            this.tbNoTelponSupplier.Name = "tbNoTelponSupplier";
            this.tbNoTelponSupplier.Size = new System.Drawing.Size(225, 22);
            this.tbNoTelponSupplier.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(189, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 17);
            this.label5.TabIndex = 43;
            this.label5.Text = "Alamat Supplier :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 17);
            this.label4.TabIndex = 42;
            this.label4.Text = "No Telpon Supplier :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(448, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 41;
            this.label3.Text = "Input Supplier";
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(541, 388);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(71, 26);
            this.btnBatal.TabIndex = 40;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            // 
            // btnUbah
            // 
            this.btnUbah.Location = new System.Drawing.Point(334, 388);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(71, 26);
            this.btnUbah.TabIndex = 39;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = true;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 38;
            this.label2.Text = "Nama Supplier : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 37;
            this.label1.Text = "ID Supplier : ";
            // 
            // tbNamaSupplier
            // 
            this.tbNamaSupplier.Enabled = false;
            this.tbNamaSupplier.Location = new System.Drawing.Point(387, 189);
            this.tbNamaSupplier.Name = "tbNamaSupplier";
            this.tbNamaSupplier.Size = new System.Drawing.Size(225, 22);
            this.tbNamaSupplier.TabIndex = 36;
            // 
            // tbIdSupplier
            // 
            this.tbIdSupplier.Location = new System.Drawing.Point(387, 136);
            this.tbIdSupplier.Name = "tbIdSupplier";
            this.tbIdSupplier.Size = new System.Drawing.Size(225, 22);
            this.tbIdSupplier.TabIndex = 35;
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(451, 388);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(71, 26);
            this.btnHapus.TabIndex = 46;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnCari
            // 
            this.btnCari.Location = new System.Drawing.Point(640, 130);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(71, 26);
            this.btnCari.TabIndex = 47;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // UpdateSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.tbAlamatSupplier);
            this.Controls.Add(this.tbNoTelponSupplier);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNamaSupplier);
            this.Controls.Add(this.tbIdSupplier);
            this.Name = "UpdateSupplier";
            this.Text = "UpdateSupplier";
            ((System.ComponentModel.ISupportInitialize)(this.haloTekDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mKategoriBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAlamatSupplier;
        private HaloTekDataSet haloTekDataSet;
        private System.Windows.Forms.BindingSource mKategoriBindingSource;
        private HaloTekDataSetTableAdapters.mKategoriTableAdapter mKategoriTableAdapter;
        private System.Windows.Forms.TextBox tbNoTelponSupplier;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNamaSupplier;
        private System.Windows.Forms.TextBox tbIdSupplier;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnCari;
    }
}