 namespace FlappyBird
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            flappyBird = new PictureBox();
            pipeTop = new PictureBox();
            pipeBottom = new PictureBox();
            ground = new PictureBox();
            scoreText = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)flappyBird).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeTop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeBottom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ground).BeginInit();
            SuspendLayout();
            // 
            // flappyBird
            // 
            flappyBird.Image = Properties.Resources.yellowbird_midflap;
            flappyBird.Location = new Point(62, 148);
            flappyBird.Name = "flappyBird";
            flappyBird.Size = new Size(65, 54);
            flappyBird.SizeMode = PictureBoxSizeMode.StretchImage;
            flappyBird.TabIndex = 0;
            flappyBird.TabStop = false;
            flappyBird.Click += pictureBox1_Click;
            // 
            // pipeTop
            // 
            pipeTop.Image = Properties.Resources.Adsız_tasarım;
            pipeTop.Location = new Point(488, -183);
            pipeTop.Name = "pipeTop";
            pipeTop.Size = new Size(116, 361);
            pipeTop.SizeMode = PictureBoxSizeMode.StretchImage;
            pipeTop.TabIndex = 1;
            pipeTop.TabStop = false;
            // 
            // pipeBottom
            // 
            pipeBottom.Image = Properties.Resources.pipe_green;
            pipeBottom.Location = new Point(488, 347);
            pipeBottom.Name = "pipeBottom";
            pipeBottom.Size = new Size(116, 486);
            pipeBottom.SizeMode = PictureBoxSizeMode.StretchImage;
            pipeBottom.TabIndex = 2;
            pipeBottom.TabStop = false;
            // 
            // ground
            // 
            ground.Image = Properties.Resources._base;
            ground.Location = new Point(-5, 561);
            ground.Name = "ground";
            ground.Size = new Size(700, 257);
            ground.SizeMode = PictureBoxSizeMode.StretchImage;
            ground.TabIndex = 3;
            ground.TabStop = false;
            // 
            // scoreText
            // 
            scoreText.AutoSize = true;
            scoreText.BackColor = Color.FromArgb(128, 255, 255);
            scoreText.Font = new Font("Verdana", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            scoreText.ForeColor = SystemColors.ControlText;
            scoreText.Location = new Point(12, 658);
            scoreText.Name = "scoreText";
            scoreText.Size = new Size(204, 48);
            scoreText.TabIndex = 4;
            scoreText.Text = "Score: 0";
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 20;
            gameTimer.Tick += gameTimerEvent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            ClientSize = new Size(689, 715);
            Controls.Add(scoreText);
            Controls.Add(ground);
            Controls.Add(pipeBottom);
            Controls.Add(pipeTop);
            Controls.Add(flappyBird);
            Name = "Form1";
            Text = "Flappy Bird";
            Load += Form1_Load;
            KeyDown += gamekeyisdown;
            KeyUp += gamekeyisup;
            ((System.ComponentModel.ISupportInitialize)flappyBird).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeTop).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeBottom).EndInit();
            ((System.ComponentModel.ISupportInitialize)ground).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox flappyBird;
        private PictureBox pipeTop;
        private PictureBox pipeBottom;
        private PictureBox ground;
        private Label scoreText;
        private System.Windows.Forms.Timer gameTimer;
    }
}
