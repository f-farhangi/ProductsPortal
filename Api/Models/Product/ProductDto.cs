using System;

namespace Api.Models
{
    public class ProductDto
    {
        #region Properties

        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string CategoryTitle { get; set; }
        public decimal Amount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        #endregion
    }
}