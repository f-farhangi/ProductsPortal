using System.Collections.Generic;

namespace Api.Entities
{
    public class Category : IEntity
    {
        #region Property

        public long Id { get; set; }
        public string Title { get; set; }

        public ICollection<Product> Products { get; set; }

        #endregion
    }
}
