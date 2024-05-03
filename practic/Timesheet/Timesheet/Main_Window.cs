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
	public partial class Main_Window : Form
	{
		public Main_Window(string _connectionstring, string _rights)
		{
			InitializeComponent();
			rights = _rights;
			connectionstring = _connectionstring;
			recognise_user(rights);
			Get_Tables(connectionstring);
		}
		static string rights = "";
		static string connectionstring = "";

		string Current_Table = "";//текущая выбранная таблица

		void recognise_user(string rights)
		{
			switch (rights)
			{
				case "User":
					{
						DELETE_button.Visible = false;
						ADD_button.Visible = false;
						Change_button.Visible = false;
						Delete_checkBox.Visible = false;
					}
					break;
				case "Admin":
					{
					
					}
					break;
				default:
					break;
			}
		}

		void Get_Tables(string connectionstring)//получение списка таблиц из базы данных и добавление первой из них
		{
			try
			{
				//__________________________Добавление существующих таблиц из ИС__________________________
				SqlConnection con = new SqlConnection(connectionstring);
				SqlDataAdapter da;
				if (rights != "User")
					da = new SqlDataAdapter("SELECT table_name FROM information_schema.tables WHERE table_name !=  'sysdiagrams'", con);
				else
					da = new SqlDataAdapter("SELECT table_name FROM information_schema.tables WHERE table_name !=  'sysdiagrams' and table_name !=  'Users'", con);

				DataTable dt = new DataTable();
				da.Fill(dt);
				con.Close();
				
				DB_Tables_comboBox.DataSource = dt;
				DB_Tables_comboBox.DisplayMember = "TABLE_NAME";
				DB_Tables_comboBox.ValueMember = "TABLE_NAME";	
			}
			catch { }


			Tables_TabControl.TabPages.Clear();
			Tables_TabControl.TabPages.Add(DB_Tables_comboBox.SelectedValue.ToString(), Name = DB_Tables_comboBox.SelectedValue.ToString()); // НАИМЕНОВАНИЕ НАЧАЛЬНОЙ ТАБЛИЦЫ ДЛЯ ОТОБРАЖЕНИЯ 
			try
			{
				Current_Table = Tables_TabControl.SelectedTab.Name;
			}
			catch { }

			CreateTable();
			RefreshTable();

			//________________________________________________________________________________________
		}

		private void Add_table_button_Click(object sender, EventArgs e)
		{
			bool cont = false;
			foreach (Control c in Tables_TabControl.Controls)
			{
				if (DB_Tables_comboBox.Text == "" || c.Name.Contains(DB_Tables_comboBox.Text))//&& TabControl1. Contains(comboBox5.Text) == false)
				{
					cont = true;
				}
			}

			if (!cont)
			{
				Tables_TabControl.TabPages.Add(DB_Tables_comboBox.Text, Name = DB_Tables_comboBox.Text);
			}
		}

		private void Delete_table_button_Click(object sender, EventArgs e)
		{
			if (Tables_TabControl.TabCount > 1)
			{
				Tables_TabControl.TabPages.Remove(Tables_TabControl.SelectedTab);
			}
		}

		private void Change_button_Click(object sender, EventArgs e)
		{
			string querry = "UPDATE  " + Current_Table + " SET ";

			foreach (var ctrl in Tables_TabControl.SelectedTab.Controls)
			{
				var dgv = ctrl as DataGridView;

				if (dgv != null)
				{
					try
					{
						SqlConnection con = new SqlConnection(connectionstring);

						querry += " ";

						for (int g = 1; g <= dgv.Columns.Count - 1; g++)
						{
							querry += " " + dgv.Columns[g].Name + " = " + " '" + dgv[g, Convert.ToInt32(dgv.CurrentRow.Index)].Value.ToString() + "', ";
						}

						querry = querry.Remove(querry.LastIndexOf(","));
						querry += " WHERE " + dgv.Columns[0].Name + " = " + dgv[0, Convert.ToInt32(dgv.CurrentRow.Index)].Value.ToString();

						//MessageBox.Show(querry);
						SqlDataAdapter da = new SqlDataAdapter(querry, con);
						DataTable dt = new DataTable();
						da.Fill(dt);
						con.Close();
						//Clipboard.SetText(querry);
						RefreshTable();
						MessageBox.Show("Данные измненены!");
					}
					catch
					{
						RefreshTable();
					}
				}
			}
		}

		private void ADD_button_Click(object sender, EventArgs e)
		{
			string querry = "INSERT INTO " + Current_Table + " ";

			foreach (var ctrl in Tables_TabControl.SelectedTab.Controls)
			{
				var dgv = ctrl as DataGridView;

				if (dgv != null)
				{
					try
					{
						SqlConnection con = new SqlConnection(connectionstring);

						querry += "(";

						for (int g = 1; g <= dgv.Columns.Count - 1; g++)
						{
							querry += " " + dgv.Columns[g].Name + ", ";
						}

						querry = querry.Remove(querry.LastIndexOf(","));
						querry += ") ";
						querry += " VALUES ";
						querry += "(";

						for (int g = 1; g <= dgv.Columns.Count - 1; g++)
						{
							querry += " '" + dgv[g, Convert.ToInt32(dgv.CurrentRow.Index)].Value.ToString() + "',";
						}

						querry = querry.Remove(querry.LastIndexOf(","));
						querry += ") ";

						//Clipboard.SetText(querry);
						SqlDataAdapter da = new SqlDataAdapter(querry, con);
						DataTable dt = new DataTable();
						da.Fill(dt);
						con.Close();
						RefreshTable();
						MessageBox.Show("Данные добавлены!");
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex + "");
						RefreshTable();
					}
				}
			}
		}


		void CreateTable()//создание таблиц внутри tabcontrol
		{
			DataGridView dgv = new DataGridView();

			dgv.Show();
			dgv.Dock = DockStyle.Fill;
			//dgv.AllowUserToAddRows = false;
			//dgv.ReadOnly = true;
			dgv.BackgroundColor = this.BackColor;//Color.FromArgb(51, 51, 153);
			Tables_TabControl.SelectedTab.Controls.Add(dgv);
			dgv.GridColor = Color.Black;
			dgv.BorderStyle = BorderStyle.FixedSingle;

			dgv.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
			dgv.RowsDefaultCellStyle.BackColor = Color.LightBlue;
			dgv.RowsDefaultCellStyle.ForeColor = Color.Black;
			dgv.RowsDefaultCellStyle.SelectionBackColor = Color.LightGreen;
			dgv.RowsDefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));

			dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
			dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
			dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;//Color.FromArgb(255,0,0);// Color.Yellow;
			dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Black;
			dgv.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));

			dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.White;//цвет нечетных строк
			dgv.DefaultCellStyle.BackColor = Color.Black;
			//dgv.BackgroundColor = this.BackColor;
			dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

			if (rights == "User")
			{
				dgv.ReadOnly = true;
			}

			dgv.Refresh();
		}




		void RefreshTable()//обновление таблиц внутри tabcontrol
		{
			SqlConnection con = new SqlConnection(connectionstring);

			foreach (var ctrl in Tables_TabControl.SelectedTab.Controls)
			{
				var dgv = ctrl as DataGridView;
				if (dgv != null)
				{
					string querry = $"SELECT * FROM {Current_Table}";
					dgv.DataSource = null;

					SqlDataAdapter da = new SqlDataAdapter(querry, con);
					DataTable dt = new DataTable();
					da.Fill(dt);
					dgv.DataSource = dt;

					Search_Settings_Box.DataSource = dgv.Columns;

					try
					{
						label6.Text = "Filter ";// + dgv.Columns[i].Name;
						Search_Settings_Box.DisplayMember = "HeaderText";//dgv.Columns[i].HeaderText.ToString();//dgv.Rows[0].Cells.ToString();
						Search_Settings_Box.ValueMember = "HeaderText";//dgv.Columns[i].HeaderText;
					}
					catch { }

					Search_Settings_Box.SelectionStart = Search_Box.TextLength;
					Search_Box.ScrollToCaret();
				}
				dgv.Refresh();
			}
			con.Close();
		}

		private void DELETE_button_Click(object sender, EventArgs e)
		{
			try
			{
				if (Delete_checkBox.Checked)
				{
					SqlConnection con = new SqlConnection(connectionstring);

					foreach (var ctrl in Tables_TabControl.SelectedTab.Controls)
					{
						var dgv = ctrl as DataGridView;
						if (dgv != null)
						{
							SqlDataAdapter da = new SqlDataAdapter("DELETE FROM " + Current_Table + " Where [" + Search_Settings_Box.Text + "] LIKE '%" + Search_Box.Text + "%'", con);// " + Search_Box.Text, con);//dgv.Columns[i].Name

							DataTable dt = new DataTable();
							da.Fill(dt);

							dgv.DataSource = dt;
							dgv.Refresh();

							RefreshTable();
							MessageBox.Show("Данные удалены!");
						}
					}
					con.Close();
				}
				else
				{
					SqlConnection con = new SqlConnection(connectionstring);

					foreach (var ctrl in Tables_TabControl.SelectedTab.Controls)
					{
						var dgv = ctrl as DataGridView;
						if (dgv != null)
						{
							string querry = $"DELETE FROM {Current_Table} WHERE {dgv.Columns[0].Name} = '{dgv[0, Convert.ToInt32(dgv.CurrentRow.Index)].Value.ToString()}' ";
							//MessageBox.Show(querry);
							SqlDataAdapter da = new SqlDataAdapter(querry, con);// " + Search_Box.Text, con);//dgv.Columns[i].Name

							DataTable dt = new DataTable();
							da.Fill(dt);

							dgv.DataSource = dt;
							dgv.Refresh();

							RefreshTable();
							MessageBox.Show("Данные удалены!");
						}
					}
					con.Close();
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

			if (Search_Box.Text == "")
			{
				RefreshTable();
			}
		}

		private void Search_Settings_Box_SelectedIndexChanged(object sender, EventArgs e)
		{
			SqlConnection con = new SqlConnection(connectionstring);
			SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM " + Current_Table, con);
			DataTable dt = new DataTable();
			da.Fill(dt);

			Choose_comboBox.DataSource = dt;
			Choose_comboBox.DisplayMember = Search_Settings_Box.Text;
			Choose_comboBox.ValueMember = dt.Columns[1].ToString();

			Search_Settings_Box.SelectionStart = Search_Box.TextLength;
			Search_Box.ScrollToCaret();
			con.Close();
		}

		private void Search_Box_TextChanged(object sender, EventArgs e)
		{
			try
			{
				SqlConnection con = new SqlConnection(connectionstring);

				foreach (var ctrl in Tables_TabControl.SelectedTab.Controls)
				{
					var dgv = ctrl as DataGridView;
					if (dgv != null)
					{
						SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM " + Current_Table + " Where [" + Search_Settings_Box.Text + "] LIKE '%" + Search_Box.Text + "%'", con);// " + Search_Box.Text, con);//dgv.Columns[i].Name

						DataTable dt = new DataTable();
						da.Fill(dt);

						dgv.DataSource = dt;
						dgv.Refresh();
					}
				}
				con.Close();
			}
			catch { }

			if (Search_Box.Text == "")
			{
				RefreshTable();
			}
		}


		private void Tables_TabControl_Selecting(object sender, TabControlCancelEventArgs e)
		{
			try
			{
				Current_Table = Tables_TabControl.SelectedTab.Name;

				foreach (var ctrl in Tables_TabControl.SelectedTab.Controls)
				{
					var dgv = ctrl as DataGridView;
					if (dgv != null)
					{


						Tables_TabControl.SelectedTab.Controls.Remove(dgv);
					}
				}
			}
			catch { }

			CreateTable();
			RefreshTable();
		}

		private void Main_Window_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}
	}
}
