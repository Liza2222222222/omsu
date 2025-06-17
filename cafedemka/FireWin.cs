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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ScrollBar;

namespace cafedemka
{
    public partial class FireWin : Form
    {
        string connStr = "server=localhost;user=root;database=cafe;password=root;";
        public FireWin()
        {
            InitializeComponent();
            FireBox.Items.Clear();
            MySqlConnection connection = new MySqlConnection(connStr);//подключаемся к БД
            connection.Open();//открываем БД
            string query = "SELECT full_name FROM workers WHERE status = 'Работает'";//выбираем таблицу 
            MySqlCommand command = new MySqlCommand(query, connection);//отправляем запрос
            MySqlDataReader reader = command.ExecuteReader();//получаем запрос
            //добавление вариантов выбора в комбобокс с логинами
            while (reader.Read())
            {
                string name = reader["full_name"].ToString();
                FireBox.Items.Add(name);
            }
            connection.Close();

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connStr);//подключаемся к БД
            connection.Open();//открываем БД
            string query = $"UPDATE workers set status = 'Уволен' WHERE full_name = '{FireBox.Text}'";//выбираем таблицу 
            MySqlCommand command = new MySqlCommand(query, connection);// отправляем запрос
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("сотрудник уволен", "Поздравляем!");
            FireBox.Text = null;
        }

        private void FireWin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.OK;
            Application.Exit();
        }
    }
}
