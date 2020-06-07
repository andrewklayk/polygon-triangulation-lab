using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Geom
{
    public partial class Form1 : Form
    {
        List<Vertex> v1 = new List<Vertex>();
        List<Edge> v2 = new List<Edge>();
        public Form1()
        {
            InitializeComponent();
        }

        public void Generate(int N)
        {
            GeneratePolygon(N, v1, v2);
        }

        public void Clear()
        {
            v1.Clear();
            v2.Clear();
            chart.Series[0].Points.Clear();
            chart.Series[1].Points.Clear();
        }

        public void Draw()
        {
            chart.Series[0].Points.Clear();
            chart.Series[1].Points.Clear();
            foreach (Edge edge in v2)
            {
                chart.Series[0].Points.Add(new DataPoint(edge.start_x, edge.start_y));
                chart.Series[0].Points.Add(new DataPoint(edge.end_x, edge.end_y));
            }
        }

        public void Triangulate(List<Vertex> v1, List<Edge> v2)
        {
            Vertex v = v1[0];
            bool emptyTriangle;
            while (v1.Count > 3)
            {
                if(v.IsConvex())
                {
                    emptyTriangle = true;
                    foreach(Vertex vi in v1)
                    {
                        if(InTriangle(vi, v.prev, v, v.next)) //If the triangle contains another vertex, v is not an ear, move to next
                        {
                            emptyTriangle = false;
                            break;
                        }
                    }
                    if(emptyTriangle)
                    {
                        //Add new diagonal to list of edges of final polygon
                        v2.Add(new Edge(v.prev, v.next));
                        //remove ear from list
                        v1.Remove(v);
                        //modify v.prev and v.next to account for v being deleted
                        v.prev.next = v.next;
                        v.next.prev = v.prev;
                    }
                }
                v = v.next;
            }
        }

        public bool InTriangle(Vertex ch, Vertex v1, Vertex v2, Vertex v3)
        {
            if (ch == v1 || ch == v2 || ch == v3)
                return false;
            double tmp1 = (v1.x - ch.x) * (v2.y - v1.y) - (v2.x - v1.x) * (v1.y - ch.y);
            double tmp2 = (v2.x - ch.x) * (v3.y - v2.y) - (v3.x - v2.x) * (v2.y - ch.y);
            double tmp3 = (v3.x - ch.x) * (v1.y - v3.y) - (v1.x - v3.x) * (v3.y - ch.y);
            return Sign(tmp1) == Sign(tmp2) && Sign(tmp1) == Sign(tmp3) && Sign(tmp2) == Sign(tmp3);
        }

        public int Sign(double x)
        {
            if (x > 0)
                return 1;
            if (x == 0)
                return 0;
            return -1;
        }

        private void GeneratePolygon(int N, List<Vertex> v1, List<Edge> v2)
        {
            double degreesLeft = 360;
            double dotsLeft = N;
            double len;
            double deg = 0;
            double cos;
            double sin;
            double prevlen = 1;
            for (int i = 0; i < N; i++)
            {
                len = new Random().NextDouble() * (1/prevlen) % 10;
                deg += new Random().NextDouble() * degreesLeft / dotsLeft;
                cos = Math.Cos(Radians(deg));
                sin = Math.Sin(Radians(deg));
                v1.Add(new Vertex(len * cos, len * sin));
                degreesLeft = 360 - deg;
                dotsLeft--;
                prevlen = len;
            }
            ConnectSortedVertexList(v1);
            FillEdgeList(v1, v2);
        }

        private void ConnectSortedVertexList(List<Vertex> v1)
        {
            for (int i = 1; i < v1.Count - 1; i++)
            {
                v1[i].next = v1[i + 1];
                v1[i].prev = v1[i - 1];
            }
            v1.First().next = v1[1];
            v1.First().prev = v1.Last();
            v1.Last().prev = v1[v1.Count - 2];
            v1.Last().next = v1.First();

        }
        private void FillEdgeList(List<Vertex> v1, List<Edge> v2)
        {
            foreach(Vertex v in v1)
            {
                v2.Add(new Edge(v, v.next));
            }
        }
        private double Radians(double x)
        {
            return (Math.PI / 180) * x;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nbox.Visible = true;
            vertexbox.Visible = false;
            if (!int.TryParse(nbox.Text, out int N) || N < 3)
            {
                MessageBox.Show("Enter a positive integer > 2", "Error");
                return;
            }
            Clear();
            Generate(N);
            Draw();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Triangulate(v1, v2);
            Draw();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void but_manual_Click(object sender, EventArgs e)
        {
            but_add.Visible = true;
            but_man_done.Visible = true;
            vertexbox.Visible = true;
            nbox.Visible = false;
            butGen.Visible = false;
        }

        private void but_random_Click(object sender, EventArgs e)
        {
            but_add.Visible = false;
            but_man_done.Visible = false;
            vertexbox.Visible = false;
            nbox.Visible = true;
            butGen.Visible = true;
        }

        private void but_add_Click(object sender, EventArgs e)
        {
            var result = vertexbox.Text.Split(',');
            double x = Double.Parse(result[0]);
            double y = Double.Parse(result[1].Trim());
            v1.Add(new Vertex(x, y));
            if (x == 0)
                x += 0.00001;
            chart.Series[1].Points.AddXY(x, y);
        }

        private void but_man_done_Click(object sender, EventArgs e)
        {
            ConnectSortedVertexList(v1);
            FillEdgeList(v1, v2);
            Draw();
        }
    }

    public class Edge
    {
        public double start_x;
        public double start_y;
        public double end_x;
        public double end_y;
        public Edge(Vertex s, Vertex e)
        {
            start_x = s.x;
            start_y = s.y;
            end_x = e.x;
            end_y = e.y;
        }
    }

    public class Vertex
    {
        public double x, y;
        public Vertex prev, next;
        public Vertex(double _x, double _y)
        {
            x = _x;
            y = _y;
        }
        public Vertex(double _x, double _y, Vertex pr, Vertex n)
        {
            x = _x;
            y = _y;
            prev = pr;
            next = n;
        }
        public bool IsConvex()
        {
            return (this.prev.x - this.x) * (this.next.y - this.y) - (this.prev.y - this.y) * (this.next.x - this.x) < 0;
        }
    }
}
