namespace QRbasic
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.button_encoder = new System.Windows.Forms.Button();
            this.button_decoder = new System.Windows.Forms.Button();
            this.textBox_intro = new System.Windows.Forms.TextBox();
            this.button_decodervideo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_encoder
            // 
            this.button_encoder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_encoder.ForeColor = System.Drawing.Color.Red;
            this.button_encoder.Location = new System.Drawing.Point(329, 12);
            this.button_encoder.Name = "button_encoder";
            this.button_encoder.Size = new System.Drawing.Size(154, 81);
            this.button_encoder.TabIndex = 0;
            this.button_encoder.Text = "Encoder";
            this.button_encoder.UseVisualStyleBackColor = true;
            this.button_encoder.Click += new System.EventHandler(this.button_encoder_Click);
            // 
            // button_decoder
            // 
            this.button_decoder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_decoder.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button_decoder.Location = new System.Drawing.Point(329, 99);
            this.button_decoder.Name = "button_decoder";
            this.button_decoder.Size = new System.Drawing.Size(154, 41);
            this.button_decoder.TabIndex = 1;
            this.button_decoder.Text = "Decoder I";
            this.button_decoder.UseVisualStyleBackColor = true;
            this.button_decoder.Click += new System.EventHandler(this.button_decoder_Click);
            // 
            // textBox_intro
            // 
            this.textBox_intro.Location = new System.Drawing.Point(3, 12);
            this.textBox_intro.Multiline = true;
            this.textBox_intro.Name = "textBox_intro";
            this.textBox_intro.Size = new System.Drawing.Size(320, 168);
            this.textBox_intro.TabIndex = 2;
            this.textBox_intro.Text = "Chức năng QR code demo:\r\n- Tùy chỉnh thông số QR code\r\n- Thêm background image ch" +
    "o QR code\r\n- Xuất QR code sang các định dạng phổ biến\r\n- Decode QR code \r\n";
            // 
            // button_decodervideo
            // 
            this.button_decodervideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_decodervideo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button_decodervideo.Location = new System.Drawing.Point(329, 146);
            this.button_decodervideo.Name = "button_decodervideo";
            this.button_decodervideo.Size = new System.Drawing.Size(154, 41);
            this.button_decodervideo.TabIndex = 3;
            this.button_decodervideo.Text = "Decoder V";
            this.button_decodervideo.UseVisualStyleBackColor = true;
            this.button_decodervideo.Click += new System.EventHandler(this.button_decodervideo_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(483, 187);
            this.Controls.Add(this.button_decodervideo);
            this.Controls.Add(this.textBox_intro);
            this.Controls.Add(this.button_decoder);
            this.Controls.Add(this.button_encoder);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QRCodeBasic - FirstDemo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_encoder;
        private System.Windows.Forms.Button button_decoder;
        private System.Windows.Forms.TextBox textBox_intro;
        private System.Windows.Forms.Button button_decodervideo;
    }
}

