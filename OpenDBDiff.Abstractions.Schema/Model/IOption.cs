namespace OpenDBDiff.Abstractions.Schema.Model
{
    public interface IOption
    {
        IOptionFilter Filters { get; }
        IOptionsContainer<string> Defaults { get; }
        IOptionsContainer<bool> Ignore { get; }
        IOptionsContainer<object> Script { get; }
        IOptionComparison Comparison { get; }

        string Serialize();
    }
    public interface IOptionsContainer<T>
    {
        System.Collections.Generic.IDictionary<string, T> GetOptions();
    }

    public interface IOptionComparison : IOptionsContainer<string>
    {
        bool ReloadComparisonOnUpdate { get; set; }
    }
}
