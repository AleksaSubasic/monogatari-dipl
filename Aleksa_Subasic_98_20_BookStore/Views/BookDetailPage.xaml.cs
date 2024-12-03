using CommunityToolkit.Maui.Alerts;

namespace Aleksa_Subasic_98_20_BookStore.Views;

public partial class BookDetailPage : ContentPage
{
    public BookDetailPage()
    {
        InitializeComponent();
    }

    private void BckBtn_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
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
                    BackgroundColor = Colors.White,
                    TextColor = Colors.White,
                    CornerRadius = 10
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