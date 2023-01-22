namespace InstalacionDeEntorno
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.Button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(22, 57);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(293, 77);
            this.textBox1.TabIndex = 0;
            this.textBox1.Tag = "Información";
            this.textBox1.Text = "Nombre: Marco Antonio Manzo Ruiz\r\nID: 173127\r\nMateria: Graficación y Videojuegos\r" +
    "\n";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(22, 155);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(293, 22);
            this.TextBox.TabIndex = 1;
            this.TextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(22, 197);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(293, 98);
            this.Button1.TabIndex = 2;
            this.Button1.Text = "Botón";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // PictureBox
            // 
            this.PictureBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox.ErrorImage = null;
            this.PictureBox.InitialImage = null;
            this.PictureBox.Location = new System.Drawing.Point(389, 57);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(362, 332);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox.TabIndex = 3;
            this.PictureBox.TabStop = false;
            this.PictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(22, 301);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(293, 103);
            this.Button2.TabIndex = 4;
            this.Button2.Text = "Botón 2";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Button Button2;
    }
}

