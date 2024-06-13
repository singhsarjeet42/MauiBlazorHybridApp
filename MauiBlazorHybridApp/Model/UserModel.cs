using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiBlazorHybridApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiBlazorHybridApp.Model
{
    public abstract partial class UserModel : ObservableObject, IViewModelBase
    {
        [ObservableProperty]
        public bool _isActive;

        [RelayCommand]
        public virtual async Task Loaded()
        {
            await Task.CompletedTask.ConfigureAwait(false);
        }

        public virtual async Task OnInitializedAsync()
        {
            await Loaded().ConfigureAwait(true);
        }
    }
}
