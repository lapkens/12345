using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timesheet
{
	public partial class Autorisation : Form
	{
		public Autorisation()
		{	
			InitializeComponent();
			connectionstring = "Server = " + serv + ";Initial catalog = " + catal + "; Integrated Security = true";
			Re_password_textBox.Visible = false;
			label3.Visible = false;
			Announce_label.Text = "";
		}

		static string connectionstring = "";//строка подключения к СУБД
		string serv = "DESKTOP-LHANI58";//сервер
		string catal = "raspisanie";//каталог
		bool registration = false;
		string rights = "User";
		private void Login_button_Click(object sender, EventArgs e)
		{
			SqlConnection con = new SqlConnection(connectionstring);
			SqlDataAdapter da = new SqlDataAdapter("SELECT User_Login, User_Password, ID_Role FROM Users", con);

			DataTable dt = new DataTable();
			da.Fill(dt);
			con.Close();


			DataGridView dgv = new DataGridView();
			this.Controls.Add(dgv);
			dgv.DataSource = dt;
			dgv.Show();
			List<string> list = new List<string>();

			if (registration)
			{
				for (int i = 0; i < dgv.Rows.Count - 1; i++)
				{
					if (Login_textBox.Text == dgv[0, i].Value + "")
					{
						Announce_label.Text = "Данный логин занят!";
						this.Controls.Remove(dgv);
						return;
					}
				}
				if (Password_textBox.Text == Re_password_textBox.Text)
				{
                    SqlConnection reg_con = new SqlConnection(connectionstring);
					SqlDataAdapter reg_da = new SqlDataAdapter($"INSERT INTO Users (User_Login, User_Password, ID_Role  ) VALUES ('{Login_textBox.Text}','{Password_textBox.Text}','{1}')", reg_con);
                    DataTable reg_dt = new DataTable();
					reg_da.Fill(reg_dt);
                    reg_con.Close(); Announce_label.Text = "Вы успешно зарегистрированны!";

                    Login_button.Text = "Войти";
					Re_password_textBox.Visible = false;
					label3.Visible = false;
					Reg_button.Visible = true;
					registration = false;
				}
				else
				{
					Announce_label.Text = "Пароли не совпадают!";

				}
			}
			else
			{
				Login_button.Text = "Войти";
				for (int i = 0; i < dgv.Rows.Count - 1; i++)
				{
					if (Login_textBox.Text == dgv[0, i].Value + "" && Password_textBox.Text == dgv[1, i].Value + "")
					{
						if (dgv[2, i].Value + "" == "1")
						{
							rights = "User";
							Main_Window catalog = new Main_Window(connectionstring, rights/*Login_textBox.Text*/);
							catalog.Show();
							this.Hide();
						}
						else
						{
							rights = "Admin";
							Main_Window catalog = new Main_Window(connectionstring, rights/*Login_textBox.Text*/);
							catalog.Show();
							this.Hide();
						}
					}
				}
			}

			this.Controls.Remove(dgv);
		}

		private void Reg_button_Click(object sender, EventArgs e)
		{
			Re_password_textBox.Visible = true;
			label3.Visible = true;
			Reg_button.Visible = false;
			Login_button.Text = "Подтвердить";
			registration = true;
		}

	}
}
