using MiddleLayer;
using FactoryCustomer;

namespace WinFormCustomer
{
    public partial class FormCustomer : Form
    {
        private CustomerBase cust;

        public FormCustomer()
        {
            InitializeComponent();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SetCustomer()
        {
            cust.CustomerName = custName.Text;
            cust.PhoneNumber = phnNumber.Text;
            cust.BillAmount = Convert.ToDecimal(billAmountTxt.Text);
            cust.BillDate = Convert.ToDateTime(billDateTxt.Text);
            cust.Address   = addressTextBox.Text;
        }
       
       
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                SetCustomer();
                cust.Validate();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cust = Factory.Create(comboBox1.Text);
        }
    }
}