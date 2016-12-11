namespace MeramecNetFlixProject.UI
{
    partial class BrowseInventory
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlMovieScroller = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlMovieScroller.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(11, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 128);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlMovieScroller
            // 
            this.pnlMovieScroller.Controls.Add(this.label1);
            this.pnlMovieScroller.Controls.Add(this.pictureBox1);
            this.pnlMovieScroller.Location = new System.Drawing.Point(1, 1);
            this.pnlMovieScroller.Name = "pnlMovieScroller";
            this.pnlMovieScroller.Size = new System.Drawing.Size(381, 562);
            this.pnlMovieScroller.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(11, 489);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 148);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1sdagkjhfd;glkajfdg\r\nasfdkgjhafldkgjhadfg\r\nalskdjfbglakjfhdgaklj\r\nasfdgadfg";
            // 
            // BrowseInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(902, 565);
            this.Controls.Add(this.pnlMovieScroller);
            this.Name = "BrowseInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meramec On-Line Movie Kiosk Rental form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlMovieScroller.ResumeLayout(false);
            this.pnlMovieScroller.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlMovieScroller;
        private System.Windows.Forms.Label label1;
    }
}