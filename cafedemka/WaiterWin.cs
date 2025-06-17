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
    public partial class WaiterWin : Form
    {
        string connStr = "server=localhost;user=root;database=cafe;password=root;";
        string glob;
        void ShowClienttInGrid(string comm, DataGridView dgv)//шаблон показа таблиц
        {

            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            string query = comm;
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgv.DataSource = table;
            conn.Close();
        }
        public WaiterWin()
        {
            InitializeComponent();
            ShowClienttInGrid("SELECT * FROM orders", dataGridView1);
            ShowClienttInGrid($"SELECT * FROM shifts WHERE workers_id = '{ID.value}'", dataGridView2);
        }

        private void WaiterWin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
