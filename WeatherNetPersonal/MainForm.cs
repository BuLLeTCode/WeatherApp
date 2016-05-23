using System.Drawing;
using System.Windows.Forms;
using WeatherNet;
using WeatherNetPersonal.Properties;

namespace WeatherNetPersonal
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitializeWeatherApi();
            InitializeBackground();
            InitializeWeatherInfo();
        }

        private void InitializeBackground()
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.Transparent;

            Opacity = .95;
        }

        private static void InitializeWeatherApi()
        {
            ClientSettings.SetApiKey("1b42f01b0706e3756da5e4a5d63fde98");
        }

        private void InitializeWeatherInfo()
        {
            CurrentCityWeather valmieraCityWeather = new CurrentCityWeather("Valmiera");//TODO this needs to changed to some Dropdown.

            pbWeatherIcone.Image = Image.FromFile(@"Pictures\" + valmieraCityWeather.GetWeatherIcone() + ".png");
            lblTemp.Text = valmieraCityWeather.GetTemp() + @"°C";
            lblCityNameCountry.Text = valmieraCityWeather.City + @", LV";
            //Add extra weather info
            tbExtraWeatherInfo.ReadOnly = true;
            tbExtraWeatherInfo.Text = Resources.MainForm_InitializeWeatherInfo_Vēja_ātrums_;
            tbExtraWeatherInfo.Text += valmieraCityWeather.GetWind() + Resources.MainForm_InitializeWeatherInfo__m_s;
            //tbExtraWeatherInfo.Text += Environment.NewLine +  
            
        }
    }
}
