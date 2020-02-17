using System;
using System.Text;
using aula144TratExcecaoParte3.Entities.Exceptions;

namespace aula144TratExcecaoParte3.Entities
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
            if (checkout <= checkin)
            { throw new DomainException("Data saída deve ser posterior à entrada"); }
            Checkin = checkin;
            Checkout = checkout;
        }

        public void UpdateDates(DateTime newCheckin, DateTime newCheckout)
        {
            if (newCheckout <= newCheckin)
            { throw new DomainException("Data saída deve ser posterior à entrada"); }
            DateTime now =  DateTime.Now;
            if (newCheckout <= now || newCheckin <= now)
            { throw new DomainException("Datas de entrada e saída devem ser posterior à hoje"); }

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
