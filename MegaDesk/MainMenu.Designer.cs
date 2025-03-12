namespace MegaDesk
{
    partial class MainMenu
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
            this.NewQuote = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ViewQuotes = new System.Windows.Forms.Button();
            this.SearchQuotes = new System.Windows.Forms.Button();
            this.Exit3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NewQuote
            // 
            this.NewQuote.Location = new System.Drawing.Point(12, 10);
            this.NewQuote.Name = "NewQuote";
            this.NewQuote.Size = new System.Drawing.Size(198, 52);
            this.NewQuote.TabIndex = 0;
            this.NewQuote.Text = "Add New Quote";
            this.NewQuote.UseVisualStyleBackColor = true;
            this.NewQuote.Click += new System.EventHandler(this.NewQuote_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(216, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 190);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // ViewQuotes
            // 
            this.ViewQuotes.Location = new System.Drawing.Point(10, 68);
            this.ViewQuotes.Name = "ViewQuotes";
            this.ViewQuotes.Size = new System.Drawing.Size(198, 52);
            this.ViewQuotes.TabIndex = 5;
            this.ViewQuotes.Text = "View Quotes";
            this.ViewQuotes.UseVisualStyleBackColor = true;
            this.ViewQuotes.Click += new System.EventHandler(this.ViewQuotes_Click);
            // 
            // SearchQuotes
            // 
            this.SearchQuotes.Location = new System.Drawing.Point(10, 126);
            this.SearchQuotes.Name = "SearchQuotes";
            this.SearchQuotes.Size = new System.Drawing.Size(198, 52);
            this.SearchQuotes.TabIndex = 6;
            this.SearchQuotes.Text = "Search Quotes";
            this.SearchQuotes.UseVisualStyleBackColor = true;
            this.SearchQuotes.Click += new System.EventHandler(this.Search_Click);
            // 
            // Exit3
            // 
            this.Exit3.Location = new System.Drawing.Point(10, 184);
            this.Exit3.Name = "Exit3";
            this.Exit3.Size = new System.Drawing.Size(198, 52);
            this.Exit3.TabIndex = 7;
            this.Exit3.Text = "Exit";
            this.Exit3.UseVisualStyleBackColor = true;
            this.Exit3.Click += new System.EventHandler(this.ExitApp);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 239);
            this.Controls.Add(this.Exit3);
            this.Controls.Add(this.SearchQuotes);
            this.Controls.Add(this.ViewQuotes);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.NewQuote);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewQuote;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ViewQuotes;
        private System.Windows.Forms.Button SearchQuotes;
        private System.Windows.Forms.Button Exit3;
    }
}

