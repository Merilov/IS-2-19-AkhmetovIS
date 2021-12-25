using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace practika
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectDB conn = new ConnectDB();
            MySqlConnection conne = new MySqlConnection(conn.Connstring);
            string fio = textBox1.Text;
            string time = textBox2.Text;
            string sql = $"INSERT INTO t_PraktStud (fioStud, datetimeStud)  VALUES ('{fio}','{time}');";
            try
            {
                conne.Open();
                MessageBox.Show("Подключение к БД");
                MySqlDataAdapter IDataAdapter = new MySqlDataAdapter(sql, conne);
                conne.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка" + ex);
                conne.Close();
            }

    }   }
}
