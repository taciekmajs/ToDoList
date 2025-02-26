using ToDoList.Models;

namespace ToDoList.Views;

public partial class TasksPage : ContentPage
{
	public TasksPage()
	{
		InitializeComponent();
		List<Assignment> placeholders = new List<Assignment>
		{
			new Assignment() {Id = 1, Name = "Zapotrzebowanie kaloryczne", Details = "Zje�� 3400kcal, w tym mniej ni� 60g cukru i mniej ni� 80g t�uszczu", IsCompleted = false},
			new Assignment() {Id = 2, Name = "Nauka szachowa", Details = "Nauczy� si� gambitu wiede�skeigo", IsCompleted = true},
			new Assignment() {Id = 3, Name = "Pot�ny riff", Details = "Napisa� catchy riff, do kt�rego w ko�cu zrobi� �cain�", IsCompleted = false}
		};
		tasksList.ItemsSource = placeholders;
	}

    private void AddTaskBtn_Clicked(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync(nameof(AddTaskPage));
    }
}