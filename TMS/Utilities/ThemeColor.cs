using System.Drawing;
using System.Collections.Generic;

namespace TMS.UI.Utilities
{
    public static class ThemeColor
    {
        public static Color PrimaryColor { get; set; }
        public static Color SecondaryColor { get; set; }
        
        public static List<string> ColorList = new List<string>() { "#009688",
                                                                    "#009688",
                                                                    "#009688",
                                                                    "#009688",
                                                                    "#009688",
                                                                    "#009688",
                                                                    "#009688",
                                                                    "#009688",
                                                                    "#009688",
                                                                    "#009688",
                                                                    "#009688"};
        public static Color ChangeColorBrightness(Color color,double correctionfactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;

            if(correctionfactor<0)
            {
                correctionfactor = 1 + correctionfactor;
                red *= correctionfactor;
                green *= correctionfactor;
                blue *= correctionfactor;

            }
            else
            {
                red = (255 - red) * correctionfactor + red;
                green = (255 - green) * correctionfactor + green;
                blue = (255 - blue) * correctionfactor + blue;

            }
            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        }
    }
}
