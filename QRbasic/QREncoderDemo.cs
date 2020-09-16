using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCodeEncoderLibrary;

namespace QRbasic
{
    public partial class QREncoderDemo : Form
    {
        private QREncoder QRCodeEncoder;
        private Bitmap QRCodeImage;
        private Rectangle QRCodeImageArea = new Rectangle();
        public QREncoderDemo()
        {
            InitializeComponent();
        }

        private void QREncoder_Load(object sender, EventArgs e)
        {  
            // create encoder object 
            QRCodeEncoder = new QREncoder(); 

            // load error correction combo box 
            ErrorCorrectionComboBox.SelectedIndex = 1;

            ModuleSizeTextBox.Text = "4";
            QuietZoneTextBox.Text = "16";

            // set initial screen
            SetScreen();
            // force resize
            OnResize(sender, e);
            return;
        }

        private void OnEncode(object sender, EventArgs e)
        {
            // get error correction code
            ErrorCorrection ErrorCorrection = (ErrorCorrection)ErrorCorrectionComboBox.SelectedIndex;

            // get module size
            string ModuleStr = ModuleSizeTextBox.Text.Trim();
            if (!int.TryParse(ModuleStr, out int ModuleSize) || ModuleSize < 1 || ModuleSize > 100)
            {
                MessageBox.Show("Module size error.");
                return;
            }

            // get quiet zone
            string QuietStr = QuietZoneTextBox.Text.Trim();
            if (!int.TryParse(QuietStr, out int QuietZone) || QuietZone < 1 || QuietZone > 100)
            {
                MessageBox.Show("Quiet zone error.");
                return;
            }

            // get data for QR Code
            string Data = DataTextBox.Text.Trim();
            if (Data.Length == 0)
            {
                MessageBox.Show("Data must not be empty.");
                return;
            }

            // disable buttons
            EnableButtons(false);

            try
            {
                QRCodeEncoder.ErrorCorrection = ErrorCorrection;
                QRCodeEncoder.ModuleSize = ModuleSize;
                QRCodeEncoder.QuietZone = QuietZone;

                // multi segment
                if (SeparatorCheckBox.Checked && Data.IndexOf('|') >= 0)
                {
                    string[] Segments = Data.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

                    // encode data
                    QRCodeEncoder.Encode(Segments);
                }

                // single segment
                else
                {
                    // encode data
                    QRCodeEncoder.Encode(Data);
                }

                // create bitmap
                QRCodeImage = QRCodeEncoder.CreateQRCodeBitmap();
            }

            catch (Exception Ex)
            {
                MessageBox.Show("Encoding exception.\r\n" + Ex.Message);
            }

            // enable buttons
            EnableButtons(true);

            // repaint panel
            Invalidate();
            return;
        }

        private void OnSavePNG(object sender, EventArgs e)
        {
            // save file dialog box
            SaveFileDialog Dialog = new SaveFileDialog();
            Dialog.DefaultExt = ".png";
            Dialog.AddExtension = true;
            Dialog.Filter = "Png image files (*.png)|*.png";
            Dialog.Title = "Save barcode in PNG format";
            Dialog.InitialDirectory = Directory.GetCurrentDirectory();
            Dialog.RestoreDirectory = true;
            Dialog.FileName = "QRCodePNGImage.png";
            if (Dialog.ShowDialog() != DialogResult.OK) return;

            // save image as png file
            QRCodeEncoder.SaveQRCodeToPngFile(Dialog.FileName);

            // start image editor
            Process.Start(Dialog.FileName);
            return;
        }

        private void OnSaveImage(object sender, EventArgs e)
        {
            // save QR code image screen
            if (QRCodeImage != null)
            {
                SaveImage Dialog = new SaveImage(QRCodeEncoder, QRCodeImage);
                Dialog.ShowDialog(this);
            }
            return;
        }

        private void OnResize(object sender, EventArgs e)
        {
            if (ClientSize.Width == 0) return;

            // center header label
            HeaderLabel.Left = (ClientSize.Width - HeaderLabel.Width) / 2;

            // put data text box at the bottom of client area
            DataTextBox.Top = ClientSize.Height - DataTextBox.Height - 8;
            DataTextBox.Width = ClientSize.Width - 2 * DataTextBox.Left;

            // put data label above text box
            DataLabel.Top = DataTextBox.Top - DataLabel.Height - 3;

            // put separator check box above and to the right of the text box
            SeparatorCheckBox.Top = DataTextBox.Top - SeparatorCheckBox.Height - 3;
            SeparatorCheckBox.Left = DataTextBox.Right - SeparatorCheckBox.Width;

            // put buttons half way between header and data text
            ButtonsGroupBox.Top = (DataLabel.Top + HeaderLabel.Top - ButtonsGroupBox.Height) / 2;

            // image area
            QRCodeImageArea.X = ButtonsGroupBox.Right + 4;
            QRCodeImageArea.Y = HeaderLabel.Bottom + 4;
            QRCodeImageArea.Width = ClientSize.Width - QRCodeImageArea.X - 4;
            QRCodeImageArea.Height = DataLabel.Top - QRCodeImageArea.Y - 4;

            // force re-paint
            Invalidate();
            return;
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            // no image
            if (QRCodeImage == null) return;

            // calculate image area width and height to preserve aspect ratio
            Rectangle ImageRect = new Rectangle
            {
                Height = (QRCodeImageArea.Width * QRCodeImage.Height) / QRCodeImage.Width
            };
            if (ImageRect.Height <= QRCodeImageArea.Height)
            {
                ImageRect.Width = QRCodeImageArea.Width;
            }
            else
            {
                ImageRect.Width = (QRCodeImageArea.Height * QRCodeImage.Width) / QRCodeImage.Height;
                ImageRect.Height = QRCodeImageArea.Height;
            }

            // calculate position
            ImageRect.X = QRCodeImageArea.X + (QRCodeImageArea.Width - ImageRect.Width) / 2;
            ImageRect.Y = QRCodeImageArea.Y + (QRCodeImageArea.Height - ImageRect.Height) / 2;
            e.Graphics.DrawImage(QRCodeImage, ImageRect);
            return;
        }

        private void EnableButtons
            (
            bool Enabled
            )
        {
            Encodebutton.Enabled = Enabled;
            SaveToPngButton.Enabled = QRCodeImage != null && Enabled;
            SaveImageButton.Enabled = QRCodeImage != null && Enabled; 
            return;
        }

        private void SetScreen()
        {
            EnableButtons(true);
            return;
        }
    }
}
