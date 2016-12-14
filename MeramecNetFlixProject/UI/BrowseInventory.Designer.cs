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
            this.lblMovDescription = new System.Windows.Forms.Label();
            this.pnlDescription = new System.Windows.Forms.Panel();
            this.btnSimilarTitles = new System.Windows.Forms.Button();
            this.btnOrderMovie = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlDescription.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMovDescription
            // 
            this.lblMovDescription.AutoSize = true;
            this.lblMovDescription.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMovDescription.Location = new System.Drawing.Point(16, 10);
            this.lblMovDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMovDescription.Name = "lblMovDescription";
            this.lblMovDescription.Size = new System.Drawing.Size(0, 17);
            this.lblMovDescription.TabIndex = 2;
            // 
            // pnlDescription
            // 
            this.pnlDescription.BackColor = System.Drawing.Color.Transparent;
            this.pnlDescription.Controls.Add(this.btnSimilarTitles);
            this.pnlDescription.Controls.Add(this.btnOrderMovie);
            this.pnlDescription.Controls.Add(this.lblMovDescription);
            this.pnlDescription.Location = new System.Drawing.Point(575, 1);
            this.pnlDescription.Margin = new System.Windows.Forms.Padding(4);
            this.pnlDescription.Name = "pnlDescription";
            this.pnlDescription.Size = new System.Drawing.Size(624, 206);
            this.pnlDescription.TabIndex = 3;
            // 
            // btnSimilarTitles
            // 
            this.btnSimilarTitles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSimilarTitles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSimilarTitles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimilarTitles.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSimilarTitles.Location = new System.Drawing.Point(20, 174);
            this.btnSimilarTitles.Margin = new System.Windows.Forms.Padding(4);
            this.btnSimilarTitles.Name = "btnSimilarTitles";
            this.btnSimilarTitles.Size = new System.Drawing.Size(128, 28);
            this.btnSimilarTitles.TabIndex = 4;
            this.btnSimilarTitles.Text = "Similar Titles";
            this.btnSimilarTitles.UseVisualStyleBackColor = false;
            this.btnSimilarTitles.Visible = false;
            // 
            // btnOrderMovie
            // 
            this.btnOrderMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOrderMovie.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOrderMovie.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOrderMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderMovie.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnOrderMovie.Location = new System.Drawing.Point(477, 174);
            this.btnOrderMovie.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrderMovie.Name = "btnOrderMovie";
            this.btnOrderMovie.Size = new System.Drawing.Size(135, 28);
            this.btnOrderMovie.TabIndex = 3;
            this.btnOrderMovie.Text = "Order Movie!";
            this.btnOrderMovie.UseVisualStyleBackColor = false;
            this.btnOrderMovie.Visible = false;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(575, 214);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(4);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(27, 25);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(624, 479);
            this.webBrowser1.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(556, 671);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // BrowseInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::MeramecNetFlixProject.Properties.Resources._9;
            this.ClientSize = new System.Drawing.Size(1203, 695);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.pnlDescription);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BrowseInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meramec On-Line Movie Kiosk Rental form";
            this.pnlDescription.ResumeLayout(false);
            this.pnlDescription.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblMovDescription;
        private System.Windows.Forms.Panel pnlDescription;
        private System.Windows.Forms.Button btnSimilarTitles;
        private System.Windows.Forms.Button btnOrderMovie;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;  
    }
}