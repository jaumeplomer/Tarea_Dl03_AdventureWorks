namespace MainForm
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.redPickerTrackBar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.greenPickerTrackBar = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.bluePickerTrackBar = new System.Windows.Forms.TrackBar();
            this.customizedUserControl1 = new CustomizedUserControl.CustomizedUserControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.redPickerTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenPickerTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluePickerTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(750, 219);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(750, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Product id:";
            // 
            // redPickerTrackBar
            // 
            this.redPickerTrackBar.Location = new System.Drawing.Point(740, 299);
            this.redPickerTrackBar.Maximum = 255;
            this.redPickerTrackBar.Name = "redPickerTrackBar";
            this.redPickerTrackBar.Size = new System.Drawing.Size(250, 56);
            this.redPickerTrackBar.TabIndex = 4;
            this.redPickerTrackBar.Scroll += new System.EventHandler(this.colorPickerTrackBar_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(750, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Red:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(750, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Green:";
            // 
            // greenPickerTrackBar
            // 
            this.greenPickerTrackBar.Location = new System.Drawing.Point(740, 361);
            this.greenPickerTrackBar.Maximum = 255;
            this.greenPickerTrackBar.Name = "greenPickerTrackBar";
            this.greenPickerTrackBar.Size = new System.Drawing.Size(250, 56);
            this.greenPickerTrackBar.TabIndex = 6;
            this.greenPickerTrackBar.Scroll += new System.EventHandler(this.colorPickerTrackBar_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(750, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Blue:";
            // 
            // bluePickerTrackBar
            // 
            this.bluePickerTrackBar.Location = new System.Drawing.Point(740, 423);
            this.bluePickerTrackBar.Maximum = 255;
            this.bluePickerTrackBar.Name = "bluePickerTrackBar";
            this.bluePickerTrackBar.Size = new System.Drawing.Size(250, 56);
            this.bluePickerTrackBar.TabIndex = 8;
            this.bluePickerTrackBar.Scroll += new System.EventHandler(this.colorPickerTrackBar_Scroll);
            // 
            // customizedUserControl1
            // 
            this.customizedUserControl1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.customizedUserControl1.Location = new System.Drawing.Point(22, 22);
            this.customizedUserControl1.Name = "customizedUserControl1";
            this.customizedUserControl1.Size = new System.Drawing.Size(671, 463);
            this.customizedUserControl1.SizesBgColor = System.Drawing.Color.Empty;
            this.customizedUserControl1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(801, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 511);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.customizedUserControl1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bluePickerTrackBar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.greenPickerTrackBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.redPickerTrackBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.redPickerTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenPickerTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluePickerTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar redPickerTrackBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar greenPickerTrackBar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar bluePickerTrackBar;
        private CustomizedUserControl.CustomizedUserControl customizedUserControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

