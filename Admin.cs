using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
namespace WindowsFormsApp1
{
    public partial class Admin : Form
    {
        int id;
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;

        string s = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Study_material\SEM5\Mini-Project-II\game\tac-main\game.mdf;Integrated Security=True";
        void connection()
        {
            con = new SqlConnection(s);
            con.Open();
        }
        void fillg()
        {
            da = new SqlDataAdapter("select Id,Fullname,Username,Email,Pass from Sign_tbl", con);
            ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        public Admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login a = new Login();
            a.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {
            connection();
            fillg();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            connection();
            id = Convert.ToInt16(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);

            cmd = new SqlCommand("delete from Sign_tbl where Id='" + id + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Deleted Record");
            fillg();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
