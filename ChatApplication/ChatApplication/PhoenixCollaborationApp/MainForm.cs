using System;
using System.Windows.Forms;
using Amazon.WorkDocs;

namespace PhoenixCollaborationApp
{
	public partial class MainForm : Form
	{
		Chat c1;
		GoogleSuite g1;
		SharedCalendar sc1;
		TaskManagement tm1;
        //designation.Text = 
        public MainForm()
		{
			c1 = new Chat();
			g1 = new GoogleSuite();
			sc1 = new SharedCalendar();
			tm1 = new TaskManagement();
			InitializeComponent();
			
		}

		private void closeBtn_Click(object sender, EventArgs e)
		{
			this.Close();
           
		
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

		private void minimizeBtn_Click(object sender, EventArgs e)
		{
			//this.WindowState = FormWindowState.Minimized;
			if (WindowState == FormWindowState.Normal)
			{
				WindowState = FormWindowState.Minimized;
			}

			else if (WindowState == FormWindowState.Maximized)
			{
				WindowState = FormWindowState.Normal;
			}

		}

		private void bunifuCustomLabel2_Click(object sender, EventArgs e)
		{

		}

		private void bunifuCustomLabel3_Click(object sender, EventArgs e)
		{

		}

		private void bunifuFlatButton1_Click(object sender, EventArgs e)
		{

		}

		private void taskManagementButton_Click(object sender, EventArgs e)
		{
			if (!displayViewPanel.Controls.Contains(TaskManagement.Instance))
			{
				displayViewPanel.Controls.Add(TaskManagement.Instance);
				TaskManagement.Instance.Dock = DockStyle.Fill;
				TaskManagement.Instance.BringToFront();
			}
			else
				TaskManagement.Instance.BringToFront();

		}

		private void calendarButton_Click(object sender, EventArgs e)
		{
			if (!displayViewPanel.Controls.Contains(SharedCalendar.Instance))
			{
				displayViewPanel.Controls.Add(SharedCalendar.Instance);
				SharedCalendar.Instance.Dock = DockStyle.Fill;
				SharedCalendar.Instance.BringToFront();
			}
			else
				SharedCalendar.Instance.BringToFront();
		}

		private void bunifuCustomLabel4_Click(object sender, EventArgs e)
		{

		}

		private void bunifuImageButton5_Click(object sender, EventArgs e)
		{
			//Collapsed Left Side Menu
			if (leftSideMenu.Width == 50)
			{
				leftSideMenu.Visible = false;
				leftSideMenu.Width = 250;
				sidePanelAnimator.ShowSync(leftSideMenu);
				sidePanelAnimator.AnimationType= BunifuAnimatorNS.AnimationType.Rotate;
				logoAnimator.ShowSync(logo);
			}

			//Expanded Left Side Menu
			else
			{ 
				logoAnimator.Hide(logo);
				leftSideMenu.Visible = false;
				leftSideMenu.Width = 50;
				sidePanelAnimator.ShowSync(leftSideMenu);
				sidePanelAnimator.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
				
			}
		}
		
		private void chatButton_Click(object sender, EventArgs e)
		{	
			// Displays the view of Chat when the button is clicked
			if (!displayViewPanel.Controls.Contains(Chat.Instance))
			{
				displayViewPanel.Controls.Add(Chat.Instance);
				Chat.Instance.Dock = DockStyle.Fill;
				Chat.Instance.BringToFront();
			}
			else
				Chat.Instance.BringToFront();

		}

		private void bunifuFlatButton3_Click(object sender, EventArgs e)
		{

		}

		private void googleSuiteButton_Click(object sender, EventArgs e)
		{
			if (!displayViewPanel.Controls.Contains(GoogleSuite.Instance))
			{
				displayViewPanel.Controls.Add(GoogleSuite.Instance);
				GoogleSuite.Instance.Dock = DockStyle.Fill;
				GoogleSuite.Instance.BringToFront();
			}
			else
			{
				GoogleSuite.Instance.BringToFront();
				//AmazonWorkDocsConfig config = new AmazonWorkDocsConfig();
				//config.AuthenticationServiceName = "Lanja Dengai";
				//config.ServiceURL = "";
			
			}
		}

		private void bunifuCustomLabel5_Click(object sender, EventArgs e)
		{

		}

		private void displayViewPanel_Paint(object sender, PaintEventArgs e)
		{
			
		}
    }
}
