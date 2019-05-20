using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AnalysisProject
{
    class MyDrawArea
    {
        Panel panel;

        List<PointF[]> PointsList;
        List<Pen> PensList;

        List<PointF[]> OnlyPointsList;
        List<Pen> OnlyPensList;

        List<PointF[]> IntegrationPointsList;
        List<Pen> IntegrationPensList;

        float xmin, xmax, ymin, ymax, xscale, yscale;

        public MyDrawArea(Control.ControlCollection control, string id, List<PointF[]> PointsList, List<Pen> PensList, List<PointF[]> OnlyPointsList, List<Pen> OnlyPensList, List<PointF[]> IntegrationPointsList, List<Pen> IntegrationPensList, double xmin = -10, double xmax = 10, double ymin = -5, double ymax = 5, int left = 0, int top = 0, int width = 827, int height = 273)
        {
            panel = new Panel();
            this.panel.Location = new System.Drawing.Point(left, top);
            this.panel.Name = "panel" + id;
            this.panel.Size = new System.Drawing.Size(width, height);
            panel.BackColor = System.Drawing.Color.White;
            panel.BorderStyle = BorderStyle.FixedSingle;

            this.xmin = (float)xmin;
            this.xmax = (float)xmax;
            this.ymin = (float)ymin;
            this.ymax = (float)ymax;

            xscale = (float)((panel.Width) / (xmax - xmin));
            if (ymin != ymax)
                yscale = (float)((panel.Height) / (ymin - ymax));
            else
                yscale = -1 * (panel.Height);

            this.PointsList = PointsList;
            this.PensList = PensList;
            if (PointsList != null && PensList != null)
                for (int i = 0; i < PointsList.Count; i++)
                {
                    for (int j = 0; j < PointsList[i].Length; j++)
                    {
                        PointsList[i][j].X *= xscale;
                        PointsList[i][j].Y *= yscale;
                    }
                }


            this.OnlyPointsList = OnlyPointsList;
            this.OnlyPensList = OnlyPensList;
            if (OnlyPointsList != null && OnlyPensList != null)
                for (int i = 0; i < OnlyPointsList.Count; i++)
                {
                    for (int j = 0; j < OnlyPointsList[i].Length; j++)
                    {
                        OnlyPointsList[i][j].X *= xscale;
                        OnlyPointsList[i][j].Y *= yscale;
                    }

                }


            panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);

            control.Add(panel);
            panel.BringToFront();
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            float x0 = (float)((panel.Width / 2) - (xmax + xmin) * xscale / 2);
            float y0 = (float)((panel.Height / 2) - (ymax + ymin) * yscale / 2);

            e.Graphics.TranslateTransform(x0, y0);

            e.Graphics.ScaleTransform(1, 1);


            //رسم المحاور
            //X Axe
            e.Graphics.DrawLine(Pens.Black, xmin*xscale, 0, xmax*xscale,0);

            //Y Axe
            e.Graphics.DrawLine(Pens.Black, 0, ymin * yscale, 0, ymax * yscale);


            //رسم التوابع
            if (PointsList != null && PensList != null)
                for (int i = 0; i < PointsList.Count; i++)
                {
                    e.Graphics.DrawLines(PensList[i], PointsList[i]);
                }

            //رسم النقط
            if (OnlyPointsList != null && OnlyPensList != null)
                for (int i = 0; i < OnlyPointsList.Count; i++)
                {
                    for (int j = 0; j < OnlyPointsList[i].Length; j++)
                    {
                        float x = OnlyPointsList[i][j].X;
                        float y = OnlyPointsList[i][j].Y;
                        e.Graphics.DrawEllipse(OnlyPensList[i],x-7F/2,y-7F/2,7,7);
                    }

                }


            
        }
    }


    class MyDrawAreaGenerator
    {
        Control.ControlCollection control;

        List<PointF[]> PointsList;
        List<Pen> PensList;

        List<PointF[]> OnlyPointsList;
        List<Pen> OnlyPensList;

        List<PointF[]> IntegrationPointsList;
        List<Pen> IntegrationPensList;

        float xmin, xmax, ymin, ymax;
        string id;
        

        public MyDrawAreaGenerator(Control.ControlCollection control)
        {
            this.control = control;

            PointsList = new List<PointF[]>();
            PensList = new List<Pen>();

            OnlyPointsList = new List<PointF[]>();
            OnlyPensList = new List<Pen>();

            IntegrationPointsList = new List<PointF[]>();
            IntegrationPensList = new List<Pen>();
        }

        public void setMain(DifferenceTable mainTable)
        {
            xmin = (float)mainTable.getX(0);
            xmax = (float)mainTable.getX(mainTable.n);

           
            ymin = (float)mainTable.getY(0);
            for (int i = 1; i <= mainTable.n; i++)
            {
                ymin = (ymin < (float)mainTable.getY(i)) ? ymin : (float)mainTable.getY(i);
            }

            ymax = (float)mainTable.getY(0);
            for (int i = 1; i <= mainTable.n; i++)
            {
                ymax = (ymax > (float)mainTable.getY(i)) ? ymax : (float)mainTable.getY(i);
            }

            float q = (xmax - xmin) * 0.1F;
            xmin -= q;
            xmax += q;

            q = (ymax - ymin) * 0.1F;
            ymin -= q;
            ymax += q;
        }

        public void AddFunction(DifferenceTable table, Pen pen)
        {
            PointsList.Add(table.ToPoints());
            PensList.Add(pen);
        }

        public void AddFunction(Polynomial P, Pen pen)
        {
            DifferenceTable table = new DifferenceTable(control, 200, "", false, false, false);
            table.setTable_Polynomial(P, xmin, xmax);

            PointsList.Add(table.ToPoints());
            PensList.Add(pen);
        }

        public void AddPoints(DifferenceTable table, Pen pen)
        {
            OnlyPointsList.Add(table.ToPoints());
            OnlyPensList.Add(pen);
        }

        public void AddIntegrationPoints(DifferenceTable table, Pen pen)
        {
            IntegrationPointsList.Add(table.ToPoints());
            IntegrationPensList.Add(pen);
        }

        public void showDrawing(string id)
        {
            control.Clear();
            new MyDrawArea(control, id, PointsList, PensList, OnlyPointsList, OnlyPensList, IntegrationPointsList,
                IntegrationPensList, xmin, xmax, ymin, ymax);
        }
    }
}
