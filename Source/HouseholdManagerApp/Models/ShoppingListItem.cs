using System;
using System.Collections.ObjectModel;

namespace HouseholdManagerApp.Models;

public sealed record ShoppingListItem(Guid ProductId, string Name, int Amount)
{
    public static ObservableCollection<ShoppingListItem> Items { get; } = new(new[]
    {
        new ShoppingListItem(ProductId: Guid.NewGuid(), Name: "Omas Apfelkuchen", Amount: 9999),
        new ShoppingListItem(ProductId: Guid.NewGuid(), Name: "Omas Käsekuchen", Amount: 999),
        new ShoppingListItem(ProductId: Guid.NewGuid(), Name: "Omas Schinken", Amount: 99),
        new ShoppingListItem(ProductId: Guid.NewGuid(), Name: "Omas Apfelsaft", Amount: 4),
        new ShoppingListItem(ProductId: Guid.NewGuid(), Name: "Omas Apfelsaft", Amount: 4),
        new ShoppingListItem(ProductId: Guid.NewGuid(), Name: "Omas Apfelsaft", Amount: 4),
        new ShoppingListItem(ProductId: Guid.NewGuid(), Name: "Omas Apfelsaft", Amount: 4),
        new ShoppingListItem(ProductId: Guid.NewGuid(), Name: "Omas Apfelsaft", Amount: 4),
        new ShoppingListItem(ProductId: Guid.NewGuid(), Name: "Omas Apfelsaft", Amount: 4),
        new ShoppingListItem(ProductId: Guid.NewGuid(), Name: "Omas Apfelsaft", Amount: 4),
        new ShoppingListItem(ProductId: Guid.NewGuid(), Name: "Omas Apfelsaft", Amount: 4),
        new ShoppingListItem(ProductId: Guid.NewGuid(), Name: "Omas Apfelsaft", Amount: 4),
        new ShoppingListItem(ProductId: Guid.NewGuid(), Name: "Omas Apfelsaft", Amount: 1),
        new ShoppingListItem(ProductId: Guid.NewGuid(), Name: "Omas Apfelsaft", Amount: 4),
        new ShoppingListItem(ProductId: Guid.NewGuid(), Name: "Omas Apfelsaft", Amount: 4),
        new ShoppingListItem(ProductId: Guid.NewGuid(), Name: "Omas Apfelsaft", Amount: 4),
        new ShoppingListItem(ProductId: Guid.NewGuid(), Name: "Omas Apfelsaft", Amount: 4),
        new ShoppingListItem(ProductId: Guid.NewGuid(), Name: "Omas Apfelsaft", Amount: 4),
        new ShoppingListItem(ProductId: Guid.NewGuid(), Name: "Omas Apfelsaft", Amount: 4),
        new ShoppingListItem(ProductId: Guid.NewGuid(), Name: "Omas Apfelsaft", Amount: 1),
    });
}