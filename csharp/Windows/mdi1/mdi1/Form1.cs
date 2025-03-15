using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace mdi1
{
    public partial class Form1 : Form
    {
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f=new Form2();
            i++;
            f.Text="Child Form " + i;
            f.MdiParent = this;
            f.Show();
        }

        private void closeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2.ActiveForm.Close();
        }

        private void horiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            label1.Font=new Font(label1.Font,FontStyle.Bold);
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        
    }
}