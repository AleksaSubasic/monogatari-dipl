namespace Aleksa_Subasic_98_20_BookStore.Views;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    private void RegBtn_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new RegisterPage_1());
    }
}