using MovieDataBase.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;

namespace MovieDataBase.Views
{
    [DesignTimeVisible(false)]
    public partial class MovieListPage : ContentPage
    {
        public List<Movie> Movies { get; set; }
        public MovieListPage()
        {
            InitializeComponent();
            Movies = GetMovies();
            BindingContext = Movies;
        }

        private List<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie
                {
                    Name = "The mask of Zorro",
                    Duration = 120,
                    ReleaseDate = new DateTime(1999, 1, 1),
                    DirectorName = "Martin Campbell",
                    Description = "In 1821 Old California--after humiliating once more the evil Spanish governor, Don Rafael Montero--the mysterious black-caped masked avenger of the oppressed, Don Diego de la Vega, or Zorro, finds himself incarcerated. With his only daughter raised by Don Rafael as his own.",
                    Picture = ImageSource.FromResource("MovieDataBase.Assets.Images.mask_of_zorro.jpg"),
                    Genres = "Comedy, Romance, Action, Adventure"
                },
                new Movie
                {
                    Name = "Fast & Furios 5",
                    Duration = 200,
                    ReleaseDate = new DateTime(2011, 3, 3),
                    DirectorName = "William Blue",
                    Description = "Former cop Brian O'Conner partners with ex-con Dom Toretto on the opposite side of the law. Since Brian and Mia Toretto broke Dom out of custody, they've blown across many borders to elude authorities.",
                    Picture = ImageSource.FromResource("MovieDataBase.Assets.Images.fast_and_furios.png"),
                    Genres = "Romance, Action, Fantasy, Comedy"
                },
                new Movie
                {
                    Name = "Interstellar",
                    Duration = 140,
                    ReleaseDate = new DateTime(2012, 2, 2),
                    DirectorName = "Martin Campbell",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Quidem praesentium ipsa iure natus sequi reiciendis aliquid aperiam doloribus ratione fuga officiis, ad eius tempora velit illo, adipisci, eligendi sunt. Sint.",
                    Picture = ImageSource.FromResource("MovieDataBase.Assets.Images.interstellar.jpg"),
                    Genres = "Sci-Fi, Action, Fantasy"
                },
                new Movie
                {
                    Name = "Mr. Robot",
                    Duration = 180,
                    ReleaseDate = new DateTime(2014, 1, 1),
                    DirectorName = "Martin Campbell",
                    Description = "Lorem ipsum dolor sit, amet consectetur adipisicing elit. Rem dignissimos eligendi labore eum omnis. Aliquam, eos? Porro, quam. Tenetur aut voluptate accusantium numquam animi cum, et neque aperiam quas blanditiis itaque nemo optio deleniti illo.",
                    Picture = ImageSource.FromResource("MovieDataBase.Assets.Images.mr_robot.jpg"),
                    Genres = "Action, Mystery"
                }
            };
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            var movie = e.SelectedItem as Movie;
            await Navigation.PushAsync(new MovieDetailsPage(movie));
            movieList.SelectedItem = null;
        }

        private async void SwipeGestureRecognizer_Swiped(object sender, SwipedEventArgs e)
        {
            await DisplayAlert("Swipe detected!", "You swiped left", "Ok");
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MovieCreateEditPage(new Movie()));
        }
    }
}
