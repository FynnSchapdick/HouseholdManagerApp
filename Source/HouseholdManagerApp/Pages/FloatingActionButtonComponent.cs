using System;
using MauiReactor;
using Microsoft.Maui.Layouts;

namespace HouseholdManagerApp.Pages;

public sealed class FloatingActionButtonComponent : Component
{
    private string _buttonText = "+";
    private Color _backgroundColor = Color.FromArgb("2B0B98");
    private Action _onClicked = () => { };

    public FloatingActionButtonComponent WithText(string text)
    {
        _buttonText = text;
        return this;
    }

    public FloatingActionButtonComponent WithBackgroundColor(Color color)
    {
        _backgroundColor = color;
        return this;
    }

    public FloatingActionButtonComponent OnClicked(Action onClicked)
    {
        _onClicked = onClicked;
        return this;
    }

    public override VisualNode Render()
    {
        return new ContentView
        {
            new Button()
                .Text(_buttonText)
                .CornerRadius(30)
                .HeightRequest(60)
                .WidthRequest(60)
                .FontSize(30)
                .BackgroundColor(_backgroundColor)
                .Shadow(new Shadow()
                    .Brush(MauiControls.Brush.Black)
                    .Offset(4, 4)
                    .Radius(10)
                    .Opacity(.5f))
                .OnClicked(_onClicked)
        }
        .AbsoluteLayoutBounds(1, 1, 100, 100)
        .AbsoluteLayoutFlags(AbsoluteLayoutFlags.PositionProportional)
        .ZIndex(100);
    }
}