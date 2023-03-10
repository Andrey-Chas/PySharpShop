namespace PySharpShopApplication.Models
{
    public class Price : IDatabaseModel
    {
        public virtual long? Id { get; protected internal set; }
        public virtual decimal Amount { get; protected internal set; }
        public virtual string Currency { get; protected internal set; }
        public virtual Product Product { get; protected internal set; }
        public virtual ShoppingCartItem ShoppingCartItem { get; protected internal set; }
    }
}
