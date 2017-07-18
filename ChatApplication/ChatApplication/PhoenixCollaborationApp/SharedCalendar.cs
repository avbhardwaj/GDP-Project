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
	public partial class SharedCalendar : UserControl
	{
		private static SharedCalendar _instance;
		public static SharedCalendar Instance
		{
			get
			{
				if (_instance == null)
					_instance = new SharedCalendar();
				return _instance;
			}
		}
		public SharedCalendar()
		{
			InitializeComponent();
		}

		private void bunifuImageButton1_Click(object sender, EventArgs e)
		{

		}
	}
}
