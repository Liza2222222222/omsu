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
    public partial class DeleteWorkers : Form
    {
        string connStr = "server=localhost;user=root;database=cafe;password=root;";
        public DeleteWorkers()
        {
            InitializeComponent();
            DelBox.Items.Clear();
            MySqlConnection connection = new MySqlConnection(connStr);//подключаемся к БД
            connection.Open();//открываем БД
            string query = "SELECT full_name FROM workers";//выбираем таблицу 
            MySqlCommand command = new MySqlCommand(query, connection);//отправляем запрос
            MySqlDataReader reader = command.ExecuteReader();//получаем запрос
            //добавление вариантов выбора в комбобокс с логинами
            while (reader.Read())
            {
                string name = reader["full_name"].ToString();
                DelBox.Items.Add(name);
            }
            connection.Close();
        }

        private void Delbutton_Click(object sender, EventArgs e)
        {
            try
            {
                // создаём объект для подключения к БД
                MySqlConnection conn = new MySqlConnection(connStr);
                // устанавливаем соединение с БД
                conn.Open();
                //создаем запрос обновления параметра бана и аутентификации
                //проблемы с изменеием аутентификации
                string query = $"DELETE FROM workers WHERE full_name = '{DelBox.Text}'";
                MySqlCommand command = new MySqlCommand(query, conn);
                // выполняем запрос
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Данные удалены из БД!", "База данных пользователей!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DelBox.Text = null;
                

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Не получилось удалить данные!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteWorkers_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.OK;
            Application.Exit();
        }
    }
}
