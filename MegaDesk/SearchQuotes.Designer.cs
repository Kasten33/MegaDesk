namespace MegaDesk
{
    partial class SearchQuotes
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
            this.ToStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ToStart
            // 
            this.ToStart.Location = new System.Drawing.Point(12, 386);
            this.ToStart.Name = "ToStart";
            this.ToStart.Size = new System.Drawing.Size(198, 52);
            this.ToStart.TabIndex = 18;
            this.ToStart.Text = "Back";
            this.ToStart.UseVisualStyleBackColor = true;
            this.ToStart.Click += new System.EventHandler(this.ToStart_Click);
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ToStart);
            this.Name = "SearchQuotes";
            this.Text = "Search Quote";
            this.Load += new System.EventHandler(this.SearchQuotes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ToStart;
    }
}