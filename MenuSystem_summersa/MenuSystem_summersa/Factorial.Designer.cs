namespace MenuSystem_summersa
{
    partial class Factorial
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
            this.txtFactorial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCompute = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblSolution = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSolutionlbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFactorial
            // 
            this.txtFactorial.Location = new System.Drawing.Point(300, 103);
            this.txtFactorial.Name = "txtFactorial";
            this.txtFactorial.Size = new System.Drawing.Size(100, 26);
            this.txtFactorial.TabIndex = 0;
            this.txtFactorial.TextChanged += new System.EventHandler(this.TxtAccurateInput);
           
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to the Factorial Calculator!";
            // 
            // btnCompute
            // 
            this.btnCompute.Enabled = false;
            this.btnCompute.Location = new System.Drawing.Point(18, 25);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(94, 52);
            this.btnCompute.TabIndex = 2;
            this.btnCompute.Tag = "Compute";
            this.btnCompute.Text = "Compute";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.FactorialClick);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(158, 25);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(94, 52);
            this.btnReset.TabIndex = 3;
            this.btnReset.Tag = "Reset";
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblSolution
            // 
            this.lblSolution.AutoSize = true;
            this.lblSolution.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSolution.Location = new System.Drawing.Point(377, 277);
            this.lblSolution.Name = "lblSolution";
            this.lblSolution.Size = new System.Drawing.Size(2, 22);
            this.lblSolution.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Please type in your number here:";
            // 
            // lblSolutionlbl
            // 
            this.lblSolutionlbl.AutoSize = true;
            this.lblSolutionlbl.Location = new System.Drawing.Point(187, 277);
            this.lblSolutionlbl.Name = "lblSolutionlbl";
            this.lblSolutionlbl.Size = new System.Drawing.Size(71, 20);
            this.lblSolutionlbl.TabIndex = 6;
            this.lblSolutionlbl.Text = "Solution:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkKhaki;
            this.groupBox1.Controls.Add(this.btnCompute);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Location = new System.Drawing.Point(132, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 103);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculation Buttons";
            // 
            // Factorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(602, 372);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblSolutionlbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSolution);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFactorial);
            this.Name = "Factorial";
            this.Text = "Factorial";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFactorial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblSolution;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSolutionlbl;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}