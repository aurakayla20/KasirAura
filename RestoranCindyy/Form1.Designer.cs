namespace RestoranCindyy
{
    partial class Form1
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
            this.NEW = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kode_barang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.harga_jual = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nama = new System.Windows.Forms.TextBox();
            this.DELETE = new System.Windows.Forms.Button();
            this.EDIT = new System.Windows.Forms.Button();
            this.LOAD_DATA = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.harga_beli = new System.Windows.Forms.TextBox();
            this.jumlah_barang = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.satuan = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NEW
            // 
            this.NEW.Location = new System.Drawing.Point(158, 640);
            this.NEW.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NEW.Name = "NEW";
            this.NEW.Size = new System.Drawing.Size(168, 35);
            this.NEW.TabIndex = 0;
            this.NEW.Text = "NEW";
            this.NEW.UseVisualStyleBackColor = true;
            this.NEW.Click += new System.EventHandler(this.NEW_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 440);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(959, 190);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 137);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nama";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.satuan);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.jumlah_barang);
            this.panel1.Controls.Add(this.harga_beli);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.kode_barang);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.harga_jual);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.nama);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(18, 18);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(963, 412);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // kode_barang
            // 
            this.kode_barang.BackColor = System.Drawing.SystemColors.Window;
            this.kode_barang.Location = new System.Drawing.Point(166, 82);
            this.kode_barang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.kode_barang.Name = "kode_barang";
            this.kode_barang.Size = new System.Drawing.Size(634, 26);
            this.kode_barang.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 86);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Kode Barang";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(378, 12);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 47);
            this.label4.TabIndex = 12;
            this.label4.Text = "Kasir Aura";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 262);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Harga Beli";
            // 
            // harga_jual
            // 
            this.harga_jual.Location = new System.Drawing.Point(166, 194);
            this.harga_jual.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.harga_jual.Name = "harga_jual";
            this.harga_jual.Size = new System.Drawing.Size(634, 26);
            this.harga_jual.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 198);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Harga Jual";
            // 
            // nama
            // 
            this.nama.BackColor = System.Drawing.SystemColors.Window;
            this.nama.Location = new System.Drawing.Point(166, 137);
            this.nama.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(634, 26);
            this.nama.TabIndex = 3;
            // 
            // DELETE
            // 
            this.DELETE.Location = new System.Drawing.Point(510, 640);
            this.DELETE.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(168, 35);
            this.DELETE.TabIndex = 11;
            this.DELETE.Text = "DELETE";
            this.DELETE.UseVisualStyleBackColor = true;
            this.DELETE.Click += new System.EventHandler(this.DELETE_Click);
            // 
            // EDIT
            // 
            this.EDIT.Location = new System.Drawing.Point(686, 640);
            this.EDIT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EDIT.Name = "EDIT";
            this.EDIT.Size = new System.Drawing.Size(168, 35);
            this.EDIT.TabIndex = 9;
            this.EDIT.Text = "EDIT";
            this.EDIT.UseVisualStyleBackColor = true;
            this.EDIT.Click += new System.EventHandler(this.EDIT_Click);
            // 
            // LOAD_DATA
            // 
            this.LOAD_DATA.Location = new System.Drawing.Point(334, 640);
            this.LOAD_DATA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LOAD_DATA.Name = "LOAD_DATA";
            this.LOAD_DATA.Size = new System.Drawing.Size(168, 35);
            this.LOAD_DATA.TabIndex = 8;
            this.LOAD_DATA.Text = "LOAD DATA";
            this.LOAD_DATA.UseVisualStyleBackColor = true;
            this.LOAD_DATA.Click += new System.EventHandler(this.LOAD_DATA_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 308);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Jumlah Barang";
            // 
            // harga_beli
            // 
            this.harga_beli.Location = new System.Drawing.Point(166, 256);
            this.harga_beli.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.harga_beli.Name = "harga_beli";
            this.harga_beli.Size = new System.Drawing.Size(634, 26);
            this.harga_beli.TabIndex = 16;
            // 
            // jumlah_barang
            // 
            this.jumlah_barang.Location = new System.Drawing.Point(166, 302);
            this.jumlah_barang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.jumlah_barang.Name = "jumlah_barang";
            this.jumlah_barang.Size = new System.Drawing.Size(634, 26);
            this.jumlah_barang.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 356);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Satuan";
            // 
            // satuan
            // 
            this.satuan.Location = new System.Drawing.Point(166, 356);
            this.satuan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.satuan.Name = "satuan";
            this.satuan.Size = new System.Drawing.Size(634, 26);
            this.satuan.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1000, 692);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.EDIT);
            this.Controls.Add(this.DELETE);
            this.Controls.Add(this.LOAD_DATA);
            this.Controls.Add(this.NEW);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NEW;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox harga_jual;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button DELETE;
        private System.Windows.Forms.Button EDIT;
        private System.Windows.Forms.Button LOAD_DATA;
        private System.Windows.Forms.TextBox kode_barang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox satuan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox jumlah_barang;
        private System.Windows.Forms.TextBox harga_beli;
        private System.Windows.Forms.Label label6;
    }
}

