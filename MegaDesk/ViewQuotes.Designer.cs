namespace MegaDesk
{
    partial class ViewQuotes
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
            this.BackToForm = new System.Windows.Forms.Button();
            this.DateLabel = new System.Windows.Forms.Label();
            this.WidthReq = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BackToForm
            // 
            this.BackToForm.Location = new System.Drawing.Point(12, 386);
            this.BackToForm.Name = "BackToForm";
            this.BackToForm.Size = new System.Drawing.Size(198, 52);
            this.BackToForm.TabIndex = 18;
            this.BackToForm.Text = "Back";
            this.BackToForm.UseVisualStyleBackColor = true;
            this.BackToForm.Click += new System.EventHandler(this.BackToForm_Click);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(12, 9);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(61, 25);
            this.DateLabel.TabIndex = 19;
            this.DateLabel.Text = "Date";
            // 
            // WidthReq
            // 
            this.WidthReq.AutoSize = true;
            this.WidthReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WidthReq.Location = new System.Drawing.Point(14, 34);
            this.WidthReq.Name = "WidthReq";
            this.WidthReq.Size = new System.Drawing.Size(39, 18);
            this.WidthReq.TabIndex = 20;
            this.WidthReq.Text = "Date";
            // 
            // ViewQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WidthReq);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.BackToForm);
            this.Name = "ViewQuotes";
            this.Text = "View Quote";
            this.Load += new System.EventHandler(this.ViewQuotes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackToForm;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label WidthReq;
    }
}