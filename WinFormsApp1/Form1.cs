using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void OpenSqlConnection()
        {
            string connectionString = GetConnectionString();

            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = connectionString;

                connection.Open();

                Console.WriteLine("State: {0}", connection.State);
                this.textBox1.Text = "State: " + connection.State + "\r\n";
                Console.WriteLine("ConnectionString: {0}",
                    connection.ConnectionString);
                this.textBox1.Text += "ConnectionString: " + connection.ConnectionString + "\r\n";

                SqlCommand cmd = new SqlCommand("SELECT id, nome FROM [dbo].[Table_Teste1]", connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("{0}, {1}", reader.GetInt32(0), reader.GetString(1));
                    Console.WriteLine(reader.GetInt32(0) + ": " + reader.GetString(1));
                    this.textBox1.Text += reader.GetInt32(0) + ": " + reader.GetString(1) + "\r\n";
                }
                reader.Close();
                
                //string sql = "INSERT INTO Table_Teste1(id,nome) VALUES(13,'Teste 4')";
                //using (SqlCommand cmd2 = new SqlCommand(sql, connection))
                //{
                    /*
                    cmd.Parameters.Add("@param1", SqlDbType.Int).Value = klantId;
                    cmd.Parameters.Add("@param2", SqlDbType.VarChar, 50).Value = klantNaam;
                    cmd.Parameters.Add("@param3", SqlDbType.VarChar, 50).Value = klantVoornaam;
                    cmd.CommandType = CommandType.Text;
                    */
                    //cmd2.ExecuteNonQuery();
                //}

                connection.Close();
            }


        }

        static string GetConnectionString()
        {
            // To avoid storing the connection string in your code,
            // you can retrieve it from a configuration file.
            return "Data source=localhost; User id=sa; Password=sipef@adm;Connect Timeout=1000; Initial Catalog=dbsipefosTreinamento2; MultipleActiveResultSets=True;";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenSqlConnection();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = GetConnectionString();

            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = connectionString;

                connection.Open();

                string sql = "INSERT INTO Table_Teste1(id,nome) VALUES(" + this.textBox2.Text + ",'" + this.textBox3.Text + "')";
                using (SqlCommand cmd2 = new SqlCommand(sql, connection))
                {
                    /*
                    cmd.Parameters.Add("@param1", SqlDbType.Int).Value = klantId;
                    cmd.Parameters.Add("@param2", SqlDbType.VarChar, 50).Value = klantNaam;
                    cmd.Parameters.Add("@param3", SqlDbType.VarChar, 50).Value = klantVoornaam;
                    cmd.CommandType = CommandType.Text;
                    */
                    cmd2.ExecuteNonQuery();
                }

                connection.Close();
            }

            OpenSqlConnection();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = GetConnectionString();

            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = connectionString;

                connection.Open();

                string sql = "DELETE FROM [dbo].[Table_Teste1] WHERE id=" + this.textBox4.Text;
                using (SqlCommand cmd2 = new SqlCommand(sql, connection))
                {
                    /*
                    cmd.Parameters.Add("@param1", SqlDbType.Int).Value = klantId;
                    cmd.Parameters.Add("@param2", SqlDbType.VarChar, 50).Value = klantNaam;
                    cmd.Parameters.Add("@param3", SqlDbType.VarChar, 50).Value = klantVoornaam;
                    cmd.CommandType = CommandType.Text;
                    */
                    cmd2.ExecuteNonQuery();
                }

                connection.Close();
            }

            OpenSqlConnection();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connectionString = GetConnectionString();

            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = connectionString;

                connection.Open();

                string sql = "UPDATE [dbo].[Table_Teste1] SET nome='" + this.textBox3.Text + "' WHERE id=" + this.textBox2.Text;
                using (SqlCommand cmd2 = new SqlCommand(sql, connection))
                {
                    /*
                    cmd.Parameters.Add("@param1", SqlDbType.Int).Value = klantId;
                    cmd.Parameters.Add("@param2", SqlDbType.VarChar, 50).Value = klantNaam;
                    cmd.Parameters.Add("@param3", SqlDbType.VarChar, 50).Value = klantVoornaam;
                    cmd.CommandType = CommandType.Text;
                    */
                    cmd2.ExecuteNonQuery();
                }

                connection.Close();
            }

            OpenSqlConnection();
        }
    }
}
