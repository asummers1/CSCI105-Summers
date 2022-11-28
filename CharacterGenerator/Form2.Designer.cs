namespace CharacterGenerator
{
    partial class CharacterGenerator
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.cbxGender = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._Luck = new System.Windows.Forms.Label();
            this._Agility = new System.Windows.Forms.Label();
            this._Perception = new System.Windows.Forms.Label();
            this._Endurance = new System.Windows.Forms.Label();
            this._Charisma = new System.Windows.Forms.Label();
            this._Wisdom = new System.Windows.Forms.Label();
            this._Intelligence = new System.Windows.Forms.Label();
            this._Constitution = new System.Windows.Forms.Label();
            this._Dexterity = new System.Windows.Forms.Label();
            this._Strength = new System.Windows.Forms.Label();
            this.lblLuck = new System.Windows.Forms.Label();
            this.lblConstitution = new System.Windows.Forms.Label();
            this.lblAgility = new System.Windows.Forms.Label();
            this.lblStrength = new System.Windows.Forms.Label();
            this.lblPerception = new System.Windows.Forms.Label();
            this.lblDexterity = new System.Windows.Forms.Label();
            this.lblEndurance = new System.Windows.Forms.Label();
            this.lblIntelligence = new System.Windows.Forms.Label();
            this.lblCharisma = new System.Windows.Forms.Label();
            this.lblWisdom = new System.Windows.Forms.Label();
            this.cbxRace = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxJob = new System.Windows.Forms.ComboBox();
            this.pctCharacterPortrait = new System.Windows.Forms.PictureBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctCharacterPortrait)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(212, 67);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(178, 26);
            this.txtName.TabIndex = 0;
            // 
            // cbxGender
            // 
            this.cbxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGender.FormattingEnabled = true;
            this.cbxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbxGender.Location = new System.Drawing.Point(212, 134);
            this.cbxGender.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxGender.Name = "cbxGender";
            this.cbxGender.Size = new System.Drawing.Size(180, 28);
            this.cbxGender.TabIndex = 2;
            this.cbxGender.Tag = "Gender";
            this.cbxGender.SelectedIndexChanged += new System.EventHandler(this.cbxGender_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 137);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Gender:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 212);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Race:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._Luck);
            this.groupBox1.Controls.Add(this._Agility);
            this.groupBox1.Controls.Add(this._Perception);
            this.groupBox1.Controls.Add(this._Endurance);
            this.groupBox1.Controls.Add(this._Charisma);
            this.groupBox1.Controls.Add(this._Wisdom);
            this.groupBox1.Controls.Add(this._Intelligence);
            this.groupBox1.Controls.Add(this._Constitution);
            this.groupBox1.Controls.Add(this._Dexterity);
            this.groupBox1.Controls.Add(this._Strength);
            this.groupBox1.Controls.Add(this.lblLuck);
            this.groupBox1.Controls.Add(this.lblConstitution);
            this.groupBox1.Controls.Add(this.lblAgility);
            this.groupBox1.Controls.Add(this.lblStrength);
            this.groupBox1.Controls.Add(this.lblPerception);
            this.groupBox1.Controls.Add(this.lblDexterity);
            this.groupBox1.Controls.Add(this.lblEndurance);
            this.groupBox1.Controls.Add(this.lblIntelligence);
            this.groupBox1.Controls.Add(this.lblCharisma);
            this.groupBox1.Controls.Add(this.lblWisdom);
            this.groupBox1.Location = new System.Drawing.Point(96, 394);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1028, 240);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Statistics";
            // 
            // _Luck
            // 
            this._Luck.AutoSize = true;
            this._Luck.Location = new System.Drawing.Point(556, 195);
            this._Luck.Name = "_Luck";
            this._Luck.Size = new System.Drawing.Size(47, 20);
            this._Luck.TabIndex = 29;
            this._Luck.Text = "Luck:";
            // 
            // _Agility
            // 
            this._Agility.AutoSize = true;
            this._Agility.Location = new System.Drawing.Point(556, 159);
            this._Agility.Name = "_Agility";
            this._Agility.Size = new System.Drawing.Size(54, 20);
            this._Agility.TabIndex = 28;
            this._Agility.Text = "Agility:";
            // 
            // _Perception
            // 
            this._Perception.AutoSize = true;
            this._Perception.Location = new System.Drawing.Point(556, 125);
            this._Perception.Name = "_Perception";
            this._Perception.Size = new System.Drawing.Size(89, 20);
            this._Perception.TabIndex = 27;
            this._Perception.Text = "Perception:";
            // 
            // _Endurance
            // 
            this._Endurance.AutoSize = true;
            this._Endurance.Location = new System.Drawing.Point(554, 83);
            this._Endurance.Name = "_Endurance";
            this._Endurance.Size = new System.Drawing.Size(91, 20);
            this._Endurance.TabIndex = 26;
            this._Endurance.Text = "Endurance:";
            // 
            // _Charisma
            // 
            this._Charisma.AutoSize = true;
            this._Charisma.Location = new System.Drawing.Point(554, 48);
            this._Charisma.Name = "_Charisma";
            this._Charisma.Size = new System.Drawing.Size(80, 20);
            this._Charisma.TabIndex = 25;
            this._Charisma.Text = "Charisma:";
            // 
            // _Wisdom
            // 
            this._Wisdom.AutoSize = true;
            this._Wisdom.Location = new System.Drawing.Point(70, 208);
            this._Wisdom.Name = "_Wisdom";
            this._Wisdom.Size = new System.Drawing.Size(70, 20);
            this._Wisdom.TabIndex = 24;
            this._Wisdom.Text = "Wisdom:";
            // 
            // _Intelligence
            // 
            this._Intelligence.AutoSize = true;
            this._Intelligence.Location = new System.Drawing.Point(70, 171);
            this._Intelligence.Name = "_Intelligence";
            this._Intelligence.Size = new System.Drawing.Size(94, 20);
            this._Intelligence.TabIndex = 23;
            this._Intelligence.Text = "Intelligence:";
            // 
            // _Constitution
            // 
            this._Constitution.AutoSize = true;
            this._Constitution.Location = new System.Drawing.Point(70, 127);
            this._Constitution.Name = "_Constitution";
            this._Constitution.Size = new System.Drawing.Size(98, 20);
            this._Constitution.TabIndex = 22;
            this._Constitution.Text = "Constitution:";
            // 
            // _Dexterity
            // 
            this._Dexterity.AutoSize = true;
            this._Dexterity.Location = new System.Drawing.Point(70, 83);
            this._Dexterity.Name = "_Dexterity";
            this._Dexterity.Size = new System.Drawing.Size(75, 20);
            this._Dexterity.TabIndex = 21;
            this._Dexterity.Text = "Dexterity:";
            // 
            // _Strength
            // 
            this._Strength.AutoSize = true;
            this._Strength.Location = new System.Drawing.Point(66, 38);
            this._Strength.Name = "_Strength";
            this._Strength.Size = new System.Drawing.Size(75, 20);
            this._Strength.TabIndex = 20;
            this._Strength.Text = "Strength:";
            // 
            // lblLuck
            // 
            this.lblLuck.AutoSize = true;
            this.lblLuck.Location = new System.Drawing.Point(721, 195);
            this.lblLuck.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLuck.Name = "lblLuck";
            this.lblLuck.Size = new System.Drawing.Size(60, 20);
            this.lblLuck.TabIndex = 19;
            this.lblLuck.Text = "label13";
            // 
            // lblConstitution
            // 
            this.lblConstitution.AutoSize = true;
            this.lblConstitution.Location = new System.Drawing.Point(175, 128);
            this.lblConstitution.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConstitution.Name = "lblConstitution";
            this.lblConstitution.Size = new System.Drawing.Size(51, 20);
            this.lblConstitution.TabIndex = 12;
            this.lblConstitution.Text = "label6";
            // 
            // lblAgility
            // 
            this.lblAgility.AutoSize = true;
            this.lblAgility.Location = new System.Drawing.Point(721, 159);
            this.lblAgility.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAgility.Name = "lblAgility";
            this.lblAgility.Size = new System.Drawing.Size(60, 20);
            this.lblAgility.TabIndex = 18;
            this.lblAgility.Text = "label12";
            // 
            // lblStrength
            // 
            this.lblStrength.AutoSize = true;
            this.lblStrength.Location = new System.Drawing.Point(175, 38);
            this.lblStrength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStrength.Name = "lblStrength";
            this.lblStrength.Size = new System.Drawing.Size(51, 20);
            this.lblStrength.TabIndex = 10;
            this.lblStrength.Tag = "";
            this.lblStrength.Text = "label4";
            // 
            // lblPerception
            // 
            this.lblPerception.AutoSize = true;
            this.lblPerception.Location = new System.Drawing.Point(721, 125);
            this.lblPerception.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPerception.Name = "lblPerception";
            this.lblPerception.Size = new System.Drawing.Size(60, 20);
            this.lblPerception.TabIndex = 17;
            this.lblPerception.Text = "label11";
            // 
            // lblDexterity
            // 
            this.lblDexterity.AutoSize = true;
            this.lblDexterity.Location = new System.Drawing.Point(175, 83);
            this.lblDexterity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDexterity.Name = "lblDexterity";
            this.lblDexterity.Size = new System.Drawing.Size(51, 20);
            this.lblDexterity.TabIndex = 10;
            this.lblDexterity.Tag = "";
            this.lblDexterity.Text = "label5";
            // 
            // lblEndurance
            // 
            this.lblEndurance.AutoSize = true;
            this.lblEndurance.Location = new System.Drawing.Point(721, 83);
            this.lblEndurance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEndurance.Name = "lblEndurance";
            this.lblEndurance.Size = new System.Drawing.Size(60, 20);
            this.lblEndurance.TabIndex = 16;
            this.lblEndurance.Text = "label10";
            // 
            // lblIntelligence
            // 
            this.lblIntelligence.AutoSize = true;
            this.lblIntelligence.Location = new System.Drawing.Point(175, 172);
            this.lblIntelligence.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIntelligence.Name = "lblIntelligence";
            this.lblIntelligence.Size = new System.Drawing.Size(51, 20);
            this.lblIntelligence.TabIndex = 13;
            this.lblIntelligence.Text = "label7";
            // 
            // lblCharisma
            // 
            this.lblCharisma.AutoSize = true;
            this.lblCharisma.Location = new System.Drawing.Point(721, 48);
            this.lblCharisma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCharisma.Name = "lblCharisma";
            this.lblCharisma.Size = new System.Drawing.Size(51, 20);
            this.lblCharisma.TabIndex = 15;
            this.lblCharisma.Text = "label9";
            // 
            // lblWisdom
            // 
            this.lblWisdom.AutoSize = true;
            this.lblWisdom.Location = new System.Drawing.Point(175, 208);
            this.lblWisdom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWisdom.Name = "lblWisdom";
            this.lblWisdom.Size = new System.Drawing.Size(51, 20);
            this.lblWisdom.TabIndex = 14;
            this.lblWisdom.Text = "label8";
            // 
            // cbxRace
            // 
            this.cbxRace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRace.FormattingEnabled = true;
            this.cbxRace.Items.AddRange(new object[] {
            "Human",
            "Reptile"});
            this.cbxRace.Location = new System.Drawing.Point(212, 209);
            this.cbxRace.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxRace.Name = "cbxRace";
            this.cbxRace.Size = new System.Drawing.Size(180, 28);
            this.cbxRace.TabIndex = 9;
            this.cbxRace.Tag = "Race";
            this.cbxRace.SelectedIndexChanged += new System.EventHandler(this.cbxRace_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(442, 67);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(174, 82);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Occupation:";
            // 
            // cbxJob
            // 
            this.cbxJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxJob.FormattingEnabled = true;
            this.cbxJob.Items.AddRange(new object[] {
            "Warrior",
            "Scientist",
            "Priest"});
            this.cbxJob.Location = new System.Drawing.Point(212, 283);
            this.cbxJob.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxJob.Name = "cbxJob";
            this.cbxJob.Size = new System.Drawing.Size(180, 28);
            this.cbxJob.TabIndex = 13;
            this.cbxJob.Tag = "Job";
            this.cbxJob.SelectedIndexChanged += new System.EventHandler(this.cbxJob_SelectedIndexChanged);
            // 
            // pctCharacterPortrait
            // 
            this.pctCharacterPortrait.Location = new System.Drawing.Point(846, 67);
            this.pctCharacterPortrait.Name = "pctCharacterPortrait";
            this.pctCharacterPortrait.Size = new System.Drawing.Size(261, 266);
            this.pctCharacterPortrait.TabIndex = 14;
            this.pctCharacterPortrait.TabStop = false;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(642, 67);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(174, 82);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // CharacterGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CharacterGenerator.Properties.Resources.CharacterGenBackground;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.pctCharacterPortrait);
            this.Controls.Add(this.cbxJob);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbxRace);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxGender);
            this.Controls.Add(this.txtName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "CharacterGenerator";
            this.Text = "Character Generator";
            this.Load += new System.EventHandler(this.CharacterGenerator_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctCharacterPortrait)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cbxGender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxRace;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblLuck;
        private System.Windows.Forms.Label lblConstitution;
        private System.Windows.Forms.Label lblAgility;
        private System.Windows.Forms.Label lblStrength;
        private System.Windows.Forms.Label lblPerception;
        private System.Windows.Forms.Label lblDexterity;
        private System.Windows.Forms.Label lblEndurance;
        private System.Windows.Forms.Label lblIntelligence;
        private System.Windows.Forms.Label lblCharisma;
        private System.Windows.Forms.Label lblWisdom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label _Luck;
        private System.Windows.Forms.Label _Agility;
        private System.Windows.Forms.Label _Perception;
        private System.Windows.Forms.Label _Endurance;
        private System.Windows.Forms.Label _Charisma;
        private System.Windows.Forms.Label _Wisdom;
        private System.Windows.Forms.Label _Intelligence;
        private System.Windows.Forms.Label _Constitution;
        private System.Windows.Forms.Label _Dexterity;
        private System.Windows.Forms.Label _Strength;
        private System.Windows.Forms.ComboBox cbxJob;
        private System.Windows.Forms.PictureBox pctCharacterPortrait;
        private System.Windows.Forms.Button btnReset;
    }
}