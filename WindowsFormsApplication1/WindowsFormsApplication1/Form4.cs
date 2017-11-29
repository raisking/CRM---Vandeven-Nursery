using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
   
    public partial class Form4 : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public Form4()
        {
            
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Users\it3883group4-01\Desktop\Group4\Assignment 7\Project2DB.accdb;
                                    Persist Security Info=False;";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //delete data from access database (make sure to comment if any changes)
            try
            {
                //DO NOT CHANGE
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "delete from Plant where PlantID =" + textBox1.Text + "";
                command.CommandText = query;
                command.ExecuteNonQuery();
                textBox1.Clear();
                MessageBox.Show("Date Deleted SUCCESSFUL");
                connection.Close();
            }
            catch (Exception ee)


            {

                MessageBox.Show("Errror try again !!!" + ee);
            
            }
                   }

        private void button3_Click(object sender, EventArgs e)
        {

            Form7 newFrm = new Form7();
            newFrm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //insert data into access database 
            try
            {

                // Donot make any changes
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "Insert into Plant (PlantID, Name, Price) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
                command.ExecuteNonQuery();
                MessageBox.Show("Plant Added SUCCESSFUL!");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                connection.Close();

            }
            catch (Exception mx)
            {

                MessageBox.Show("Errro try again!!!" + mx);

            }

            finally
            {
                if (connection!= null)connection.Close(); 
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                //output data from access database GUI 
                // Donot make any changes
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "Select*from Plant";
                command.CommandText = query;
                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                connection.Close();

            }
            catch (Exception xxx)
            {

                MessageBox.Show("Errro try again!!!" + xxx);

            }




        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Edit data
            //edit data into access database 
            try
            {

                // Donot make any changes
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = " UPDATE Plant set Name = '"+ textBox2.Text +"' ,Price= '"+ textBox3.Text +"' WHERE PlantID = "+ textBox1.Text+"";
                MessageBox.Show(" Data Edit SUCCESSFUL!");
                command.CommandText = query;
                command.ExecuteNonQuery();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                connection.Close();

            }
            catch (Exception mx)
            {

                MessageBox.Show("Errro try again!!!" + mx);

            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
