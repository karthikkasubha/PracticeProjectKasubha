using Newtonsoft.Json;

namespace API
{
    // further staging commit
    public class ExampleQueryHandler : IQueryHandler<ExampleQuery, string>
    {
        public async Task<string> Handle(ExampleQuery query, CancellationToken cancellationToken)
        {
            return JsonConvert.SerializeObject("Hello Example API");
        }
    }
}
