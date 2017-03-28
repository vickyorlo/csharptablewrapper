using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Table
{
    class Table
    {
        public delegate void Delegate(int count);
        public BindingList<int> BackingTable = new BindingList<int>();
        public event Delegate ChangedTable;

        public int this[int index]
        {
            get
            {
                if (index > BackingTable.Count)
                {
                    throw new IndexOutOfRangeException();
                }
                return BackingTable[index];
            }
            set
            {
                try
                {
                    BackingTable[index] = value;
                }
                catch (ArgumentOutOfRangeException)
                {
                    while(BackingTable.Count<index)
                    {
                        BackingTable.Add(0);
                    }
                    BackingTable.Add(value);
                }
                ChangedTable(BackingTable.Count);
            }
        }

        public Table Add(int element)
        {
            BackingTable.Add(element);
            ChangedTable(BackingTable.Count);
            return this;
        }
    }
}
