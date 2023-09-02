namespace API
{
    //test dev branch changes - test ss
    //test dev branch changes - KK
    public class ExampleQuery : IQuery<string>
    {
        public Guid Id { get; }

        public ExampleQuery()
        {
            Id = Guid.NewGuid();
        }
    }
}
