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
    public partial class Form3 : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public Form3()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Users\it3883group4-01\Desktop\Group4\Assignment 7\Project2DB.accdb;
                                    Persist Security Info=False;";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Form7 newFrm = new Form7();
            newFrm.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                // Donot make any changes
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "Select*from Sale";
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

        private void button4_Click(object sender, EventArgs e)
        {


            //delete data from access database (make sure to comment if any changes)
            try
            {
                //DO NOT CHANGE
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "DELETE from Sale WHERE ID =" + textBox1.Text + "";
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

        private void button5_Click(object sender, EventArgs e)
        {
            // Total method 

           // if (!string.IsNullOrEmpty(textBox3.Text) && !string.IsNullOrEmpty(textBox4.Text))
               // textBox5.Text = (Convert.ToInt32(textBox3.Text) * Convert.ToInt32(textBox4.Text)).ToString(); 
            
            //Edit Data
            //Edit data
            //edit data into access database 
            try
            {
              
                // Donot make any changes
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = " UPDATE Sale set ID = '" + textBox1.Text + "' ,DateOfSale= '" + textBox2.Text + "',  PlantID= '" + textBox3.Text + "',Quantity= '" + textBox4.Text + "',Price= '" + textBox5.Text + "'WHERE ID = " + textBox1.Text + "";
                MessageBox.Show(" Data Edit SUCCESSFUL!");
                command.CommandText = query;
                command.ExecuteNonQuery();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
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

        private void button3_Click(object sender, EventArgs e)
        {
            // total button            
            // calulate total price and also save the data to the access database
            
                try
                {
/*
                    // Donot make any changes
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    int num = int.Parse(textBox4.Text);
                    int num1 = int.Parse(textBox5.Text);
                    // int num2 = int.Parse(textBox6.Text);
                    int num2 = num * num1;
                    MessageBox.Show("Order total:" + num2.ToString());
                    command.CommandText = "Insert into Sale (ID,DateOfSale,PlantID,Quantity,Price,Total) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','"+num2+ "' )";
                    command.ExecuteNonQuery();
                    connection.Close();
*/



                    // Donot make any changes
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    int num = int.Parse(textBox4.Text);
                    int num1 = int.Parse(textBox5.Text);
                    // int num2 = int.Parse(textBox6.Text);
                    int num2 = num * num1;
                    MessageBox.Show("Order total:" + num2.ToString());
                    command.CommandText = "Insert into Sale (ID,DateOfSale,PlantID,PlantName,Quantity,Price,Total) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox1.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + num2 + "' )";
                    command.ExecuteNonQuery();
                    connection.Close();
                }

                catch (Exception x)
                {

                    MessageBox.Show("Error try again!!!" + x);
                }
                 

            }

        private void button6_Click(object sender, EventArgs e)
        {
          
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
           
            textBox1.Clear();
            textBox2.Clear();

            textBox3.Clear();
            textBox4.Clear();
            textBox4.Clear();
            textBox5.Clear();
            comboBox1.ResetText();

    
        
        }
        }
   }

