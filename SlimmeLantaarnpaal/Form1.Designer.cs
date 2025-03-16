namespace SlimmeLantaarnpaal
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
            lblLichtsterkte = new Label();
            btnMeetLicht = new Button();
            lblLantaarnpaal = new Label();
            pbLantaarnpaal = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbLantaarnpaal).BeginInit();
            SuspendLayout();
            // 
            // lblLichtsterkte
            // 
            lblLichtsterkte.AutoSize = true;
            lblLichtsterkte.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLichtsterkte.Location = new Point(35, 343);
            lblLichtsterkte.Name = "lblLichtsterkte";
            lblLichtsterkte.Size = new Size(156, 25);
            lblLichtsterkte.TabIndex = 0;
            lblLichtsterkte.Text = "Lichtsterkte: N/A";
            // 
            // btnMeetLicht
            // 
            btnMeetLicht.Location = new Point(40, 297);
            btnMeetLicht.Name = "btnMeetLicht";
            btnMeetLicht.Size = new Size(94, 29);
            btnMeetLicht.TabIndex = 1;
            btnMeetLicht.Text = "Meet licht";
            btnMeetLicht.UseVisualStyleBackColor = true;
            btnMeetLicht.Click += btnMeetLicht_Click;
            // 
            // lblLantaarnpaal
            // 
            lblLantaarnpaal.AutoSize = true;
            lblLantaarnpaal.Location = new Point(512, 343);
            lblLantaarnpaal.Name = "lblLantaarnpaal";
            lblLantaarnpaal.Size = new Size(139, 20);
            lblLantaarnpaal.TabIndex = 2;
            lblLantaarnpaal.Text = "Lantaarnpaal Status";
            // 
            // pbLantaarnpaal
            // 
            pbLantaarnpaal.Location = new Point(523, 168);
            pbLantaarnpaal.Name = "pbLantaarnpaal";
            pbLantaarnpaal.Size = new Size(228, 158);
            pbLantaarnpaal.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLantaarnpaal.TabIndex = 3;
            pbLantaarnpaal.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pbLantaarnpaal);
            Controls.Add(lblLantaarnpaal);
            Controls.Add(btnMeetLicht);
            Controls.Add(lblLichtsterkte);
            Name = "Form1";
            Text = "Slimme Lantaarnpaal";
            ((System.ComponentModel.ISupportInitialize)pbLantaarnpaal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLichtsterkte;
        private Button btnMeetLicht;
        private Label lblLantaarnpaal;
        private PictureBox pbLantaarnpaal;
    }
}
