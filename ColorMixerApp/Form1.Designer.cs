namespace ColorMixerApp
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
            this.RedBox = new System.Windows.Forms.PictureBox();
            this.GreenBox = new System.Windows.Forms.PictureBox();
            this.BlueBox = new System.Windows.Forms.PictureBox();
            this.RandomRed = new System.Windows.Forms.Button();
            this.RandomGreen = new System.Windows.Forms.Button();
            this.RandomBlue = new System.Windows.Forms.Button();
            this.RandomAll = new System.Windows.Forms.Button();
            this.RedSlider = new System.Windows.Forms.TrackBar();
            this.BlueSlider = new System.Windows.Forms.TrackBar();
            this.GreenSlider = new System.Windows.Forms.TrackBar();
            this.HexNumber = new System.Windows.Forms.Label();
            this.RedLabel = new System.Windows.Forms.Label();
            this.GreenLabel = new System.Windows.Forms.Label();
            this.BlueLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RedBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // RedBox
            // 
            this.RedBox.Location = new System.Drawing.Point(15, 12);
            this.RedBox.Name = "RedBox";
            this.RedBox.Size = new System.Drawing.Size(200, 200);
            this.RedBox.TabIndex = 0;
            this.RedBox.TabStop = false;
            // 
            // GreenBox
            // 
            this.GreenBox.Location = new System.Drawing.Point(221, 12);
            this.GreenBox.Name = "GreenBox";
            this.GreenBox.Size = new System.Drawing.Size(200, 200);
            this.GreenBox.TabIndex = 1;
            this.GreenBox.TabStop = false;
            // 
            // BlueBox
            // 
            this.BlueBox.Location = new System.Drawing.Point(427, 12);
            this.BlueBox.Name = "BlueBox";
            this.BlueBox.Size = new System.Drawing.Size(200, 200);
            this.BlueBox.TabIndex = 2;
            this.BlueBox.TabStop = false;
            // 
            // RandomRed
            // 
            this.RandomRed.Location = new System.Drawing.Point(15, 218);
            this.RandomRed.Name = "RandomRed";
            this.RandomRed.Size = new System.Drawing.Size(200, 40);
            this.RandomRed.TabIndex = 3;
            this.RandomRed.Text = "Random Red Value";
            this.RandomRed.UseVisualStyleBackColor = true;
            this.RandomRed.Click += new System.EventHandler(this.RandomRed_Click);
            // 
            // RandomGreen
            // 
            this.RandomGreen.Location = new System.Drawing.Point(221, 218);
            this.RandomGreen.Name = "RandomGreen";
            this.RandomGreen.Size = new System.Drawing.Size(200, 40);
            this.RandomGreen.TabIndex = 4;
            this.RandomGreen.Text = "Random Green Value";
            this.RandomGreen.UseVisualStyleBackColor = true;
            this.RandomGreen.Click += new System.EventHandler(this.RandomGreen_Click);
            // 
            // RandomBlue
            // 
            this.RandomBlue.Location = new System.Drawing.Point(427, 218);
            this.RandomBlue.Name = "RandomBlue";
            this.RandomBlue.Size = new System.Drawing.Size(200, 40);
            this.RandomBlue.TabIndex = 5;
            this.RandomBlue.Text = "Random Blue Value";
            this.RandomBlue.UseVisualStyleBackColor = true;
            this.RandomBlue.Click += new System.EventHandler(this.RandomBlue_Click);
            // 
            // RandomAll
            // 
            this.RandomAll.Location = new System.Drawing.Point(15, 264);
            this.RandomAll.Name = "RandomAll";
            this.RandomAll.Size = new System.Drawing.Size(612, 40);
            this.RandomAll.TabIndex = 6;
            this.RandomAll.Text = "Random All Values";
            this.RandomAll.UseVisualStyleBackColor = true;
            this.RandomAll.Click += new System.EventHandler(this.RandomAll_Click);
            // 
            // RedSlider
            // 
            this.RedSlider.BackColor = System.Drawing.Color.White;
            this.RedSlider.Location = new System.Drawing.Point(15, 323);
            this.RedSlider.Maximum = 255;
            this.RedSlider.Name = "RedSlider";
            this.RedSlider.Size = new System.Drawing.Size(612, 45);
            this.RedSlider.TabIndex = 13;
            this.RedSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.RedSlider.Scroll += new System.EventHandler(this.RedSlider_Scroll);
            // 
            // BlueSlider
            // 
            this.BlueSlider.BackColor = System.Drawing.Color.White;
            this.BlueSlider.Location = new System.Drawing.Point(15, 451);
            this.BlueSlider.Maximum = 255;
            this.BlueSlider.Name = "BlueSlider";
            this.BlueSlider.Size = new System.Drawing.Size(612, 45);
            this.BlueSlider.TabIndex = 14;
            this.BlueSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.BlueSlider.Scroll += new System.EventHandler(this.BlueSlider_Scroll);
            // 
            // GreenSlider
            // 
            this.GreenSlider.BackColor = System.Drawing.Color.White;
            this.GreenSlider.Location = new System.Drawing.Point(15, 387);
            this.GreenSlider.Maximum = 255;
            this.GreenSlider.Name = "GreenSlider";
            this.GreenSlider.Size = new System.Drawing.Size(612, 45);
            this.GreenSlider.TabIndex = 15;
            this.GreenSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.GreenSlider.Scroll += new System.EventHandler(this.GreenSlider_Scroll);
            // 
            // HexNumber
            // 
            this.HexNumber.AutoSize = true;
            this.HexNumber.BackColor = System.Drawing.Color.White;
            this.HexNumber.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HexNumber.ForeColor = System.Drawing.SystemColors.ControlText;
            this.HexNumber.Location = new System.Drawing.Point(12, 520);
            this.HexNumber.Name = "HexNumber";
            this.HexNumber.Size = new System.Drawing.Size(117, 27);
            this.HexNumber.TabIndex = 20;
            this.HexNumber.Text = "Hex Value:";
            // 
            // RedLabel
            // 
            this.RedLabel.AutoSize = true;
            this.RedLabel.BackColor = System.Drawing.Color.White;
            this.RedLabel.Location = new System.Drawing.Point(305, 307);
            this.RedLabel.Name = "RedLabel";
            this.RedLabel.Size = new System.Drawing.Size(27, 13);
            this.RedLabel.TabIndex = 21;
            this.RedLabel.Text = "Red";
            // 
            // GreenLabel
            // 
            this.GreenLabel.AutoSize = true;
            this.GreenLabel.BackColor = System.Drawing.Color.White;
            this.GreenLabel.Location = new System.Drawing.Point(305, 371);
            this.GreenLabel.Name = "GreenLabel";
            this.GreenLabel.Size = new System.Drawing.Size(36, 13);
            this.GreenLabel.TabIndex = 22;
            this.GreenLabel.Text = "Green";
            // 
            // BlueLabel
            // 
            this.BlueLabel.AutoSize = true;
            this.BlueLabel.BackColor = System.Drawing.Color.White;
            this.BlueLabel.Location = new System.Drawing.Point(305, 435);
            this.BlueLabel.Name = "BlueLabel";
            this.BlueLabel.Size = new System.Drawing.Size(28, 13);
            this.BlueLabel.TabIndex = 23;
            this.BlueLabel.Text = "Blue";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 556);
            this.Controls.Add(this.BlueLabel);
            this.Controls.Add(this.GreenLabel);
            this.Controls.Add(this.RedLabel);
            this.Controls.Add(this.HexNumber);
            this.Controls.Add(this.GreenSlider);
            this.Controls.Add(this.BlueSlider);
            this.Controls.Add(this.RedSlider);
            this.Controls.Add(this.RandomAll);
            this.Controls.Add(this.RandomBlue);
            this.Controls.Add(this.RandomGreen);
            this.Controls.Add(this.RandomRed);
            this.Controls.Add(this.BlueBox);
            this.Controls.Add(this.GreenBox);
            this.Controls.Add(this.RedBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.RedBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox RedBox;
        private System.Windows.Forms.PictureBox GreenBox;
        private System.Windows.Forms.PictureBox BlueBox;
        private System.Windows.Forms.Button RandomRed;
        private System.Windows.Forms.Button RandomGreen;
        private System.Windows.Forms.Button RandomBlue;
        private System.Windows.Forms.Button RandomAll;
        private System.Windows.Forms.TrackBar RedSlider;
        private System.Windows.Forms.TrackBar BlueSlider;
        private System.Windows.Forms.TrackBar GreenSlider;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label HexNumber;
        private System.Windows.Forms.Label RedLabel;
        private System.Windows.Forms.Label GreenLabel;
        private System.Windows.Forms.Label BlueLabel;
    }
}

