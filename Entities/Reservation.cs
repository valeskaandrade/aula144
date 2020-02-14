using System;
using System.Text;

namespace aula142TratExcecao.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime Checkin { get; set; }
        public DateTime Checkout { get; set; }

        public int Duration()
        {
            TimeSpan duration = Checkout.Subtract(Checkin);
            return (int)duration.TotalDays;
        }
        public Reservation(int roomNumber, DateTime checkin, DateTime checkout)
        {
            RoomNumber = roomNumber;
            Checkin = checkin;
            Checkout = checkout;
        }

        public void UpdateDates(DateTime newCheckin, DateTime newCheckout)
        {
            Checkin = newCheckin;
            Checkout = newCheckout;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Reservation: Room: ");
            sb.Append(RoomNumber);
            sb.Append(", check-in: ");
            sb.Append(Checkin.ToString("dd/MM/yyyy"));
            sb.Append(",check-out: ");
            sb.Append(Checkout.ToString("dd/MM/yyyy"));
            sb.Append(", ");
            sb.Append(Duration());
            sb.Append(" nights");
            return sb.ToString();
        }

    }
}
