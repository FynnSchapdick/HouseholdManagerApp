using System;
using HouseholdManager.App.Models;
using MauiReactor;

namespace HouseholdManager.App.Pages;

public class ShoppingListOverviewPageState
{
    public Guid? SelectedShoppingListId { get; set; }
}

public class ShoppingListOverviewPage : Component<ShoppingListOverviewPageState>
{
    public override VisualNode Render()
    {
        return new ContentPage("ShoppingLists")
        {
            new ScrollView
            {
                new VerticalStackLayout(2)
                {
                    new CollectionView()
                        .ItemsSource(ShoppingList.Items, RenderShoppingListOverviewItem)
                        .ItemsLayout(new VerticalLinearItemsLayout().ItemSpacing(10))
                        .Margin(24, 20)
                }
            }
        };
    }
    
    protected override void OnMounted()
    {
        Routing.RegisterRoute<ShoppingListDetailPage>("shoppinglistdetailpage");
        base.OnMounted();
    }

    private VisualNode RenderShoppingListOverviewItem(ShoppingList shoppingList)
        => new ShoppingListOverviewItemComponent()
            .ShoppingList(shoppingList)
            .OnSelected(() => OnShoppingListSelected(shoppingList));

    private async void OnShoppingListSelected(ShoppingList shoppingList)
    {
        SetState(s =>
        {
            s.SelectedShoppingListId = shoppingList.ShoppingListId;
        });

        await MauiControls.Shell.Current.GoToAsync<ShoppingListDetailPageProps>("shoppinglistdetailpage",
            props => props.ShoppingList = shoppingList);
       
    }
}