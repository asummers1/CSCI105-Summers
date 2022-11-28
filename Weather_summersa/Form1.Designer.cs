namespace weatherapp
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lstbxFirstCityInfo = new System.Windows.Forms.ListBox();
            this.txtCity1 = new System.Windows.Forms.TextBox();
            this.txtCity2 = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblFirstCity = new System.Windows.Forms.Label();
            this.lblSecondCity = new System.Windows.Forms.Label();
            this.lblWeatherData = new System.Windows.Forms.Label();
            this.lstbxSecondCityInfo = new System.Windows.Forms.ListBox();
            this.lstbxComparer = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(184, 488);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(646, 40);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lstbxFirstCityInfo
            // 
            this.lstbxFirstCityInfo.FormattingEnabled = true;
            this.lstbxFirstCityInfo.HorizontalScrollbar = true;
            this.lstbxFirstCityInfo.ItemHeight = 20;
            this.lstbxFirstCityInfo.Location = new System.Drawing.Point(50, 149);
            this.lstbxFirstCityInfo.Name = "lstbxFirstCityInfo";
            this.lstbxFirstCityInfo.Size = new System.Drawing.Size(424, 224);
            this.lstbxFirstCityInfo.TabIndex = 1;
            // 
            // txtCity1
            // 
            this.txtCity1.Location = new System.Drawing.Point(135, 82);
            this.txtCity1.Name = "txtCity1";
            this.txtCity1.Size = new System.Drawing.Size(138, 26);
            this.txtCity1.TabIndex = 2;
            this.txtCity1.Validating += new System.ComponentModel.CancelEventHandler(this.txtCity1_Validating);
            // 
            // txtCity2
            // 
            this.txtCity2.Location = new System.Drawing.Point(627, 82);
            this.txtCity2.Name = "txtCity2";
            this.txtCity2.Size = new System.Drawing.Size(138, 26);
            this.txtCity2.TabIndex = 3;
            this.txtCity2.TextChanged += new System.EventHandler(this.txtCity2_TextChanged);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(184, 560);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(646, 40);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblFirstCity
            // 
            this.lblFirstCity.AutoSize = true;
            this.lblFirstCity.Location = new System.Drawing.Point(45, 86);
            this.lblFirstCity.Name = "lblFirstCity";
            this.lblFirstCity.Size = new System.Drawing.Size(70, 20);
            this.lblFirstCity.TabIndex = 5;
            this.lblFirstCity.Text = "First City";
            // 
            // lblSecondCity
            // 
            this.lblSecondCity.AutoSize = true;
            this.lblSecondCity.Location = new System.Drawing.Point(506, 86);
            this.lblSecondCity.Name = "lblSecondCity";
            this.lblSecondCity.Size = new System.Drawing.Size(94, 20);
            this.lblSecondCity.TabIndex = 6;
            this.lblSecondCity.Text = "Second City";
            // 
            // lblWeatherData
            // 
            this.lblWeatherData.AutoSize = true;
            this.lblWeatherData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeatherData.Location = new System.Drawing.Point(32, 12);
            this.lblWeatherData.Name = "lblWeatherData";
            this.lblWeatherData.Size = new System.Drawing.Size(204, 20);
            this.lblWeatherData.TabIndex = 7;
            this.lblWeatherData.Text = "Weather Data Comparer";
            // 
            // lstbxSecondCityInfo
            // 
            this.lstbxSecondCityInfo.FormattingEnabled = true;
            this.lstbxSecondCityInfo.ItemHeight = 20;
            this.lstbxSecondCityInfo.Location = new System.Drawing.Point(483, 149);
            this.lstbxSecondCityInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstbxSecondCityInfo.Name = "lstbxSecondCityInfo";
            this.lstbxSecondCityInfo.Size = new System.Drawing.Size(424, 224);
            this.lstbxSecondCityInfo.TabIndex = 8;
            // 
            // lstbxComparer
            // 
            this.lstbxComparer.FormattingEnabled = true;
            this.lstbxComparer.ItemHeight = 20;
            this.lstbxComparer.Location = new System.Drawing.Point(50, 385);
            this.lstbxComparer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstbxComparer.Name = "lstbxComparer";
            this.lstbxComparer.Size = new System.Drawing.Size(858, 84);
            this.lstbxComparer.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(152)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(982, 617);
            this.Controls.Add(this.lstbxComparer);
            this.Controls.Add(this.lstbxSecondCityInfo);
            this.Controls.Add(this.lblWeatherData);
            this.Controls.Add(this.lblSecondCity);
            this.Controls.Add(this.lblFirstCity);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtCity2);
            this.Controls.Add(this.txtCity1);
            this.Controls.Add(this.lstbxFirstCityInfo);
            this.Controls.Add(this.btnCalculate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Weather Data Comparer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.ListBox lstbxFirstCityInfo;
        private System.Windows.Forms.TextBox txtCity1;
        private System.Windows.Forms.TextBox txtCity2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblFirstCity;
        private System.Windows.Forms.Label lblSecondCity;
        private System.Windows.Forms.Label lblWeatherData;
        private System.Windows.Forms.ListBox lstbxSecondCityInfo;
        private System.Windows.Forms.ListBox lstbxComparer;
    }
}

