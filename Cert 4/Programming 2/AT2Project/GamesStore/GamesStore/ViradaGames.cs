using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
//Kyer Potts
//30003389
namespace GamesStore
{
    public partial class ViradaGames : Form
    {
        public ViradaGames()
        {
            InitializeComponent();
        }

        List<Product> productList = new List<Product>();
        List<Customer> customersList = new List<Customer>();
        List<Transaction> transactionList = new List<Transaction>();
        
        //Opens all serialised files containing data on form load
        private void Form1_Load(object sender, EventArgs e)
        {   
            if (File.Exists("product.dat") && File.Exists("customers.dat") && File.Exists("transactions.dat"))
            {
                productList = OpenData<Product>("product.dat");
                customersList = OpenData<Customer>("customers.dat");
                transactionList = OpenData<Transaction>("transactions.dat");

                //displays all data loaded from serialised files on form load
                DisplayProducts();
                DisplayCustomers();
                DisplayTransactions();
            }
        }
        

        //Method to clear Product textbox controls
        public void ClearProdTbs()
        {
            tbIIProductID.Clear();
            tbIIDescription.Clear();
            tbIIStockQuantity.Clear();
            tbIIRetailPrice.Clear();
            tbGPublisher.Clear();
            tbGMediaType.Clear();
            tbPModelNumber.Clear();
            tbAPlatformType.Clear();
        }

        //Method to clear Customer textbox controls
        public void ClearCustTbs()
        {
            tbCICustID.Clear();
            tbCIFamilyName.Clear();
            tbCIFirstName.Clear();
            tbCIEmail.Clear();
        }

        //Method to clear Transactions textbox controls
        public void ClearTransTbs()
        {
            tbTICustID.Clear();
            tbTIProductID.Clear();
            tbTIQuantity.Clear();
            tbTIRetailPrice.Clear();
            tbTIDate.Clear();
        }

        //Method used to display products in listbox
        public void DisplayProducts()
        {
            if (productList != null)
            {
                lstProducts.Items.Clear();
                for (int i = 0; i < productList.Count; i++)
                {
                    lstProducts.Items.Add(productList[i].getproductID() + " " + productList[i].getDescription());
                }
            }
            else
            {
                return;
            }
        }

        //method used to display customers in listbox
        public void DisplayCustomers()
        {
            if (customersList != null)
            {
                lstCustomers.Items.Clear();
                for (int i = 0; i < customersList.Count; i++)
                {
                    lstCustomers.Items.Add(customersList[i].getCustID() + " " + customersList[i].getSurname() + " " + customersList[i].getFirstName());
                }
            }
            else
            {
                return;
            }
        }

        //Method used to display transactions in listbox
        public void DisplayTransactions()
        {
            if (transactionList != null)
            {
                lstTransactions.Items.Clear();
                for (int i = 0; i < transactionList.Count; i++)
                {
                    lstTransactions.Items.Add(transactionList[i].getCustID() + " " + transactionList[i].getProductID() + " x" + transactionList[i].getQuantity() + " " + transactionList[i].getDate());
                }
            }
            else
            {
                return;
            }
        }

        //Serialisation save method
        public void SaveData<T>(string filename, List<T> dataList)
        {
            try
            {
                if (dataList != null)
                {
                    using (Stream fileStream = File.Open(filename, FileMode.Create))
                    {
                        BinaryFormatter serializer = new BinaryFormatter();
                        serializer.Serialize(fileStream, dataList);
                        fileStream.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex, "Exception Throw", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Deserialisation open method
        public List<T> OpenData<T>(string filename)
        {
            try
            {
                if (new FileInfo(filename).Length != 0)
                {
                    using (Stream fileStream = File.OpenRead(filename))
                    {
                        BinaryFormatter deserializer = new BinaryFormatter();
                        List<T> dataList = (List<T>)deserializer.Deserialize(fileStream);
                        fileStream.Close();
                        if (dataList != null)
                        {
                            return dataList;
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex, "Exception Throw", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void btnProductsAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //Checks Item Info textbox controls and Games textbox controls are populated
                //Ensures no other Products textbox controls are populated
                //Adds data to productList
                if (tbIIProductID.Text != "" && tbIIDescription.Text != "" && tbIIStockQuantity.Text != "" && tbIIRetailPrice.Text != "" && tbGPublisher.Text != "" && tbGMediaType.Text != "" && tbPModelNumber.Text == "" && tbAPlatformType.Text == "")
                {
                    Games game = new Games(tbIIProductID.Text, tbIIDescription.Text, int.Parse(tbIIStockQuantity.Text), decimal.Parse(tbIIRetailPrice.Text), tbGPublisher.Text, tbGMediaType.Text);
                    productList.Add(game);
                }
                //Checks Item Info textbox controls and Platforms textbox controls are populated
                //Ensure no other Products textbox controls are populated
                //Adds data to productList
                else if (tbIIProductID.Text != "" && tbIIDescription.Text != "" && tbIIStockQuantity.Text != "" && tbIIRetailPrice.Text != "" && tbGPublisher.Text == "" && tbGMediaType.Text == "" && tbPModelNumber.Text != "" && tbAPlatformType.Text == "")
                {
                    Platforms platform = new Platforms(tbIIProductID.Text, tbIIDescription.Text, int.Parse(tbIIStockQuantity.Text), decimal.Parse(tbIIRetailPrice.Text), tbPModelNumber.Text);
                    productList.Add(platform);
                }

                //Checks Item Info textbox controls and Accessories textbox controls are populated
                //Ensures no other Products textbox controls are populated
                //Adds data to productList
                else if (tbIIProductID.Text != "" && tbIIDescription.Text != "" && tbIIStockQuantity.Text != "" && tbIIRetailPrice.Text != "" && tbGPublisher.Text == "" && tbGMediaType.Text == "" && tbPModelNumber.Text == "" && tbAPlatformType.Text != "")
                {
                    Accessories accessory = new Accessories(tbIIProductID.Text, tbIIDescription.Text, int.Parse(tbIIStockQuantity.Text), decimal.Parse(tbIIRetailPrice.Text), tbAPlatformType.Text);
                    productList.Add(accessory);
                }
                //If Products textbox controls are populated incorrectly, displays error message, returns from code
                else
                {
                    MessageBox.Show("Data entered incorrectly, please ensure all required fields are entered correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                //Displays updated productList data into Products List box
                DisplayProducts();
                //Clears all Products textbox controls of data
                ClearProdTbs();
            }
            catch (Exception x)
            {
                MessageBox.Show("Exception: " + x.Message);
            }

        }

        private void btnCustomersAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //Checks Customer Info textbox controls to ensure all are populated
                //Adds data to customerList
                if(tbCICustID.Text != "" && tbCIFamilyName.Text != "" && tbCIFirstName.Text != "" && tbCIEmail.Text != "")
                {
                    Customer cust = new Customer(tbCICustID.Text, tbCIFamilyName.Text, tbCIFirstName.Text, tbCIEmail.Text);
                    customersList.Add(cust);
                }
                //If Customers textbox controls are not populated, generate message box asking if they would like to create a generic customer
                else
                {
                    DialogResult dialog = MessageBox.Show("Data Incomplete, would you like to create a default customer", "Alert", MessageBoxButtons.YesNo);
                    if (dialog == DialogResult.Yes)
                    {
                        Customer cust = new Customer("C000", "unknown", "unknown", "unknown");
                        customersList.Add(cust);
                    }
                }
                //Displays updated customerList data into Customers List box
                DisplayCustomers();
                //Clears all Customers textbox controls of data
                ClearCustTbs();
            }
            catch(Exception x)
            {
                MessageBox.Show("Exception: " + x.Message);
            }
        }

        private void btnTransactionsAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //Checks Transaction Info textbox controls to ensure all are populated
                //Adds data to transactionList 
                if (tbTICustID.Text != "" && tbTIProductID.Text != "" && tbTIQuantity.Text != "" && tbTIRetailPrice.Text != "" && tbTIDate.Text != "")
                {
                    Transaction trans = new Transaction(tbTICustID.Text, tbTIProductID.Text, int.Parse(tbTIQuantity.Text), decimal.Parse(tbTIRetailPrice.Text), tbTIDate.Text);
                    transactionList.Add(trans);
                }
                //If Transactions textbox controls are populated incorrectly, displays error message, returns from code
                else
                {
                    MessageBox.Show("Data entered incorrectly, please ensure all required fields are entered correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                //Displays updated transactionList data into Transactions List box
                DisplayTransactions();
                //Clears all Transactions textbox controls of data
                ClearTransTbs();
            }
            catch(Exception x)
            {
                MessageBox.Show("Exception: " + x.Message);
            }
        }

        private void lstProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstProducts.SelectedIndex == -1)//if nothing is selected, return
            {
                return;
            }
            //Populates textbox controls with relevant data pulled from productList
            tbTIProductID.Text = productList[lstProducts.SelectedIndex].getproductID();
            tbTIRetailPrice.Text = productList[lstProducts.SelectedIndex].getRetailPrice().ToString();
        }

        private void lstCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCustomers.SelectedIndex == -1)
            {
                return;
            }
            //Populates textbox controls with relevant data pulled from customersList
            tbTICustID.Text = customersList[lstCustomers.SelectedIndex].getCustID();
        }

        private void lstTransactions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTransactions.SelectedIndex == -1)
            {
                return;
            }
            //Populates Transactions textbox controls from data retrieved from transactionList
            tbTICustID.Text = transactionList[lstTransactions.SelectedIndex].getCustID();
            tbTIProductID.Text = transactionList[lstTransactions.SelectedIndex].getProductID();
            tbTIQuantity.Text = transactionList[lstTransactions.SelectedIndex].getQuantity().ToString();
            tbTIRetailPrice.Text = transactionList[lstTransactions.SelectedIndex].getRetailPrice().ToString();
            tbTIDate.Text = transactionList[lstTransactions.SelectedIndex].getDate();

            //Finds relevant product from selection in Transactions List box
            foreach (Product p in productList)
            {
                if(tbTIProductID.Text.CompareTo(p.getproductID()) == 0)
                {
                    //Determines if product is Games type, if true populate appropriate textbox controls
                    if (p is Games)
                    {
                        int productIndex = productList.IndexOf(p);
                        lstProducts.SelectedIndex = productIndex;

                        Games g = (Games)p;
                        tbIIProductID.Text = g.getproductID();
                        tbIIDescription.Text = g.getDescription();
                        tbIIStockQuantity.Text = g.getStockQty().ToString();
                        tbIIRetailPrice.Text = g.getRetailPrice().ToString();
                        tbGPublisher.Text = g.getPublisher();
                        tbGMediaType.Text = g.getMediaType();
                        break;
                    }
                    //Determines if product is Platforms type, if true populate appropriate textbox controls
                    else if (p is Platforms)
                    {
                        int productIndex = productList.IndexOf(p);
                        lstProducts.SelectedIndex = productIndex;

                        Platforms pl = (Platforms)p;
                        tbIIProductID.Text = pl.getproductID();
                        tbIIDescription.Text = pl.getDescription();
                        tbIIStockQuantity.Text = pl.getStockQty().ToString();
                        tbIIRetailPrice.Text = pl.getRetailPrice().ToString();
                        tbPModelNumber.Text = pl.getModelNumber();
                        break;
                    }
                    //Determines if product is Accessories type, if true populate appropriate textbox controls
                    else if (p is Accessories)
                    {
                        int productIndex = productList.IndexOf(p);
                        lstProducts.SelectedIndex = productIndex;

                        Accessories a = (Accessories)p;
                        tbIIProductID.Text = a.getproductID();
                        tbIIDescription.Text = a.getDescription();
                        tbIIStockQuantity.Text = a.getStockQty().ToString();
                        tbIIRetailPrice.Text = a.getRetailPrice().ToString();
                        tbAPlatformType.Text = a.getPlatformType();
                        break;
                    }
                }
            }
            //Finds relevant customer from selection in Transactions List box
            foreach (Customer c in customersList)
            {
                if (tbTICustID.Text.CompareTo(c.getCustID()) == 0)
                {
                    int customerIndex = customersList.IndexOf(c);
                    lstCustomers.SelectedIndex = customerIndex;

                    tbCICustID.Text = c.getCustID();
                    tbCIFamilyName.Text = c.getSurname();
                    tbCIFirstName.Text = c.getFirstName();
                    tbCIEmail.Text = c.getEmail();
                    break;
                }
            }
        }

        private void ViradaGames_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Saves all serialised data on form close
            SaveData<Product>("product.dat", productList);
            SaveData<Customer>("customers.dat", customersList);
            SaveData<Transaction>("transactions.dat", transactionList);
        }

        //Clears all products textbox controls on double click
        private void tbIIProductID_DoubleClick(object sender, EventArgs e)
        {
            ClearProdTbs();
        }
        //Clear all customers textbox controls on double click
        private void tbCICustID_DoubleClick(object sender, EventArgs e)
        {
            ClearCustTbs();
        }
    }
}
