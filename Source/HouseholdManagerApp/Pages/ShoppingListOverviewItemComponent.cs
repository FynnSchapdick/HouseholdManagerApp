using System;
using HouseholdManager.App.Models;
using MauiReactor;

namespace HouseholdManager.App.Pages;

public sealed class ShoppingListOverviewItemComponent : Component
{
    private ShoppingList _shoppingList;
    private Action _onSelectedAction;

    public ShoppingListOverviewItemComponent ShoppingList(ShoppingList shoppingList)
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
        }
        .BackgroundColor(Colors.Azure)
        .OnTapped(_onSelectedAction);
    }
}