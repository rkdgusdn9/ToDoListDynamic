using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListDynamic.Class
{
    public abstract class ToDoItem : ToDoList
    {
        public DateTime dateTime = new DateTime();
        public ToDoItem() : base()
        {

        }
        public void TaskName()
        {
            Console.WriteLine("\nWhat is your Task?\n");
            string InputTask = Console.ReadLine();
            Message = InputTask;
        }

        public DateTime CheckDateTime()
        {
            //DateTime dateTime = new DateTime();
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

            DateTime = dateTime;

            return DateTime;
        }

        public void LinkAddress()
        {
            Console.WriteLine("\nAdd Zoom Link:\n");
            Link = Console.ReadLine();
        }
        override
        public string ToString()
        {
            if(Type == 1)
            {
                return $"\nType = {Type}.Message\nTask = {Message}\n";
            }
            else if(Type == 2)
            {
                return $"\nType = {Type}.Appointment\nTask = {Message}\nDateTime = {DateTime.ToString()}\n";
            }
            else
            {
                return $"\nType = {Type}.Zoom\nTask = {Message}\nDateTime = {DateTime.ToString()}\nLink = {Link}\n";
            }
        }
    }

    
}
