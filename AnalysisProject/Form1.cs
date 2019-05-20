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
    public partial class Form1 : Form
    {
        private DifferenceTable table_Interpolation;
        private DifferenceTable table_Integration;

        private Polynomial forwardPoly, backwardPoly, lagrangePoly;

        private ToolTip forwardTooltip, backwardTooltip, lagrangeTooltip;

        
        public Form1()
        {
            InitializeComponent();

            forwardTooltip = initializeTooltip();
            backwardTooltip = initializeTooltip();
            lagrangeTooltip = initializeTooltip();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            int n=0;
            if(!int.TryParse(nbPointsTextBox.Text,out n) || n<=1)
            {
                MessageBox.Show("Please enter a valid integer value bigger than 1 !", "Error !");
                nbPointsTextBox.Focus();
                nbPointsTextBox.SelectAll();
                return;
            }

            table1Panel.Controls.Clear();
            table_Interpolation = new DifferenceTable(table1Panel.Controls, n, "myInterpolationTable");

            //nbPointsTextBox.Enabled = false;
            //submitBtn.Enabled = false;

            table1GroupBox.Enabled = true;
            functionBtn.Enabled = true;

        }

        private void functionBtn_Click(object sender, EventArgs e)
        {
            if (!table_Interpolation.checkTable())
            {
                MessageBox.Show("There's a repeated x ! Please check the entered values", "Error !");
                return;
            }

            table_Interpolation.transformToDifferences();


            //Lagrange :
            lagrangePoly = table_Interpolation.LagrangePoly();
            label_function_Lagrange.Text = "f(x) = "+lagrangePoly.ToString();
            lagrangeFunctionGroupBox.Enabled = true;
            lagrangeTooltip.SetToolTip(label_function_Lagrange, label_function_Lagrange.Text);

            //Draw
            MyDrawAreaGenerator draw1 = new MyDrawAreaGenerator(drawPanel.Controls);
            draw1.setMain(table_Interpolation);
            draw1.AddFunction(lagrangePoly, Pens.Red);
            draw1.AddPoints(table_Interpolation, Pens.Blue);
            draw1.showDrawing("myShow1");

            //Forward and backward Newton
            if (!table_Interpolation.checkUniDistance())
            {
                label_function_Newton_Forward.Text = 
                    label_function_Newton_Backward.Text = "Conditions aren't complete\n الشروط غير مكتملة";

                newtonFunctionGroupBox.Enabled = false;

                return;
            }

            newtonFunctionGroupBox.Enabled = true;

            //Forward
            forwardPoly = table_Interpolation.NewtonPoly_Forward();
            label_function_Newton_Forward.Text = "f(x) = " + forwardPoly.ToString();
            forwardTooltip.SetToolTip(label_function_Newton_Forward, label_function_Newton_Forward.Text);

            //Backward
            backwardPoly = table_Interpolation.NewtonPoly_Backward();
            label_function_Newton_Backward.Text = "f(x) = " + backwardPoly.ToString();
            backwardTooltip.SetToolTip(label_function_Newton_Backward, label_function_Newton_Backward.Text);
        }

        private void button1_Click(object sender, EventArgs e) //Reset Button
        {
            nbPointsTextBox.Enabled = true;
            submitBtn.Enabled = true;

            table1GroupBox.Enabled = false;
            functionBtn.Enabled = false;

            newtonFunctionGroupBox.Enabled = false;
            lagrangeFunctionGroupBox.Enabled = false;

            table1Panel.Controls.Clear();

            forwardPoly = backwardPoly = lagrangePoly = null;
        }

        private void getY(TextBox input,Label output, Polynomial P)
        {
            double v;
            if(!double.TryParse(input.Text,out v))
            {
                MessageBox.Show("Invalid input value.", "Error !");
                input.Select();
                input.SelectAll();

                return;
            }
            if(P!=null)
                output.Text = P.value(v).ToString();
        }

        private void getYBtn_Backward_Click(object sender, EventArgs e)
        {
            getY(textBox_newton_backward, label_YValue_Backward, backwardPoly);
        }

        private void getYBtn_Forward_Click(object sender, EventArgs e)
        {
            getY(textBox_newton_forward, label_YValue_Forward, forwardPoly);
        }

        private void getYBtn_Lagrange_Click(object sender, EventArgs e)
        {
            getY(textBox_lagrange, label_YValue_Lagrange, lagrangePoly);
        }

        private ToolTip initializeTooltip()
        {
            ToolTip tooltip = new ToolTip();
            tooltip.AutoPopDelay = 10000;
            tooltip.InitialDelay = 1000;
            tooltip.ReshowDelay = 500;
            tooltip.ShowAlways = true;

            return tooltip;
        }

        private void button_Func_GetValue_Click(object sender, EventArgs e)
        {
            int nbPoints;
            double a,b;
            string expression=textBox_Func_fx.Text;

            if (!int.TryParse(textBox_Function_nbPoints.Text, out nbPoints) || nbPoints<=1)
            {
                MessageBox.Show("Invalid integer number of points larger than 1 !", "Error !");
                textBox_Function_nbPoints.Focus();
                textBox_Function_nbPoints.SelectAll();
                return;
            }

            if (!double.TryParse(textBox_Function_a.Text, out a))
            {
                MessageBox.Show("Invalid double value in (a) !", "Error !");
                textBox_Function_a.Focus();
                textBox_Function_a.SelectAll();
                return;
            }

            if (!double.TryParse(textBox_Function_b.Text, out b) || b==a)
            {
                MessageBox.Show("Invalid double value in (b) or is equal to (a) !", "Error !");
                textBox_Function_b.Focus();
                textBox_Function_b.SelectAll();
                return;
            }

            if (!validExpression(expression))
            {
                MessageBox.Show("Invalid function !", "Error !");
                textBox_Func_fx.Focus();
                textBox_Func_fx.SelectAll();
                return;
            }

            table_Integration = new DifferenceTable(table2Panel.Controls, nbPoints, "myIntegrationTableHelp", false, false);
            table_Integration.setTable_Expression(expression, a, b);

            groupBox_Integration_Table.Enabled = true;
            groupBox_Integration_Result.Enabled = false;

        }

        private bool validExpression(string expression)
        {
            ExpressionParser myParser = new ExpressionParser();
            Hashtable hshtbl = new Hashtable();
            hshtbl.Add("x", 1.ToString());
            if (!myParser.TryParse(expression, hshtbl))
            {
                return false;
            }

            return true;

        }


        private void Btn_Table_Reset_Click(object sender, EventArgs e)
        {
            groupBox_Integration_Table.Enabled = false;
            table2Panel.Controls.Clear();

            label_Trapezoida_Result.Text = label_Simpson_Result.Text = "Result";
            groupBox_Integration_Result.Enabled = false;

        }

        private void Btn_Table_GetValue_Click(object sender, EventArgs e)
        {
            if(table_Integration!=null)
            {
                label_Trapezoida_Result.Text = table_Integration.Integration_Trapezoida().ToString();
                label_Simpson_Result.Text = (table_Integration.n % 2 == 0) ? 
                    table_Integration.Integration_Simpson().ToString() : "nb. of points must be odd\nعدد النقط يجب أن يكون فردياً"; //n even => n+1 odd
                groupBox_Integration_Result.Enabled = true ;
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Func_fx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                textBox_Func_fx.SelectAll();
            }
        }

        private void textBox_Func_fx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.button_Func_GetValue_Click(sender, e);
                e.KeyChar = (char)0;                
            }
        }

        private void textBox_Function_nb_a_b_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.button_Func_GetValue_Click(sender, e);

        }

        private void nbPointsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.submitBtn_Click(sender, e);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        
    }
}
