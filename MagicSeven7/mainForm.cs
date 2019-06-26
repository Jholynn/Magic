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
using System.Media;

namespace MagicSeven7
{
	public partial class mainForm : Form
	{
        SqlConnection con = new SqlConnection(@"Data Source=JONALYN;Initial Catalog=magic7;Integrated Security=True");
        int mov, movX, movY;

        private const int dropShadow = 0x00020000;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= dropShadow;
                return cp;
            }
        }

        public mainForm()
        {
            InitializeComponent();
        }

        private void btnShutDown_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnMinimized_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}
		private void panelHeader_MouseDown(object sender, MouseEventArgs e)
		{
			mov = 1;
			movX = e.X;
			movY = e.Y;
        }

		private void panelHeader_MouseMove(object sender, MouseEventArgs e)
		{
			if (mov == 1)
			{
				this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
                this.Opacity = 0.7;
			}
            
		}

		private void panelHeader_MouseUp(object sender, MouseEventArgs e)
		{
			mov = 0;
            this.Opacity = 1;
        }

		//private void txtBoxUserName_MouseEnter(object sender, EventArgs e)
		//{
		//	if (txtBoxUserName.Text == "User Name")
		//	{
		//		txtBoxUserName.Text = "";
		//		txtBoxUserName.ForeColor = Color.DimGray;
		//	}
		//}

		//private void txtBoxUserName_MouseLeave(object sender, EventArgs e)
		//{
		//	if (txtBoxUserName.Text == "")
		//	{
		//		txtBoxUserName.Text = "User Name";
		//		txtBoxUserName.ForeColor = Color.DimGray;
		//	}
		//}

		private void txtBoxPassword_MouseEnter(object sender, EventArgs e)
		{
			if (txtBoxPassword.Text == "Password")
			{
				txtBoxPassword.Text = "";
				txtBoxPassword.isPassword = true;
				txtBoxPassword.ForeColor = Color.DimGray;
			}
		}

		private void txtBoxPassword_MouseLeave(object sender, EventArgs e)
		{
			if (txtBoxPassword.Text == "")
			{
				txtBoxPassword.Text = "Password";
				txtBoxPassword.isPassword = false;
				txtBoxPassword.ForeColor = Color.DimGray;
			}
		}

		private void picBoxShowPassword_MouseDown(object sender, MouseEventArgs e)
		{
			txtBoxPassword.isPassword = false;
		}

		private void picBoxShowPassword_MouseUp(object sender, MouseEventArgs e)
		{
			txtBoxPassword.isPassword = true;
		}

		private void txtBoxPassword_Enter(object sender, EventArgs e)
		{
			txtBoxPassword.Text = "";
		}

		private void txtBoxPassword_OnValueChanged(object sender, EventArgs e)
		{
			txtBoxPassword.isPassword = true;
		}

        private void mainForm_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnLogin;
        }

        private void btnForgetPassword_Click(object sender, EventArgs e)
		{

		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
            SqlConnection con = new SqlConnection(@"Data Source=JONALYN;Initial Catalog=magic7;Integrated Security=True");
            //SqlConnection con = new SqlConnection(@"Data Source=EJ\EJ;Initial Catalog=magic7;Integrated Security=True");
            con.Open();
			SqlCommand cmd = new SqlCommand("select Department from MagicUser where Username='" + txtBoxUserName.Text + "'and Password='" + txtBoxPassword.Text + "'", con);
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			da.Fill(dt);
            if (txtBoxUserName.Text.Trim() == "")
            {
                SystemSounds.Exclamation.Play();
                Dialog_Message_Box.mainDialogMessageBox error = new Dialog_Message_Box.mainDialogMessageBox();
                error.ShowDialog();
                txtBoxUserName.Focus();
                return;
            }

            if (txtBoxPassword.Text.Trim() == "")
            {
                SystemSounds.Exclamation.Play();
                Dialog_Message_Box.mainDialogMessageBox error = new Dialog_Message_Box.mainDialogMessageBox();
                error.ShowDialog();
                txtBoxPassword.Focus();
                return;
            }

            if (dt.Rows.Count == 1)
			{
                if (dt.Rows[0][0].ToString() == "Admin")
                {
                    Dashboard dash = new Dashboard();
                    dash.Show();
                    dash.btnOperation.Enabled = false;
                    dash.btnOperation.Textcolor = Color.DimGray;
                    dash.btnOperation.Iconimage = Properties.Resources.Operator_DimGray;
                    dash.btnAccounting.Enabled = false;
                    dash.btnAccounting.Textcolor = Color.DimGray;
                    dash.btnAccounting.Iconimage = Properties.Resources.Accounting_dimGray;
                    this.Hide();
                }
                if (dt.Rows[0][0].ToString() == "Accounting")
                {
                    Dashboard dash = new Dashboard();
                    dash.Show();
                    dash.btnOperation.Enabled = false;
                    dash.btnOperation.Textcolor = Color.DimGray;
                    dash.btnOperation.Iconimage = Properties.Resources.Operator_DimGray;
                    dash.btnUtility.Enabled = false;
                    dash.btnUtility.Textcolor = Color.DimGray;
                    dash.btnUtility.Iconimage = Properties.Resources.utility_dimGray;
                    this.Hide();
                }
                if (dt.Rows[0][0].ToString() == "Operation")
                {
                    Dashboard dash = new Dashboard();
                    dash.Show();
                    dash.btnAccounting.Enabled = false;
                    dash.btnAccounting.Textcolor = Color.DimGray;
                    dash.btnAccounting.Iconimage = Properties.Resources.Accounting_dimGray;
                    dash.btnUtility.Enabled = false;
                    dash.btnUtility.Textcolor = Color.DimGray;
                    dash.btnUtility.Iconimage = Properties.Resources.utility_dimGray;
                    this.Hide();
                }
            }
			else
			{
				SystemSounds.Exclamation.Play();
				Dialog_Message_Box.mainDialogMessageBox error = new Dialog_Message_Box.mainDialogMessageBox();
				error.ShowDialog();
			}
			con.Close();
		}
	}
}
