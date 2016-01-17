using System;
using System.Drawing;

namespace MovieHue
{
    public class Section : IDisposable
    {
        public string Name { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public Bitmap Bitmap { get; set; }
        public int AvgRed { get; set; }
        public int AvgBlue { get; set; }
        public int AvgGreen { get; set; }
        public Color Color { get; set; }

        #region IDisposable Members

        public void Dispose()
        {
            Name = String.Empty;
            Width = 0;
            Height = 0;
            X = 0;
            Y = 0;
            Bitmap.Dispose();
            AvgBlue = 0;
            AvgGreen = 0;
            AvgRed = 0;
        }

        #endregion
    }
}