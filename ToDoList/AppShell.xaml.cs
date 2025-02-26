using ToDoList.Views;

namespace ToDoList
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(AssignmentsPage), typeof(AssignmentsPage));
            Routing.RegisterRoute(nameof(AddAssignmentPage), typeof(AddAssignmentPage));
        }
    }
}
