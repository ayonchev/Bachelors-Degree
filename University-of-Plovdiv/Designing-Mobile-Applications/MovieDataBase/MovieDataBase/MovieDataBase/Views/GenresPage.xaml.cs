using MovieDataBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MovieDataBase.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GenresPage : ContentPage
    {
        public GenresPage()
        {
            InitializeComponent();
            BindingContext = GetGenres();
        }

        private List<Genre> GetGenres()
        {
            return new List<Genre>
            {
                new Genre 
                { 
                    Name = "Action",
                    Picture = ImageSource.FromResource("MovieDataBase.Assets.Images.action.jpg")
                },
                new Genre
                {
                    Name = "Adventure",
                    Picture = ImageSource.FromResource("MovieDataBase.Assets.Images.adventure.jpg")
                },
                new Genre
                {
                    Name = "Comedy",
                    Picture = ImageSource.FromResource("MovieDataBase.Assets.Images.comedy.jpeg")
                },
                new Genre
                {
                    Name = "Documentary",
                    Picture = ImageSource.FromResource("MovieDataBase.Assets.Images.documentary.jpg")
                },
                new Genre
                {
                    Name = "Horror",
                    Picture = ImageSource.FromResource("MovieDataBase.Assets.Images.horror.jpg")
                },
                new Genre
                {
                    Name = "Romance",
                    Picture = ImageSource.FromResource("MovieDataBase.Assets.Images.romance.jpg")
                },
                new Genre
                {
                    Name = "Mystery",
                    Picture = ImageSource.FromResource("MovieDataBase.Assets.Images.mystery.jpg")
                }
            };
        }
    }
}