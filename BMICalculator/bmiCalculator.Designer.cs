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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.weight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.height = new System.Windows.Forms.TextBox();
            this.bmiresult = new System.Windows.Forms.TextBox();
            this.bmiscale = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.metricbutton = new System.Windows.Forms.RadioButton();
            this.imperialbutton = new System.Windows.Forms.RadioButton();
            this.bmicalculatebutton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.weight, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.height, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.bmiresult, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.bmiscale, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 138);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.10735F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.89265F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(386, 339);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // weight
            // 
            this.weight.Location = new System.Drawing.Point(196, 97);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(187, 49);
            this.weight.TabIndex = 4;
            this.weight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "My Height";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 48);
            this.label3.TabIndex = 2;
            this.label3.Text = "Your BMI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 48);
            this.label2.TabIndex = 1;
            this.label2.Text = "My Weight";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 48);
            this.label4.TabIndex = 3;
            this.label4.Text = "BMI Scale";
            // 
            // height
            // 
            this.height.Location = new System.Drawing.Point(196, 3);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(187, 49);
            this.height.TabIndex = 1;
            this.height.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.height.Leave += new System.EventHandler(this.height_Leave);
            // 
            // bmiresult
            // 
            this.bmiresult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bmiresult.Enabled = false;
            this.bmiresult.Location = new System.Drawing.Point(196, 180);
            this.bmiresult.MaxLength = 3;
            this.bmiresult.Name = "bmiresult";
            this.bmiresult.ReadOnly = true;
            this.bmiresult.Size = new System.Drawing.Size(187, 42);
            this.bmiresult.TabIndex = 5;
            this.bmiresult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bmiscale
            // 
            this.bmiscale.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bmiscale.Enabled = false;
            this.bmiscale.Location = new System.Drawing.Point(196, 262);
            this.bmiscale.Name = "bmiscale";
            this.bmiscale.ReadOnly = true;
            this.bmiscale.Size = new System.Drawing.Size(187, 42);
            this.bmiscale.TabIndex = 6;
            this.bmiscale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(330, 48);
            this.label5.TabIndex = 1;
            this.label5.Text = "System Of Measurement";
            // 
            // metricbutton
            // 
            this.metricbutton.AutoSize = true;
            this.metricbutton.Location = new System.Drawing.Point(12, 80);
            this.metricbutton.Name = "metricbutton";
            this.metricbutton.Size = new System.Drawing.Size(123, 52);
            this.metricbutton.TabIndex = 2;
            this.metricbutton.Text = "metric";
            this.metricbutton.UseVisualStyleBackColor = true;
            this.metricbutton.CheckedChanged += new System.EventHandler(this.metricbutton_CheckedChanged);
            // 
            // imperialbutton
            // 
            this.imperialbutton.AutoSize = true;
            this.imperialbutton.Location = new System.Drawing.Point(141, 80);
            this.imperialbutton.Name = "imperialbutton";
            this.imperialbutton.Size = new System.Drawing.Size(146, 52);
            this.imperialbutton.TabIndex = 3;
            this.imperialbutton.Text = "imperial";
            this.imperialbutton.UseVisualStyleBackColor = true;
            this.imperialbutton.CheckedChanged += new System.EventHandler(this.imperialbutton_CheckedChanged);
            // 
            // bmicalculatebutton
            // 
            this.bmicalculatebutton.Enabled = false;
            this.bmicalculatebutton.Location = new System.Drawing.Point(340, 498);
            this.bmicalculatebutton.Name = "bmicalculatebutton";
            this.bmicalculatebutton.Size = new System.Drawing.Size(203, 56);
            this.bmicalculatebutton.TabIndex = 4;
            this.bmicalculatebutton.Text = "Calculate BMI";
            this.bmicalculatebutton.UseVisualStyleBackColor = true;
            this.bmicalculatebutton.Click += new System.EventHandler(this.bmicalculatebutton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(401, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 48);
            this.label6.TabIndex = 5;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(401, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 48);
            this.label7.TabIndex = 6;
            this.label7.Text = "Meters";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(401, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 48);
            this.label8.TabIndex = 7;
            this.label8.Text = "KG";
            // 
            // bmiCalculator
            // 
            this.AcceptButton = this.bmicalculatebutton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(569, 566);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bmicalculatebutton);
            this.Controls.Add(this.imperialbutton);
            this.Controls.Add(this.metricbutton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Sitka Banner", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.MaximizeBox = false;
            this.Name = "bmiCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.Load += new System.EventHandler(this.bmiCalculator_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox height;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton metricbutton;
        private System.Windows.Forms.RadioButton imperialbutton;
        private System.Windows.Forms.Button bmicalculatebutton;
        private System.Windows.Forms.TextBox weight;
        private System.Windows.Forms.TextBox bmiresult;
        private System.Windows.Forms.TextBox bmiscale;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

