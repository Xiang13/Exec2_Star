namespace WindowsFormsApp4
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
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.name = new System.Windows.Forms.TextBox();
			this.address = new System.Windows.Forms.TextBox();
			this.phone = new System.Windows.Forms.TextBox();
			this.cellphone = new System.Windows.Forms.TextBox();
			this.cityId = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(70, 64);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 23);
			this.btnDelete.TabIndex = 0;
			this.btnDelete.Text = "刪除";
			this.btnDelete.UseVisualStyleBackColor = true;
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(180, 64);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(75, 23);
			this.btnUpdate.TabIndex = 0;
			this.btnUpdate.Text = "更新";
			this.btnUpdate.UseVisualStyleBackColor = true;
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(290, 64);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 0;
			this.btnCancel.Text = "取消";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// name
			// 
			this.name.Location = new System.Drawing.Point(103, 137);
			this.name.Name = "name";
			this.name.Size = new System.Drawing.Size(262, 22);
			this.name.TabIndex = 1;
			// 
			// address
			// 
			this.address.Location = new System.Drawing.Point(103, 180);
			this.address.Name = "address";
			this.address.Size = new System.Drawing.Size(262, 22);
			this.address.TabIndex = 2;
			// 
			// phone
			// 
			this.phone.Location = new System.Drawing.Point(103, 223);
			this.phone.Name = "phone";
			this.phone.Size = new System.Drawing.Size(262, 22);
			this.phone.TabIndex = 1;
			// 
			// cellphone
			// 
			this.cellphone.Location = new System.Drawing.Point(103, 266);
			this.cellphone.Name = "cellphone";
			this.cellphone.Size = new System.Drawing.Size(262, 22);
			this.cellphone.TabIndex = 2;
			// 
			// cityId
			// 
			this.cityId.Location = new System.Drawing.Point(103, 309);
			this.cityId.Name = "cityId";
			this.cityId.Size = new System.Drawing.Size(262, 22);
			this.cityId.TabIndex = 2;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.cityId);
			this.Controls.Add(this.cellphone);
			this.Controls.Add(this.phone);
			this.Controls.Add(this.address);
			this.Controls.Add(this.name);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnDelete);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.TextBox name;
		private System.Windows.Forms.TextBox address;
		private System.Windows.Forms.TextBox phone;
		private System.Windows.Forms.TextBox cellphone;
		private System.Windows.Forms.TextBox cityId;
	}
}

