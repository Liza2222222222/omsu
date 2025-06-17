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
    public partial class autorization : Form
    {
        string connStr = "server=localhost;user=root;database=cafe;password=root;";
        string login;
        string password;
        int block = 3;
        int auth = 1;
        bool schet = true;
        public autorization()
        {
            InitializeComponent();
            //закрытие других форм просле закрытия этой
            this.FormClosing += new FormClosingEventHandler(Autorization_FormClosing);
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //проверка пустых полей
            login = loginBox.Text.Trim();
            password = passBox.Text.Trim();
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Логин и пароль обязательны для заполнения!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
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
            //// читаем результат
            while (reader.Read())
            {
                //обработка ошибки
                try
                {
                    //если логин и пароль равны
                    if (reader["login"].ToString() == login && reader["password"].ToString() == password)
                    {
                        ID.value = reader["id"].ToString();
                        //если аккаунт забанен
                        if (reader["ban"].ToString() == "0")
                        {
                            MessageBox.Show("Этот аккаунт был заблокирован за чрезмерное количество неправильных попыток входа!\nОбратитесь к администратору.", "Нарушение!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        else //если не забанен
                        { // если роль читается как администратор
                            if (reader["position"].ToString() == "администратор")
                            {
                                AdminWin adm = new AdminWin();
                                MessageBox.Show("Вы успешно авторизовались, администратор!", "Поздравляем!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                adm.Show();
                                this.Hide();
                                return;
                            }
                            else if (reader["position"].ToString() == "официант") //если читается роль пользователя, по желанию можно разнообразить теми же swithc case
                            {
                                WaiterWin user = new WaiterWin();
                                PassChange pass = new PassChange();
                                MessageBox.Show("Вы успешно авторизовались, Официант!", "Поздравляем!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                if (reader["auth"].ToString() == "0") //если это первая аутентификация(парметр равен нулю)
                                {
                                    pass.Show();
                                }
                                else//иначе просто открываем форму
                                {
                                    user.Show();
                                }
                                this.Hide();
                                return;
                            }
                            else
                            {
                                PovarWin user = new PovarWin();
                                PassChange pass = new PassChange();
                                MessageBox.Show("Вы успешно авторизовались, Повар!", "Поздравляем!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                if (reader["auth"].ToString() == "0") //если это первая аутентификация(парметр равен нулю)
                                {
                                    pass.Show();
                                }
                                else//иначе просто открываем форму
                                {
                                    user.Show();
                                }
                                this.Hide();
                                return;
                            }
                        }

                    }
                    else if (reader["login"].ToString() == login && reader["password"].ToString() != password)
                    {
                        if (schet)//костыль первого совпадения
                        {
                            block = Convert.ToInt32(reader["ban"]);
                            schet = false;
                        }
                        //проверка на блокировку
                        block--;
                        if (block == 2)
                        {
                            MessageBox.Show("Логин или пароль введён неверно,осталось " + block + " попытки до блокировки!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (block == 1)
                        {
                            MessageBox.Show("Логин или пароль введён неверно,осталась " + block + " попытка до блокировки!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            loginBox.Enabled = false;
                            passBox.Enabled = false;
                            MessageBox.Show("Вы заблокированы. \nОбратитесь к администратору!", "Нарушение!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                        return;

                    }

                }
                //если что-то на этапах неудалось, выдает ошибку
                catch( Exception ex) { MessageBox.Show(ex.ToString(), "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            reader.Close(); // закрываем reader
            // закрываем соединение с БД
            conn.Close();

        }
        private void Autorization_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.Hide();
            MySqlConnection conn = new MySqlConnection(connStr);
            // устанавливаем соединение с БД
            conn.Open();
            //создаем запрос обновления параметра бана и аутентификации
            string query = $"update workers SET ban = {block}, auth = {auth} WHERE login = '{loginBox.Text}';";
            MySqlCommand command = new MySqlCommand(query, conn);
            // выполняем запрос
            command.ExecuteNonQuery();
            conn.Close();
            Application.Exit();
            
        }
    }
}


