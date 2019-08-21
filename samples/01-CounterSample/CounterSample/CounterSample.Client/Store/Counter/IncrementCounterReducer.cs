using Blazor.Fluxor;

namespace CounterSample.Client.Store.Counter
{
	public class IncrementCountReducer: Reducer<CounterState, IncrementCountAction>
	{
		public override CounterState Reduce(CounterState state, IncrementCountAction action)
		{
			return new CounterState(state.ClickCount + 1);
		}
	}

    public class DecrementCountReducer : Reducer<CounterState, DecrementCountAction>
    {
        public override CounterState Reduce(CounterState state, DecrementCountAction action)
        {
            return new CounterState(state.ClickCount - 1);
        }
    }

    public class ResetCounterReducer : Reducer<CounterState, ResetCounterAction>
    {
        public override CounterState Reduce(CounterState state, ResetCounterAction action)
        {
            return new CounterState(0);
        }
    }

}
