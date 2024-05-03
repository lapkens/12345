namespace Timesheet
{
	partial class Main_Window
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel3 = new System.Windows.Forms.Panel();
			this.label7 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.DB_Tables_comboBox = new System.Windows.Forms.ComboBox();
			this.Delete_table_button = new System.Windows.Forms.Button();
			this.Add_table_button = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.Choose_comboBox = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.Search_Settings_Box = new System.Windows.Forms.ComboBox();
			this.Search_Box = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.Delete_checkBox = new System.Windows.Forms.CheckBox();
			this.Tables_TabControl = new System.Windows.Forms.TabControl();
			this.Users = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.Change_button = new System.Windows.Forms.Button();
			this.ADD_button = new System.Windows.Forms.Button();
			this.DELETE_button = new System.Windows.Forms.Button();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			this.Tables_TabControl.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.Transparent;
			this.panel3.Controls.Add(this.label7);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Controls.Add(this.DB_Tables_comboBox);
			this.panel3.Controls.Add(this.Delete_table_button);
			this.panel3.Controls.Add(this.Add_table_button);
			this.panel3.Location = new System.Drawing.Point(12, 12);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(715, 78);
			this.panel3.TabIndex = 37;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.ForeColor = System.Drawing.Color.Black;
			this.label7.Location = new System.Drawing.Point(530, 44);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(169, 25);
			this.label7.TabIndex = 18;
			this.label7.Text = "Удалить вкладку";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(530, 6);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(182, 25);
			this.label2.TabIndex = 29;
			this.label2.Text = "Добавить вкладку";
			// 
			// DB_Tables_comboBox
			// 
			this.DB_Tables_comboBox.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.DB_Tables_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.DB_Tables_comboBox.FormattingEnabled = true;
			this.DB_Tables_comboBox.Location = new System.Drawing.Point(3, 4);
			this.DB_Tables_comboBox.Name = "DB_Tables_comboBox";
			this.DB_Tables_comboBox.Size = new System.Drawing.Size(454, 32);
			this.DB_Tables_comboBox.TabIndex = 13;
			// 
			// Delete_table_button
			// 
			this.Delete_table_button.BackColor = System.Drawing.Color.White;
			this.Delete_table_button.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Delete_table_button.ForeColor = System.Drawing.Color.Black;
			this.Delete_table_button.Location = new System.Drawing.Point(473, 42);
			this.Delete_table_button.Name = "Delete_table_button";
			this.Delete_table_button.Size = new System.Drawing.Size(56, 32);
			this.Delete_table_button.TabIndex = 15;
			this.Delete_table_button.Text = "-";
			this.Delete_table_button.UseVisualStyleBackColor = false;
			this.Delete_table_button.Click += new System.EventHandler(this.Delete_table_button_Click);
			// 
			// Add_table_button
			// 
			this.Add_table_button.BackColor = System.Drawing.Color.White;
			this.Add_table_button.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Add_table_button.ForeColor = System.Drawing.Color.Black;
			this.Add_table_button.Location = new System.Drawing.Point(473, 4);
			this.Add_table_button.Name = "Add_table_button";
			this.Add_table_button.Size = new System.Drawing.Size(56, 32);
			this.Add_table_button.TabIndex = 14;
			this.Add_table_button.Text = "+";
			this.Add_table_button.UseVisualStyleBackColor = false;
			this.Add_table_button.Click += new System.EventHandler(this.Add_table_button_Click);
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
			this.panel2.Controls.Add(this.Choose_comboBox);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.Search_Settings_Box);
			this.panel2.Controls.Add(this.Search_Box);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Location = new System.Drawing.Point(890, 12);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(280, 110);
			this.panel2.TabIndex = 38;
			// 
			// Choose_comboBox
			// 
			this.Choose_comboBox.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.Choose_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Choose_comboBox.FormattingEnabled = true;
			this.Choose_comboBox.Location = new System.Drawing.Point(143, 32);
			this.Choose_comboBox.Name = "Choose_comboBox";
			this.Choose_comboBox.Size = new System.Drawing.Size(131, 28);
			this.Choose_comboBox.TabIndex = 11;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.SystemColors.HotTrack;
			this.label6.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(3, 6);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(56, 22);
			this.label6.TabIndex = 10;
			this.label6.Text = "Filter";
			// 
			// Search_Settings_Box
			// 
			this.Search_Settings_Box.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.Search_Settings_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Search_Settings_Box.FormattingEnabled = true;
			this.Search_Settings_Box.Location = new System.Drawing.Point(7, 32);
			this.Search_Settings_Box.Name = "Search_Settings_Box";
			this.Search_Settings_Box.Size = new System.Drawing.Size(131, 28);
			this.Search_Settings_Box.TabIndex = 4;
			this.Search_Settings_Box.SelectedIndexChanged += new System.EventHandler(this.Search_Settings_Box_SelectedIndexChanged);
			// 
			// Search_Box
			// 
			this.Search_Box.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.Search_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Search_Box.Location = new System.Drawing.Point(79, 66);
			this.Search_Box.Name = "Search_Box";
			this.Search_Box.Size = new System.Drawing.Size(195, 29);
			this.Search_Box.TabIndex = 3;
			this.Search_Box.TextChanged += new System.EventHandler(this.Search_Box_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(4, 72);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 24);
			this.label1.TabIndex = 6;
			this.label1.Text = "Поиск";
			// 
			// Delete_checkBox
			// 
			this.Delete_checkBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Delete_checkBox.AutoSize = true;
			this.Delete_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Delete_checkBox.Location = new System.Drawing.Point(890, 128);
			this.Delete_checkBox.Name = "Delete_checkBox";
			this.Delete_checkBox.Size = new System.Drawing.Size(225, 28);
			this.Delete_checkBox.TabIndex = 39;
			this.Delete_checkBox.Text = "Удаление по фильтру";
			this.Delete_checkBox.UseVisualStyleBackColor = true;
			// 
			// Tables_TabControl
			// 
			this.Tables_TabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Tables_TabControl.Controls.Add(this.Users);
			this.Tables_TabControl.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.Tables_TabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Tables_TabControl.Location = new System.Drawing.Point(15, 162);
			this.Tables_TabControl.Multiline = true;
			this.Tables_TabControl.Name = "Tables_TabControl";
			this.Tables_TabControl.SelectedIndex = 0;
			this.Tables_TabControl.Size = new System.Drawing.Size(1158, 490);
			this.Tables_TabControl.TabIndex = 40;
			this.Tables_TabControl.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.Tables_TabControl_Selecting);
			// 
			// Users
			// 
			this.Users.BackColor = System.Drawing.Color.Transparent;
			this.Users.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.Users.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.Users.Location = new System.Drawing.Point(4, 29);
			this.Users.Name = "Users";
			this.Users.Padding = new System.Windows.Forms.Padding(3);
			this.Users.Size = new System.Drawing.Size(1150, 457);
			this.Users.TabIndex = 0;
			this.Users.Text = "Person";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.tableLayoutPanel1.ColumnCount = 6;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.Controls.Add(this.Change_button, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.ADD_button, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.DELETE_button, 2, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(19, 658);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(626, 78);
			this.tableLayoutPanel1.TabIndex = 41;
			// 
			// Change_button
			// 
			this.Change_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Change_button.BackColor = System.Drawing.Color.White;
			this.Change_button.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.Change_button.Font = new System.Drawing.Font("Onyx", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Change_button.ForeColor = System.Drawing.Color.Black;
			this.Change_button.Location = new System.Drawing.Point(107, 3);
			this.Change_button.Name = "Change_button";
			this.Change_button.Size = new System.Drawing.Size(98, 67);
			this.Change_button.TabIndex = 20;
			this.Change_button.Text = "Изменить";
			this.Change_button.UseVisualStyleBackColor = false;
			this.Change_button.Click += new System.EventHandler(this.Change_button_Click);
			// 
			// ADD_button
			// 
			this.ADD_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ADD_button.BackColor = System.Drawing.Color.White;
			this.ADD_button.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.ADD_button.Font = new System.Drawing.Font("Onyx", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ADD_button.ForeColor = System.Drawing.Color.Black;
			this.ADD_button.Location = new System.Drawing.Point(3, 3);
			this.ADD_button.Name = "ADD_button";
			this.ADD_button.Size = new System.Drawing.Size(98, 67);
			this.ADD_button.TabIndex = 0;
			this.ADD_button.Text = "Добавить";
			this.ADD_button.UseVisualStyleBackColor = false;
			this.ADD_button.Click += new System.EventHandler(this.ADD_button_Click);
			// 
			// DELETE_button
			// 
			this.DELETE_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.DELETE_button.BackColor = System.Drawing.Color.White;
			this.DELETE_button.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.DELETE_button.Font = new System.Drawing.Font("Onyx", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.DELETE_button.ForeColor = System.Drawing.Color.Black;
			this.DELETE_button.Location = new System.Drawing.Point(211, 3);
			this.DELETE_button.Name = "DELETE_button";
			this.DELETE_button.Size = new System.Drawing.Size(98, 67);
			this.DELETE_button.TabIndex = 18;
			this.DELETE_button.Text = "Удалить";
			this.DELETE_button.UseVisualStyleBackColor = false;
			this.DELETE_button.Click += new System.EventHandler(this.DELETE_button_Click);
			// 
			// Main_Window
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1182, 748);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.Tables_TabControl);
			this.Controls.Add(this.Delete_checkBox);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel3);
			this.Name = "Main_Window";
			this.Text = "Main_Window";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_Window_FormClosing);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.Tables_TabControl.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox DB_Tables_comboBox;
		private System.Windows.Forms.Button Delete_table_button;
		private System.Windows.Forms.Button Add_table_button;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.ComboBox Choose_comboBox;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox Search_Settings_Box;
		private System.Windows.Forms.TextBox Search_Box;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox Delete_checkBox;
		private System.Windows.Forms.TabControl Tables_TabControl;
		private System.Windows.Forms.TabPage Users;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button Change_button;
		private System.Windows.Forms.Button ADD_button;
		private System.Windows.Forms.Button DELETE_button;
	}
}