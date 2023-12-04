using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace insatsu
{
    using Prints = List<Print | null>;

    enum Print_Type
    {
        A,B
    }

    internal class Machine
    {
        public List<Prints> schedule;
        public Print_Type type;
        public int size;
        public string name;

        public Machine(Print_Type type, int size, string name)
        {
            this.type = type;
            this.size = size;
            this.name = name;
        }

        public void Set_Plan(Prints prints)
        {
            if (check_index()) this.schedule.Add(prints);
        }

        private bool check_index()
        {
            if (size == this.schedule.Count) return false;
            return true;
        }
    }
}
