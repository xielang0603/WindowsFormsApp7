using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //WebRefWeather.WeatherWS weather = new WebRefWeather.WeatherWS();
            WebRefWeather.WeatherWebService weather = new WebRefWeather.WeatherWebService();
            string[] str = new string[32];
            try
            {
                //str = weather.getWeather("北京", "");
                str = weather.getWeatherbyCityName("北京");
                MessageBox.Show(str[0] + "\n" + str[1] + "\n" + str[2] + "\n" + str[4] + "\n" + str[5], "天气信息");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
