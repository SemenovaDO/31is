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
    public partial class AddChangeListFurnitura : Form
    {
        public Model1 db { get; set; }
        public Фурнитура fur { get; set; }
        public AddChangeListFurnitura()
        {
            InitializeComponent();
        }

        private void AddChangeListFurnitura_Load(object sender, EventArgs e)
        {
            if (fur == null)
            {
                фурнитураBindingSource.AddNew();
                this.Text = "Добавление новой фурнитуры";
            }
            else
            {
                фурнитураBindingSource.Add(fur);
                артикулTextBox.ReadOnly = true;
                this.Text = "Корректировка данных фурнитуры" + fur.Артикул;
            }
        }

        private void Button1_Click(object sender, EventArgs e)//save
        {
            if (fur == null)
            {
                fur = (Фурнитура)фурнитураBindingSource.List[0];
                db.Фурнитура.Add(fur);
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
