namespace MauiApp1;
using System.Net.Http;
using System.Net.Http.Json;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		var client = new HttpClient();

		HttpRequestMessage message = new HttpRequestMessage(HttpMethod.Get, "https://api.open-meteo.com/v1/forecast?latitude=-27.4679&longitude=153.0281&current=temperature_2m&daily=weather_code,temperature_2m_max,temperature_2m_min&forecast_days=1")
        
		string weather = client.GetStreamAsync
			
		InitializeComponent();
	}

}