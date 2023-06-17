using MiddleLayer;
using FactoryCustomer;
using InterfaceCustomer;

namespace WinFormCustomer
{
    public partial class FormCustomer : Form
    {
        private ICustomer cust;

        public FormCustomer()
        {
            InitializeComponent();
        }

        private void SetCustomer()
        {
            cust.CustomerName = custName.Text;
            cust.PhoneNumber = phnNumber.Text;
            cust.BillAmount = Convert.ToDecimal(billAmountTxt.Text);
            cust.BillDate = Convert.ToDateTime(billDateTxt.Text);
            cust.Address = addressTextBox.Text;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                SetCustomer();
                cust.Validate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            billAmountTxt.Text = "0";
            billDateTxt.Text = "1/1/2023";
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cust = Factory.Create(comboBox1.Text);
        }
    }
}