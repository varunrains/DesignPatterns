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
            IDal<CustomerBase> dal = FactoryDAL<IDal<CustomerBase>>.Create(dalType.Text);
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
            IDal<CustomerBase> dal = FactoryDAL<IDal<CustomerBase>>.Create("ADODal");
            dal.Add(cust);//In memory
            dal.Save(); //Physical commit
        }

        private void dalType_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadGrid();
        }
    }
}