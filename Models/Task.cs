using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManager.Models
{
    public class Task
    {
        public int ID { get; set; }
        [Display(Name ="Nazwa")]
        public string TaskName { get; set; }
        [Display(Name ="Data")]
        public DateTime Date { get; set; }
        [Display(Name ="Czy zakończone?")]
        public bool IsDone { get; set; }

    }
}
