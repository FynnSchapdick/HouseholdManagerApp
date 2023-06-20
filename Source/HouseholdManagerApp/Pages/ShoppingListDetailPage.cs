using HouseholdManager.App.Models;
using MauiReactor;

namespace HouseholdManager.App.Pages;

public sealed class ShoppingListDetailPageState
{
    
}

public sealed class ShoppingListDetailPageProps
{
    public ShoppingList ShoppingList { get; set; }
}

public sealed class ShoppingListDetailPage : Component<ShoppingListDetailPageState, ShoppingListDetailPageProps>
{
    public override VisualNode Render()
    {
        return new ContentPage()
        {
            new Label("Welcome to ShoppingListDetailPage")
        }
        .Title(() => Props.ShoppingList.Name);
    }
    

    protected override void OnPropsChanged()
    {
        var blub = Props.ShoppingList;
        base.OnPropsChanged();
    }

    protected override void OnMounted()
    {
        var blub = Props.ShoppingList;
        base.OnMounted();
    }
}