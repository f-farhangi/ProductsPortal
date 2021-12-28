using System;

namespace Api.Entities
{
    public class ProductPrice : IEntity
    {
        #region Property

        public long Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public long ProductId { get; set; }
        public Product Product { get; set; }

        #endregion

    }
}
