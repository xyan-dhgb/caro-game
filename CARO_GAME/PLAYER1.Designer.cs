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
            this.timerCountDown = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.processBar = new System.Windows.Forms.ProgressBar();
            this.timeLabel = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.IPTextBox = new System.Windows.Forms.TextBox();
            this.ipLabel = new System.Windows.Forms.Label();
            this.playerLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.player1Image = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeUIModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.clickhereLabel = new System.Windows.Forms.Label();
            this.mute = new System.Windows.Forms.PictureBox();
            this.unmute = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1Image)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unmute)).BeginInit();
            this.SuspendLayout();
            // 
            // chessBoardPanel
            // 
            this.chessBoardPanel.BackColor = System.Drawing.Color.White;
            this.chessBoardPanel.Location = new System.Drawing.Point(12, 13);
            this.chessBoardPanel.Name = "chessBoardPanel";
            this.chessBoardPanel.Size = new System.Drawing.Size(570, 688);
            this.chessBoardPanel.TabIndex = 0;
            // 
            // timerCountDown
            // 
            this.timerCountDown.Tick += new System.EventHandler(this.timerCountDown_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(854, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 3;
            // 
            // processBar
            // 
            this.processBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.processBar.BackColor = System.Drawing.Color.Red;
            this.processBar.ForeColor = System.Drawing.Color.Transparent;
            this.processBar.Location = new System.Drawing.Point(44, 482);
            this.processBar.Name = "processBar";
            this.processBar.Size = new System.Drawing.Size(459, 43);
            this.processBar.TabIndex = 1;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.BackColor = System.Drawing.Color.Transparent;
            this.timeLabel.Font = new System.Drawing.Font("Lucida Fax", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.timeLabel.Location = new System.Drawing.Point(214, 540);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(146, 32);
            this.timeLabel.TabIndex = 4;
            this.timeLabel.Text = "00:00:00";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // connectButton
            // 
            this.connectButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.connectButton.Font = new System.Drawing.Font("Lucida Fax", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectButton.Location = new System.Drawing.Point(147, 422);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(280, 44);
            this.connectButton.TabIndex = 11;
            this.connectButton.Text = "CONNECT";
            this.connectButton.UseVisualStyleBackColor = true;
            // 
            // IPTextBox
            // 
            this.IPTextBox.BackColor = System.Drawing.Color.LightSkyBlue;
            this.IPTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IPTextBox.Font = new System.Drawing.Font("Lucida Fax", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPTextBox.Location = new System.Drawing.Point(14, 354);
            this.IPTextBox.Name = "IPTextBox";
            this.IPTextBox.ReadOnly = true;
            this.IPTextBox.Size = new System.Drawing.Size(220, 31);
            this.IPTextBox.TabIndex = 10;
            this.IPTextBox.Text = "127.0.0.1";
            // 
            // ipLabel
            // 
            this.ipLabel.AutoSize = true;
            this.ipLabel.Font = new System.Drawing.Font("Lucida Fax", 14F);
            this.ipLabel.Location = new System.Drawing.Point(9, 324);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(219, 27);
            this.ipLabel.TabIndex = 9;
            this.ipLabel.Text = "Enter IP address:";
            // 
            // playerLabel
            // 
            this.playerLabel.AutoSize = true;
            this.playerLabel.Font = new System.Drawing.Font("Lucida Fax", 14F);
            this.playerLabel.Location = new System.Drawing.Point(9, 232);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(188, 27);
            this.playerLabel.TabIndex = 8;
            this.playerLabel.Text = "Player\'s name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.LightSkyBlue;
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTextBox.Font = new System.Drawing.Font("Lucida Fax", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(14, 262);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(220, 31);
            this.nameTextBox.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.timeLabel);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.player1Image);
            this.panel1.Controls.Add(this.IPTextBox);
            this.panel1.Controls.Add(this.connectButton);
            this.panel1.Controls.Add(this.ipLabel);
            this.panel1.Controls.Add(this.processBar);
            this.panel1.Controls.Add(this.playerLabel);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(588, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(525, 584);
            this.panel1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(190, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // player1Image
            // 
            this.player1Image.BackColor = System.Drawing.SystemColors.Control;
            this.player1Image.Cursor = System.Windows.Forms.Cursors.Hand;
            this.player1Image.Location = new System.Drawing.Point(258, 192);
            this.player1Image.Name = "player1Image";
            this.player1Image.Size = new System.Drawing.Size(204, 193);
            this.player1Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player1Image.TabIndex = 7;
            this.player1Image.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(525, 29);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.changeUIModeToolStripMenuItem,
            this.quitGameToolStripMenuItem});
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("Lucida Fax", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(74, 25);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(304, 26);
            this.newGameToolStripMenuItem.Text = "New game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // changeUIModeToolStripMenuItem
            // 
            this.changeUIModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lightToolStripMenuItem,
            this.darkToolStripMenuItem});
            this.changeUIModeToolStripMenuItem.Name = "changeUIModeToolStripMenuItem";
            this.changeUIModeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.changeUIModeToolStripMenuItem.Size = new System.Drawing.Size(304, 26);
            this.changeUIModeToolStripMenuItem.Text = "Change UI mode";
            this.changeUIModeToolStripMenuItem.Click += new System.EventHandler(this.changeUIModeToolStripMenuItem_Click);
            // 
            // lightToolStripMenuItem
            // 
            this.lightToolStripMenuItem.Name = "lightToolStripMenuItem";
            this.lightToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.lightToolStripMenuItem.Text = "Light";
            // 
            // darkToolStripMenuItem
            // 
            this.darkToolStripMenuItem.Name = "darkToolStripMenuItem";
            this.darkToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.darkToolStripMenuItem.Text = "Dark";
            // 
            // quitGameToolStripMenuItem
            // 
            this.quitGameToolStripMenuItem.Name = "quitGameToolStripMenuItem";
            this.quitGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.quitGameToolStripMenuItem.Size = new System.Drawing.Size(304, 26);
            this.quitGameToolStripMenuItem.Text = "Quit game";
            this.quitGameToolStripMenuItem.Click += new System.EventHandler(this.quitGameToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 13F);
            this.label2.Location = new System.Drawing.Point(717, 654);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Don\'t know how to play?";
            // 
            // clickhereLabel
            // 
            this.clickhereLabel.AutoSize = true;
            this.clickhereLabel.Font = new System.Drawing.Font("Lucida Fax", 13F);
            this.clickhereLabel.ForeColor = System.Drawing.Color.Blue;
            this.clickhereLabel.Location = new System.Drawing.Point(803, 684);
            this.clickhereLabel.Name = "clickhereLabel";
            this.clickhereLabel.Size = new System.Drawing.Size(128, 25);
            this.clickhereLabel.TabIndex = 18;
            this.clickhereLabel.Text = "Click here!";
            this.clickhereLabel.Click += new System.EventHandler(this.clickhereLabel_Click);
            // 
            // mute
            // 
            this.mute.Image = ((System.Drawing.Image)(resources.GetObject("mute.Image")));
            this.mute.Location = new System.Drawing.Point(868, 603);
            this.mute.Name = "mute";
            this.mute.Size = new System.Drawing.Size(44, 48);
            this.mute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mute.TabIndex = 16;
            this.mute.TabStop = false;
            this.mute.Click += new System.EventHandler(this.mute_Click);
            // 
            // unmute
            // 
            this.unmute.Image = ((System.Drawing.Image)(resources.GetObject("unmute.Image")));
            this.unmute.Location = new System.Drawing.Point(798, 603);
            this.unmute.Name = "unmute";
            this.unmute.Size = new System.Drawing.Size(44, 48);
            this.unmute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.unmute.TabIndex = 15;
            this.unmute.TabStop = false;
            this.unmute.Click += new System.EventHandler(this.unmute_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(792, 631);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 32);
            this.label3.TabIndex = 14;
            // 
            // player1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1119, 718);
            this.Controls.Add(this.clickhereLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mute);
            this.Controls.Add(this.unmute);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chessBoardPanel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Lucida Fax", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "player1Form";
            this.Text = "PLAYER1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.player1Form_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1Image)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unmute)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Panel chessBoardPanel;
        private Timer timerCountDown;
        private Label label1;
        private ProgressBar processBar;
        private Label timeLabel;
        private Button connectButton;
        private TextBox IPTextBox;
        private Label ipLabel;
        private Label playerLabel;
        private PictureBox player1Image;
        private TextBox nameTextBox;
        private Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem newGameToolStripMenuItem;
        private ToolStripMenuItem changeUIModeToolStripMenuItem;
        private ToolStripMenuItem quitGameToolStripMenuItem;
        private ToolStripMenuItem lightToolStripMenuItem;
        private PictureBox pictureBox1;
        private ToolStripMenuItem darkToolStripMenuItem;
        private Label label3;
        private PictureBox unmute;
        private PictureBox mute;
        private Label label2;
        private Label clickhereLabel;
    }
}
