using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListDynamic.Class
{
    public abstract class ToDoList
    {
        public int Type { get; set; }
        public string Message { get; set; }
        public DateTime DateTime { get; set; }
        public string Link { get; set; }
        public ToDoList()
        {

        }
    }
}
