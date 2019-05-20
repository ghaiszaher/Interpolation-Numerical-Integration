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
    class EditLabel
    {
        public Label label;
        public TextBox textbox;
        public bool EditEnable;
        public ToolTip tooltip;

        public int left
        {
            set
            {
                if (label != null)
                    label.Left = value;
            }
            get
            {
                return (label == null) ? 0 : label.Left;
            }
        }

        public int top
        {
            set
            {
                if (label != null)
                    label.Top = value;
            }
            get
            {
                return (label == null) ? 0 : label.Top;
            }
        }
        
        public EditLabel(Control.ControlCollection control, string id,bool addToControls=true, int X = 0, int Y = 0, int Width = 100, int Height = 15)
        {
            EditEnable = true;

            //Create label and set properties
            label = new Label();
            label.Name = "labelmember" + id.ToString();
            label.Size = new Size(Width, Height);
            left = X;
            top = Y;
            label.Location = new Point(X, Y);
            label.Text = "0";
            label.TabIndex = 20;
            label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            if (addToControls)
            {
                //Add label to control and Show
                control.Add(label);
                label.Show();
                label.BringToFront();


                //Add Events of label            
                label.DoubleClick += new EventHandler(this.label_DblClick);

                //Add tooltip
                setToolTip();
            }
        }

        private void label_DblClick(object sender, EventArgs e)
        {
            if (!EditEnable)
                return;

            //Create textbox and name it
            if (textbox == null)
            {
                textbox = new TextBox();
                textbox.Name = "temporarytextbox";
                textbox.Multiline = false;
            }

            //Set textbox properties
            textbox.Location = label.Location;
            textbox.Top-=3;
            textbox.Width = label.Width;
            textbox.Text = label.Text;
            textbox.Font = label.Font;

            //Add to control and show
            label.Parent.Controls.Add(textbox);
            textbox.Show();
            
            textbox.BringToFront();

            textbox.Select();

            //Add Events to textbox
            textbox.KeyPress += new KeyPressEventHandler(this.textBox_KeyPress);
            textbox.Leave += new EventHandler(this.textBox_Leave);

        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                checkTextBox();
                e.KeyChar = '\n';
            }
        }

        private void checkTextBox()
        {
            double D;            
            if (double.TryParse(textbox.Text, out D))
            {
                label.Text = D.ToString();
                textbox.Hide();
                setToolTip();
            }
            else
            {
                MessageBox.Show("Invalid double value !", "Error!");
                textbox.Select();
                textbox.SelectAll();
            }
        }

        private void textBox_Leave(object sender, EventArgs e)
        {
            double D;
            if (double.TryParse(textbox.Text, out D))
                label.Text = D.ToString();

            setToolTip();
            textbox.Hide();

        }

        public double Value
        {
            get
            {
                double D;
                if (double.TryParse(label.Text, out D))
                    return D;
                else
                    return 0;
            }
            set
            {
                label.Text = value.ToString();
            }

        }

        public void setToolTip()
        {

            if (tooltip == null)
            {
                tooltip = new ToolTip();
                tooltip.AutoPopDelay = 5000;
                tooltip.InitialDelay = 1000;
                tooltip.ReshowDelay = 500;
                tooltip.ShowAlways = true;
            }


            tooltip.SetToolTip(this.label, this.label.Text);         
        }

    }
}
