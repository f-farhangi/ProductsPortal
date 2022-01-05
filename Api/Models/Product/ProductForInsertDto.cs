namespace Api.Models
{
    public class ProductForInsertDto
    {
        #region Properties

        public long CategoryId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }

        #endregion
    }
}
