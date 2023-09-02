using Newtonsoft.Json;

namespace API
{
    // further staging commit Final changes commit 2
    // comment 2
    public class ExampleQueryHandler : IQueryHandler<ExampleQuery, string>
    {
        public async Task<string> Handle(ExampleQuery query, CancellationToken cancellationToken)
        {
            return JsonConvert.SerializeObject("Hello Example API");
        }
    }
}
