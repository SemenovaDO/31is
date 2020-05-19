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
    public partial class Manager : Form
    {
        public static Manager mng;
        public Manager()
        {
            InitializeComponent();
            mng = this;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form1.FORMA.Show();
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ListИзделий list = new ListИзделий();
            Form1.fa = 2;
            list.Show();
            this.Hide();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            СписокЗаказов listOrder = new СписокЗаказов();
            Form1.fa = 2;
            listOrder.Show();
            this.Hide();
        }
    }
}
