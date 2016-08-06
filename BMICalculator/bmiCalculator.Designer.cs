namespace BMICalculator
{
    partial class bmiCalculator
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
            this.label5 = new System.Windows.Forms.Label();
            this.metricbutton = new System.Windows.Forms.RadioButton();
            this.imperialbutton = new System.Windows.Forms.RadioButton();
            this.bmicalculatebutton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.DecimalButton = new System.Windows.Forms.Button();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.ThreeButton = new System.Windows.Forms.Button();
            this.TwoButton = new System.Windows.Forms.Button();
            this.OneButton = new System.Windows.Forms.Button();
            this.SixButton = new System.Windows.Forms.Button();
            this.FiveButton = new System.Windows.Forms.Button();
            this.FourButton = new System.Windows.Forms.Button();
            this.NineButton = new System.Windows.Forms.Button();
            this.EightButton = new System.Windows.Forms.Button();
            this.SevenButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.height = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.weight = new System.Windows.Forms.TextBox();
            this.bmiscale = new System.Windows.Forms.TextBox();
            this.bmiresult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.TableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(343, 39);
            this.label5.TabIndex = 1;
            this.label5.Text = "System Of Measurement";
            // 
            // metricbutton
            // 
            this.metricbutton.AutoSize = true;
            this.metricbutton.Location = new System.Drawing.Point(12, 60);
            this.metricbutton.Name = "metricbutton";
            this.metricbutton.Size = new System.Drawing.Size(125, 43);
            this.metricbutton.TabIndex = 2;
            this.metricbutton.Text = "Metric";
            this.metricbutton.UseVisualStyleBackColor = true;
            this.metricbutton.CheckedChanged += new System.EventHandler(this.metricbutton_CheckedChanged);
            // 
            // imperialbutton
            // 
            this.imperialbutton.AutoSize = true;
            this.imperialbutton.Location = new System.Drawing.Point(199, 59);
            this.imperialbutton.Name = "imperialbutton";
            this.imperialbutton.Size = new System.Drawing.Size(148, 43);
            this.imperialbutton.TabIndex = 3;
            this.imperialbutton.Text = "Imperial";
            this.imperialbutton.UseVisualStyleBackColor = true;
            this.imperialbutton.CheckedChanged += new System.EventHandler(this.imperialbutton_CheckedChanged);
            // 
            // bmicalculatebutton
            // 
            this.bmicalculatebutton.BackColor = System.Drawing.Color.Maroon;
            this.bmicalculatebutton.ForeColor = System.Drawing.Color.White;
            this.bmicalculatebutton.Location = new System.Drawing.Point(302, 656);
            this.bmicalculatebutton.Name = "bmicalculatebutton";
            this.bmicalculatebutton.Size = new System.Drawing.Size(216, 47);
            this.bmicalculatebutton.TabIndex = 4;
            this.bmicalculatebutton.Text = "Calculate BMI";
            this.bmicalculatebutton.UseVisualStyleBackColor = false;
            this.bmicalculatebutton.Click += new System.EventHandler(this.bmicalculatebutton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(401, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 39);
            this.label6.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(331, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 39);
            this.label7.TabIndex = 6;
            this.label7.Text = "Meters";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(331, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 39);
            this.label8.TabIndex = 7;
            this.label8.Text = "KG";
            // 
            // TableLayoutPanel
            // 
            this.TableLayoutPanel.ColumnCount = 4;
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayoutPanel.Controls.Add(this.DecimalButton, 2, 4);
            this.TableLayoutPanel.Controls.Add(this.ZeroButton, 1, 4);
            this.TableLayoutPanel.Controls.Add(this.ThreeButton, 2, 3);
            this.TableLayoutPanel.Controls.Add(this.TwoButton, 1, 3);
            this.TableLayoutPanel.Controls.Add(this.OneButton, 0, 3);
            this.TableLayoutPanel.Controls.Add(this.SixButton, 2, 2);
            this.TableLayoutPanel.Controls.Add(this.FiveButton, 1, 2);
            this.TableLayoutPanel.Controls.Add(this.FourButton, 0, 2);
            this.TableLayoutPanel.Controls.Add(this.NineButton, 2, 1);
            this.TableLayoutPanel.Controls.Add(this.EightButton, 1, 1);
            this.TableLayoutPanel.Controls.Add(this.SevenButton, 0, 1);
            this.TableLayoutPanel.Controls.Add(this.BackButton, 3, 0);
            this.TableLayoutPanel.Controls.Add(this.ClearButton, 0, 0);
            this.TableLayoutPanel.Location = new System.Drawing.Point(124, 370);
            this.TableLayoutPanel.Name = "TableLayoutPanel";
            this.TableLayoutPanel.RowCount = 5;
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.65217F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.56522F));
            this.TableLayoutPanel.Size = new System.Drawing.Size(277, 287);
            this.TableLayoutPanel.TabIndex = 8;
            this.TableLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.TableLayoutPanel_Paint);
            // 
            // DecimalButton
            // 
            this.DecimalButton.Location = new System.Drawing.Point(141, 233);
            this.DecimalButton.Name = "DecimalButton";
            this.DecimalButton.Size = new System.Drawing.Size(60, 47);
            this.DecimalButton.TabIndex = 18;
            this.DecimalButton.Text = ".";
            this.DecimalButton.UseVisualStyleBackColor = true;
            this.DecimalButton.Click += new System.EventHandler(this.bmiCalculatorButton_Click);
            // 
            // ZeroButton
            // 
            this.ZeroButton.Location = new System.Drawing.Point(72, 233);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(60, 47);
            this.ZeroButton.TabIndex = 17;
            this.ZeroButton.Text = "0";
            this.ZeroButton.UseVisualStyleBackColor = true;
            this.ZeroButton.Click += new System.EventHandler(this.bmiCalculatorButton_Click);
            // 
            // ThreeButton
            // 
            this.ThreeButton.Location = new System.Drawing.Point(141, 174);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.Size = new System.Drawing.Size(60, 49);
            this.ThreeButton.TabIndex = 14;
            this.ThreeButton.Text = "3";
            this.ThreeButton.UseVisualStyleBackColor = true;
            this.ThreeButton.Click += new System.EventHandler(this.bmiCalculatorButton_Click);
            // 
            // TwoButton
            // 
            this.TwoButton.Location = new System.Drawing.Point(72, 174);
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.Size = new System.Drawing.Size(60, 49);
            this.TwoButton.TabIndex = 13;
            this.TwoButton.Text = "2";
            this.TwoButton.UseVisualStyleBackColor = true;
            this.TwoButton.Click += new System.EventHandler(this.bmiCalculatorButton_Click);
            // 
            // OneButton
            // 
            this.OneButton.Location = new System.Drawing.Point(3, 174);
            this.OneButton.Name = "OneButton";
            this.OneButton.Size = new System.Drawing.Size(60, 49);
            this.OneButton.TabIndex = 12;
            this.OneButton.Text = "1";
            this.OneButton.UseVisualStyleBackColor = true;
            this.OneButton.Click += new System.EventHandler(this.bmiCalculatorButton_Click);
            // 
            // SixButton
            // 
            this.SixButton.Location = new System.Drawing.Point(141, 117);
            this.SixButton.Name = "SixButton";
            this.SixButton.Size = new System.Drawing.Size(60, 47);
            this.SixButton.TabIndex = 10;
            this.SixButton.Text = "6";
            this.SixButton.UseVisualStyleBackColor = true;
            this.SixButton.Click += new System.EventHandler(this.bmiCalculatorButton_Click);
            // 
            // FiveButton
            // 
            this.FiveButton.Location = new System.Drawing.Point(72, 117);
            this.FiveButton.Name = "FiveButton";
            this.FiveButton.Size = new System.Drawing.Size(60, 47);
            this.FiveButton.TabIndex = 9;
            this.FiveButton.Text = "5";
            this.FiveButton.UseVisualStyleBackColor = true;
            this.FiveButton.Click += new System.EventHandler(this.bmiCalculatorButton_Click);
            // 
            // FourButton
            // 
            this.FourButton.Location = new System.Drawing.Point(3, 117);
            this.FourButton.Name = "FourButton";
            this.FourButton.Size = new System.Drawing.Size(60, 47);
            this.FourButton.TabIndex = 8;
            this.FourButton.Text = "4";
            this.FourButton.UseVisualStyleBackColor = true;
            this.FourButton.Click += new System.EventHandler(this.bmiCalculatorButton_Click);
            // 
            // NineButton
            // 
            this.NineButton.Location = new System.Drawing.Point(141, 60);
            this.NineButton.Name = "NineButton";
            this.NineButton.Size = new System.Drawing.Size(60, 47);
            this.NineButton.TabIndex = 6;
            this.NineButton.Text = "9";
            this.NineButton.UseVisualStyleBackColor = true;
            this.NineButton.Click += new System.EventHandler(this.bmiCalculatorButton_Click);
            // 
            // EightButton
            // 
            this.EightButton.Location = new System.Drawing.Point(72, 60);
            this.EightButton.Name = "EightButton";
            this.EightButton.Size = new System.Drawing.Size(60, 47);
            this.EightButton.TabIndex = 5;
            this.EightButton.Text = "8";
            this.EightButton.UseVisualStyleBackColor = true;
            this.EightButton.Click += new System.EventHandler(this.bmiCalculatorButton_Click);
            // 
            // SevenButton
            // 
            this.SevenButton.Location = new System.Drawing.Point(3, 60);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(60, 47);
            this.SevenButton.TabIndex = 4;
            this.SevenButton.Text = "7";
            this.SevenButton.UseVisualStyleBackColor = true;
            this.SevenButton.Click += new System.EventHandler(this.bmiCalculatorButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BackButton.ForeColor = System.Drawing.Color.White;
            this.BackButton.Location = new System.Drawing.Point(210, 3);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(62, 47);
            this.BackButton.TabIndex = 2;
            this.BackButton.Text = "<-";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // height
            // 
            this.height.CausesValidation = false;
            this.height.Location = new System.Drawing.Point(178, 135);
            this.height.Name = "height";
            this.height.ReadOnly = true;
            this.height.Size = new System.Drawing.Size(147, 45);
            this.height.TabIndex = 9;
            this.height.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.height.Click += new System.EventHandler(this.height_TextChanged);
            this.height.TextChanged += new System.EventHandler(this.height_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 39);
            this.label1.TabIndex = 10;
            this.label1.Text = "My Height";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 39);
            this.label2.TabIndex = 11;
            this.label2.Text = "My Weight";
            // 
            // weight
            // 
            this.weight.CausesValidation = false;
            this.weight.Location = new System.Drawing.Point(178, 200);
            this.weight.Name = "weight";
            this.weight.ReadOnly = true;
            this.weight.Size = new System.Drawing.Size(147, 45);
            this.weight.TabIndex = 12;
            this.weight.TabStop = false;
            this.weight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.weight.Click += new System.EventHandler(this.height_TextChanged);
            // 
            // bmiscale
            // 
            this.bmiscale.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bmiscale.Enabled = false;
            this.bmiscale.Location = new System.Drawing.Point(178, 329);
            this.bmiscale.Name = "bmiscale";
            this.bmiscale.ReadOnly = true;
            this.bmiscale.Size = new System.Drawing.Size(288, 38);
            this.bmiscale.TabIndex = 13;
            this.bmiscale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bmiresult
            // 
            this.bmiresult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bmiresult.Enabled = false;
            this.bmiresult.Location = new System.Drawing.Point(178, 265);
            this.bmiresult.Name = "bmiresult";
            this.bmiresult.ReadOnly = true;
            this.bmiresult.Size = new System.Drawing.Size(265, 38);
            this.bmiresult.TabIndex = 14;
            this.bmiresult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 39);
            this.label3.TabIndex = 15;
            this.label3.Text = "BMI result";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 39);
            this.label4.TabIndex = 16;
            this.label4.Text = "BMI Scale";
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClearButton.ForeColor = System.Drawing.Color.White;
            this.ClearButton.Location = new System.Drawing.Point(3, 3);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(63, 41);
            this.ClearButton.TabIndex = 19;
            this.ClearButton.Text = "C";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // bmiCalculator
            // 
            this.AcceptButton = this.bmicalculatebutton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(530, 704);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bmiresult);
            this.Controls.Add(this.bmiscale);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bmicalculatebutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.height);
            this.Controls.Add(this.TableLayoutPanel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.imperialbutton);
            this.Controls.Add(this.metricbutton);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.MaximizeBox = false;
            this.Name = "bmiCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.TableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton metricbutton;
        private System.Windows.Forms.RadioButton imperialbutton;
        private System.Windows.Forms.Button bmicalculatebutton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel;
        private System.Windows.Forms.Button DecimalButton;
        private System.Windows.Forms.Button ZeroButton;
        private System.Windows.Forms.Button ThreeButton;
        private System.Windows.Forms.Button TwoButton;
        private System.Windows.Forms.Button OneButton;
        private System.Windows.Forms.Button SixButton;
        private System.Windows.Forms.Button FiveButton;
        private System.Windows.Forms.Button FourButton;
        private System.Windows.Forms.Button NineButton;
        private System.Windows.Forms.Button EightButton;
        private System.Windows.Forms.Button SevenButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.TextBox height;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox weight;
        private System.Windows.Forms.TextBox bmiscale;
        private System.Windows.Forms.TextBox bmiresult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ClearButton;
    }
}

