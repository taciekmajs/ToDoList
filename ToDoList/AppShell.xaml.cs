using ToDoList.Views;

namespace ToDoList
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(TasksPage), typeof(TasksPage));
            Routing.RegisterRoute(nameof(AddTaskPage), typeof(AddTaskPage));
        }
    }
}
