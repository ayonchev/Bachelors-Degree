using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MovieDataBase.Models
{
    public class Movie
    {
        public string Name { get; set; }

        public DateTime ReleaseDate { get; set; }

        public string Description { get; set; }

        //public ICollection<MovieGenre> MovieGenres { get; set; }

        public int Duration { get; set; }

        public ImageSource Picture { get; set; }

        public string TrailerURL { get; set; }

        public string DirectorName { get; set; }
        public string Genres { get; set; }
    }
}
