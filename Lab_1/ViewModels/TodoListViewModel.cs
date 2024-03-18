using System.Collections.ObjectModel;
using Lab_1.Models;


namespace Lab_1.ViewModels;

public class TodoListViewModel : ViewModelBase
{
    public LinkedList<ToDoItem> ListItems { get; }

    public TodoListViewModel()
    {
        ListItems = new LinkedList<ToDoItem>();
    }
}