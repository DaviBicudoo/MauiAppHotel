using MauiAppHotel.Models;

namespace MauiAppHotel.Views;

public partial class HiringAccommodation : ContentPage
{
	App appProperties;
	public HiringAccommodation()
	{
		InitializeComponent();

		appProperties = (App)Application.Current;

		roomPicker.ItemsSource = appProperties.RoomList;

		checkinDatePicker.MinimumDate = DateTime.Now;
		checkinDatePicker.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);

		checkoutDatePicker.MinimumDate = checkinDatePicker.Date.AddDays(1);
		checkoutDatePicker.MaximumDate = checkinDatePicker.Date.AddMonths(1);
	}

    private async void NextButton_Clicked(object sender, EventArgs e)
    {
		try
		{
			Accommodation accommodation = new Accommodation
			{
				SelectedRoom = (Room)roomPicker.SelectedItem,
				NumberOfAdults = Convert.ToInt32(adultsStepper.Value),
				NumberOfChildren = Convert.ToInt32(childrenStepper.Value),
				CheckInDate = checkinDatePicker.Date,
				CheckOutDate = checkoutDatePicker.Date // Se não funcionar, coloque vírgula no fim desta linha!!!
			};


			await Navigation.PushAsync(new HiredAccommodation()
			{
				BindingContext = accommodation
			});
			

		} catch(Exception ex)
		{
			DisplayAlert("Ops!", ex.Message, "OK");
		}
    }

    private void checkinDatePicker_DateSelected(object sender, DateChangedEventArgs e)
    {
		DatePicker element = sender as DatePicker;

		DateTime selectedCheckinDate = element.Date;

		checkoutDatePicker.MinimumDate = selectedCheckinDate.AddDays(1);
		checkoutDatePicker.MaximumDate = selectedCheckinDate.AddMonths(2);
    }
}