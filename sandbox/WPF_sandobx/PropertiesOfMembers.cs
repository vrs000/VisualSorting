using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
namespace WPF_sandobx
{
  public class PropertiesOfMembers
    {
        private static double _height;
        private static double _prevheight;
        public static double PanelHeight;
        public static double PanelHeightPrevious;
        public static VerticalAlignment Valing = VerticalAlignment.Bottom;
        public static SortType SortType;
        public static int number { get; set; } = 1000;
        public static double width { get; set; } = 1;
        /// <summary>
        /// Максимальная высота элемента
        /// </summary>
        public static double height
        { get
            {
                return _height;
            }
            set
            {
                PanelHeight = value;
                _height = (value - 63 - 20) / 1.25;
            }
            
            
        }

        public static double PreviousHeight 
         {
                get
                {
                    return _prevheight;
                }
                set
                {
                    PanelHeightPrevious = value;
                    _prevheight = (value - 63 - 20) / 1.25;
                }
        }

      public static void UpdateAlligment(UIElementCollection Collection)
        {
            foreach (Rectangle item in Collection)
            {
                item.VerticalAlignment = PropertiesOfMembers.Valing;
            }
        }

    }
}
