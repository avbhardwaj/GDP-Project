using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace PhoenixCollaborationApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox4.PasswordChar = '*';
        }

        // string conn = "Data Source=vineeth.cblh3csuj0ih.us-east-2.rds.amazonaws.com;Initial Catalog=Phoenix_Users;Integrated Security=true";
        MainForm ob = new MainForm();
       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

          
        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (textBox3.Text == "" && textBox4.Text == "")
                {
                    MessageBox.Show("Please enter Username and Password, Thank you!");
                }
                else
                {
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString =
                    "Data Source=vineeth.cblh3csuj0ih.us-east-2.rds.amazonaws.com;" +
                    "Initial Catalog=Phoenix_Users;" +
                    "User id=vineeth;" +
                    "Password=vineethgajula;";
                    conn.Open();
                    SqlCommand q1 = new SqlCommand("select * from Users where NAME=@username and PASSWORD=@password", conn);
                    q1.Parameters.AddWithValue("@username", textBox3.Text);
                    q1.Parameters.AddWithValue("@password", textBox4.Text);
                    //sql.Open();
                    SqlDataAdapter adpt = new SqlDataAdapter(q1);
                    DataSet ds = new DataSet();
                    adpt.Fill(ds);
                   
                    int count = ds.Tables[0].Rows.Count;
                    if (count == 1)
                    {
                        MessageBox.Show("Successfully Logged-in");
                        this.Hide();
                        SqlCommand q2 = new SqlCommand("select ID from Users where NAME=@username and PASSWORD=@password", conn);
                        q2.Parameters.AddWithValue("@username", textBox3.Text);
                        q2.Parameters.AddWithValue("@password", textBox4.Text);
                        SqlDataAdapter ad = new SqlDataAdapter(q2);
                        DataSet ds2 = new DataSet();
                        conn.Close();

                        ob.Show();

                    }
                    else
                    {
                        MessageBox.Show("Login Unsuccessful, Please Try Again!");
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: {0}", ex.Message);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
