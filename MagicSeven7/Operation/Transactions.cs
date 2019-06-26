using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MagicSeven7.Operation
{
    public partial class Transactions : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=JONALYN;Initial Catalog=magic7;Integrated Security=True");

        int mov, movX, movY;

        // Start of Ddrop Shadow effect
        private bool m_aeroEnabled;

        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCPAINT = 0x0085;
        private const int WM_ACTIVATEAPP = 0x001C;

        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]

        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );

        public struct MARGINS
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }
        protected override CreateParams CreateParams
        {
            get
            {
                m_aeroEnabled = CheckAeroEnabled();
                CreateParams cp = base.CreateParams;
                if (!m_aeroEnabled)
                    cp.ClassStyle |= CS_DROPSHADOW; return cp;
            }
        }
        private bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0; DwmIsCompositionEnabled(ref enabled);
                return (enabled == 1) ? true : false;
            }
            return false;
        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCPAINT:
                    if (m_aeroEnabled)
                    {
                        var v = 2;
                        DwmSetWindowAttribute(this.Handle, 4, ref v, 8);
                        MARGINS margins = new MARGINS()
                        {
                            bottomHeight = 1,
                            leftWidth = 0,
                            rightWidth = 0,
                            topHeight = 0
                        }; DwmExtendFrameIntoClientArea(this.Handle, ref margins);
                    }
                    break;
                default: break;
            }
            base.WndProc(ref m);
        }
        // End of Ddrop Shadow effect

        private void bunifuCardstop_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void bunifuCardstop_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
                this.Opacity = 0.7;
            }
        }

        private void bunifuCardstop_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
            this.Opacity = 1;
        }

        //Method
        public void datagridrefresh()
        {
            SqlCommand cmd = new SqlCommand("select * from Courierr", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            dataGridViewOperation.DataSource = dt.Tables[0].DefaultView;
        }


        private void Transactions_Load(object sender, EventArgs e)
        {
            datagridrefresh();
            dataGridViewOperation.Columns["DNno"].DefaultCellStyle.Format = "000000";
        }

        private void dataGridViewOperation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select Qty, Unit, Itemdes, Doref, CBM from Items where DnNo = '" + dataGridViewOperation.CurrentRow.Cells["DnNO"].Value + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            DataGridViewQuantity.DataSource = dt.Tables[0].DefaultView;
        }

        private void txtBoxSearch_OnValueChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select * from Courierr where DnNo like '" + txtBoxSearch.Text + "%'";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            dataGridViewOperation.DataSource = dt.Tables[0].DefaultView;
        }

        public Transactions()
        {
            InitializeComponent();
            m_aeroEnabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
