namespace FlappyBird
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
            this.pipeDown = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.pipeUp = new System.Windows.Forms.PictureBox();
            this.bird = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.l3 = new System.Windows.Forms.PictureBox();
            this.l2 = new System.Windows.Forms.PictureBox();
            this.l1 = new System.Windows.Forms.PictureBox();
            this.score = new System.Windows.Forms.Label();
            this.Game_timer = new System.Windows.Forms.Timer(this.components);
            this.gameOver = new System.Windows.Forms.Label();
            this.exLife = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.l3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.l2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.l1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exLife)).BeginInit();
            this.SuspendLayout();
            // 
            // pipeDown
            // 
            this.pipeDown.Image = global::FlappyBird.Properties.Resources.images_removebg_preview2;
            this.pipeDown.Location = new System.Drawing.Point(325, -80);
            this.pipeDown.Name = "pipeDown";
            this.pipeDown.Size = new System.Drawing.Size(66, 185);
            this.pipeDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeDown.TabIndex = 3;
            this.pipeDown.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = global::FlappyBird.Properties.Resources.background1;
            this.ground.Location = new System.Drawing.Point(-14, 315);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(644, 96);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 2;
            this.ground.TabStop = false;
            // 
            // pipeUp
            // 
            this.pipeUp.Image = global::FlappyBird.Properties.Resources.images_removebg_preview1;
            this.pipeUp.Location = new System.Drawing.Point(491, 209);
            this.pipeUp.Name = "pipeUp";
            this.pipeUp.Size = new System.Drawing.Size(67, 265);
            this.pipeUp.TabIndex = 1;
            this.pipeUp.TabStop = false;
            // 
            // bird
            // 
            this.bird.Image = global::FlappyBird.Properties.Resources.bird_removebg_preview;
            this.bird.Location = new System.Drawing.Point(67, 87);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(78, 52);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird.TabIndex = 0;
            this.bird.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel1.Controls.Add(this.l3);
            this.panel1.Controls.Add(this.l2);
            this.panel1.Controls.Add(this.l1);
            this.panel1.Location = new System.Drawing.Point(20, 337);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(158, 53);
            this.panel1.TabIndex = 4;
            // 
            // l3
            // 
            this.l3.Image = global::FlappyBird.Properties.Resources.heart_removebg_preview;
            this.l3.Location = new System.Drawing.Point(96, 7);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(59, 42);
            this.l3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.l3.TabIndex = 2;
            this.l3.TabStop = false;
            // 
            // l2
            // 
            this.l2.Image = global::FlappyBird.Properties.Resources.heart_removebg_preview;
            this.l2.Location = new System.Drawing.Point(47, 7);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(59, 42);
            this.l2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.l2.TabIndex = 1;
            this.l2.TabStop = false;
            // 
            // l1
            // 
            this.l1.Image = global::FlappyBird.Properties.Resources.heart_removebg_preview;
            this.l1.Location = new System.Drawing.Point(0, 7);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(59, 42);
            this.l1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.l1.TabIndex = 0;
            this.l1.TabStop = false;
            // 
            // score
            // 
            this.score.Font = new System.Drawing.Font("Broadway", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.Location = new System.Drawing.Point(400, 344);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(172, 42);
            this.score.TabIndex = 5;
            this.score.Text = "Score :";
            this.score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Game_timer
            // 
            this.Game_timer.Enabled = true;
            this.Game_timer.Interval = 20;
            this.Game_timer.Tick += new System.EventHandler(this.Game_timer_tick_event);
            // 
            // gameOver
            // 
            this.gameOver.Font = new System.Drawing.Font("MV Boli", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOver.Location = new System.Drawing.Point(128, 129);
            this.gameOver.Name = "gameOver";
            this.gameOver.Size = new System.Drawing.Size(363, 111);
            this.gameOver.TabIndex = 6;
            this.gameOver.Text = "label1";
            this.gameOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gameOver.Visible = false;
            // 
            // exLife
            // 
            this.exLife.Image = global::FlappyBird.Properties.Resources.heart_removebg_preview;
            this.exLife.Location = new System.Drawing.Point(175, 129);
            this.exLife.Name = "exLife";
            this.exLife.Size = new System.Drawing.Size(59, 42);
            this.exLife.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exLife.TabIndex = 2;
            this.exLife.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(617, 411);
            this.Controls.Add(this.exLife);
            this.Controls.Add(this.gameOver);
            this.Controls.Add(this.score);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pipeDown);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipeUp);
            this.Controls.Add(this.bird);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flappy Bird";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownEvent);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyUpEvent);
            ((System.ComponentModel.ISupportInitialize)(this.pipeDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.l3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.l2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.l1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exLife)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.PictureBox pipeUp;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox pipeDown;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox l1;
        private System.Windows.Forms.PictureBox l3;
        private System.Windows.Forms.PictureBox l2;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Timer Game_timer;
        private System.Windows.Forms.Label gameOver;
        private System.Windows.Forms.PictureBox exLife;
    }
}

