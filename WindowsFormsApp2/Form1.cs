using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("您要刪除這個紀錄嗎", "刪除視窗", MessageBoxButtons.YesNo);

			if (result == DialogResult.Yes)
			{
				MessageBox.Show("您選擇了Yes");
			}
			else
			{
				MessageBox.Show("您選擇了No");
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			MessageBox.Show("無法刪除紀錄, 此紀錄不存在",
							"刪除紀錄",
							MessageBoxButtons.OK,
							MessageBoxIcon.Exclamation);
		}
	}
}
