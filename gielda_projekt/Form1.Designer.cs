namespace gielda_projekt
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.labelFilepath = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonStartTrain = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDownDays = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownCycle = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownRate = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownLoop = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboBoxThirdLayer = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxfirstLayer = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBoxSecondLayer = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.numericUpDownTestNumber = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.labelTestFilePath = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCycle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLoop)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTestNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Utwórz sieć";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(428, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 75);
            this.button2.TabIndex = 1;
            this.button2.Text = "Testuj";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(519, 312);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(511, 286);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sieć";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.labelFilepath);
            this.groupBox5.Controls.Add(this.button3);
            this.groupBox5.Controls.Add(this.buttonStartTrain);
            this.groupBox5.Location = new System.Drawing.Point(8, 215);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(495, 66);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Uczenie sieci";
            // 
            // labelFilepath
            // 
            this.labelFilepath.AutoSize = true;
            this.labelFilepath.Location = new System.Drawing.Point(7, 45);
            this.labelFilepath.Name = "labelFilepath";
            this.labelFilepath.Size = new System.Drawing.Size(73, 13);
            this.labelFilepath.TabIndex = 2;
            this.labelFilepath.Text = "Wybierz plik...";
            this.labelFilepath.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Plik z danymi";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonStartTrain
            // 
            this.buttonStartTrain.Location = new System.Drawing.Point(414, 19);
            this.buttonStartTrain.Name = "buttonStartTrain";
            this.buttonStartTrain.Size = new System.Drawing.Size(75, 23);
            this.buttonStartTrain.TabIndex = 0;
            this.buttonStartTrain.Text = "Rozpocznij";
            this.buttonStartTrain.UseVisualStyleBackColor = true;
            this.buttonStartTrain.Click += new System.EventHandler(this.buttonStartTrain_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.numericUpDownDays);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numericUpDownCycle);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numericUpDownRate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numericUpDownLoop);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 203);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parametry sieci";
            // 
            // numericUpDownDays
            // 
            this.numericUpDownDays.Location = new System.Drawing.Point(84, 42);
            this.numericUpDownDays.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownDays.Name = "numericUpDownDays";
            this.numericUpDownDays.Size = new System.Drawing.Size(71, 20);
            this.numericUpDownDays.TabIndex = 12;
            this.numericUpDownDays.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Liczba dni";
            // 
            // numericUpDownCycle
            // 
            this.numericUpDownCycle.Location = new System.Drawing.Point(314, 16);
            this.numericUpDownCycle.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownCycle.Name = "numericUpDownCycle";
            this.numericUpDownCycle.Size = new System.Drawing.Size(62, 20);
            this.numericUpDownCycle.TabIndex = 10;
            this.numericUpDownCycle.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cykle";
            // 
            // numericUpDownRate
            // 
            this.numericUpDownRate.DecimalPlaces = 3;
            this.numericUpDownRate.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownRate.Location = new System.Drawing.Point(212, 16);
            this.numericUpDownRate.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownRate.Name = "numericUpDownRate";
            this.numericUpDownRate.Size = new System.Drawing.Size(57, 20);
            this.numericUpDownRate.TabIndex = 8;
            this.numericUpDownRate.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Learning rate";
            // 
            // numericUpDownLoop
            // 
            this.numericUpDownLoop.Location = new System.Drawing.Point(84, 16);
            this.numericUpDownLoop.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownLoop.Name = "numericUpDownLoop";
            this.numericUpDownLoop.Size = new System.Drawing.Size(47, 20);
            this.numericUpDownLoop.TabIndex = 6;
            this.numericUpDownLoop.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "L. Powtórzeń";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comboBoxThirdLayer);
            this.groupBox4.Location = new System.Drawing.Point(336, 110);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(155, 58);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Trzecia warstwa";
            // 
            // comboBoxThirdLayer
            // 
            this.comboBoxThirdLayer.FormattingEnabled = true;
            this.comboBoxThirdLayer.Items.AddRange(new object[] {
            "LinearLayer",
            "LogarithmLayer",
            "SigmoidLayer",
            "SineLayer",
            "TanhLayer"});
            this.comboBoxThirdLayer.Location = new System.Drawing.Point(6, 19);
            this.comboBoxThirdLayer.Name = "comboBoxThirdLayer";
            this.comboBoxThirdLayer.Size = new System.Drawing.Size(143, 21);
            this.comboBoxThirdLayer.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxfirstLayer);
            this.groupBox2.Location = new System.Drawing.Point(6, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(155, 58);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pierwsza warstwa";
            // 
            // comboBoxfirstLayer
            // 
            this.comboBoxfirstLayer.FormattingEnabled = true;
            this.comboBoxfirstLayer.Items.AddRange(new object[] {
            "LinearLayer",
            "LogarithmLayer",
            "SigmoidLayer",
            "SineLayer",
            "TanhLayer"});
            this.comboBoxfirstLayer.Location = new System.Drawing.Point(6, 19);
            this.comboBoxfirstLayer.Name = "comboBoxfirstLayer";
            this.comboBoxfirstLayer.Size = new System.Drawing.Size(143, 21);
            this.comboBoxfirstLayer.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBoxSecondLayer);
            this.groupBox3.Location = new System.Drawing.Point(167, 110);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(155, 58);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Druga warstwa";
            // 
            // comboBoxSecondLayer
            // 
            this.comboBoxSecondLayer.FormattingEnabled = true;
            this.comboBoxSecondLayer.Items.AddRange(new object[] {
            "LinearLayer",
            "LogarithmLayer",
            "SigmoidLayer",
            "SineLayer",
            "TanhLayer"});
            this.comboBoxSecondLayer.Location = new System.Drawing.Point(6, 19);
            this.comboBoxSecondLayer.Name = "comboBoxSecondLayer";
            this.comboBoxSecondLayer.Size = new System.Drawing.Size(143, 21);
            this.comboBoxSecondLayer.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.numericUpDownTestNumber);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.labelTestFilePath);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(511, 422);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Testuj sieć";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // numericUpDownTestNumber
            // 
            this.numericUpDownTestNumber.Location = new System.Drawing.Point(86, 9);
            this.numericUpDownTestNumber.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownTestNumber.Name = "numericUpDownTestNumber";
            this.numericUpDownTestNumber.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownTestNumber.TabIndex = 6;
            this.numericUpDownTestNumber.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Liczba testów";
            // 
            // labelTestFilePath
            // 
            this.labelTestFilePath.AutoSize = true;
            this.labelTestFilePath.Location = new System.Drawing.Point(8, 68);
            this.labelTestFilePath.Name = "labelTestFilePath";
            this.labelTestFilePath.Size = new System.Drawing.Size(73, 13);
            this.labelTestFilePath.TabIndex = 4;
            this.labelTestFilePath.Text = "Wybierz plik...";
            this.labelTestFilePath.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(8, 42);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Plik z danymi";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(335, 174);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 13;
            this.button5.Text = "Zapisz";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(416, 174);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 14;
            this.button6.Text = "Wczytaj";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 312);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCycle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLoop)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTestNumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxfirstLayer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxThirdLayer;
        private System.Windows.Forms.ComboBox comboBoxSecondLayer;
        private System.Windows.Forms.NumericUpDown numericUpDownLoop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownCycle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownDays;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonStartTrain;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label labelFilepath;
        private System.Windows.Forms.Label labelTestFilePath;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.NumericUpDown numericUpDownTestNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

