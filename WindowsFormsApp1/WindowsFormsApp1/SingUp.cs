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
    public partial class SingUp : Form
    {
        Model1 db = new Model1();
        public SingUp()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)//sign up
        {
            if (textBox1.Text == "" || textBox2.Text == "" ||
             textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Нужно задать все данные!");
                return;
            }
            else if (textBox2.Text != textBox3.Text)
            {
                MessageBox.Show("Значения паролей не совпадают!");
                return;
            }
            else if ((textBox4.Text != "Директор") && (textBox4.Text != "Менеджер")
            && (textBox4.Text != "Заказчик") && (textBox4.Text != "Кладовщик"))
            {
                MessageBox.Show("Задана неверная роль!");
                return;
            }
            // ищем запись пользователя с введенным логином
            Пользователь usr = db.Пользователь.Find(textBox1.Text);
            if (usr != null)
            {
                MessageBox.Show("Пользователь с таким логином уже есть!");
                return;
            }
            else
            {
                // создаем нового пользователя
                usr = new Пользователь();
                usr.Логин = textBox1.Text;
                usr.Пароль = textBox2.Text;
                usr.Роль = textBox4.Text;
                // добавляем новую учетную запись в коллекцию
                db.Пользователь.Add(usr);
                try
                {
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                MessageBox.Show("Пользователь " + usr.Логин + " зарегистрирован!");
                Form1.FORMA.Show();
                this.Close();
                return;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1.FORMA.Show();
        }

        private void SingUp_Load(object sender, EventArgs e)
        {

        }
    }
}
