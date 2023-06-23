using System;
using System.Linq;
using HouseholdManagerApp.Models;
using MauiReactor;
using MauiReactor.Canvas;
using MauiReactor.Parameters;

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
    private readonly IParameter<ActionMenuOverlayParameters> _parameter;

    public ShoppingListDetailPage()
    {
        _parameter = CreateParameter<ActionMenuOverlayParameters>();
    }

    public override VisualNode Render()
    {
        return new ContentPage
            {
                new Grid("8*,92*", "*")
                {
                    new ListPageAppBar()
                        .WithTitle(State.ShoppingListDetail.Name)
                        .WithItemCount(State.ShoppingListDetail.ShoppingListItems.Count())
                        .WithBackButton()
                        .WithMenuButton()
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
