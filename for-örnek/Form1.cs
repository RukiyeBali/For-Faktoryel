using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace for_örnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void btnBul_Click_1(object sender, EventArgs e)
        {
            int sayi1, sayi2;
            int carpim = 1;

            sayi1 = Convert.ToInt32(txtSayi.Text);


            for (int i = 1; i <= sayi1; i++)
            {
                carpim *= i;
            }
            lbl1.Text = carpim.ToString();
        }
    }
}
