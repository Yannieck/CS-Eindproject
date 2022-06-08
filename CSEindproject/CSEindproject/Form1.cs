using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSEindproject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


    }
    public class Camping
    {
        public string name;
        public string adress;
        public float totalIncome;
        public int avgDays;
        public int totPeople;
        public List<Reservation> reservations;

        public Camping(string name, string adress)
        {
            this.name = name;
            this.adress = adress;
            totalIncome = 0;
            avgDays = 0;
            totPeople = 0;
            reservations = new List<Reservation>();
        }

        public void addReservation(DateTime startDate, DateTime endDate, int amtPeople, bool car, Place place)
        {
            Reservation reservation = new Reservation(startDate, endDate, amtPeople, car, place);
            reservations.Add(reservation);

            avgDays += (endDate.Date - startDate.Date).Days;
            totPeople += amtPeople;
            totalIncome += reservation.calculatePrice();
        }
    }

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
                total *= (3/4);
            }

            return total;
        }
    }

    public class Place
    {
        public string id;
        public float price = 15f;
    }
}
