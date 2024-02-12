using ClassLibrary.Exceptions;
using ClassLibrary.Interfaces;

namespace ClassLibrary
{
    public class Shop
    {
        private IShopDiscounter discounter;

        private ILogger logger;

        private IDb dataBase;

        public Shop(IShopDiscounter discounter, ILogger logger, IItem item, IDb dataBase)
        {
            if (discounter == null)
            {
                throw new ArgumentNullException();
            }
            else
            {
                this.discounter = discounter;
            }

            if (logger == null)
            {
                throw new ArgumentNullException();
            }
            else
            {
                this.logger = logger;
            }

            if (dataBase == null)
            {
                throw new ArgumentNullException();
            }
            else
            {
                this.dataBase = dataBase;
            }            
        }

        public IItem BuyItem(string itemName)
        {
            var item = dataBase.GetItem(itemName);

            if (item == null)
            {
                string errorMessage = $"Item with name {itemName} is missed";
                logger.Warn(errorMessage);
                throw new ShopItemMissedException();
            }

            return item;
        }

        public IItem BuyItemWithDiscount(string itemName, int discountPercent)
        {
            IItem item = BuyItem(itemName);

            return discounter.AddDiscountToItem(item, discountPercent);
        }
    }
}
