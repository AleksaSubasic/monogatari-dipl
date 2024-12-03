namespace Aleksa_Subasic_98_20_BookStore.Views;

public partial class SuccReg : ContentPage
{
	public SuccReg()
	{
		InitializeComponent();
	}

    private void BackToLoginBtn_Clicked(object sender, EventArgs e)
    {
		Navigation.PopToRootAsync();
    }
}