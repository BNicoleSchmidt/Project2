namespace MeramecNetFlixProject
{
    partial class Genre
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtGenreName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGenreExit = new System.Windows.Forms.Button();
            this.btnClearClear = new System.Windows.Forms.Button();
            this.btnGenreDelete = new System.Windows.Forms.Button();
            this.btnGenreUpdate = new System.Windows.Forms.Button();
            this.btnGenreBrowse = new System.Windows.Forms.Button();
            this.btnGenreAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(80, 20);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 2;
            // 
            // txtGenreName
            // 
            this.txtGenreName.Location = new System.Drawing.Point(80, 62);
            this.txtGenreName.Name = "txtGenreName";
            this.txtGenreName.Size = new System.Drawing.Size(392, 20);
            this.txtGenreName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // btnGenreExit
            // 
            this.btnGenreExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenreExit.Location = new System.Drawing.Point(737, 351);
            this.btnGenreExit.Name = "btnGenreExit";
            this.btnGenreExit.Size = new System.Drawing.Size(139, 43);
            this.btnGenreExit.TabIndex = 9;
            this.btnGenreExit.Text = "Exit";
            this.btnGenreExit.UseVisualStyleBackColor = true;
            this.btnGenreExit.Click += new System.EventHandler(this.btnGenreExit_Click);
            // 
            // btnClearClear
            // 
            this.btnClearClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearClear.Location = new System.Drawing.Point(592, 351);
            this.btnClearClear.Name = "btnClearClear";
            this.btnClearClear.Size = new System.Drawing.Size(139, 43);
            this.btnClearClear.TabIndex = 10;
            this.btnClearClear.Text = "Clear";
            this.btnClearClear.UseVisualStyleBackColor = true;
            this.btnClearClear.Click += new System.EventHandler(this.btnClearClear_Click);
            // 
            // btnGenreDelete
            // 
            this.btnGenreDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenreDelete.Location = new System.Drawing.Point(447, 351);
            this.btnGenreDelete.Name = "btnGenreDelete";
            this.btnGenreDelete.Size = new System.Drawing.Size(139, 43);
            this.btnGenreDelete.TabIndex = 11;
            this.btnGenreDelete.Text = "Delete";
            this.btnGenreDelete.UseVisualStyleBackColor = true;
            // 
            // btnGenreUpdate
            // 
            this.btnGenreUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenreUpdate.Location = new System.Drawing.Point(302, 351);
            this.btnGenreUpdate.Name = "btnGenreUpdate";
            this.btnGenreUpdate.Size = new System.Drawing.Size(139, 43);
            this.btnGenreUpdate.TabIndex = 12;
            this.btnGenreUpdate.Text = "Update";
            this.btnGenreUpdate.UseVisualStyleBackColor = true;
            // 
            // btnGenreBrowse
            // 
            this.btnGenreBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenreBrowse.Location = new System.Drawing.Point(157, 351);
            this.btnGenreBrowse.Name = "btnGenreBrowse";
            this.btnGenreBrowse.Size = new System.Drawing.Size(139, 43);
            this.btnGenreBrowse.TabIndex = 13;
            this.btnGenreBrowse.Text = "Browse";
            this.btnGenreBrowse.UseVisualStyleBackColor = true;
            // 
            // btnGenreAdd
            // 
            this.btnGenreAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenreAdd.Location = new System.Drawing.Point(12, 351);
            this.btnGenreAdd.Name = "btnGenreAdd";
            this.btnGenreAdd.Size = new System.Drawing.Size(139, 43);
            this.btnGenreAdd.TabIndex = 14;
            this.btnGenreAdd.Text = "Add";
            this.btnGenreAdd.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(157, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(574, 150);
            this.dataGridView1.TabIndex = 15;
            // 
            // Genre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 433);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGenreExit);
            this.Controls.Add(this.btnClearClear);
            this.Controls.Add(this.btnGenreDelete);
            this.Controls.Add(this.btnGenreUpdate);
            this.Controls.Add(this.btnGenreBrowse);
            this.Controls.Add(this.btnGenreAdd);
            this.Controls.Add(this.txtGenreName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Genre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Genre Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtGenreName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGenreExit;
        private System.Windows.Forms.Button btnClearClear;
        private System.Windows.Forms.Button btnGenreDelete;
        private System.Windows.Forms.Button btnGenreUpdate;
        private System.Windows.Forms.Button btnGenreBrowse;
        private System.Windows.Forms.Button btnGenreAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

