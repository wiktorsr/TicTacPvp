using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoe
{
    public partial class Form1 : Form
    {
        private int playerQueue = 0;
        public Form1()
        {
            InitializeComponent();
        }
        
        private string xOrO()
        {
            string symbol;
            if((playerQueue%2)==0)
            {
                symbol= "X";
            }
            else
            {
                symbol= "O";
            }
            playerQueue++;
            return symbol;
        }

        private void winAlert(Button buttontest)
        {
            string winner;
            if (buttontest.Text.Equals("X"))
                winner = " pierwszy ";
            else
                winner = " drugi ";

            if (MessageBox.Show("Chcesz zagac ponownie?", "Gracz" + winner + "wygral", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                clean();
            }
            else
            {
                Application.Exit();
            }
        }
        private void winEqualizer(Button button1check, Button button2check, Button button3check)
        {
            if (button1check.Text.Equals(button2check.Text) && button2check.Text.Equals(button3check.Text))
            { 
                if (button1check.Text.Length == 1)
                {
                    button1check.BackColor = Color.Green;
                    button2check.BackColor = Color.Green;
                    button3check.BackColor = Color.Green;
                    winAlert(button1check);
                }
            }
        }
        private void winCheck()
        {
           if(playerQueue>4)
            {
                if(button1.Text.Equals(button2.Text)&& button2.Text.Equals(button3.Text))
                {
                    if(button1.Text.Length==1)
                    {
                        button1.BackColor = Color.Green;
                        button2.BackColor = Color.Green;
                        button3.BackColor = Color.Green;
                        winAlert(button1);
                    }

                }
                if (button4.Text.Equals(button5.Text) && button5.Text.Equals(button6.Text))
                {
                    if(button4.Text.Length==1)
                    {
                        button4.BackColor = Color.Green;
                        button5.BackColor = Color.Green;
                        button6.BackColor = Color.Green;
                        winAlert(button4);
                    }
                }
                if (button7.Text.Equals(button8.Text) && button8.Text.Equals(button9.Text))
                {
                    if(button7.Text.Length==1)
                    {
                        button7.BackColor = Color.Green;
                        button8.BackColor = Color.Green;
                        button9.BackColor = Color.Green;
                        winAlert(button7);
                    }
                }
                if (button1.Text.Equals(button4.Text) && button4.Text.Equals(button7.Text))
                {
                    if(button1.Text.Length==1)
                    {
                        button1.BackColor = Color.Green;
                        button4.BackColor = Color.Green;
                        button7.BackColor = Color.Green;
                        winAlert(button1);
                    }
                }
                if (button2.Text.Equals(button5.Text) && button5.Text.Equals(button8.Text))
                {
                    if(button2.Text.Length==1)
                    {
                        button2.BackColor = Color.Green;
                        button5.BackColor = Color.Green;
                        button8.BackColor = Color.Green;
                        winAlert(button2);
                    }

                }
                if (button3.Text.Equals(button6.Text) && button6.Text.Equals(button9.Text))
                {
                    if(button3.Text.Length==1)
                    {
                        button3.BackColor = Color.Green;
                        button6.BackColor = Color.Green;
                        button9.BackColor = Color.Green;
                        winAlert(button3);
                    }
                }
                if (button1.Text.Equals(button5.Text) && button5.Text.Equals(button9.Text))
                {
                    if(button1.Text.Length==1)
                    {
                        button1.BackColor = Color.Green;
                        button5.BackColor = Color.Green;
                        button9.BackColor = Color.Green;
                        winAlert(button1);
                    }
                }
                if (button3.Text.Equals(button5.Text) && button5.Text.Equals(button7.Text))
                {
                    if(button3.Text.Length==1)
                    {
                        button3.BackColor = Color.Green;
                        button5.BackColor = Color.Green;
                        button7.BackColor = Color.Green;
                        winAlert(button3);
                    }
                }

            }
        /*
            winEqualizer(button1,button2,button3);
            winEqualizer(button4,button5,button6);
            winEqualizer(button7,button8,button9);
            winEqualizer(button1,button4,button7);
            winEqualizer(button2,button5,button8);
            winEqualizer(button3,button6,button9);
            winEqualizer(button1,button5,button9);
            winEqualizer(button3,button5,button7);
        */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = xOrO();
            winCheck();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = xOrO();
            winCheck();

        }
        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = xOrO();
            winCheck();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = xOrO();
            winCheck();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = xOrO();
            winCheck();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = xOrO();
            winCheck();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Text = xOrO();
            winCheck();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Text = xOrO();
            winCheck();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Text = xOrO();
            winCheck();

        }

        private void clean()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button1.BackColor = Color.Transparent;
            button2.BackColor = Color.Transparent;
            button3.BackColor = Color.Transparent;
            button4.BackColor = Color.Transparent;
            button5.BackColor = Color.Transparent;
            button6.BackColor = Color.Transparent;
            button7.BackColor = Color.Transparent;
            button8.BackColor = Color.Transparent;
            button9.BackColor = Color.Transparent;
            playerQueue = 0;
        }

        private void reset_Click(object sender, EventArgs e)
        {
            clean();
        }
    }
}
