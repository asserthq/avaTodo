using avaTodo.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Diagnostics;
using System.Windows.Input;

namespace avaTodo.ViewModels
{
    public partial class AddItemViewModel : ViewModelBase
    {
        [ObservableProperty]
        private string description = String.Empty;

        [RelayCommand]
        public void ApplyAdding()
        {
            var isValid = !(string.IsNullOrEmpty(Description) || string.IsNullOrWhiteSpace(Description));
            if (isValid)
            {
                new TodoItem { Description = Description };
            }
            Debug.WriteLine($"Apply Adding {Description}");
        }

        [RelayCommand]
        public void CancelAdding()
        {
            Debug.WriteLine("Cancel Adding");
        }
    }
}
