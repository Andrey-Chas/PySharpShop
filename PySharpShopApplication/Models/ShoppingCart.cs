using System.Collections.Generic;

namespace PySharpShopApplication.Models
{
    public class ShoppingCart : IDatabaseModel
    {
        public virtual long? Id { get; protected internal set; }
        public virtual decimal TotalPrice { get; protected internal set; }
        public virtual string Currency { get; protected internal set; }
        public virtual ShoppingCartStatus Status { get; protected internal set; }
        public virtual ShoppingCartItem ShoppingCartItem { get; protected internal set; }
        public virtual IList<ShoppingCartItem> Items { get; protected internal set; }
    }
}
