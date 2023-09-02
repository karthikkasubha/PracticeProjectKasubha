namespace API
{
    public class ExampleQuery : IQuery<string>
    {
        public Guid Id { get; }

        public ExampleQuery()
        {
            Id = Guid.NewGuid();
        }
    }
}
