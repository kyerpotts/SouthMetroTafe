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
    class Product
    {
        protected string productID;
        protected string description;
        protected int stockQty;
        protected decimal retailPrice;

        public void setProductID(string productID)
        {
            this.productID = productID;
        }

        public string getproductID()
        {
            return productID;
        }

        public void setDescription(string description)
        {
            this.description = description;
        }

        public string getDescription()
        {
            return description;
        }

        public void setStockQty(int stockQty)
        {
            this.stockQty = stockQty;
        }

        public int getStockQty()
        {
            return stockQty;
        }
        
        public void setRetailPrice(decimal retailPrice)
        {
            this.retailPrice = retailPrice;
        }

        public decimal getRetailPrice()
        {
            return retailPrice;
        }
    }
}
