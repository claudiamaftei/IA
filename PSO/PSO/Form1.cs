using MindFusion.Diagramming;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Brush = MindFusion.Drawing.Brush;
using System.Windows.Input;
namespace PSO
{

    public partial class Particle_Swarm_Optimization : Form
    {
        private int nr_links = 0;
        private static int nrOfNodes = 6;
        RectangleF[] nodeBounds = new RectangleF[nrOfNodes];
        private int first_nod;
        private int[,] adiacent;
        private Label[] label_position;
        private Label[] label_costs;
        private PSO pso = new PSO();
        private void Initializare()
        {

            diagram1.DefaultShape = Shapes.Ellipse;
            diagram1.ClearAll();



            nodeBounds[0] = new RectangleF(8, 20, 10, 10);
            nodeBounds[1] = new RectangleF(48, 5, 10, 10);
            nodeBounds[2] = new RectangleF(48, 35, 10, 10);
            nodeBounds[3] = new RectangleF(88, 5, 10, 10);
            nodeBounds[4] = new RectangleF(88, 35, 10, 10);
            nodeBounds[5] = new RectangleF(128, 20, 10, 10);
            ShapeNode[] nod = new ShapeNode[6];
            if (label_position != null)
            {
                for (int i = 0; i < label_position.Length; ++i)
                {
                    diagramView1.Controls.Remove(label_position[i]);
                }
            }
            if (label_costs != null)
            {
                for (int i = 0; i < label_costs.Length; ++i)
                {
                    diagramView1.Controls.Remove(label_costs[i]);
                }
            }
            for (int i = 0; i < nrOfNodes; ++i)
            {
                nod[i] = diagram1.Factory.CreateShapeNode(nodeBounds[i]);
                nod[i].Brush = new MindFusion.Drawing.SolidBrush(Color.FromArgb(227, 204, 255));
            }
            label_position = new Label[nrOfNodes];
            adiacent = new int[nrOfNodes, nrOfNodes];
            first_nod = -1;
            nr_links = 0;
            

        }
        public Particle_Swarm_Optimization()
        {
            InitializeComponent();
            Initializare();



        }
        private void diagramView1_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            int seccond_node=-1 ;
            for (int i = 0; i < nrOfNodes; i++)
            {
                var cursor_poz = diagramView1.PointerCursor;
                if ((double)e.X/3.8  >= nodeBounds[i].X &&(double) e.X/3.8  <= nodeBounds[i].X + nodeBounds[i].Width
                    && (double)e.Y/3.8 >= nodeBounds[i].Y && (double)e.Y/3.8 <= nodeBounds[i].Y + nodeBounds[i].Height)
                {
                    
                    seccond_node = i;
                    if(first_nod!=-1)
                    {
                        adiacent[first_nod, seccond_node] = 1;
                        
                        nr_links++;
                    }
                    break;
                }
                
            }
            first_nod = -1;
        }
        private void diagramView1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            for(int i=0;i<nrOfNodes;i++)
            {
                if ((double)e.X / 3.8 >= nodeBounds[i].X && (double)e.X / 3.8 <= nodeBounds[i].X + nodeBounds[i].Width
                    && (double)e.Y / 3.8 >= nodeBounds[i].Y && (double)e.Y / 3.8 <= nodeBounds[i].Y + nodeBounds[i].Height)
                {

                    first_nod = i;
                    break;
                }
                
            }
        }

        private void generate_input_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            label_costs = new Label[nr_links];
            int cnt = 0;
            for (int i = 0; i < nrOfNodes; ++i)
            {
                
                label_position[i] = new Label();
                label_position[i].Text = i.ToString();
                label_position[i].Font = new Font(label_position[i].Font.FontFamily, 15);
                label_position[i].Location = new Point((int)(nodeBounds[i].X*3.8+7), (int)(nodeBounds[i].Y*3.8+7));
                label_position[i].Visible = true;
                label_position[i].Size = new Size(23,23);
                label_position[i].BackColor = Color.FromArgb(227, 204, 255);
                diagramView1.Controls.Add(label_position[i]);

                for(int j=0;j<nrOfNodes;++j)
                {
                    if(adiacent[i,j]==1)
                    {
                        adiacent[i, j] = r.Next(1,11);
                        label_costs[cnt] = new Label();
                        label_costs[cnt].Text = adiacent[i, j].ToString();
                        label_costs[cnt].Font = new Font(label_costs[cnt].Font.FontFamily, 15);
                        label_costs[cnt].Location = new Point((int)((2*nodeBounds[i].X+nodeBounds[j].X)/3 * 3.8 + 7), (int)((2*nodeBounds[i].Y+nodeBounds[j].Y)/3 * 3.8 + 7));
                        label_costs[cnt].Visible = true;
                        label_costs[cnt].Size = new Size(23, 23);
                        label_costs[cnt].BackColor = Color.White;
                        diagramView1.Controls.Add(label_costs[cnt]);
                        cnt++;
                    }
                }
            }

        }

        private void reset_graph_Click(object sender, EventArgs e)
        {
            Initializare();
            textBox1.Clear();
        }

        private void find_the_path_Click(object sender, EventArgs e)
        {
            pso.ParticleSwarm(6,adiacent);
            var list = pso.optimizare_roi();
            foreach (double val in list)
                textBox1.Text += val.ToString()+"-->";

            textBox1.Text += "STOP";

        }
    }
}
