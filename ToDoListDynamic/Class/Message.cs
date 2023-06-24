using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListDynamic.Class
{
    public class Message : ToDoItem
    {
        public Message(int type) : base()
        {
            Type = type;
            TaskName();
            ToString();
        }

    }
}
