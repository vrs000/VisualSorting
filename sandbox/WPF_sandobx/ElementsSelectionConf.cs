using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;
namespace WPF_sandobx
{
    public class ElementsSelectionConf
    {
        //private static SoundPlayer SelectionSound = new SoundPlayer("E:/VisualStudio2015/WPF_sandobx/WPF_sandobx/Jump.wav");
        private static string jump = "E:/VisualStudio2015/WPF_sandobx/WPF_sandobx/Jump.wav";
        //public static MediaPlayer SelectionSound = new MediaPlayer();
        public static SoundPlayer SelectionSound = new SoundPlayer(jump);

        public static RGB Stroke = new RGB(0, 0, 0);
        public static RGB Selection = new RGB(255, 255, 0);
        public static RGB Filling = new RGB(255, 255, 255);
        public static RGB Background = new RGB(0, 0, 0);

        public static int Swaps = 0;
        public static int Steps = 0;
        public static Brush BrashBack;
        public static SolidColorBrush StrokeColor = Brushes.Black;
        public static SolidColorBrush FillElements = Brushes.White;
        public static SolidColorBrush SelectedColor = Brushes.Yellow;
        public static SolidColorBrush OkColor = Brushes.Green;
        public static SolidColorBrush BackgroundColor = Brushes.Black;
        public static double StrokeThickness = 0;
        public static Label SwapsLabel;
        public static Label StepsLabel;
        public static void UpdateSwap(Label lab)
        {
            lab.Content = "Swap: " + Swaps.ToString();
        }
        public static void UpdateSteps(Label lab)
        {
            lab.Content = "Steps: " + Steps.ToString();
        }

        public static void Update(UIElementCollection collection)
        {
            foreach (Rectangle item in collection)
            {
                item.Stroke = StrokeColor;
                item.Fill = FillElements;
                item.StrokeThickness = StrokeThickness;
            }
        }

        public static void Select(Rectangle rect1, Rectangle rect2)
        {
            //SelectionSound.PlaySync();


            //Dispatcher.Invoke(() => Console.Beep(5000, 900));
            //new Thread(() => Console.Beep(5000, 30)).Start();

            string CurrentSwap = ConfigBackup.swaps.Content.ToString().Split(' ')[1];
            string swaps = "Swaps: ";
            int CurrentSwapCount = Convert.ToInt32(CurrentSwap);
            //ConfigBackup.swaps.Content = swaps + (CurrentSwapCount++).ToString();

            //foreach (System.Windows.Window win in System.Windows.Application.Current.Windows)
            //{
            //    if (win.GetType() == typeof(MainWindow))
            //    {
            //        CurrentSwap = (win as MainWindow).swaps.Content.ToString().Split(' ')[1];
            //        CurrentSwapCount = Convert.ToInt32(CurrentSwap);
            //        (win as MainWindow).swaps.Content = swaps + (CurrentSwapCount++).ToString();
            //    }
            //}

            ElementsSelectionConf.Swaps++;
            ElementsSelectionConf.UpdateSwap(SwapsLabel);


            

            BrashBack = rect1.Stroke;

            rect1.Stroke = SelectedColor;
            rect1.Fill = SelectedColor;
            rect2.Stroke = SelectedColor;
            rect2.Fill = SelectedColor;

            
        }

        public async static Task SelectBack(Rectangle rect1, Rectangle rect2)
        {
            Select(rect1, rect2);
            
            await Task.Delay(TimeSpan.FromTicks(SORT.TicksDelay));
            Back(rect1, rect2);
            
        }
        public static void Back(Rectangle rect1, Rectangle rect2)
        {
            rect1.Stroke = StrokeColor;
            rect2.Stroke = StrokeColor;
            rect1.Fill = FillElements;
            rect2.Fill = FillElements;
        }



        public async static

        Task
OkFilling(UIElementCollection list)
        {
            foreach (Rectangle rect in list)
            {
                rect.Stroke = ElementsSelectionConf.OkColor;
                rect.Fill = OkColor;


                if (PropertiesOfMembers.number <= 500)
                    await Task.Delay(TimeSpan.FromTicks(SORT.TicksDelay));
                else
                    await Task.Delay(TimeSpan.FromTicks(SORT.TicksDelay - 1));


            }

            await Task.Delay(TimeSpan.FromSeconds(1));

            foreach (Rectangle rect in list)
            {

                rect.Stroke = StrokeColor;
                rect.Fill = FillElements;
                if (PropertiesOfMembers.number <= 500)
                    await Task.Delay(TimeSpan.FromTicks(SORT.TicksDelay));
                else
                    await Task.Delay(TimeSpan.FromTicks(SORT.TicksDelay - 1));

            }
        }

    }
}
