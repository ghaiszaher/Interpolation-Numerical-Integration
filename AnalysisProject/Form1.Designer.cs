namespace AnalysisProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.drawPanel = new System.Windows.Forms.Panel();
            this.functionBtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.lagrangeFunctionGroupBox = new System.Windows.Forms.GroupBox();
            this.getYBtn_Lagrange = new System.Windows.Forms.Button();
            this.label_YValue_Lagrange = new System.Windows.Forms.Label();
            this.lagrangeYLabel = new System.Windows.Forms.Label();
            this.textBox_lagrange = new System.Windows.Forms.TextBox();
            this.lagrangeEnterxLabel = new System.Windows.Forms.Label();
            this.newtonFunctionGroupBox = new System.Windows.Forms.GroupBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label_function_Newton_Forward = new System.Windows.Forms.Label();
            this.getYBtn_Forward = new System.Windows.Forms.Button();
            this.label_YValue_Forward = new System.Windows.Forms.Label();
            this.forwardYLabel = new System.Windows.Forms.Label();
            this.textBox_newton_forward = new System.Windows.Forms.TextBox();
            this.forwardEnterxLabel = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.getYBtn_Backward = new System.Windows.Forms.Button();
            this.label_YValue_Backward = new System.Windows.Forms.Label();
            this.backwardYLabel = new System.Windows.Forms.Label();
            this.textBox_newton_backward = new System.Windows.Forms.TextBox();
            this.backwardEnterxLabel = new System.Windows.Forms.Label();
            this.table1GroupBox = new System.Windows.Forms.GroupBox();
            this.table1Panel = new System.Windows.Forms.Panel();
            this.nbPointsLabel = new System.Windows.Forms.Label();
            this.nbPointsTextBox = new System.Windows.Forms.TextBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox_Integration_Result = new System.Windows.Forms.GroupBox();
            this.label_Trapezoida_Result = new System.Windows.Forms.Label();
            this.label_Simpson_Result = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Table_Reset = new System.Windows.Forms.Button();
            this.groupBox_Integration_Func = new System.Windows.Forms.GroupBox();
            this.button_Func_GetValue = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label_Func_Instructions = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Func_fx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Function_b = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Function_a = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Function_nbPoints = new System.Windows.Forms.TextBox();
            this.groupBox_Integration_Table = new System.Windows.Forms.GroupBox();
            this.label_Table_Instructions = new System.Windows.Forms.Label();
            this.Btn_Table_GetValue = new System.Windows.Forms.Button();
            this.table2Panel = new System.Windows.Forms.Panel();
            this.label_function_Lagrange = new System.Windows.Forms.Label();
            this.label_function_Newton_Backward = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.lagrangeFunctionGroupBox.SuspendLayout();
            this.newtonFunctionGroupBox.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.table1GroupBox.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox_Integration_Result.SuspendLayout();
            this.groupBox_Integration_Func.SuspendLayout();
            this.groupBox_Integration_Table.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(850, 700);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.drawPanel);
            this.tabPage1.Controls.Add(this.functionBtn);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.instructionLabel);
            this.tabPage1.Controls.Add(this.lagrangeFunctionGroupBox);
            this.tabPage1.Controls.Add(this.newtonFunctionGroupBox);
            this.tabPage1.Controls.Add(this.table1GroupBox);
            this.tabPage1.Controls.Add(this.nbPointsLabel);
            this.tabPage1.Controls.Add(this.nbPointsTextBox);
            this.tabPage1.Controls.Add(this.submitBtn);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(842, 674);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Interpolation الاستيفاء";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // drawPanel
            // 
            this.drawPanel.Location = new System.Drawing.Point(7, 395);
            this.drawPanel.Name = "drawPanel";
            this.drawPanel.Size = new System.Drawing.Size(827, 273);
            this.drawPanel.TabIndex = 12;
            // 
            // functionBtn
            // 
            this.functionBtn.Enabled = false;
            this.functionBtn.Location = new System.Drawing.Point(224, 354);
            this.functionBtn.Name = "functionBtn";
            this.functionBtn.Size = new System.Drawing.Size(294, 33);
            this.functionBtn.TabIndex = 3;
            this.functionBtn.Text = "Complete Table And Get Function إكمال الجدول وإظهار التابع";
            this.functionBtn.UseVisualStyleBackColor = true;
            this.functionBtn.Click += new System.EventHandler(this.functionBtn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(110, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "(n+1)";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button1.Location = new System.Drawing.Point(405, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 25);
            this.button1.TabIndex = 6;
            this.button1.Text = "Reset إعادة ضبط";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // instructionLabel
            // 
            this.instructionLabel.Location = new System.Drawing.Point(16, 355);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(214, 33);
            this.instructionLabel.TabIndex = 7;
            this.instructionLabel.Text = "Double Click on any x or f(x) to edit its value, then press enter.";
            // 
            // lagrangeFunctionGroupBox
            // 
            this.lagrangeFunctionGroupBox.Controls.Add(this.label_function_Lagrange);
            this.lagrangeFunctionGroupBox.Controls.Add(this.getYBtn_Lagrange);
            this.lagrangeFunctionGroupBox.Controls.Add(this.label_YValue_Lagrange);
            this.lagrangeFunctionGroupBox.Controls.Add(this.lagrangeYLabel);
            this.lagrangeFunctionGroupBox.Controls.Add(this.textBox_lagrange);
            this.lagrangeFunctionGroupBox.Controls.Add(this.lagrangeEnterxLabel);
            this.lagrangeFunctionGroupBox.Enabled = false;
            this.lagrangeFunctionGroupBox.Location = new System.Drawing.Point(537, 215);
            this.lagrangeFunctionGroupBox.Name = "lagrangeFunctionGroupBox";
            this.lagrangeFunctionGroupBox.Size = new System.Drawing.Size(290, 169);
            this.lagrangeFunctionGroupBox.TabIndex = 5;
            this.lagrangeFunctionGroupBox.TabStop = false;
            this.lagrangeFunctionGroupBox.Text = "Function (Lagrange) التابع - استيفاء لاغرانج";
            // 
            // getYBtn_Lagrange
            // 
            this.getYBtn_Lagrange.Location = new System.Drawing.Point(195, 133);
            this.getYBtn_Lagrange.Name = "getYBtn_Lagrange";
            this.getYBtn_Lagrange.Size = new System.Drawing.Size(75, 23);
            this.getYBtn_Lagrange.TabIndex = 7;
            this.getYBtn_Lagrange.Text = "Get Y";
            this.getYBtn_Lagrange.UseVisualStyleBackColor = true;
            this.getYBtn_Lagrange.Click += new System.EventHandler(this.getYBtn_Lagrange_Click);
            // 
            // label_YValue_Lagrange
            // 
            this.label_YValue_Lagrange.Location = new System.Drawing.Point(57, 109);
            this.label_YValue_Lagrange.Name = "label_YValue_Lagrange";
            this.label_YValue_Lagrange.Size = new System.Drawing.Size(175, 13);
            this.label_YValue_Lagrange.TabIndex = 5;
            // 
            // lagrangeYLabel
            // 
            this.lagrangeYLabel.AutoSize = true;
            this.lagrangeYLabel.Location = new System.Drawing.Point(24, 109);
            this.lagrangeYLabel.Name = "lagrangeYLabel";
            this.lagrangeYLabel.Size = new System.Drawing.Size(26, 13);
            this.lagrangeYLabel.TabIndex = 3;
            this.lagrangeYLabel.Text = "Y = ";
            // 
            // textBox_lagrange
            // 
            this.textBox_lagrange.Location = new System.Drawing.Point(72, 71);
            this.textBox_lagrange.Name = "textBox_lagrange";
            this.textBox_lagrange.Size = new System.Drawing.Size(100, 20);
            this.textBox_lagrange.TabIndex = 3;
            // 
            // lagrangeEnterxLabel
            // 
            this.lagrangeEnterxLabel.AutoSize = true;
            this.lagrangeEnterxLabel.Location = new System.Drawing.Point(20, 74);
            this.lagrangeEnterxLabel.Name = "lagrangeEnterxLabel";
            this.lagrangeEnterxLabel.Size = new System.Drawing.Size(46, 13);
            this.lagrangeEnterxLabel.TabIndex = 1;
            this.lagrangeEnterxLabel.Text = "Enter x :";
            // 
            // newtonFunctionGroupBox
            // 
            this.newtonFunctionGroupBox.Controls.Add(this.tabControl2);
            this.newtonFunctionGroupBox.Enabled = false;
            this.newtonFunctionGroupBox.Location = new System.Drawing.Point(537, 13);
            this.newtonFunctionGroupBox.Name = "newtonFunctionGroupBox";
            this.newtonFunctionGroupBox.Size = new System.Drawing.Size(290, 196);
            this.newtonFunctionGroupBox.TabIndex = 4;
            this.newtonFunctionGroupBox.TabStop = false;
            this.newtonFunctionGroupBox.Text = "Function (Newton) التابع - استيفاء نيوتن";
            // 
            // tabControl2
            // 
            this.tabControl2.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(4, 15);
            this.tabControl2.Multiline = true;
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(280, 175);
            this.tabControl2.TabIndex = 7;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label_function_Newton_Forward);
            this.tabPage3.Controls.Add(this.getYBtn_Forward);
            this.tabPage3.Controls.Add(this.label_YValue_Forward);
            this.tabPage3.Controls.Add(this.forwardYLabel);
            this.tabPage3.Controls.Add(this.textBox_newton_forward);
            this.tabPage3.Controls.Add(this.forwardEnterxLabel);
            this.tabPage3.Location = new System.Drawing.Point(4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(253, 167);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "تقدمي";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label_function_Newton_Forward
            // 
            this.label_function_Newton_Forward.AutoSize = true;
            this.label_function_Newton_Forward.Location = new System.Drawing.Point(7, 26);
            this.label_function_Newton_Forward.Name = "label_function_Newton_Forward";
            this.label_function_Newton_Forward.Size = new System.Drawing.Size(70, 13);
            this.label_function_Newton_Forward.TabIndex = 12;
            this.label_function_Newton_Forward.Text = "The Function";
            // 
            // getYBtn_Forward
            // 
            this.getYBtn_Forward.Location = new System.Drawing.Point(163, 138);
            this.getYBtn_Forward.Name = "getYBtn_Forward";
            this.getYBtn_Forward.Size = new System.Drawing.Size(75, 23);
            this.getYBtn_Forward.TabIndex = 11;
            this.getYBtn_Forward.Text = "Get Y";
            this.getYBtn_Forward.UseVisualStyleBackColor = true;
            this.getYBtn_Forward.Click += new System.EventHandler(this.getYBtn_Forward_Click);
            // 
            // label_YValue_Forward
            // 
            this.label_YValue_Forward.Location = new System.Drawing.Point(44, 103);
            this.label_YValue_Forward.Name = "label_YValue_Forward";
            this.label_YValue_Forward.Size = new System.Drawing.Size(175, 13);
            this.label_YValue_Forward.TabIndex = 5;
            // 
            // forwardYLabel
            // 
            this.forwardYLabel.AutoSize = true;
            this.forwardYLabel.Location = new System.Drawing.Point(11, 103);
            this.forwardYLabel.Name = "forwardYLabel";
            this.forwardYLabel.Size = new System.Drawing.Size(26, 13);
            this.forwardYLabel.TabIndex = 10;
            this.forwardYLabel.Text = "Y = ";
            // 
            // textBox_newton_forward
            // 
            this.textBox_newton_forward.Location = new System.Drawing.Point(59, 64);
            this.textBox_newton_forward.Name = "textBox_newton_forward";
            this.textBox_newton_forward.Size = new System.Drawing.Size(100, 20);
            this.textBox_newton_forward.TabIndex = 9;
            // 
            // forwardEnterxLabel
            // 
            this.forwardEnterxLabel.AutoSize = true;
            this.forwardEnterxLabel.Location = new System.Drawing.Point(7, 67);
            this.forwardEnterxLabel.Name = "forwardEnterxLabel";
            this.forwardEnterxLabel.Size = new System.Drawing.Size(46, 13);
            this.forwardEnterxLabel.TabIndex = 7;
            this.forwardEnterxLabel.Text = "Enter x :";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label_function_Newton_Backward);
            this.tabPage4.Controls.Add(this.getYBtn_Backward);
            this.tabPage4.Controls.Add(this.label_YValue_Backward);
            this.tabPage4.Controls.Add(this.backwardYLabel);
            this.tabPage4.Controls.Add(this.textBox_newton_backward);
            this.tabPage4.Controls.Add(this.backwardEnterxLabel);
            this.tabPage4.Location = new System.Drawing.Point(4, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(253, 167);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "تراجعي";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // getYBtn_Backward
            // 
            this.getYBtn_Backward.Location = new System.Drawing.Point(163, 138);
            this.getYBtn_Backward.Name = "getYBtn_Backward";
            this.getYBtn_Backward.Size = new System.Drawing.Size(75, 23);
            this.getYBtn_Backward.TabIndex = 17;
            this.getYBtn_Backward.Text = "Get Y";
            this.getYBtn_Backward.UseVisualStyleBackColor = true;
            this.getYBtn_Backward.Click += new System.EventHandler(this.getYBtn_Backward_Click);
            // 
            // label_YValue_Backward
            // 
            this.label_YValue_Backward.Location = new System.Drawing.Point(44, 103);
            this.label_YValue_Backward.Name = "label_YValue_Backward";
            this.label_YValue_Backward.Size = new System.Drawing.Size(175, 13);
            this.label_YValue_Backward.TabIndex = 12;
            // 
            // backwardYLabel
            // 
            this.backwardYLabel.AutoSize = true;
            this.backwardYLabel.Location = new System.Drawing.Point(11, 103);
            this.backwardYLabel.Name = "backwardYLabel";
            this.backwardYLabel.Size = new System.Drawing.Size(26, 13);
            this.backwardYLabel.TabIndex = 16;
            this.backwardYLabel.Text = "Y = ";
            // 
            // textBox_newton_backward
            // 
            this.textBox_newton_backward.Location = new System.Drawing.Point(59, 64);
            this.textBox_newton_backward.Name = "textBox_newton_backward";
            this.textBox_newton_backward.Size = new System.Drawing.Size(100, 20);
            this.textBox_newton_backward.TabIndex = 15;
            // 
            // backwardEnterxLabel
            // 
            this.backwardEnterxLabel.AutoSize = true;
            this.backwardEnterxLabel.Location = new System.Drawing.Point(7, 67);
            this.backwardEnterxLabel.Name = "backwardEnterxLabel";
            this.backwardEnterxLabel.Size = new System.Drawing.Size(46, 13);
            this.backwardEnterxLabel.TabIndex = 13;
            this.backwardEnterxLabel.Text = "Enter x :";
            // 
            // table1GroupBox
            // 
            this.table1GroupBox.Controls.Add(this.table1Panel);
            this.table1GroupBox.Enabled = false;
            this.table1GroupBox.Location = new System.Drawing.Point(9, 58);
            this.table1GroupBox.Name = "table1GroupBox";
            this.table1GroupBox.Size = new System.Drawing.Size(511, 290);
            this.table1GroupBox.TabIndex = 2;
            this.table1GroupBox.TabStop = false;
            this.table1GroupBox.Text = "Table of Forward \\ Backward Differences - جدول الفروق التقدمية / التراجعية";
            // 
            // table1Panel
            // 
            this.table1Panel.AutoScroll = true;
            this.table1Panel.Location = new System.Drawing.Point(7, 20);
            this.table1Panel.Name = "table1Panel";
            this.table1Panel.Size = new System.Drawing.Size(497, 264);
            this.table1Panel.TabIndex = 0;
            // 
            // nbPointsLabel
            // 
            this.nbPointsLabel.AutoSize = true;
            this.nbPointsLabel.Location = new System.Drawing.Point(29, 22);
            this.nbPointsLabel.Name = "nbPointsLabel";
            this.nbPointsLabel.Size = new System.Drawing.Size(113, 13);
            this.nbPointsLabel.TabIndex = 2;
            this.nbPointsLabel.Text = "Enter number of points";
            // 
            // nbPointsTextBox
            // 
            this.nbPointsTextBox.Location = new System.Drawing.Point(151, 20);
            this.nbPointsTextBox.Name = "nbPointsTextBox";
            this.nbPointsTextBox.Size = new System.Drawing.Size(100, 20);
            this.nbPointsTextBox.TabIndex = 0;
            this.nbPointsTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nbPointsTextBox_KeyPress);
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(266, 17);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(102, 25);
            this.submitBtn.TabIndex = 1;
            this.submitBtn.Tag = "";
            this.submitBtn.Text = "Submit إدخال";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox_Integration_Result);
            this.tabPage2.Controls.Add(this.Btn_Table_Reset);
            this.tabPage2.Controls.Add(this.groupBox_Integration_Func);
            this.tabPage2.Controls.Add(this.groupBox_Integration_Table);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(842, 674);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Integration - التكامل";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox_Integration_Result
            // 
            this.groupBox_Integration_Result.Controls.Add(this.label_Trapezoida_Result);
            this.groupBox_Integration_Result.Controls.Add(this.label_Simpson_Result);
            this.groupBox_Integration_Result.Controls.Add(this.label8);
            this.groupBox_Integration_Result.Controls.Add(this.label6);
            this.groupBox_Integration_Result.Controls.Add(this.label7);
            this.groupBox_Integration_Result.Controls.Add(this.label1);
            this.groupBox_Integration_Result.Enabled = false;
            this.groupBox_Integration_Result.Location = new System.Drawing.Point(644, 13);
            this.groupBox_Integration_Result.Name = "groupBox_Integration_Result";
            this.groupBox_Integration_Result.Size = new System.Drawing.Size(190, 257);
            this.groupBox_Integration_Result.TabIndex = 22;
            this.groupBox_Integration_Result.TabStop = false;
            this.groupBox_Integration_Result.Text = "Integration Result - نتيجة التكامل";
            // 
            // label_Trapezoida_Result
            // 
            this.label_Trapezoida_Result.Location = new System.Drawing.Point(6, 72);
            this.label_Trapezoida_Result.Name = "label_Trapezoida_Result";
            this.label_Trapezoida_Result.Size = new System.Drawing.Size(178, 33);
            this.label_Trapezoida_Result.TabIndex = 2;
            this.label_Trapezoida_Result.Text = "Result";
            this.label_Trapezoida_Result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Simpson_Result
            // 
            this.label_Simpson_Result.Location = new System.Drawing.Point(6, 201);
            this.label_Simpson_Result.Name = "label_Simpson_Result";
            this.label_Simpson_Result.Size = new System.Drawing.Size(178, 33);
            this.label_Simpson_Result.TabIndex = 1;
            this.label_Simpson_Result.Text = "Result";
            this.label_Simpson_Result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "باستخدام طريقة سمبسون";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Using Simpson";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = " باستخدام شبه المنحرف";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Using Trapezoida";
            // 
            // Btn_Table_Reset
            // 
            this.Btn_Table_Reset.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Btn_Table_Reset.Location = new System.Drawing.Point(732, 281);
            this.Btn_Table_Reset.Name = "Btn_Table_Reset";
            this.Btn_Table_Reset.Size = new System.Drawing.Size(102, 25);
            this.Btn_Table_Reset.TabIndex = 13;
            this.Btn_Table_Reset.Text = "Reset إعادة ضبط";
            this.Btn_Table_Reset.UseVisualStyleBackColor = true;
            this.Btn_Table_Reset.Click += new System.EventHandler(this.Btn_Table_Reset_Click);
            // 
            // groupBox_Integration_Func
            // 
            this.groupBox_Integration_Func.Controls.Add(this.button_Func_GetValue);
            this.groupBox_Integration_Func.Controls.Add(this.label11);
            this.groupBox_Integration_Func.Controls.Add(this.label_Func_Instructions);
            this.groupBox_Integration_Func.Controls.Add(this.label5);
            this.groupBox_Integration_Func.Controls.Add(this.textBox_Func_fx);
            this.groupBox_Integration_Func.Controls.Add(this.label4);
            this.groupBox_Integration_Func.Controls.Add(this.textBox_Function_b);
            this.groupBox_Integration_Func.Controls.Add(this.label3);
            this.groupBox_Integration_Func.Controls.Add(this.textBox_Function_a);
            this.groupBox_Integration_Func.Controls.Add(this.label9);
            this.groupBox_Integration_Func.Controls.Add(this.label2);
            this.groupBox_Integration_Func.Controls.Add(this.textBox_Function_nbPoints);
            this.groupBox_Integration_Func.Location = new System.Drawing.Point(12, 13);
            this.groupBox_Integration_Func.Name = "groupBox_Integration_Func";
            this.groupBox_Integration_Func.Size = new System.Drawing.Size(263, 302);
            this.groupBox_Integration_Func.TabIndex = 21;
            this.groupBox_Integration_Func.TabStop = false;
            this.groupBox_Integration_Func.Text = "Integration Using a funtion - التكامل باستخدام تابع";
            // 
            // button_Func_GetValue
            // 
            this.button_Func_GetValue.Location = new System.Drawing.Point(152, 263);
            this.button_Func_GetValue.Name = "button_Func_GetValue";
            this.button_Func_GetValue.Size = new System.Drawing.Size(105, 30);
            this.button_Func_GetValue.TabIndex = 21;
            this.button_Func_GetValue.Text = "Get Table";
            this.button_Func_GetValue.UseVisualStyleBackColor = true;
            this.button_Func_GetValue.Click += new System.EventHandler(this.button_Func_GetValue_Click);
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(7, 175);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(249, 57);
            this.label11.TabIndex = 22;
            this.label11.Text = resources.GetString("label11.Text");
            // 
            // label_Func_Instructions
            // 
            this.label_Func_Instructions.Location = new System.Drawing.Point(6, 243);
            this.label_Func_Instructions.Name = "label_Func_Instructions";
            this.label_Func_Instructions.Size = new System.Drawing.Size(207, 33);
            this.label_Func_Instructions.TabIndex = 14;
            this.label_Func_Instructions.Text = "You can leave f(x)=0 or whatever and enter the table manually";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Enter f(x) :";
            // 
            // textBox_Func_fx
            // 
            this.textBox_Func_fx.Location = new System.Drawing.Point(132, 111);
            this.textBox_Func_fx.Multiline = true;
            this.textBox_Func_fx.Name = "textBox_Func_fx";
            this.textBox_Func_fx.Size = new System.Drawing.Size(125, 57);
            this.textBox_Func_fx.TabIndex = 19;
            this.textBox_Func_fx.Text = "x^2 + 3*x + 2*sin(x)";
            this.textBox_Func_fx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_Func_fx_KeyDown);
            this.textBox_Func_fx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Func_fx_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Enter b :";
            // 
            // textBox_Function_b
            // 
            this.textBox_Function_b.Location = new System.Drawing.Point(132, 82);
            this.textBox_Function_b.Name = "textBox_Function_b";
            this.textBox_Function_b.Size = new System.Drawing.Size(79, 20);
            this.textBox_Function_b.TabIndex = 17;
            this.textBox_Function_b.Text = "10";
            this.textBox_Function_b.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Function_nb_a_b_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Enter a :";
            // 
            // textBox_Function_a
            // 
            this.textBox_Function_a.Location = new System.Drawing.Point(132, 54);
            this.textBox_Function_a.Name = "textBox_Function_a";
            this.textBox_Function_a.Size = new System.Drawing.Size(79, 20);
            this.textBox_Function_a.TabIndex = 15;
            this.textBox_Function_a.Text = "0";
            this.textBox_Function_a.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Function_nb_a_b_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(215, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "(n+1)";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Enter number of points";
            // 
            // textBox_Function_nbPoints
            // 
            this.textBox_Function_nbPoints.Location = new System.Drawing.Point(132, 26);
            this.textBox_Function_nbPoints.Name = "textBox_Function_nbPoints";
            this.textBox_Function_nbPoints.Size = new System.Drawing.Size(79, 20);
            this.textBox_Function_nbPoints.TabIndex = 8;
            this.textBox_Function_nbPoints.Text = "10";
            this.textBox_Function_nbPoints.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Function_nb_a_b_KeyPress);
            // 
            // groupBox_Integration_Table
            // 
            this.groupBox_Integration_Table.Controls.Add(this.label_Table_Instructions);
            this.groupBox_Integration_Table.Controls.Add(this.Btn_Table_GetValue);
            this.groupBox_Integration_Table.Controls.Add(this.table2Panel);
            this.groupBox_Integration_Table.Enabled = false;
            this.groupBox_Integration_Table.Location = new System.Drawing.Point(281, 13);
            this.groupBox_Integration_Table.Name = "groupBox_Integration_Table";
            this.groupBox_Integration_Table.Size = new System.Drawing.Size(356, 302);
            this.groupBox_Integration_Table.TabIndex = 11;
            this.groupBox_Integration_Table.TabStop = false;
            this.groupBox_Integration_Table.Text = "Integration Using Points Table - التكامل باستخدام جدول النقط";
            // 
            // label_Table_Instructions
            // 
            this.label_Table_Instructions.Location = new System.Drawing.Point(18, 263);
            this.label_Table_Instructions.Name = "label_Table_Instructions";
            this.label_Table_Instructions.Size = new System.Drawing.Size(207, 33);
            this.label_Table_Instructions.TabIndex = 14;
            this.label_Table_Instructions.Text = "Double Click on any f(x) to edit its value, then press enter.";
            // 
            // Btn_Table_GetValue
            // 
            this.Btn_Table_GetValue.Location = new System.Drawing.Point(231, 263);
            this.Btn_Table_GetValue.Name = "Btn_Table_GetValue";
            this.Btn_Table_GetValue.Size = new System.Drawing.Size(105, 30);
            this.Btn_Table_GetValue.TabIndex = 12;
            this.Btn_Table_GetValue.Text = "Get Value";
            this.Btn_Table_GetValue.UseVisualStyleBackColor = true;
            this.Btn_Table_GetValue.Click += new System.EventHandler(this.Btn_Table_GetValue_Click);
            // 
            // table2Panel
            // 
            this.table2Panel.AutoScroll = true;
            this.table2Panel.Location = new System.Drawing.Point(17, 19);
            this.table2Panel.Name = "table2Panel";
            this.table2Panel.Size = new System.Drawing.Size(319, 238);
            this.table2Panel.TabIndex = 0;
            // 
            // label_function_Lagrange
            // 
            this.label_function_Lagrange.AutoSize = true;
            this.label_function_Lagrange.Location = new System.Drawing.Point(7, 37);
            this.label_function_Lagrange.Name = "label_function_Lagrange";
            this.label_function_Lagrange.Size = new System.Drawing.Size(70, 13);
            this.label_function_Lagrange.TabIndex = 13;
            this.label_function_Lagrange.Text = "The Function";
            // 
            // label_function_Newton_Backward
            // 
            this.label_function_Newton_Backward.AutoSize = true;
            this.label_function_Newton_Backward.Location = new System.Drawing.Point(7, 26);
            this.label_function_Newton_Backward.Name = "label_function_Newton_Backward";
            this.label_function_Newton_Backward.Size = new System.Drawing.Size(70, 13);
            this.label_function_Newton_Backward.TabIndex = 18;
            this.label_function_Newton_Backward.Text = "The Function";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 708);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Analysis Project";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.lagrangeFunctionGroupBox.ResumeLayout(false);
            this.lagrangeFunctionGroupBox.PerformLayout();
            this.newtonFunctionGroupBox.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.table1GroupBox.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox_Integration_Result.ResumeLayout(false);
            this.groupBox_Integration_Result.PerformLayout();
            this.groupBox_Integration_Func.ResumeLayout(false);
            this.groupBox_Integration_Func.PerformLayout();
            this.groupBox_Integration_Table.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label nbPointsLabel;
        private System.Windows.Forms.TextBox nbPointsTextBox;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.GroupBox table1GroupBox;
        private System.Windows.Forms.GroupBox newtonFunctionGroupBox;
        private System.Windows.Forms.GroupBox lagrangeFunctionGroupBox;
        private System.Windows.Forms.Button functionBtn;
        private System.Windows.Forms.Label lagrangeEnterxLabel;
        private System.Windows.Forms.TextBox textBox_lagrange;
        private System.Windows.Forms.Label lagrangeYLabel;
        private System.Windows.Forms.Label label_YValue_Lagrange;
        private System.Windows.Forms.Label label_YValue_Forward;
        private System.Windows.Forms.Button getYBtn_Lagrange;
        private System.Windows.Forms.Panel table1Panel;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button getYBtn_Forward;
        private System.Windows.Forms.Label forwardYLabel;
        private System.Windows.Forms.TextBox textBox_newton_forward;
        private System.Windows.Forms.Label forwardEnterxLabel;
        private System.Windows.Forms.Button getYBtn_Backward;
        private System.Windows.Forms.Label label_YValue_Backward;
        private System.Windows.Forms.Label backwardYLabel;
        private System.Windows.Forms.TextBox textBox_newton_backward;
        private System.Windows.Forms.Label backwardEnterxLabel;
        private System.Windows.Forms.Button Btn_Table_Reset;
        private System.Windows.Forms.Label label_Table_Instructions;
        private System.Windows.Forms.Button Btn_Table_GetValue;
        private System.Windows.Forms.GroupBox groupBox_Integration_Table;
        private System.Windows.Forms.Panel table2Panel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Function_nbPoints;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Function_a;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Func_fx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Function_b;
        private System.Windows.Forms.GroupBox groupBox_Integration_Func;
        private System.Windows.Forms.Button button_Func_GetValue;
        private System.Windows.Forms.Label label_Func_Instructions;
        private System.Windows.Forms.GroupBox groupBox_Integration_Result;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_Trapezoida_Result;
        private System.Windows.Forms.Label label_Simpson_Result;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel drawPanel;
        private System.Windows.Forms.Label label_function_Newton_Forward;
        private System.Windows.Forms.Label label_function_Lagrange;
        private System.Windows.Forms.Label label_function_Newton_Backward;
    }
}

