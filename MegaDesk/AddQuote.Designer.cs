namespace MegaDesk
{
    partial class AddQuote
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
            this.components = new System.ComponentModel.Container();
            this.DrawerInput = new System.Windows.Forms.ComboBox();
            this.MaterialComboBox = new System.Windows.Forms.ComboBox();
            this.ShippingComboBox = new System.Windows.Forms.ComboBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.DepthBox = new System.Windows.Forms.TextBox();
            this.WidthBox = new System.Windows.Forms.TextBox();
            this.DateLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ToForm1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.WidthErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.DepthErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.DCounterErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ShippingErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.NameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.MaterialErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.WidthErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepthErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DCounterErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShippingErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // DrawerInput
            // 
            this.DrawerInput.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.DrawerInput.Location = new System.Drawing.Point(253, 233);
            this.DrawerInput.Name = "DrawerInput";
            this.DrawerInput.Size = new System.Drawing.Size(178, 24);
            this.DrawerInput.TabIndex = 20;
            this.DrawerInput.Validating += new System.ComponentModel.CancelEventHandler(this.DrawerInput_Validation);
            // 
            // MaterialComboBox
            // 
            this.MaterialComboBox.FormattingEnabled = true;
            this.MaterialComboBox.Items.AddRange(new object[] {
            "Pine",
            "Laminate",
            "Veneer",
            "Oak",
            "Rosewood"});
            this.MaterialComboBox.Location = new System.Drawing.Point(253, 274);
            this.MaterialComboBox.Name = "MaterialComboBox";
            this.MaterialComboBox.Size = new System.Drawing.Size(178, 24);
            this.MaterialComboBox.TabIndex = 2;
            this.MaterialComboBox.SelectedIndexChanged += new System.EventHandler(this.MaterialComboBox_SelectedIndexChanged);
            // 
            // ShippingComboBox
            // 
            this.ShippingComboBox.FormattingEnabled = true;
            this.ShippingComboBox.Items.AddRange(new object[] {
            "3",
            "5",
            "7"});
            this.ShippingComboBox.Location = new System.Drawing.Point(253, 319);
            this.ShippingComboBox.Name = "ShippingComboBox";
            this.ShippingComboBox.Size = new System.Drawing.Size(178, 24);
            this.ShippingComboBox.TabIndex = 3;
            this.ShippingComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.Shipping_Validation);
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(253, 96);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(178, 22);
            this.NameBox.TabIndex = 4;
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            // 
            // DepthBox
            // 
            this.DepthBox.Location = new System.Drawing.Point(253, 190);
            this.DepthBox.Name = "DepthBox";
            this.DepthBox.Size = new System.Drawing.Size(178, 22);
            this.DepthBox.TabIndex = 19;
            this.DepthBox.Validating += new System.ComponentModel.CancelEventHandler(this.DepthBox_Validating);
            // 
            // WidthBox
            // 
            this.WidthBox.Location = new System.Drawing.Point(253, 143);
            this.WidthBox.Name = "WidthBox";
            this.WidthBox.Size = new System.Drawing.Size(178, 22);
            this.WidthBox.TabIndex = 6;
            this.WidthBox.Validating += new System.ComponentModel.CancelEventHandler(this.WidthBox_Validating);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(297, 57);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(86, 16);
            this.DateLabel.TabIndex = 7;
            this.DateLabel.Text = "Todays Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Please Enter Your Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Desk Width:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Desk Depth:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Desk Drawer Count:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Material Type:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Shipping Timeframe:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Todays Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(172, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Mega Desk";
            // 
            // ToForm1
            // 
            this.ToForm1.Location = new System.Drawing.Point(12, 370);
            this.ToForm1.Name = "ToForm1";
            this.ToForm1.Size = new System.Drawing.Size(198, 52);
            this.ToForm1.TabIndex = 17;
            this.ToForm1.Text = "Back";
            this.ToForm1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(233, 370);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(198, 52);
            this.button2.TabIndex = 18;
            this.button2.Text = "Submit Order";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.SubmitOrder);
            // 
            // WidthErrorProvider
            // 
            this.WidthErrorProvider.ContainerControl = this;
            // 
            // DepthErrorProvider
            // 
            this.DepthErrorProvider.ContainerControl = this;
            // 
            // DCounterErrorProvider
            // 
            this.DCounterErrorProvider.ContainerControl = this;
            // 
            // ShippingErrorProvider
            // 
            this.ShippingErrorProvider.ContainerControl = this;
            // 
            // NameErrorProvider
            // 
            this.NameErrorProvider.ContainerControl = this;
            // 
            // MaterialErrorProvider
            // 
            this.MaterialErrorProvider.ContainerControl = this;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 434);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ToForm1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.WidthBox);
            this.Controls.Add(this.DepthBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.ShippingComboBox);
            this.Controls.Add(this.MaterialComboBox);
            this.Controls.Add(this.DrawerInput);
            this.Name = "AddQuote";
            this.Text = "Add Quote";
            ((System.ComponentModel.ISupportInitialize)(this.WidthErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepthErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DCounterErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShippingErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox DrawerInput;
        private System.Windows.Forms.ComboBox MaterialComboBox;
        private System.Windows.Forms.ComboBox ShippingComboBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox DepthBox;
        private System.Windows.Forms.TextBox WidthBox;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button ToForm1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ErrorProvider WidthErrorProvider;
        private System.Windows.Forms.ErrorProvider DepthErrorProvider;
        private System.Windows.Forms.ErrorProvider DCounterErrorProvider;
        private System.Windows.Forms.ErrorProvider ShippingErrorProvider;
        private System.Windows.Forms.ErrorProvider NameErrorProvider;
        private System.Windows.Forms.ErrorProvider MaterialErrorProvider;
    }
}