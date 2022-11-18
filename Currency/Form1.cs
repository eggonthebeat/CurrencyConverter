using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Currency
{
    public partial class Form1 : Form
    {

        private const string URL = "https://currency-exchange.p.rapidapi.com/exchange";

        private string urlParameters = "?from=SEK&to=NOK&q=1.0";
        private HttpClient client = new HttpClient();
        

        public Form1()
        {
            InitializeComponent();
            string[] currencies = { "SEK", "NOK", "USD", "EUR", "GER", "SAR" };
            currency1Box.Items.Clear(); currency2Box.Items.Clear();
            foreach (string currency in currencies) {
                currency1Box.Items.Add(currency);
                currency2Box.Items.Add(currency);
            }

            client.BaseAddress = new Uri(URL);
            client.DefaultRequestHeaders.Add("X-RapidAPI-Key", "2ec232f206msh922aedb2320f018p10e0f5jsne84ee10326b4");

            client.DefaultRequestHeaders.Add("X-RapidAPI-Host", "currency-exchange.p.rapidapi.com");



            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("text/plain"));



            //var r = response.Content.ReadAsStringAsync().Result;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void currency2Box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void print(object output)
        {
            Console.WriteLine(output);
        }
        private void convertBtn_Click(object sender, EventArgs e)
        {

           

            if (currency1txt.Text==String.Empty) return;

            urlParameters = "?from=" + currency1Box.Text + "&to=" + currency2Box.Text + "&q=1.0";
            var response = client.GetAsync(urlParameters).Result;

            
            var r = (response.Content.ReadAsStringAsync().Result);

            print(urlParameters);

            r = r.Replace(".", ",");

            var difference = Double.Parse(r);

            print(difference);

            currency2txt.Text = (difference * Double.Parse(currency1txt.Text)).ToString();


            //float dif = difference.to
        }
    }
}
