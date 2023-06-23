using System;
using System.Linq;
using HouseholdManagerApp.Models;
using MauiReactor;
using MauiReactor.Canvas;

namespace HouseholdManagerApp.Pages;

public sealed class ShoppingListDetailPageState
{
    public ShoppingListDetail ShoppingListDetail { get; set; }
}

public sealed class ShoppingListDetailPageProps
{
    public Guid ShoppingListId { get; set; }
}

public sealed class ShoppingListDetailPage : Component<ShoppingListDetailPageState, ShoppingListDetailPageProps>
{
    public override VisualNode Render()
    {
        return new ContentPage
            {
                new Grid("8*,92*", "*")
                {
                    new ListPageAppBarComponent()
                        .WithTitle(State.ShoppingListDetail.Name)
                        .WithItemCount(State.ShoppingListDetail.ShoppingListItems.Count())
                        .WithBackButton()
                        .GridRow(0),

                    new CollectionView()
                        .ItemsSource(State.ShoppingListDetail.ShoppingListItems, RenderShoppingListItem)
                        .ItemsLayout(new VerticalLinearItemsLayout().ItemSpacing(5))
                        .GridRow(1)
                        .Margin(10)
                }
            }
            .Set(MauiControls.NavigationPage.HasNavigationBarProperty, false);
    }

    private VisualNode RenderShoppingListItem(ShoppingListItem shoppingListItem)
        => new ShoppingListItemComponent()
            .ShoppingListItem(shoppingListItem);

    protected override void OnMounted()
    {
        // This would be an Api-Call in future
        State.ShoppingListDetail = ShoppingListDetail.FromHead(Props.ShoppingListId);
        base.OnMounted();
    }
}