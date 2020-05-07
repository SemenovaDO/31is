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
    public partial class Klient : Form
    {
        public static Klient kli;
        public Klient()
        {
            InitializeComponent();
            kli = this;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form1.FORMA.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
