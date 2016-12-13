namespace MeramecNetFlixProject.UI
{
    partial class SignInScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignInScreen));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manageAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browseInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMemberSignIn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnUpdateGenre = new System.Windows.Forms.Button();
            this.btnUpdateMovies = new System.Windows.Forms.Button();
            this.createWatchListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Enabled = false;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageAccountToolStripMenuItem,
            this.createWatchListToolStripMenuItem,
            this.browseInventoryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(449, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manageAccountToolStripMenuItem
            // 
            this.manageAccountToolStripMenuItem.Name = "manageAccountToolStripMenuItem";
            this.manageAccountToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.manageAccountToolStripMenuItem.Text = "Manage Account";
            this.manageAccountToolStripMenuItem.Click += new System.EventHandler(this.manageAccountToolStripMenuItem_Click);
            // 
            // browseInventoryToolStripMenuItem
            // 
            this.browseInventoryToolStripMenuItem.Name = "browseInventoryToolStripMenuItem";
            this.browseInventoryToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.browseInventoryToolStripMenuItem.Text = "Browse Inventory";
            this.browseInventoryToolStripMenuItem.Click += new System.EventHandler(this.browseInventoryToolStripMenuItem_Click);
            // 
            // btnMemberSignIn
            // 
            this.btnMemberSignIn.BackColor = System.Drawing.Color.Silver;
            this.btnMemberSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemberSignIn.ForeColor = System.Drawing.Color.Red;
            this.btnMemberSignIn.Location = new System.Drawing.Point(64, 55);
            this.btnMemberSignIn.Margin = new System.Windows.Forms.Padding(2);
            this.btnMemberSignIn.Name = "btnMemberSignIn";
            this.btnMemberSignIn.Size = new System.Drawing.Size(319, 55);
            this.btnMemberSignIn.TabIndex = 1;
            this.btnMemberSignIn.Text = "Sign In";
            this.btnMemberSignIn.UseVisualStyleBackColor = false;
            this.btnMemberSignIn.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(64, 114);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(319, 247);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnUpdateGenre
            // 
            this.btnUpdateGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateGenre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdateGenre.Location = new System.Drawing.Point(64, 380);
            this.btnUpdateGenre.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateGenre.Name = "btnUpdateGenre";
            this.btnUpdateGenre.Size = new System.Drawing.Size(101, 25);
            this.btnUpdateGenre.TabIndex = 3;
            this.btnUpdateGenre.Text = "Update Genre";
            this.btnUpdateGenre.UseVisualStyleBackColor = true;
            this.btnUpdateGenre.Visible = false;
            this.btnUpdateGenre.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnUpdateMovies
            // 
            this.btnUpdateMovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateMovies.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdateMovies.Location = new System.Drawing.Point(282, 380);
            this.btnUpdateMovies.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateMovies.Name = "btnUpdateMovies";
            this.btnUpdateMovies.Size = new System.Drawing.Size(101, 25);
            this.btnUpdateMovies.TabIndex = 3;
            this.btnUpdateMovies.Text = "Update Movies";
            this.btnUpdateMovies.UseVisualStyleBackColor = true;
            this.btnUpdateMovies.Visible = false;
            this.btnUpdateMovies.Click += new System.EventHandler(this.btnUpdateMovies_Click);
            // 
            // createWatchListToolStripMenuItem
            // 
            this.createWatchListToolStripMenuItem.Name = "createWatchListToolStripMenuItem";
            this.createWatchListToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.createWatchListToolStripMenuItem.Text = "Favorites";
            this.createWatchListToolStripMenuItem.Click += new System.EventHandler(this.createWatchListToolStripMenuItem_Click);
            // 
            // SignInScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(449, 437);
            this.Controls.Add(this.btnUpdateMovies);
            this.Controls.Add(this.btnUpdateGenre);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnMemberSignIn);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "SignInScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meramec On-Line Kiosk Movie Rental System";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem browseInventoryToolStripMenuItem;
        private System.Windows.Forms.Button btnMemberSignIn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnUpdateGenre;
        private System.Windows.Forms.Button btnUpdateMovies;
        private System.Windows.Forms.ToolStripMenuItem createWatchListToolStripMenuItem;
    }
}