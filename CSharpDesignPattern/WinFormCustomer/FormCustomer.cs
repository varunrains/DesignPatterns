using MiddleLayer;
using FactoryCustomer;
using InterfaceCustomer;
using InterfaceDAL;
using FactoryDAL;

namespace WinFormCustomer
{
    public partial class FormCustomer : Form
    {
        private CustomerBase cust;

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

            dalType.Items.Add("ADODal");
            dalType.Items.Add("EFDal");
            dalType.SelectedIndex = 0;
            LoadGrid();
        }

        private void LoadGrid()
        {
            IRepository<CustomerBase> dal = FactoryDAL<IRepository<CustomerBase>>.Create(dalType.Text);
            List<CustomerBase> custs = dal.Search();
            dtgCustomer.DataSource = custs;

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cust = Factory<CustomerBase>.Create(comboBox1.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SetCustomer();
            IRepository<CustomerBase> dal = FactoryDAL<IRepository<CustomerBase>>.Create(dalType.Text);
            dal.Add(cust);//In memory
            dal.Save(); //Physical commit
            LoadGrid();
            ClearCustomer();
        }

        private void ClearCustomer()
        {
            custName.Text = "";
            phnNumber.Text = "";
            billDateTxt.Text = DateTime.Now.Date.ToString();
            billAmountTxt.Text = "";
            addressTextBox.Text = "";
        }

        private void dalType_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void uowBtn_Click(object sender, EventArgs e)
        {

        }
    }
}