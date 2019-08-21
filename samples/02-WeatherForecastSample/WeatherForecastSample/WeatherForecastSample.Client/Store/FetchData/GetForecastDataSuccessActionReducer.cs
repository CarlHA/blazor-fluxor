﻿using Blazor.Fluxor;

namespace WeatherForecastSample.Client.Store.FetchData
{
	public class GetForecastDataSuccessActionReducer : Reducer<FetchDataState, GetForecastDataSuccessAction>
	{
		public override FetchDataState Reduce(FetchDataState state, GetForecastDataSuccessAction action)
		{
			return new FetchDataState(
				isLoading: false,
				errorMessage: string.Empty,
				forecasts: action.WeatherForecasts);
		}
	}
}
