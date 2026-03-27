using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Anar5455
{
    public partial class Form1 : Form
    {
        string connStr = "server=localhost;port=3306;database=movie;uid=root;pwd=P@ssw0rd";
        public Form1()
        {
            InitializeComponent();
        }

        MySqlConnection GetConnection()
        {
            return new MySqlConnection(connStr);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Ner, nuuts ugee oruulna uu");
                return;
            }
       

            try
            {
                using (var conn = GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT * FROM reviewer WHERE rName = @name AND rPass = @pass";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", txtUserName.Text);
                        cmd.Parameters.AddWithValue("@pass", txtPassword.Text);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                MessageBox.Show("Login amjilttai");

                                new mainForm().Show();
                                 this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Ner eswel nuuts ug buruu");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Aldaa: " + ex.Message);
            }
        }
    }
}


