using System;
using System.Collections.Generic;
using System.Text;
using CodingPractice;

namespace DesignPatterns
{
	class ObservablePattern : AbsProblem, IProblem
	{

		/*
		 * Observable Pattern
		 * 
		 * Pattern that will make other modulars independent of each others. 
		 * Its a design pattern that will enforce other objects to not depend on change. 
		 * If there is a data that needs to be listened for, the Subject will notify the change of data 
		 * to each of the Observer. 
		 * 
		 */ 

		public ObservablePattern() : base("Observable Pattern")
		{

		}

		public override void Begin()
		{
			WeatherData weatherData = new WeatherData();

			CurrentConditionsDisplay currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);
			StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
			ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);

			weatherData.setMeasurements(80, 75, 30.4f);
			weatherData.setMeasurements(85, 70, 28.4f);
			weatherData.setMeasurements(75, 90, 63.4f);

			//Remove forecast from being notified of any change in weatherData
			forecastDisplay.unRegister();
		}
	}

	//Common Interface for Observables
	public interface IObservable
	{
		void updateData(float temp, float humidity, float pressure);
	}

	public interface IDisplay
	{
		void updateDislay();
	}

	//Common interface for subject
	public interface ISubject
	{
		void registerOberservable(IObservable observable, string name);
		void removeObeservable(IObservable observable, string name);
		void notifyObservable();
	}

	//Concrete class that will implement ISubject 
	public class WeatherData : ISubject
	{
		private List<IObservable> screens;
		private float _temp;
		private float _humidity;
		private float _pressure;

		public WeatherData()
		{
			screens = new List<IObservable>();
		}

		public void notifyObservable()
		{
			foreach(var screen in screens)
			{
				screen.updateData(_temp, _humidity, _pressure);
			}
		}

		public void registerOberservable(IObservable observable, string name)
		{
			Console.WriteLine($"{name} has been registered");
			screens.Add(observable);
		}

		public void removeObeservable(IObservable observable, string name)
		{
			Console.WriteLine($"{name} has been removed");

			screens.Remove(observable);
		}

		public void getTemperature()
		{
			//Calls to another module to retrieve temperature Data
		}

		public void getHumidity()
		{
			//Calls to another module to retrieve Humidity Data
		}

		public void getPressure()
		{
			//Calls to another module to retrieve pressure Data
		}

		public void setMeasurements(float temp, float humd, float pressure)
		{
			_temp = temp;
			_humidity = humd;
			_pressure = pressure;

			//Send out update to all observables
			notifyObservable();
		}
	}

	public class CurrentConditionsDisplay : IObservable, IDisplay
	{
		private WeatherData _weatherData;
		private float _temperature;
		private float _humidity;
		private float _pressure;

		public CurrentConditionsDisplay(WeatherData weatherData)
		{
			_weatherData = weatherData;

			//Subscribe to Subject's notifications 
			_weatherData.registerOberservable(this, "CurrentConditionsDisplay");
		}

		public void updateData(float temp, float humidity, float pressure)
		{
			_temperature = temp;
			_humidity = humidity;
			_pressure = pressure;

			updateDislay();
		}

		public void updateDislay()
		{
			Console.WriteLine("CurrentConditionsDisplay status: ");
			Console.WriteLine($"Temperature: {this._temperature}, Humidity: {this._humidity}, Pressure: {this._pressure}");
		}
	}

	public class StatisticsDisplay : IObservable, IDisplay
	{
		private WeatherData _weatherData;
		private float _temperature;
		private float _humidity;
		private float _pressure;

		public StatisticsDisplay(WeatherData weatherData)
		{
			_weatherData = weatherData;

			//Subscribe to Subject's notifications 
			_weatherData.registerOberservable(this, "StatisticsDisplay");
		}

		public void updateData(float temp, float humidity, float pressure)
		{
			_temperature = temp;
			_humidity = humidity;
			_pressure = pressure;

			updateDislay();
		}

		public void updateDislay()
		{
			Console.WriteLine("StatisticsDisplay status: ");
			Console.WriteLine($"Temperature: {this._temperature}, Humidity: {this._humidity}, Pressure: {this._pressure}");
		}
	}

	public class ForecastDisplay : IObservable, IDisplay
	{
		private WeatherData _weatherData;
		private float _temperature;
		private float _humidity;
		private float _pressure;

		public ForecastDisplay(WeatherData weatherData)
		{
			_weatherData = weatherData;

			//Subscribe to Subject's notifications 
			_weatherData.registerOberservable(this, "ForecastDisplay");
			
		}

		public void updateData(float temp, float humidity, float pressure)
		{
			_temperature = temp;
			_humidity = humidity;
			_pressure = pressure;

			updateDislay();
		}

		public void updateDislay()
		{
			Console.WriteLine("ForecastDisplay status: ");
			Console.WriteLine($"Temperature: {this._temperature}, Humidity: {this._humidity}, Pressure: {this._pressure}");
		}

		public void unRegister()
		{
			//Unsubscribe to Subject's notifications
			_weatherData.removeObeservable(this, "ForecastDisplay");
		}
	}

}
