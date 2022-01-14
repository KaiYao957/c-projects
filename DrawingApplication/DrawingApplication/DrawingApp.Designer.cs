
namespace DrawingApplication
{
    partial class DrawingApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrawingApp));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.canvas = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.blackButton = new System.Windows.Forms.Button();
            this.grayButton = new System.Windows.Forms.Button();
            this.redButton = new System.Windows.Forms.Button();
            this.greenButton = new System.Windows.Forms.Button();
            this.blueButton = new System.Windows.Forms.Button();
            this.yellowButton = new System.Windows.Forms.Button();
            this.whiteButton = new System.Windows.Forms.Button();
            this.brownButton = new System.Windows.Forms.Button();
            this.purpleButton = new System.Windows.Forms.Button();
            this.orangeButton = new System.Windows.Forms.Button();
            this.tanButton = new System.Windows.Forms.Button();
            this.cyanButton = new System.Windows.Forms.Button();
            this.limeButton = new System.Windows.Forms.Button();
            this.beigeButton = new System.Windows.Forms.Button();
            this.indigoButton = new System.Windows.Forms.Button();
            this.magentaButton = new System.Windows.Forms.Button();
            this.lightPurpleButton = new System.Windows.Forms.Button();
            this.pinkButton = new System.Windows.Forms.Button();
            this.lightBlueButton = new System.Windows.Forms.Button();
            this.lightGreenButton = new System.Windows.Forms.Button();
            this.silverButton = new System.Windows.Forms.Button();
            this.goldButton = new System.Windows.Forms.Button();
            this.orangeRedButton = new System.Windows.Forms.Button();
            this.darkPinkButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.size1 = new System.Windows.Forms.RadioButton();
            this.size2 = new System.Windows.Forms.RadioButton();
            this.size3 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.size20 = new System.Windows.Forms.RadioButton();
            this.size17point5 = new System.Windows.Forms.RadioButton();
            this.size15 = new System.Windows.Forms.RadioButton();
            this.size12 = new System.Windows.Forms.RadioButton();
            this.size10 = new System.Windows.Forms.RadioButton();
            this.size7point5 = new System.Windows.Forms.RadioButton();
            this.size5 = new System.Windows.Forms.RadioButton();
            this.eraserButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(332, 333);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.SystemColors.ControlLight;
            this.canvas.Location = new System.Drawing.Point(380, 128);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(600, 450);
            this.canvas.TabIndex = 1;
            this.canvas.TabStop = false;
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            this.canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(632, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Colors";
            // 
            // blackButton
            // 
            this.blackButton.BackColor = System.Drawing.Color.Black;
            this.blackButton.Location = new System.Drawing.Point(380, 45);
            this.blackButton.Name = "blackButton";
            this.blackButton.Size = new System.Drawing.Size(50, 34);
            this.blackButton.TabIndex = 3;
            this.blackButton.UseVisualStyleBackColor = false;
            this.blackButton.Click += new System.EventHandler(this.blackButton_Click);
            // 
            // grayButton
            // 
            this.grayButton.BackColor = System.Drawing.Color.Gray;
            this.grayButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.grayButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grayButton.Location = new System.Drawing.Point(430, 45);
            this.grayButton.Name = "grayButton";
            this.grayButton.Size = new System.Drawing.Size(50, 34);
            this.grayButton.TabIndex = 4;
            this.grayButton.UseVisualStyleBackColor = false;
            this.grayButton.Click += new System.EventHandler(this.grayButton_Click);
            // 
            // redButton
            // 
            this.redButton.BackColor = System.Drawing.Color.Red;
            this.redButton.Location = new System.Drawing.Point(480, 45);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(50, 34);
            this.redButton.TabIndex = 5;
            this.redButton.UseVisualStyleBackColor = false;
            this.redButton.Click += new System.EventHandler(this.redButton_Click);
            // 
            // greenButton
            // 
            this.greenButton.BackColor = System.Drawing.Color.Green;
            this.greenButton.Location = new System.Drawing.Point(530, 45);
            this.greenButton.Name = "greenButton";
            this.greenButton.Size = new System.Drawing.Size(50, 34);
            this.greenButton.TabIndex = 6;
            this.greenButton.UseVisualStyleBackColor = false;
            this.greenButton.Click += new System.EventHandler(this.greenButton_Click);
            // 
            // blueButton
            // 
            this.blueButton.BackColor = System.Drawing.Color.Blue;
            this.blueButton.Location = new System.Drawing.Point(480, 85);
            this.blueButton.Name = "blueButton";
            this.blueButton.Size = new System.Drawing.Size(50, 34);
            this.blueButton.TabIndex = 7;
            this.blueButton.UseVisualStyleBackColor = false;
            this.blueButton.Click += new System.EventHandler(this.blueButton_Click);
            // 
            // yellowButton
            // 
            this.yellowButton.BackColor = System.Drawing.Color.Yellow;
            this.yellowButton.Location = new System.Drawing.Point(530, 85);
            this.yellowButton.Name = "yellowButton";
            this.yellowButton.Size = new System.Drawing.Size(50, 34);
            this.yellowButton.TabIndex = 8;
            this.yellowButton.UseVisualStyleBackColor = false;
            this.yellowButton.Click += new System.EventHandler(this.yellowButton_Click);
            // 
            // whiteButton
            // 
            this.whiteButton.BackColor = System.Drawing.Color.White;
            this.whiteButton.Location = new System.Drawing.Point(380, 85);
            this.whiteButton.Name = "whiteButton";
            this.whiteButton.Size = new System.Drawing.Size(50, 34);
            this.whiteButton.TabIndex = 9;
            this.whiteButton.UseVisualStyleBackColor = false;
            this.whiteButton.Click += new System.EventHandler(this.whiteButton_Click);
            // 
            // brownButton
            // 
            this.brownButton.BackColor = System.Drawing.Color.Brown;
            this.brownButton.Location = new System.Drawing.Point(430, 85);
            this.brownButton.Name = "brownButton";
            this.brownButton.Size = new System.Drawing.Size(50, 34);
            this.brownButton.TabIndex = 10;
            this.brownButton.UseVisualStyleBackColor = false;
            this.brownButton.Click += new System.EventHandler(this.brownButton_Click);
            // 
            // purpleButton
            // 
            this.purpleButton.BackColor = System.Drawing.Color.Purple;
            this.purpleButton.Location = new System.Drawing.Point(580, 85);
            this.purpleButton.Name = "purpleButton";
            this.purpleButton.Size = new System.Drawing.Size(50, 34);
            this.purpleButton.TabIndex = 11;
            this.purpleButton.UseVisualStyleBackColor = false;
            this.purpleButton.Click += new System.EventHandler(this.purpleButton_Click);
            // 
            // orangeButton
            // 
            this.orangeButton.BackColor = System.Drawing.Color.Orange;
            this.orangeButton.Location = new System.Drawing.Point(580, 45);
            this.orangeButton.Name = "orangeButton";
            this.orangeButton.Size = new System.Drawing.Size(50, 34);
            this.orangeButton.TabIndex = 11;
            this.orangeButton.UseVisualStyleBackColor = false;
            this.orangeButton.Click += new System.EventHandler(this.orangeButton_Click);
            // 
            // tanButton
            // 
            this.tanButton.BackColor = System.Drawing.Color.Tan;
            this.tanButton.Location = new System.Drawing.Point(730, 45);
            this.tanButton.Name = "tanButton";
            this.tanButton.Size = new System.Drawing.Size(50, 34);
            this.tanButton.TabIndex = 12;
            this.tanButton.UseVisualStyleBackColor = false;
            this.tanButton.Click += new System.EventHandler(this.tanButton_Click);
            // 
            // cyanButton
            // 
            this.cyanButton.BackColor = System.Drawing.Color.Cyan;
            this.cyanButton.Location = new System.Drawing.Point(630, 85);
            this.cyanButton.Name = "cyanButton";
            this.cyanButton.Size = new System.Drawing.Size(50, 34);
            this.cyanButton.TabIndex = 13;
            this.cyanButton.UseVisualStyleBackColor = false;
            this.cyanButton.Click += new System.EventHandler(this.cyanButton_Click);
            // 
            // limeButton
            // 
            this.limeButton.BackColor = System.Drawing.Color.Lime;
            this.limeButton.Location = new System.Drawing.Point(630, 45);
            this.limeButton.Name = "limeButton";
            this.limeButton.Size = new System.Drawing.Size(50, 34);
            this.limeButton.TabIndex = 14;
            this.limeButton.UseVisualStyleBackColor = false;
            this.limeButton.Click += new System.EventHandler(this.limeButton_Click);
            // 
            // beigeButton
            // 
            this.beigeButton.BackColor = System.Drawing.Color.Beige;
            this.beigeButton.Location = new System.Drawing.Point(730, 85);
            this.beigeButton.Name = "beigeButton";
            this.beigeButton.Size = new System.Drawing.Size(50, 34);
            this.beigeButton.TabIndex = 15;
            this.beigeButton.UseVisualStyleBackColor = false;
            this.beigeButton.Click += new System.EventHandler(this.beigeButton_Click);
            // 
            // indigoButton
            // 
            this.indigoButton.BackColor = System.Drawing.Color.Indigo;
            this.indigoButton.Location = new System.Drawing.Point(680, 85);
            this.indigoButton.Name = "indigoButton";
            this.indigoButton.Size = new System.Drawing.Size(50, 34);
            this.indigoButton.TabIndex = 16;
            this.indigoButton.UseVisualStyleBackColor = false;
            this.indigoButton.Click += new System.EventHandler(this.indigoButton_Click);
            // 
            // magentaButton
            // 
            this.magentaButton.BackColor = System.Drawing.Color.Magenta;
            this.magentaButton.Location = new System.Drawing.Point(680, 45);
            this.magentaButton.Name = "magentaButton";
            this.magentaButton.Size = new System.Drawing.Size(50, 34);
            this.magentaButton.TabIndex = 17;
            this.magentaButton.UseVisualStyleBackColor = false;
            this.magentaButton.Click += new System.EventHandler(this.magentaButton_Click);
            // 
            // lightPurpleButton
            // 
            this.lightPurpleButton.BackColor = System.Drawing.Color.DarkOrchid;
            this.lightPurpleButton.Location = new System.Drawing.Point(780, 85);
            this.lightPurpleButton.Name = "lightPurpleButton";
            this.lightPurpleButton.Size = new System.Drawing.Size(50, 34);
            this.lightPurpleButton.TabIndex = 18;
            this.lightPurpleButton.UseVisualStyleBackColor = false;
            this.lightPurpleButton.Click += new System.EventHandler(this.lightPurpleButton_Click);
            // 
            // pinkButton
            // 
            this.pinkButton.BackColor = System.Drawing.Color.Pink;
            this.pinkButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pinkButton.Location = new System.Drawing.Point(780, 45);
            this.pinkButton.Name = "pinkButton";
            this.pinkButton.Size = new System.Drawing.Size(50, 34);
            this.pinkButton.TabIndex = 19;
            this.pinkButton.UseVisualStyleBackColor = false;
            this.pinkButton.Click += new System.EventHandler(this.pinkButton_Click);
            // 
            // lightBlueButton
            // 
            this.lightBlueButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lightBlueButton.Location = new System.Drawing.Point(830, 45);
            this.lightBlueButton.Name = "lightBlueButton";
            this.lightBlueButton.Size = new System.Drawing.Size(50, 34);
            this.lightBlueButton.TabIndex = 20;
            this.lightBlueButton.UseVisualStyleBackColor = false;
            this.lightBlueButton.Click += new System.EventHandler(this.lightBlueButton_Click);
            // 
            // lightGreenButton
            // 
            this.lightGreenButton.BackColor = System.Drawing.Color.LimeGreen;
            this.lightGreenButton.Location = new System.Drawing.Point(880, 45);
            this.lightGreenButton.Name = "lightGreenButton";
            this.lightGreenButton.Size = new System.Drawing.Size(50, 34);
            this.lightGreenButton.TabIndex = 21;
            this.lightGreenButton.UseVisualStyleBackColor = false;
            this.lightGreenButton.Click += new System.EventHandler(this.lightGreenButton_Click);
            // 
            // silverButton
            // 
            this.silverButton.BackColor = System.Drawing.Color.Silver;
            this.silverButton.Location = new System.Drawing.Point(930, 45);
            this.silverButton.Name = "silverButton";
            this.silverButton.Size = new System.Drawing.Size(50, 34);
            this.silverButton.TabIndex = 22;
            this.silverButton.UseVisualStyleBackColor = false;
            this.silverButton.Click += new System.EventHandler(this.silverButton_Click);
            // 
            // goldButton
            // 
            this.goldButton.BackColor = System.Drawing.Color.Gold;
            this.goldButton.Location = new System.Drawing.Point(930, 85);
            this.goldButton.Name = "goldButton";
            this.goldButton.Size = new System.Drawing.Size(50, 34);
            this.goldButton.TabIndex = 25;
            this.goldButton.UseVisualStyleBackColor = false;
            this.goldButton.Click += new System.EventHandler(this.goldButton_Click);
            // 
            // orangeRedButton
            // 
            this.orangeRedButton.BackColor = System.Drawing.Color.OrangeRed;
            this.orangeRedButton.Location = new System.Drawing.Point(880, 85);
            this.orangeRedButton.Name = "orangeRedButton";
            this.orangeRedButton.Size = new System.Drawing.Size(50, 34);
            this.orangeRedButton.TabIndex = 24;
            this.orangeRedButton.UseVisualStyleBackColor = false;
            this.orangeRedButton.Click += new System.EventHandler(this.orangeRedButton_Click);
            // 
            // darkPinkButton
            // 
            this.darkPinkButton.BackColor = System.Drawing.Color.HotPink;
            this.darkPinkButton.Location = new System.Drawing.Point(830, 85);
            this.darkPinkButton.Name = "darkPinkButton";
            this.darkPinkButton.Size = new System.Drawing.Size(50, 34);
            this.darkPinkButton.TabIndex = 23;
            this.darkPinkButton.UseVisualStyleBackColor = false;
            this.darkPinkButton.Click += new System.EventHandler(this.darkPinkButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(126, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Pen Size";
            // 
            // size1
            // 
            this.size1.AutoSize = true;
            this.size1.Checked = true;
            this.size1.Location = new System.Drawing.Point(121, 45);
            this.size1.Name = "size1";
            this.size1.Size = new System.Drawing.Size(31, 17);
            this.size1.TabIndex = 27;
            this.size1.TabStop = true;
            this.size1.Text = "1";
            this.size1.UseVisualStyleBackColor = true;
            this.size1.CheckedChanged += new System.EventHandler(this.size1_CheckedChanged);
            // 
            // size2
            // 
            this.size2.AutoSize = true;
            this.size2.Location = new System.Drawing.Point(121, 68);
            this.size2.Name = "size2";
            this.size2.Size = new System.Drawing.Size(31, 17);
            this.size2.TabIndex = 28;
            this.size2.TabStop = true;
            this.size2.Text = "2";
            this.size2.UseVisualStyleBackColor = true;
            this.size2.CheckedChanged += new System.EventHandler(this.size2_CheckedChanged);
            // 
            // size3
            // 
            this.size3.AutoSize = true;
            this.size3.Location = new System.Drawing.Point(121, 91);
            this.size3.Name = "size3";
            this.size3.Size = new System.Drawing.Size(31, 17);
            this.size3.TabIndex = 29;
            this.size3.TabStop = true;
            this.size3.Text = "3";
            this.size3.UseVisualStyleBackColor = true;
            this.size3.CheckedChanged += new System.EventHandler(this.size3_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.size20);
            this.groupBox1.Controls.Add(this.size17point5);
            this.groupBox1.Controls.Add(this.size15);
            this.groupBox1.Controls.Add(this.size12);
            this.groupBox1.Controls.Add(this.size10);
            this.groupBox1.Controls.Add(this.size7point5);
            this.groupBox1.Controls.Add(this.size5);
            this.groupBox1.Controls.Add(this.size3);
            this.groupBox1.Controls.Add(this.size1);
            this.groupBox1.Controls.Add(this.size2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 351);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 164);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            // 
            // size20
            // 
            this.size20.AutoSize = true;
            this.size20.Location = new System.Drawing.Point(169, 137);
            this.size20.Name = "size20";
            this.size20.Size = new System.Drawing.Size(37, 17);
            this.size20.TabIndex = 36;
            this.size20.Text = "20";
            this.size20.UseVisualStyleBackColor = true;
            this.size20.CheckedChanged += new System.EventHandler(this.size20_CheckedChanged);
            // 
            // size17point5
            // 
            this.size17point5.AutoSize = true;
            this.size17point5.Location = new System.Drawing.Point(169, 114);
            this.size17point5.Name = "size17point5";
            this.size17point5.Size = new System.Drawing.Size(46, 17);
            this.size17point5.TabIndex = 35;
            this.size17point5.TabStop = true;
            this.size17point5.Text = "17.5";
            this.size17point5.UseVisualStyleBackColor = true;
            this.size17point5.CheckedChanged += new System.EventHandler(this.size17point5_CheckedChanged);
            // 
            // size15
            // 
            this.size15.AutoSize = true;
            this.size15.Location = new System.Drawing.Point(169, 91);
            this.size15.Name = "size15";
            this.size15.Size = new System.Drawing.Size(37, 17);
            this.size15.TabIndex = 34;
            this.size15.TabStop = true;
            this.size15.Text = "15";
            this.size15.UseVisualStyleBackColor = true;
            this.size15.CheckedChanged += new System.EventHandler(this.size15_CheckedChanged);
            // 
            // size12
            // 
            this.size12.AutoSize = true;
            this.size12.Location = new System.Drawing.Point(169, 68);
            this.size12.Name = "size12";
            this.size12.Size = new System.Drawing.Size(37, 17);
            this.size12.TabIndex = 33;
            this.size12.TabStop = true;
            this.size12.Text = "12";
            this.size12.UseVisualStyleBackColor = true;
            this.size12.CheckedChanged += new System.EventHandler(this.size12_CheckedChanged);
            // 
            // size10
            // 
            this.size10.AutoSize = true;
            this.size10.Location = new System.Drawing.Point(169, 45);
            this.size10.Name = "size10";
            this.size10.Size = new System.Drawing.Size(37, 17);
            this.size10.TabIndex = 32;
            this.size10.TabStop = true;
            this.size10.Text = "10";
            this.size10.UseVisualStyleBackColor = true;
            this.size10.CheckedChanged += new System.EventHandler(this.size10_CheckedChanged);
            // 
            // size7point5
            // 
            this.size7point5.AutoSize = true;
            this.size7point5.Location = new System.Drawing.Point(121, 137);
            this.size7point5.Name = "size7point5";
            this.size7point5.Size = new System.Drawing.Size(40, 17);
            this.size7point5.TabIndex = 31;
            this.size7point5.TabStop = true;
            this.size7point5.Text = "7.5";
            this.size7point5.UseVisualStyleBackColor = true;
            this.size7point5.CheckedChanged += new System.EventHandler(this.size7point5_CheckedChanged);
            // 
            // size5
            // 
            this.size5.AutoSize = true;
            this.size5.Location = new System.Drawing.Point(121, 114);
            this.size5.Name = "size5";
            this.size5.Size = new System.Drawing.Size(31, 17);
            this.size5.TabIndex = 30;
            this.size5.TabStop = true;
            this.size5.Text = "5";
            this.size5.UseVisualStyleBackColor = true;
            this.size5.CheckedChanged += new System.EventHandler(this.size5_CheckedChanged);
            // 
            // eraserButton
            // 
            this.eraserButton.BackColor = System.Drawing.Color.DarkGray;
            this.eraserButton.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eraserButton.Location = new System.Drawing.Point(25, 521);
            this.eraserButton.Name = "eraserButton";
            this.eraserButton.Size = new System.Drawing.Size(145, 46);
            this.eraserButton.TabIndex = 35;
            this.eraserButton.Text = "Eraser";
            this.eraserButton.UseVisualStyleBackColor = false;
            this.eraserButton.Click += new System.EventHandler(this.eraserButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.DarkGray;
            this.clearButton.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(199, 521);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(145, 46);
            this.clearButton.TabIndex = 36;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // DrawingApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1043, 695);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.eraserButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.goldButton);
            this.Controls.Add(this.orangeRedButton);
            this.Controls.Add(this.darkPinkButton);
            this.Controls.Add(this.silverButton);
            this.Controls.Add(this.lightGreenButton);
            this.Controls.Add(this.lightBlueButton);
            this.Controls.Add(this.pinkButton);
            this.Controls.Add(this.lightPurpleButton);
            this.Controls.Add(this.magentaButton);
            this.Controls.Add(this.indigoButton);
            this.Controls.Add(this.beigeButton);
            this.Controls.Add(this.limeButton);
            this.Controls.Add(this.cyanButton);
            this.Controls.Add(this.tanButton);
            this.Controls.Add(this.orangeButton);
            this.Controls.Add(this.purpleButton);
            this.Controls.Add(this.brownButton);
            this.Controls.Add(this.whiteButton);
            this.Controls.Add(this.yellowButton);
            this.Controls.Add(this.blueButton);
            this.Controls.Add(this.greenButton);
            this.Controls.Add(this.redButton);
            this.Controls.Add(this.grayButton);
            this.Controls.Add(this.blackButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DrawingApp";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button blackButton;
        private System.Windows.Forms.Button grayButton;
        private System.Windows.Forms.Button redButton;
        private System.Windows.Forms.Button greenButton;
        private System.Windows.Forms.Button blueButton;
        private System.Windows.Forms.Button yellowButton;
        private System.Windows.Forms.Button whiteButton;
        private System.Windows.Forms.Button brownButton;
        private System.Windows.Forms.Button purpleButton;
        private System.Windows.Forms.Button orangeButton;
        private System.Windows.Forms.Button tanButton;
        private System.Windows.Forms.Button cyanButton;
        private System.Windows.Forms.Button limeButton;
        private System.Windows.Forms.Button beigeButton;
        private System.Windows.Forms.Button indigoButton;
        private System.Windows.Forms.Button magentaButton;
        private System.Windows.Forms.Button lightPurpleButton;
        private System.Windows.Forms.Button pinkButton;
        private System.Windows.Forms.Button lightBlueButton;
        private System.Windows.Forms.Button lightGreenButton;
        private System.Windows.Forms.Button silverButton;
        private System.Windows.Forms.Button goldButton;
        private System.Windows.Forms.Button orangeRedButton;
        private System.Windows.Forms.Button darkPinkButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton size1;
        private System.Windows.Forms.RadioButton size2;
        private System.Windows.Forms.RadioButton size3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton size20;
        private System.Windows.Forms.RadioButton size17point5;
        private System.Windows.Forms.RadioButton size15;
        private System.Windows.Forms.RadioButton size12;
        private System.Windows.Forms.RadioButton size10;
        private System.Windows.Forms.RadioButton size7point5;
        private System.Windows.Forms.RadioButton size5;
        private System.Windows.Forms.Button eraserButton;
        private System.Windows.Forms.Button clearButton;
    }
}

