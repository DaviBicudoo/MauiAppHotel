namespace MauiAppHotel.Models
{
    public class Accommodation
    {
        public Room SelectedRoom { get; set; }

        public int NumberOfAdults { get; set; }
        public int NumberOfChildren { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }

        public int TimeOfStay
        {
            get => CheckOutDate.Subtract(CheckInDate).Days;
        }

        public double TotalValue
        {
            get
            {
                double adultsValue = NumberOfAdults * SelectedRoom.AdultDiaryValue;
                double childrenValue = NumberOfChildren * SelectedRoom.ChildrenDiaryValue;

                double total = (adultsValue + childrenValue) * TimeOfStay;

                return total;
            }
        }
    }
}
