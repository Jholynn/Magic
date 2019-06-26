using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagicSeven7.Accounting
{
    public partial class ucAccounting : UserControl
    {
        private static ucAccounting _instance;

        public static ucAccounting Instance
        {
            get
            {
                if (_instance == null) _instance = new ucAccounting();
                return _instance;
            }
        }

        public ucAccounting()
        {
            InitializeComponent();
        }
    }
}
