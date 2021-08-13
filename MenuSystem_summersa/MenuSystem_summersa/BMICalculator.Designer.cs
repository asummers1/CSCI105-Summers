namespace MenuSystem_summersa
{
    partial class BMICalculator
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
            this.btnCompute = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtHeightFeet = new System.Windows.Forms.TextBox();
            this.txtHeightInches = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lblBMI = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBMISolution = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCompute
            // 
            this.btnCompute.Enabled = false;
            this.btnCompute.Location = new System.Drawing.Point(123, 204);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(115, 35);
            this.btnCompute.TabIndex = 1;
            this.btnCompute.Tag = "Calculate";
            this.btnCompute.Text = "Compute";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.BMIClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(332, 204);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 35);
            this.button2.TabIndex = 2;
            this.button2.Tag = "Reset";
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.BMIClick);
            // 
            // txtHeightFeet
            // 
            this.txtHeightFeet.Location = new System.Drawing.Point(123, 49);
            this.txtHeightFeet.Name = "txtHeightFeet";
            this.txtHeightFeet.Size = new System.Drawing.Size(100, 26);
            this.txtHeightFeet.TabIndex = 3;
            this.txtHeightFeet.TextChanged += new System.EventHandler(this.txtChecker);
            // 
            // txtHeightInches
            // 
            this.txtHeightInches.Location = new System.Drawing.Point(123, 114);
            this.txtHeightInches.Name = "txtHeightInches";
            this.txtHeightInches.Size = new System.Drawing.Size(100, 26);
            this.txtHeightInches.TabIndex = 4;
            this.txtHeightInches.TextChanged += new System.EventHandler(this.txtChecker);
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(432, 48);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(100, 26);
            this.txtWeight.TabIndex = 5;
            this.txtWeight.TextChanged += new System.EventHandler(this.txtChecker);
            // 
            // lblBMI
            // 
            this.lblBMI.AutoSize = true;
            this.lblBMI.Location = new System.Drawing.Point(277, 362);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(0, 20);
            this.lblBMI.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Feet:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Inches:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Weight (In Pounds):";
            // 
            // lblBMISolution
            // 
            this.lblBMISolution.AutoSize = true;
            this.lblBMISolution.Location = new System.Drawing.Point(53, 36);
            this.lblBMISolution.Name = "lblBMISolution";
            this.lblBMISolution.Size = new System.Drawing.Size(51, 20);
            this.lblBMISolution.TabIndex = 11;
            this.lblBMISolution.Text = "label5";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleGreen;
            this.groupBox1.Controls.Add(this.lblBMISolution);
            this.groupBox1.Location = new System.Drawing.Point(224, 262);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 81);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Solution";
            // 
            // BMICalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(583, 388);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBMI);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtHeightInches);
            this.Controls.Add(this.txtHeightFeet);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCompute);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BMICalculator";
            this.Text = "BMICalculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtHeightFeet;
        private System.Windows.Forms.TextBox txtHeightInches;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lblBMI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBMISolution;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}