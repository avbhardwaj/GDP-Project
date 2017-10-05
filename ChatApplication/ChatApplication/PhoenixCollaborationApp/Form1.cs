using System;
using System.Net;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Amazon.S3.Model;
using Amazon.S3;
using Newtonsoft.Json;
using Amazon.WorkDocs;
using System.Security.Cryptography;
namespace PhoenixCollaborationApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

		forgotPassForm fm = new forgotPassForm();
		MainForm ob = new MainForm();
		string jsonURL = "https://aws-phoenix.s3-us-west-2.amazonaws.com/Data.json?AWSAccessKeyId=AKIAIMD627FG7CHA6SYQ&Expires=1514786340&Signature=DbrgDMcW6DiUNQO5fJXVtsHM6s0%3D";
		//string jsonURL = "https://s3-us-west-2.amazonaws.com/aws-phoenix/Data.json";
		static string bucketName = "aws-phoenix";
		static string keyName = "pFFg4pO5s81lzRIu8INWfUrcKPNmccVfRZ2quw9q";
		static IAmazonS3 client;



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
		
		private void userName_OnValueChanged(object sender, EventArgs e)
		{

		}

		private void secureLogBtn_Click(object sender, EventArgs e)
		{
			
			//This piece of code creates a new webclient and downloads the JSON file from the specif URL.
				WebClient wc = new WebClient();
				var json = wc.DownloadString(jsonURL);
				Console.WriteLine(json);
				SecData connect = JsonConvert.DeserializeObject<SecData>(json);
			try
			{
				if (userName.Text == "" && pwdBtn.Text == "")
				{
					MessageBox.Show("Please enter Username and Password, Thank you!");
				}
				else
				{
					SqlConnection conn = new SqlConnection();
					conn.ConnectionString = "Data Source=" + connect.DataSource + "Initial Catalog=" + connect.InitialCatalog + "User id=" + connect.UserName + "Password=" + connect.Password;
					conn.Open();
					SqlCommand q1 = new SqlCommand("select * from Users where NAME=@username and PASSWORD=@password", conn);
					q1.Parameters.AddWithValue("@username", userName.Text);
					q1.Parameters.AddWithValue("@password", pwdBtn.Text);
					//sql.Open();
					SqlDataAdapter adpt = new SqlDataAdapter(q1);
					DataSet ds = new DataSet();
					adpt.Fill(ds);
					conn.Close();

					int count = ds.Tables[0].Rows.Count;
					if (count == 1)
					{
						MessageBox.Show("Successfully Logged-in");
						this.Hide();
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

		private void minimizeBtn_Click(object sender, EventArgs e)
		{
			if (WindowState == FormWindowState.Normal)
			{
				WindowState = FormWindowState.Minimized;
			}

			else if (WindowState == FormWindowState.Maximized)
			{
				WindowState = FormWindowState.Normal;
			}
		}

		private void maximizeBtn_Click(object sender, EventArgs e)
		{
			if (WindowState == FormWindowState.Normal)
			{
				WindowState = FormWindowState.Maximized;
			}

			else if (WindowState == FormWindowState.Maximized)
			{
				WindowState = FormWindowState.Normal;
			}
		}

		private void closeBtn_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void pwdBtn_OnValueChanged(object sender, EventArgs e)
		{

		}

		private void leftSideMenu_Paint(object sender, PaintEventArgs e)
		{

		}

		private void bunifuTileButton1_Click(object sender, EventArgs e)
		{

		}

		private void forgotPass_Click(object sender, EventArgs e)
		{
			this.Hide();
			fm.Show();
		}
	}
}
