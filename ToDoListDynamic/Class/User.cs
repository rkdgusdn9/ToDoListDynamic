using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListDynamic.Class
{
    public class User
    {
        public string Name { get; set; }

        public void ProperName()
        {
            Name = Name.First().ToString().ToUpper() + Name.Substring(1);
        }
    }

   
}
