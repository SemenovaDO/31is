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
    public partial class ListТканей : Form
    {
        Model1 db = new Model1();
        public ListТканей()
        {
            InitializeComponent();
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

        private void Button1_Click(object sender, EventArgs e)
        {
            if (Form1.fa == 3)
            {
                Storekeeper.stor.Show();
                Close();
            }
        }

        private void ListТканей_Load(object sender, EventArgs e)
        {
            тканьBindingSource.DataSource = db.Ткань.ToList();
        }

        private void Button2_Click(object sender, EventArgs e)//add
        {
            if (Form1.fa == 3)
            {
                AddChangeListTkaney addclo = new AddChangeListTkaney();
                addclo.db = db;
                addclo.cloth = null; 
                DialogResult dr = addclo.ShowDialog();
                try
                {
                    if (dr == DialogResult.OK)
                    {
                        тканьBindingSource.DataSource = db.Ткань.ToList();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.InnerException.InnerException.Message);
                }
            }
            else
            {
                MessageBox.Show("Вам не разрешено добавлять ткань");
            }
        }

        private void Button3_Click(object sender, EventArgs e)//change
        {
            if (Form1.fa == 3)
            {
                AddChangeListTkaney addclo = new AddChangeListTkaney();
                addclo.db = db;
                addclo.cloth = (Ткань)тканьBindingSource.Current;
                DialogResult dr = addclo.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    тканьBindingSource.DataSource = db.Ткань.ToList();
                }
            }
            else
            {
                MessageBox.Show("Вам не разрешено изменять ткань");
            }
        }

        private void Button4_Click(object sender, EventArgs e)//delete
        {
            if (Form1.fa == 3)
            {
                Ткань cloth = (Ткань)тканьBindingSource.Current;
                DialogResult dr = MessageBox.Show("Удалить ткань " +
                cloth.Артикул + "?", "Удаление данных ткани",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    db.Ткань.Remove(cloth);
                    try
                    {
                        db.SaveChanges();
                        тканьBindingSource.DataSource = db.Ткань.ToList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.InnerException.InnerException.Message);
                    }

                }
            }
            else
            {
                MessageBox.Show("Вам не разрешено удалять ткань");
            }
        }
    }
}
