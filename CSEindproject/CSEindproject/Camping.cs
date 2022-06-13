using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSEindproject
{
    public class Camping
    {
        public string name;
        public string adress;
        public float totalIncome;
        public int totDays;
        public int totPeople;
        public List<Reservation> reservations;

        public Camping(string name, string adress)
        {
            this.name = name;
            this.adress = adress;
            this.totalIncome = 0;
            this.totDays = 0;
            this.totPeople = 0;
            this.reservations = new List<Reservation>();
        }

        public void addReservation(Reservation reservation)
        {
            this.reservations.Add(reservation);

            this.totDays += (reservation.endDate.Date - reservation.startDate.Date).Days;
            this.totPeople += reservation.amtPeople;
            this.totalIncome += reservation.calculatePrice();
        }

        public int getAvgDays()
        {
            if (reservations.Count > 0)
                return totDays / reservations.Count;
            else
                return 0;

        }

    }