namespace API
{
    // 11: 57 commit 1205 commit
    public class ExampleQuery : IQuery<string>
    {
        public Guid Id { get; }

        public ExampleQuery()
        {
            Id = Guid.NewGuid();
        }
    }
}
