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
    public partial class AdminWin : Form
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
        public AdminWin()
        {
            InitializeComponent();
            ShowClienttInGrid("SELECT * FROM workers", dataGridView1);
            ShowClienttInGrid("SELECT * FROM shifts", dataGridView2);
            ShowClienttInGrid("SELECT * FROM orders", dataGridView3);
        }

        private void AddWorker_Click(object sender, EventArgs e)
        {
            AddUser add = new AddUser();
           DialogResult result = add.ShowDialog();
            if (result == DialogResult.OK) 
            {
                ShowClienttInGrid("SELECT * FROM workers", dataGridView1);
            }


            
        }

        private void FireWorker_Click(object sender, EventArgs e)
        {
            FireWin fire = new FireWin();
            DialogResult result = fire.ShowDialog();
            if (result == DialogResult.OK)
            {
                ShowClienttInGrid("SELECT * FROM workers", dataGridView1);
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            DeleteWorkers deleteWorkers = new DeleteWorkers();
            DialogResult result = deleteWorkers.ShowDialog();
            if (result == DialogResult.OK)
            {
                ShowClienttInGrid("SELECT * FROM workers", dataGridView1);
            }

        }

        private void AdminWin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
    
       
}
