using Microsoft.Maui.Controls.Handlers.Items;

namespace MauiGridItemsLayoutChangeSpanIssue.Workaround;

public partial class CollectionControlHandler : CollectionViewHandler
{
    protected override ItemsViewLayout SelectLayout()
    {
        if (ItemsView.ItemsLayout is GridItemsLayout gridItemsLayout)
            return new GridViewLayoutExt(gridItemsLayout, ItemsView.ItemSizingStrategy);

        return base.SelectLayout();
    }
}