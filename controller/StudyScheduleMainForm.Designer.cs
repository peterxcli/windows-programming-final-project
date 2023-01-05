namespace life_assistant.controller;

partial class StudyScheduleMainForm
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.subject = new System.Windows.Forms.ColumnHeader();
            this.problem = new System.Windows.Forms.ColumnHeader();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.hScrollBar0 = new System.Windows.Forms.HScrollBar();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.hScrollBar3 = new System.Windows.Forms.HScrollBar();
            this.hScrollBar4 = new System.Windows.Forms.HScrollBar();
            this.hScrollBar5 = new System.Windows.Forms.HScrollBar();
            this.label1 = new MaterialSkin.Controls.MaterialLabel();
            this.Math = new MaterialSkin.Controls.MaterialLabel();
            this.label3 = new MaterialSkin.Controls.MaterialLabel();
            this.label4 = new MaterialSkin.Controls.MaterialLabel();
            this.label5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new MaterialSkin.Controls.MaterialLabel();
            this.label7 = new MaterialSkin.Controls.MaterialLabel();
            this.label8 = new MaterialSkin.Controls.MaterialLabel();
            this.label9 = new MaterialSkin.Controls.MaterialLabel();
            this.label10 = new MaterialSkin.Controls.MaterialLabel();
            this.hScrollBar2 = new System.Windows.Forms.HScrollBar();
            this.label11 = new MaterialSkin.Controls.MaterialLabel();
            this.hScrollBar6 = new System.Windows.Forms.HScrollBar();
            this.label2 = new MaterialSkin.Controls.MaterialLabel();
            this.l1 = new MaterialSkin.Controls.MaterialLabel();
            this.label12 = new MaterialSkin.Controls.MaterialLabel();
            this.label13 = new MaterialSkin.Controls.MaterialLabel();
            this.label14 = new MaterialSkin.Controls.MaterialLabel();
            this.label15 = new MaterialSkin.Controls.MaterialLabel();
            this.label16 = new MaterialSkin.Controls.MaterialLabel();
            this.label17 = new MaterialSkin.Controls.MaterialLabel();
            this.l7 = new MaterialSkin.Controls.MaterialLabel();
            this.l6 = new MaterialSkin.Controls.MaterialLabel();
            this.l5 = new MaterialSkin.Controls.MaterialLabel();
            this.l4 = new MaterialSkin.Controls.MaterialLabel();
            this.l3 = new MaterialSkin.Controls.MaterialLabel();
            this.l2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialButton4 = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.subject,
            this.problem});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(9, 129);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(483, 405);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "number";
            this.columnHeader4.Width = 90;
            // 
            // subject
            // 
            this.subject.Text = "subject";
            this.subject.Width = 80;
            // 
            // problem
            // 
            this.problem.Text = "problem";
            this.problem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.problem.Width = 400;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView2.GridLines = true;
            this.listView2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listView2.Location = new System.Drawing.Point(524, 129);
            this.listView2.Margin = new System.Windows.Forms.Padding(2);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(234, 405);
            this.listView2.TabIndex = 1;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Date";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Subject  ";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Section";
            this.columnHeader3.Width = 100;
            // 
            // hScrollBar0
            // 
            this.hScrollBar0.Location = new System.Drawing.Point(864, 158);
            this.hScrollBar0.Maximum = 109;
            this.hScrollBar0.Name = "hScrollBar0";
            this.hScrollBar0.Size = new System.Drawing.Size(132, 26);
            this.hScrollBar0.TabIndex = 2;
            this.hScrollBar0.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(864, 207);
            this.hScrollBar1.Maximum = 109;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(132, 26);
            this.hScrollBar1.TabIndex = 3;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar2_Scroll);
            // 
            // hScrollBar3
            // 
            this.hScrollBar3.Location = new System.Drawing.Point(864, 324);
            this.hScrollBar3.Maximum = 109;
            this.hScrollBar3.Name = "hScrollBar3";
            this.hScrollBar3.Size = new System.Drawing.Size(132, 26);
            this.hScrollBar3.TabIndex = 4;
            this.hScrollBar3.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar3_Scroll);
            // 
            // hScrollBar4
            // 
            this.hScrollBar4.Location = new System.Drawing.Point(864, 389);
            this.hScrollBar4.Maximum = 109;
            this.hScrollBar4.Name = "hScrollBar4";
            this.hScrollBar4.Size = new System.Drawing.Size(132, 26);
            this.hScrollBar4.TabIndex = 5;
            this.hScrollBar4.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar4_Scroll);
            // 
            // hScrollBar5
            // 
            this.hScrollBar5.Location = new System.Drawing.Point(864, 444);
            this.hScrollBar5.Maximum = 109;
            this.hScrollBar5.Name = "hScrollBar5";
            this.hScrollBar5.Size = new System.Drawing.Size(132, 26);
            this.hScrollBar5.TabIndex = 6;
            this.hScrollBar5.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar5_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Depth = 0;
            this.label1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(770, 158);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.MouseState = MaterialSkin.MouseState.HOVER;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Chinese";
            // 
            // Math
            // 
            this.Math.AutoSize = true;
            this.Math.Depth = 0;
            this.Math.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Math.Location = new System.Drawing.Point(770, 207);
            this.Math.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Math.MouseState = MaterialSkin.MouseState.HOVER;
            this.Math.Name = "Math";
            this.Math.Size = new System.Drawing.Size(73, 19);
            this.Math.TabIndex = 8;
            this.Math.Text = "psycology";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Depth = 0;
            this.label3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label3.Location = new System.Drawing.Point(770, 324);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.MouseState = MaterialSkin.MouseState.HOVER;
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Calculus";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Depth = 0;
            this.label4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label4.Location = new System.Drawing.Point(770, 389);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.MouseState = MaterialSkin.MouseState.HOVER;
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Pd1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Depth = 0;
            this.label5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label5.Location = new System.Drawing.Point(770, 444);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.MouseState = MaterialSkin.MouseState.HOVER;
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "English";
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(23, 542);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(106, 38);
            this.materialButton1.TabIndex = 12;
            this.materialButton1.Text = "Add a problem";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSize = false;
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(201, 542);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(110, 38);
            this.materialButton2.TabIndex = 13;
            this.materialButton2.Text = "Delete a Problem";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // materialButton3
            // 
            this.materialButton3.AutoSize = false;
            this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton3.Depth = 0;
            this.materialButton3.HighEmphasis = true;
            this.materialButton3.Icon = null;
            this.materialButton3.Location = new System.Drawing.Point(605, 548);
            this.materialButton3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton3.Size = new System.Drawing.Size(106, 38);
            this.materialButton3.TabIndex = 14;
            this.materialButton3.Text = "Add a plan";
            this.materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton3.UseAccentColor = false;
            this.materialButton3.UseVisualStyleBackColor = true;
            this.materialButton3.Click += new System.EventHandler(this.materialButton3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(327, 542);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(35, 27);
            this.textBox1.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Depth = 0;
            this.label6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label6.Location = new System.Drawing.Point(317, 570);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.MouseState = MaterialSkin.MouseState.HOVER;
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(263, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "(Please enter the number of problem)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Depth = 0;
            this.label7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label7.Location = new System.Drawing.Point(201, 86);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.MouseState = MaterialSkin.MouseState.HOVER;
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 19);
            this.label7.TabIndex = 17;
            this.label7.Text = "Problem recorder";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Depth = 0;
            this.label8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label8.Location = new System.Drawing.Point(596, 86);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.MouseState = MaterialSkin.MouseState.HOVER;
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 19);
            this.label8.TabIndex = 18;
            this.label8.Text = "Study Plan";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Depth = 0;
            this.label9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label9.Location = new System.Drawing.Point(820, 86);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.MouseState = MaterialSkin.MouseState.HOVER;
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 19);
            this.label9.TabIndex = 19;
            this.label9.Text = "Your Study Progress";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Depth = 0;
            this.label10.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label10.Location = new System.Drawing.Point(770, 265);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.MouseState = MaterialSkin.MouseState.HOVER;
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 19);
            this.label10.TabIndex = 21;
            this.label10.Text = "Science";
            // 
            // hScrollBar2
            // 
            this.hScrollBar2.Location = new System.Drawing.Point(864, 265);
            this.hScrollBar2.Maximum = 109;
            this.hScrollBar2.Name = "hScrollBar2";
            this.hScrollBar2.Size = new System.Drawing.Size(132, 26);
            this.hScrollBar2.TabIndex = 20;
            this.hScrollBar2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar6_Scroll);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Depth = 0;
            this.label11.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label11.Location = new System.Drawing.Point(770, 494);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.MouseState = MaterialSkin.MouseState.HOVER;
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 19);
            this.label11.TabIndex = 23;
            this.label11.Text = "Electronics";
            // 
            // hScrollBar6
            // 
            this.hScrollBar6.Location = new System.Drawing.Point(864, 494);
            this.hScrollBar6.Maximum = 109;
            this.hScrollBar6.Name = "hScrollBar6";
            this.hScrollBar6.Size = new System.Drawing.Size(132, 26);
            this.hScrollBar6.TabIndex = 22;
            this.hScrollBar6.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar7_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Depth = 0;
            this.label2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.Location = new System.Drawing.Point(1038, 496);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.MouseState = MaterialSkin.MouseState.HOVER;
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 19);
            this.label2.TabIndex = 24;
            this.label2.Text = "%";
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Depth = 0;
            this.l1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.l1.Location = new System.Drawing.Point(1001, 161);
            this.l1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l1.MouseState = MaterialSkin.MouseState.HOVER;
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(10, 19);
            this.l1.TabIndex = 25;
            this.l1.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Depth = 0;
            this.label12.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label12.Location = new System.Drawing.Point(1038, 210);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.MouseState = MaterialSkin.MouseState.HOVER;
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 19);
            this.label12.TabIndex = 26;
            this.label12.Text = "%";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Depth = 0;
            this.label13.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label13.Location = new System.Drawing.Point(1038, 267);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.MouseState = MaterialSkin.MouseState.HOVER;
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 19);
            this.label13.TabIndex = 27;
            this.label13.Text = "%";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Depth = 0;
            this.label14.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label14.Location = new System.Drawing.Point(1038, 327);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.MouseState = MaterialSkin.MouseState.HOVER;
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 19);
            this.label14.TabIndex = 28;
            this.label14.Text = "%";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Depth = 0;
            this.label15.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label15.Location = new System.Drawing.Point(1038, 161);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.MouseState = MaterialSkin.MouseState.HOVER;
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(13, 19);
            this.label15.TabIndex = 29;
            this.label15.Text = "%";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Depth = 0;
            this.label16.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label16.Location = new System.Drawing.Point(1038, 389);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.MouseState = MaterialSkin.MouseState.HOVER;
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(13, 19);
            this.label16.TabIndex = 30;
            this.label16.Text = "%";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Depth = 0;
            this.label17.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label17.Location = new System.Drawing.Point(1038, 444);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.MouseState = MaterialSkin.MouseState.HOVER;
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(13, 19);
            this.label17.TabIndex = 31;
            this.label17.Text = "%";
            // 
            // l7
            // 
            this.l7.AutoSize = true;
            this.l7.Depth = 0;
            this.l7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.l7.Location = new System.Drawing.Point(1001, 494);
            this.l7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l7.MouseState = MaterialSkin.MouseState.HOVER;
            this.l7.Name = "l7";
            this.l7.Size = new System.Drawing.Size(10, 19);
            this.l7.TabIndex = 32;
            this.l7.Text = "0";
            this.l7.Click += new System.EventHandler(this.l7_Click);
            // 
            // l6
            // 
            this.l6.AutoSize = true;
            this.l6.Depth = 0;
            this.l6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.l6.Location = new System.Drawing.Point(1001, 447);
            this.l6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l6.MouseState = MaterialSkin.MouseState.HOVER;
            this.l6.Name = "l6";
            this.l6.Size = new System.Drawing.Size(10, 19);
            this.l6.TabIndex = 33;
            this.l6.Text = "0";
            // 
            // l5
            // 
            this.l5.AutoSize = true;
            this.l5.Depth = 0;
            this.l5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.l5.Location = new System.Drawing.Point(1001, 389);
            this.l5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l5.MouseState = MaterialSkin.MouseState.HOVER;
            this.l5.Name = "l5";
            this.l5.Size = new System.Drawing.Size(10, 19);
            this.l5.TabIndex = 34;
            this.l5.Text = "0";
            // 
            // l4
            // 
            this.l4.AutoSize = true;
            this.l4.Depth = 0;
            this.l4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.l4.Location = new System.Drawing.Point(1001, 327);
            this.l4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l4.MouseState = MaterialSkin.MouseState.HOVER;
            this.l4.Name = "l4";
            this.l4.Size = new System.Drawing.Size(10, 19);
            this.l4.TabIndex = 35;
            this.l4.Text = "0";
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.Depth = 0;
            this.l3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.l3.Location = new System.Drawing.Point(1001, 267);
            this.l3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l3.MouseState = MaterialSkin.MouseState.HOVER;
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(10, 19);
            this.l3.TabIndex = 36;
            this.l3.Text = "0";
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Depth = 0;
            this.l2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.l2.Location = new System.Drawing.Point(1001, 210);
            this.l2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l2.MouseState = MaterialSkin.MouseState.HOVER;
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(10, 19);
            this.l2.TabIndex = 37;
            this.l2.Text = "0";
            // 
            // materialButton4
            // 
            this.materialButton4.AutoSize = false;
            this.materialButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton4.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton4.Depth = 0;
            this.materialButton4.HighEmphasis = true;
            this.materialButton4.Icon = null;
            this.materialButton4.Location = new System.Drawing.Point(953, 544);
            this.materialButton4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.materialButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton4.Name = "materialButton4";
            this.materialButton4.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton4.Size = new System.Drawing.Size(106, 38);
            this.materialButton4.TabIndex = 38;
            this.materialButton4.Text = "Save";
            this.materialButton4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton4.UseAccentColor = false;
            this.materialButton4.UseVisualStyleBackColor = true;
            this.materialButton4.Click += new System.EventHandler(this.materialButton4_Click);
            // 
            // StudyScheduleMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 613);
            this.Controls.Add(this.materialButton4);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.l3);
            this.Controls.Add(this.l4);
            this.Controls.Add(this.l5);
            this.Controls.Add(this.l6);
            this.Controls.Add(this.l7);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.hScrollBar6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.hScrollBar2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.materialButton3);
            this.Controls.Add(this.materialButton2);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Math);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hScrollBar5);
            this.Controls.Add(this.hScrollBar4);
            this.Controls.Add(this.hScrollBar3);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.hScrollBar0);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StudyScheduleMainForm";
            this.Padding = new System.Windows.Forms.Padding(2, 53, 2, 2);
            this.Text = "Study Schedule";
            this.Load += new System.EventHandler(this.study_schedule_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    public ListView listView1;
    private ColumnHeader subject;
    private ColumnHeader problem;
    public ListView listView2;
    private ColumnHeader columnHeader1;
    private ColumnHeader columnHeader2;
    private ColumnHeader columnHeader3;
    private HScrollBar hScrollBar0;
    private HScrollBar hScrollBar1;
    private HScrollBar hScrollBar3;
    private HScrollBar hScrollBar4;
    private HScrollBar hScrollBar5;
    private MaterialSkin.Controls.MaterialLabel label1;
    private MaterialSkin.Controls.MaterialLabel Math;
    private MaterialSkin.Controls.MaterialLabel label3;
    private MaterialSkin.Controls.MaterialLabel label4;
    private MaterialSkin.Controls.MaterialLabel label5;
    private MaterialSkin.Controls.MaterialButton materialButton1;
    private MaterialSkin.Controls.MaterialButton materialButton2;
    private MaterialSkin.Controls.MaterialButton materialButton3;
    private ColumnHeader columnHeader4;
    private TextBox textBox1;
    private MaterialSkin.Controls.MaterialLabel label6;
    private MaterialSkin.Controls.MaterialLabel label7;
    private MaterialSkin.Controls.MaterialLabel label8;
    private MaterialSkin.Controls.MaterialLabel label9;
    private MaterialSkin.Controls.MaterialLabel label10;
    private HScrollBar hScrollBar2;
    private MaterialSkin.Controls.MaterialLabel label11;
    private HScrollBar hScrollBar6;
    private MaterialSkin.Controls.MaterialLabel label2;
    private MaterialSkin.Controls.MaterialLabel l1;
    private MaterialSkin.Controls.MaterialLabel label12;
    private MaterialSkin.Controls.MaterialLabel label13;
    private MaterialSkin.Controls.MaterialLabel label14;
    private MaterialSkin.Controls.MaterialLabel label15;
    private MaterialSkin.Controls.MaterialLabel label16;
    private MaterialSkin.Controls.MaterialLabel label17;
    private MaterialSkin.Controls.MaterialLabel l7;
    private MaterialSkin.Controls.MaterialLabel l6;
    private MaterialSkin.Controls.MaterialLabel l5;
    private MaterialSkin.Controls.MaterialLabel l4;
    private MaterialSkin.Controls.MaterialLabel l3;
    private MaterialSkin.Controls.MaterialLabel l2;
    private MaterialSkin.Controls.MaterialButton materialButton4;
}