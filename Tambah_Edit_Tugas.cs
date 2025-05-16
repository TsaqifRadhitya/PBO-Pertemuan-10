using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PBO_Pertemuan_9
{
    public partial class Tambah_Edit_Tugas : Form
    {
        string type;
        public string namatugas, deadline, matakuliah;
        public int id;

        public Tambah_Edit_Tugas(string type)
        {
            InitializeComponent();
            this.type = type;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && comboBox1.Text != "")
            {
                executeTask();
                MessageBox.Show(type == "Tambah" ? "Tambah Tugas" : "Ubah Tugas", type == "Tambah" ? "Berhasil Menambah Tugas" : "Berhasil Mengubah Tugas",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }

            if (textBox1.Text == "")
            {
                errName.Text = "Harap Memasukkan Nama Tugas";
            }

            if (comboBox1.Text == "")
            {
                errMatkul.Text = "Harap Memasukkan Matakuliah";
            }
        }

        private void executeTask()
        {
            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Database=PBO Praktikum;port = 5432");
            conn.Open();
            NpgsqlCommand npgsqlCommand = new NpgsqlCommand();
            npgsqlCommand.Connection = conn;
            if (type == "Tambah")
            {
                npgsqlCommand.CommandText = $"INSERT INTO tugas(nama_tugas,matakuliah,deadline) Values ('{textBox1.Text}','{comboBox1.Text}','{dateTimePicker1.Value}')";
            }
            else
            {
                npgsqlCommand.CommandText = $"update tugas set nama_tugas = '{textBox1.Text}', matakuliah = '{comboBox1.Text}', deadline = '{dateTimePicker1.Value}' where id = {id}";
            }
            npgsqlCommand.ExecuteNonQuery();
            conn.Close();
        }

        private void Tambah_Edit_Tugas_Load(object sender, EventArgs e)
        {
            if (this.type == "Tambah")
            {
                label1.Text = "Tambah Data Tugas";
                button1.Text = "Tambahkan";
            }
            else
            {
                label1.Text = "Ubah Data Tugas";
                button1.Text = "Perbarui";
                textBox1.Text = namatugas;
                comboBox1.Text = matakuliah;
                dateTimePicker1.Value = DateTime.Parse(deadline);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                errName.Text = string.Empty;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                errMatkul.Text = string.Empty;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }
    }
}
