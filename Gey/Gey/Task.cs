using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gey
{
    public class Task
    {
        [Key]
        public int Id { get; set; }

        public string Description { get; set; }

        public bool IsCompleted { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }

        
        [NotMapped]
        public string Status => IsCompleted ? "Completed" : "Pending";
    }
}
