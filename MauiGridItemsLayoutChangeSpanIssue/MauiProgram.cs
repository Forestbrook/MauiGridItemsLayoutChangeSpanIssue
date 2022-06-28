using MauiGridItemsLayoutChangeSpanIssue.Workaround;

namespace MauiGridItemsLayoutChangeSpanIssue;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder.UseMauiApp<App>();
        builder.ConfigureMauiHandlers(mhc => mhc.AddHandler(typeof(CollectionControl), typeof(CollectionControlHandler)));
		return builder.Build();
	}
}