using System.Collections.Generic;

namespace Api.Entities
{
    public class Product : IEntity
    {
        #region Property

        public long Id { get; set; }
        public string Title { get; set; }

        public long CategoryId { get; set; }
        public Category Category { get; set; }

        public ICollection<ProductDetail> ProductDetails { get; set; }

        #endregion
    }
}
