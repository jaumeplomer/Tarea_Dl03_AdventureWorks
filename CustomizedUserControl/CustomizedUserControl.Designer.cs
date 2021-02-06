namespace CustomizedUserControl
{
    partial class CustomizedUserControl
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.largePhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.productModelIdTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.productModelNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.productPriceTextBox = new System.Windows.Forms.TextBox();
            this.sizesFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.mainBgColorButton = new System.Windows.Forms.Button();
            this.panelsBgColorButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.largePhotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // largePhotoPictureBox
            // 
            this.largePhotoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.largePhotoPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.largePhotoPictureBox.Location = new System.Drawing.Point(43, 60);
            this.largePhotoPictureBox.Name = "largePhotoPictureBox";
            this.largePhotoPictureBox.Size = new System.Drawing.Size(358, 211);
            this.largePhotoPictureBox.TabIndex = 0;
            this.largePhotoPictureBox.TabStop = false;
            this.largePhotoPictureBox.Click += new System.EventHandler(this.largePhotoPictureBox_Click);
            // 
            // productModelIdTextBox
            // 
            this.productModelIdTextBox.Location = new System.Drawing.Point(454, 166);
            this.productModelIdTextBox.Name = "productModelIdTextBox";
            this.productModelIdTextBox.Size = new System.Drawing.Size(122, 22);
            this.productModelIdTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Photo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(451, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "ProductModel Id:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(451, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "ProductModel Name:";
            // 
            // productModelNameTextBox
            // 
            this.productModelNameTextBox.Location = new System.Drawing.Point(454, 83);
            this.productModelNameTextBox.Name = "productModelNameTextBox";
            this.productModelNameTextBox.Size = new System.Drawing.Size(155, 22);
            this.productModelNameTextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(454, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Price:";
            // 
            // productPriceTextBox
            // 
            this.productPriceTextBox.Location = new System.Drawing.Point(454, 239);
            this.productPriceTextBox.Name = "productPriceTextBox";
            this.productPriceTextBox.Size = new System.Drawing.Size(130, 22);
            this.productPriceTextBox.TabIndex = 6;
            // 
            // sizesFlowLayoutPanel
            // 
            this.sizesFlowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sizesFlowLayoutPanel.Location = new System.Drawing.Point(43, 307);
            this.sizesFlowLayoutPanel.Name = "sizesFlowLayoutPanel";
            this.sizesFlowLayoutPanel.Size = new System.Drawing.Size(358, 107);
            this.sizesFlowLayoutPanel.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Sizes:";
            // 
            // mainBgColorButton
            // 
            this.mainBgColorButton.Location = new System.Drawing.Point(454, 307);
            this.mainBgColorButton.Name = "mainBgColorButton";
            this.mainBgColorButton.Size = new System.Drawing.Size(185, 43);
            this.mainBgColorButton.TabIndex = 10;
            this.mainBgColorButton.Text = "Change UI color!";
            this.mainBgColorButton.UseVisualStyleBackColor = true;
            this.mainBgColorButton.Click += new System.EventHandler(this.mainBgColorButton_Click);
            // 
            // panelsBgColorButton
            // 
            this.panelsBgColorButton.Location = new System.Drawing.Point(454, 371);
            this.panelsBgColorButton.Name = "panelsBgColorButton";
            this.panelsBgColorButton.Size = new System.Drawing.Size(185, 43);
            this.panelsBgColorButton.TabIndex = 11;
            this.panelsBgColorButton.Text = "Change panels color!";
            this.panelsBgColorButton.UseVisualStyleBackColor = true;
            this.panelsBgColorButton.Click += new System.EventHandler(this.panelsBgColorButton_Click);
            // 
            // CustomizedUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.panelsBgColorButton);
            this.Controls.Add(this.mainBgColorButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sizesFlowLayoutPanel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.productPriceTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.productModelNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productModelIdTextBox);
            this.Controls.Add(this.largePhotoPictureBox);
            this.Name = "CustomizedUserControl";
            this.Size = new System.Drawing.Size(675, 472);
            ((System.ComponentModel.ISupportInitialize)(this.largePhotoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox largePhotoPictureBox;
        private System.Windows.Forms.TextBox productModelIdTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox productModelNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox productPriceTextBox;
        private System.Windows.Forms.FlowLayoutPanel sizesFlowLayoutPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button mainBgColorButton;
        private System.Windows.Forms.Button panelsBgColorButton;
    }
}
