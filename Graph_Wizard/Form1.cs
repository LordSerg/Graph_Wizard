using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graph_Wizard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int q = -1;
        int[] x1, x2, y1, y2;
        int id=0;

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = "0";

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            int abc = 1;
            vertex[] v=new vertex[0];
            edge[] ed = new edge[0];
            if (q == 0)
            {
                //добавляем вершину
                id++;
                v = new vertex[id];
                x1 = new int[id];
                x2 = new int[id];
                y1 = new int[id];
                y2 = new int[id];
                if (id > 1)
                    for (int i = 0; i < id - 1; i++)
                    {
                        x1[i] = x2[i];
                        y1[i] = y2[i];
                    }
                x1[id - 1] = e.X;
                y1[id - 1] = e.Y;
                x2[id - 1] = e.X;
                y2[id - 1] = e.Y;
                for (int i = 0; i < id; i++)
                {
                    v[i] = new vertex(x1[i], y1[i]);
                }
                
            }
            if (q == 1)
            {
                //добавляем грань
                if (abc == 1)
                {

                }
                if (abc == 2)
                {

                }
                abc++;
            }
            if ((q == 0) || (q == 1 && abc == 3))
                draw_graph(v, ed);
        }

        private void додатиВершинуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //timer1.Enabled = true;
            q = 0;
        }

        class vertex
        {
            public int x, y;

            public vertex(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        class edge
        {
            public int a, b;
            public edge(int a,int b)
            {
                this.a = a;
                this.b = b;
            }
        }

        void draw_graph(vertex[] V,edge[] E)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
