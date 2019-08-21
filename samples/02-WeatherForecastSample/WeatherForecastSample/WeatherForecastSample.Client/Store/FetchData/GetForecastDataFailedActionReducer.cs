using Blazor.Fluxor;
using System;
using System.Linq;
using WeatherForecastSample.Shared;

namespace WeatherForecastSample.Client.Store.FetchData
{
	public class GetForecastDataFailedActionReducer : Reducer<FetchDataState, GetForecastDataFailedAction>
	{
		public override FetchDataState Reduce(FetchDataState state, GetForecastDataFailedAction action)
		{
			return new FetchDataState(
				isLoading: false,
				errorMessage: action.ErrorMessage,
				forecasts: Array.Empty<WeatherForecast>());
		}
	}
}
