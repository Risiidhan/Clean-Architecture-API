namespace MoivesStore.Domain.Models
{
    public class Movies
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public int ReleasedYear { get; set; }
        public bool IsMyFavourite { get; set; }
    }
}