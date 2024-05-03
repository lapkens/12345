namespace Timesheet
{
	partial class Autorisation
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.Re_password_textBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.Password_textBox = new System.Windows.Forms.TextBox();
			this.Reg_button = new System.Windows.Forms.Button();
			this.Login_button = new System.Windows.Forms.Button();
			this.Login_textBox = new System.Windows.Forms.TextBox();
			this.Announce_label = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// Re_password_textBox
			// 
			this.Re_password_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Re_password_textBox.Location = new System.Drawing.Point(16, 136);
			this.Re_password_textBox.Name = "Re_password_textBox";
			this.Re_password_textBox.PasswordChar = '*';
			this.Re_password_textBox.Size = new System.Drawing.Size(277, 26);
			this.Re_password_textBox.TabIndex = 36;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(12, 113);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(152, 20);
			this.label3.TabIndex = 35;
			this.label3.Text = "Повторите пароль";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(12, 61);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 20);
			this.label2.TabIndex = 34;
			this.label2.Text = "Пароль";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 20);
			this.label1.TabIndex = 33;
			this.label1.Text = "Логин";
			// 
			// Password_textBox
			// 
			this.Password_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Password_textBox.Location = new System.Drawing.Point(16, 84);
			this.Password_textBox.Name = "Password_textBox";
			this.Password_textBox.PasswordChar = '*';
			this.Password_textBox.Size = new System.Drawing.Size(277, 26);
			this.Password_textBox.TabIndex = 32;
			// 
			// Reg_button
			// 
			this.Reg_button.BackColor = System.Drawing.Color.White;
			this.Reg_button.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.Reg_button.Font = new System.Drawing.Font("Onyx", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Reg_button.ForeColor = System.Drawing.Color.Black;
			this.Reg_button.Location = new System.Drawing.Point(16, 212);
			this.Reg_button.Name = "Reg_button";
			this.Reg_button.Size = new System.Drawing.Size(277, 38);
			this.Reg_button.TabIndex = 31;
			this.Reg_button.Text = "Зарегистрироваться";
			this.Reg_button.UseVisualStyleBackColor = false;
			this.Reg_button.Click += new System.EventHandler(this.Reg_button_Click);
			// 
			// Login_button
			// 
			this.Login_button.BackColor = System.Drawing.Color.White;
			this.Login_button.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.Login_button.Font = new System.Drawing.Font("Onyx", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Login_button.ForeColor = System.Drawing.Color.Black;
			this.Login_button.Location = new System.Drawing.Point(16, 168);
			this.Login_button.Name = "Login_button";
			this.Login_button.Size = new System.Drawing.Size(277, 38);
			this.Login_button.TabIndex = 30;
			this.Login_button.Text = "Войти";
			this.Login_button.UseVisualStyleBackColor = false;
			this.Login_button.Click += new System.EventHandler(this.Login_button_Click);
			// 
			// Login_textBox
			// 
			this.Login_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Login_textBox.Location = new System.Drawing.Point(16, 32);
			this.Login_textBox.Name = "Login_textBox";
			this.Login_textBox.Size = new System.Drawing.Size(277, 26);
			this.Login_textBox.TabIndex = 29;
			// 
			// Announce_label
			// 
			this.Announce_label.AutoSize = true;
			this.Announce_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Announce_label.Location = new System.Drawing.Point(12, 264);
			this.Announce_label.Name = "Announce_label";
			this.Announce_label.Size = new System.Drawing.Size(39, 20);
			this.Announce_label.TabIndex = 37;
			this.Announce_label.Text = "------";
			// 
			// Autorisation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(316, 293);
			this.Controls.Add(this.Announce_label);
			this.Controls.Add(this.Re_password_textBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Password_textBox);
			this.Controls.Add(this.Reg_button);
			this.Controls.Add(this.Login_button);
			this.Controls.Add(this.Login_textBox);
			this.Name = "Autorisation";
			this.Text = "Авторизация";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox Re_password_textBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox Password_textBox;
		private System.Windows.Forms.Button Reg_button;
		private System.Windows.Forms.Button Login_button;
		private System.Windows.Forms.TextBox Login_textBox;
		private System.Windows.Forms.Label Announce_label;
	}
}

