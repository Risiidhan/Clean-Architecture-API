namespace MoivesStore.Contract.DTOs.Movie
{
    public class MovieCreateDto
    {
        public required string Name { get; set; }
        public int ReleasedYear { get; set; }
        public bool IsMyFavourite { get; set; }
    }
}