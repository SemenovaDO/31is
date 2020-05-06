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
    public partial class AddChangeListTkaney : Form
    {
        public Model1 db { get; set; }
        public Ткань cloth { get; set; }
        public AddChangeListTkaney()
        {
            InitializeComponent();
        }

        private void AddChangeListTkaney_Load(object sender, EventArgs e)
        {
            if (cloth == null)
            {
                тканьBindingSource.AddNew();
                this.Text = "Добавление новой ткани";
            }
            else
            {
                тканьBindingSource.Add(cloth);
                артикулTextBox.ReadOnly = true;
                this.Text = "Корректировка данных ткани" + cloth.Артикул;
            }
        }

        private void Button1_Click(object sender, EventArgs e)//save
        {
            if (cloth == null)
            {
                cloth = (Ткань)тканьBindingSource.List[0];
                db.Ткань.Add(cloth);
            }
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка " + ex.Message);
            }
            DialogResult = DialogResult.OK;
        }

        private void Button2_Click(object sender, EventArgs e)//exit
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
