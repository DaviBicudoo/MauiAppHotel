namespace MauiAppHotel.Views;

public partial class HiredAccommodation : ContentPage
{
	public HiredAccommodation()
	{
		InitializeComponent();
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		try
		{
			Navigation.PopAsync();
		}
		catch (Exception ex)
		{
			DisplayAlert("OPS!", ex.Message, "OK");
		}
	}

}