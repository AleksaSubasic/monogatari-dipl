namespace Aleksa_Subasic_98_20_BookStore;

public partial class MyStepper : ContentView
{
	public MyStepper()
	{
		InitializeComponent();
	}

	private int _quantity = 1;

	private void OnIncrementClicked(object sender, EventArgs e)
	{
		_quantity++;
		QuantityLabel.Text = _quantity.ToString();
	}

	private void OnDecrementClicked(object sender, EventArgs e)
	{
		if (_quantity > 1)
		{
			_quantity--;
			QuantityLabel.Text = _quantity.ToString();
		}
	}
}