
namespace WindowsFormsApp1
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.player1 = new System.Windows.Forms.TextBox();
            this.player2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.x_wins = new System.Windows.Forms.Label();
            this.y_wins = new System.Windows.Forms.Label();
            this.draws = new System.Windows.Forms.Label();
            this.new_game = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.dashboards = new System.Windows.Forms.GroupBox();
            this.btn_22 = new System.Windows.Forms.Button();
            this.btn_21 = new System.Windows.Forms.Button();
            this.btn_20 = new System.Windows.Forms.Button();
            this.btn_12 = new System.Windows.Forms.Button();
            this.btn_11 = new System.Windows.Forms.Button();
            this.btn_10 = new System.Windows.Forms.Button();
            this.btn_02 = new System.Windows.Forms.Button();
            this.btn_01 = new System.Windows.Forms.Button();
            this.btn_00 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dashboards.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Player 2";
            // 
            // player1
            // 
            this.player1.BackColor = System.Drawing.Color.RosyBrown;
            this.player1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1.Location = new System.Drawing.Point(183, 53);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(188, 30);
            this.player1.TabIndex = 2;
            // 
            // player2
            // 
            this.player2.BackColor = System.Drawing.Color.RosyBrown;
            this.player2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2.Location = new System.Drawing.Point(183, 93);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(188, 30);
            this.player2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(106, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "Score Board";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 32);
            this.label4.TabIndex = 5;
            this.label4.Text = "X - Wins";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(62, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 32);
            this.label5.TabIndex = 6;
            this.label5.Text = "O - Wins";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(62, 402);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 32);
            this.label6.TabIndex = 7;
            this.label6.Text = "Draws";
            // 
            // x_wins
            // 
            this.x_wins.AutoSize = true;
            this.x_wins.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x_wins.Location = new System.Drawing.Point(220, 271);
            this.x_wins.Name = "x_wins";
            this.x_wins.Size = new System.Drawing.Size(31, 32);
            this.x_wins.TabIndex = 8;
            this.x_wins.Text = "0";
            this.x_wins.Click += new System.EventHandler(this.x_wins_Click);
            // 
            // y_wins
            // 
            this.y_wins.AutoSize = true;
            this.y_wins.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.y_wins.Location = new System.Drawing.Point(220, 333);
            this.y_wins.Name = "y_wins";
            this.y_wins.Size = new System.Drawing.Size(31, 32);
            this.y_wins.TabIndex = 9;
            this.y_wins.Text = "0";
            this.y_wins.Click += new System.EventHandler(this.y_wins_Click);
            // 
            // draws
            // 
            this.draws.AutoSize = true;
            this.draws.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.draws.Location = new System.Drawing.Point(220, 402);
            this.draws.Name = "draws";
            this.draws.Size = new System.Drawing.Size(31, 32);
            this.draws.TabIndex = 10;
            this.draws.Text = "0";
            // 
            // new_game
            // 
            this.new_game.BackColor = System.Drawing.Color.Salmon;
            this.new_game.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_game.Location = new System.Drawing.Point(73, 528);
            this.new_game.Name = "new_game";
            this.new_game.Size = new System.Drawing.Size(298, 56);
            this.new_game.TabIndex = 11;
            this.new_game.Text = "New Game";
            this.new_game.UseVisualStyleBackColor = false;
            this.new_game.Click += new System.EventHandler(this.new_game_Click);
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.Salmon;
            this.reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.Location = new System.Drawing.Point(39, 617);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(146, 45);
            this.reset.TabIndex = 12;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Salmon;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(264, 617);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(146, 45);
            this.exit.TabIndex = 13;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // dashboards
            // 
            this.dashboards.BackColor = System.Drawing.Color.PeachPuff;
            this.dashboards.Controls.Add(this.btn_22);
            this.dashboards.Controls.Add(this.btn_21);
            this.dashboards.Controls.Add(this.btn_20);
            this.dashboards.Controls.Add(this.btn_12);
            this.dashboards.Controls.Add(this.btn_11);
            this.dashboards.Controls.Add(this.btn_10);
            this.dashboards.Controls.Add(this.btn_02);
            this.dashboards.Controls.Add(this.btn_01);
            this.dashboards.Controls.Add(this.btn_00);
            this.dashboards.Location = new System.Drawing.Point(512, 26);
            this.dashboards.Name = "dashboards";
            this.dashboards.Size = new System.Drawing.Size(1171, 727);
            this.dashboards.TabIndex = 14;
            this.dashboards.TabStop = false;
            // 
            // btn_22
            // 
            this.btn_22.BackColor = System.Drawing.Color.Sienna;
            this.btn_22.Enabled = false;
            this.btn_22.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_22.Location = new System.Drawing.Point(645, 358);
            this.btn_22.Name = "btn_22";
            this.btn_22.Size = new System.Drawing.Size(126, 112);
            this.btn_22.TabIndex = 8;
            this.btn_22.UseVisualStyleBackColor = false;
            this.btn_22.Click += new System.EventHandler(this.btn_22_Click);
            // 
            // btn_21
            // 
            this.btn_21.BackColor = System.Drawing.Color.Sienna;
            this.btn_21.Enabled = false;
            this.btn_21.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_21.Location = new System.Drawing.Point(509, 358);
            this.btn_21.Name = "btn_21";
            this.btn_21.Size = new System.Drawing.Size(130, 112);
            this.btn_21.TabIndex = 7;
            this.btn_21.UseVisualStyleBackColor = false;
            this.btn_21.Click += new System.EventHandler(this.btn_21_Click);
            // 
            // btn_20
            // 
            this.btn_20.BackColor = System.Drawing.Color.Sienna;
            this.btn_20.Enabled = false;
            this.btn_20.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_20.Location = new System.Drawing.Point(372, 362);
            this.btn_20.Name = "btn_20";
            this.btn_20.Size = new System.Drawing.Size(131, 108);
            this.btn_20.TabIndex = 6;
            this.btn_20.UseVisualStyleBackColor = false;
            this.btn_20.Click += new System.EventHandler(this.btn_20_Click);
            // 
            // btn_12
            // 
            this.btn_12.BackColor = System.Drawing.Color.Sienna;
            this.btn_12.Enabled = false;
            this.btn_12.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_12.Location = new System.Drawing.Point(645, 249);
            this.btn_12.Name = "btn_12";
            this.btn_12.Size = new System.Drawing.Size(126, 103);
            this.btn_12.TabIndex = 5;
            this.btn_12.UseVisualStyleBackColor = false;
            this.btn_12.Click += new System.EventHandler(this.btn_12_Click);
            // 
            // btn_11
            // 
            this.btn_11.BackColor = System.Drawing.Color.Sienna;
            this.btn_11.Enabled = false;
            this.btn_11.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_11.Location = new System.Drawing.Point(509, 249);
            this.btn_11.Name = "btn_11";
            this.btn_11.Size = new System.Drawing.Size(130, 103);
            this.btn_11.TabIndex = 4;
            this.btn_11.UseVisualStyleBackColor = false;
            this.btn_11.Click += new System.EventHandler(this.btn_11_Click);
            // 
            // btn_10
            // 
            this.btn_10.BackColor = System.Drawing.Color.Sienna;
            this.btn_10.Enabled = false;
            this.btn_10.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_10.Location = new System.Drawing.Point(372, 249);
            this.btn_10.Name = "btn_10";
            this.btn_10.Size = new System.Drawing.Size(131, 107);
            this.btn_10.TabIndex = 3;
            this.btn_10.UseVisualStyleBackColor = false;
            this.btn_10.Click += new System.EventHandler(this.btn_10_Click);
            // 
            // btn_02
            // 
            this.btn_02.BackColor = System.Drawing.Color.Sienna;
            this.btn_02.Enabled = false;
            this.btn_02.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_02.Location = new System.Drawing.Point(645, 131);
            this.btn_02.Name = "btn_02";
            this.btn_02.Size = new System.Drawing.Size(126, 112);
            this.btn_02.TabIndex = 2;
            this.btn_02.UseVisualStyleBackColor = false;
            this.btn_02.Click += new System.EventHandler(this.btn_02_Click);
            // 
            // btn_01
            // 
            this.btn_01.BackColor = System.Drawing.Color.Sienna;
            this.btn_01.Enabled = false;
            this.btn_01.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_01.Location = new System.Drawing.Point(509, 132);
            this.btn_01.Name = "btn_01";
            this.btn_01.Size = new System.Drawing.Size(130, 111);
            this.btn_01.TabIndex = 1;
            this.btn_01.UseVisualStyleBackColor = false;
            this.btn_01.Click += new System.EventHandler(this.btn_01_Click);
            // 
            // btn_00
            // 
            this.btn_00.BackColor = System.Drawing.Color.Sienna;
            this.btn_00.Enabled = false;
            this.btn_00.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_00.Location = new System.Drawing.Point(372, 131);
            this.btn_00.Name = "btn_00";
            this.btn_00.Size = new System.Drawing.Size(131, 112);
            this.btn_00.TabIndex = 0;
            this.btn_00.UseVisualStyleBackColor = false;
            this.btn_00.Click += new System.EventHandler(this.btn_00_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Red;
            this.label7.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(1778, -1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 22);
            this.label7.TabIndex = 15;
            this.label7.Text = "X";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dashboards);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.new_game);
            this.Controls.Add(this.draws);
            this.Controls.Add(this.y_wins);
            this.Controls.Add(this.x_wins);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.player2);
            this.Controls.Add(this.player1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.dashboards.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox player1;
        private System.Windows.Forms.TextBox player2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label x_wins;
        private System.Windows.Forms.Label y_wins;
        private System.Windows.Forms.Label draws;
        private System.Windows.Forms.Button new_game;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.GroupBox dashboards;
        private System.Windows.Forms.Button btn_22;
        private System.Windows.Forms.Button btn_21;
        private System.Windows.Forms.Button btn_20;
        private System.Windows.Forms.Button btn_12;
        private System.Windows.Forms.Button btn_11;
        private System.Windows.Forms.Button btn_10;
        private System.Windows.Forms.Button btn_02;
        private System.Windows.Forms.Button btn_01;
        private System.Windows.Forms.Button btn_00;
        private System.Windows.Forms.Label label7;
    }
}

