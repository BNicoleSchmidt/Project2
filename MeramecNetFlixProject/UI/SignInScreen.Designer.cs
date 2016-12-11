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
            this.createWatchListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browseInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderMovieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMemberSignIn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAdminSignIn = new System.Windows.Forms.Button();
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
            this.browseInventoryToolStripMenuItem,
            this.orderMovieToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(756, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manageAccountToolStripMenuItem
            // 
            this.manageAccountToolStripMenuItem.Name = "manageAccountToolStripMenuItem";
            this.manageAccountToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.manageAccountToolStripMenuItem.Text = "Manage Account";
            // 
            // createWatchListToolStripMenuItem
            // 
            this.createWatchListToolStripMenuItem.Name = "createWatchListToolStripMenuItem";
            this.createWatchListToolStripMenuItem.Size = new System.Drawing.Size(135, 24);
            this.createWatchListToolStripMenuItem.Text = "Create Watch List";
            // 
            // browseInventoryToolStripMenuItem
            // 
            this.browseInventoryToolStripMenuItem.Name = "browseInventoryToolStripMenuItem";
            this.browseInventoryToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.browseInventoryToolStripMenuItem.Text = "Browse Inventory";
            this.browseInventoryToolStripMenuItem.Click += new System.EventHandler(this.browseInventoryToolStripMenuItem_Click);
            // 
            // orderMovieToolStripMenuItem
            // 
            this.orderMovieToolStripMenuItem.Name = "orderMovieToolStripMenuItem";
            this.orderMovieToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.orderMovieToolStripMenuItem.Text = "Order Movie";
            // 
            // btnMemberSignIn
            // 
            this.btnMemberSignIn.BackColor = System.Drawing.Color.Silver;
            this.btnMemberSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemberSignIn.ForeColor = System.Drawing.Color.Red;
            this.btnMemberSignIn.Location = new System.Drawing.Point(160, 57);
            this.btnMemberSignIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMemberSignIn.Name = "btnMemberSignIn";
            this.btnMemberSignIn.Size = new System.Drawing.Size(425, 68);
            this.btnMemberSignIn.TabIndex = 1;
            this.btnMemberSignIn.Text = "Sign In";
            this.btnMemberSignIn.UseVisualStyleBackColor = false;
            this.btnMemberSignIn.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(160, 132);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(425, 304);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnAdminSignIn
            // 
            this.btnAdminSignIn.BackColor = System.Drawing.Color.Silver;
            this.btnAdminSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminSignIn.ForeColor = System.Drawing.Color.Red;
            this.btnAdminSignIn.Location = new System.Drawing.Point(160, 442);
            this.btnAdminSignIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdminSignIn.Name = "btnAdminSignIn";
            this.btnAdminSignIn.Size = new System.Drawing.Size(425, 68);
            this.btnAdminSignIn.TabIndex = 1;
            this.btnAdminSignIn.Text = "Sign In As Admin";
            this.btnAdminSignIn.UseVisualStyleBackColor = false;
            this.btnAdminSignIn.Click += new System.EventHandler(this.button2_Click);
            // 
            // SignInScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(756, 534);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAdminSignIn);
            this.Controls.Add(this.btnMemberSignIn);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.ToolStripMenuItem createWatchListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem browseInventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderMovieToolStripMenuItem;
        private System.Windows.Forms.Button btnMemberSignIn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAdminSignIn;
    }
}