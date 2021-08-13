namespace Battle_Damage
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
            this.txtWeaponDamage = new System.Windows.Forms.TextBox();
            this.txtAttackPower = new System.Windows.Forms.TextBox();
            this.txtWeaponSpeed = new System.Windows.Forms.TextBox();
            this.txtDamMult = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblBatDamNoDisplay = new System.Windows.Forms.Label();
            this.btnCompute = new System.Windows.Forms.Button();
            this.lblBatDamDisp = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtWeaponDamage
            // 
            this.txtWeaponDamage.Location = new System.Drawing.Point(209, 45);
            this.txtWeaponDamage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtWeaponDamage.Name = "txtWeaponDamage";
            this.txtWeaponDamage.Size = new System.Drawing.Size(148, 26);
            this.txtWeaponDamage.TabIndex = 1;
            this.txtWeaponDamage.TextChanged += new System.EventHandler(this.txtChanged);
            // 
            // txtAttackPower
            // 
            this.txtAttackPower.Location = new System.Drawing.Point(209, 99);
            this.txtAttackPower.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAttackPower.Name = "txtAttackPower";
            this.txtAttackPower.Size = new System.Drawing.Size(148, 26);
            this.txtAttackPower.TabIndex = 2;
            this.txtAttackPower.TextChanged += new System.EventHandler(this.txtChanged);
            // 
            // txtWeaponSpeed
            // 
            this.txtWeaponSpeed.Location = new System.Drawing.Point(209, 153);
            this.txtWeaponSpeed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtWeaponSpeed.Name = "txtWeaponSpeed";
            this.txtWeaponSpeed.Size = new System.Drawing.Size(148, 26);
            this.txtWeaponSpeed.TabIndex = 3;
            this.txtWeaponSpeed.TextChanged += new System.EventHandler(this.txtChanged);
            // 
            // txtDamMult
            // 
            this.txtDamMult.Location = new System.Drawing.Point(209, 207);
            this.txtDamMult.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDamMult.Name = "txtDamMult";
            this.txtDamMult.Size = new System.Drawing.Size(148, 26);
            this.txtDamMult.TabIndex = 4;
            this.txtDamMult.TextChanged += new System.EventHandler(this.txtChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Weapon Damage";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Attack Power";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Weapon Speed";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 213);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Damage Multiplier";
            // 
            // lblBatDamNoDisplay
            // 
            this.lblBatDamNoDisplay.AutoSize = true;
            this.lblBatDamNoDisplay.Location = new System.Drawing.Point(361, 311);
            this.lblBatDamNoDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBatDamNoDisplay.Name = "lblBatDamNoDisplay";
            this.lblBatDamNoDisplay.Size = new System.Drawing.Size(120, 20);
            this.lblBatDamNoDisplay.TabIndex = 10;
            this.lblBatDamNoDisplay.Text = "Battle Damage:";
            // 
            // btnCompute
            // 
            this.btnCompute.Enabled = false;
            this.btnCompute.Location = new System.Drawing.Point(59, 304);
            this.btnCompute.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(112, 35);
            this.btnCompute.TabIndex = 12;
            this.btnCompute.Text = "Compute";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // lblBatDamDisp
            // 
            this.lblBatDamDisp.AutoSize = true;
            this.lblBatDamDisp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBatDamDisp.Location = new System.Drawing.Point(517, 309);
            this.lblBatDamDisp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBatDamDisp.MaximumSize = new System.Drawing.Size(299, 30);
            this.lblBatDamDisp.MinimumSize = new System.Drawing.Size(299, 30);
            this.lblBatDamDisp.Name = "lblBatDamDisp";
            this.lblBatDamDisp.Size = new System.Drawing.Size(299, 30);
            this.lblBatDamDisp.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(215, 377);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(328, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Calculations are determined with this formula:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 428);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(633, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Damage = (Weapon Damage + Attack Power / 3.5 * Weapon Speed) * Damage Multiplier";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(388, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "This number can range from 10-500.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(388, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(256, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "1 to 10 is the range for this textbox.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(388, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(254, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "1.0 is the lowest. 5.0 is the highest.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(388, 213);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(422, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "You can type in a range of numbers from 1.0 to 4.0 in here.";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(209, 304);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(118, 35);
            this.btnReset.TabIndex = 20;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(969, 513);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblBatDamDisp);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.lblBatDamNoDisplay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDamMult);
            this.Controls.Add(this.txtWeaponSpeed);
            this.Controls.Add(this.txtAttackPower);
            this.Controls.Add(this.txtWeaponDamage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Battle Damage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtWeaponDamage;
        private System.Windows.Forms.TextBox txtAttackPower;
        private System.Windows.Forms.TextBox txtWeaponSpeed;
        private System.Windows.Forms.TextBox txtDamMult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblBatDamNoDisplay;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.Label lblBatDamDisp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnReset;
    }
}

