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
    public partial class Storekeeper : Form
    {
        public static Storekeeper stor;
        public Storekeeper()
        {
            InitializeComponent();
            stor = this;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form1.FORMA.Show();
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)//list tkaney
        {
            ListТканей listТканей = new ListТканей();
            Form1.fa = 3;
            listТканей.Show();
            this.Hide();
        }

        private void Button3_Click(object sender, EventArgs e)//list furnitura
        {
            СписокФурнитуры список = new СписокФурнитуры();
            Form1.fa = 3;
            список.Show();
            this.Hide();
        }
    }
}
