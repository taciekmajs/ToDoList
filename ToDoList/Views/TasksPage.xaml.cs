namespace ToDoList.Views;

public partial class TasksPage : ContentPage
{
	public TasksPage()
	{
		InitializeComponent();
		List<TaskPlaceHolder> placeholders = new List<TaskPlaceHolder>
		{
			new TaskPlaceHolder() {TaskName = "Zapotrzebowanie kaloryczne", TaskDetails = "Zje�� 3400kcal, w tym mniej ni� 60g cukru i mniej ni� 80g t�uszczu"},
			new TaskPlaceHolder() {TaskName = "Nauka szachowa", TaskDetails = "Nauczy� si� gambitu wiede�skeigo"},
			new TaskPlaceHolder() {TaskName = "Pot�ny riff", TaskDetails = "Napisa� catchy riff, do kt�rego w ko�cu zrobi� �cain�"}
		};
		tasksList.ItemsSource = placeholders;
	}

    private void AddTaskBtn_Clicked(object sender, EventArgs e)
    {

    }

	public class TaskPlaceHolder()
	{
		public string TaskName { get; set; }
		public string? TaskDetails { get; set; }
	}
}