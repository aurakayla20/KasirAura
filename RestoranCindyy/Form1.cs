using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RestoranCindyy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void NEW_Click(object sender, EventArgs e)
        {

            string connection = "server=localhost;user id=root;password=;database=kasiraura";
            string query = "INSERT INTO kasir(kode_barang, nama, harga_jual, harga_beli, jumlah_barang, satuan)VALUES('" + this.kode_barang.Text + "', '" + this.nama.Text + "', '" + this.harga_jual.Text + "', '" + this.harga_beli.Text + "', '" + this.jumlah_barang.Text + "', '" + this.satuan.Text + "')";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("Succesfully saved");
            conn.Close();
        }

        private void LOAD_DATA_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=kasiraura";
            string query = "SELECT * FROM kasir";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void EDIT_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=kasiraura";
            string query = "UPDATE kasir SET nama = '" + this.nama.Text + "', harga_jual = '" + this.harga_jual.Text + "', harga_beli = '" + this.harga_beli.Text + "', jumlah_barang = '" + this.jumlah_barang.Text + "', Satuan = '" + this.satuan.Text + "' WHERE kode_barang = '" + this.kode_barang.Text + "'";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("Record has been updated successfully");
            conn.Close();
        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=kasiraura";
            string query = "DELETE FROM kasir WHERE kode_barang ='" + this.kode_barang.Text + "'";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("Data has been successfully deleted!");
            conn.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
