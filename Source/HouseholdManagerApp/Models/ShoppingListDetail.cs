using System;
using System.Collections.Generic;
using System.Linq;

namespace HouseholdManagerApp.Models;

public record ShoppingListDetail(Guid ShoppingListId, string Name, IEnumerable<ShoppingListItem> ShoppingListItems)
{
    public static ShoppingListDetail FromHead(Guid shoppingListId)
    {
        ShoppingListHead shoppingListHead = ShoppingListHead.Items.Single(x => x.ShoppingListId == shoppingListId);
        return new ShoppingListDetail(shoppingListHead.ShoppingListId, shoppingListHead.Name, ShoppingListItem.Items);
    }
}