using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace pharmacy_project
{
    class ColorsTheme
    {
        public static Random random;
        public static int tempIndx;
        public static Color primaryColor;
        public static Color SecondryColor;
        private static List<string> ColorList = new List<string>() {"#3f51b5","#009688","#ff5722","#ff9800", "#607d8b","#9c27b0",
                                                                   "#2196f3","#ea676c","#e41a4a", "#5978bb", "#018790", "#0e3441",
                                                                   "#00b0ad","#721d47","#ea4833","#ef937e",
                                                                   "#f37521","#a12059","#126881","#8bc240","#364d5b","#c7dc5b",
                                                                    "#0094bc","#e4126b","#43b76e","#7bcfe9", "#b71c46"};

        public static Color ColorLogoDark(Color color)
        {
            Double red = color.R;
            Double green = color.G;
            Double blue = color.B;
            double addvalue = 0.7;
            red *= addvalue;
            blue *= addvalue;
            green *= addvalue;
            return Color.FromArgb(color.A, (byte)red , (byte)green, (byte)blue);
        }
        public static Color SelectThemeColor()
        {
            ColorsTheme.random = new Random();
            int index = ColorsTheme.random.Next(ColorsTheme.ColorList.Count);
            if (ColorsTheme.tempIndx == index)
            {
                index = ColorsTheme.random.Next(ColorsTheme.ColorList.Count);
            }
            ColorsTheme.tempIndx = index;
            string color = ColorsTheme.ColorList[index];
            return ColorTranslator.FromHtml(color);

        }


    }
}
