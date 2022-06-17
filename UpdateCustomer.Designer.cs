namespace HaloTek
{
    partial class UpdateCustomer
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
            this.tbIdCustomer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNoTelponCustomer = new System.Windows.Forms.TextBox();
            this.mKategoriTableAdapter = new HaloTek.HaloTekDataSetTableAdapters.mKategoriTableAdapter();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNamaCustomer = new System.Windows.Forms.TextBox();
            this.mKategoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.haloTekDataSet = new HaloTek.HaloTekDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnCari = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mKategoriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.haloTekDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tbIdCustomer
            // 
            this.tbIdCustomer.Location = new System.Drawing.Point(387, 159);
            this.tbIdCustomer.Name = "tbIdCustomer";
            this.tbIdCustomer.Size = new System.Drawing.Size(225, 22);
            this.tbIdCustomer.TabIndex = 61;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 17);
            this.label4.TabIndex = 68;
            this.label4.Text = "No Telpon Customer :";
            // 
            // tbNoTelponCustomer
            // 
            this.tbNoTelponCustomer.Enabled = false;
            this.tbNoTelponCustomer.Location = new System.Drawing.Point(387, 258);
            this.tbNoTelponCustomer.Name = "tbNoTelponCustomer";
            this.tbNoTelponCustomer.Size = new System.Drawing.Size(225, 22);
            this.tbNoTelponCustomer.TabIndex = 69;
            // 
            // mKategoriTableAdapter
            // 
            this.mKategoriTableAdapter.ClearBeforeFill = true;
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(541, 364);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(71, 26);
            this.btnBatal.TabIndex = 66;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(428, 364);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(71, 26);
            this.btnHapus.TabIndex = 65;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 64;
            this.label2.Text = "Nama Customer :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 63;
            this.label1.Text = "ID Customer :";
            // 
            // tbNamaCustomer
            // 
            this.tbNamaCustomer.Enabled = false;
            this.tbNamaCustomer.Location = new System.Drawing.Point(387, 212);
            this.tbNamaCustomer.Name = "tbNamaCustomer";
            this.tbNamaCustomer.Size = new System.Drawing.Size(225, 22);
            this.tbNamaCustomer.TabIndex = 62;
            // 
            // mKategoriBindingSource
            // 
            this.mKategoriBindingSource.DataMember = "mKategori";
            this.mKategoriBindingSource.DataSource = this.haloTekDataSet;
            // 
            // haloTekDataSet
            // 
            this.haloTekDataSet.DataSetName = "HaloTekDataSet";
            this.haloTekDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(448, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 17);
            this.label3.TabIndex = 67;
            this.label3.Text = "Update Customer";
            // 
            // btnUbah
            // 
            this.btnUbah.Location = new System.Drawing.Point(312, 364);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(71, 26);
            this.btnUbah.TabIndex = 70;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = true;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // btnCari
            // 
            this.btnCari.Location = new System.Drawing.Point(643, 153);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(71, 26);
            this.btnCari.TabIndex = 71;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // UpdateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.tbIdCustomer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbNoTelponCustomer);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNamaCustomer);
            this.Controls.Add(this.label3);
            this.Name = "UpdateCustomer";
            this.Text = "UpdateCustomer";
            ((System.ComponentModel.ISupportInitialize)(this.mKategoriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.haloTekDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbIdCustomer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNoTelponCustomer;
        private HaloTekDataSetTableAdapters.mKategoriTableAdapter mKategoriTableAdapter;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNamaCustomer;
        private System.Windows.Forms.BindingSource mKategoriBindingSource;
        private HaloTekDataSet haloTekDataSet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnCari;
    }
}