using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace Таблица
{

    public partial class Form1 : Form

    {
        private SqlConnection sqlConnection = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["dbtest"].ConnectionString);
            sqlConnection.Open();
            
            if (sqlConnection.State== ConnectionState.Open)
            {
                MessageBox.Show("Подключено");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand(
                $"INSERT INTO [Table] (ADR, OBEM, OTVET, Povremennaya_adolzhennost) VALUES (@ADR, @OBEM, @OTVET, @PREDN)",
                sqlConnection);
            command.Parameters.AddWithValue("ADR", textBox1.Text);
            command.Parameters.AddWithValue("OBEM", textBox2.Text);
            command.Parameters.AddWithValue("OTVET", textBox3.Text);
            command.Parameters.AddWithValue("PREDN", textBox4.Text);
            MessageBox.Show(command.ExecuteNonQuery().ToString());
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
