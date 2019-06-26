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
	public partial class ucUtilityBody : UserControl
	{
		private static ucUtilityBody _instance;

		public static ucUtilityBody Instance
		{
			get
			{
				if (_instance == null) _instance = new ucUtilityBody();
				return _instance;
			}
		}

        //SqlConnection con = new SqlConnection(@"Data Source=EJ\EJ;Initial Catalog=magic7;Integrated Security=True");
        SqlConnection con = new SqlConnection(@"Data Source=JONALYN;Initial Catalog=magic7;Integrated Security=True");
        public void datagridrefresh()
        {
            SqlCommand cmd = new SqlCommand("select * from MagicUser", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            dataGridUser.DataSource = dt.Tables[0].DefaultView;
        }

        public ucUtilityBody()
		{
			InitializeComponent();
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

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {

        }
    }
}
