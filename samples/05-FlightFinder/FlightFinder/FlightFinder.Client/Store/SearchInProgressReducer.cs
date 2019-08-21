using Blazor.Fluxor;
using System.Collections.Generic;

namespace FlightFinder.Client.Store
{
	public class SearchInProgressReducer : Reducer<AppState, SearchInProgressAction>
	{
		public override AppState Reduce(AppState state, SearchInProgressAction action)
		{
			return new AppState(
				searchInProgress: true,
				searchResults: new List<Shared.Itinerary>(),
				shortlist: state.Shortlist,
				airports: state.Airports);
		}
	}
}
