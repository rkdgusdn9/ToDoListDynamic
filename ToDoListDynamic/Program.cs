using System;
using System.Collections.Generic;
using ToDoListDynamic.Class;

namespace ToDoListDynamic
{
    class Program
    {
        public static ToDoList AllList = null;
        static void Main(string[] args)
        {
            Welcome();
            AddTasks();
            var itemToAdd = ChooseType();
            list.add(itemToAdd);

            list.ShowAllTodoList();
            //ShowToDo();

            foreach(var item in list)
            {
                item.ShowItem();
            }
        }

        private static void Welcome()
        {
            Console.WriteLine("\nWhat is your name?\n");
            User user = new User()
            {
                Name = Console.ReadLine()
            };
            user.ProperName();
            Console.WriteLine($"\nHi {user.Name}, Welcome\n");
            
        }

        private static void AddTasks()
        {
            Console.WriteLine("Do you want to add a task?\n");
            Console.WriteLine("[1] Yes\n");
            Console.WriteLine("[2] No\n");

            string userInput = Console.ReadLine();
            int number;
            Int32.TryParse(userInput, out number);
            while (number != 1 || number != 2)
            {
                if (number == 1)
                {
                    ShowToDo();
                }
                else if (number == 2)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\nWrong Input! Try again.\n");
                    Console.WriteLine("[1] Yes\n");
                    Console.WriteLine("[2] No\n");
                    userInput = Console.ReadLine();
                    Int32.TryParse(userInput, out number);
                }
            }
        }

        private static ToDoItem ChooseType()
        {
            ToDoItem toDoItem = null;
            //var messageList = new List<string>();
            //string wholeMessage;
            Console.WriteLine("\nSelect Type:\n");
            int inputType = Convert.ToInt32(Console.ReadLine());
            switch (inputType)
            {
                case 1:
                    toDoItem = new Message();
                    break;

                case 2:
                    toDoItem = new Appointment();
                    break;

                case 3:
                    toDoItem = new Zoom();
                    break;

                case 4:
                    toDoItem = new ShoppingItem();
                    break;
            }


            toDoItem.AskForInputs();

            return toDoItem;

        }

        private static void ShowToDo()
        {
            var todo = ChooseType();
            List<ToDoItem> AllList = new List<ToDoItem>(); // Found mistake here that this list is not from ToDoList class and create new list each time showtodo is called
            AllList.Add(todo);
            foreach (var toDo in AllList)
            {
                Console.WriteLine(toDo.ToString());
            }

        }


        public class ShoppingItem() { 
        }

    }
}
