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
    public partial class СписокФурнитуры : Form
    {
        Model1 db = new Model1();

        public СписокФурнитуры()
        {
            InitializeComponent();
        }

        private void СписокФурнитуры_Load(object sender, EventArgs e)
        {
            фурнитураBindingSource.DataSource = db.Фурнитура.ToList();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (Form1.fa == 3)
            {
                ДобИзмФурнитуры addfur = new ДобИзмФурнитуры();
                addfur.db = db;
                addfur.fur = null;
                DialogResult dr = addfur.ShowDialog();
                try
                {
                    if (dr == DialogResult.OK)
                    {
                        фурнитураBindingSource.DataSource = db.Фурнитура.ToList();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.InnerException.InnerException.Message);
                }
            }
            else
            {
                MessageBox.Show("Вам не разрешено добавлять фурнитуру");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (Form1.fa == 3)
            {
                ДобИзмФурнитуры addfur = new ДобИзмФурнитуры();
                addfur.db = db;
                addfur.fur = (Фурнитура)фурнитураBindingSource.Current;
                DialogResult dr = addfur.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    фурнитураBindingSource.DataSource = db.Фурнитура.ToList();
                }
            }
            else
            {
                MessageBox.Show("Вам не разрешено изменять фурнитуру");
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (Form1.fa == 3)
            {
                Фурнитура fur = (Фурнитура)фурнитураBindingSource.Current;
                DialogResult dr = MessageBox.Show("Удалить фурнитуру " +
                fur.Артикул + "?", "Удаление данных фурнитуры",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    db.Фурнитура.Remove(fur);
                    try
                    {
                        db.SaveChanges();
                        фурнитураBindingSource.DataSource = db.Фурнитура.ToList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.InnerException.InnerException.Message);
                    }

                }
            }
            else
            {
                MessageBox.Show("Вам не разрешено удалять фурнитуру");
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (Form1.fa == 3)
            {
                Storekeeper.stor.Show();
                Close();
            }
        }

        private void ФурнитураDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Form1.fa == 3)
            {
                фурнитураDataGridView.AllowUserToAddRows = true;
                фурнитураDataGridView.AllowUserToDeleteRows = true;
                фурнитураDataGridView.ReadOnly = false;
            }
            else
            {
                фурнитураDataGridView.AllowUserToAddRows = false;
                фурнитураDataGridView.AllowUserToDeleteRows = false;
                фурнитураDataGridView.ReadOnly = true;
            }
        }
    }
}
