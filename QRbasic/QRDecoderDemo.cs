
using QRCodeDecoderLibrary;
using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms; 
namespace QRbasic
{
    public partial class QRDecoderDemo : Form
    {
        private QRDecoder QRCodeDecoder;
        private Bitmap QRCodeInputImage;
        private Rectangle ImageArea = new Rectangle();

        public QRDecoderDemo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Test decode program initialization
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void OnLoad(object sender, EventArgs e)
        {
           
#if DEBUG
            // current directory
            string CurDir = Environment.CurrentDirectory;
            string WorkDir = CurDir.Replace("bin\\Debug", "Work");
            if (WorkDir != CurDir && Directory.Exists(WorkDir)) Environment.CurrentDirectory = WorkDir;

            // open trace file
           // QRCodeTrace.Open("QRCodeDecoderTrace.txt");
            //QRCodeTrace.Write("QRCodeDecoderDemo");
#endif

            // create decoder
            QRCodeDecoder = new QRDecoder();

            // resize window
            OnResize(sender, e);
            return;
        }

        private void OnLoadImage(object sender, EventArgs e)
        {
            // get file name to decode
            OpenFileDialog Dialog = new OpenFileDialog
            {
                Filter = "Image Files(*.png;*.jpg;*.gif;*.tif)|*.png;*.jpg;*.gif;*.tif;*.bmp)|All files (*.*)|*.*",
                Title = "Load QR Code Image",
                InitialDirectory = Directory.GetCurrentDirectory(),
                RestoreDirectory = true,
                FileName = string.Empty
            };

            // display dialog box
            if (Dialog.ShowDialog() != DialogResult.OK) return;

            // clear parameters
            ImageFileLabel.Text = Dialog.FileName;

            // disable buttons
            LoadImageButton.Enabled = false;

            // dispose previous image
            if (QRCodeInputImage != null) QRCodeInputImage.Dispose();

            // load image to bitmap
            QRCodeInputImage = new Bitmap(Dialog.FileName);

            // trace
#if DEBUG
         //   QRCodeTrace.Format("****");
          //  QRCodeTrace.Format("Decode image: {0} ", Dialog.FileName);
          //  QRCodeTrace.Format("Image width: {0}, Height: {1}", QRCodeInputImage.Width, QRCodeInputImage.Height);
#endif

            // decode image
            byte[][] DataByteArray = QRCodeDecoder.ImageDecoder(QRCodeInputImage);

            // convert results to text
            DataTextBox.Text = QRCodeResult(DataByteArray);

            // enable buttons
            LoadImageButton.Enabled = true;

            // force repaint
            Invalidate();
            return;
        }

        /// <summary>
        /// Format result for display
        /// </summary>
        /// <param name="DataByteArray"></param>
        /// <returns></returns>
        private static string QRCodeResult
                (
                byte[][] DataByteArray
                )
        {
            // no QR code
            if (DataByteArray == null) return string.Empty;

            // image has one QR code
            if (DataByteArray.Length == 1) return QRDecoder.ByteArrayToStr(DataByteArray[0]);

            // image has more than one QR code
            StringBuilder Str = new StringBuilder();
            for (int Index = 0; Index < DataByteArray.Length; Index++)
            {
                if (Index != 0) Str.Append("\r\n");
                Str.AppendFormat("QR Code {0}\r\n", Index + 1);
                Str.Append(QRDecoder.ByteArrayToStr(DataByteArray[Index]));
            }
            return Str.ToString();
        }

        ////////////////////////////////////////////////////////////////////
        // paint QR Code image
        ////////////////////////////////////////////////////////////////////

        private void OnPaint(object sender, PaintEventArgs e)
        {
            // no image
            if (QRCodeInputImage == null) return;

            // calculate image area width and height to preserve aspect ratio
            Rectangle ImageRect = new Rectangle
            {
                Height = (ImageArea.Width * QRCodeInputImage.Height) / QRCodeInputImage.Width
            };

            if (ImageRect.Height <= ImageArea.Height)
            {
                ImageRect.Width = ImageArea.Width;
            }
            else
            {
                ImageRect.Width = (ImageArea.Height * QRCodeInputImage.Width) / QRCodeInputImage.Height;
                ImageRect.Height = ImageArea.Height;
            }

            // calculate position
            ImageRect.X = ImageArea.X + (ImageArea.Width - ImageRect.Width) / 2;
            ImageRect.Y = ImageArea.Y + (ImageArea.Height - ImageRect.Height) / 2;
            e.Graphics.DrawImage(QRCodeInputImage, ImageRect);
            return;
        }

        ////////////////////////////////////////////////////////////////////
        // Resize Encoder Control
        ////////////////////////////////////////////////////////////////////

        private void OnResize(object sender, EventArgs e)
        {
            // minimize
            if (ClientSize.Width == 0) return;

            // center header label
            HeaderLabel.Left = (ClientSize.Width - HeaderLabel.Width) / 2;

            // put button at bottom left
            LoadImageButton.Top = ClientSize.Height - LoadImageButton.Height - 8;

            // image file label
            ImageFileLabel.Top = LoadImageButton.Top + (LoadImageButton.Height - ImageFileLabel.Height) / 2;
            ImageFileLabel.Width = ClientSize.Width - ImageFileLabel.Left - 16;

            // data text box
            DataTextBox.Top = LoadImageButton.Top - DataTextBox.Height - 8;
            DataTextBox.Width = ClientSize.Width - 8 - SystemInformation.VerticalScrollBarWidth;

            // decoded data label
            DecodedDataLabel.Top = DataTextBox.Top - DecodedDataLabel.Height - 4;

            // image area
            ImageArea.X = 4;
            ImageArea.Y = HeaderLabel.Bottom + 4;
            ImageArea.Width = ClientSize.Width - ImageArea.X - 4;
            ImageArea.Height = DecodedDataLabel.Top - ImageArea.Y - 4;

            if (QRCodeInputImage != null) Invalidate();
            return;
        }
    }
}
