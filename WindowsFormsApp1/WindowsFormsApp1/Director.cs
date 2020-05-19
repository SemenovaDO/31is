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
    public partial class Director : Form
    {
        public static Director dir;
        public Director()
        {
            InitializeComponent();
            dir = this;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form1.FORMA.Show();
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ListИзделий list = new ListИзделий();
            Form1.fa = 1;
            list.Show();
            this.Hide();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Internet info = new Internet();
            info.Show();
            this.Hide();
        }
    }
}
