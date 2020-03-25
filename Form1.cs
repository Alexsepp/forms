using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_Rudnev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (pic1.Visible == true)
            {
                pic1.Visible = false;
                btn1.Text = "ON";
            }
            else
            {
                pic1.Visible = true;
                btn1.Text = "OFF";
            }
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            Form2 forma = new Form2();
            forma.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form3 forma1 = new Form3();
            forma1.Show();

        }
    }
}
