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
            Hashtable weeks = new Hashtable();
            weeks.Add("1", "SunDay");
            weeks.Add("2", "MonDay");
            weeks.Add("3", "TueDay");
            weeks.Add("4", "WedDay");
            weeks.Add("5", "ThuDay");
            weeks.Add("6", "FriDay");
            weeks.Add("7", "SatDay");
            //Display a single Item 

            MessageBox.Show(weeks["5"].ToString ());
            //Search an Item 
            if (weeks.ContainsValue("TueDay"))
            {
                MessageBox.Show("Find");
            }
            else
            {
                MessageBox.Show("Not find");
            }
            //remove an Item 
            weeks.Remove("3");
            //Display all key value pairs
            foreach (DictionaryEntry day in weeks )
            {
                MessageBox.Show (day.Key + "   -   " + day.Value );
            }
        }
    }
}