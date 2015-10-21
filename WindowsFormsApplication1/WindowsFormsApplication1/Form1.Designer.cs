using System;
using System.Drawing;
using System.Threading;


namespace WindowsFormsApplication1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.missile = new System.Windows.Forms.PictureBox();
            this.FireButton = new System.Windows.Forms.Button();
            PowerBar = new System.Windows.Forms.TrackBar();
            PowerBarDisplay = new System.Windows.Forms.RichTextBox();
            playGround = new System.Windows.Forms.Panel();
            WinBox = new System.Windows.Forms.RichTextBox();
            this.Player2ScoreBox = new System.Windows.Forms.RichTextBox();
            this.Player1ScoreBox = new System.Windows.Forms.RichTextBox();
            this.MoveRightButton = new System.Windows.Forms.Button();
            this.MoveLeftButton = new System.Windows.Forms.Button();
            this.Angle = new System.Windows.Forms.RichTextBox();
            AngleBar = new System.Windows.Forms.TrackBar();
            this.missile2 = new System.Windows.Forms.PictureBox();
            this.Tank2 = new System.Windows.Forms.PictureBox();
            this.Tank1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.missile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(PowerBar)).BeginInit();
            playGround.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(AngleBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.missile2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tank2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tank1)).BeginInit();
            this.SuspendLayout();
            // 
            // missile
            // 
            this.missile.BackColor = System.Drawing.Color.Red;
            this.missile.Image = ((System.Drawing.Image)(resources.GetObject("missile.Image")));
            this.missile.Location = new System.Drawing.Point(141, 322);
            this.missile.Name = "missile";
            this.missile.Size = new System.Drawing.Size(18, 7);
            this.missile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.missile.TabIndex = 3;
            this.missile.TabStop = false;
            // 
            // FireButton
            // 
            this.FireButton.Location = new System.Drawing.Point(1007, 591);
            this.FireButton.Name = "FireButton";
            this.FireButton.Size = new System.Drawing.Size(160, 45);
            this.FireButton.TabIndex = 1;
            this.FireButton.Text = "Fire!";
            this.FireButton.UseVisualStyleBackColor = true;
            this.FireButton.Click += new System.EventHandler(this.FireButton_Click);
            // 
            // PowerBar
            // 
            PowerBar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            PowerBar.Cursor = System.Windows.Forms.Cursors.Hand;
            PowerBar.Location = new System.Drawing.Point(114, 593);
            PowerBar.Margin = new System.Windows.Forms.Padding(0);
            PowerBar.Maximum = 100;
            PowerBar.Name = "PowerBar";
            PowerBar.Size = new System.Drawing.Size(325, 45);
            PowerBar.TabIndex = 4;
            PowerBar.Tag = "Power Bar";
            PowerBar.Scroll += new System.EventHandler(PowerBar_Scroll);
            // 
            // PowerBarDisplay
            // 
            PowerBarDisplay.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            PowerBarDisplay.Location = new System.Drawing.Point(445, 593);
            PowerBarDisplay.Name = "PowerBarDisplay";
            PowerBarDisplay.Size = new System.Drawing.Size(100, 45);
            PowerBarDisplay.TabIndex = 5;
            PowerBarDisplay.Text = "";
            // 
            // playGround
            // 
            playGround.AutoSize = true;
            playGround.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            playGround.BackColor = System.Drawing.Color.DarkGray;
            playGround.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            playGround.Controls.Add(WinBox);
            playGround.Controls.Add(this.Player2ScoreBox);
            playGround.Controls.Add(this.Player1ScoreBox);
            playGround.Controls.Add(this.MoveRightButton);
            playGround.Controls.Add(this.MoveLeftButton);
            playGround.Controls.Add(this.FireButton);
            playGround.Controls.Add(this.Angle);
            playGround.Controls.Add(AngleBar);
            playGround.Controls.Add(this.missile2);
            playGround.Controls.Add(this.Tank2);
            playGround.Controls.Add(this.Tank1);
            playGround.Dock = System.Windows.Forms.DockStyle.Fill;
            playGround.Location = new System.Drawing.Point(0, 0);
            playGround.Name = "playGround";
            playGround.Size = new System.Drawing.Size(1426, 665);
            playGround.TabIndex = 0;
            // 
            // WinBox
            // 
            WinBox.BackColor = System.Drawing.Color.DarkGray;
            WinBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            WinBox.Font = new System.Drawing.Font("Impact", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            WinBox.ForeColor = System.Drawing.Color.Red;
            WinBox.Location = new System.Drawing.Point(438, 99);
            WinBox.Name = "WinBox";
            WinBox.Size = new System.Drawing.Size(612, 311);
            WinBox.TabIndex = 15;
            WinBox.Text = "";
            WinBox.Visible = false;
            // 
            // Player2ScoreBox
            // 
            this.Player2ScoreBox.Font = new System.Drawing.Font("Impact", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2ScoreBox.Location = new System.Drawing.Point(1312, 10);
            this.Player2ScoreBox.Name = "Player2ScoreBox";
            this.Player2ScoreBox.Size = new System.Drawing.Size(100, 96);
            this.Player2ScoreBox.TabIndex = 14;
            this.Player2ScoreBox.Text = "";
            // 
            // Player1ScoreBox
            // 
            this.Player1ScoreBox.Font = new System.Drawing.Font("Impact", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1ScoreBox.Location = new System.Drawing.Point(10, 10);
            this.Player1ScoreBox.Name = "Player1ScoreBox";
            this.Player1ScoreBox.Size = new System.Drawing.Size(100, 96);
            this.Player1ScoreBox.TabIndex = 13;
            this.Player1ScoreBox.Text = "";
            // 
            // MoveRightButton
            // 
            this.MoveRightButton.Location = new System.Drawing.Point(1294, 591);
            this.MoveRightButton.Name = "MoveRightButton";
            this.MoveRightButton.Size = new System.Drawing.Size(67, 45);
            this.MoveRightButton.TabIndex = 10;
            this.MoveRightButton.Text = "Move Right";
            this.MoveRightButton.UseVisualStyleBackColor = true;
            this.MoveRightButton.Click += new System.EventHandler(this.MoveRightButton_Click);
            // 
            // MoveLeftButton
            // 
            this.MoveLeftButton.Location = new System.Drawing.Point(1231, 591);
            this.MoveLeftButton.Name = "MoveLeftButton";
            this.MoveLeftButton.Size = new System.Drawing.Size(67, 45);
            this.MoveLeftButton.TabIndex = 9;
            this.MoveLeftButton.Text = "Move Left";
            this.MoveLeftButton.UseVisualStyleBackColor = true;
            this.MoveLeftButton.Click += new System.EventHandler(this.MoveLeftButton_Click);
            // 
            // Angle
            // 
            this.Angle.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Angle.Location = new System.Drawing.Point(857, 589);
            this.Angle.Name = "Angle";
            this.Angle.Size = new System.Drawing.Size(100, 47);
            this.Angle.TabIndex = 6;
            this.Angle.Text = "";
            // 
            // AngleBar
            // 
            AngleBar.BackColor = System.Drawing.Color.Black;
            AngleBar.Location = new System.Drawing.Point(590, 591);
            AngleBar.Maximum = 180;
            AngleBar.Name = "AngleBar";
            AngleBar.Size = new System.Drawing.Size(261, 45);
            AngleBar.TabIndex = 2;
            AngleBar.Scroll += new System.EventHandler(AngleBar_Scroll);
            // 
            // missile2
            // 
            this.missile2.BackColor = System.Drawing.Color.DodgerBlue;
            this.missile2.Image = ((System.Drawing.Image)(resources.GetObject("missile2.Image")));
            this.missile2.Location = new System.Drawing.Point(702, 327);
            this.missile2.Name = "missile2";
            this.missile2.Size = new System.Drawing.Size(18, 7);
            this.missile2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.missile2.TabIndex = 11;
            this.missile2.TabStop = false;
            // 
            // Tank2
            // 
            this.Tank2.Image = ((System.Drawing.Image)(resources.GetObject("Tank2.Image")));
            this.Tank2.Location = new System.Drawing.Point(1046, 336);
            this.Tank2.Name = "Tank2";
            this.Tank2.Size = new System.Drawing.Size(70, 40);
            this.Tank2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Tank2.TabIndex = 8;
            this.Tank2.TabStop = false;
            // 
            // Tank1
            // 
            this.Tank1.Image = ((System.Drawing.Image)(resources.GetObject("Tank1.Image")));
            this.Tank1.Location = new System.Drawing.Point(112, 400);
            this.Tank1.Name = "Tank1";
            this.Tank1.Size = new System.Drawing.Size(70, 40);
            this.Tank1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Tank1.TabIndex = 7;
            this.Tank1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1426, 665);
            this.Controls.Add(PowerBarDisplay);
            this.Controls.Add(PowerBar);
            this.Controls.Add(this.missile);
            this.Controls.Add(playGround);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.missile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(PowerBar)).EndInit();
            playGround.ResumeLayout(false);
            playGround.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(AngleBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.missile2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tank2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tank1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox missile;



        private System.Windows.Forms.Button FireButton;
        private System.Windows.Forms.RichTextBox PowerBarDisplay;
        private System.Windows.Forms.RichTextBox Angle;
        public System.Windows.Forms.PictureBox Tank1;
        private System.Windows.Forms.PictureBox Tank2;
        private System.Windows.Forms.Button MoveLeftButton;
        private System.Windows.Forms.Button MoveRightButton;
        private System.Windows.Forms.PictureBox missile2;
        private System.Windows.Forms.RichTextBox Player2ScoreBox;
        private System.Windows.Forms.RichTextBox Player1ScoreBox;
        private System.Windows.Forms.Timer timer1;
        public static System.Windows.Forms.TrackBar PowerBar;
        public static System.Windows.Forms.TrackBar AngleBar;
        public static System.Windows.Forms.Panel playGround;
        public static System.Windows.Forms.RichTextBox WinBox;

    }
}

