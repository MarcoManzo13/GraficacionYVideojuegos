namespace PacManGame
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PacMan = new System.Windows.Forms.PictureBox();
            this.XPosition = new System.Windows.Forms.Label();
            this.YPosition = new System.Windows.Forms.Label();
            this.CoinsLabel = new System.Windows.Forms.Label();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.Enemywuan = new System.Windows.Forms.PictureBox();
            this.EnemyTwo = new System.Windows.Forms.PictureBox();
            this.EnemyThree = new System.Windows.Forms.PictureBox();
            this.EnemyCuatro = new System.Windows.Forms.PictureBox();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.Ghost1Label = new System.Windows.Forms.Label();
            this.Ghost2Label = new System.Windows.Forms.Label();
            this.Ghost3Label = new System.Windows.Forms.Label();
            this.Ghost4Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PacMan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemywuan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyCuatro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(750, 750);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PacMan
            // 
            this.PacMan.BackColor = System.Drawing.Color.Transparent;
            this.PacMan.Location = new System.Drawing.Point(360, 510);
            this.PacMan.Name = "PacMan";
            this.PacMan.Size = new System.Drawing.Size(25, 25);
            this.PacMan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PacMan.TabIndex = 1;
            this.PacMan.TabStop = false;
            // 
            // XPosition
            // 
            this.XPosition.AutoSize = true;
            this.XPosition.BackColor = System.Drawing.Color.White;
            this.XPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.XPosition.Location = new System.Drawing.Point(755, 153);
            this.XPosition.Name = "XPosition";
            this.XPosition.Size = new System.Drawing.Size(81, 29);
            this.XPosition.TabIndex = 2;
            this.XPosition.Text = "label1";
            // 
            // YPosition
            // 
            this.YPosition.AutoSize = true;
            this.YPosition.BackColor = System.Drawing.Color.White;
            this.YPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.YPosition.Location = new System.Drawing.Point(755, 208);
            this.YPosition.Name = "YPosition";
            this.YPosition.Size = new System.Drawing.Size(81, 29);
            this.YPosition.TabIndex = 3;
            this.YPosition.Text = "label1";
            // 
            // CoinsLabel
            // 
            this.CoinsLabel.AutoSize = true;
            this.CoinsLabel.BackColor = System.Drawing.Color.White;
            this.CoinsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.CoinsLabel.Location = new System.Drawing.Point(755, 261);
            this.CoinsLabel.Name = "CoinsLabel";
            this.CoinsLabel.Size = new System.Drawing.Size(81, 29);
            this.CoinsLabel.TabIndex = 4;
            this.CoinsLabel.Text = "label1";
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.BackColor = System.Drawing.Color.White;
            this.ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ScoreLabel.Location = new System.Drawing.Point(755, 308);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(81, 29);
            this.ScoreLabel.TabIndex = 5;
            this.ScoreLabel.Text = "label1";
            // 
            // Enemywuan
            // 
            this.Enemywuan.BackColor = System.Drawing.Color.Transparent;
            this.Enemywuan.Location = new System.Drawing.Point(222, 510);
            this.Enemywuan.Name = "Enemywuan";
            this.Enemywuan.Size = new System.Drawing.Size(25, 25);
            this.Enemywuan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Enemywuan.TabIndex = 6;
            this.Enemywuan.TabStop = false;
            // 
            // EnemyTwo
            // 
            this.EnemyTwo.BackColor = System.Drawing.Color.Transparent;
            this.EnemyTwo.Location = new System.Drawing.Point(545, 510);
            this.EnemyTwo.Name = "EnemyTwo";
            this.EnemyTwo.Size = new System.Drawing.Size(25, 25);
            this.EnemyTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EnemyTwo.TabIndex = 7;
            this.EnemyTwo.TabStop = false;
            // 
            // EnemyThree
            // 
            this.EnemyThree.BackColor = System.Drawing.Color.Transparent;
            this.EnemyThree.Location = new System.Drawing.Point(540, 120);
            this.EnemyThree.Name = "EnemyThree";
            this.EnemyThree.Size = new System.Drawing.Size(25, 25);
            this.EnemyThree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EnemyThree.TabIndex = 8;
            this.EnemyThree.TabStop = false;
            // 
            // EnemyCuatro
            // 
            this.EnemyCuatro.BackColor = System.Drawing.Color.Transparent;
            this.EnemyCuatro.Location = new System.Drawing.Point(180, 153);
            this.EnemyCuatro.Name = "EnemyCuatro";
            this.EnemyCuatro.Size = new System.Drawing.Size(25, 25);
            this.EnemyCuatro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EnemyCuatro.TabIndex = 9;
            this.EnemyCuatro.TabStop = false;
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Location = new System.Drawing.Point(787, 22);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(474, 110);
            this.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPictureBox.TabIndex = 11;
            this.LogoPictureBox.TabStop = false;
            // 
            // Ghost1Label
            // 
            this.Ghost1Label.AutoSize = true;
            this.Ghost1Label.BackColor = System.Drawing.Color.Black;
            this.Ghost1Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Ghost1Label.Font = new System.Drawing.Font("Ravie", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ghost1Label.ForeColor = System.Drawing.SystemColors.Control;
            this.Ghost1Label.Location = new System.Drawing.Point(12, 825);
            this.Ghost1Label.Name = "Ghost1Label";
            this.Ghost1Label.Size = new System.Drawing.Size(304, 37);
            this.Ghost1Label.TabIndex = 12;
            this.Ghost1Label.Text = "Ghost\'s Dialogue";
            this.Ghost1Label.Click += new System.EventHandler(this.label1_Click);
            // 
            // Ghost2Label
            // 
            this.Ghost2Label.AutoSize = true;
            this.Ghost2Label.BackColor = System.Drawing.Color.White;
            this.Ghost2Label.Font = new System.Drawing.Font("Ravie", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Ghost2Label.Location = new System.Drawing.Point(12, 813);
            this.Ghost2Label.Name = "Ghost2Label";
            this.Ghost2Label.Size = new System.Drawing.Size(0, 35);
            this.Ghost2Label.TabIndex = 13;
            // 
            // Ghost3Label
            // 
            this.Ghost3Label.AutoSize = true;
            this.Ghost3Label.BackColor = System.Drawing.Color.White;
            this.Ghost3Label.Font = new System.Drawing.Font("Ravie", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Ghost3Label.Location = new System.Drawing.Point(12, 862);
            this.Ghost3Label.Name = "Ghost3Label";
            this.Ghost3Label.Size = new System.Drawing.Size(0, 35);
            this.Ghost3Label.TabIndex = 14;
            // 
            // Ghost4Label
            // 
            this.Ghost4Label.AutoSize = true;
            this.Ghost4Label.BackColor = System.Drawing.Color.White;
            this.Ghost4Label.Font = new System.Drawing.Font("Ravie", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Ghost4Label.Location = new System.Drawing.Point(12, 913);
            this.Ghost4Label.Name = "Ghost4Label";
            this.Ghost4Label.Size = new System.Drawing.Size(0, 35);
            this.Ghost4Label.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1347, 953);
            this.Controls.Add(this.Ghost4Label);
            this.Controls.Add(this.Ghost3Label);
            this.Controls.Add(this.Ghost2Label);
            this.Controls.Add(this.Ghost1Label);
            this.Controls.Add(this.LogoPictureBox);
            this.Controls.Add(this.EnemyCuatro);
            this.Controls.Add(this.EnemyThree);
            this.Controls.Add(this.EnemyTwo);
            this.Controls.Add(this.Enemywuan);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.CoinsLabel);
            this.Controls.Add(this.YPosition);
            this.Controls.Add(this.XPosition);
            this.Controls.Add(this.PacMan);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PacMan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemywuan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyCuatro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox PacMan;
        private System.Windows.Forms.Label XPosition;
        private System.Windows.Forms.Label YPosition;
        private System.Windows.Forms.Label CoinsLabel;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.PictureBox Enemywuan;
        private System.Windows.Forms.PictureBox EnemyTwo;
        private System.Windows.Forms.PictureBox EnemyThree;
        private System.Windows.Forms.PictureBox EnemyCuatro;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.Label Ghost1Label;
        private System.Windows.Forms.Label Ghost2Label;
        private System.Windows.Forms.Label Ghost3Label;
        private System.Windows.Forms.Label Ghost4Label;
    }
}

