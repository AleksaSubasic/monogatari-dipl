namespace Aleksa_Subasic_98_20_BookStore.Views;
using Aleksa_Subasic_98_20_BookStore;
using CommunityToolkit.Maui.Alerts;

public partial class ExplorePage : ContentPage
{
    private List<string> _placeholders = new List<string>
        {
            "Search book", "Search author", "Search genre"
        };
    private int _placeholderIndex = 0;

    public ExplorePage()
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

    private async void GoTo_All_Categories_Tapped(object sender, TappedEventArgs e)
    {
        var page = new CategoriesSheet();
        page.HasHandle = true;
        await page.ShowAsync(Window);
    }

    private void ImageButton_Clicked(object sender, EventArgs e)
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
                    BackgroundColor = Colors.White,
                    TextColor = Colors.Black,
                    CornerRadius = 10
                }).Show();
        }
        else
        {
            img.Source = "fav.svg";
            Snackbar.Make("Removed from favourites.", () => DisplayAlert("", "", ""), "",
                TimeSpan.FromSeconds(2), new CommunityToolkit.Maui.Core.SnackbarOptions
                {
                    BackgroundColor = Colors.White,
                    TextColor = Colors.Black,
                    CornerRadius = 10
                }).Show();
        }
    }
}