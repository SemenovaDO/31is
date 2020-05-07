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
    public partial class Form1 : Form
    {
        public static int fa = 0;
        public static Form1 FORMA { get; set; }
        public static Пользователь USER { get; set; }
        Model1 db = new Model1();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)//sign up - зарегистрироваться
        {
            SingUp sup = new SingUp();
            FORMA = this;
            this.Hide();
            sup.Show();
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void Button1_Click(object sender, EventArgs e)//sign in - войти
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Нужно задать логин и пароль!");
                return;
            }
            // ищем запись пользователя с введенным логином
            Пользователь usr = db.Пользователь.Find(textBox1.Text);
            if ((usr != null) && (usr.Пароль == textBox2.Text))
            {
                USER = usr;
                FORMA = this;
                if (usr.Роль == "Директор")
                {
                    Director dir = new Director();
                    dir.Show();
                    this.Hide();
                }
                else if (usr.Роль == "Менеджер")
                {
                    Manager mgr = new Manager();
                    mgr.Show();
                    this.Hide();
                }
                else if (usr.Роль == "Кладовщик")
                {
                    Storekeeper str = new Storekeeper();
                    str.Show();
                    this.Hide();
                }
                else if (usr.Роль == "Заказчик")
                {
                    Klient kli = new Klient();
                    kli.Show();
                    this.Hide();
                }
                else // если такой роли нет
                {
                    MessageBox.Show($"Роли {usr.Роль} в системе нет!");
                    return;
                }
                textBox1.Text = "";
                textBox2.Text = "";
            }
            else
            {
                // если данные введены не правильно, то показываем сообщение
                MessageBox.Show("Пользователя с таким логином и паролем нет!");
                textBox1.Text = "";
                textBox2.Text = "";
                return;
            }
        }

        private void Button3_Click(object sender, EventArgs e)//exit
        {
            Application.Exit();
        }
    }
}
