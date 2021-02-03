namespace Sirh3e.Steamer.Core.Pipeline {
    public interface ISteamerPipelineHandler<in TInput, out TOutput> {
        public TOutput Process(TInput input);
    }
}