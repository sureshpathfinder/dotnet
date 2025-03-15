using System;
using System.Collections;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            ArrayList ItemList = new ArrayList();
            ItemList.Add("Item4");
            ItemList.Add("Item5");
            ItemList.Add("Item2");
            ItemList.Add("Item1");
            ItemList.Add("Item3");
            MessageBox.Show ("Shows Added Items");
            for (i = 0; i < = ItemList.Count - 1; i++)
            {
                MessageBox.Show(ItemList[i].ToString());
            }
            //insert an item 
            ItemList.Insert(3, "Item6");
            //sort itemms in an arraylist 
            ItemList.Sort();
            //remove an item 
            ItemList.Remove("Item1");
            //remove item from a specified index 
            ItemList.RemoveAt(3);
            MessageBox.Show("Shows final Items the ArrayList");
            for (i = 0; i < = ItemList.Count - 1; i++)
            {
                MessageBox.Show(ItemList[i].ToString());
            }
        }
    }
}