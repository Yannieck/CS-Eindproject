/// <summary>
/// 
/// Naam: Yannieck Blaauw
/// Datum: 13-6-22
/// Opdracht: 4 (Camping)
///     Maak een programma voor een camping, waarbij je reserveringen kan plaatsen
/// Beg. Docent: Rob Loves
/// 
/// </summary>

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace CSEindproject
{
    public partial class CampingMain : Form
    {
        Camping camping;

        //String to connect to DB
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CSEindproject;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public CampingMain()
        {
            Thread thread = new Thread(new ThreadStart(startLoading));
            thread.Start();
            Thread.Sleep(1000);
            thread.Abort();

            InitializeComponent();
            //Make a new camping
            camping = new Camping("Test naam", "ergens");
            loadCamping();
        }

        private void CampingMain_Load(object sender, EventArgs e)
        {
            this.Activate();
        }

        private void Form1_Resize(object sender, EventArgs e)
        { 
            if (this.WindowState == FormWindowState.Minimized)
            {
                hideApp();
            }
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
                    LoadSelectBox();
                    UpdatePrice();
                    break;
                case "PlacePage":
                    loadPlace();
                    break;
                default:
                    break;
            }
        }

        private void startLoading()
        {
            Application.Run(new CampingLoading());
        }

        /////////////
        // CAMPING //
        /////////////

        //Load in the camping data
        private void loadCamping()
        {
            loadCampingFromDB();

            CampingNameLabel.Text = camping.name;
            AdressLabelValue.Text = camping.adress;
            PeopleAmtLabelValue.Text = camping.totPeople.ToString();
            AvgTimespanLabelValue.Text = camping.getAvgDays().ToString();
            TotIncomeLabelValue.Text = convertToMoney(camping.totalIncome);
        }

        private void loadCampingFromDB()
        {
            string query = @"SELECT startDate, endDate, people, car, placeId
                           FROM Reservations;";
            DataSet result = new DataSet();

            SqlConnection connection = new SqlConnection(connectionString);

            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.Fill(result);

            foreach (DataRow dr in result.Tables[0].Rows)
            {
                Place place = new Place((string)dr[4], GetPriceFromPlace((string)dr[4]));
                Reservation reservation = new Reservation((DateTime)dr[0], (DateTime)dr[1], (int)dr[2], (bool)dr[3], place);
                camping.addReservation(reservation);
            }
        }

        private string convertToMoney(float amt)
        {
            return "€ " + string.Format("{0:0.00}", amt);
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

            string placeName = ((KeyValuePair<string, string>)PlaceSelectBox.SelectedItem).Key;
            string placePrice = ((KeyValuePair<string, string>)PlaceSelectBox.SelectedItem).Value;

            Place place = new Place(placeName, float.Parse(placePrice));

            if (endDate > startDate)
            {
                if (peopleAmount > 0)
                {
                    return new Reservation(startDate, endDate, peopleAmount, hasCar, place);
                }
            }
            return null;
        }

        private void addReservationToDB(Reservation reservation)
        {
            string query = @"INSERT INTO Reservations(startDate, endDate, people, car, placeId) VALUES(@startDate, @endDate, @people, @car, @placeId)";

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.Add(new SqlParameter("@startDate", reservation.startDate));
            cmd.Parameters.Add(new SqlParameter("@endDate", reservation.endDate));
            cmd.Parameters.Add(new SqlParameter("@people", reservation.amtPeople));
            cmd.Parameters.Add(new SqlParameter("@car", reservation.car));
            cmd.Parameters.Add(new SqlParameter("@placeId", reservation.place.id));
            cmd.ExecuteNonQuery();
        }

        private void UpdatePrice_Event(object sender, EventArgs e)
        {
            UpdatePrice();
        }

        private void UpdatePrice()
        {
            Reservation reservation = ReadReservation();
            if (reservation != null)
            {
                ReservationPriceLabel.Text = convertToMoney(reservation.calculatePrice());
            }
            else
            {
                ReservationPriceLabel.Text = "Please fill in all fields";
            }
        }

        private void LoadSelectBox()
        {
            string query = @"SELECT Place.id, Place.price
                           FROM Place;";

            DataSet result = new DataSet();

            SqlConnection connection = new SqlConnection(connectionString);

            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.Fill(result);

            Dictionary<string, string> comboSource = new Dictionary<string, string>();

            foreach (DataRow dr in result.Tables[0].Rows)
            {
                string price = dr[1].ToString();
                string display = dr[0].ToString();

                comboSource.Add(display, price);
            }

            PlaceSelectBox.DataSource = new BindingSource(comboSource, null);
            PlaceSelectBox.DisplayMember = "Key";
            PlaceSelectBox.ValueMember = "Value";
        }

        private void ReserveBtn_Click(object sender, EventArgs e)
        {
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
                        addReservationToDB(reservation);
                    }
                }
            }
        }

        ////////////
        // PLACES //
        ////////////

        private void loadPlace()
        {
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
                PlaceListLabel.Text += dr[0].ToString() + ": " + convertToMoney(price) + "\n";
            }
        }

        private void AddPlace(object sender, EventArgs e)
        {
            if (PlaceNameField.Text != string.Empty && PlacePriceField.Value > 0)
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

        private float GetPriceFromPlace(string placeId)
        {
            string query = @"SELECT Place.price
                           FROM Place
                           WHERE Place.id = @id;";

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.Add(new SqlParameter("@id", placeId));
            var result = cmd.ExecuteScalar();
            return float.Parse(result.ToString());
        }

        private void CamingStrip_Click(object sender, EventArgs e)
        {
            showApp();
            TabControl.SelectedTab = TabControl.TabPages["CampingPage"];
        }

        private void ReservationStrip_Click(object sender, EventArgs e)
        {
            showApp();
            TabControl.SelectedTab = TabControl.TabPages["ReservePage"];
        }

        private void placesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showApp();
            TabControl.SelectedTab = TabControl.TabPages["PlacePage"];
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.Show();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            showApp();
        }

        private void showApp()
        {
            Show();
            WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }

        private void hideApp()
        {
            Hide();
            notifyIcon.Visible = true;
        }
    }
}
