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
    public partial class AddChangeListИзделий : Form
    {
        public Model1 db { get; set; }
        public Изделие izd { get; set; }
        public AddChangeListИзделий()
        {
            InitializeComponent();
        }

        private void AddListИзделий_Load(object sender, EventArgs e)
        {
            if (izd == null)
            {
                изделиеBindingSource.AddNew();
                this.Text = "Добавление нового изделия";
            }
            else
            {
                изделиеBindingSource.Add(izd);
                артикулTextBox.ReadOnly = true;
                this.Text = "Корректировка данных изделия" + izd.Артикул;
            }
        }

        private void Button2_Click(object sender, EventArgs e)//exit
        {
            DialogResult = DialogResult.Cancel;
        }

        private void Button1_Click(object sender, EventArgs e)//save
        {
            if (izd == null)
            {
                izd = (Изделие)изделиеBindingSource.List[0];
                db.Изделие.Add(izd);
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
    }
}
