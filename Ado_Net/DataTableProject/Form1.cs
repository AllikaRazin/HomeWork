using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataTableProject
{
    public partial class Form1 : Form
    {

        private SqlDataReader reader;
        private DataTable table;
        private SqlConnection conn;

        string cs = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=usersdb;"
        + "Integrated Security=true;";
        public Form1()
        {
            InitializeComponent();
            conn = new SqlConnection();
            conn.ConnectionString = cs;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand comm = new SqlCommand();
                comm.CommandText = textBox1.Text;
                comm.Connection = conn;
                conn.Open();

                table = new DataTable();
                reader = comm.ExecuteReader();
                int line = 0;

                do
                {
                    while (reader.Read())
                    {
                        if (line == 0)
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                table.Columns.Add(reader.GetName(i));
                            }
                            line++;
                        }
                        DataRow row = table.NewRow();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            row[i] = reader[i];
                        }
                        table.Rows.Add(row);
                    }
                } while (reader.NextResult());
                dataGridView1.DataSource = table;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Probably wrong request syntax");
            }
            finally
            {
                if(conn!=null)
                {
                    conn.Close();
                }
                if(reader!=null)
                {
                    reader.Close();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
