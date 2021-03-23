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
    class Platforms : Product
    {
        private string modelNumber;

        public Platforms (string productID, string description, int stockQty, decimal retailPrice, string modelNumber)
        {
            setProductID(productID);
            setDescription(description);
            setStockQty(stockQty);
            setRetailPrice(retailPrice);
            setModelNumber(modelNumber);
        }

        public void setModelNumber(string modelNumber)
        {
            this.modelNumber = modelNumber;
        }

        public string getModelNumber()
        {
            return modelNumber;
        }
    }
}
