using System.Threading.Tasks;

namespace Sirh3e.Steamer.Core.Pipeline
{
    public interface ISteamerPipelineHandler<in TInput, TOutput>
    {
        public TOutput Process(TInput input);
        public Task<TOutput> ProcessAsync(TInput input);
    }
}