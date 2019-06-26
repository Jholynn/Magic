using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagicSeven7.Dialog_Message_Box
{
	public partial class mainDialogMessageBox : Form
	{
        int mov, movX, movY;

        // Start of Ddrop Shadow effect
        // End of Ddrop Shadow effect

    public mainDialogMessageBox()
		{
			InitializeComponent();
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
            }
        }

        private void panelHeader_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void btnExit_Click_1(object sender, EventArgs e)
		{
			this.Dispose();
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
