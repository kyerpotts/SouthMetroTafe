using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Kyer Potts
//30003389
namespace GamesStore
{
    [Serializable]
    class Transaction
    {
        private string custID;
        private string productID;
        private int quantity;
        private decimal retailPrice;
        private string date;

        public Transaction(string custID, string productID, int quantity, decimal retailPrice, string date)
        {
            setCustID(custID);
            setProductID(productID);
            setQuantity(quantity);
            setRetailPrice(retailPrice);
            setDate(date);            
        }

        public void setCustID(string custID)
        {
            this.custID = custID;
        }

        public string getCustID()
        {
            return custID;
        }

        public void setProductID(string productID)
        {
            this.productID = productID;
        }

        public string getProductID()
        {
            return productID;
        }

        public void setQuantity(int quantity)
        {
            this.quantity = quantity;
        }

        public int getQuantity()
        {
            return quantity;
        }

        public void setRetailPrice(decimal retailPrice)
        {
            this.retailPrice = retailPrice;
        }

        public decimal getRetailPrice()
        {
            return retailPrice;
        }

        public void setDate(string date)
        {
            this.date = date;
        }

        public string getDate()
        {
            return date;
        }
    }
}
