using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToDoList.Models
{
    public class Assignment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Details { get; set; }
        public bool IsCompleted { get; set; }
    }
}
