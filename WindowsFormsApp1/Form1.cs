using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}



		private void greetButton_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Hi");
		}

		private void btnHello_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Hello world");
		}

		private void button2_Click(object sender, EventArgs e)
		{
			MessageBox.Show("您確定要刪除紀錄嗎?");
		}
	}
}
