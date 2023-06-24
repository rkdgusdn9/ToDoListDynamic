using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListDynamic.Class
{
    public class Appointment : ToDoItem
    {
        public Appointment(int type) : base()
        {
            Type = type;
            TaskName();
            CheckDateTime();
            ToString();
        }
     
    }
}
