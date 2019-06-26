using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyImageButton
{
    public partial class CustomsImageButton: PictureBox
    {
        public CustomsImageButton()
        {
            InitializeComponent();
        }

		private Image normalImage;
		private Image hoverImage;

		public Image ImageNormal {
			get { return normalImage; }
			set { normalImage = value; }
		}

		public Image ImageHover {
			get { return hoverImage; }
			set { hoverImage = value; }
		}

		private void CustomsImageButton_MouseHover(object sender, EventArgs e)
		{
			this.Image = hoverImage;
		}

		private void CustomsImageButton_MouseLeave(object sender, EventArgs e)
		{
			this.Image = normalImage;
		}
	}
}
