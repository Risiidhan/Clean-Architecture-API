using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoivesStore.Contract.DTOs.Movie
{
    public class MovieDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int ReleasedYear { get; set; }
        public bool IsMyFavourite { get; set; }
    }
}