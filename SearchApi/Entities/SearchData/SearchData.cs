namespace SearchApi.Entities
{
    public class SearchData : IEntity
    {
        #region Properties

        public long Id { get; set; }
        public long ProductId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        #endregion
    }
}
