namespace WindowsFormsApp6
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
			this.txtlbl = new System.Windows.Forms.Label();
			this.txtBox = new System.Windows.Forms.TextBox();
			this.generateButton = new System.Windows.Forms.Button();
			this.resultTxtBox = new System.Windows.Forms.TextBox();
			this.starsLbl = new System.Windows.Forms.Label();
			this.generateButton2 = new System.Windows.Forms.Button();
			this.generateButton3 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtlbl
			// 
			this.txtlbl.AutoSize = true;
			this.txtlbl.Location = new System.Drawing.Point(69, 50);
			this.txtlbl.Name = "txtlbl";
			this.txtlbl.Size = new System.Drawing.Size(32, 12);
			this.txtlbl.TabIndex = 0;
			this.txtlbl.Text = "列數:";
			// 
			// txtBox
			// 
			this.txtBox.Location = new System.Drawing.Point(130, 45);
			this.txtBox.MaxLength = 2;
			this.txtBox.Name = "txtBox";
			this.txtBox.Size = new System.Drawing.Size(100, 22);
			this.txtBox.TabIndex = 1;
			// 
			// generateButton
			// 
			this.generateButton.Location = new System.Drawing.Point(248, 43);
			this.generateButton.Name = "generateButton";
			this.generateButton.Size = new System.Drawing.Size(75, 23);
			this.generateButton.TabIndex = 2;
			this.generateButton.Tag = "1";
			this.generateButton.Text = "顯示1";
			this.generateButton.UseVisualStyleBackColor = true;
			this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
			// 
			// resultTxtBox
			// 
			this.resultTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.resultTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.resultTxtBox.Location = new System.Drawing.Point(71, 93);
			this.resultTxtBox.MinimumSize = new System.Drawing.Size(408, 113);
			this.resultTxtBox.Multiline = true;
			this.resultTxtBox.Name = "resultTxtBox";
			this.resultTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.resultTxtBox.Size = new System.Drawing.Size(408, 113);
			this.resultTxtBox.TabIndex = 3;
			// 
			// starsLbl
			// 
			this.starsLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.starsLbl.Location = new System.Drawing.Point(71, 245);
			this.starsLbl.Name = "starsLbl";
			this.starsLbl.Size = new System.Drawing.Size(408, 113);
			this.starsLbl.TabIndex = 4;
			this.starsLbl.Text = "starsLbl";
			// 
			// generateButton2
			// 
			this.generateButton2.Location = new System.Drawing.Point(344, 43);
			this.generateButton2.Name = "generateButton2";
			this.generateButton2.Size = new System.Drawing.Size(75, 23);
			this.generateButton2.TabIndex = 5;
			this.generateButton2.Tag = "2";
			this.generateButton2.Text = "顯示2";
			this.generateButton2.UseVisualStyleBackColor = true;
			this.generateButton2.Click += new System.EventHandler(this.generateButton_Click);
			// 
			// generateButton3
			// 
			this.generateButton3.Location = new System.Drawing.Point(440, 43);
			this.generateButton3.Name = "generateButton3";
			this.generateButton3.Size = new System.Drawing.Size(75, 23);
			this.generateButton3.TabIndex = 5;
			this.generateButton3.Tag = "3";
			this.generateButton3.Text = "顯示3";
			this.generateButton3.UseVisualStyleBackColor = true;
			this.generateButton3.Click += new System.EventHandler(this.generateButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(546, 393);
			this.Controls.Add(this.generateButton3);
			this.Controls.Add(this.generateButton2);
			this.Controls.Add(this.starsLbl);
			this.Controls.Add(this.resultTxtBox);
			this.Controls.Add(this.generateButton);
			this.Controls.Add(this.txtBox);
			this.Controls.Add(this.txtlbl);
			this.MinimumSize = new System.Drawing.Size(562, 432);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label txtlbl;
		private System.Windows.Forms.TextBox txtBox;
		private System.Windows.Forms.Button generateButton;
		private System.Windows.Forms.TextBox resultTxtBox;
		private System.Windows.Forms.Label starsLbl;
		private System.Windows.Forms.Button generateButton2;
		private System.Windows.Forms.Button generateButton3;
	}
}

