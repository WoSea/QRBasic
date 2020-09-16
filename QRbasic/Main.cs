using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QRbasic
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button_encoder_Click(object sender, EventArgs e)
        {
            QREncoderDemo QREncode= new QREncoderDemo();
            QREncode.Show();
        }

        private void button_decoder_Click(object sender, EventArgs e)
        {
            QRDecoderDemo QRDecode = new QRDecoderDemo();
            QRDecode.Show();
        }

        private void button_decodervideo_Click(object sender, EventArgs e)
        {
            QRDecoderVDemo QRDecodeV = new QRDecoderVDemo();
            QRDecodeV.Show();
        }
    }
}
