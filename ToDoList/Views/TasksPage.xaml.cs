using ToDoList.Models;

namespace ToDoList.Views;

public partial class TasksPage : ContentPage
{
	public TasksPage()
	{
		InitializeComponent();
		List<Assignment> placeholders = new List<Assignment>
		{
			new Assignment() {Id = 1, Name = "Zapotrzebowanie kaloryczne", Details = "Zjeœæ 3400kcal, w tym mniej ni¿ 60g cukru i mniej ni¿ 80g t³uszczu", IsCompleted = false},
			new Assignment() {Id = 2, Name = "Nauka szachowa", Details = "Nauczyæ siê gambitu wiedeñskeigo", IsCompleted = true},
			new Assignment() {Id = 3, Name = "Potê¿ny riff", Details = "Napisaæ catchy riff, do którego w koñcu zrobi¹ œcainê", IsCompleted = false}
		};
		tasksList.ItemsSource = placeholders;
	}

    private void AddTaskBtn_Clicked(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync(nameof(AddTaskPage));
    }
}