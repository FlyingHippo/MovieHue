using System.Collections.Generic;
using System.Drawing;

namespace MovieHue.Logic
{
    public class ScreenZone
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<string> LightNames { get; set; }
        public Color? Color { get; set; }
    }
}