using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Data.SqlClient;

namespace CSEindproject
{
    public partial class Form1 : Form
    {
        Camping camping;

        //String to connect to DB
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CSEindproject;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public Form1()
        {
            InitializeComponent();
            //Make a new camping
            camping = new Camping("Test naam", "ergens");
            loadCamping();
        }

        //Load the data according to which page is selected
        private void Camping_Selected(object sender, TabControlEventArgs e)
        {
            switch (e.TabPage.Name)
            {
                case "CampingPage":
                    loadCamping();
                    break;
                case "ReservePage":
                    break;
                case "PlacePage":
                    loadPlace();
                    break;
                default:
                    break;
            }
        }

        /////////////
        // CAMPING //
        /////////////

        //Load in the camping data
        private void loadCamping()
        {
            Console.WriteLine("Loaded camping page");

            CampingNameLabel.Text = camping.name;
            AdressLabelValue.Text = camping.adress;
            PeopleAmtLabelValue.Text = camping.totPeople.ToString();
            AvgTimespanLabelValue.Text = camping.avgDays.ToString();
            TotIncomeLabelValue.Text = camping.totalIncome.ToString("C", CultureInfo.CurrentCulture);
        }

        //////////////////
        // RESERVATIONS //
        //////////////////

        private Reservation ReadReservation()
        {
            DateTime startDate = StartDatePicker.Value;
            DateTime endDate = EndDatePicker.Value;
            int peopleAmount = (int)PeopleAmountField.Value;
            bool hasCar = HasCarCheckbox.Checked;
            Place place = new Place(ReservationPlaceInput.Text);

            if (endDate > startDate)
            {
                if (peopleAmount > 0)
                {
                    if (place != Place.empty)
                    {
                        return new Reservation(startDate, endDate, peopleAmount, hasCar, place);
                    }
                }
            }
            return null;
        }

        private void addReservationToDB()
        {

        }

        private void UpdatePrice(object sender, EventArgs e)
        {
            Reservation reservation = ReadReservation();
            ReservationPriceLabel.Text = reservation.calculatePrice().ToString("C", CultureInfo.CurrentCulture);
        }

        private void ReserveBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Added reservation");

            Reservation reservation = ReadReservation();

            if (reservation != null)
            {
                string query = @"SELECT Place.id, Place.price
                           FROM Place;";

                DataSet result = new DataSet();

                SqlConnection connection = new SqlConnection(connectionString);

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(result);

                foreach (DataRow dr in result.Tables[0].Rows)
                {
                    if ((string)dr[0] == reservation.place.id)
                    {
                        MessageBox.Show("Added Reservation");
                        camping.addReservation(reservation);
                    }
                }
            }
        }

        ////////////
        // PLACES //
        ////////////

        private void loadPlace()
        {
            Console.WriteLine("Loaded Place page");

            PlaceListLabel.Text = "";

            string query = @"SELECT Place.id, Place.price
                           FROM Place;";

            DataSet result = new DataSet();

            SqlConnection connection = new SqlConnection(connectionString);

            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.Fill(result);

            foreach (DataRow dr in result.Tables[0].Rows)
            {
                float price = float.Parse(dr[1].ToString());
                PlaceListLabel.Text += dr[0].ToString() + ": " + price.ToString("C", CultureInfo.CurrentCulture) + "\n";
            }
        }

        private void AddPlace(object sender, EventArgs e)
        {
            if (PlaceNameField.Text != String.Empty && PlacePriceField.Value > 0)
            {
                string query = "INSERT INTO Place(id, price) VALUES(@id, @price)";

                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", PlaceNameField.Text);
                    cmd.Parameters.AddWithValue("@price", PlacePriceField.Value);

                    try
                    {
                        int rowsAdded = cmd.ExecuteNonQuery();
                        if (rowsAdded > 0)
                        {
                            MessageBox.Show("Added place");
                            loadPlace();
                        }
                        else
                            MessageBox.Show("Error");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid values");
            }
        }
    }

    /////////////
    // OBJECTS //
    /////////////

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
            this.totalIncome = 0;
            this.avgDays = 0;
            this.totPeople = 0;
            this.reservations = new List<Reservation>();
        }

        public void addReservation(Reservation reservation)
        {
            this.reservations.Add(reservation);

            this.avgDays += (reservation.endDate.Date - reservation.startDate.Date).Days;
            this.totPeople += reservation.amtPeople;
            this.totalIncome += reservation.calculatePrice();
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
                total *= (3 / 4);
            }

            return total;
        }
    }

    public class Place
    {
        public string id;
        public float price = 15f;

        public static Place empty = new Place(string.Empty, 0);

        public Place(string id, float price = 15.0f)
        {
            this.id = id;
            this.price = price;
        }
    }
}
