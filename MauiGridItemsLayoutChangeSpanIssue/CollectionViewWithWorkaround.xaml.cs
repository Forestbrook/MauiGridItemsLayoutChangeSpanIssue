namespace MauiGridItemsLayoutChangeSpanIssue;

public partial class CollectionViewWithWorkaround : ContentPage
{
    private const int ItemWidth = 120;
    private const int ItemSpacing = 10;
    private const int MaxSpan = 8;
    private const int MinSpan = 2;
    private readonly GridItemsLayout _itemsLayout;

	public CollectionViewWithWorkaround()
	{
		InitializeComponent();
        BindingContext = new CollectionViewModel();
        _collectionView.SizeChanged += OnSizeChanged;
        _itemsLayout = (GridItemsLayout)_collectionView.ItemsLayout;
	}

    private void OnSizeChanged(object sender, EventArgs e)
    {
        var bounds = _collectionView.Bounds;
        var span = (int)(1 + (bounds.Width - ItemWidth) / (ItemWidth + ItemSpacing));
        if (span < MinSpan)
            span = MinSpan;
        else if (span > MaxSpan)
            span = MaxSpan;

        if (_itemsLayout.Span != span)
            Test(span);
    }

    private async void Test(int span)
    {
#if ANDROID
        await Task.Delay(100);
#else
        await Task.CompletedTask;
#endif
        _itemsLayout.Span = span;
    }
}