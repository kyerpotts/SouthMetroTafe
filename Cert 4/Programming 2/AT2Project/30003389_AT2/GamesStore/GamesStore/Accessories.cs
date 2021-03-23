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
    class Accessories : Product
    {
        private string platformType;

        public Accessories(string productID, string description, int stockQty, decimal retailPrice, string platformType)
        {
            setProductID(productID);
            setDescription(description);
            setStockQty(stockQty);
            setRetailPrice(retailPrice);
            setPlatformType(platformType);
        }

        public void setPlatformType(string platformType)
        {
            this.platformType = platformType;
        }

        public string getPlatformType()
        {
            return platformType;
        }
    }
}
