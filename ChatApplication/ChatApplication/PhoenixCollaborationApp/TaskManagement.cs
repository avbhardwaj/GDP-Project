using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoenixCollaborationApp
{
	public partial class TaskManagement : UserControl
	{
		private static TaskManagement _instance;
		public static TaskManagement Instance
		{
			get
			{
				if (_instance == null)
					_instance = new TaskManagement();
				return _instance;
			}
		}
		public TaskManagement()
		{
			InitializeComponent();
		}

		private void bunifuImageButton1_Click(object sender, EventArgs e)
		{

		}
	}
}
