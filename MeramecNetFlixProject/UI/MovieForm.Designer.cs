namespace MeramecNetFlixProject.UI
{
    partial class MovieForm
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
            this.txtMovieNumber = new System.Windows.Forms.TextBox();
            this.txtMovieTitle = new System.Windows.Forms.TextBox();
            this.txtMovieDescription = new System.Windows.Forms.TextBox();
            this.txtRetailCost = new System.Windows.Forms.TextBox();
            this.txtYearMade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboGenre = new System.Windows.Forms.ComboBox();
            this.txtRentalCost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboMediaType = new System.Windows.Forms.ComboBox();
            this.cboRating = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCopiesOnHand = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtImageName = new System.Windows.Forms.TextBox();
            this.txtTrailerLink = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnMovieAdd = new System.Windows.Forms.Button();
            this.btnMovieFind = new System.Windows.Forms.Button();
            this.btnMovieUpdate = new System.Windows.Forms.Button();
            this.btnMovieDelete = new System.Windows.Forms.Button();
            this.btnMovieClear = new System.Windows.Forms.Button();
            this.btnMovieExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMovieNumber
            // 
            this.txtMovieNumber.Location = new System.Drawing.Point(97, 12);
            this.txtMovieNumber.Name = "txtMovieNumber";
            this.txtMovieNumber.Size = new System.Drawing.Size(100, 20);
            this.txtMovieNumber.TabIndex = 0;
            // 
            // txtMovieTitle
            // 
            this.txtMovieTitle.Location = new System.Drawing.Point(97, 38);
            this.txtMovieTitle.Name = "txtMovieTitle";
            this.txtMovieTitle.Size = new System.Drawing.Size(330, 20);
            this.txtMovieTitle.TabIndex = 0;
            // 
            // txtMovieDescription
            // 
            this.txtMovieDescription.Location = new System.Drawing.Point(97, 64);
            this.txtMovieDescription.Multiline = true;
            this.txtMovieDescription.Name = "txtMovieDescription";
            this.txtMovieDescription.Size = new System.Drawing.Size(497, 86);
            this.txtMovieDescription.TabIndex = 0;
            // 
            // txtRetailCost
            // 
            this.txtRetailCost.Location = new System.Drawing.Point(97, 200);
            this.txtRetailCost.Name = "txtRetailCost";
            this.txtRetailCost.Size = new System.Drawing.Size(100, 20);
            this.txtRetailCost.TabIndex = 0;
            // 
            // txtYearMade
            // 
            this.txtYearMade.Location = new System.Drawing.Point(97, 165);
            this.txtYearMade.Name = "txtYearMade";
            this.txtYearMade.Size = new System.Drawing.Size(100, 20);
            this.txtYearMade.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Movie Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Title:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Description:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Year Made:";
            // 
            // cboGenre
            // 
            this.cboGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGenre.FormattingEnabled = true;
            this.cboGenre.Location = new System.Drawing.Point(278, 168);
            this.cboGenre.Name = "cboGenre";
            this.cboGenre.Size = new System.Drawing.Size(121, 21);
            this.cboGenre.TabIndex = 3;
            // 
            // txtRentalCost
            // 
            this.txtRentalCost.Location = new System.Drawing.Point(278, 200);
            this.txtRentalCost.Name = "txtRentalCost";
            this.txtRentalCost.Size = new System.Drawing.Size(100, 20);
            this.txtRentalCost.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(233, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Genre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(426, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Rating:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(614, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Media Type:";
            // 
            // cboMediaType
            // 
            this.cboMediaType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMediaType.FormattingEnabled = true;
            this.cboMediaType.Location = new System.Drawing.Point(686, 168);
            this.cboMediaType.Name = "cboMediaType";
            this.cboMediaType.Size = new System.Drawing.Size(121, 21);
            this.cboMediaType.TabIndex = 3;
            // 
            // cboRating
            // 
            this.cboRating.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRating.FormattingEnabled = true;
            this.cboRating.Location = new System.Drawing.Point(473, 168);
            this.cboRating.Name = "cboRating";
            this.cboRating.Size = new System.Drawing.Size(121, 21);
            this.cboRating.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Retail Cost:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(210, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Rental Cost:";
            // 
            // txtCopiesOnHand
            // 
            this.txtCopiesOnHand.Location = new System.Drawing.Point(509, 200);
            this.txtCopiesOnHand.Name = "txtCopiesOnHand";
            this.txtCopiesOnHand.Size = new System.Drawing.Size(100, 20);
            this.txtCopiesOnHand.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(411, 203);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Copies on hand:";
            // 
            // txtImageName
            // 
            this.txtImageName.Location = new System.Drawing.Point(97, 235);
            this.txtImageName.Name = "txtImageName";
            this.txtImageName.Size = new System.Drawing.Size(100, 20);
            this.txtImageName.TabIndex = 0;
            // 
            // txtTrailerLink
            // 
            this.txtTrailerLink.Location = new System.Drawing.Point(282, 235);
            this.txtTrailerLink.Name = "txtTrailerLink";
            this.txtTrailerLink.Size = new System.Drawing.Size(376, 20);
            this.txtTrailerLink.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 238);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Image Filename:";
            this.label11.Click += new System.EventHandler(this.label8_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(214, 238);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Trailer Link:";
            this.label12.Click += new System.EventHandler(this.label8_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 261);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(831, 111);
            this.dataGridView1.TabIndex = 4;
            // 
            // btnMovieAdd
            // 
            this.btnMovieAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovieAdd.Location = new System.Drawing.Point(29, 391);
            this.btnMovieAdd.Name = "btnMovieAdd";
            this.btnMovieAdd.Size = new System.Drawing.Size(128, 44);
            this.btnMovieAdd.TabIndex = 5;
            this.btnMovieAdd.Text = "Add";
            this.btnMovieAdd.UseVisualStyleBackColor = true;
            // 
            // btnMovieFind
            // 
            this.btnMovieFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovieFind.Location = new System.Drawing.Point(163, 391);
            this.btnMovieFind.Name = "btnMovieFind";
            this.btnMovieFind.Size = new System.Drawing.Size(128, 44);
            this.btnMovieFind.TabIndex = 5;
            this.btnMovieFind.Text = "Find";
            this.btnMovieFind.UseVisualStyleBackColor = true;
            // 
            // btnMovieUpdate
            // 
            this.btnMovieUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovieUpdate.Location = new System.Drawing.Point(297, 391);
            this.btnMovieUpdate.Name = "btnMovieUpdate";
            this.btnMovieUpdate.Size = new System.Drawing.Size(128, 44);
            this.btnMovieUpdate.TabIndex = 5;
            this.btnMovieUpdate.Text = "Update";
            this.btnMovieUpdate.UseVisualStyleBackColor = true;
            // 
            // btnMovieDelete
            // 
            this.btnMovieDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovieDelete.Location = new System.Drawing.Point(431, 391);
            this.btnMovieDelete.Name = "btnMovieDelete";
            this.btnMovieDelete.Size = new System.Drawing.Size(128, 44);
            this.btnMovieDelete.TabIndex = 5;
            this.btnMovieDelete.Text = "Delete";
            this.btnMovieDelete.UseVisualStyleBackColor = true;
            // 
            // btnMovieClear
            // 
            this.btnMovieClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovieClear.Location = new System.Drawing.Point(565, 391);
            this.btnMovieClear.Name = "btnMovieClear";
            this.btnMovieClear.Size = new System.Drawing.Size(128, 44);
            this.btnMovieClear.TabIndex = 5;
            this.btnMovieClear.Text = "Clear";
            this.btnMovieClear.UseVisualStyleBackColor = true;
            this.btnMovieClear.Click += new System.EventHandler(this.btnMovieClear_Click);
            // 
            // btnMovieExit
            // 
            this.btnMovieExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovieExit.Location = new System.Drawing.Point(699, 391);
            this.btnMovieExit.Name = "btnMovieExit";
            this.btnMovieExit.Size = new System.Drawing.Size(128, 44);
            this.btnMovieExit.TabIndex = 5;
            this.btnMovieExit.Text = "Exit";
            this.btnMovieExit.UseVisualStyleBackColor = true;
            this.btnMovieExit.Click += new System.EventHandler(this.btnMovieExit_Click);
            // 
            // MovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 460);
            this.Controls.Add(this.btnMovieExit);
            this.Controls.Add(this.btnMovieClear);
            this.Controls.Add(this.btnMovieDelete);
            this.Controls.Add(this.btnMovieUpdate);
            this.Controls.Add(this.btnMovieFind);
            this.Controls.Add(this.btnMovieAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cboMediaType);
            this.Controls.Add(this.cboRating);
            this.Controls.Add(this.cboGenre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtYearMade);
            this.Controls.Add(this.txtCopiesOnHand);
            this.Controls.Add(this.txtRentalCost);
            this.Controls.Add(this.txtTrailerLink);
            this.Controls.Add(this.txtImageName);
            this.Controls.Add(this.txtRetailCost);
            this.Controls.Add(this.txtMovieDescription);
            this.Controls.Add(this.txtMovieTitle);
            this.Controls.Add(this.txtMovieNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MovieForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movie Form";
            this.Load += new System.EventHandler(this.MovieForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMovieNumber;
        private System.Windows.Forms.TextBox txtMovieTitle;
        private System.Windows.Forms.TextBox txtMovieDescription;
        private System.Windows.Forms.TextBox txtRetailCost;
        private System.Windows.Forms.TextBox txtYearMade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboGenre;
        private System.Windows.Forms.TextBox txtRentalCost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboMediaType;
        private System.Windows.Forms.ComboBox cboRating;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCopiesOnHand;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtImageName;
        private System.Windows.Forms.TextBox txtTrailerLink;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnMovieAdd;
        private System.Windows.Forms.Button btnMovieFind;
        private System.Windows.Forms.Button btnMovieUpdate;
        private System.Windows.Forms.Button btnMovieDelete;
        private System.Windows.Forms.Button btnMovieClear;
        private System.Windows.Forms.Button btnMovieExit;
    }
}