using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagicSeven7
{
	public partial class Dashboard : Form
	{
		public Dashboard()
		{
			InitializeComponent();
		}

        // dropshadow start
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
        // dropshadow end

        int mov, movX, movY;

        private void btnMinimized_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButtonMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            bunifuImageButtonMaximize.Visible = false;
            bunifuImageButtonMinimizer.Visible = true;
        }

        private void bunifuImageButtonMinimizer_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            bunifuImageButtonMinimizer.Visible = false;
            bunifuImageButtonMaximize.Visible = true;
        }

        private void btnShutDown_Click(object sender, EventArgs e)
        {
            mainForm mf = new mainForm();
            this.Dispose();
            mf.ShowDialog();
            
        }

        private void bunifuCardsHeader_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
            this.Opacity = 1;
        }

        private void bunifuCardsHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
                this.Opacity = 0.7;
            }
        }

        private void bunifuCardsHeader_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            // animation hover
            panelLeftActive.Height = btnHome.Height;
            panelLeftActive.Top = btnHome.Top;
        }

        private void btnOperation_Click(object sender, EventArgs e)
        {
            // animation hover
            panelLeftActive.Height = btnOperation.Height;
            panelLeftActive.Top = btnOperation.Top;
            
            //Open new User Controls
            panelDashBoardBody.Controls.Clear();

            if (!panelDashBoardBody.Controls.Contains(Operation.ucOperationBody.Instance))
            {
                panelDashBoardBody.Controls.Add(Operation.ucOperationBody.Instance);
                Operation.ucOperationBody.Instance.Dock = DockStyle.Fill;
                Operation.ucOperationBody.Instance.BringToFront();
            }
            else
            {
                Operation.ucOperationBody.Instance.BringToFront();
            }
          
        }

        private void btnAccounting_Click(object sender, EventArgs e)
        {
            // animation hover
            panelLeftActive.Height = btnAccounting.Height;
            panelLeftActive.Top = btnAccounting.Top;

            //Open new User Controls
            panelDashBoardBody.Controls.Clear();

            if (!panelDashBoardBody.Controls.Contains(Accounting.ucAccounting.Instance))
            {
                panelDashBoardBody.Controls.Add(Accounting.ucAccounting.Instance);
                Accounting.ucAccounting.Instance.Dock = DockStyle.None;
                Accounting.ucAccounting.Instance.BringToFront();
            }
            else
            {
                Accounting.ucAccounting.Instance.BringToFront();
            }
        }

        private void btnUtility_Click(object sender, EventArgs e)
        {
            // animation hover
            panelLeftActive.Height = btnUtility.Height;
            panelLeftActive.Top = btnUtility.Top;
  
            //Open new User Controls
            panelDashBoardBody.Controls.Clear();

            if (!panelDashBoardBody.Controls.Contains(Utility.ucUtilityBody.Instance))
            {
                panelDashBoardBody.Controls.Add(Utility.ucUtilityBody.Instance);
                Utility.ucUtilityBody.Instance.Dock = DockStyle.Fill;
                Utility.ucUtilityBody.Instance.BringToFront();
            }
            else
            {
                Utility.ucUtilityBody.Instance.BringToFront();
            }
        }
    }
}
