﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIC_TAC_TOE_
{
    public partial class Form1 : Form
    {
        bool turn = true; //true = A turn; false = B turn
        int turn_count = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }//app closed
        private void button_clicked(object sender, EventArgs e)
        {
            Button x = (Button)sender;
            if (turn)
                x.Text = "X";
            else
                x.Text = "O";
            turn = !turn;
            x.Enabled = false;
            turn_count++;
            doWeHaveAWinner();
        }//end of if
        private void doWeHaveAWinner()
        {
            bool weHaveAWinner = false;
            //checking horizontally
            if ((button_1.Text == button_2.Text) && (button_2.Text == button_3.Text) && (!button_1.Enabled))
                weHaveAWinner = true;
            else if ((button_4.Text == button_5.Text) && (button_5.Text == button_6.Text) && (!button_4.Enabled))
                weHaveAWinner = true;
            else if ((button_7.Text == button_8.Text) && (button_8.Text == button_9.Text) && (!button_7.Enabled))
                weHaveAWinner = true;
            if (weHaveAWinner)
            {
                String winner = "";
                if (turn)
                    winner = "O";
                else 
                    winner = "X";
                MessageBox.Show(winner + " is the winner!", "Winner winner chicken dinner!!");
            }//end of if
        }//end of weHaveAWinner
    }
}
