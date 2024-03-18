
using System;
using System.Linq;
using System.Reactive.Linq;
using Lab_1.Models;
using ReactiveUI;

namespace Lab_1.ViewModels;

public class MainWindowViewModel : ViewModelBase
{ 

    public TodoListViewModel TodoList { get; }
    private ViewModelBase _contentViewModel;

    public MainWindowViewModel()
    {
        TodoList = new TodoListViewModel();
        _contentViewModel = TodoList;
    }

    public ViewModelBase ContentViewModel
    {
        get => _contentViewModel;
        private set => this.RaiseAndSetIfChanged(ref _contentViewModel, value);
    }

    public void AddItem()
    {
        AddItemViewModel addItemViewModel = new();
        Observable.Merge(
                addItemViewModel.OkCommand,
                addItemViewModel.CancelCommand.Select(_ => (ToDoItem?)null))
            .Take(1)
            .Subscribe(newItem =>
            {
                if (newItem is not null)
                {
                    TodoList.ListItems.Append(newItem);
                }

                ContentViewModel = TodoList;
            });
        ContentViewModel = addItemViewModel;
    }
    
    public void RemoveItem()
    {
        if (TodoList.ListItems.Length > 0)
        {
            TodoList.ListItems.Remove(TodoList.ListItems.Get(TodoList.ListItems.Length - 1));
        }
    }
    
    public void ClearItems()
    {
        TodoList.ListItems.Clear();
    }
    
}