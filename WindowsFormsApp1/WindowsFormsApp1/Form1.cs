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
    public partial class Form1 : Form //форма Авторизация
    {
        public static int fa = 0;//переменная для того, чтобы система определяла, на какую форму возвращаться
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

        private void Button2_Click(object sender, EventArgs e)//Кнопка sign up - зарегистрироваться
        {
            SingUp sup = new SingUp();
            FORMA = this;
            this.Hide();//скрывание формы Авторизация
            sup.Show();//переход на форму Регистрация
            textBox1.Text = "";//очищение данных
            textBox2.Text = "";//очищение данных
        }

        private void Button1_Click(object sender, EventArgs e)//Кнопка sign in - войти
        {
            if (textBox1.Text == "" || textBox2.Text == "")//если поля Логин и Пароль пусты
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
                if (usr.Роль == "Директор")//если роль Директор
                {
                    Director dir = new Director();
                    dir.Show();//переходим на форму Директора
                    this.Hide();
                }
                else if (usr.Роль == "Менеджер")//если роль Менеджер
                {
                    Manager mgr = new Manager();
                    mgr.Show();//переходим на форму Менеджер
                    this.Hide();
                }
                else if (usr.Роль == "Кладовщик")//если роль Кладовщик
                {
                    Storekeeper str = new Storekeeper();
                    str.Show();//переходим на форму Кладовщик
                    this.Hide();
                }
                else if (usr.Роль == "Заказчик")//если роль Заказчик
                {
                    Klient kli = new Klient();
                    kli.Show();//переходим на форму Заказчик
                    this.Hide();
                }
                else // если такой роли нет
                {
                    MessageBox.Show($"Роли {usr.Роль} в системе нет!");
                    return;
                }
                textBox1.Text = "";//очищение данных
                textBox2.Text = "";//очищение данных
            }
            else
            {
                // если данные введены не правильно, то показываем сообщение
                MessageBox.Show("Пользователя с таким логином и паролем нет!");
                textBox1.Text = "";//очищение данных
                textBox2.Text = "";//очищение данных
                return;
            }
        }

        private void Button3_Click(object sender, EventArgs e)//Кнопка exit
        {
            Application.Exit();//Выход из разрабатываемой ИС
        }
    }
}
