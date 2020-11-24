namespace EntityFramework.Entities
{
    public class ArticleTag : IEntity
    {
        public int Id { get; set; }
        public int ArticleId { get; set; }
        public int TagId { get; set; }
    }
}
