namespace WindowsFormsApp5
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
			this.namelbl = new System.Windows.Forms.Label();
			this.txtlbl = new System.Windows.Forms.TextBox();
			this.greetBtn = new System.Windows.Forms.Button();
			this.greetinglbl = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// namelbl
			// 
			this.namelbl.AutoSize = true;
			this.namelbl.Location = new System.Drawing.Point(36, 35);
			this.namelbl.Name = "namelbl";
			this.namelbl.Size = new System.Drawing.Size(30, 12);
			this.namelbl.TabIndex = 0;
			this.namelbl.Text = "name";
			// 
			// txtlbl
			// 
			this.txtlbl.Location = new System.Drawing.Point(72, 32);
			this.txtlbl.Name = "txtlbl";
			this.txtlbl.Size = new System.Drawing.Size(100, 22);
			this.txtlbl.TabIndex = 1;
			// 
			// greetBtn
			// 
			this.greetBtn.Location = new System.Drawing.Point(97, 88);
			this.greetBtn.Name = "greetBtn";
			this.greetBtn.Size = new System.Drawing.Size(75, 23);
			this.greetBtn.TabIndex = 2;
			this.greetBtn.Text = "greet";
			this.greetBtn.UseVisualStyleBackColor = true;
			this.greetBtn.Click += new System.EventHandler(this.greetBtn_Click);
			// 
			// greetinglbl
			// 
			this.greetinglbl.AutoSize = true;
			this.greetinglbl.Location = new System.Drawing.Point(36, 93);
			this.greetinglbl.Name = "greetinglbl";
			this.greetinglbl.Size = new System.Drawing.Size(40, 12);
			this.greetinglbl.TabIndex = 3;
			this.greetinglbl.Text = "greetlbl";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(216, 149);
			this.Controls.Add(this.greetinglbl);
			this.Controls.Add(this.greetBtn);
			this.Controls.Add(this.txtlbl);
			this.Controls.Add(this.namelbl);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label namelbl;
		private System.Windows.Forms.TextBox txtlbl;
		private System.Windows.Forms.Button greetBtn;
		private System.Windows.Forms.Label greetinglbl;
	}
}

