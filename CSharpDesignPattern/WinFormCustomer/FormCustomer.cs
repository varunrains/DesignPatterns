using FactoryCustomer;
using FactoryDAL;
using InterfaceCustomer;
using InterfaceDAL;

namespace WinFormCustomer
{
    public partial class FormCustomer : Form
    {
        private CustomerBase cust;
        private IRepository<CustomerBase> dal;
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
            //dalType.SelectedIndex = 0;
            
            
            dal = FactoryDAL<IRepository<CustomerBase>>.Create(dalType.Items[0].ToString());
            LoadGrid();

        }

        private void LoadGrid()
        {
            var custs = dal.Search(); //fetch from physcial source
            dtgCustomer.DataSource = custs;
        }

        private void LoadGridInMemory()
        {
            dtgCustomer.DataSource = null;
            var custs = dal.GetData(); // in -memory fetch
            dtgCustomer.DataSource = custs;
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cust == null)
            {
                cust = FactoryCustomerLookup<CustomerBase>.Create(comboBox1.Text);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SetCustomer();
            //IRepository<CustomerBase> dal = FactoryDAL<IRepository<CustomerBase>>.Create(dalType.Text);
            dal.Add(cust);//In memory
            //dal.Save(); //Physical commit
            LoadGridInMemory();
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
            dal = FactoryDAL<IRepository<CustomerBase>>.Create(dalType.Text);
            LoadGrid();
        }

        private void uowBtn_Click(object sender, EventArgs e)
        {
            IUow uow = FactoryDAL<IUow>.Create("EfUow");
            try
            {
               
                CustomerBase cust1 = new CustomerBase();
                cust1.CustomerType = "Lead";
                cust1.CustomerName = "Cust1";

                //Unit of work
                //IRepository<CustomerBase> dal = FactoryDAL<IRepository<CustomerBase>>.Create(dalType.Text);
                dal.SetUnitOfWork(uow);
                dal.Add(cust1); //IN memory
                
               // dal.Save(); //No problem

                var cust2 = new CustomerBase();
                cust2.CustomerType = "Lead";
                cust2.CustomerName = "Cust2";
                cust2.Address = "DSFSDLKSDKSDF EXTRA LARGE THAN 50 ";
                IRepository<CustomerBase> dal1 = FactoryDAL<IRepository<CustomerBase>>.Create(dalType.Text);
                dal1.SetUnitOfWork(uow);
                dal1.Add(cust2); //IN memory
               
                //dal1.Save(); //No problem
                uow.Commit();
            }catch(Exception ex)
            {
                uow.RollBack();
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            dal.Save();
            ClearCustomer();
            LoadGrid();
        }

        //Dummy button for Iterator pattern example
        private void dummyBtn_Click(object sender, EventArgs e)
        {
            var custs = dal.GetData();
            //This add will not even check for validation and it is not same ADD as the other add method
            //That we have already defined.
            //custs.Add(new CustomerBase());
            //Even we can save this bad data
            dal.Save();
        }

        private void dtgCustomer_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            cust = dal.GetData(e.RowIndex);
            cust.Clone();
            LoadCustomerOnUI();
        }

        private void LoadCustomerOnUI()
        {
            custName.Text = cust.CustomerName;
            phnNumber.Text = cust.PhoneNumber;
            billDateTxt.Text = cust.BillDate.ToString();
            billAmountTxt.Text = cust.BillAmount.ToString();
            addressTextBox.Text = cust.Address;
            comboBox1.Text = cust.CustomerType.ToString();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            cust.Revert();
            ClearCustomer();
            LoadGridInMemory();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                cust.Validate();
                MessageBox.Show(cust.ActualCost().ToString());
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}