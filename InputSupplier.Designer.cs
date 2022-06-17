namespace HaloTek
{
    partial class InputSupplier
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
            this.haloTekDataSet = new HaloTek.HaloTekDataSet();
            this.mKategoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mKategoriTableAdapter = new HaloTek.HaloTekDataSetTableAdapters.mKategoriTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNamaSupplier = new System.Windows.Forms.TextBox();
            this.tbIdSupplier = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbAlamatSupplier = new System.Windows.Forms.TextBox();
            this.tbNoTelponSupplier = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.haloTekDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mKategoriBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(437, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "Input Supplier";
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(530, 360);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(71, 26);
            this.btnBatal.TabIndex = 29;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(376, 360);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(71, 26);
            this.btnSimpan.TabIndex = 28;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Nama Supplier : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "ID Supplier : ";
            // 
            // tbNamaSupplier
            // 
            this.tbNamaSupplier.Location = new System.Drawing.Point(376, 161);
            this.tbNamaSupplier.Name = "tbNamaSupplier";
            this.tbNamaSupplier.Size = new System.Drawing.Size(225, 22);
            this.tbNamaSupplier.TabIndex = 25;
            // 
            // tbIdSupplier
            // 
            this.tbIdSupplier.Location = new System.Drawing.Point(376, 108);
            this.tbIdSupplier.Name = "tbIdSupplier";
            this.tbIdSupplier.Size = new System.Drawing.Size(225, 22);
            this.tbIdSupplier.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "No Telpon Supplier :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(178, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "Alamat Supplier :";
            // 
            // tbAlamatSupplier
            // 
            this.tbAlamatSupplier.Location = new System.Drawing.Point(376, 250);
            this.tbAlamatSupplier.Name = "tbAlamatSupplier";
            this.tbAlamatSupplier.Size = new System.Drawing.Size(225, 22);
            this.tbAlamatSupplier.TabIndex = 33;
            // 
            // tbNoTelponSupplier
            // 
            this.tbNoTelponSupplier.Location = new System.Drawing.Point(376, 207);
            this.tbNoTelponSupplier.Name = "tbNoTelponSupplier";
            this.tbNoTelponSupplier.Size = new System.Drawing.Size(225, 22);
            this.tbNoTelponSupplier.TabIndex = 34;
            // 
            // InputSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 596);
            this.Controls.Add(this.tbNoTelponSupplier);
            this.Controls.Add(this.tbAlamatSupplier);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNamaSupplier);
            this.Controls.Add(this.tbIdSupplier);
            this.Name = "InputSupplier";
            this.Text = "InputSupplier";
            ((System.ComponentModel.ISupportInitialize)(this.haloTekDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mKategoriBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private HaloTekDataSet haloTekDataSet;
        private System.Windows.Forms.BindingSource mKategoriBindingSource;
        private HaloTekDataSetTableAdapters.mKategoriTableAdapter mKategoriTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNamaSupplier;
        private System.Windows.Forms.TextBox tbIdSupplier;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbAlamatSupplier;
        private System.Windows.Forms.TextBox tbNoTelponSupplier;
    }
}