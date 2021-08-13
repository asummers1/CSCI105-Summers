namespace WinQuadEquation
{
    partial class WinQuadEquation
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
            this.btnSolve = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.grpSolutions = new System.Windows.Forms.GroupBox();
            this.txtSolutionX2 = new System.Windows.Forms.Label();
            this.txtSolutionX1 = new System.Windows.Forms.Label();
            this.lblX2 = new System.Windows.Forms.Label();
            this.lblX1 = new System.Windows.Forms.Label();
            this.grpEqTerms = new System.Windows.Forms.GroupBox();
            this.txtTermC = new System.Windows.Forms.TextBox();
            this.lblTermC = new System.Windows.Forms.Label();
            this.txtTermB = new System.Windows.Forms.TextBox();
            this.lblTermB = new System.Windows.Forms.Label();
            this.txtTermA = new System.Windows.Forms.TextBox();
            this.lblTermA = new System.Windows.Forms.Label();
            this.grpSolutions.SuspendLayout();
            this.grpEqTerms.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSolve
            // 
            this.btnSolve.Enabled = false;
            this.btnSolve.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolve.Location = new System.Drawing.Point(18, 275);
            this.btnSolve.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(408, 60);
            this.btnSolve.TabIndex = 2;
            this.btnSolve.Text = "Solve";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.BtnSolve_Click);
            // 
            // btnReset
            // 
            this.btnReset.Enabled = false;
            this.btnReset.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(458, 275);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(408, 60);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // grpSolutions
            // 
            this.grpSolutions.BackColor = System.Drawing.Color.AntiqueWhite;
            this.grpSolutions.Controls.Add(this.txtSolutionX2);
            this.grpSolutions.Controls.Add(this.txtSolutionX1);
            this.grpSolutions.Controls.Add(this.lblX2);
            this.grpSolutions.Controls.Add(this.lblX1);
            this.grpSolutions.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSolutions.Location = new System.Drawing.Point(381, 18);
            this.grpSolutions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpSolutions.Name = "grpSolutions";
            this.grpSolutions.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpSolutions.Size = new System.Drawing.Size(484, 248);
            this.grpSolutions.TabIndex = 5;
            this.grpSolutions.TabStop = false;
            this.grpSolutions.Text = "Solutions";
            // 
            // txtSolutionX2
            // 
            this.txtSolutionX2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtSolutionX2.Location = new System.Drawing.Point(76, 134);
            this.txtSolutionX2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtSolutionX2.Name = "txtSolutionX2";
            this.txtSolutionX2.Size = new System.Drawing.Size(386, 42);
            this.txtSolutionX2.TabIndex = 8;
            this.txtSolutionX2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSolutionX1
            // 
            this.txtSolutionX1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtSolutionX1.Location = new System.Drawing.Point(76, 83);
            this.txtSolutionX1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtSolutionX1.Name = "txtSolutionX1";
            this.txtSolutionX1.Size = new System.Drawing.Size(386, 42);
            this.txtSolutionX1.TabIndex = 7;
            this.txtSolutionX1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblX2
            // 
            this.lblX2.AutoSize = true;
            this.lblX2.Location = new System.Drawing.Point(20, 138);
            this.lblX2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblX2.Name = "lblX2";
            this.lblX2.Size = new System.Drawing.Size(48, 30);
            this.lblX2.TabIndex = 4;
            this.lblX2.Text = "X2:";
            // 
            // lblX1
            // 
            this.lblX1.AutoSize = true;
            this.lblX1.Location = new System.Drawing.Point(20, 88);
            this.lblX1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblX1.Name = "lblX1";
            this.lblX1.Size = new System.Drawing.Size(48, 30);
            this.lblX1.TabIndex = 2;
            this.lblX1.Text = "X1:";
            // 
            // grpEqTerms
            // 
            this.grpEqTerms.BackColor = System.Drawing.Color.AntiqueWhite;
            this.grpEqTerms.Controls.Add(this.txtTermC);
            this.grpEqTerms.Controls.Add(this.lblTermC);
            this.grpEqTerms.Controls.Add(this.txtTermB);
            this.grpEqTerms.Controls.Add(this.lblTermB);
            this.grpEqTerms.Controls.Add(this.txtTermA);
            this.grpEqTerms.Controls.Add(this.lblTermA);
            this.grpEqTerms.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEqTerms.Location = new System.Drawing.Point(18, 18);
            this.grpEqTerms.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpEqTerms.Name = "grpEqTerms";
            this.grpEqTerms.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpEqTerms.Size = new System.Drawing.Size(340, 248);
            this.grpEqTerms.TabIndex = 4;
            this.grpEqTerms.TabStop = false;
            this.grpEqTerms.Text = "Equation Terms";
            // 
            // txtTermC
            // 
            this.txtTermC.Location = new System.Drawing.Point(152, 166);
            this.txtTermC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTermC.Name = "txtTermC";
            this.txtTermC.Size = new System.Drawing.Size(150, 37);
            this.txtTermC.TabIndex = 2;
            this.txtTermC.TextChanged += new System.EventHandler(this.TxtTermC_TextChanged);
            // 
            // lblTermC
            // 
            this.lblTermC.AutoSize = true;
            this.lblTermC.Location = new System.Drawing.Point(33, 171);
            this.lblTermC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTermC.Name = "lblTermC";
            this.lblTermC.Size = new System.Drawing.Size(112, 30);
            this.lblTermC.TabIndex = 4;
            this.lblTermC.Text = "Term C: ";
            // 
            // txtTermB
            // 
            this.txtTermB.Location = new System.Drawing.Point(152, 115);
            this.txtTermB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTermB.Name = "txtTermB";
            this.txtTermB.Size = new System.Drawing.Size(150, 37);
            this.txtTermB.TabIndex = 1;
            this.txtTermB.TextChanged += new System.EventHandler(this.TxtTermB_TextChanged);
            // 
            // lblTermB
            // 
            this.lblTermB.AutoSize = true;
            this.lblTermB.Location = new System.Drawing.Point(33, 120);
            this.lblTermB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTermB.Name = "lblTermB";
            this.lblTermB.Size = new System.Drawing.Size(106, 30);
            this.lblTermB.TabIndex = 2;
            this.lblTermB.Text = "Term B: ";
            // 
            // txtTermA
            // 
            this.txtTermA.Location = new System.Drawing.Point(152, 65);
            this.txtTermA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTermA.Name = "txtTermA";
            this.txtTermA.Size = new System.Drawing.Size(150, 37);
            this.txtTermA.TabIndex = 0;
            this.txtTermA.Validating += new System.ComponentModel.CancelEventHandler(this.TxtTermA_Validating);
            // 
            // lblTermA
            // 
            this.lblTermA.AutoSize = true;
            this.lblTermA.Location = new System.Drawing.Point(33, 69);
            this.lblTermA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTermA.Name = "lblTermA";
            this.lblTermA.Size = new System.Drawing.Size(109, 30);
            this.lblTermA.TabIndex = 0;
            this.lblTermA.Text = "Term A: ";
            // 
            // WinQuadEquation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ClientSize = new System.Drawing.Size(884, 362);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.grpSolutions);
            this.Controls.Add(this.grpEqTerms);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "WinQuadEquation";
            this.Text = "Quadratic Equation";
            this.Load += new System.EventHandler(this.WinQuadEquation_Load);
            this.grpSolutions.ResumeLayout(false);
            this.grpSolutions.PerformLayout();
            this.grpEqTerms.ResumeLayout(false);
            this.grpEqTerms.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox grpSolutions;
        private System.Windows.Forms.Label txtSolutionX2;
        private System.Windows.Forms.Label txtSolutionX1;
        private System.Windows.Forms.Label lblX2;
        private System.Windows.Forms.Label lblX1;
        private System.Windows.Forms.GroupBox grpEqTerms;
        private System.Windows.Forms.TextBox txtTermC;
        private System.Windows.Forms.Label lblTermC;
        private System.Windows.Forms.TextBox txtTermB;
        private System.Windows.Forms.Label lblTermB;
        private System.Windows.Forms.TextBox txtTermA;
        private System.Windows.Forms.Label lblTermA;
    }
}

