namespace MenuSystem_summersa
{
    partial class DistanceFormula
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
            this.txtX1 = new System.Windows.Forms.TextBox();
            this.txtY1 = new System.Windows.Forms.TextBox();
            this.txtX2 = new System.Windows.Forms.TextBox();
            this.txtY2 = new System.Windows.Forms.TextBox();
            this.lblx1 = new System.Windows.Forms.Label();
            this.lblx2 = new System.Windows.Forms.Label();
            this.lbly1 = new System.Windows.Forms.Label();
            this.lbly2 = new System.Windows.Forms.Label();
            this.btnCompute = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSolution = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtX1
            // 
            this.txtX1.Location = new System.Drawing.Point(70, 25);
            this.txtX1.Name = "txtX1";
            this.txtX1.Size = new System.Drawing.Size(100, 26);
            this.txtX1.TabIndex = 0;
            this.txtX1.TextChanged += new System.EventHandler(this.txtChanged);
            // 
            // txtY1
            // 
            this.txtY1.Location = new System.Drawing.Point(285, 31);
            this.txtY1.Name = "txtY1";
            this.txtY1.Size = new System.Drawing.Size(100, 26);
            this.txtY1.TabIndex = 1;
            this.txtY1.TextChanged += new System.EventHandler(this.txtChanged);
            // 
            // txtX2
            // 
            this.txtX2.Location = new System.Drawing.Point(70, 82);
            this.txtX2.Name = "txtX2";
            this.txtX2.Size = new System.Drawing.Size(100, 26);
            this.txtX2.TabIndex = 2;
            this.txtX2.TextChanged += new System.EventHandler(this.txtChanged);
            // 
            // txtY2
            // 
            this.txtY2.Location = new System.Drawing.Point(285, 82);
            this.txtY2.Name = "txtY2";
            this.txtY2.Size = new System.Drawing.Size(100, 26);
            this.txtY2.TabIndex = 3;
            this.txtY2.TextChanged += new System.EventHandler(this.txtChanged);
            // 
            // lblx1
            // 
            this.lblx1.AutoSize = true;
            this.lblx1.Location = new System.Drawing.Point(30, 31);
            this.lblx1.Name = "lblx1";
            this.lblx1.Size = new System.Drawing.Size(29, 20);
            this.lblx1.TabIndex = 4;
            this.lblx1.Text = "x1:";
            // 
            // lblx2
            // 
            this.lblx2.AutoSize = true;
            this.lblx2.Location = new System.Drawing.Point(30, 82);
            this.lblx2.Name = "lblx2";
            this.lblx2.Size = new System.Drawing.Size(29, 20);
            this.lblx2.TabIndex = 5;
            this.lblx2.Text = "x2:";
            // 
            // lbly1
            // 
            this.lbly1.AutoSize = true;
            this.lbly1.Location = new System.Drawing.Point(226, 31);
            this.lbly1.Name = "lbly1";
            this.lbly1.Size = new System.Drawing.Size(29, 20);
            this.lbly1.TabIndex = 6;
            this.lbly1.Text = "y1:";
            // 
            // lbly2
            // 
            this.lbly2.AutoSize = true;
            this.lbly2.Location = new System.Drawing.Point(226, 82);
            this.lbly2.Name = "lbly2";
            this.lbly2.Size = new System.Drawing.Size(29, 20);
            this.lbly2.TabIndex = 7;
            this.lbly2.Text = "y2:";
            // 
            // btnCompute
            // 
            this.btnCompute.Enabled = false;
            this.btnCompute.Location = new System.Drawing.Point(176, 341);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(148, 35);
            this.btnCompute.TabIndex = 8;
            this.btnCompute.Text = "Calculate";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(410, 341);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(153, 35);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Welcome to the Distance Formula Calculator!";
            // 
            // lblSolution
            // 
            this.lblSolution.AutoSize = true;
            this.lblSolution.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSolution.Location = new System.Drawing.Point(236, 168);
            this.lblSolution.Name = "lblSolution";
            this.lblSolution.Size = new System.Drawing.Size(2, 22);
            this.lblSolution.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Solution:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox1.Controls.Add(this.txtX1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblSolution);
            this.groupBox1.Controls.Add(this.lblx1);
            this.groupBox1.Controls.Add(this.txtX2);
            this.groupBox1.Controls.Add(this.lblx2);
            this.groupBox1.Controls.Add(this.txtY1);
            this.groupBox1.Controls.Add(this.lbly1);
            this.groupBox1.Controls.Add(this.txtY2);
            this.groupBox1.Controls.Add(this.lbly2);
            this.groupBox1.Location = new System.Drawing.Point(69, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 239);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type in your numbers here:";
            // 
            // DistanceFormula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCompute);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "DistanceFormula";
            this.Text = "DistanceFormula";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtX1;
        private System.Windows.Forms.TextBox txtY1;
        private System.Windows.Forms.TextBox txtX2;
        private System.Windows.Forms.TextBox txtY2;
        private System.Windows.Forms.Label lblx1;
        private System.Windows.Forms.Label lblx2;
        private System.Windows.Forms.Label lbly1;
        private System.Windows.Forms.Label lbly2;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSolution;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}