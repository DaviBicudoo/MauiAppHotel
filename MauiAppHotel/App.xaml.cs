using MauiAppHotel.Models;

namespace MauiAppHotel
{
    public partial class App : Application
    {
        public List<Room> RoomList = new List<Room>
        {
            new Room()
            {
                Description = "Super Deluxe suit",
                AdultDiaryValue = 1000.0,
                ChildrenDiaryValue = 800.0
            },

            new Room()
            {
                Description = "Deluxe suit",
                AdultDiaryValue = 700.0,
                ChildrenDiaryValue = 500.0
            },

            new Room()
            {
                Description = "Big suit",
                AdultDiaryValue = 500.0,
                ChildrenDiaryValue = 300.0
            },

            new Room()
            {
                Description = "Normal suit",
                AdultDiaryValue = 400.0,
                ChildrenDiaryValue = 200.0
            },

            new Room()
            {
                Description = "Cheap suit",
                AdultDiaryValue = 300.0,
                ChildrenDiaryValue = 150
            },

            new Room()
            {
                Description = "Single suit",
                AdultDiaryValue = 100.0,
                ChildrenDiaryValue = 0
            }
        };

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.HiringAccommodation());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 600;

            return window;
        }
    }
}
