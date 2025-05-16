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

namespace PBO_Pertemuan_9
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox2.Text == textBox3.Text) {
                bool registerValidation = register(textBox1.Text, textBox2.Text);
                if (registerValidation)
                {
                    MessageBox.Show("Register", "Register Berhasil",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Dashboard dashboard = new Dashboard(textBox1.Text);
                    this.Hide();
                    dashboard.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Register", "Register Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";

                }
                return;
            }
            MessageBox.Show("Register", "Harap Memasukkan username/password dengan benar", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private bool register(string username,string password)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Database=PBO Praktikum;port = 5432");
            conn.Open();
            NpgsqlCommand npgsqlCommand = new NpgsqlCommand();
            npgsqlCommand.Connection = conn;
            npgsqlCommand.CommandText = $"INSERT INTO AKUN(username,password) Values ('{username}','{password}')";
            try
            {
                npgsqlCommand.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch{
                conn.Close(); 
                return false;
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
