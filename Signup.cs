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
    public partial class Signup : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Study_material\SEM5\Mini-Project-II\game\tac-main\game.mdf;Integrated Security=True";
        public Signup()
        {
            InitializeComponent();
        }

        void connection()
        {
            con = new SqlConnection(connectionString);
            con.Open();
        }
        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtpass.Text == txtConfirmPass.Text)
            {
                connection();
                string query = "INSERT INTO Sign_tbl (Fullname, Username, Email, Pass) VALUES (@fullName, @username, @email, @password)";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@fullName", txtfname.Text);
                cmd.Parameters.AddWithValue("@username", txtuname.Text);
                cmd.Parameters.AddWithValue("@email", txtemail.Text);
                cmd.Parameters.AddWithValue("@password", txtpass.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Signup successful!");

                Login login = new Login();
                login.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Passwords do not match.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
