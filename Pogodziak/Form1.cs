using Newtonsoft.Json;
using System.ComponentModel.Design.Serialization;

namespace Pogodziak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Display();
        }

        void Display()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://api.open-meteo.com/v1/forecast?latitude=54.36&longitude=18.64&current=temperature_2m,relative_humidity_2m,weather_code&hourly=temperature_2m&timezone=Europe%2FBerlin");

            HttpResponseMessage response = client.GetAsync(client.BaseAddress).Result;
            string result = response.Content.ReadAsStringAsync().Result;

            Root currentWeather = JsonConvert.DeserializeObject<Root>(result);

            lat.Text = currentWeather.latitude.ToString();
            lon.Text = currentWeather.longitude.ToString();
            time.Text = currentWeather.current.time.ToString();
            temp.Text = currentWeather.current.temperature_2m.ToString() + "℃";
            hum.Text = currentWeather.current.relative_humidity_2m.ToString() + "%";

            if (currentWeather.current.weather_code == 0)
            {
                weather.Text = "Słonecznie";
            }
            else if (currentWeather.current.weather_code >= 1 && currentWeather.current.weather_code <= 3)
            {
                weather.Text = "Lekkie zachmurzenie";
            }
            else if (currentWeather.current.weather_code == 45 && currentWeather.current.weather_code == 48)
            {
                weather.Text = "Mgła";
            }
            else if (currentWeather.current.weather_code == 61 && currentWeather.current.weather_code == 63 && currentWeather.current.weather_code == 65 && currentWeather.current.weather_code == 66 && currentWeather.current.weather_code == 67)
            {
                weather.Text = "Opady deszczu";
            }
            else if (currentWeather.current.weather_code == 71 && currentWeather.current.weather_code == 73 && currentWeather.current.weather_code == 75)
            {
                weather.Text = "Opady śniegu";
            }
            else if (currentWeather.current.weather_code == 95 && currentWeather.current.weather_code == 96 && currentWeather.current.weather_code == 99)
            {
                weather.Text = "Burza";
            }

        }
    }

    public class Current
    {
        public string time { get; set; }
        public int interval { get; set; }
        public double temperature_2m { get; set; }
        public int relative_humidity_2m { get; set; }
        public int weather_code { get; set; }
    }

    public class CurrentUnits
    {
        public string time { get; set; }
        public string interval { get; set; }
        public string temperature_2m { get; set; }
        public string relative_humidity_2m { get; set; }
        public string weather_code { get; set; }
    }

    public class Hourly
    {
        public List<string> time { get; set; }
        public List<double> temperature_2m { get; set; }
    }

    public class HourlyUnits
    {
        public string time { get; set; }
        public string temperature_2m { get; set; }
    }

    public class Root
    {
        public double latitude { get; set; }
        public double longitude { get; set; }
        public double generationtime_ms { get; set; }
        public int utc_offset_seconds { get; set; }
        public string timezone { get; set; }
        public string timezone_abbreviation { get; set; }
        public double elevation { get; set; }
        public CurrentUnits current_units { get; set; }
        public Current current { get; set; }
        public HourlyUnits hourly_units { get; set; }
        public Hourly hourly { get; set; }
    }
}
