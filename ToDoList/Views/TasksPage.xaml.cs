namespace ToDoList.Views;

public partial class TasksPage : ContentPage
{
	public TasksPage()
	{
		InitializeComponent();
		List<TaskPlaceHolder> placeholders = new List<TaskPlaceHolder>
		{
			new TaskPlaceHolder() {TaskName = "Zapotrzebowanie kaloryczne", TaskDetails = "Zjeœæ 3400kcal, w tym mniej ni¿ 60g cukru i mniej ni¿ 80g t³uszczu"},
			new TaskPlaceHolder() {TaskName = "Nauka szachowa", TaskDetails = "Nauczyæ siê gambitu wiedeñskeigo"},
			new TaskPlaceHolder() {TaskName = "Potê¿ny riff", TaskDetails = "Napisaæ catchy riff, do którego w koñcu zrobi¹ œcainê"}
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