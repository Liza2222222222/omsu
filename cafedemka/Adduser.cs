using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafedemka
{
    public partial class AddUser : Form
    {
        string connStr = "server=localhost;user=root;database=cafe;password=root;";
        public AddUser()
        {
            InitializeComponent();
            RoleBox.Items.Clear();
            MySqlConnection connection = new MySqlConnection(connStr);//подключаемся к БД
            connection.Open();//открываем БД
            string query = "SELECT distinct position FROM workers";//выбираем таблицу 
            MySqlCommand command = new MySqlCommand(query, connection);//отправляем запрос
            MySqlDataReader reader = command.ExecuteReader();//получаем запрос
            //добавление вариантов выбора в комбобокс с логинами
            while (reader.Read())
            {
                string name = reader["position"].ToString();
                RoleBox.Items.Add(name);
            }
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // создаём объект для подключения к БД
                MySqlConnection conn = new MySqlConnection(connStr);
                // устанавливаем соединение с БД
                conn.Open();
                //создаем запрос обновления параметра бана и аутентификации
                //проблемы с изменеием аутентификации
                string query = $"insert into workers (full_name,position, phone, login, password, hire_date, ban, auth) value ('{FullnameBox.Text}','{RoleBox.Text}', '{PhoneBox.Text}','{LogBox.Text}', '{PassBox.Text}', '{HireBox.Text}', 3, 0);;";
                MySqlCommand command = new MySqlCommand(query, conn);
                // выполняем запрос
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Новый сотрудник добавлен!", "База данных пользователей!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FullnameBox.Text = null;
                RoleBox.Text = null;
                PhoneBox.Text = null;
                LogBox.Text = null;
                PassBox.Text = null;
                HireBox.Text = null;

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Не получилось добавить нового сотрудника!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.OK;
            Application.Exit();
        }
    }
}
