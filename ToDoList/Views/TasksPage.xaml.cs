using ToDoList.Models;
using ToDoList.Repositories;
using System.Collections.Generic;

namespace ToDoList.Views;

public partial class AssignmentsPage : ContentPage
{

    public AssignmentsPage()
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
        assignmentsList.ItemsSource = assignments;
    }

    private void OnAssignmentDone(object sender, EventArgs e)
    {
        if (sender is Button button && button.CommandParameter is int assignmentId)
        {
            AssignmentRepository.ToggleAssignmentStatus(assignmentId);
            LoadAssignments();
        }
    }

    private void OnAssignmentRemoved(object sender, EventArgs e)
    {
        if (sender is Button button && button.CommandParameter is int assignmentId)
        {
            AssignmentRepository.RemoveAssignment(assignmentId);
            LoadAssignments();
        }
    }

    private void AddAssignmentBtn_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(AddAssignmentPage));
    }
}