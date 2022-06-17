namespace HaloTek
{
    partial class InputUser
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
            this.tbIdUser = new System.Windows.Forms.TextBox();
            this.haloTekDataSet = new HaloTek.HaloTekDataSet();
            this.mKategoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mKategoriTableAdapter = new HaloTek.HaloTekDataSetTableAdapters.mKategoriTableAdapter();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNamaUser = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbJabatan = new System.Windows.Forms.TextBox();
            this.tbNoTelpUser = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.haloTekDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mKategoriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbIdUser
            // 
            this.tbIdUser.Location = new System.Drawing.Point(387, 136);
            this.tbIdUser.Name = "tbIdUser";
            this.tbIdUser.Size = new System.Drawing.Size(225, 22);
            this.tbIdUser.TabIndex = 35;
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
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(387, 235);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(225, 22);
            this.tbUsername.TabIndex = 45;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(387, 278);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(225, 22);
            this.tbPassword.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(189, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 43;
            this.label5.Text = "Password :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 42;
            this.label4.Text = "Username :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(448, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 41;
            this.label3.Text = "Input User";
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(541, 412);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(71, 26);
            this.btnBatal.TabIndex = 40;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(387, 412);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(71, 26);
            this.btnSimpan.TabIndex = 39;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 38;
            this.label2.Text = "Nama User :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 37;
            this.label1.Text = "ID User :";
            // 
            // tbNamaUser
            // 
            this.tbNamaUser.Location = new System.Drawing.Point(387, 189);
            this.tbNamaUser.Name = "tbNamaUser";
            this.tbNamaUser.Size = new System.Drawing.Size(225, 22);
            this.tbNamaUser.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(189, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 46;
            this.label6.Text = "Jabatan :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(189, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 17);
            this.label7.TabIndex = 47;
            this.label7.Text = "No Telpon User :";
            // 
            // tbJabatan
            // 
            this.tbJabatan.Location = new System.Drawing.Point(387, 316);
            this.tbJabatan.Name = "tbJabatan";
            this.tbJabatan.Size = new System.Drawing.Size(225, 22);
            this.tbJabatan.TabIndex = 48;
            // 
            // tbNoTelpUser
            // 
            this.tbNoTelpUser.Location = new System.Drawing.Point(387, 357);
            this.tbNoTelpUser.Name = "tbNoTelpUser";
            this.tbNoTelpUser.Size = new System.Drawing.Size(225, 22);
            this.tbNoTelpUser.TabIndex = 49;
            // 
            // InputUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbNoTelpUser);
            this.Controls.Add(this.tbJabatan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbIdUser);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNamaUser);
            this.Name = "InputUser";
            this.Text = "InputUser";
            ((System.ComponentModel.ISupportInitialize)(this.haloTekDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mKategoriBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbIdUser;
        private HaloTekDataSet haloTekDataSet;
        private System.Windows.Forms.BindingSource mKategoriBindingSource;
        private HaloTekDataSetTableAdapters.mKategoriTableAdapter mKategoriTableAdapter;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNamaUser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbJabatan;
        private System.Windows.Forms.TextBox tbNoTelpUser;
    }
}