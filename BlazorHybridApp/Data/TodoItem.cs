using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorHybridApp.Data
{
    class TodoItem
    {
        public string? Title { get; set; }
        public bool isDone { get; set; } = false;
    }
}
