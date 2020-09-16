namespace QRbasic
{
    partial class QREncoderDemo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QREncoderDemo));
            this.ButtonsGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ErrorCorrectionComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ModuleSizeTextBox = new System.Windows.Forms.TextBox();
            this.QuietZoneTextBox = new System.Windows.Forms.TextBox();
            this.Encodebutton = new System.Windows.Forms.Button();
            this.SaveToPngButton = new System.Windows.Forms.Button();
            this.SaveImageButton = new System.Windows.Forms.Button();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.DataLabel = new System.Windows.Forms.Label();
            this.DataTextBox = new System.Windows.Forms.TextBox();
            this.SeparatorCheckBox = new System.Windows.Forms.CheckBox();
            this.ButtonsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonsGroupBox
            // 
            this.ButtonsGroupBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ButtonsGroupBox.Controls.Add(this.SaveImageButton);
            this.ButtonsGroupBox.Controls.Add(this.SaveToPngButton);
            this.ButtonsGroupBox.Controls.Add(this.Encodebutton);
            this.ButtonsGroupBox.Controls.Add(this.QuietZoneTextBox);
            this.ButtonsGroupBox.Controls.Add(this.ModuleSizeTextBox);
            this.ButtonsGroupBox.Controls.Add(this.label3);
            this.ButtonsGroupBox.Controls.Add(this.label2);
            this.ButtonsGroupBox.Controls.Add(this.ErrorCorrectionComboBox);
            this.ButtonsGroupBox.Controls.Add(this.label1);
            this.ButtonsGroupBox.Location = new System.Drawing.Point(13, 22);
            this.ButtonsGroupBox.Name = "ButtonsGroupBox";
            this.ButtonsGroupBox.Size = new System.Drawing.Size(169, 360);
            this.ButtonsGroupBox.TabIndex = 0;
            this.ButtonsGroupBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Error Correction";
            // 
            // ErrorCorrectionComboBox
            // 
            this.ErrorCorrectionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ErrorCorrectionComboBox.FormattingEnabled = true;
            this.ErrorCorrectionComboBox.Items.AddRange(new object[] {
            "L (7%)",
            "M (15%)",
            "Q (25%)",
            "H (30%)"});
            this.ErrorCorrectionComboBox.Location = new System.Drawing.Point(9, 46);
            this.ErrorCorrectionComboBox.Name = "ErrorCorrectionComboBox";
            this.ErrorCorrectionComboBox.Size = new System.Drawing.Size(98, 24);
            this.ErrorCorrectionComboBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Error Correction";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Error Correction";
            // 
            // ModuleSizeTextBox
            // 
            this.ModuleSizeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ModuleSizeTextBox.Location = new System.Drawing.Point(9, 101);
            this.ModuleSizeTextBox.Name = "ModuleSizeTextBox";
            this.ModuleSizeTextBox.Size = new System.Drawing.Size(65, 26);
            this.ModuleSizeTextBox.TabIndex = 4;
            this.ModuleSizeTextBox.Text = "4";
            // 
            // QuietZoneTextBox
            // 
            this.QuietZoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.QuietZoneTextBox.Location = new System.Drawing.Point(9, 157);
            this.QuietZoneTextBox.Name = "QuietZoneTextBox";
            this.QuietZoneTextBox.Size = new System.Drawing.Size(65, 26);
            this.QuietZoneTextBox.TabIndex = 5;
            this.QuietZoneTextBox.Text = "16";
            // 
            // Encodebutton
            // 
            this.Encodebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Encodebutton.Location = new System.Drawing.Point(9, 203);
            this.Encodebutton.Name = "Encodebutton";
            this.Encodebutton.Size = new System.Drawing.Size(146, 43);
            this.Encodebutton.TabIndex = 6;
            this.Encodebutton.Text = "Encode";
            this.Encodebutton.UseVisualStyleBackColor = true;
            this.Encodebutton.Click += new System.EventHandler(this.OnEncode);
            // 
            // SaveToPngButton
            // 
            this.SaveToPngButton.Location = new System.Drawing.Point(9, 252);
            this.SaveToPngButton.Name = "SaveToPngButton";
            this.SaveToPngButton.Size = new System.Drawing.Size(146, 43);
            this.SaveToPngButton.TabIndex = 7;
            this.SaveToPngButton.Text = "Save *.png";
            this.SaveToPngButton.UseVisualStyleBackColor = true;
            this.SaveToPngButton.Click += new System.EventHandler(this.OnSavePNG);
            // 
            // SaveImageButton
            // 
            this.SaveImageButton.Location = new System.Drawing.Point(9, 301);
            this.SaveImageButton.Name = "SaveImageButton";
            this.SaveImageButton.Size = new System.Drawing.Size(146, 43);
            this.SaveImageButton.TabIndex = 8;
            this.SaveImageButton.Text = "Save Image";
            this.SaveImageButton.UseVisualStyleBackColor = true;
            this.SaveImageButton.Click += new System.EventHandler(this.OnSaveImage);
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HeaderLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.HeaderLabel.ForeColor = System.Drawing.Color.Red;
            this.HeaderLabel.Location = new System.Drawing.Point(344, 9);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(104, 21);
            this.HeaderLabel.TabIndex = 9;
            this.HeaderLabel.Text = "QR Encoder";
            this.HeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DataLabel
            // 
            this.DataLabel.AutoSize = true;
            this.DataLabel.Location = new System.Drawing.Point(12, 397);
            this.DataLabel.Name = "DataLabel";
            this.DataLabel.Size = new System.Drawing.Size(249, 16);
            this.DataLabel.TabIndex = 11;
            this.DataLabel.Text = "Enter your data to be encoded in this box";
            // 
            // DataTextBox
            // 
            this.DataTextBox.Location = new System.Drawing.Point(15, 416);
            this.DataTextBox.Multiline = true;
            this.DataTextBox.Name = "DataTextBox";
            this.DataTextBox.Size = new System.Drawing.Size(579, 94);
            this.DataTextBox.TabIndex = 12;
            // 
            // SeparatorCheckBox
            // 
            this.SeparatorCheckBox.AutoSize = true;
            this.SeparatorCheckBox.Location = new System.Drawing.Point(359, 393);
            this.SeparatorCheckBox.Name = "SeparatorCheckBox";
            this.SeparatorCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SeparatorCheckBox.Size = new System.Drawing.Size(235, 20);
            this.SeparatorCheckBox.TabIndex = 13;
            this.SeparatorCheckBox.Text = "Use pipe | to create data segments";
            this.SeparatorCheckBox.UseVisualStyleBackColor = true;
            // 
            // QREncoderDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(594, 511);
            this.Controls.Add(this.SeparatorCheckBox);
            this.Controls.Add(this.DataTextBox);
            this.Controls.Add(this.DataLabel);
            this.Controls.Add(this.HeaderLabel);
            this.Controls.Add(this.ButtonsGroupBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(610, 550);
            this.Name = "QREncoderDemo";
            this.Text = "QREncoder";
            this.Load += new System.EventHandler(this.QREncoder_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            this.Resize += new System.EventHandler(this.OnResize);
            this.ButtonsGroupBox.ResumeLayout(false);
            this.ButtonsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox ButtonsGroupBox;
        private System.Windows.Forms.ComboBox ErrorCorrectionComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox QuietZoneTextBox;
        private System.Windows.Forms.TextBox ModuleSizeTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SaveImageButton;
        private System.Windows.Forms.Button SaveToPngButton;
        private System.Windows.Forms.Button Encodebutton;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Label DataLabel;
        private System.Windows.Forms.TextBox DataTextBox;
        private System.Windows.Forms.CheckBox SeparatorCheckBox;
    }
}