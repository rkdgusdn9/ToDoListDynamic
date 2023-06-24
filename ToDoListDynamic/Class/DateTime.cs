using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListDynamic.Class
{
    public class DateTime
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }

        public int Hour { get; set; }
        public int Minute { get; set; }

        public string ToString()
        {
            // Created enum class to retrieve AM,PM status for practice and need to setup this condition.
            // Currently this is only only retrieving 'AM' hard-coded and no condition for input
            return $"{Year}/{Month}/{Day} {Hour}:{Minute}{AMPM.AM}";
        }
    }
}
