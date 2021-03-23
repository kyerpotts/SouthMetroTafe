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
    class Games : Product
    {
        private string publisher;
        private string mediaType;

        public Games(string productID, string description, int stockQty, decimal retailPrice, string publisher, string mediaType)
        {
            setProductID(productID);
            setDescription(description);
            setStockQty(stockQty);
            setRetailPrice(retailPrice);
            setPublisher(publisher);
            setMediaType(mediaType);
            
        }

        public void setPublisher(string publisher)
        {
            this.publisher = publisher;
        }

        public string getPublisher()
        {
            return publisher;
        }

        public void setMediaType(string mediaType)
        {
            this.mediaType = mediaType;
        }

        public string getMediaType()
        {
            return mediaType;
        }
    }
}
