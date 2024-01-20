using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insatsu
{
    using Prints = List<Print2>;

    enum Print_Type
    {
        A, B
    }

    internal class Machine2
    {
        public List<Prints> schedule = new List<Prints>();
        public Print_Type type;
        public int size;
        public string name;


        public Machine2(Print_Type type, int size, string name)
        {
            this.type = type;
            this.size = size;
            this.name = name;
        }

        public void Set_Plan(Prints prints)
        {
            /*
            if (check_index())
            {
                this.schedule.Add(prints);
            }
            */
            if (check_size(prints))
            {
                this.schedule.Add(prints);
            }
        }

        private bool check_index()
        {
            if (size == this.schedule.Count) return false;
            return true;
        }
        private bool check_size(Prints prints)
        {
            if (size < prints.Count) return false;
            return true;
        }
    }
}
