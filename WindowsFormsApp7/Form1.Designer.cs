namespace WindowsFormsApp7
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.guess01btn = new System.Windows.Forms.Button();
			this.guess02btn = new System.Windows.Forms.Button();
			this.guess03btn = new System.Windows.Forms.Button();
			this.answerLabel = new System.Windows.Forms.Label();
			this.newGamebtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// guess01btn
			// 
			this.guess01btn.Font = new System.Drawing.Font("新細明體", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.guess01btn.Location = new System.Drawing.Point(68, 46);
			this.guess01btn.Name = "guess01btn";
			this.guess01btn.Size = new System.Drawing.Size(101, 85);
			this.guess01btn.TabIndex = 0;
			this.guess01btn.Tag = "1";
			this.guess01btn.Text = "1";
			this.guess01btn.UseVisualStyleBackColor = true;
			this.guess01btn.Click += new System.EventHandler(this.guessbtn_Click);
			// 
			// guess02btn
			// 
			this.guess02btn.Font = new System.Drawing.Font("新細明體", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.guess02btn.Location = new System.Drawing.Point(224, 46);
			this.guess02btn.Name = "guess02btn";
			this.guess02btn.Size = new System.Drawing.Size(101, 85);
			this.guess02btn.TabIndex = 1;
			this.guess02btn.Tag = "2";
			this.guess02btn.Text = "2";
			this.guess02btn.UseVisualStyleBackColor = true;
			this.guess02btn.Click += new System.EventHandler(this.guessbtn_Click);
			// 
			// guess03btn
			// 
			this.guess03btn.Font = new System.Drawing.Font("新細明體", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.guess03btn.Location = new System.Drawing.Point(380, 46);
			this.guess03btn.Name = "guess03btn";
			this.guess03btn.Size = new System.Drawing.Size(101, 85);
			this.guess03btn.TabIndex = 2;
			this.guess03btn.Tag = "3";
			this.guess03btn.Text = "3";
			this.guess03btn.UseVisualStyleBackColor = true;
			this.guess03btn.Click += new System.EventHandler(this.guessbtn_Click);
			// 
			// answerLabel
			// 
			this.answerLabel.AutoSize = true;
			this.answerLabel.Location = new System.Drawing.Point(425, 247);
			this.answerLabel.Name = "answerLabel";
			this.answerLabel.Size = new System.Drawing.Size(33, 12);
			this.answerLabel.TabIndex = 4;
			this.answerLabel.Text = "label1";
			// 
			// newGamebtn
			// 
			this.newGamebtn.Location = new System.Drawing.Point(406, 173);
			this.newGamebtn.Name = "newGamebtn";
			this.newGamebtn.Size = new System.Drawing.Size(75, 23);
			this.newGamebtn.TabIndex = 3;
			this.newGamebtn.Text = "再玩一次";
			this.newGamebtn.UseVisualStyleBackColor = true;
			this.newGamebtn.Click += new System.EventHandler(this.newGamebtn_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(546, 290);
			this.Controls.Add(this.newGamebtn);
			this.Controls.Add(this.answerLabel);
			this.Controls.Add(this.guess03btn);
			this.Controls.Add(this.guess02btn);
			this.Controls.Add(this.guess01btn);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button guess01btn;
		private System.Windows.Forms.Button guess02btn;
		private System.Windows.Forms.Button guess03btn;
		private System.Windows.Forms.Label answerLabel;
		private System.Windows.Forms.Button newGamebtn;
	}
}

