using Aleksa_Subasic_98_20_BookStore.Views;
using CommunityToolkit.Maui.Alerts;

namespace Aleksa_Subasic_98_20_BookStore
{
    public partial class MainPage : ContentPage
    {
        private List<string> _placeholders = new List<string>
        {
            "Search book", "Search author", "Search genre"
        };
        private int _placeholderIndex = 0;

        public MainPage()
        {
            InitializeComponent();
            // Start a timer that updates the placeholder every 2 seconds
            Application.Current.Dispatcher.StartTimer(TimeSpan.FromSeconds(2), () =>
            {
                ChangePlaceholder();
                return true; // Return true to keep the timer running
            });

        }

        private void ChangePlaceholder()
        {
            searchEntry.Placeholder = _placeholders[_placeholderIndex];
            _placeholderIndex = (_placeholderIndex + 1) % _placeholders.Count;
        }

        private async void GoTo_ProductsPage_TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }

        private void AddToFavorites_Clicked(object sender, EventArgs e)
        {
            // change url to green svg, add to fav > db
            var img = (ImageButton)sender;
            //img.Source = img.Source.ToString().Contains("fav.svg") ? "fav_marked.svg" : "fav.svg";

            if (img.Source.ToString().Contains("fav.svg"))
            {
                img.Source = "fav_marked.svg";
                //Toast.Make("Added to favourites.", CommunityToolkit.Maui.Core.ToastDuration.Short, 14).Show();

                Snackbar.Make("Added to favourites.", () => DisplayAlert("", "", ""), "",
                    TimeSpan.FromSeconds(2), new CommunityToolkit.Maui.Core.SnackbarOptions
                    {
                        TextColor = Colors.White,
                        CornerRadius = 50
                    }).Show();
            }
            else
            {
                img.Source = "fav.svg";
                Snackbar.Make("Removed from favourites.", () => DisplayAlert("", "", ""), "",
                    TimeSpan.FromSeconds(2), new CommunityToolkit.Maui.Core.SnackbarOptions
                    {
                        TextColor = Colors.White,
                        CornerRadius = 10
                    }).Show();
            }
        }

        private void BookImage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BookDetailPage());
        }
    }

}