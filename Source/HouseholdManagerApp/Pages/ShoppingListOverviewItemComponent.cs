using System;
using HouseholdManagerApp.Models;
using MauiReactor;

namespace HouseholdManagerApp.Pages;

public sealed class ShoppingListOverviewItemComponent : Component
{
    private ShoppingListHead _shoppingList;
    private Action _onSelectedAction;

    public ShoppingListOverviewItemComponent ShoppingList(ShoppingListHead shoppingList)
    {
        _shoppingList = shoppingList;
        return this;
    }

    public ShoppingListOverviewItemComponent OnSelected(Action action)
    {
        _onSelectedAction = action;
        return this;
    }

    public override VisualNode Render()
    {
        return new Frame
        {
            new Label(_shoppingList.Name)
                .VCenter()
                .HCenter()
                .FontSize(16)
                .TextColor(Colors.Black)
        }
        .BackgroundColor(Colors.Azure)
        .OnTapped(_onSelectedAction);
    }
}