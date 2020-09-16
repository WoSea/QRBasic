using QRCodeDecoderLibrary;
using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices.ComTypes;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text;
using QRbasic.videodecoderClass; 
using DirectShowLib;
using QRCodeVideoDecoder;

namespace QRbasic
{
    public partial class QRDecoderVDemo : Form
    {
        private FrameSize FrameSize = new FrameSize(640, 480);
        private Camera VideoCamera;
        private Timer QRCodeTimer;
        private QRDecoder Decoder;
        public QRDecoderVDemo()
        {
            InitializeComponent();
        }

        private void OnClosing(object sender, FormClosingEventArgs e)
        {
            if (VideoCamera != null) VideoCamera.Dispose();
            return;
        }

        private void OnLoad(object sender, EventArgs e)
        {
             
#if DEBUG
            // current directory
            string CurDir = Environment.CurrentDirectory;
            string WorkDir = CurDir.Replace("bin\\Debug", "Work");
            if (WorkDir != CurDir && Directory.Exists(WorkDir)) Environment.CurrentDirectory = WorkDir;

            // open trace file
          //  QRCodeTrace.Open("QRCodeVideoDecoderTrace.txt");
           // QRCodeTrace.Write(Text);
#endif

            // disable reset button
            ResetButton.Enabled = false;
            GoToUriButton.Enabled = false;

            // get an array of web camera devices
            DsDevice[] CameraDevices = DsDevice.GetDevicesOfCat(FilterCategory.VideoInputDevice);

            // make sure at least one is available
            if (CameraDevices == null || CameraDevices.Length == 0)
            {
                MessageBox.Show("No video cameras in this computer");
                Close();
                return;
            }

            // select the first camera
            DsDevice CameraDevice = CameraDevices[0];

            // Device moniker
            IMoniker CameraMoniker = CameraDevice.Moniker;

            // get a list of frame sizes available
            FrameSize[] FrameSizes = Camera.GetFrameSizeList(CameraMoniker);

            // make sure there is at least one frame size
            if (FrameSizes == null || FrameSizes.Length == 0)
            {
                MessageBox.Show("No video cameras in this computer");
                Close();
                return;
            }

            // test if our frame size is available
            int Index;
            for (Index = 0; Index < FrameSizes.Length &&
                (FrameSizes[Index].Width != FrameSize.Width || FrameSizes[Index].Height != FrameSize.Height); Index++) ;

            // select first frame size
            if (Index == FrameSizes.Length) FrameSize = FrameSizes[0];

            // Set selected camera to camera control with default frame size
            // Create camera object
            VideoCamera = new Camera(PreviewPanel, CameraMoniker, FrameSize);

            // create QR code decoder
            Decoder = new QRDecoder();

            // resize window
            OnResize(sender, e);

            // create timer
            QRCodeTimer = new Timer();
            QRCodeTimer.Interval = 200;
            QRCodeTimer.Tick += QRCodeTimer_Tick;
            QRCodeTimer.Enabled = true;
            return;
        }
        private void QRCodeTimer_Tick(object sender, EventArgs e)
        {
            QRCodeTimer.Enabled = false;
            Bitmap QRCodeImage;
            try
            {
                QRCodeImage = VideoCamera.SnapshotSourceImage();

                // trace
#if DEBUG
              //  QRCodeTrace.Format("Image width: {0}, Height: {1}", QRCodeImage.Width, QRCodeImage.Height);
#endif
            }

            catch (Exception EX)
            {
                DataTextBox.Text = "Decode exception.\r\n" + EX.Message;
                QRCodeTimer.Enabled = true;
                return;
            }

            // decode image
            byte[][] DataByteArray = Decoder.ImageDecoder(QRCodeImage);
            string Text = QRCodeResult(DataByteArray);

            // dispose bitmap
            QRCodeImage.Dispose();

            // we have no QR code
            if (Text.Length == 0)
            {
                QRCodeTimer.Enabled = true;
                return;
            }

            VideoCamera.PauseGraph();

            DataTextBox.Text = Text;
            ResetButton.Enabled = true;
            if (IsValidUri(DataTextBox.Text)) GoToUriButton.Enabled = true;
            return;
        }
        /// <summary>
        /// Format result for display
        /// </summary>
        /// <param name="DataByteArray"></param>
        /// <returns></returns>
        private static string QRCodeResult   (    byte[][] DataByteArray   )
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

        private static bool IsValidUri(string Uri)
        {
            if (!System.Uri.IsWellFormedUriString(Uri, UriKind.Absolute)) return false;

            if (!System.Uri.TryCreate(Uri, UriKind.Absolute, out Uri TempUri)) return false;

            return TempUri.Scheme == System.Uri.UriSchemeHttp || TempUri.Scheme == System.Uri.UriSchemeHttps;
        }

        /// <summary>
        /// Reset button was pressed
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void OnResize(object sender, EventArgs e)
        {
            // minimize
            if (ClientSize.Width == 0) return;

            // put reset button at bottom center
            ResetButton.Left = ClientSize.Width / 2 - ResetButton.Width - 8;
            ResetButton.Top = ClientSize.Height - ResetButton.Height - 8;
            GoToUriButton.Left = ResetButton.Right + 16;
            GoToUriButton.Top = ResetButton.Top;

            // data text box
            DataTextBox.Top = ResetButton.Top - DataTextBox.Height - 8;
            DataTextBox.Width = ClientSize.Width - 8 - SystemInformation.VerticalScrollBarWidth;

            // decoded data label
            DecodedDataLabel.Top = DataTextBox.Top - DecodedDataLabel.Height - 4;

            // preview area
            int AreaWidth = ClientSize.Width - 4;
            int AreaHeight = DecodedDataLabel.Top - 4;
            if (AreaHeight > FrameSize.Height * AreaWidth / FrameSize.Width)
                AreaHeight = FrameSize.Height * AreaWidth / FrameSize.Width;
            else
                AreaWidth = FrameSize.Width * AreaHeight / FrameSize.Height;

            // preview panel
            PreviewPanel.Left = (ClientSize.Width - AreaWidth) / 2;
            PreviewPanel.Top = (DecodedDataLabel.Top - 4 - AreaHeight) / 2;
            PreviewPanel.Width = AreaWidth;
            PreviewPanel.Height = AreaHeight;
            return;
        }

        private void OnResetButton(object sender, EventArgs e)
        {
            VideoCamera.RunGraph();
            QRCodeTimer.Enabled = true;
            ResetButton.Enabled = false;
            GoToUriButton.Enabled = false;
            DataTextBox.Text = string.Empty;
            return;
        }

        private void OnGoToUri(object sender, EventArgs e)
        {
            Process.Start(DataTextBox.Text);
            return;
        }
    }
}
