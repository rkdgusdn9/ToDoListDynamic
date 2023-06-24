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

        public override void AskForInputs()
        {
            Console.WriteLine("Type your date");
     
            Console.WriteLine("\nYear?\n");
            dateTime.Year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nMonth?\n");
            dateTime.Month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nDay?\n");
            dateTime.Day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nHour?\n");
            dateTime.Hour = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nMinute?\n");
            dateTime.Minute = Convert.ToInt32(Console.ReadLine());

        }
    }
}
