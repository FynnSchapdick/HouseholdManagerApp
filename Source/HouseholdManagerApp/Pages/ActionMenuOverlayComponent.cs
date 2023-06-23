using System;
using MauiReactor;
using MauiReactor.Parameters;
using Microsoft.Maui.Layouts;

namespace HouseholdManagerApp.Pages;

public sealed class ActionMenuOverlayComponentState
{
    public bool IsVisible { get; set; }
}

public sealed class ActionMenuOverlayComponent : Component
{
    public override VisualNode Render()
    {
        var parameter = GetParameter<ActionMenuOverlayComponentState>();
        
        return new ContentView
        {
            new Grid("2*,5*", "3*,2*")
            {
                new BoxView()
                    .GridColumn(1)
                    .Color(Colors.Red)
                    .OnTapped(OnBoxViewTapped)

            }
            .OnTapped(OnGridTapped)
            .BackgroundColor(Colors.Transparent)
        }
        .AbsoluteLayoutFlags(AbsoluteLayoutFlags.SizeProportional)
        .AbsoluteLayoutBounds(0,0,1,1)
        .IsVisible(parameter.Value.IsVisible)
        .ZIndex(25);
    }

    private void OnGridTapped()
    {
        System.Diagnostics.Debug.WriteLine("Grid tapped");
    }
    
    private void OnBoxViewTapped()
    {
        System.Diagnostics.Debug.WriteLine("Boxview tapped");
    }
}