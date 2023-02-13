using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PySharpShopApplication.Models
{
    public class Product
    {
        public virtual long? Id { get; protected internal set; }
        public virtual string Name { get; protected internal set; }
        public virtual string Description { get; protected internal set; }
        public virtual ProductStatus Status { get; protected internal set; }
        public virtual int Quantity { get; protected internal set; }
        public virtual string FileId { get; protected internal set; }
        public virtual long? CategoryId { get; protected internal set; }
        public virtual long? PriceId { get; protected internal set; }
        public virtual Category Category { get; protected internal set; }
        public virtual Price Price { get; protected internal set; }

        public void ChangePrice(Price price)
        {
            if (Name is null)
            {
                throw new ArgumentNullException("The product does not exist");
            }
            Price = price;
        }

        public void ChangeProductStatus(ProductStatus productStatus)
        {
            if (Name is null)
            {
                throw new ArgumentNullException("The product does not exist");
            }
            if (Status == productStatus)
            {
                throw new Exception("You are trying to change to the current status");
            }
            Status = productStatus;
        }

        public void ChangeProductName(string name)
        {
            if (Name is null)
            {
                throw new ArgumentNullException("This product does not exist");
            }
            Name = name;
        }
    }
}
