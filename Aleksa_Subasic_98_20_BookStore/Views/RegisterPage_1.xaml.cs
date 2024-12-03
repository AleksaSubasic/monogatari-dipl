namespace Aleksa_Subasic_98_20_BookStore.Views;

public partial class RegisterPage_1 : ContentPage
{
	public RegisterPage_1()
	{
		InitializeComponent();
	}

    private void NextBtn_Clicked(object sender, EventArgs e)
    {
        // Slanje podataka - Ime, prezime
        Navigation.PushAsync(new RegisterPage_2());
    }
}