using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFlow.Core
{
    internal class TaskItem
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Status { get; set; } = "To Do";
        public string Priority { get; set; } = "Medium";
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime TimeLeft {  get; set; } 
        public DateTime? DeadLine { get; set; }
    }
}
