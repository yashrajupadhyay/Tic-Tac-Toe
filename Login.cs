using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Study_material\SEM5\Mini-Project-II\game\tac-main\game.mdf;Integrated Security=True";

        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;

        void connection()
        {
            con = new SqlConnection(connectionString);
            con.Open();
        }

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection();
            string query = "SELECT COUNT(*) FROM Sign_tbl WHERE Username=@username AND Pass=@password";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@username", txtuname.Text);
            cmd.Parameters.AddWithValue("@password", txtpass.Text);


            try
            {
                // Execute the query and get the result
                int result = (int)cmd.ExecuteScalar();

                // Check if any matching record was found
                if (result > 0)
                {
                    // If valid, open the Game form and hide the login form
                    Game g = new Game();
                    g.Show();
                    this.Hide();
                }
                else
                {
                    // If invalid, show an error message
                    MessageBox.Show("Invalid username or password");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error executing query: " + ex.Message);
            }
            finally
            {
                // Close the database connection
                if (con != null && con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            connection();
        }

        private void txtuname_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Signup s = new Signup();
            s.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (txtuname.Text == "admin" && txtpass.Text == "1234")
            {
                MessageBox.Show("Login done...", "Login");
                Admin a = new Admin();
                a.Show();
            }
            else
            {
                MessageBox.Show("Enter valid username or password");
            }
        }
    }
}
