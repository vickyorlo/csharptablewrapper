using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Table
{
    public partial class Form1 : Form
    {
        private Table Table = new Table();
        public Form1()
        {
            InitializeComponent();
            TableBox.DataSource = Table.BackingTable;
            Table.ChangedTable += Table_ChangedTable;
        }

        private void Table_ChangedTable(int count)
        {
            MessageBox.Show("Event tripped! There are currently " + count + " items in the list.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Table.Add((int)AddInteger.Value);
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            Table[(int)InsertIndex.Value] = (int)InsertInteger.Value;
        }
    }
}
