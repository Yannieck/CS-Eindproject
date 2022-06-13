using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSEindproject
{
    public class Reservation
    {
        public DateTime startDate;
        public DateTime endDate;
        public int amtPeople;
        public bool car;
        public Place place;

        public Reservation(DateTime startDate, DateTime endDate, int amtPeople, bool car, Place place)
        {
            this.startDate = startDate;
            this.endDate = endDate;
            this.amtPeople = amtPeople;
            this.car = car;
            this.place = place;
        }

        public float calculatePrice()
        {
            float placePrice = place.price;
            float pricePeople = amtPeople * 2.5f;
            float priceCar = car ? 3.0f : 0.0f;

            float total = (placePrice + pricePeople + priceCar) * (endDate.Date - startDate.Date).Days;

            DateTime startDealDate = new DateTime(startDate.Year, 7, 11);
            DateTime endDealDate = new DateTime(startDate.Year, 8, 15);

            if (startDate > startDealDate && startDate < endDealDate && endDate > startDealDate && endDate < endDealDate)
            {
                total *= (3 / 4);
            }

            return total;
        }
    }
}
