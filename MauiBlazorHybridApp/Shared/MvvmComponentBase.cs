using MauiBlazorHybridApp.ViewModel;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiBlazorHybridApp.Shared
{
    public abstract class MvvmComponentBase<TViewModel> : ComponentBase
    where TViewModel : IViewModelBase
    {
        [Inject]
        [NotNull]
#pragma warning disable CS8618
        protected TViewModel ViewModel { get; set; }
#pragma warning restore CS8618

        protected override void OnInitialized()
        {
            // Cause changes to the ViewModel to make Blazor re-render
            ViewModel.PropertyChanged += (_, _) => StateHasChanged();
            base.OnInitialized();
        }

        protected override Task OnInitializedAsync()
        {
            return ViewModel.OnInitializedAsync();
        }
    }
}
