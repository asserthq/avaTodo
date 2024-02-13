using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using avaTodo.Services;
using System;

namespace avaTodo.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        [ObservableProperty]
        private ViewModelBase contentViewModel;

        public MainWindowViewModel() 
        {
            var service = new TodoListService();
            TodoList = new TodoListViewModel(service.GetItems());
            contentViewModel = TodoList;
        }

        public TodoListViewModel TodoList { get; }

        [RelayCommand]
        public void AddItem()
        {
            ContentViewModel = new AddItemViewModel();


        }

        //[RelayCommand]
        //public void AddItem()
        //{
        //    AddItemViewModel addItemViewModel = new();

        //    Observable.Merge(
        //        addItemViewModel.ApplyAddingCommand,
        //        addItemViewModel.CancelAddingCommand.Select(_ => (TodoItem?)null))
        //        .Take(1)
        //        .Subscribe(newItem =>
        //        {
        //            if (newItem != null)
        //            {
        //                ToDoList.ListItems.Add(newItem);
        //            }
        //            ContentViewModel = ToDoList;
        //        });

        //    TodoList.ListItems.Add(newItem);

        //    ContentViewModel = addItemViewModel;
        //}
    }
}
