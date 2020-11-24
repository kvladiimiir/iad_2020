namespace EntityFramework.Entities
{
    public class FavouriteArticles : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ArticleId { get; set; }
    }
}
