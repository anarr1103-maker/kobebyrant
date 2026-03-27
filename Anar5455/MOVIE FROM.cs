using MySql.Data.MySqlClient;
using System.Data;
using System;
using System.Windows.Forms;

namespace Anar5455
{
    public partial class MOVIE_FROM : Form
    {
        string connStr = "server=localhost;port=3306;database=movie;uid=root;pwd=P@ssw0rd;";
        public MOVIE_FROM()
        {
            InitializeComponent();
        }

        MySqlConnection GetConnection()
        {
            return new MySqlConnection(connStr);
        }

        private void MOVIE_FROM_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            {
                try
                {
                    using (var conn = GetConnection())
                    {
                        conn.Open();
                        MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM movie;", conn);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvMovie.DataSource = dt;

                        dgvMovie.Columns["movieID"].HeaderText = "ID";
                        dgvMovie.Columns["title"].HeaderText = "kinoni ner";
                        dgvMovie.Columns["year1"].HeaderText = "On";
                        dgvMovie.Columns["Director"].HeaderText = "Director";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dgvMovie_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMovie.CurrentRow != null)

            {
                DataGridViewRow row = dgvMovie.CurrentRow;

                txtID.Text = row.Cells["movieID"].Value?.ToString();
                txtTitle.Text = row.Cells["title"].Value?.ToString();
                txtYear.Text = row.Cells["year1"].Value?.ToString();
                txtDirector.Text = row.Cells["director"].Value?.ToString();

                string FileName = $@"{AppDomain.CurrentDomain.BaseDirectory}images\{txtID.Text}.jpg";
                string imgFileName = $@"{AppDomain.CurrentDomain.BaseDirectory}images\Nothing.jpg";
                if (File.Exists(FileName))
                {
                    imgFileName = FileName;
                }
                picMovie.Image = Image.FromFile(@imgFileName);
            }
        }

        private void btnzasah_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Kino songoltoo hiine uu");
                return;
            }
            try
            {
                using (var conn = GetConnection())
                {
                    conn.Open();
                    string sql = "UPDATE movie SET title=@title, year1=@year1, director=@director WHERE movieID=@movieID;";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@title", txtTitle.Text);
                    cmd.Parameters.AddWithValue("@year1", Convert.ToInt32(txtYear.Text));
                    cmd.Parameters.AddWithValue("@director", txtDirector.Text);
                    cmd.Parameters.AddWithValue("@movieID", txtID.Text);
                    cmd.ExecuteNonQuery();
                }
                LoadData();
                MessageBox.Show("Amjilttai zasagdlaa...");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Aldaa: " + ex.Message);
            }


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text) || string.IsNullOrWhiteSpace(txtTitle.Text) || string.IsNullOrWhiteSpace(txtYear.Text) || string.IsNullOrWhiteSpace(txtDirector.Text))
            {
                MessageBox.Show("Ogogdol buren oruulna uu");
                return;
            }

            try
            {
                using (var conn = GetConnection())
                {
                    conn.Open();

                    string sql = "SELECT * FROM movie WHERE movieID = @id";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", txtID.Text);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                MessageBox.Show(txtID.Text + "Dugaartai kino burtgeltei baina");
                            }
                            else
                            {
                                insertData();
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
        void insertData()
        {
            try
            {
                using (var conn = GetConnection())
                {
                    conn.Open();
                    string sql = "INSERT INTO movie (movieID, title, year1, director) VALUES (@movieID, @title, @year1, @director);";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@title", txtTitle.Text);
                    cmd.Parameters.AddWithValue("@year1", Convert.ToInt32(txtYear.Text));
                    cmd.Parameters.AddWithValue("@director", txtDirector.Text);
                    cmd.Parameters.AddWithValue("movieID", txtID.Text);
                    cmd.ExecuteNonQuery();
                }
                LoadData();
                MessageBox.Show("Amjilttai nemegdlee...");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Aldaa: " + ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {



        }
    }
}

