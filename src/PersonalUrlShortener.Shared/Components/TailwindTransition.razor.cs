﻿using Microsoft.AspNetCore.Components;

namespace PersonalUrlShortener.Shared.Components;

public partial class TailwindTransition : TailwindTransitionalComponentBase
{
    [CascadingParameter] public TailwindTransitionalElement Parent { get; set; }

    public async Task Toggle()
    {
        await InvokeAsync(async () =>
        {
            if (Parent.IsOpened)
                await ShowAsync();
            else
                await HideAsync();
        });
    }

    protected override void OnInitialized()
    {
        //Console.WriteLine("Initialized" + GetHashCode());
        Parent.AddTransition(this);
    }
}