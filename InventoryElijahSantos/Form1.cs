namespace InventoryElijahSantos
{
    public partial class frmAddProduct : Form
    {
        public frmAddProduct()
        {
            InitializeComponent();
            showProductList = new BindingSource();

        }
        private BindingSource showProductList;
        private string _ProductName, _Category, _MfgDate, _ExpDate, _Description;
        private int _Quantity;
        private double _SellPrice;
        string[] ListOfProductCategory = { "Beverages", "Bread/Bakery", "Canned/Jarred Goods", "Dairy", "Frozen Goods", "Meat", "Personal Care", "Other" };


        private void frmAddProduct_Load(object sender, EventArgs e)
        {
            foreach (string category in ListOfProductCategory)
            {
                cbCategory.Items.Add(category);

            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {




            try
            {
                _ProductName = Product_Name(txtProductName.Text);
                _Category = cbCategory.Text;
                _MfgDate = dtPickerMfgDate.Value.ToString("yyyy-MM-dd");
                _ExpDate = dtPickerExpDate.Value.ToString("yyyy-MM-dd");
                _Description = richTxtDescription.Text;
                _Quantity = Quantity(txtQuantity.Text);
                _SellPrice = SellingPrice(txtSellPrice.Text);

                showProductList.Add(new ProductClass(_ProductName, _Category, _MfgDate, _ExpDate, _SellPrice, _Quantity, _Description));
                gridViewProductList.DataSource = showProductList;
            }
            catch (NumberFormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (CurrencyFormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (StringFormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        class NumberFormatException : Exception
        {
            public NumberFormatException(string varName) : base(varName) { }
        }

        class CurrencyFormatException : Exception
        {
            public CurrencyFormatException(string varName) : base(varName) { }
        }

        class StringFormatException : Exception
        {
            public StringFormatException(string varName) : base(varName) { }
        }

        private int Quantity(string input)
        {
            if (!int.TryParse(input, out int result))
            {
                throw new NumberFormatException("Invalid format for quantity.");
            }
            return result;
        }

        private double SellingPrice(string input)
        {
            if (!double.TryParse(input, out double result))
            {
                throw new CurrencyFormatException("Invalid format for selling price.");
            }
            return result;
        }

        private string Product_Name(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                throw new StringFormatException("Product name cannot be empty.");
            }
            return input;
        }
    }
    }
    

