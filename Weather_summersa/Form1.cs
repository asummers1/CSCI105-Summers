using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;  // Added to use the XDocument class
/*
 * Alexander Summers
 * Displays weather info and comparison between two cities.
 * 10-7-2019
 */
namespace weatherapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Enter your API key here.
        // Get an API key by making a free account at:
        //      http://home.openweathermap.org/users/sign_in
        private const string API_KEY = "61ad9d42b5bf4553aba08ad86af729ee";

        // Query URLs. Replace @LOC@ with the location.
        private const string CurrentUrl =
            "http://api.openweathermap.org/data/2.5/weather?" +
            "q=@LOC@&mode=xml&units=imperial&APPID=" + API_KEY;

        
        static private void GetConditions(string city, ref string temp, ref string units, ref string humidity, ref string pressure)
        {
            // Compose the query URL.
            string url = CurrentUrl.Replace("@LOC@", city);
            

            // Load the XDocument class with XML file for the requested city
            XDocument X = XDocument.Load(url);

            // Extract the temperature data from the XML file.
            XElement tempData = X.Element("current").Element("temperature");
            XElement humidityData = X.Element("current").Element("humidity");
            XElement pressureData = X.Element("current").Element("pressure");

            // Extract the first attribute which is the temperature and the last which is the units
            temp = tempData.FirstAttribute.ToString();
            units = tempData.LastAttribute.ToString();
            humidity = humidityData.FirstAttribute.ToString();
            pressure = pressureData.FirstAttribute.ToString();
            
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                lstbxFirstCityInfo.Items.Clear();  //While the listbox is clear when the program first starts, it needs to clear itself when "Calculate" is clicked another time. Otherwise, text will simply be added to the end.
                // Variable declarations
                string city1, city2;
                string tempCity1, tempCity2;
                string unitsCity1, unitsCity2;
                string humidityCity1, humidityCity2;
                string pressureCity1, pressureCity2;

                double c1Temp = 0, c2Temp = 0;
                double c1Humidity = 0, c2Humidity = 0;
                double c1Pressure = 0, c2Pressure = 0;

                tempCity1 = tempCity2 = unitsCity1 = unitsCity2 = "";
                humidityCity1 = humidityCity2 = pressureCity1 = pressureCity2 = "";

                // Ask the user for city to get weather information

                city1 = txtCity1.Text;

                // Get the current weather for city1
                GetConditions(city1, ref tempCity1, ref unitsCity1, ref humidityCity1, ref pressureCity1);

                // Clean up data
                tempCity1 = tempCity1.Remove(0, 7);
                tempCity1 = tempCity1.TrimEnd('"');
                c1Temp = double.Parse(tempCity1);

                
                unitsCity1 = unitsCity1.Remove(0, 6);
                unitsCity1 = unitsCity1.TrimEnd('"');

                humidityCity1 = humidityCity1.Remove(0, 7);
                humidityCity1 = humidityCity1.TrimEnd('"');
                c1Humidity = double.Parse(humidityCity1);

                pressureCity1 = pressureCity1.Remove(0, 7);
                pressureCity1 = pressureCity1.TrimEnd('"');
                c1Pressure = double.Parse(pressureCity1);

                // Adk the user for city to get weather information

                city2 = txtCity2.Text;

                // Get the current weather for city2
                GetConditions(city2, ref tempCity2, ref unitsCity2, ref humidityCity2, ref pressureCity2);

                // Clean up data
                tempCity2 = tempCity2.Remove(0, 7);
                tempCity2 = tempCity2.TrimEnd('"');
                c2Temp = double.Parse(tempCity2);

                unitsCity2 = unitsCity2.Remove(0, 6);
                unitsCity2 = unitsCity2.TrimEnd('"');

                humidityCity2 = (humidityCity2.Remove(0, 7)).TrimEnd('"');
                c2Humidity = double.Parse(humidityCity2);

                c2Pressure = double.Parse((pressureCity2.Remove(0, 7)).TrimEnd('"'));

                // Output data to the screen

                lstbxFirstCityInfo.Items.Add($"{city1}:\n"); //adds info for the first city on the screen
                lstbxFirstCityInfo.Items.Add($"\t    temp: {c1Temp:N2}\n");  
                lstbxFirstCityInfo.Items.Add($"\t   units: {unitsCity1}\n");
                lstbxFirstCityInfo.Items.Add($"\thumidity: {c1Humidity:N0}\n");
                lstbxFirstCityInfo.Items.Add($"\tpressure: {c1Pressure:N0}");
                lstbxFirstCityInfo.Items.Add("");


                lstbxSecondCityInfo.Items.Add($"{city2}:\n"); //adds info for the second city onto the screen
                lstbxSecondCityInfo.Items.Add($"\t    temp: {c2Temp:N2}\n");
                lstbxSecondCityInfo.Items.Add($"\t   units: {unitsCity2}\n");
                lstbxSecondCityInfo.Items.Add($"\thumidity: {c2Humidity:N0}\n");
                lstbxSecondCityInfo.Items.Add($"\tpressure: {c2Pressure:N0}");
                lstbxSecondCityInfo.Items.Add("");
                // Checking to see if city1 is hotter than city2



                if (c1Temp > c2Temp)
                {

                    lstbxComparer.Items.Add($"\t{city1} is hotter than {city2}.");
                }
                else
                {

                    lstbxComparer.Items.Add($"\t{city2} is hotter than {city1}.");
                }

                // Variant 1
                /*
                if (c1Temp > c2Temp)
                    lstbxWeatherInfo.Items.Add($"\t{city1} is hotter than {city2}.");
                else
                    lstbxWeatherInfo.Items.Add($"\t{city2} is hotter than {city1}.");

                // Variant 2

                if (c1Temp > c2Temp) lstbxWeatherInfo.Items.Add($"\t{city1} is hotter than {city2}.");
                else lstbxWeatherInfo.Items.Add($"\t{city2} is hotter than {city1}.");

                // Check to see if city1 is hotter, equal to, or cooler

                lstbxWeatherInfo.Items.Add("Is city1 hotter, equal to, or cooler than city2");


                if (c1Temp > c2Temp)
                {
                    lstbxWeatherInfo.Items.Add($"\t{city1} is hotter than {city2}.");
                }
                else
                {
                    if (c1Temp == c2Temp)
                    {
                        lstbxWeatherInfo.Items.Add($"\t{city1} has the same temperature as {city2}.");
                    }
                    else
                    {
                        lstbxWeatherInfo.Items.Add($"\t{city1} is cooler than {city2}.");
                    }
                }
                */
                // Variant 3
                if (c1Temp > c2Temp)
                {
                    lstbxComparer.Items.Add($"\t{city1} is hotter than {city2}.");
                }
                else if (c1Temp == c2Temp)
                {
                    lstbxComparer.Items.Add($"\t{city1} has the same temperature as {city2}.");
                }
                else
                {
                    lstbxComparer.Items.Add($"\t{city1} is cooler than {city2}.");
                }

                if (c1Pressure <= 500)
                {
                    lstbxFirstCityInfo.Items.Add($"{city1} has a pressure that is less than or equal to 500.");
                }
                else if (c1Pressure <= 1000)
                {
                    lstbxFirstCityInfo.Items.Add($"{city1} has a pressure that is greater than 500 and less than 1001.");
                }
                else
                {
                    lstbxFirstCityInfo.Items.Add($"{city1} has a pressure that is greater than 1000.");
                }

                if (c2Pressure <= 500)
                {
                    lstbxSecondCityInfo.Items.Add($"{city2} has a pressure that is less than or equal to 500.");
                }
                else if (c1Pressure <= 1000)
                {
                    lstbxSecondCityInfo.Items.Add($"{city2} has a pressure that is greater than 500 and less than 1001.");
                }
                else
                {
                    lstbxSecondCityInfo.Items.Add($"{city2} has a pressure that is greater than 1000.");
                }
                /*
                 * Determine humidity range for City 1
                 *   Less than or equal to 50
                 *   between 51 and 100
                 *   greater than or equal to 101
                 */


                lstbxFirstCityInfo.Items.Add("*** City1 humidity range ***");


                if (c1Humidity <= 50)
                    lstbxFirstCityInfo.Items.Add($"{city1}'s humidity is less than or equal to 50.");
                else if (c1Humidity > 50 && c1Humidity <= 100)
                    lstbxFirstCityInfo.Items.Add($"{city1}'s humidity is between 50 and 100.");
                else
                    lstbxFirstCityInfo.Items.Add($"{city1}'s humidity is greater than 100.");

                lstbxSecondCityInfo.Items.Add("*** City2 humidity range ***");
                if (c2Humidity <= 50)
                    lstbxSecondCityInfo.Items.Add($"{city2}'s humidity is less than or equal to 50.");
                else if (c2Humidity > 50 && c2Humidity <= 100)
                    lstbxSecondCityInfo.Items.Add($"{city2}'s humidity is between 50 and 100.");
                else
                    lstbxSecondCityInfo.Items.Add($"{city2}'s humidity is greater than 100.");

            }
            catch    
            {
                MessageBox.Show("Please make sure your city names are valid.");
                lstbxFirstCityInfo.Items.Clear();
            }
           
}

        private void btnReset_Click(object sender, EventArgs e)
        {
            ListBox temp;

            foreach (Control c in this.Controls)
            {
                if (c is ListBox)
                {
                    temp = (ListBox)c;
                    temp.Items.Clear();
                }
            }
          
        }

        private void txtCity1_Validating(object sender, CancelEventArgs e)
        {
            if (int.TryParse(txtCity1.Text, out int num))
            {
                MessageBox.Show("Please enter in a city name in the upper leftmost box.");
                txtCity1.Clear();
                txtCity1.Focus();
                return;
            }
        }

        private void txtCity2_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtCity1.Text, out int num))
            {
                MessageBox.Show("Please enter in a city name in the upper rightmost box.");
                txtCity2.Clear();
                txtCity2.Focus();
                return;
            }
        }
    }
}
        
    

