using ToDoList.Models;
using ToDoList.Repositories;

namespace ToDoList.Views;

public partial class TasksPage : ContentPage
{
    public TasksPage()
    {
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        LoadAssignments(); 
    }

    private void LoadAssignments()
    {
        List<Assignment> assignments = AssignmentRepository.GetAllAssignments();
        tasksList.ItemsSource = assignments;
    }

    private void AddTaskBtn_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(AddAssignmentPage));
    }
}