using MauiReactor;

namespace HouseholdManagerApp.Pages;

public sealed class ListPageAppBarComponent : Component
{
    private string _title;
    private int _itemCount;
    private bool _isBackButtonVisible;

    public ListPageAppBarComponent WithTitle(string title)
    {
        _title = title;
        return this;
    }

    public ListPageAppBarComponent WithItemCount(int itemCount)
    {
        _itemCount = itemCount;
        return this;
    }
    
    public ListPageAppBarComponent WithBackButton(bool enabled = true)
    {
        _isBackButtonVisible = enabled;
        return this;
    }

    public override VisualNode Render()
    {
        return new Grid("*", "7*,3*")
        {
            new HorizontalStackLayout(10)
            {
                new ImageButton("arrow_left")
                    .VCenter()
                    .IsVisible(_isBackButtonVisible)
                    .OnClicked(OnBack),

                new VerticalStackLayout
                    {
                        new Label(_title)
                            .VCenter()
                            .FontSize(20)
                            .TextColor(Colors.White),

                        new Label(FormatItemCountDescription(_itemCount))
                            .VCenter()
                            .FontSize(14)
                            .TextColor(Colors.White)
                    }
                    .VCenter()
                    .HStart(),
            }
                .Margin(10)
                .GridColumn(0),

            new ImageButton("three_dots")
                .VCenter()
                .HEnd()
                .Margin(10)
                .GridColumn(1)
        }
        .BackgroundColor(Color.FromArgb("2B0B98"));
    }

    private string FormatItemCountDescription(int itemCount) => itemCount switch
    {
        1 => $"{itemCount} item",
        _ => $"{itemCount} items"
    };
    
    private async void OnBack()
    {
        if (Navigation is null || Navigation.NavigationStack.Count <= 0)
        {
            return;
        }
        
        await Navigation.PopAsync(false);
    }
}