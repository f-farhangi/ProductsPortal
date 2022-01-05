using System.Collections.Generic;

namespace Api.Entities
{
    public class Product : IEntity
    {
        #region Properties

        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public long CategoryId { get; set; }
        public Category Category { get; set; }

        public ICollection<ProductDetail> ProductDetails { get; set; }
        public ICollection<ProductPrice> ProductPrices { get; set; }

        #endregion
    }
}
