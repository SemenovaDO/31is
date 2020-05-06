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
    public partial class ListFurnitura : Form
    {
        Model1 db = new Model1();
        public ListFurnitura()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (Form1.fa == 3)
            {
                Storekeeper.stor.Show();
                Close();
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Form1.fa == 3)
            {
                dataGridView1.AllowUserToAddRows = true;
                dataGridView1.AllowUserToDeleteRows = true;
                dataGridView1.ReadOnly = false;
            }
            else
            {
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.AllowUserToDeleteRows = false;
                dataGridView1.ReadOnly = true;
            }
        }

        private void ListFurnitura_Load(object sender, EventArgs e)
        {
            фурнитураBindingSource.DataSource = db.Фурнитура.ToList();
        }

        private void Button2_Click(object sender, EventArgs e)//add
        {
            if (Form1.fa == 3)
            {
                AddChangeListFurnitura addfur = new AddChangeListFurnitura();
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

        private void Button3_Click(object sender, EventArgs e)//change
        {
            if (Form1.fa == 3)
            {
                AddChangeListFurnitura addfur = new AddChangeListFurnitura();
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

        private void Button4_Click(object sender, EventArgs e)//delete
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
    }
}
