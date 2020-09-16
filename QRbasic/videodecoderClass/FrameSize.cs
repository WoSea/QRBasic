using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QRbasic.videodecoderClass
{
    public class FrameSize
    {
        public int Width { set; get; }

        /// <summary>
        /// Height of frame of video output.
        /// </summary>
        public int Height { set; get; }

        /// <summary>
        /// Constructor for <see cref="FrameSize"/> class.
        /// </summary>
        /// <param name="width">Width of frame of video output.</param>
        /// <param name="height">Height of frame of video output.</param>
        public FrameSize
                (
                int width,
                int height
                )
        {
            Width = width;
            Height = height;
            return;
        }
    }
}
