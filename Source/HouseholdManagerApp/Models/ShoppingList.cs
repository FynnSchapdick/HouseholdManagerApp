using System;
using System.Collections.ObjectModel;

namespace HouseholdManager.App.Models;

public record ShoppingList(Guid ShoppingListId, string Name)
{
    public static ObservableCollection<ShoppingList> Items { get; } = new ObservableCollection<ShoppingList>(new[]
    {
        new ShoppingList(ShoppingListId: Guid.NewGuid(), Name: "Rewe Einkaufsliste"),
        new ShoppingList(ShoppingListId: Guid.NewGuid(), Name: "Famila Einkaufsliste"),
        new ShoppingList(ShoppingListId: Guid.NewGuid(), Name: "Baumarkt Einkaufsliste"),
        new ShoppingList(ShoppingListId: Guid.NewGuid(), Name: "Apotheke Einkaufsliste"),
        new ShoppingList(ShoppingListId: Guid.NewGuid(), Name: "Sontiges Einkaufsliste"),
        new ShoppingList(ShoppingListId: Guid.NewGuid(), Name: "Omas Einkaufsliste"),
        new ShoppingList(ShoppingListId: Guid.NewGuid(), Name: "Rewe Einkaufsliste"),
        new ShoppingList(ShoppingListId: Guid.NewGuid(), Name: "Famila Einkaufsliste"),
        new ShoppingList(ShoppingListId: Guid.NewGuid(), Name: "Baumarkt Einkaufsliste"),
        new ShoppingList(ShoppingListId: Guid.NewGuid(), Name: "Apotheke Einkaufsliste"),
        new ShoppingList(ShoppingListId: Guid.NewGuid(), Name: "Sontiges Einkaufsliste"),
        new ShoppingList(ShoppingListId: Guid.NewGuid(), Name: "Omas Einkaufsliste")
    });
}