using ToDoList.Models;
using ToDoList.Repositories;

namespace ToDoList.Views;

public partial class TasksPage : ContentPage
{
	public TasksPage()
	{
		InitializeComponent();
		List<Assignment> placeholders = AssignmentRepository.GetAllAssignments();
		tasksList.ItemsSource = placeholders;
	}

    private void AddTaskBtn_Clicked(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync(nameof(AddTaskPage));
    }
}