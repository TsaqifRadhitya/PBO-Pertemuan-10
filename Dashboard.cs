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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PBO_Pertemuan_9
{
    public partial class Dashboard : Form
    {
        string username;
        public Dashboard(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            label1.Text = $"Halo {username} !!";
            loadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tambah_Edit_Tugas tambah_tugas = new Tambah_Edit_Tugas("Tambah");
            tambah_tugas.ShowDialog();
            loadData();
        }

        private void loadData()
        {
            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Database=PBO Praktikum;port = 5432");
            conn.Open();
            NpgsqlCommand npgsqlCommand = new NpgsqlCommand();
            npgsqlCommand.Connection = conn;
            npgsqlCommand.CommandText = $"SELECT * FROM TUGAS ORDER BY ID";
            DataTable data = new DataTable();
            data.Load(npgsqlCommand.ExecuteReader());
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = data;
            dataGridView1.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "Update",
                UseColumnTextForButtonValue = true,
                Text = "Update"
            });
            dataGridView1.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "Delete",
                UseColumnTextForButtonValue = true,
                Text = "Delete"
            });
            conn.Close();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Update"].Index)
            {
                Tambah_Edit_Tugas edit_tugas = new Tambah_Edit_Tugas("Hapus");
                edit_tugas.matakuliah = dataGridView1.Rows[e.RowIndex].Cells["matakuliah"].Value.ToString();
                edit_tugas.id = (int)dataGridView1.Rows[e.RowIndex].Cells["id"].Value;
                edit_tugas.deadline = dataGridView1.Rows[e.RowIndex].Cells["deadline"].Value.ToString();
                edit_tugas.namatugas = dataGridView1.Rows[e.RowIndex].Cells["nama_tugas"].Value.ToString();
                edit_tugas.ShowDialog();
                loadData();
            }
            if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index)
            {
                NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Database=PBO Praktikum;port = 5432");
                conn.Open();
                NpgsqlCommand npgsqlCommand = new NpgsqlCommand();
                npgsqlCommand.Connection = conn;
                DataGridViewRow selectedData = dataGridView1.Rows[e.RowIndex];
                npgsqlCommand.CommandText = $"delete from tugas where id = {(int)selectedData.Cells["id"].Value}";
                npgsqlCommand.ExecuteNonQuery();
                conn.Close();
                loadData();
            }
            if (e.ColumnIndex == dataGridView1.Columns["status"].Index)
            {
                NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Database=PBO Praktikum;port = 5432");
                conn.Open();
                NpgsqlCommand npgsqlCommand = new NpgsqlCommand();
                npgsqlCommand.Connection = conn;
                DataGridViewRow selectedData = dataGridView1.Rows[e.RowIndex];
                npgsqlCommand.CommandText = $"update tugas set status =  {!(bool)selectedData.Cells["status"].Value} where id = {(int)selectedData.Cells["id"].Value}";
                npgsqlCommand.ExecuteNonQuery();
                conn.Close();
                loadData();
            }
        }
    }
}
