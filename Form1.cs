using Npgsql;

namespace PBO_Pertemuan_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                if (authLogin(textBox1.Text, textBox2.Text))
                {
                    MessageBox.Show("berhasil","Login",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    Dashboard dashboard = new Dashboard(textBox1.Text);
                    this.Hide();
                    dashboard.ShowDialog();
                    this.Close();
                }else
                {
                    MessageBox.Show("gagal","Login",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                return;
            }
            MessageBox.Show("Login Gagal","Login" ,MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private bool authLogin(string username, string password)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Database=PBO Praktikum;port = 5432");
            conn.Open();
            NpgsqlCommand npgsqlCommand = new NpgsqlCommand();
            npgsqlCommand.Connection = conn;
            npgsqlCommand.CommandText = $"Select * from Akun where username = '{username}' AND password = '{password}' ";
            NpgsqlDataReader data = npgsqlCommand.ExecuteReader();
            bool result = data.Read();
            conn.Close();
            return result;
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.ShowDialog();
            this.Show();
        }
    }
}
