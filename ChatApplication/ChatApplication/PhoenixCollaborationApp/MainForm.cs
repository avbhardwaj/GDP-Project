﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoenixCollaborationApp
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void bunifuImageButton1_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		private void bunifuImageButton2_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Maximized;
		}

		private void bunifuImageButton3_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
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

		private void bunifuFlatButton5_Click(object sender, EventArgs e)
		{

		}

		private void bunifuFlatButton2_Click(object sender, EventArgs e)
		{

		}
	}
}