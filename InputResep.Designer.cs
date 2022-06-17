namespace HaloTek
{
    partial class InputResep
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
            this.tbIdResep = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mKategoriTableAdapter = new HaloTek.HaloTekDataSetTableAdapters.mKategoriTableAdapter();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mKategoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.haloTekDataSet = new HaloTek.HaloTekDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPenyakit = new System.Windows.Forms.TextBox();
            this.dtTglInput = new System.Windows.Forms.DateTimePicker();
            this.cbNamaCustomer = new System.Windows.Forms.ComboBox();
            this.cbNamaObat = new System.Windows.Forms.ComboBox();
            this.haloTekDataSet1 = new HaloTek.HaloTekDataSet1();
            this.mCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mCustomerTableAdapter = new HaloTek.HaloTekDataSet1TableAdapters.mCustomerTableAdapter();
            this.haloTekDataSet2 = new HaloTek.HaloTekDataSet2();
            this.mObatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mObatTableAdapter = new HaloTek.HaloTekDataSet2TableAdapters.mObatTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.mKategoriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.haloTekDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.haloTekDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mCustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.haloTekDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mObatBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbIdResep
            // 
            this.tbIdResep.Location = new System.Drawing.Point(387, 159);
            this.tbIdResep.Name = "tbIdResep";
            this.tbIdResep.Size = new System.Drawing.Size(225, 22);
            this.tbIdResep.TabIndex = 61;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 68;
            this.label4.Text = "Nama Obat :";
            // 
            // mKategoriTableAdapter
            // 
            this.mKategoriTableAdapter.ClearBeforeFill = true;
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(541, 412);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(71, 26);
            this.btnBatal.TabIndex = 66;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(387, 412);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(71, 26);
            this.btnSimpan.TabIndex = 65;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
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
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 63;
            this.label1.Text = "ID Resep :";
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
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 67;
            this.label3.Text = "Input Resep";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(189, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 70;
            this.label5.Text = "Penyakit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(189, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 17);
            this.label6.TabIndex = 71;
            this.label6.Text = "Tanggal Input";
            // 
            // tbPenyakit
            // 
            this.tbPenyakit.Location = new System.Drawing.Point(387, 310);
            this.tbPenyakit.Name = "tbPenyakit";
            this.tbPenyakit.Size = new System.Drawing.Size(225, 22);
            this.tbPenyakit.TabIndex = 72;
            // 
            // dtTglInput
            // 
            this.dtTglInput.Location = new System.Drawing.Point(387, 364);
            this.dtTglInput.Name = "dtTglInput";
            this.dtTglInput.Size = new System.Drawing.Size(200, 22);
            this.dtTglInput.TabIndex = 73;
            // 
            // cbNamaCustomer
            // 
            this.cbNamaCustomer.DataSource = this.mCustomerBindingSource;
            this.cbNamaCustomer.DisplayMember = "nama_customer";
            this.cbNamaCustomer.FormattingEnabled = true;
            this.cbNamaCustomer.Location = new System.Drawing.Point(387, 215);
            this.cbNamaCustomer.Name = "cbNamaCustomer";
            this.cbNamaCustomer.Size = new System.Drawing.Size(218, 24);
            this.cbNamaCustomer.TabIndex = 74;
            this.cbNamaCustomer.ValueMember = "id_customer";
            // 
            // cbNamaObat
            // 
            this.cbNamaObat.DataSource = this.mObatBindingSource;
            this.cbNamaObat.DisplayMember = "nama_obat";
            this.cbNamaObat.FormattingEnabled = true;
            this.cbNamaObat.Location = new System.Drawing.Point(387, 261);
            this.cbNamaObat.Name = "cbNamaObat";
            this.cbNamaObat.Size = new System.Drawing.Size(218, 24);
            this.cbNamaObat.TabIndex = 75;
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
            // mCustomerTableAdapter
            // 
            this.mCustomerTableAdapter.ClearBeforeFill = true;
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
            // mObatTableAdapter
            // 
            this.mObatTableAdapter.ClearBeforeFill = true;
            // 
            // InputResep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbNamaObat);
            this.Controls.Add(this.cbNamaCustomer);
            this.Controls.Add(this.dtTglInput);
            this.Controls.Add(this.tbPenyakit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbIdResep);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Name = "InputResep";
            this.Text = "InputResep";
            this.Load += new System.EventHandler(this.InputResep_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mKategoriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.haloTekDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.haloTekDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mCustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.haloTekDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mObatBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbIdResep;
        private System.Windows.Forms.Label label4;
        private HaloTekDataSetTableAdapters.mKategoriTableAdapter mKategoriTableAdapter;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource mKategoriBindingSource;
        private HaloTekDataSet haloTekDataSet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPenyakit;
        private System.Windows.Forms.DateTimePicker dtTglInput;
        private System.Windows.Forms.ComboBox cbNamaCustomer;
        private System.Windows.Forms.ComboBox cbNamaObat;
        private HaloTekDataSet1 haloTekDataSet1;
        private System.Windows.Forms.BindingSource mCustomerBindingSource;
        private HaloTekDataSet1TableAdapters.mCustomerTableAdapter mCustomerTableAdapter;
        private HaloTekDataSet2 haloTekDataSet2;
        private System.Windows.Forms.BindingSource mObatBindingSource;
        private HaloTekDataSet2TableAdapters.mObatTableAdapter mObatTableAdapter;
    }
}