using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day25_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            imageList1.Draw(e.Graphics, 0, 0, 0);
            imageList1.Draw(e.Graphics, 40, 0, 1);
            button2.ImageList = imageList1;
            button2.ImageIndex = 0;
            button2.Text = "";
        }
    }
}
