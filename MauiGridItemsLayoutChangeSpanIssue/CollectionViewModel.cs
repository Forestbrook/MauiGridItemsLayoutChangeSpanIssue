namespace MauiGridItemsLayoutChangeSpanIssue;

public class CollectionViewModel
{
    public CollectionViewModel()
    {
        Items = CreateItems().ToList();
    }

    public IList<string> Items { get; }

    private static IEnumerable<string> CreateItems()
    {
        for (var i = 1; i <= 30; i++)
            yield return $"Item {i}";
    }
}