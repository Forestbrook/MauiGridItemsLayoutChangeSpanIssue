using Microsoft.Maui.Controls.Handlers.Items;
using System.ComponentModel;

namespace MauiGridItemsLayoutChangeSpanIssue.Workaround;

public class GridViewLayoutExt : GridViewLayout
{
    public GridViewLayoutExt(GridItemsLayout itemsLayout, ItemSizingStrategy itemSizingStrategy)
        : base(itemsLayout, itemSizingStrategy)
    { }

    protected override void HandlePropertyChanged(PropertyChangedEventArgs propertyChanged)
    {
        if (propertyChanged.PropertyName == GridItemsLayout.SpanProperty.PropertyName || propertyChanged.PropertyName == GridItemsLayout.HorizontalItemSpacingProperty.PropertyName || propertyChanged.PropertyName == GridItemsLayout.VerticalItemSpacingProperty.PropertyName)
        {
            // Workaround for bug:
            if (CollectionView == null)
                return;
        }

        base.HandlePropertyChanged(propertyChanged);
    }
}