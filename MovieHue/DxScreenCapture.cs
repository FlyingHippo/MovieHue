using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MovieHue.Logic;
using SlimDX;
using SlimDX.Direct3D9;

namespace MovieHue
{
    public class DxScreenCapture
    {
        private const int Bpp = 4;
        private readonly Collection<long> bPos = new Collection<long>();
        private readonly Collection<long> blPos = new Collection<long>();
        private readonly Collection<long> brPos = new Collection<long>();
        private readonly Device d;
        private readonly Collection<long> lPos = new Collection<long>();
        private readonly Collection<long> rPos = new Collection<long>();
        private readonly Collection<long> tPos = new Collection<long>();
        private readonly Collection<long> tlPos = new Collection<long>();
        private readonly Collection<long> trPos = new Collection<long>();

        public DxScreenCapture()
        {
            var present_params = new PresentParameters();
            present_params.Windowed = true;
            present_params.SwapEffect = SwapEffect.Discard;
            d = new Device(new Direct3D(), 0, DeviceType.Hardware, IntPtr.Zero, CreateFlags.SoftwareVertexProcessing,
                           present_params);
            int o = 20;
            int m = 8;
            int sx = Screen.PrimaryScreen.Bounds.Width - m;
            int sy = Screen.PrimaryScreen.Bounds.Height - m;
            int bx = (sx - m)/3 + m;
            int by = (sy - m)/3 + m;
            int bx2 = (sx - m)*2/3 + m;
            int by2 = (sy - m)*2/3 + m;

            long x, y;
            long pos;

            y = m;
            for (x = m; x < sx; x += o)
            {
                pos = (y*Screen.PrimaryScreen.Bounds.Width + x)*Bpp;
                if (x < bx)
                    tlPos.Add(pos);
                else if (x > bx && x < bx2)
                    tPos.Add(pos);
                else if (x > bx2)
                    trPos.Add(pos);
            }

            y = sy;
            for (x = m; x < sx; x += o)
            {
                pos = (y*Screen.PrimaryScreen.Bounds.Width + x)*Bpp;
                if (x < bx)
                    blPos.Add(pos);
                else if (x > bx && x < bx2)
                    bPos.Add(pos);
                else if (x > bx2)
                    brPos.Add(pos);
            }

            x = m;
            for (y = m + 1; y < sy - 1; y += o)
            {
                pos = (y*Screen.PrimaryScreen.Bounds.Width + x)*Bpp;
                if (y < by)
                    tlPos.Add(pos);
                else if (y > by && y < by2)
                    lPos.Add(pos);
                else if (y > by2)
                    blPos.Add(pos);
            }

            x = sx;
            for (y = m + 1; y < sy - 1; y += o)
            {
                pos = (y*Screen.PrimaryScreen.Bounds.Width + x)*Bpp;
                if (y < by)
                    trPos.Add(pos);
                else if (y > by && y < by2)
                    rPos.Add(pos);
                else if (y > by2)
                    brPos.Add(pos);
            }
        }

        public Surface CaptureScreen()
        {
            Surface s = Surface.CreateOffscreenPlain(d, Screen.PrimaryScreen.Bounds.Width,
                                                     Screen.PrimaryScreen.Bounds.Height, Format.A8R8G8B8, Pool.Scratch);
            d.GetFrontBufferData(0, s);
            return s;
        }

        private Color avcs(DataStream gs, Collection<long> positions)
        {
            var bu = new byte[4];
            int r = 0;
            int g = 0;
            int b = 0;
            int i = 0;

            foreach (long pos in positions)
            {
                gs.Position = pos;
                gs.Read(bu, 0, 4);
                r += bu[2];
                g += bu[1];
                b += bu[0];
                i++;
            }

            return Color.FromArgb(r/i, g/i, b/i);
        }

        public List<ScreenZone> Calculate(List<ScreenZone> screenZones)
        {
            Surface s = CaptureScreen();
            DataRectangle dr = s.LockRectangle(LockFlags.None);
            DataStream gs = dr.Data;


            List<Section> sections = new List<Section>();
            sections.Add(new Section()
                             {
                                 Name = "Top left",
                                 Color = avcs(gs, tlPos)
                             });
            sections.Add(new Section()
                             {
                                 Name = "Top right",
                                 Color = avcs(gs, trPos)
                             });
            sections.Add(new Section()
                             {
                                 Name = "Bottom left",
                                 Color = avcs(gs, blPos)
                             });
            sections.Add(new Section()
                             {
                                 Name = "Bottom right",
                                 Color = avcs(gs, brPos)
                             });
            sections.Add(new Section()
                             {
                                 Name = "Top",
                                 Color = avcs(gs, tPos)
                             });
            sections.Add(new Section()
                             {
                                 Name = "Bottom",
                                 Color = avcs(gs, bPos)
                             });
            sections.Add(new Section()
                             {
                                 Name = "Left",
                                 Color = avcs(gs, lPos)
                             });
            sections.Add(new Section()
                             {
                                 Name = "Right",
                                 Color = avcs(gs, rPos)
                             });
            foreach (ScreenZone screenZone in screenZones)
            {
                Section tempScetion = sections.Where(x => x.Name.Equals(screenZone.Name)).Select(x => x).FirstOrDefault();
                if (tempScetion != null)
                {
                    screenZone.Color = tempScetion.Color;
                }
            }

            s.UnlockRectangle();
            s.Dispose();

            return screenZones;
        }
    }
}