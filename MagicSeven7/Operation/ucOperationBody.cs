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

namespace MagicSeven7.Operation
{
    public partial class ucOperationBody : UserControl
    {
        //SqlConnection con = new SqlConnection(@"Data Source=EJ\EJ;Initial Catalog=magic7;Integrated Security=True");
        SqlConnection con = new SqlConnection(@"Data Source=JONALYN;Initial Catalog=magic7;Integrated Security=True");
        private static ucOperationBody _instance;

        public static ucOperationBody Instance
        {
            get
            {
                if (_instance == null) _instance = new ucOperationBody();
                return _instance;
            }
        }

        //Method 
        public void datagridrefresh()
        {
            SqlCommand cmd = new SqlCommand("select * from Courierr", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            dataGridOperation.DataSource = dt.Tables[0].DefaultView;
        }
        public void idload()
        {
            //Id +1
            SqlCommand cmd = new SqlCommand("select max(DNno)+1 as Id from Courierr", con);
            con.Open();
            txtBoxDn_No.Text = String.Format("{0:000000}", cmd.ExecuteScalar());
            con.Close();
        }
        public void addInfo()
        {
            //adding Courier in database
            SqlConnection con = new SqlConnection(@"Data Source=JONALYN;Initial Catalog=magic7;Integrated Security=True");
            con.Open();
            try
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "Insert into Courierr(Dateissued,ClientRef,DeliveredTo,ATTN,Tel, Driver, ContactNo,PlateNo,Helper1,Helper2,Helper3,SpecialIns) values ('" + this.datePicker.Value.Date + "','" + this.txtBoxClientRef.Text + "','" + this.txtBoxDeliveredTo.Text + "','" + this.txtBoxAttn.Text + "','" + this.bunifuMetroTel.Text + "','" + this.txtBoxDriver.Text + "','" + this.txtBoxContactNo.Text + "','" + this.bunifuMetroPlateno.Text + "','" + this.txtBoxHelper1.Text + "','" + this.txtBoxHelper2.Text + "','" + this.txtBoxHelper3.Text + "','" + this.bunifuCustomTextbox1.Text + "')";
                SqlDataReader rdr;
                rdr = cmd.ExecuteReader();
                MessageBox.Show("Save Data");
                while (rdr.Read())
                {
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public ucOperationBody()
        {
            InitializeComponent();
        }
 
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtBoxQuantity.Text == "" && txtBoxItemDescription.Text == "" && txtBoxDO_Ref.Text== "" && txtBoxCBM.Text == "")
            {
                MessageBox.Show("Please fill the needed information!");
            }
            else
            {
                string Colum1 = txtBoxQuantity.Text;
                string Colum2 = comboBoxUnit.Text;
                string Colum3 = txtBoxItemDescription.Text;
                string Colum4 = txtBoxDO_Ref.Text;
                string Colum5 = txtBoxCBM.Text;
                string[] row = { Colum1, Colum2, Colum3, Colum4, Colum5 };
                dataGridOperation.Rows.Add(row);
            }
        }

        private void ucOperationBody_Load(object sender, EventArgs e)
        {
            idload();
            comboBoxUnit.selectedIndex= 0;
            if (txtBoxDn_No.Enabled == false)
            {
                txtBoxDn_No.ForeColor = Color.Red;
            }
            else
            {
                txtBoxDn_No.ForeColor = Color.Red;
            }
        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            if (dataGridOperation.CurrentRow == null)
            {
                MessageBox.Show("Please Complete the transaction.");
            }
            else
            {
                addInfo();
                idload();
            }
        }

        private void txtBoxDn_No_OnValueChanged(object sender, EventArgs e)
        {
            txtBoxDn_No.ForeColor = Color.Red;
        }

        private void btnViewTransaction_Click(object sender, EventArgs e)
        {
            Operation.Transactions operTrans = new Operation.Transactions();
            operTrans.ShowDialog();
        }
    }
}
