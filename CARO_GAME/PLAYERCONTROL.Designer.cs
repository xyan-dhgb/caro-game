namespace CARO_GAME
{
    partial class PlayerControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerControl));
            this.player1Button = new System.Windows.Forms.Button();
            this.play2Button = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // player1Button
            // 
            this.player1Button.Font = new System.Drawing.Font("Lucida Fax", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1Button.Location = new System.Drawing.Point(233, 187);
            this.player1Button.Name = "player1Button";
            this.player1Button.Size = new System.Drawing.Size(234, 60);
            this.player1Button.TabIndex = 0;
            this.player1Button.Text = "PLAYER 1";
            this.player1Button.UseVisualStyleBackColor = true;
            this.player1Button.Click += new System.EventHandler(this.player1Button_Click);
            // 
            // play2Button
            // 
            this.play2Button.Font = new System.Drawing.Font("Lucida Fax", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play2Button.Location = new System.Drawing.Point(233, 293);
            this.play2Button.Name = "play2Button";
            this.play2Button.Size = new System.Drawing.Size(234, 60);
            this.play2Button.TabIndex = 1;
            this.play2Button.Text = "PLAYER 2";
            this.play2Button.UseVisualStyleBackColor = true;
            this.play2Button.Click += new System.EventHandler(this.play2Button_Click);
            // 
            // returnButton
            // 
            this.returnButton.Font = new System.Drawing.Font("Lucida Fax", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnButton.Location = new System.Drawing.Point(134, 401);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(431, 60);
            this.returnButton.TabIndex = 2;
            this.returnButton.Text = "RETURN TO HOME";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // PlayerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.play2Button);
            this.Controls.Add(this.player1Button);
            this.Name = "PlayerControl";
            this.Size = new System.Drawing.Size(684, 664);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button player1Button;
        private System.Windows.Forms.Button play2Button;
        private System.Windows.Forms.Button returnButton;
    }
}
