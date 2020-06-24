using MovieDataBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MovieDataBase.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MovieDetailsPage : ContentPage
    {
        public Movie Movie { get; set; }
        public MovieDetailsPage(Movie movie)
        {
            InitializeComponent();
            Movie = movie;
            Movie.Name = Movie.Name.ToUpper();
            coverImage.WidthRequest = App.Current.MainPage.Width;
                //DeviceDisplay.MainDisplayInfo.Width / DeviceDisplay.MainDisplayInfo.Density;
            coverImage.HeightRequest = App.Current.MainPage.Height;
                //DeviceDisplay.MainDisplayInfo.Height / DeviceDisplay.MainDisplayInfo.Density;
            BindingContext = Movie;
        }

        private async void SwipeGestureRecognizer_Swiped(object sender, SwipedEventArgs e)
        {
            await Navigation.PopAsync();
        }

        private async void EditButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MovieCreateEditPage(Movie));
        }
    }
}