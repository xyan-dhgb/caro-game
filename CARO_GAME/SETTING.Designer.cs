namespace CARO_GAME
{
    partial class SettingControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingControl));
            this.lightButton = new System.Windows.Forms.RadioButton();
            this.interfaceLabel = new System.Windows.Forms.Label();
            this.darkButton = new System.Windows.Forms.RadioButton();
            this.settingLabel = new System.Windows.Forms.Label();
            this.songLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.returnButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lightButton
            // 
            this.lightButton.AutoSize = true;
            this.lightButton.BackColor = System.Drawing.Color.Transparent;
            this.lightButton.Font = new System.Drawing.Font("Lucida Fax", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lightButton.Location = new System.Drawing.Point(380, 208);
            this.lightButton.Name = "lightButton";
            this.lightButton.Size = new System.Drawing.Size(111, 36);
            this.lightButton.TabIndex = 0;
            this.lightButton.TabStop = true;
            this.lightButton.Text = "Light";
            this.lightButton.UseVisualStyleBackColor = false;
            this.lightButton.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // interfaceLabel
            // 
            this.interfaceLabel.AutoSize = true;
            this.interfaceLabel.BackColor = System.Drawing.Color.Transparent;
            this.interfaceLabel.Font = new System.Drawing.Font("Lucida Fax", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interfaceLabel.Location = new System.Drawing.Point(36, 210);
            this.interfaceLabel.Name = "interfaceLabel";
            this.interfaceLabel.Size = new System.Drawing.Size(310, 32);
            this.interfaceLabel.TabIndex = 1;
            this.interfaceLabel.Text = "Choose your theme:";
            // 
            // darkButton
            // 
            this.darkButton.AutoSize = true;
            this.darkButton.BackColor = System.Drawing.Color.Transparent;
            this.darkButton.Font = new System.Drawing.Font("Lucida Fax", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darkButton.Location = new System.Drawing.Point(523, 208);
            this.darkButton.Name = "darkButton";
            this.darkButton.Size = new System.Drawing.Size(107, 36);
            this.darkButton.TabIndex = 2;
            this.darkButton.TabStop = true;
            this.darkButton.Text = "Dark";
            this.darkButton.UseVisualStyleBackColor = false;
            this.darkButton.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // settingLabel
            // 
            this.settingLabel.AutoSize = true;
            this.settingLabel.Font = new System.Drawing.Font("Algerian", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingLabel.Location = new System.Drawing.Point(163, 75);
            this.settingLabel.Name = "settingLabel";
            this.settingLabel.Size = new System.Drawing.Size(358, 89);
            this.settingLabel.TabIndex = 3;
            this.settingLabel.Text = "SETTING";
            // 
            // songLabel
            // 
            this.songLabel.AutoSize = true;
            this.songLabel.BackColor = System.Drawing.Color.Transparent;
            this.songLabel.Font = new System.Drawing.Font("Lucida Fax", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songLabel.Location = new System.Drawing.Point(36, 292);
            this.songLabel.Name = "songLabel";
            this.songLabel.Size = new System.Drawing.Size(288, 32);
            this.songLabel.TabIndex = 4;
            this.songLabel.Text = "Choose your song:";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.comboBox1.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "None",
            "Angry bird",
            "Daisy",
            "The Epic 2",
            "Thunder Unison"});
            this.comboBox1.Location = new System.Drawing.Point(380, 293);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(250, 31);
            this.comboBox1.TabIndex = 5;
            // 
            // returnButton
            // 
            this.returnButton.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnButton.Location = new System.Drawing.Point(493, 415);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(137, 44);
            this.returnButton.TabIndex = 6;
            this.returnButton.Text = "Home";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(42, 415);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(423, 44);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save your changes";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // SettingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.songLabel);
            this.Controls.Add(this.settingLabel);
            this.Controls.Add(this.darkButton);
            this.Controls.Add(this.interfaceLabel);
            this.Controls.Add(this.lightButton);
            this.Name = "SettingControl";
            this.Size = new System.Drawing.Size(667, 699);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton lightButton;
        private System.Windows.Forms.Label interfaceLabel;
        private System.Windows.Forms.RadioButton darkButton;
        private System.Windows.Forms.Label settingLabel;
        private System.Windows.Forms.Label songLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button saveButton;
    }
}
