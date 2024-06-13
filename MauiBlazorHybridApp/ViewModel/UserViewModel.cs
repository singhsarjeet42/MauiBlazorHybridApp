using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiBlazorHybridApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiBlazorHybridApp.ViewModel
{
    public partial class UserViewModel : UserModel
    {
        public UserViewModel() { }
        [ObservableProperty]
        public string? _name;

        [ObservableProperty]
        public string? _email;

        [RelayCommand]
        public async Task buttonClickCommand()
        {
            IsActive = true;
        }
        [RelayCommand]
        public async Task<string> getData()
        {
            Name = "SARJEET"; 
            return Name;
        }
        [RelayCommand]
        public async Task Clear()
        {
            Name = string.Empty;
            IsActive = false;
        }

    }
}
