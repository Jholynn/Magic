using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MagicSeven7.Utility
{
	public partial class ucBody : UserControl
	{
		private static ucBody _instance;

		public static ucBody Instance
		{
			get
			{
				if (_instance == null) _instance = new ucBody();
				return _instance;
			}
		}

		SqlConnection con = new SqlConnection(@"Data Source=EJ\SQLEXPRESS;Initial Catalog=MagicSeven7;Integrated Security=True");

        public void datagridrefresh()
        {
            SqlCommand cmd = new SqlCommand("select * from m7Users", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            dataGridUser.DataSource = dt.Tables[0].DefaultView;
        }

        public ucBody()
		{
			InitializeComponent();
		}

		private void btnSignUp_Click(object sender, EventArgs e)
		{
			// animation hover
			panelActive.Width = btnSignUp.Width;
			panelActive.Left = btnSignUp.Left;
		}

		private void btnArchive_Click(object sender, EventArgs e)
		{
			// animation hover
			panelActive.Width = btnArchive.Width;
			panelActive.Left = btnArchive.Left;
		}

		private void btnAuditTrail_Click(object sender, EventArgs e)
		{
			// animation hover
			panelActive.Width = btnAuditTrail.Width;
			panelActive.Left = btnAuditTrail.Left;
		}

		private void btnBackup_Click(object sender, EventArgs e)
		{
			// animation hover
			panelActive.Width = btnBackup.Width;
			panelActive.Left = btnBackup.Left;
		}

		private void ucBody_Load(object sender, EventArgs e)
		{
            datagridrefresh();
        }

        private void btnShutDown_Click(object sender, EventArgs e)
        {
            CreateAccount ca = new CreateAccount();
            ca.ShowDialog();
        }
    }
}
