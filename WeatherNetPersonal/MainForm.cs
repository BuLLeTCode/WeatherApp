using System;
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
        }

        private void InitializeBackground()
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.Transparent;

            Opacity = .95;
            
            //By default no city
            lblTemp.Visible = false;
            lblCityNameCountry.Text = @"Izvēlies pilsētu";
            tbExtraWeatherInfo.Visible = false;
        }

        private static void InitializeWeatherApi()
        {
            ClientSettings.SetApiKey("1b42f01b0706e3756da5e4a5d63fde98");
        }

        private void InitializeWeatherInfo(string userInputCity)
        {
            CurrentCityWeather cityWeather = new CurrentCityWeather(userInputCity);
            //Little manipulation according to City validation!
            if (!cityWeather.IsCityValide())
            {
                pbWeatherIcone.Image = pbWeatherIcone.ErrorImage;
                lblTemp.Visible = false;
                lblCityNameCountry.Text = @"Pilsēta nav atrasta";
                tbExtraWeatherInfo.Visible = false;
            }
            else
            {
                if (!lblTemp.Visible)
                {
                    lblTemp.Visible = true;
                    tbExtraWeatherInfo.Visible = true;
                }
            }

            pbWeatherIcone.Image = Image.FromFile(@"Pictures\" + cityWeather.GetWeatherIcone() + ".png");
            lblTemp.Text = cityWeather.GetTemp() + @"°C";
            lblCityNameCountry.Text = cityWeather.City + @", LV";
            //Add extra weather info
            tbExtraWeatherInfo.ReadOnly = true;
            tbExtraWeatherInfo.Text = Resources.MainForm_InitializeWeatherInfo_Vēja_ātrums_;
            tbExtraWeatherInfo.Text += cityWeather.GetWind() + Resources.MainForm_InitializeWeatherInfo__m_s;
            tbExtraWeatherInfo.Text += Environment.NewLine + Resources.MainForm_InitializeWeatherInfo_Gaisa_mitrums_ +
                                       cityWeather.GetHumidity();
            //TODO get information about sunrise and sunset.
            //tbExtraWeatherInfo.Text += Environment.NewLine + cityWeather.GetHumidity();


        }

        private void tbUserInputCity_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Return)
            {
                InitializeWeatherInfo(tbUserInputCity.Text);
            }
        }
    }
}
