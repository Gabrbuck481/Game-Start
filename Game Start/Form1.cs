using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media; 

namespace Game_Start
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Easymode_Click(object sender, EventArgs e)
        {
            Easymode.Text = "3"; 


            Refresh();
            Thread.Sleep(1000);


            Easymode.Text = "2";


            Refresh();
            Thread.Sleep(1000);


            Easymode.Text = "1";

            
            Refresh();
            Thread.Sleep(1000);

            
            Easymode.Text = "Begin"; 
            
            
        }

        private void Legendarymode_Click(object sender, EventArgs e)
        {
            Legendarymode.Text = "3";


            Refresh();
            Thread.Sleep(1000);


            Legendarymode.Text = "2";


            Refresh();
            Thread.Sleep(1000);


            Legendarymode.Text = "1";


            Refresh();
            Thread.Sleep(1000);


            Legendarymode.Text = "Begin";

        }

        private void Legendarymode_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Regularmode_Click(object sender, EventArgs e)
        {
            Regularmode.Text = "3";


            Refresh();
            Thread.Sleep(1000);


            Regularmode.Text = "2";


            Refresh();
            Thread.Sleep(1000);


            Regularmode.Text = "1";


            Refresh();
            Thread.Sleep(1000);


            Regularmode.Text = "Begin";

        }

        private void Heroicmode_Click(object sender, EventArgs e)
        {
            Heroicmode.Text = "3";


            Refresh();
            Thread.Sleep(1000);


            Heroicmode.Text = "2";


            Refresh();
            Thread.Sleep(1000);


            Heroicmode.Text = "1";


            Refresh();
            Thread.Sleep(1000);


            Heroicmode.Text = "Begin";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }
    }
}
