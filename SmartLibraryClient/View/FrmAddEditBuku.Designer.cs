namespace SmartLibraryClient.View
{
    partial class FrmAddEditBuku
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
            this.cmbPenerbit = new System.Windows.Forms.ComboBox();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEdisi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBahasa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtJudul = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbPenerbit
            // 
            this.cmbPenerbit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPenerbit.FormattingEnabled = true;
            this.cmbPenerbit.Location = new System.Drawing.Point(74, 132);
            this.cmbPenerbit.Name = "cmbPenerbit";
            this.cmbPenerbit.Size = new System.Drawing.Size(290, 21);
            this.cmbPenerbit.TabIndex = 17;
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(289, 161);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(75, 23);
            this.btnBatal.TabIndex = 19;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(208, 161);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 18;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Penerbit";
            // 
            // txtEdisi
            // 
            this.txtEdisi.Location = new System.Drawing.Point(74, 104);
            this.txtEdisi.MaxLength = 2;
            this.txtEdisi.Name = "txtEdisi";
            this.txtEdisi.Size = new System.Drawing.Size(58, 20);
            this.txtEdisi.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Edisi";
            // 
            // txtBahasa
            // 
            this.txtBahasa.Location = new System.Drawing.Point(74, 76);
            this.txtBahasa.MaxLength = 20;
            this.txtBahasa.Name = "txtBahasa";
            this.txtBahasa.Size = new System.Drawing.Size(121, 20);
            this.txtBahasa.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Bahasa";
            // 
            // txtJudul
            // 
            this.txtJudul.Location = new System.Drawing.Point(74, 48);
            this.txtJudul.MaxLength = 255;
            this.txtJudul.Name = "txtJudul";
            this.txtJudul.Size = new System.Drawing.Size(290, 20);
            this.txtJudul.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Judul";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(74, 20);
            this.txtISBN.MaxLength = 20;
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(121, 20);
            this.txtISBN.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "ISBN";
            // 
            // FrmAddEditBuku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 224);
            this.Controls.Add(this.cmbPenerbit);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEdisi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBahasa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtJudul);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.label1);
            this.Name = "FrmAddEditBuku";
            this.Text = "FrmAddEditBuku";
            this.Load += new System.EventHandler(this.FrmAddEditBuku_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPenerbit;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEdisi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBahasa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtJudul;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label label1;
    }
}