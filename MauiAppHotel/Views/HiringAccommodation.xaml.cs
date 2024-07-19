namespace MauiAppHotel.Views;

public partial class HiringAccommodation : ContentPage
{
	App appProperties;
	public HiringAccommodation()
	{
		InitializeComponent();

		appProperties = (App)Application.Current;

		roomPicker.ItemsSource = appProperties.RoomList;
	}

    private void NextButton_Clicked(object sender, EventArgs e)
    {
		try
		{
			Navigation.PushAsync(new HiredAccommodation());

		} catch(Exception ex)
		{
			DisplayAlert("Ops!", ex.Message, "OK");
		}
    }
}