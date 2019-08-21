using Blazor.Fluxor;
using System;
using System.Linq;
using WeatherForecastSample.Shared;

namespace WeatherForecastSample.Client.Store.FetchData
{
	public class FetchDataFeature : Feature<FetchDataState>
	{
		public override string GetName() => "FetchData";

        protected override FetchDataState GetInitialState() => new FetchDataState(
            isLoading: false,
            errorMessage: string.Empty,
            forecasts: Array.Empty<WeatherForecast>());
	}
}
