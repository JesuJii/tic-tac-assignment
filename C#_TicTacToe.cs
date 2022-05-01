using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // add action to all buttons inside panel2
            foreach (Control c in panel2.Controls)
            {
                if(c is Button)
                {
                    c.Click += new System.EventHandler(btn_click);
                }
            }
        }
        int Xor0 = 0;
        // Create button action
        public void btn_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if(Xor0 % 2 == 0)
            {
                btn.Text = "X";
            }else
            {
                btn.Text = "O";
            }

        }
    }
}
