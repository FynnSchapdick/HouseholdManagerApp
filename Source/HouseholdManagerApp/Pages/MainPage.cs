using MauiReactor;

namespace HouseholdManagerApp.Pages;

public sealed class MainPage : Component
{
    public override VisualNode Render()
    {
        return new Shell
        {
            new FlyoutItem("ShoppingListOverViewPage")
            {
                new ShellContent()
                    .RenderContent(() => new ShoppingListOverviewPage())
            }
        }
        .ItemTemplate(RenderItemTemplate);
    }
    
    private static VisualNode RenderItemTemplate(MauiControls.BaseShellItem item)
        => new Grid("68", "*")
        {
            new Label(item.Title)
                .VCenter()
                .Margin(10,0)
        };
}