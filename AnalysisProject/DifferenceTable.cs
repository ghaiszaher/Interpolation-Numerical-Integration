using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using info.lundin.Math;
using System.Collections; 

namespace AnalysisProject
{
    class DifferenceTable
    {
        public EditLabel[][] TableArray;
        private int rows, cols;
        public int n;
        private Panel[] Panels;

        public DifferenceTable(Control.ControlCollection control,int points,string id,bool ExtendTable=true, bool EditEnable=true,bool addToControls=true, int X = 0, int Y = 0, int ElementWidth = 70, int ElementHeight = 20)
        {
            if (addToControls)
                control.Clear();

            if (points < 2)
                points = 2;

            rows = points+1;
            cols = points+2;
            if (!ExtendTable)
                cols = 3;
            TableArray = new EditLabel[cols][];
            for (int j = 0; j < cols; j++)
            {
                if(j<3)
                    TableArray[j] = new EditLabel[rows];
                else
                    TableArray[j] = new EditLabel[rows - j + 2];

                
                for (int i = 0; i < TableArray[j].Length; i++)
                {
                    TableArray[j][i] = new EditLabel(control,id+i.ToString()+j.ToString(),addToControls,X,Y,ElementWidth,ElementHeight);
                    TableArray[j][i].label.Font = new System.Drawing.Font("Times New Roman Special G1", (ElementHeight/2 - ElementHeight/ElementWidth), System.Drawing.FontStyle.Italic);
                    if (i == 0 || j == 0 || j > 2 || (j == 1 && EditEnable == false))
                        TableArray[j][i].EditEnable = false;
                    else
                    {
                        TableArray[j][i].label.Font = new System.Drawing.Font("Times New Roman Special G1", (ElementHeight / 2 - ElementHeight / ElementWidth), ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
                        TableArray[j][i].label.Cursor = Cursors.Hand;
                    }
                }


            }

            if (addToControls)
            {
                setLocations();
                setNames();
                setNames_ForwardBackWardDifference();
                setLines();
                setLengths();
            }

            n = TableArray[0].Length - 2;
        }

        public void setTable_Expression(string expression, double a, double b)
        {
            if (a == b)
                return;
            if (a > b)
            {
                double temp = a;
                a = b;
                b = temp;
            }

            double h = (b - a) / n; //n is nb. of points - 1 (points are from x0 to xn)


            for (int i = 0; i <= n; i++)
            {
                double xi = a + h * i;
                double yi = getExpressionValue(expression, xi);

                TableArray[1][i + 1].Value = xi;
                TableArray[2][i + 1].Value = yi;
            }

            this.setToolTips();

        }

        public void setTable_Polynomial(Polynomial P, double a, double b)
        {
            if (a == b)
                return;
            if (a > b)
            {
                double temp = a;
                a = b;
                b = temp;
            }

            double h = (b - a) / n; //n is nb. of points - 1 (points are from x0 to xn)


            for (int i = 0; i <= n; i++)
            {
                double xi = a + h * i;
                double yi = P.value(xi);

                TableArray[1][i + 1].Value = xi;
                TableArray[2][i + 1].Value = yi;
            }

            this.setToolTips();
        }

        public double getExpressionValue(string expression, double x)
        {
            ExpressionParser myParser = new ExpressionParser();
            Hashtable h = new Hashtable();
            h.Add("x", x.ToString());
            if (!myParser.TryParse(expression, h))
                return 0;

            return myParser.Parse(expression, h);


        }

        public double getX(int i)
        {
            if (i < 0 || i > n)
                return 0;
            else
                return TableArray[1][i + 1].Value;
        }

        public double getY(int i)
        {
            if (i < 0 || i > n)
                return 0;
            else
                return TableArray[2][i + 1].Value;
        }

        public void setLocations()
        {
            int addLeftValue = TableArray[0][0].left;
            int addTopValue = TableArray[0][0].top;

            int addLeftSpecial = Convert.ToInt32(TableArray[0][0].label.Width * 0.5) * 0;
            int addTopSpecial = Convert.ToInt32(TableArray[0][0].label.Height * 0.1) * 0;

            int multLeftValue = Convert.ToInt32(TableArray[0][0].label.Width * 1.3);
            int multTopValue = Convert.ToInt32(TableArray[0][0].label.Height * 1.9);
            

            for (int j = 0; j < cols; j++)
            {
                for (int i = 0; i < TableArray[j].Length; i++)
                {
                    if ((j != 0 || i != 0) && (j < 3 || i == 0))
                    {
                        TableArray[j][i].top = i * multTopValue + addTopValue;
                        TableArray[j][i].left = j * multLeftValue + addLeftValue;

                        //    TableArray[j][i].top += (TableArray[i][j - 1].top + TableArray[i + 1][j - 1].top) / 2;
                    }
                    else if (j != 0 || i != 0)
                    {
                        TableArray[j][i].top = (TableArray[j - 1][i].top + TableArray[j - 1][i + 1].top) / 2;
                        TableArray[j][i].left = j * multLeftValue + addLeftValue;
                    }

                    if (i != 0)                    
                        TableArray[j][i].top -= addTopSpecial;
                    if (j != 0)
                        TableArray[j][i].left -= addLeftSpecial;
                    
                        
                    
                }                
            }

        }

        public void setNames()
        {
            TableArray[0][0].label.Text = "i";
            for (int i = 1; i < TableArray[0].Length; i++)
            {
                TableArray[0][i].label.Text = (i - 1).ToString();                                
            }

            TableArray[1][0].label.Text = "x";
            TableArray[2][0].label.Text = "f(x)";

        
        }

        public void setNames_ForwardBackWardDifference()
        {
            for (int j = 3; j < cols; j++)
            {
                TableArray[j][0].label.Text = "D" + (j - 2).ToString();
            }

            setToolTips();
        }

        public void setNames_DividedDifference()
        {
            for (int j = 3; j < cols; j++)
            {
                TableArray[j][0].label.Text = "f[";
                for (int k = 1; k <= j - 2; k++)
                    TableArray[j][0].label.Text += ",";
                TableArray[j][0].label.Text += "]";
            }

            setToolTips();
        }

        public void setLines()
        {

            int AllTop = TableArray[0][0].label.Top;
            int AllHeight = TableArray[0][rows - 1].label.Height + TableArray[0][rows - 1].label.Top - AllTop + 15;

            Panels = new Panel[cols];
            for (int j = 0; j < cols; j++)
            {
                int thisLeft;
                int thisWidth=1;

                if (j == cols - 1)
                {
                    AllTop = (TableArray[0][0].top + TableArray[0][1].top + TableArray[0][1].label.Height) / 2;
                    AllHeight = 1;
                    thisLeft = TableArray[0][0].label.Left;
                    thisWidth = TableArray[cols - 1][0].left + TableArray[cols - 1][0].label.Width - thisLeft;

                }
                else
                    thisLeft = (TableArray[j][0].left + TableArray[j + 1][0].left + TableArray[j + 1][0].label.Width) / 2;

                Panels[j] = new Panel();
                Panels[j].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                Panels[j].Location = new Point(thisLeft, AllTop);
                Panels[j].Name = " ";
                Panels[j].Size = new Size(thisWidth, AllHeight);
                TableArray[0][0].label.Parent.Controls.Add(Panels[j]);
                Panels[j].Show();
                Panels[j].BringToFront();                          
            }                        
        }

        public void setLengths()
        {
            
        }

        public void setToolTips()
        {
            for (int j = 0; j < cols; j++)
            {
                for (int i = 0; i < TableArray[j].Length; i++)
                {
                    TableArray[j][i].setToolTip();                    
                }                
            }
        }

        public bool checkTable() //arrange table and check if there's a repeated x
        {
            for (int i = 1; i < TableArray[1].Length - 1; i++)
            {
                for (int k = i + 1; k < TableArray[1].Length; k++)
                {
                    if (TableArray[1][k].Value < TableArray[1][i].Value)
                    {
                        double s = TableArray[1][k].Value;
                        TableArray[1][k].Value = TableArray[1][i].Value;
                        TableArray[1][i].Value = s;

                        s = TableArray[2][k].Value;
                        TableArray[2][k].Value = TableArray[2][i].Value;
                        TableArray[2][i].Value = s;
                    }
                    else if (TableArray[1][k].Value == TableArray[1][i].Value)
                        return false;
                }
            }

            return true;
        }

        public bool checkUniDistance() //to check wheter distance between each xi and xi+1 is the same
        {
            double h = System.Math.Round((getX(1) - getX(0)) * 100000) / 100000; //To avoid machine's negative floating numbers comparison errors

            for (int i = 2; i <= n; i++)
            {
                double xi = getX(i);
                double xii = getX(i - 1);
                double dif = System.Math.Round((xi - xii) * 100000) / 100000; 
                if(dif != h)
                    return false;                
            }
            return true;
        }        

        public void transformToDifferences()
        {
            if (!checkTable())
                return;
            for (int j = 3; j < cols; j++)
            {
                for (int i = 1; i < TableArray[j].Length; i++)
                {
                    TableArray[j][i].Value = TableArray[j - 1][i + 1].Value - TableArray[j - 1][i].Value;
                }                
            }

            setToolTips();
        }

        public static int fact(int x)
        {
            if (x == 0 || x == 1)
                return 1;
            else
                return x * fact(x - 1);
        }

        public Polynomial NewtonPoly_Forward() //كثير حدود نيوتن بالفروق التقدمية
        {
            if (!checkTable() || !checkUniDistance())
                return null;

            transformToDifferences();

            double f0 = getY(0);
            double x0 = getX(0);
            double x1 = getX(1);
            double h = x1 - x0;

            Polynomial P = new Polynomial();
            P.Add(f0, 0); // P = f0

            Polynomial B = new Polynomial();
            B.Add(1 / h, 1);
            B.Add(-x0 / h, 0); // B= (x-x0)/h = x/h - x0/h ... B here is 'p' in the known rule

            Polynomial L = new Polynomial(B); //L هو البسط

            for (int k = 1; k <= n; k++)
            {
                Polynomial G = L * (1.0 / fact(k));
                int j = k + 2;
                double Delta = TableArray[j][1].Value; //Delta1y , Delta2y , Delta3y ....
                G = G * Delta; // G = (B(B-1)(B-2)... / k!) * Delta
                P = P + G;
                Polynomial Temp = B - k;
                L = L * Temp; //B - k في كل حد جديد, البسط هو البسط السابق مضروباً بـ
            }

            return P;
        }

        public Polynomial NewtonPoly_Backward() //كثير حدود نيوتن بالفروق التراجعية
        {
            if (!checkTable() || !checkUniDistance())
                return null;

            transformToDifferences();

            double fn = getY(n);
            double x0 = getX(0);
            double x1 = getX(1);
            double xn = getX(n);
            double h = x1 - x0;

            Polynomial P = new Polynomial();
            P.Add(fn, 0); // P = fn

            Polynomial B = new Polynomial();
            B.Add(1 / h, 1);
            B.Add(-xn / h, 0); // B= (x-xn)/h = x/h - xn/h ... B here is 'p' in the known rule

            Polynomial L = new Polynomial(B); //L هو البسط
            
            for (int k = 1; k <= n; k++)
            {
                Polynomial G = L * (1.0 / fact(k));
                int j = k + 2;
                int i = TableArray[j].Length - 1;
                double Nabla = TableArray[j][i].Value; //Nabla1y , Nabla2y , Nabla3y ....
                G = G * Nabla; // G = (B(B+1)(B+2)... / k!) * Nabla
                P = P + G;
                Polynomial Temp = B + k;
                L = L * Temp; //B + k في كل حد جديد, البسط هو البسط السابق مضروباً بـ
            }
            
            return P;            
        }

        public Polynomial LagrangePoly() //كثير حدود لاغرانج
        {
            if (!checkTable())
                return null;

            Polynomial P = new Polynomial();

            for (int k = 0; k <= n; k++)
            {
                double yk = getY(k);
                Polynomial L = Lagrange(k);
                P = P + (yk * L);
            }

            return P;
        }

        public Polynomial Lagrange(int j) //لاغرانج
        {
            if (!checkTable())
                return null;


            return Bast_Lagrange(j) * (1.0 / Maqam_Lagrange(j)) ;
        } 

        public Polynomial Bast_Lagrange(int j)  //بسط لاغرانج
        {
            Polynomial P = new Polynomial();
            P.Add(1, 0);

            for (int i = 0; i <= n; i++)
            {
                if (i != j)
                {
                    double xi = getX(i);
                    Polynomial B = new Polynomial();
                    B.Add(1, 1); // B = x
                    B.Add(-xi, 0); // B = x - xi
                    P = P * B; //P = (x-x1)*(x-x2)*(x-x3)......(x-xn) 
                }
            }

            return P;
        }

        public double Maqam_Lagrange(int j) //مقام لاغرانج
        {
            double xj = getX(j);
            double res = 1;

            for (int i = 0; i <= n; i++)
            {
                if (i != j)
                {
                    double xi = getX(i);
                    res = res * (xj - xi);
                }
            }

            return res;
        }

        public double Integration_Trapezoida() //تكامل شبه المنحرف
        {
            if (!checkUniDistance())
                return 0;
                        
            double h = getX(1) - getX(0);
            double f0 = getY(0), fn = getY(n);
            double res = f0 + fn;

            for (int i = 1; i <= n-1; i++)
            {
                double fi = getY(i);

                res += 2 * fi;
            }

            return res * (h/2.0);
        }

        public double Integration_Simpson() //تكامل سبمسون
        {
            if (!checkUniDistance())
                return 0;
            if ((n) % 2 != 0) //where n is the nb. of points - 1 (nb. of domains)
                return 0;

            double h = getX(1) - getX(0);
            double f0 = getY(0), fn = getY(n);
            double res = f0 + fn;

            for (int i = 1; i <= n-1; i++)
            {
                double fi = getY(i);
                if (i % 2 == 0)
                    res += 2 * fi;
                else
                    res += 4 * fi;
            }

            return res * (h/3.0);
        }


        public PointF[] ToPoints()
        {
            PointF[] P = new PointF[n + 1];
            for (int i = 0; i <=n; i++)
            {
                double xi = getX(i);
                double yi = getY(i);

                P[i] = new PointF((float)xi,(float)yi);
            }

            return P;
        }
    }

}

