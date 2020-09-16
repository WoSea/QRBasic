using System;
using System.Drawing;

namespace QRbasic
{
    internal class Perspective
    {
        private double CenterX;
        private double CenterY;
        private double CosRot;
        private double SinRot;
        private double CamDist;
        private double CosX;
        private double SinX;
        private double CamVectY;
        private double CamVectZ;
        private double CamPosY;
        private double CamPosZ;

        internal Perspective(double CenterX, double CenterY, double ImageRot, double CamDist, double RotX)
        {
            // center position
            this.CenterX = CenterX;
            this.CenterY = CenterY;

            // image rotation
            double RotRad = Math.PI * ImageRot / 180.0;
            CosRot = Math.Cos(RotRad);
            SinRot = Math.Sin(RotRad);

            // camera distance from Pdf417 barcode
            this.CamDist = CamDist;

            // x and z axis rotation constants
            double RotXRad = Math.PI * RotX / 180.0;
            CosX = Math.Cos(RotXRad);
            SinX = Math.Sin(RotXRad);

            // camera vector relative to Pdf417 barcode image
            CamVectY = SinX;
            CamVectZ = CosX;

            // camera position relative to Pdf417 barcode image
            CamPosY = CamDist * CamVectY;
            CamPosZ = CamDist * CamVectZ;

            // exit
            return;
        }

        internal PointF ScreenPosition
                (
                double BarcodePosX,
                double BarcodePosY
                )
        {
            // rotation
            double PosX = CosRot * BarcodePosX - SinRot * BarcodePosY;
            double PosY = SinRot * BarcodePosX + CosRot * BarcodePosY;

            // temp values for intersection calclulation
            double CamToBarcode = CamVectY * PosY;
            double T = CamToBarcode / (CamToBarcode - CamDist);

            // screen position relative to screen center
            double ScrnPosX = CenterX + PosX * (1 - T);
            double TempPosY = PosY + (CamPosY - PosY) * T;
            double TempPosZ = CamPosZ * T; // - ScrnCenterZ;

            // rotate around x axis
            double ScrnPosY = CenterY + TempPosY * CosX - TempPosZ * SinX;

            // program test
#if DEBUG
            double ScrnPosZ = TempPosY * SinX + TempPosZ * CosX;
            if (Math.Abs(ScrnPosZ) > 0.0001) throw new ApplicationException("Screen Z position must be zero");
#endif

            return new PointF((float)ScrnPosX, (float)ScrnPosY);
        }

        internal void GetPolygon
                (
                double PosX,
                double PosY,
                double Width,
                double Height,
                PointF[] Polygon
                )
        {
            Polygon[0] = ScreenPosition(PosX, PosY);
            Polygon[1] = ScreenPosition(PosX + Width, PosY);
            Polygon[2] = ScreenPosition(PosX + Width, PosY + Height);
            Polygon[3] = ScreenPosition(PosX, PosY + Height);
            return;
        }
    }
}