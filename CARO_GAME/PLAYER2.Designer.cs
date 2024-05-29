using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CARO_GAME
{
    partial class player1Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(player1Form));
            this.chessBoardPanel = new System.Windows.Forms.Panel();
            this.playerInfoPanel = new System.Windows.Forms.Panel();
            this.connectButton = new System.Windows.Forms.Button();
            this.IPTextBox = new System.Windows.Forms.TextBox();
            this.ipLabel = new System.Windows.Forms.Label();
            this.playerLabel = new System.Windows.Forms.Label();
            this.player1Image = new System.Windows.Forms.PictureBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.processBar = new System.Windows.Forms.ProgressBar();
            this.picturePanel = new System.Windows.Forms.Panel();
            this.timerCountDown = new System.Windows.Forms.Timer(this.components);
            this.playerInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player1Image)).BeginInit();
            this.SuspendLayout();
            // 
            // chessBoardPanel
            // 
            this.chessBoardPanel.BackColor = System.Drawing.Color.White;
            this.chessBoardPanel.Location = new System.Drawing.Point(13, 13);
            this.chessBoardPanel.Name = "chessBoardPanel";
            this.chessBoardPanel.Size = new System.Drawing.Size(559, 740);
            this.chessBoardPanel.TabIndex = 0;
            // 
            // playerInfoPanel
            // 
            this.playerInfoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.playerInfoPanel.Controls.Add(this.connectButton);
            this.playerInfoPanel.Controls.Add(this.IPTextBox);
            this.playerInfoPanel.Controls.Add(this.ipLabel);
            this.playerInfoPanel.Controls.Add(this.playerLabel);
            this.playerInfoPanel.Controls.Add(this.player1Image);
            this.playerInfoPanel.Controls.Add(this.nameTextBox);
            this.playerInfoPanel.Location = new System.Drawing.Point(605, 444);
            this.playerInfoPanel.Name = "playerInfoPanel";
            this.playerInfoPanel.Size = new System.Drawing.Size(459, 309);
            this.playerInfoPanel.TabIndex = 2;
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
            this.IPTextBox.BackColor = System.Drawing.Color.White;
            this.IPTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPTextBox.Location = new System.Drawing.Point(12, 139);
            this.IPTextBox.Name = "IPTextBox";
            this.IPTextBox.ReadOnly = true;
            this.IPTextBox.Size = new System.Drawing.Size(220, 30);
            this.IPTextBox.TabIndex = 4;
            this.IPTextBox.Text = "127.0.0.1";
            // 
            // ipLabel
            // 
            this.ipLabel.AutoSize = true;
            this.ipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipLabel.Location = new System.Drawing.Point(9, 111);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(162, 25);
            this.ipLabel.TabIndex = 3;
            this.ipLabel.Text = "Enter IP address:";
            // 
            // playerLabel
            // 
            this.playerLabel.AutoSize = true;
            this.playerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerLabel.Location = new System.Drawing.Point(9, 25);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(141, 25);
            this.playerLabel.TabIndex = 2;
            this.playerLabel.Text = "Player\'s name:";
            // 
            // player1Image
            // 
            this.player1Image.BackColor = System.Drawing.SystemColors.Control;
            this.player1Image.Location = new System.Drawing.Point(238, 3);
            this.player1Image.Name = "player1Image";
            this.player1Image.Size = new System.Drawing.Size(218, 198);
            this.player1Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player1Image.TabIndex = 1;
            this.player1Image.TabStop = false;
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.White;
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(12, 54);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(220, 30);
            this.nameTextBox.TabIndex = 0;
            // 
            // processBar
            // 
            this.processBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.processBar.ForeColor = System.Drawing.Color.Teal;
            this.processBar.Location = new System.Drawing.Point(605, 372);
            this.processBar.Name = "processBar";
            this.processBar.Size = new System.Drawing.Size(459, 43);
            this.processBar.TabIndex = 1;
            // 
            // picturePanel
            // 
            this.picturePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picturePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picturePanel.BackgroundImage")));
            this.picturePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picturePanel.Location = new System.Drawing.Point(605, 13);
            this.picturePanel.Name = "picturePanel";
            this.picturePanel.Size = new System.Drawing.Size(459, 335);
            this.picturePanel.TabIndex = 1;
            // 
            // timerCountDown
            // 
            this.timerCountDown.Tick += new System.EventHandler(this.timerCountDown_Tick);
            // 
            // player1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1076, 765);
            this.Controls.Add(this.processBar);
            this.Controls.Add(this.playerInfoPanel);
            this.Controls.Add(this.picturePanel);
            this.Controls.Add(this.chessBoardPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "player1Form";
            this.Text = "PLAYER1";
            this.playerInfoPanel.ResumeLayout(false);
            this.playerInfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player1Image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel chessBoardPanel;
        private System.Windows.Forms.Panel playerInfoPanel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.PictureBox player1Image;
        private System.Windows.Forms.ProgressBar processBar;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.TextBox IPTextBox;
        private System.Windows.Forms.Label ipLabel;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.Panel picturePanel;
        private Timer timerCountDown;
    }
}
