namespace Api.Entities
{
    public class ProductDetail : IEntity
    {
        #region Property

        public long Id { get; set; }

        public long ProductId { get; set; }
        public Product Product { get; set; }

        #endregion
    }
}
