namespace QRbasic
{
    partial class QRDecoderVDemo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QRDecoderVDemo));
            this.GoToUriButton = new System.Windows.Forms.Button();
            this.DataTextBox = new System.Windows.Forms.TextBox();
            this.DecodedDataLabel = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.PreviewPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // GoToUriButton
            // 
            this.GoToUriButton.Location = new System.Drawing.Point(351, 487);
            this.GoToUriButton.Name = "GoToUriButton";
            this.GoToUriButton.Size = new System.Drawing.Size(110, 39);
            this.GoToUriButton.TabIndex = 9;
            this.GoToUriButton.Text = "Go to URI";
            this.GoToUriButton.UseVisualStyleBackColor = true;
            this.GoToUriButton.Click += new System.EventHandler(this.OnGoToUri);
            // 
            // DataTextBox
            // 
            this.DataTextBox.AcceptsReturn = true;
            this.DataTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.DataTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DataTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.DataTextBox.Location = new System.Drawing.Point(15, 394);
            this.DataTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DataTextBox.Multiline = true;
            this.DataTextBox.Name = "DataTextBox";
            this.DataTextBox.ReadOnly = true;
            this.DataTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataTextBox.Size = new System.Drawing.Size(637, 74);
            this.DataTextBox.TabIndex = 7;
            this.DataTextBox.TabStop = false;
            this.DataTextBox.Text = "\r\n";
            // 
            // DecodedDataLabel
            // 
            this.DecodedDataLabel.AutoSize = true;
            this.DecodedDataLabel.Location = new System.Drawing.Point(14, 374);
            this.DecodedDataLabel.Name = "DecodedDataLabel";
            this.DecodedDataLabel.Size = new System.Drawing.Size(88, 16);
            this.DecodedDataLabel.TabIndex = 6;
            this.DecodedDataLabel.Text = "Decoded data";
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(216, 487);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(110, 39);
            this.ResetButton.TabIndex = 8;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.OnResetButton);
            // 
            // PreviewPanel
            // 
            this.PreviewPanel.Location = new System.Drawing.Point(17, 12);
            this.PreviewPanel.Name = "PreviewPanel";
            this.PreviewPanel.Size = new System.Drawing.Size(640, 360);
            this.PreviewPanel.TabIndex = 5;
            // 
            // QRDecoderVDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(670, 538);
            this.Controls.Add(this.GoToUriButton);
            this.Controls.Add(this.DataTextBox);
            this.Controls.Add(this.DecodedDataLabel);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.PreviewPanel);
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(686, 577);
            this.Name = "QRDecoderVDemo";
            this.Text = "QRDecoderVDemo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnClosing);
            this.Load += new System.EventHandler(this.OnLoad);
            this.Resize += new System.EventHandler(this.OnResize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GoToUriButton;
        private System.Windows.Forms.TextBox DataTextBox;
        private System.Windows.Forms.Label DecodedDataLabel;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Panel PreviewPanel;
    }
}