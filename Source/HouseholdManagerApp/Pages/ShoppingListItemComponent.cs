using HouseholdManagerApp.Models;
using MauiReactor;

namespace HouseholdManagerApp.Pages;

public sealed class ShoppingListItemComponent : Component
{
    private ShoppingListItem _shoppingListItem;

    public ShoppingListItemComponent ShoppingListItem(ShoppingListItem shoppingList)
    {
        _shoppingListItem = shoppingList;
        return this;
    }

    public override VisualNode Render()
    {
        return new Frame
        {
            new Grid("*", "15*, 60*, 25*")
            {
                new CheckBox()
                    .GridColumn(0)
                    .VCenter()
                    .HStart(),
                new Label(_shoppingListItem.Name)
                    .GridColumn(1)
                    .TextColor(Colors.Black)
                    .FontSize(16)
                    .VCenter(),
                new Label(FormatItemAmount(_shoppingListItem.Amount))
                    .GridColumn(2)
                    .TextColor(Colors.Black)
                    .FontSize(16)
                    .VCenter()
                    .HEnd()
            }
        }
        .BackgroundColor(Colors.Azure);
    }
    
    private string FormatItemAmount(int amount) => amount switch
    {
        _ => $"{amount} pcs."
    };
}