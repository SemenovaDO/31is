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
    public partial class ListИзделий : Form
    {
        Model1 db = new Model1();
        public ListИзделий()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (Form1.fa == 1)
            {
                Director.dir.Show();
                Close();
            }
            else if (Form1.fa == 2)
            {
                Manager.mng.Show();
                Close();
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Form1.fa == 2)
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

        private void ListИзделий_Load(object sender, EventArgs e)
        {
            изделиеBindingSource.DataSource = db.Изделие.ToList();
        }

        private void Button2_Click(object sender, EventArgs e)//add
        {
            if (Form1.fa == 2)
            {
                AddChangeListИзделий add1 = new AddChangeListИзделий();
                add1.db = db;
                add1.izd = null;;
                DialogResult dr = add1.ShowDialog();
                try
                {
                    if (dr == DialogResult.OK)
                    {
                        изделиеBindingSource.DataSource = db.Изделие.ToList();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.InnerException.InnerException.Message);
                }
            }
            else
            {
                MessageBox.Show("Вам не разрешено добавлять изделия");
            }
        }

        private void Button3_Click(object sender, EventArgs e)//change
        {
            if (Form1.fa == 2)
            {
                AddChangeListИзделий addcha = new AddChangeListИзделий();
                addcha.db = db;
                addcha.izd = (Изделие)изделиеBindingSource.Current;
                DialogResult dr = addcha.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    изделиеBindingSource.DataSource = db.Изделие.ToList();
                }
            }
            else
            {
                MessageBox.Show("Вам не разрешено изменять изделия");
            }
        }

        private void Button4_Click(object sender, EventArgs e)//delete 
        {
            if (Form1.fa == 2)
            {
                Изделие izd = (Изделие)изделиеBindingSource.Current;
                DialogResult dr = MessageBox.Show("Удалить изделие " +
                izd.Артикул + "?", "Удаление данных изделия",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    db.Изделие.Remove(izd);
                    try
                    {
                        db.SaveChanges();
                        изделиеBindingSource.DataSource = db.Изделие.ToList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.InnerException.InnerException.Message);
                    }

                }
            }
            else
            {
                MessageBox.Show("Вам не разрешено удалять изделия");
            }
        }
    }
}
