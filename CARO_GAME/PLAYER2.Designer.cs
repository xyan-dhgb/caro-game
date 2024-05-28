namespace CARO_GAME
{
    partial class player2Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(player2Form));
            this.chessBoardPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.connectButton = new System.Windows.Forms.Button();
            this.IPTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.player2Image = new System.Windows.Forms.PictureBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player2Image)).BeginInit();
            this.SuspendLayout();
            // 
            // chessBoardPanel
            // 
            this.chessBoardPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chessBoardPanel.Location = new System.Drawing.Point(13, 13);
            this.chessBoardPanel.Name = "chessBoardPanel";
            this.chessBoardPanel.Size = new System.Drawing.Size(559, 740);
            this.chessBoardPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(605, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 335);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.connectButton);
            this.panel2.Controls.Add(this.IPTextBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.player2Image);
            this.panel2.Controls.Add(this.nameTextBox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(605, 444);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(459, 309);
            this.panel2.TabIndex = 2;
            // 
            // connectButton
            // 
            this.connectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectButton.Location = new System.Drawing.Point(101, 237);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(280, 44);
            this.connectButton.TabIndex = 5;
            this.connectButton.Text = "CONNECT";
            this.connectButton.UseVisualStyleBackColor = true;
            // 
            // IPTextBox
            // 
            this.IPTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPTextBox.Location = new System.Drawing.Point(12, 139);
            this.IPTextBox.Name = "IPTextBox";
            this.IPTextBox.ReadOnly = true;
            this.IPTextBox.Size = new System.Drawing.Size(220, 30);
            this.IPTextBox.TabIndex = 4;
            this.IPTextBox.Text = "127.0.0.1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter IP address:";
            // 
            // player2Image
            // 
            this.player2Image.BackColor = System.Drawing.SystemColors.Control;
            this.player2Image.Location = new System.Drawing.Point(238, 3);
            this.player2Image.Name = "player2Image";
            this.player2Image.Size = new System.Drawing.Size(218, 198);
            this.player2Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player2Image.TabIndex = 2;
            this.player2Image.TabStop = false;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(12, 54);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(220, 30);
            this.nameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player\'s name: ";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(605, 372);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(459, 43);
            this.progressBar1.TabIndex = 3;
            // 
            // player2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 765);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chessBoardPanel);
            this.Name = "player2Form";
            this.Text = "PLAYER2";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player2Image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel chessBoardPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.PictureBox player2Image;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IPTextBox;
        private System.Windows.Forms.Button connectButton;
    }
}