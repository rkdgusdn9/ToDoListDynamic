using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListDynamic.Class
{
    public class Zoom : ToDoItem
    {
        public Zoom(int type) : base()
        {
            Type = type;
            TaskName();
            CheckDateTime();
            LinkAddress();
            ToString();
        }

    }
}
