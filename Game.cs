using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class Game : Form
    {
    
        int xwin, owin,draw,turn;

        public void new_game_Click(object sender, EventArgs e)
        {
            newgame();
        }
        #region function
        public void newgame()
        {
           /* player1.Text = "";
            player2.Text = "";*/
            foreach (Button btn in dashboards.Controls)
            {
                turn = 0;
                btn.Text = "";
                btn.Enabled = true;

            }
        }
        private void btn_00_Click(object sender, EventArgs e)
        {
            putxo(btn_00); 
        }

        private void btn_01_Click(object sender, EventArgs e)
        {
            putxo(btn_01);
        }

        private void btn_02_Click(object sender, EventArgs e)
        {
            putxo(btn_02);
        }

        private void btn_10_Click(object sender, EventArgs e)
        {
            putxo(btn_10);
        }

        private void btn_11_Click(object sender, EventArgs e)
        {
            putxo(btn_11);
        }

        private void btn_12_Click(object sender, EventArgs e)
        {
            putxo(btn_12);
        }

        private void btn_20_Click(object sender, EventArgs e)
        {
            putxo(btn_20);
        }

        private void btn_21_Click(object sender, EventArgs e)
        {
            putxo(btn_21);
        }

        private void btn_22_Click(object sender, EventArgs e)
        {
            putxo(btn_22);
        }

        public void putxo(Button btn)
        {
            turn = turn + 1;
            if (turn % 2 == 0)
            {
                btn.Text = "X";
                btn.Enabled = false;
            }
            else {
                btn.Text = "O";
                btn.Enabled = false;
            }
            if(turn==9)
            {
                draw++;
                MessageBox.Show("You both played but no one of you can win shame on you Guys");
                draws.Text = draw.ToString();
            }
            checkwin(btn);
        }

        private void x_wins_Click(object sender, EventArgs e)
        {

        }

        private void y_wins_Click(object sender, EventArgs e)
        {

        }

        private void reset_Click(object sender, EventArgs e)
        {
            xwin = 0;
            owin = 0;
            draw = 0;
            x_wins.Text="0";
            y_wins.Text = "0";
            draws.Text = "0";
            btn_00.Text = "";
            btn_01.Text = "";
            btn_02.Text = "";
            btn_10.Text = "";
            btn_11.Text = "";
            btn_12.Text = "";
            btn_20.Text = "";
            btn_21.Text = "";
            btn_22.Text = "";
            player1.Text = "";
            player2.Text = "";
            foreach (Button btn in dashboards.Controls)
            {
                turn = 0;
                btn.Text = "";
                btn.Enabled = true;
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to Quit the best game in the world?")==DialogResult.OK)
                this.Close();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login a = new Login();
            a.Show();
        }

        public void checkwin(Button btn)
        {
            bool flag = false;
            if (btn_00.Text == btn_01.Text && btn_01.Text == btn_02.Text && btn_00.Text != "")
                flag = true;
            else if (btn_10.Text == btn_11.Text && btn_11.Text == btn_12.Text && btn_10.Text != "")
                flag = true;
            else if (btn_20.Text == btn_21.Text && btn_21.Text == btn_22.Text && btn_20.Text != "")
                flag = true;
            else if (btn_00.Text == btn_10.Text && btn_10.Text == btn_20.Text && btn_00.Text != "")
                flag = true;
            else if (btn_01.Text == btn_11.Text && btn_11.Text == btn_21.Text && btn_01.Text != "")
                flag = true;
            else if (btn_02.Text == btn_12.Text && btn_12.Text == btn_22.Text && btn_02.Text != "")
                flag = true;
            else if (btn_00.Text == btn_11.Text && btn_11.Text == btn_22.Text && btn_00.Text != "")
                flag = true;
            else if (btn_02.Text == btn_11.Text && btn_11.Text == btn_20.Text && btn_02.Text != "")
                flag = true;
            if (flag == true)
            {
                if (btn.Text=="X")
                {
                    MessageBox.Show(player2.Text + " You Won the Game! but "+ player1.Text + " Won in Life!","Tic Tac Toe");
                    xwin++;

                    btn_00.Text = "";
                    btn_01.Text = "";
                    btn_02.Text = "";
                    btn_10.Text = "";
                    btn_11.Text = "";
                    btn_12.Text = "";
                    btn_20.Text = "";
                    btn_21.Text = "";
                    btn_22.Text = "";
                    newgame();

                }
                else
                {
                    MessageBox.Show(player1.Text + " You Won the Game! but " + player2.Text + " Won in Life!", "Tic Tac Toe");
                    owin++;
                    btn_00.Text = "";
                    btn_01.Text = "";
                    btn_02.Text = "";
                    btn_10.Text = "";
                    btn_11.Text = "";
                    btn_12.Text = "";
                    btn_20.Text = "";
                    btn_21.Text = "";
                    btn_22.Text = "";
                    newgame();
                }
                x_wins.Text = xwin.ToString();
                y_wins.Text = owin.ToString();
                foreach(Button stop in dashboards.Controls)

                {
                    stop.Enabled = false;
                }
            }

            
        }
        #endregion
        public Game()
        {
            InitializeComponent();
            xwin = 0;
            owin = 0;
            draw = 0;
            turn = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
