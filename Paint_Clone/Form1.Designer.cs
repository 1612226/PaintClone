namespace Paint_Clone
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
            this.clearBtn = new System.Windows.Forms.Button();
            this.mnstripPaint = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbWidth = new System.Windows.Forms.TrackBar();
            this.btnBorderColor = new System.Windows.Forms.Button();
            this.cbbBrush = new System.Windows.Forms.ComboBox();
            this.cbbDashStyle = new System.Windows.Forms.ComboBox();
            this.lbBorderColor = new System.Windows.Forms.Label();
            this.lbFillColor = new System.Windows.Forms.Label();
            this.btnFillColor = new System.Windows.Forms.Button();
            this.panelPenAndBrush = new System.Windows.Forms.Panel();
            this.btnNormal = new System.Windows.Forms.Button();
            this.btnUnderline = new System.Windows.Forms.Button();
            this.btnItalic = new System.Windows.Forms.Button();
            this.btnBold = new System.Windows.Forms.Button();
            this.cbbFontSize = new System.Windows.Forms.ComboBox();
            this.cbbFont = new System.Windows.Forms.ComboBox();
            this.newTextRadio = new System.Windows.Forms.RadioButton();
            this.parabolaRadio = new System.Windows.Forms.RadioButton();
            this.polygonRadio = new System.Windows.Forms.RadioButton();
            this.hyperbolaRadio = new System.Windows.Forms.RadioButton();
            this.parallelogramRadio = new System.Windows.Forms.RadioButton();
            this.ellipseArcRadio = new System.Windows.Forms.RadioButton();
            this.circleArcRadio = new System.Windows.Forms.RadioButton();
            this.circleRadio = new System.Windows.Forms.RadioButton();
            this.brokenLineRadio = new System.Windows.Forms.RadioButton();
            this.bezierRadio = new System.Windows.Forms.RadioButton();
            this.lineRadio = new System.Windows.Forms.RadioButton();
            this.rectRadio = new System.Windows.Forms.RadioButton();
            this.ellipseRadio = new System.Windows.Forms.RadioButton();
            this.rotateRadio = new System.Windows.Forms.RadioButton();
            this.deleteRadio = new System.Windows.Forms.RadioButton();
            this.controlRadio = new System.Windows.Forms.RadioButton();
            this.moveRadio = new System.Windows.Forms.RadioButton();
            this.scaleRadio = new System.Windows.Forms.RadioButton();
            this.selectRadio = new System.Windows.Forms.RadioButton();
            this.pnShapes = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mnstripPaint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbWidth)).BeginInit();
            this.panelPenAndBrush.SuspendLayout();
            this.pnShapes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(1141, 35);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 12;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // mnstripPaint
            // 
            this.mnstripPaint.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mnstripPaint.Location = new System.Drawing.Point(0, 0);
            this.mnstripPaint.Name = "mnstripPaint";
            this.mnstripPaint.Size = new System.Drawing.Size(1262, 24);
            this.mnstripPaint.TabIndex = 21;
            this.mnstripPaint.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // tbWidth
            // 
            this.tbWidth.Location = new System.Drawing.Point(376, 2);
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(100, 45);
            this.tbWidth.TabIndex = 22;
            this.tbWidth.Scroll += new System.EventHandler(this.tbWidth_Scroll);
            // 
            // btnBorderColor
            // 
            this.btnBorderColor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBorderColor.Location = new System.Drawing.Point(251, -2);
            this.btnBorderColor.Name = "btnBorderColor";
            this.btnBorderColor.Size = new System.Drawing.Size(25, 23);
            this.btnBorderColor.TabIndex = 23;
            this.btnBorderColor.UseVisualStyleBackColor = false;
            this.btnBorderColor.Click += new System.EventHandler(this.btnBorderColor_Click);
            // 
            // cbbBrush
            // 
            this.cbbBrush.FormattingEnabled = true;
            this.cbbBrush.Items.AddRange(new object[] {
            "No Fill",
            "Solid Brush",
            "Hatch Brush"});
            this.cbbBrush.Location = new System.Drawing.Point(282, 1);
            this.cbbBrush.Name = "cbbBrush";
            this.cbbBrush.Size = new System.Drawing.Size(88, 21);
            this.cbbBrush.TabIndex = 24;
            this.cbbBrush.Text = "No Fill";
            this.cbbBrush.SelectedIndexChanged += new System.EventHandler(this.cbbBrush_SelectedIndexChanged);
            // 
            // cbbDashStyle
            // 
            this.cbbDashStyle.FormattingEnabled = true;
            this.cbbDashStyle.Items.AddRange(new object[] {
            "PS_SOLID",
            "PS_DOT",
            "PS_DASH",
            "PS_DASHDOT",
            "PS_DASHDOTDOT"});
            this.cbbDashStyle.Location = new System.Drawing.Point(282, 24);
            this.cbbDashStyle.Name = "cbbDashStyle";
            this.cbbDashStyle.Size = new System.Drawing.Size(88, 21);
            this.cbbDashStyle.TabIndex = 25;
            this.cbbDashStyle.Text = "PS_SOLID";
            this.cbbDashStyle.SelectedIndexChanged += new System.EventHandler(this.cbbDashStyle_SelectedIndexChanged);
            // 
            // lbBorderColor
            // 
            this.lbBorderColor.AutoSize = true;
            this.lbBorderColor.Location = new System.Drawing.Point(180, 4);
            this.lbBorderColor.Name = "lbBorderColor";
            this.lbBorderColor.Size = new System.Drawing.Size(65, 13);
            this.lbBorderColor.TabIndex = 27;
            this.lbBorderColor.Text = "Border Color";
            // 
            // lbFillColor
            // 
            this.lbFillColor.AutoSize = true;
            this.lbFillColor.Location = new System.Drawing.Point(199, 27);
            this.lbFillColor.Name = "lbFillColor";
            this.lbFillColor.Size = new System.Drawing.Size(46, 13);
            this.lbFillColor.TabIndex = 28;
            this.lbFillColor.Text = "Fill Color";
            // 
            // btnFillColor
            // 
            this.btnFillColor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFillColor.Location = new System.Drawing.Point(251, 24);
            this.btnFillColor.Name = "btnFillColor";
            this.btnFillColor.Size = new System.Drawing.Size(25, 23);
            this.btnFillColor.TabIndex = 29;
            this.btnFillColor.UseVisualStyleBackColor = false;
            this.btnFillColor.Click += new System.EventHandler(this.btnFillColor_Click);
            // 
            // panelPenAndBrush
            // 
            this.panelPenAndBrush.Controls.Add(this.btnNormal);
            this.panelPenAndBrush.Controls.Add(this.btnUnderline);
            this.panelPenAndBrush.Controls.Add(this.btnItalic);
            this.panelPenAndBrush.Controls.Add(this.btnBold);
            this.panelPenAndBrush.Controls.Add(this.cbbFontSize);
            this.panelPenAndBrush.Controls.Add(this.cbbFont);
            this.panelPenAndBrush.Controls.Add(this.lbBorderColor);
            this.panelPenAndBrush.Controls.Add(this.tbWidth);
            this.panelPenAndBrush.Controls.Add(this.lbFillColor);
            this.panelPenAndBrush.Controls.Add(this.cbbBrush);
            this.panelPenAndBrush.Controls.Add(this.cbbDashStyle);
            this.panelPenAndBrush.Controls.Add(this.btnFillColor);
            this.panelPenAndBrush.Controls.Add(this.btnBorderColor);
            this.panelPenAndBrush.Location = new System.Drawing.Point(656, 35);
            this.panelPenAndBrush.Name = "panelPenAndBrush";
            this.panelPenAndBrush.Size = new System.Drawing.Size(479, 68);
            this.panelPenAndBrush.TabIndex = 32;
            // 
            // btnNormal
            // 
            this.btnNormal.BackgroundImage = global::Paint_Clone.Properties.Resources.normal2;
            this.btnNormal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNormal.Location = new System.Drawing.Point(144, 24);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(22, 23);
            this.btnNormal.TabIndex = 35;
            this.btnNormal.UseVisualStyleBackColor = true;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // btnUnderline
            // 
            this.btnUnderline.BackgroundImage = global::Paint_Clone.Properties.Resources.Underline;
            this.btnUnderline.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUnderline.Location = new System.Drawing.Point(116, 24);
            this.btnUnderline.Name = "btnUnderline";
            this.btnUnderline.Size = new System.Drawing.Size(22, 23);
            this.btnUnderline.TabIndex = 34;
            this.btnUnderline.UseVisualStyleBackColor = true;
            this.btnUnderline.Click += new System.EventHandler(this.btnUnderline_Click);
            // 
            // btnItalic
            // 
            this.btnItalic.BackgroundImage = global::Paint_Clone.Properties.Resources.Italic;
            this.btnItalic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnItalic.Location = new System.Drawing.Point(88, 24);
            this.btnItalic.Name = "btnItalic";
            this.btnItalic.Size = new System.Drawing.Size(22, 23);
            this.btnItalic.TabIndex = 33;
            this.btnItalic.UseVisualStyleBackColor = true;
            this.btnItalic.Click += new System.EventHandler(this.btnItalic_Click);
            // 
            // btnBold
            // 
            this.btnBold.BackgroundImage = global::Paint_Clone.Properties.Resources.Bold;
            this.btnBold.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBold.Location = new System.Drawing.Point(59, 24);
            this.btnBold.Name = "btnBold";
            this.btnBold.Size = new System.Drawing.Size(23, 23);
            this.btnBold.TabIndex = 32;
            this.btnBold.UseVisualStyleBackColor = true;
            this.btnBold.Click += new System.EventHandler(this.btnBold_Click);
            // 
            // cbbFontSize
            // 
            this.cbbFontSize.FormattingEnabled = true;
            this.cbbFontSize.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "36",
            "48",
            "72"});
            this.cbbFontSize.Location = new System.Drawing.Point(15, 24);
            this.cbbFontSize.Name = "cbbFontSize";
            this.cbbFontSize.Size = new System.Drawing.Size(38, 21);
            this.cbbFontSize.TabIndex = 31;
            this.cbbFontSize.Text = "22";
            this.cbbFontSize.SelectedIndexChanged += new System.EventHandler(this.cbbFontSize_SelectedIndexChanged);
            // 
            // cbbFont
            // 
            this.cbbFont.FormattingEnabled = true;
            this.cbbFont.Location = new System.Drawing.Point(15, 0);
            this.cbbFont.Name = "cbbFont";
            this.cbbFont.Size = new System.Drawing.Size(151, 21);
            this.cbbFont.TabIndex = 30;
            this.cbbFont.Text = "Times New Roman";
            this.cbbFont.SelectedIndexChanged += new System.EventHandler(this.cbbFont_SelectedIndexChanged);
            // 
            // newTextRadio
            // 
            this.newTextRadio.AutoSize = true;
            this.newTextRadio.Location = new System.Drawing.Point(247, 49);
            this.newTextRadio.Name = "newTextRadio";
            this.newTextRadio.Size = new System.Drawing.Size(71, 17);
            this.newTextRadio.TabIndex = 13;
            this.newTextRadio.Text = "New Text";
            this.newTextRadio.UseVisualStyleBackColor = true;
            this.newTextRadio.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // parabolaRadio
            // 
            this.parabolaRadio.AutoSize = true;
            this.parabolaRadio.Location = new System.Drawing.Point(247, 3);
            this.parabolaRadio.Name = "parabolaRadio";
            this.parabolaRadio.Size = new System.Drawing.Size(67, 17);
            this.parabolaRadio.TabIndex = 19;
            this.parabolaRadio.Text = "Parabola";
            this.parabolaRadio.UseVisualStyleBackColor = true;
            this.parabolaRadio.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // polygonRadio
            // 
            this.polygonRadio.AutoSize = true;
            this.polygonRadio.Location = new System.Drawing.Point(159, 49);
            this.polygonRadio.Name = "polygonRadio";
            this.polygonRadio.Size = new System.Drawing.Size(63, 17);
            this.polygonRadio.TabIndex = 5;
            this.polygonRadio.Text = "Polygon";
            this.polygonRadio.UseVisualStyleBackColor = true;
            this.polygonRadio.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // hyperbolaRadio
            // 
            this.hyperbolaRadio.AutoSize = true;
            this.hyperbolaRadio.Location = new System.Drawing.Point(247, 26);
            this.hyperbolaRadio.Name = "hyperbolaRadio";
            this.hyperbolaRadio.Size = new System.Drawing.Size(73, 17);
            this.hyperbolaRadio.TabIndex = 20;
            this.hyperbolaRadio.Text = "Hyperbola";
            this.hyperbolaRadio.UseVisualStyleBackColor = true;
            this.hyperbolaRadio.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // parallelogramRadio
            // 
            this.parallelogramRadio.AutoSize = true;
            this.parallelogramRadio.Location = new System.Drawing.Point(159, 26);
            this.parallelogramRadio.Name = "parallelogramRadio";
            this.parallelogramRadio.Size = new System.Drawing.Size(88, 17);
            this.parallelogramRadio.TabIndex = 4;
            this.parallelogramRadio.Text = "Parallelogram";
            this.parallelogramRadio.UseVisualStyleBackColor = true;
            this.parallelogramRadio.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // ellipseArcRadio
            // 
            this.ellipseArcRadio.AutoSize = true;
            this.ellipseArcRadio.Location = new System.Drawing.Point(82, 49);
            this.ellipseArcRadio.Name = "ellipseArcRadio";
            this.ellipseArcRadio.Size = new System.Drawing.Size(74, 17);
            this.ellipseArcRadio.TabIndex = 10;
            this.ellipseArcRadio.Text = "Ellipse Arc";
            this.ellipseArcRadio.UseVisualStyleBackColor = true;
            this.ellipseArcRadio.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // circleArcRadio
            // 
            this.circleArcRadio.AutoSize = true;
            this.circleArcRadio.Location = new System.Drawing.Point(82, 3);
            this.circleArcRadio.Name = "circleArcRadio";
            this.circleArcRadio.Size = new System.Drawing.Size(70, 17);
            this.circleArcRadio.TabIndex = 7;
            this.circleArcRadio.Text = "Circle Arc";
            this.circleArcRadio.UseVisualStyleBackColor = true;
            this.circleArcRadio.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // circleRadio
            // 
            this.circleRadio.AutoSize = true;
            this.circleRadio.Location = new System.Drawing.Point(3, 49);
            this.circleRadio.Name = "circleRadio";
            this.circleRadio.Size = new System.Drawing.Size(51, 17);
            this.circleRadio.TabIndex = 8;
            this.circleRadio.Text = "Circle";
            this.circleRadio.UseVisualStyleBackColor = true;
            this.circleRadio.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // brokenLineRadio
            // 
            this.brokenLineRadio.AutoSize = true;
            this.brokenLineRadio.Location = new System.Drawing.Point(3, 26);
            this.brokenLineRadio.Name = "brokenLineRadio";
            this.brokenLineRadio.Size = new System.Drawing.Size(82, 17);
            this.brokenLineRadio.TabIndex = 6;
            this.brokenLineRadio.Text = "Broken Line";
            this.brokenLineRadio.UseVisualStyleBackColor = true;
            this.brokenLineRadio.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // bezierRadio
            // 
            this.bezierRadio.AutoSize = true;
            this.bezierRadio.Location = new System.Drawing.Point(320, 3);
            this.bezierRadio.Name = "bezierRadio";
            this.bezierRadio.Size = new System.Drawing.Size(54, 17);
            this.bezierRadio.TabIndex = 11;
            this.bezierRadio.Text = "Bezier";
            this.bezierRadio.UseVisualStyleBackColor = true;
            this.bezierRadio.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // lineRadio
            // 
            this.lineRadio.AutoSize = true;
            this.lineRadio.Checked = true;
            this.lineRadio.Location = new System.Drawing.Point(3, 3);
            this.lineRadio.Name = "lineRadio";
            this.lineRadio.Size = new System.Drawing.Size(45, 17);
            this.lineRadio.TabIndex = 1;
            this.lineRadio.TabStop = true;
            this.lineRadio.Text = "Line";
            this.lineRadio.UseVisualStyleBackColor = true;
            this.lineRadio.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // rectRadio
            // 
            this.rectRadio.AutoSize = true;
            this.rectRadio.Location = new System.Drawing.Point(159, 3);
            this.rectRadio.Name = "rectRadio";
            this.rectRadio.Size = new System.Drawing.Size(74, 17);
            this.rectRadio.TabIndex = 3;
            this.rectRadio.Text = "Rectangle";
            this.rectRadio.UseVisualStyleBackColor = true;
            this.rectRadio.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // ellipseRadio
            // 
            this.ellipseRadio.AutoSize = true;
            this.ellipseRadio.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ellipseRadio.Cursor = System.Windows.Forms.Cursors.Default;
            this.ellipseRadio.Location = new System.Drawing.Point(82, 26);
            this.ellipseRadio.Name = "ellipseRadio";
            this.ellipseRadio.Size = new System.Drawing.Size(55, 17);
            this.ellipseRadio.TabIndex = 9;
            this.ellipseRadio.Text = "Ellipse";
            this.ellipseRadio.UseVisualStyleBackColor = true;
            this.ellipseRadio.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // rotateRadio
            // 
            this.rotateRadio.AutoSize = true;
            this.rotateRadio.Location = new System.Drawing.Point(448, 27);
            this.rotateRadio.Name = "rotateRadio";
            this.rotateRadio.Size = new System.Drawing.Size(57, 17);
            this.rotateRadio.TabIndex = 26;
            this.rotateRadio.Text = "Rotate";
            this.rotateRadio.UseVisualStyleBackColor = true;
            this.rotateRadio.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // deleteRadio
            // 
            this.deleteRadio.AutoSize = true;
            this.deleteRadio.Location = new System.Drawing.Point(449, 48);
            this.deleteRadio.Name = "deleteRadio";
            this.deleteRadio.Size = new System.Drawing.Size(56, 17);
            this.deleteRadio.TabIndex = 23;
            this.deleteRadio.Text = "Delete";
            this.deleteRadio.UseVisualStyleBackColor = true;
            this.deleteRadio.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // controlRadio
            // 
            this.controlRadio.AutoSize = true;
            this.controlRadio.Location = new System.Drawing.Point(391, 26);
            this.controlRadio.Name = "controlRadio";
            this.controlRadio.Size = new System.Drawing.Size(58, 17);
            this.controlRadio.TabIndex = 24;
            this.controlRadio.Text = "Control";
            this.controlRadio.UseVisualStyleBackColor = true;
            this.controlRadio.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // moveRadio
            // 
            this.moveRadio.AutoSize = true;
            this.moveRadio.Location = new System.Drawing.Point(391, 48);
            this.moveRadio.Name = "moveRadio";
            this.moveRadio.Size = new System.Drawing.Size(52, 17);
            this.moveRadio.TabIndex = 22;
            this.moveRadio.Text = "Move";
            this.moveRadio.UseVisualStyleBackColor = true;
            this.moveRadio.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // scaleRadio
            // 
            this.scaleRadio.AutoSize = true;
            this.scaleRadio.Location = new System.Drawing.Point(449, 5);
            this.scaleRadio.Name = "scaleRadio";
            this.scaleRadio.Size = new System.Drawing.Size(52, 17);
            this.scaleRadio.TabIndex = 25;
            this.scaleRadio.Text = "Scale";
            this.scaleRadio.UseVisualStyleBackColor = true;
            this.scaleRadio.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // selectRadio
            // 
            this.selectRadio.AutoSize = true;
            this.selectRadio.Location = new System.Drawing.Point(391, 3);
            this.selectRadio.Name = "selectRadio";
            this.selectRadio.Size = new System.Drawing.Size(55, 17);
            this.selectRadio.TabIndex = 21;
            this.selectRadio.Text = "Select";
            this.selectRadio.UseVisualStyleBackColor = true;
            this.selectRadio.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // pnShapes
            // 
            this.pnShapes.Controls.Add(this.selectRadio);
            this.pnShapes.Controls.Add(this.rotateRadio);
            this.pnShapes.Controls.Add(this.ellipseRadio);
            this.pnShapes.Controls.Add(this.deleteRadio);
            this.pnShapes.Controls.Add(this.rectRadio);
            this.pnShapes.Controls.Add(this.scaleRadio);
            this.pnShapes.Controls.Add(this.lineRadio);
            this.pnShapes.Controls.Add(this.controlRadio);
            this.pnShapes.Controls.Add(this.bezierRadio);
            this.pnShapes.Controls.Add(this.moveRadio);
            this.pnShapes.Controls.Add(this.brokenLineRadio);
            this.pnShapes.Controls.Add(this.circleRadio);
            this.pnShapes.Controls.Add(this.circleArcRadio);
            this.pnShapes.Controls.Add(this.ellipseArcRadio);
            this.pnShapes.Controls.Add(this.parallelogramRadio);
            this.pnShapes.Controls.Add(this.hyperbolaRadio);
            this.pnShapes.Controls.Add(this.polygonRadio);
            this.pnShapes.Controls.Add(this.parabolaRadio);
            this.pnShapes.Controls.Add(this.newTextRadio);
            this.pnShapes.Location = new System.Drawing.Point(12, 36);
            this.pnShapes.Name = "pnShapes";
            this.pnShapes.Size = new System.Drawing.Size(511, 68);
            this.pnShapes.TabIndex = 30;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1238, 548);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1262, 674);
            this.Controls.Add(this.panelPenAndBrush);
            this.Controls.Add(this.pnShapes);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mnstripPaint);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MainMenuStrip = this.mnstripPaint;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.mnstripPaint.ResumeLayout(false);
            this.mnstripPaint.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbWidth)).EndInit();
            this.panelPenAndBrush.ResumeLayout(false);
            this.panelPenAndBrush.PerformLayout();
            this.pnShapes.ResumeLayout(false);
            this.pnShapes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.MenuStrip mnstripPaint;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.TrackBar tbWidth;
        private System.Windows.Forms.Button btnBorderColor;
        private System.Windows.Forms.ComboBox cbbBrush;
        private System.Windows.Forms.ComboBox cbbDashStyle;
        private System.Windows.Forms.Label lbBorderColor;
        private System.Windows.Forms.Label lbFillColor;
        private System.Windows.Forms.Button btnFillColor;
        private System.Windows.Forms.Panel panelPenAndBrush;
        private System.Windows.Forms.Button btnUnderline;
        private System.Windows.Forms.Button btnItalic;
        private System.Windows.Forms.Button btnBold;
        private System.Windows.Forms.ComboBox cbbFontSize;
        private System.Windows.Forms.ComboBox cbbFont;
        private System.Windows.Forms.Button btnNormal;
        private System.Windows.Forms.RadioButton newTextRadio;
        private System.Windows.Forms.RadioButton parabolaRadio;
        private System.Windows.Forms.RadioButton polygonRadio;
        private System.Windows.Forms.RadioButton hyperbolaRadio;
        private System.Windows.Forms.RadioButton parallelogramRadio;
        private System.Windows.Forms.RadioButton ellipseArcRadio;
        private System.Windows.Forms.RadioButton circleArcRadio;
        private System.Windows.Forms.RadioButton circleRadio;
        private System.Windows.Forms.RadioButton brokenLineRadio;
        private System.Windows.Forms.RadioButton bezierRadio;
        private System.Windows.Forms.RadioButton lineRadio;
        private System.Windows.Forms.RadioButton rectRadio;
        private System.Windows.Forms.RadioButton ellipseRadio;
        private System.Windows.Forms.RadioButton rotateRadio;
        private System.Windows.Forms.RadioButton deleteRadio;
        private System.Windows.Forms.RadioButton controlRadio;
        private System.Windows.Forms.RadioButton moveRadio;
        private System.Windows.Forms.RadioButton scaleRadio;
        private System.Windows.Forms.RadioButton selectRadio;
        private System.Windows.Forms.Panel pnShapes;
    }
}

