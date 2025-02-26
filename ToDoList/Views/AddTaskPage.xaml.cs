namespace ToDoList.Views;

public partial class AddTaskPage : ContentPage
{
	public AddTaskPage()
	{
		InitializeComponent();
	}

    private void btnAddTask_Clicked(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync("..");
    }
}