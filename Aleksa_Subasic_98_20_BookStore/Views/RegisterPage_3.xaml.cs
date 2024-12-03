namespace Aleksa_Subasic_98_20_BookStore.Views;

public partial class RegisterPage_3 : ContentPage
{
	public RegisterPage_3()
	{
		InitializeComponent();
	}

    private void FinishBtn_Clicked(object sender, EventArgs e)
    {
        // dohvatanje svih podataka koji su prosledjeni
        // slanje podataka u bazu

        // ako je slanje dobro prikazati stranicu SuccReg
        Navigation.PushAsync(new SuccReg());
    }
}