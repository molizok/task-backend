using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tasks_backend
{
    public class Task
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }
    }
}
