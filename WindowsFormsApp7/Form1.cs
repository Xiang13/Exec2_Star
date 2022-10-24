using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
	public partial class Form1 : Form
	{
		private int answer = 0;
		public Form1()
		{
			InitializeComponent();
			// 在表單一開始就先取亂數 1 ~ 3, 存放在變數中, 並在 label 裡呈現答案, 方便檢查是否正確
			answer = new Random().Next(1, 4);
			answerLabel.Text = answer.ToString();
			// answerLabel.Text = string.Empty;
		}

		private void guessbtn_Click(object sender, EventArgs e)
		{
			// sender 是按鈕, 將它轉型為 button 之後, 可以取得 tag 值
			Button btn = (Button)sender;
			int tag = Convert.ToInt32(btn.Tag);

			// MessageBox.Show(tag.ToString());

			// 跟答案比對, 就知道有沒有答對
			if (tag == answer)
			{
				MessageBox.Show("您答對了");
			}
			else
			{
				MessageBox.Show("您答錯了, 再按一次");
			}
		}

		private void newGamebtn_Click(object sender, EventArgs e)
		{
			//answer = new Random().Next(1, 4);
			//answerLabel.Text = answer.ToString();
			Form1 reTry = new Form1();
			answer = reTry.answer;
			answerLabel.Text = answer.ToString();
		}
	}
}
