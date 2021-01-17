using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deneme1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button[,] buttons = new Button[8, 8];
            int left = 0;
            int top = 0;
            string text1 = "S";
            string text2 = "O";
            for (int i = 0; i < buttons.GetUpperBound(0); i++)
            {
                for (int j = 0; j < buttons.GetUpperBound(1); j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    //buttons[i, j].Text = "O";
                    buttons[i, j].Left = left;
                    buttons[i, j].Top = top;
                    left += 60;

                    if ((i+j)%2==0)
                    {
                        buttons[i, j].Text = text1;
                    }
                    else
                    {
                        buttons[i, j].Text = text2;
                    }
                    this.Controls.Add(buttons[i, j]);
                }
                left = 0;
                top += 60;
            }
        }
    }
}
