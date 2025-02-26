using ToDoList.Models;
using ToDoList.Repositories;

namespace ToDoList.Views
{
    public partial class AddAssignmentPage : ContentPage
    {

        public AddAssignmentPage()
        {
            InitializeComponent();
        }

        private void btnAddAssignment_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AssignmentName.Text))
            {
                DisplayAlert("Error", "Assignment title cannot be empty!", "OK");
                return;
            }

            var newAssignment = new Assignment
            {
                Name = AssignmentName.Text,
                Details = AssignmentDetails.Text ?? string.Empty,
                IsCompleted = false
            };
            
            AssignmentRepository.AddAssignment(newAssignment);
            DisplayAlert("Success", "Assignment added!", "OK");
            Navigation.PopAsync(); 
        }
    }
}