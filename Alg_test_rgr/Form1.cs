using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Microsoft.VisualBasic;

namespace Alg_test_rgr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        LinkedList<Circle> circles = new LinkedList<Circle>();
        int vertex = -1;
        bool check = false;
        int ves; // вес ребра
        int n = 0;//vertex count

        class Circle
        {
            private int x, y;
            private int rad = 15;
            public int X { get { return x; } set { x = value; } }
            public int Y { get { return y; } set { y = value; } }
            public int Rad { get { return rad; } }
        }

        Point[] koortoch = new Point[50]; //массив точек
        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            Circle circle = new Circle();
            switch (e.Button)
            {
                case MouseButtons.Left:
                    Pen pen_circle = new Pen(Color.Black, 3);
                    circle.X = e.X - circle.Rad;
                    circle.Y = e.Y - circle.Rad;
                    panel.CreateGraphics().DrawEllipse(pen_circle, circle.X, circle.Y,
                        circle.Rad * 2, circle.Rad * 2);

                    String drawString = (circles.Count + 1).ToString();
                    int fontSize = 14;
                    if (circles.Count + 1 >= 10)
                        fontSize = 11;

                    Font font = new Font("Arial", fontSize);
                    SolidBrush brush = new SolidBrush(Color.Black);
                    PointF point = new PointF(circle.X + circle.Rad / 2, (circle.Y + circle.Rad / 2) - 2);

                    panel.CreateGraphics().DrawString(drawString, font, brush, point);
                    circles.AddLast(circle);
                    n++;
                    koortoch[n] = e.Location;
                    if (check == false)
                    {
                        var column1 = new DataGridViewColumn();
                        column1.HeaderText = "0";
                        column1.ReadOnly = true;
                        column1.Name = "0";
                        column1.CellTemplate = new DataGridViewTextBoxCell();
                        column1.DefaultCellStyle.BackColor = Color.White;
                        column1.DefaultCellStyle.ForeColor = Color.Black;
                        dgv_matrix.Columns.Add(column1);
                        dgv_matrix.Rows.Add();
                        dgv_matrix.Columns.Add(1.ToString(), 1.ToString());
                        dgv_matrix[0, 0].Value = 1;
                        check = true;
                    }
                    else
                    {
                        for (int i = circles.Count; i < circles.Count + 1; ++i)
                        {
                            dgv_matrix.Columns.Add(i.ToString(), i.ToString());
                            dgv_matrix.Rows.Add();
                        }
                        for (int i = 0; i < circles.Count; ++i)
                            dgv_matrix[0, i].Value = i + 1;
                    }
                    break;

                case MouseButtons.Right:
                    Pen pen_selected = new Pen(Color.Red, 2);
                    if (vertex == -1)
                    {
                        int count = 0;
                        foreach (Circle c in circles)
                        {
                            if (e.X - c.Rad <= c.X + c.Rad &&
                                      e.X - c.Rad >= c.X - c.Rad &&
                                   e.Y - c.Rad <= c.Y + c.Rad &&
                                   e.Y - c.Rad >= c.Y - c.Rad)
                            {
                                vertex = count;
                                panel.CreateGraphics().DrawEllipse(pen_selected, c.X, c.Y, c.Rad * 2, c.Rad * 2);
                                break;
                            }
                            count++;
                        }
                    }
                    else
                    {
                        int tovertex = -1;
                        int count = 0;
                        foreach (Circle c in circles)
                        {
                            if (e.X - c.Rad <= c.X + c.Rad &&
                                        e.X - c.Rad >= c.X - c.Rad &&
                                        e.Y - c.Rad <= c.Y + c.Rad &&
                                        e.Y - c.Rad >= c.Y - c.Rad)
                            {
                                tovertex = count;
                                panel.CreateGraphics().DrawEllipse(pen_selected, c.X, c.Y, c.Rad * 2, c.Rad * 2);
                                break;
                            }
                            count++;
                        }

                        if ((tovertex != -1) && (vertex != tovertex))
                        {
                            int it = 0;
                            Point p1 = new Point(0, 0);
                            Point p2 = new Point(0, 0);
                            foreach (Circle c in circles)
                            {
                                if (it == vertex)
                                    p1 = new Point(c.X + c.Rad, c.Y + c.Rad);
                                if (it == tovertex)
                                    p2 = new Point(c.X + c.Rad, c.Y + c.Rad);
                                it++;
                            }
                            panel.CreateGraphics().DrawLine(pen_selected, p1, p2);
                            try
                            {
                                ves = Convert.ToInt32(Interaction.InputBox("Введите вес", "Вес", "", 100, 100));
                            }
                            catch (Exception) // если возникла ошибка
                            {
                                ves = 1;
                            }

                            for (int i = 0; i < n; i++)
                            {
                                for (int j = 0; j < n; j++)
                                {
                                    Pen pen_edge = new Pen(Color.Black, 3);
                                    var label_edge = new Label //определение Label для визуализации расстояния между городами
                                    {
                                        Text = ves.ToString(), //расстояние
                                        Location = new Point((p1.X + p2.X) / 2, ((p1.Y + p2.Y) / 2) - 20), //координаты размещения Label
                                        AutoSize = true,
                                        Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))),
                                        ForeColor = Color.Black,
                                    };
                                    panel.Controls.Add(label_edge); //добавление Label на полотно
                                    label_edge.BringToFront(); //перенос Label поверх остальных элементов на полотне
                                }
                            }

                            for (int i = circles.Count; i < circles.Count + 1; ++i)
                            {
                                dgv_matrix[vertex + 1, tovertex].Value = ves;
                                dgv_matrix[tovertex + 1, vertex].Value = ves;
                            }
                            vertex = -1;
                        }
                    }
                    break;
            }
        }
        private void btn_prim_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < n + 1; i++)
                for (int j = 0; j < n; j++)
                    if (dgv_matrix[i, j].Value == null)
                        dgv_matrix[i, j].Value = 0;
            int[,] copymatrix = new int[n + 1, n + 1]; //двумерный массив, копирующий dataGridView
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    copymatrix[i, j] = Convert.ToInt32(dgv_matrix[i + 1, j].Value);
                }
            }
            int no_edge;
            int result = 0;
            int[] selected = new int[n + 1];
            List<int> list = new List<int>();

            no_edge = 0;
            int x, y;
            selected[0] = 1;
            while (no_edge <= n)
            {
                int min = Int32.MaxValue;                //int min = 10000000;
                x = 0;
                y = 0;
                for (int i = 0; i < n + 1; i++)
                {
                    if (selected[i] == 1)
                    {
                        for (int j = 0; j < n + 1; j++)
                        {
                            if ((selected[j] != 1) && (copymatrix[i, j] != 0))
                            {
                                if (min > copymatrix[i, j])
                                {
                                    min = copymatrix[i, j];
                                    x = i;
                                    y = j;

                                }
                            }
                        }
                    }
                }
                if (min == Int32.MaxValue)
                    min = 0;
                if (min != 0)
                    list.Add(min);
                result += min;
                selected[y] = 1;
                no_edge++;
                textbox_result.Text = "Вес остова =" + result + " (Ребра ";
                foreach (int i in list)
                    textbox_result.Text += i.ToString() + "  ";
                textbox_result.Text += ")";
            }
        }

        private void btn_clean_Click(object sender, EventArgs e)
        {
            textbox_result.Text = "";
            dgv_matrix.Columns.Clear();
            dgv_matrix.Rows.Clear();
            panel.Refresh();
            circles.Clear();
            dgv_matrix.Columns.Add(0.ToString(), 0.ToString());
            n = 0;
        }

    }
}