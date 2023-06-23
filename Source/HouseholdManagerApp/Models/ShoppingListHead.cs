using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace HouseholdManagerApp.Models;

public record ShoppingListHead(Guid ShoppingListId, string Name)
{
    public static ObservableCollection<ShoppingListHead> Items { get; } = new(new[]
    {
        new ShoppingListHead(ShoppingListId: Guid.NewGuid(), Name: "Rewe Einkaufsliste"),
        new ShoppingListHead(ShoppingListId: Guid.NewGuid(), Name: "Famila Einkaufsliste"),
        new ShoppingListHead(ShoppingListId: Guid.NewGuid(), Name: "Baumarkt Einkaufsliste"),
        new ShoppingListHead(ShoppingListId: Guid.NewGuid(), Name: "Apotheke Einkaufsliste"),
        new ShoppingListHead(ShoppingListId: Guid.NewGuid(), Name: "Sontiges Einkaufsliste"),
        new ShoppingListHead(ShoppingListId: Guid.NewGuid(), Name: "Omas Einkaufsliste"),
        new ShoppingListHead(ShoppingListId: Guid.NewGuid(), Name: "Rewe Einkaufsliste"),
        new ShoppingListHead(ShoppingListId: Guid.NewGuid(), Name: "Famila Einkaufsliste"),
        new ShoppingListHead(ShoppingListId: Guid.NewGuid(), Name: "Baumarkt Einkaufsliste"),
        new ShoppingListHead(ShoppingListId: Guid.NewGuid(), Name: "Apotheke Einkaufsliste"),
        new ShoppingListHead(ShoppingListId: Guid.NewGuid(), Name: "Sontiges Einkaufsliste"),
        new ShoppingListHead(ShoppingListId: Guid.NewGuid(), Name: "Omas Einkaufsliste")
    });
}