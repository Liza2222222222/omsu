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
    public partial class PassChange : Form
    {
        string connStr = "server=localhost;user=root;database=cafe;password=root;";
        string oldPass;
        string newPass;
        string appPass;
        public PassChange()
        {
            InitializeComponent();
        }
        
        private void passwordChange_Click(object sender, EventArgs e)
        {
            if (newPass == appPass)
            {
                AdminWin admin = new AdminWin();
                WaiterWin ofic = new WaiterWin();
                PovarWin povar = new PovarWin();
                // строка подключения к БД
                // создаём объект для подключения к БД
                MySqlConnection conn = new MySqlConnection(connStr);
                // устанавливаем соединение с БД
                conn.Open();
                // запрос
                string sql = "SELECT * FROM workers";
                // объект для выполнения SQL-запроса
                MySqlCommand command = new MySqlCommand(sql, conn);
                // объект для чтения ответа сервера
                MySqlDataReader reader = command.ExecuteReader();
                // читаем результат
                while (reader.Read())
                {
                    if (oldPass == reader["password"].ToString() && reader["id"].ToString() == ID.value)
                    {
                       
                        if (reader["position"].ToString() == "официант")
                        {
                            ofic.Show();
                            this.Hide();
                            MessageBox.Show("Пароль успешно изменён", "Поздравляем!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        else if (reader["position"].ToString() == "повар")
                        {
                            povar.Show();
                            this.Hide();
                            MessageBox.Show("Пароль успешно изменён", "Поздравляем!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                           
                        }
                        
                        else
                        {
                            MessageBox.Show("Неизвестная роль!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        
                    }
                }
                MessageBox.Show("Такого пароля не существует!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                reader.Close(); // закрываем reader
                                // закрываем соединение с БД
                conn.Close();
            }

        }
        private void appBox_TextChanged(object sender, EventArgs e)
        {
            appPass = appBox.Text;
            if (newPass != appPass) { warningLbl.Text = "Введенный пароль не совпадает с новым!"; }
            else { warningLbl.Text = ""; }
        }

        private void newBox_TextChanged(object sender, EventArgs e)
        {
            newPass = newBox.Text;
        }

        private void oldBox_TextChanged(object sender, EventArgs e)
        {
            oldPass = oldBox.Text;
        }

        private void PassChange_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            MySqlConnection conn = new MySqlConnection(connStr);
            // устанавливаем соединение с БД
            conn.Open();
            // запрос
            string sql = $"UPDATE workers SET password = '{newBox.Text}' WHERE id = '{ID.value}';";
            // объект для выполнения SQL-запроса
            MySqlCommand command = new MySqlCommand(sql, conn);
            // объект для чтения ответа сервера
            MySqlDataReader reader = command.ExecuteReader();
        }
    }

}
