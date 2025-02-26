using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using ToDoList.Models;

namespace ToDoList.Repositories
{
    public static class AssignmentRepository
    {
        private const string AssignmentKey = "assignment";

        public static List<Assignment> GetAllAssignments()
        {
            string json = Preferences.Get(AssignmentKey, "[]");
            return JsonSerializer.Deserialize<List<Assignment>>(json) ?? new List<Assignment>();
        }

        public static void SaveAssignments(List<Assignment> assignments)
        {
            string json = JsonSerializer.Serialize(assignments);
            Preferences.Set(AssignmentKey, json);
        }

        public static void AddAssignment(Assignment assignment)
        {
            var assignments = GetAllAssignments();
            assignments.Add(assignment);
            SaveAssignments(assignments);
        }

        public static void RemoveAssignment(int assignmentId)
        {
            var assignments = GetAllAssignments().Where(t => t.Id != assignmentId).ToList();
            SaveAssignments(assignments);
        }

        public static void ToggleAssignmentStatus(int assignmentId)
        {
            var assignments = GetAllAssignments();
            var assignment = assignments.FirstOrDefault(t => t.Id == assignmentId);
            if (assignment != null)
            {
                assignment.IsCompleted = !assignment.IsCompleted;
                SaveAssignments(assignments);
            }
        }

    }
}
