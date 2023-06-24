using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListDynamic.Class
{

    public static class Appp
    {

        public static void Main()
        {
            var list = new ItemList();

            BaseItem item = null;
            // ask user for which type
            int type = 0;

            switch(type)
            {
                case 1:
                    item = HandleItem1Input();
                    break;
                case 21:
                    item = HandleItem1Input();
                    break;
                case 3:
                    item = HandleItem1Input();
                    break;

                default: break;

            }

            list.Add(item);

            item.ShowItem();


            list.ShowAll();

        }

        public class ItemList
        {
            public List<BaseItem> List { get; set; } = new List<BaseItem>();

            public void Add(BaseItem item)
            {
                List.Add(item);
            }


            public void ShowAll()
            {
                foreach(BaseItem item in List)
                {
                    item.ShowItem();
                }
            }
        }

        public static BaseItem HandleItem1Input()
        {
            //
            string message = null;
            DateTime date = null;

            // readline() get message from user
            // message = readline();
            //date = convert(readline());


            return new Item1(message, date);
        }



    }


    public abstract class BaseItem
    {

        public string Message { get; set; }

        public abstract void ShowItem();
    }

    public class Item1 : BaseItem
    {
        public DateTime Date;

        public Item1(string message, DateTime date)
        {
            this.Message = message;
            this.Date = date;
        }

        public override void ShowItem()
        {
            Console.Write("------------");
            Console.Write($"Message: {}");
            Console.Write("------------");
            Console.Write("------------");
        }
    }

    public class Item2 : BaseItem
    {
        public string Link { get; set; }
        public AddressBook AddressBook { get; set; }

        public Item2(string message, string link, AddressBook addressBook1)
        {
            this.Message = message;
            this.Link = link;
            this.AddressBook = addressBook1;
        }

        public override void ShowItem()
        {
            throw new NotImplementedException();
        }
    }

    public class Item3 : BaseItem
    {
        public string Title { get; set; }

        public Item3(string message, string title)
        {
            this.Message = message;

            this.Title = title;
        }

        public override void ShowItem()
        {
            throw new NotImplementedException();
        }
    }


    public class AddressBook
    {
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
    }
}
