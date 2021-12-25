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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
                string id_rows = "0";
                if (!e.RowIndex.Equals(-1) && !e.ColumnIndex.Equals(-1) && e.Button.Equals(MouseButtons.Left))
                {
                    dataGridView1.CurrentCell = dataGridView1[e.ColumnIndex, e.RowIndex];

                    dataGridView1.CurrentRow.Selected = true;

                    string index_rows;

                    index_rows = dataGridView1.SelectedCells[0].RowIndex.ToString();

                    id_rows = dataGridView1.Rows[Convert.ToInt32(index_rows)].Cells[2].Value.ToString();
                    DateTime x = DateTime.Today;
                    DateTime y = Convert.ToDateTime(dataGridView1.Rows[Convert.ToInt32(index_rows)].Cells[2].Value.ToString());
                    string DayR = (x - y).ToString();
                    MessageBox.Show("день рождение" + DayR.Substring(0, DayR.Length - 9));
                }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            ConnectDB conn = new ConnectDB();
            MySqlConnection conne = new MySqlConnection(conn.Connstring);
            string sql = $"SELECT idStud, fioStud, drStud FROM t_datetime";
            try
            {
                conne.Open();
                MessageBox.Show("Подключение к БД");
                MySqlDataAdapter IDataAdapter = new MySqlDataAdapter(sql, conne);
                DataSet dataset = new DataSet();
                IDataAdapter.Fill(dataset);
                dataGridView1.DataSource = dataset.Tables[0];
                conne.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка" + ex);
                conne.Close();
            }
        }
    }
}
