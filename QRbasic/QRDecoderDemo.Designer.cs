namespace QRbasic
{
    partial class QRDecoderDemo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QRDecoderDemo));
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.ImageFileLabel = new System.Windows.Forms.Label();
            this.LoadImageButton = new System.Windows.Forms.Button();
            this.DataTextBox = new System.Windows.Forms.TextBox();
            this.DecodedDataLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.HeaderLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HeaderLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.Location = new System.Drawing.Point(205, -4);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(180, 32);
            this.HeaderLabel.TabIndex = 1;
            this.HeaderLabel.Text = "QR Code Decoder";
            this.HeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ImageFileLabel
            // 
            this.ImageFileLabel.BackColor = System.Drawing.SystemColors.Info;
            this.ImageFileLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImageFileLabel.Location = new System.Drawing.Point(182, 477);
            this.ImageFileLabel.Name = "ImageFileLabel";
            this.ImageFileLabel.Size = new System.Drawing.Size(407, 20);
            this.ImageFileLabel.TabIndex = 16;
            this.ImageFileLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoadImageButton
            // 
            this.LoadImageButton.Location = new System.Drawing.Point(10, 469);
            this.LoadImageButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LoadImageButton.Name = "LoadImageButton";
            this.LoadImageButton.Size = new System.Drawing.Size(164, 38);
            this.LoadImageButton.TabIndex = 15;
            this.LoadImageButton.Text = "Load QR Code Image";
            this.LoadImageButton.UseVisualStyleBackColor = true;
            this.LoadImageButton.Click += new System.EventHandler(this.OnLoadImage);
            // 
            // DataTextBox
            // 
            this.DataTextBox.AcceptsReturn = true;
            this.DataTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.DataTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DataTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.DataTextBox.Location = new System.Drawing.Point(10, 360);
            this.DataTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DataTextBox.Multiline = true;
            this.DataTextBox.Name = "DataTextBox";
            this.DataTextBox.ReadOnly = true;
            this.DataTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataTextBox.Size = new System.Drawing.Size(572, 101);
            this.DataTextBox.TabIndex = 14;
            this.DataTextBox.TabStop = false;
            this.DataTextBox.Text = "\r\n";
            // 
            // DecodedDataLabel
            // 
            this.DecodedDataLabel.AutoSize = true;
            this.DecodedDataLabel.Location = new System.Drawing.Point(9, 340);
            this.DecodedDataLabel.Name = "DecodedDataLabel";
            this.DecodedDataLabel.Size = new System.Drawing.Size(95, 16);
            this.DecodedDataLabel.TabIndex = 13;
            this.DecodedDataLabel.Text = "Decoded data";
            // 
            // QRDecoderDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(594, 511);
            this.Controls.Add(this.ImageFileLabel);
            this.Controls.Add(this.LoadImageButton);
            this.Controls.Add(this.DataTextBox);
            this.Controls.Add(this.DecodedDataLabel);
            this.Controls.Add(this.HeaderLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(610, 550);
            this.Name = "QRDecoderDemo";
            this.Text = "QRDecoder";
            this.Load += new System.EventHandler(this.OnLoad);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            this.Resize += new System.EventHandler(this.OnResize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Label ImageFileLabel;
        private System.Windows.Forms.Button LoadImageButton;
        private System.Windows.Forms.TextBox DataTextBox;
        private System.Windows.Forms.Label DecodedDataLabel;
    }
}