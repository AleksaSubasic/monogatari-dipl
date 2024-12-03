namespace Aleksa_Subasic_98_20_BookStore.Views;

public partial class RegisterPage_2 : ContentPage
{
	public RegisterPage_2()
	{
		InitializeComponent();
	}

    private void NextBtn_Clicked(object sender, EventArgs e)
    {
        // Slanje podataka - Ime, prezime, adresa, grad, broj tel
        Navigation.PushAsync(new RegisterPage_3());
    }
}