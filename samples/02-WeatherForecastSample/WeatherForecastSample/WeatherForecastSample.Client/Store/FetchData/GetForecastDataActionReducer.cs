using Blazor.Fluxor;
using System;
using System.Linq;
using WeatherForecastSample.Shared;

namespace WeatherForecastSample.Client.Store.FetchData
{
	public class GetForecastDataActionReducer : Reducer<FetchDataState, GetForecastDataAction>
	{
		public override FetchDataState Reduce(FetchDataState state, GetForecastDataAction action)
		{
			return new FetchDataState(
				isLoading: true,
				errorMessage: string.Empty,
				forecasts: Array.Empty<WeatherForecast>());
		}
	}
}
