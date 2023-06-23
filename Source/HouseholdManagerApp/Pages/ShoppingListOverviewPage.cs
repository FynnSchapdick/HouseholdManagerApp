using System;
using System.Collections.Generic;
using System.Linq;
using HouseholdManagerApp.Models;
using MauiReactor;
using MauiReactor.Parameters;
using Microsoft.Maui.Layouts;

namespace HouseholdManagerApp.Pages;

public class ShoppingListOverviewPageState
{
    public Guid? SelectedShoppingListId { get; set; }
    public IEnumerable<ShoppingListHead> ShoppingLists { get; set; } = Enumerable.Empty<ShoppingListHead>();
}

public class ShoppingListOverviewPage : Component<ShoppingListOverviewPageState>
{
    private readonly IParameter<ActionMenuOverlayComponentState> _actionMenuOverlayComponent;

    public ShoppingListOverviewPage()
    {
        _actionMenuOverlayComponent = CreateParameter<ActionMenuOverlayComponentState>();
    }
    
    public override VisualNode Render()
    {
        return new NavigationPage
        {
            new ContentPage
            {
                new AbsoluteLayout
                {
                    new FloatingActionButtonComponent(),
                    
                    new ActionMenuOverlayComponent(),

                    new Grid("8*,92*", "*")
                    {
                        new ListPageAppBarComponent()
                            .WithTitle("ShoppingLists")
                            .WithItemCount(State.ShoppingLists.Count())
                            .GridRow(0),

                        new CollectionView()
                            .ItemsSource(ShoppingListHead.Items, RenderShoppingListOverviewItem)
                            .ItemsLayout(new VerticalLinearItemsLayout().ItemSpacing(5))
                            .Margin(10)
                            .GridRow(1),
                    }
                    .AbsoluteLayoutBounds(0,0,1,1)
                    .AbsoluteLayoutFlags(AbsoluteLayoutFlags.All)
                }
            }
            .Set(MauiControls.NavigationPage.HasNavigationBarProperty, false)
        };
    }

    protected override void OnMounted()
    {
        SetState(x => x.ShoppingLists = ShoppingListHead.Items);
        base.OnMounted();
    }

    private VisualNode RenderShoppingListOverviewItem(ShoppingListHead shoppingList)
        => new ShoppingListOverviewItemComponent()
            .ShoppingList(shoppingList)
            .OnSelected(() => OnShoppingListSelected(shoppingList));

    private async void OnShoppingListSelected(ShoppingListHead shoppingList)
    {
        SetState(s => s.SelectedShoppingListId = shoppingList.ShoppingListId);

        if (Navigation is null)
        {
            return;
        }

        await Navigation.PushAsync<ShoppingListDetailPage, ShoppingListDetailPageProps>(props =>
            props.ShoppingListId = shoppingList.ShoppingListId);
    }
}