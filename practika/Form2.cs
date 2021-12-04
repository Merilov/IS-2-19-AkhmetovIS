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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        class Connector
        {
            public string stringconn = "server=caseum.ru;port=33333;user=test_user;database=db_test;password=test_pass;";

            public void ConnectInfo()
            {
                MessageBox.Show(stringconn);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Connector con = new Connector();

            MySqlConnection conn = new MySqlConnection(con.stringconn);
            bool result = true;
            try
            {
                conn.Open();
            }
            catch
            {
                result = false;
            }
            finally
            {
                if (result == true)
                {
                    MessageBox.Show("Работает кажись");
                }
                else
                {
                    MessageBox.Show("Теперь точно не работает");
                }
                conn.Close();
            }
        }
    }
}
