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
    public partial class MovieCreateEditPage : ContentPage
    {
        public MovieCreateEditPage(Movie movie)
        {
            InitializeComponent();
            BindingContext = movie;
        }

        private async void SwipeGestureRecognizer_Swiped(object sender, SwipedEventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}