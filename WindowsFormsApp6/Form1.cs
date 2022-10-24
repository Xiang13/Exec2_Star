using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			starsLbl.Text = string.Empty;
		}

		private void generateButton_Click(object sender, EventArgs e)
		{
			// 取得列數
			// int? rows = GetRows();
			int rows = 0;
			try
			{
				rows = GetRows();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

			/* 
				
			if (rows.HasValue == false)
			{
				MessageBox.Show("請輸入列數")
				return;
			}

			if (rows.Value < 0)
			{
				MessageBox.Show("列數必須大於零")
				return;
			}
			 
			*/

			// 產生星形三角形
			Button btn = (Button)sender;
			int tag = Convert.ToInt32(btn.Tag);
			// 左側
			if (tag == 1)
			{
				string result = generateStars(rows);
				DisplayStars(result);
			}
			// 右側
			else if (tag == 2)
			{
				string result = generateStars1(rows);
				DisplayStars(result);
			}
			// 等腰
			else if (tag == 3)
			{
				string result = generateStars2(rows);
				DisplayStars(result);
			}



			// 用 textbox 呈現
			//DisplayStars(result);

		}

		private void DisplayStars(string stars)
		{
			resultTxtBox.Text = stars;
			starsLbl.Text = stars;
		}

		private string generateStars(int value)
		{
			string result = string.Empty;

			// 左側
			for (int i = 1; i <= value; i++)
			{
				result += new string('*', i) + "\r\n";
			}
			return result;
		}

		private string generateStars1(int value)
		{
			string result = string.Empty;
			// 右側
			string empty = string.Empty;
			string stars = string.Empty;
			for (int i = 1; i <= value; i++)
			{
				result += new string(' ', (value - i)*2) + new string('*', i) + "\r\n";
			}
			return result;
		}

		private string generateStars2(int value)
		{
			string result = string.Empty;
			// 等腰
			string empty = string.Empty;
			string stars = string.Empty;
			for (int i = 1; i <= value; i++)
			{
				result += new string(' ', value - i) + new string('*', i) + "\r\n";
			}
			return result;
		}

		private int GetRows()
		{
			string input = txtBox.Text;
			bool isInt = int.TryParse(input, out int rows);
			if (isInt == false)
			{
				throw new Exception("請輸入列數");
			}
			if (rows < 0)
			{
				throw new Exception("列數必須大於零");
			}
			return rows;
		}


		/* 
			private int? GetRows()
			{
				string input = rowsTextBox.Text;
				bool isInt = int.TryParse(input, out int rows);

				if(isInt)
				{
					return rows;
				}
				else
				{
					return null;
				}
			}

		*/
	}
}
