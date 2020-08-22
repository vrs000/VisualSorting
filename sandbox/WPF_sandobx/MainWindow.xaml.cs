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
using System.Threading;
using System.Windows.Threading;
using System.IO;
using System.Media;

namespace WPF_sandobx
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        // <Rectangle Width="52" Height="52" Fill="Black" Stroke="Red" StrokeThickness="3" VerticalAlignment="Bottom"/>
        public MainWindow()
        {
            InitializeComponent();

            //ElementsSelectionConf.FillElements = new SolidColorBrush(Color.FromRgb(125, 32, 56));

            WindowState = WindowState.Maximized;
           

            WidthStrokeValue.Text = ElementsSelectionConf.StrokeThickness.ToString();

            ElementsSelectionConf.SwapsLabel = swaps;
            
            ConfigBackup.swaps = swaps;
            

            //StreamReader file = new StreamReader("BackUp.txt");
            //file.ReadLine();
            //file.ReadLine();
            //PropertiesOfMembers.number = Convert.ToInt32(file.ReadLine());
            //PropertiesOfMembers.width = Convert.ToDouble(file.ReadLine());
            //file.Close();

            Random r = new Random();

            panel.Children.Clear();

            NumberValue.Text = PropertiesOfMembers.number.ToString();
            WidthValue.Text = PropertiesOfMembers.width.ToString();

            StopButton.IsEnabled = false;
            PropertiesOfMembers.height = Height;
            PropertiesOfMembers.PreviousHeight = Height;
            panel.Height = PropertiesOfMembers.height;

            this.WindowStartupLocation = WindowStartupLocation.CenterOwner;


            for (int i = 0; i < PropertiesOfMembers.number; i++)
            {
                panel.Children.Add(new Rectangle()
                {
                    Fill = ElementsSelectionConf.FillElements,
                    Width = PropertiesOfMembers.width,
                    Height = r.Next(0, 100) * 0.01 * PropertiesOfMembers.height,
                    Stroke = ElementsSelectionConf.StrokeColor,
                    StrokeThickness = ElementsSelectionConf.StrokeThickness,
                    VerticalAlignment = PropertiesOfMembers.Valing


                });
                // MessageBox.Show(panel.Height.ToString());
            }

        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            Random rand = new Random();

            if (PropertiesOfMembers.height == PropertiesOfMembers.PreviousHeight)
            {
                PropertiesOfMembers.height = Height;
            }

            else
            {
                PropertiesOfMembers.PreviousHeight = PropertiesOfMembers.PanelHeight;
                PropertiesOfMembers.height = Height;
            }





            panel.Height = PropertiesOfMembers.height;


            foreach (var r in panel.Children)
            {
                (r as Rectangle).Height *= PropertiesOfMembers.PanelHeight / PropertiesOfMembers.PanelHeightPrevious;
            }

            //if (WindowState==WindowState.Normal)
            //{
            //    PropertiesOfMembers.height = Height;
            //    panel.Height = PropertiesOfMembers.height;
            //    foreach (var r in panel.Children)
            //    {
            //        (r as Rectangle).Height = PropertiesOfMembers.PanelHeight / PropertiesOfMembers.PanelHeightPrevious;
            //    }

            //}

            if (WindowState == WindowState.Maximized)
            {
                Height = System.Windows.SystemParameters.PrimaryScreenHeight;
                if (PropertiesOfMembers.height != PropertiesOfMembers.PreviousHeight)
                {
                    PropertiesOfMembers.PreviousHeight = PropertiesOfMembers.PanelHeight;
                }

                PropertiesOfMembers.height = Height;
                panel.Height = PropertiesOfMembers.height;
                foreach (var r in panel.Children)
                {
                    (r as Rectangle).Height *= PropertiesOfMembers.PanelHeight / PropertiesOfMembers.PanelHeightPrevious;
                    //(r as Rectangle).Height = rand.Next(0, 100) * 0.01 * PropertiesOfMembers.height;
                }
            }


        }

        private async void RepeatButton_Click(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();

            foreach (Rectangle item in panel.Children)
            {
                item.Fill = ElementsSelectionConf.SelectedColor;
                item.Stroke = ElementsSelectionConf.SelectedColor;
                if (SpeedSlider.Value != 0)
                    await Task.Delay(TimeSpan.FromTicks(SORT.TicksDelay));
                item.Height = rand.Next(0, 100) * 0.01 * PropertiesOfMembers.height;
                item.Fill = ElementsSelectionConf.FillElements;
                item.Stroke = ElementsSelectionConf.StrokeColor;

            }
        }

        private void WidthValue_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (WidthValue.Text != "")
                    if (Convert.ToDouble(WidthValue.Text) > 0)
                    {
                        double width = Convert.ToDouble(WidthValue.Text);
                        PropertiesOfMembers.width = width;

                        foreach (Rectangle item in panel.Children)
                        {
                            item.Width = PropertiesOfMembers.width;
                        }
                    }
            }catch(Exception)
            {
                WidthValue.Text = PropertiesOfMembers.width.ToString();
            }

        }

        private void NumberValue_TextChanged(object sender, TextChangedEventArgs e)
        {
            //if (!(NumberValue.Text is Int32))
            //    NumberValue.Text = PropertiesOfMembers.number.ToString();
            try { 
            //if (NumberValue.Text is Int32)
            if (NumberValue.Text != "")
                if (Convert.ToInt32(NumberValue.Text) > 0)
                {
                    int numb = Convert.ToInt32(NumberValue.Text);

                    if (numb > PropertiesOfMembers.number)
                    {

                        int difference = numb - PropertiesOfMembers.number;
                        Random r = new Random();
                        for (int i = 0; i < difference; i++)
                        {
                            panel.Children.Add(new Rectangle()
                            {
                                Fill = ElementsSelectionConf.FillElements,
                                Width = PropertiesOfMembers.width,
                                Height = r.Next(0, 100) * 0.01 * PropertiesOfMembers.height,
                                Stroke = ElementsSelectionConf.StrokeColor,
                                StrokeThickness = ElementsSelectionConf.StrokeThickness,
                                VerticalAlignment = PropertiesOfMembers.Valing
                            });
                        }

                    }

                    if (numb < panel.Children.Count)
                    {
                        int difference = panel.Children.Count - numb;
                        int index = panel.Children.Count - 1;
                        for (int i = 0; i < difference; i++)
                        {
                            panel.Children.RemoveAt(index);
                            index--;
                        }

                    }
                }
                        PropertiesOfMembers.number = Convert.ToInt32(NumberValue.Text);
                    
                }catch(Exception)
            {
                NumberValue.Text = PropertiesOfMembers.number.ToString();
            }
        }

        private async void RepeatButton_Click_1(object sender, RoutedEventArgs e)
        {
            
            swaps.Content = "Swaps: 0";
            ElementsSelectionConf.Steps = 0;
            ElementsSelectionConf.Swaps = 0;

            #region LockButtons
            SortAscButton.IsEnabled = false;
            RandButton.IsEnabled = false;
            SortDescButton.IsEnabled = false;
            NumberValue.IsEnabled = false;
            StopButton.IsEnabled = true;
            ListOfSorts.IsEnabled = false;
            #endregion

            double d;

            #region BubbleSortAscending
            if (CombBoxBubbleSort.IsSelected)
            {
                int high = panel.Children.Count - 1;


                for (int j = 0; j <= high - 1; j++)
                {
                    for (int i = 0; i < high - j; i++)
                    {

                        if ((panel.Children[i] as Rectangle).Height > (panel.Children[i + 1] as Rectangle).Height)
                        {

                            await Task.Delay(TimeSpan.FromTicks(SORT.TicksDelay / 2));

                            //(panel.Children[i] as Rectangle).Stroke = Brushes.Yellow;
                            //(panel.Children[i + 1] as Rectangle).Stroke = Brushes.Yellow;

                            ElementsSelectionConf.Select(panel.Children[i] as Rectangle, panel.Children[i + 1] as Rectangle);


                            await Task.Delay(TimeSpan.FromTicks(SORT.TicksDelay));
                            d = (panel.Children[i + 1] as Rectangle).Height;
                            (panel.Children[i + 1] as Rectangle).Height = (panel.Children[i] as Rectangle).Height;
                            (panel.Children[i] as Rectangle).Height = d;

                            ElementsSelectionConf.Back(panel.Children[i] as Rectangle, panel.Children[i + 1] as Rectangle);
                            //(panel.Children[i] as Rectangle).Stroke = Brushes.Red;
                            //(panel.Children[i + 1] as Rectangle).Stroke = Brushes.Red;
                        }
                    }

                }
            }
            #endregion

            #region CocktailSort
            if (CombBoxCocktailSort.IsSelected)
            {
                int left = 0,
               right = panel.Children.Count - 1,
               count = 0;

                while (left < right)
                {
                    for (int i = left; i < right; i++)
                    {
                        count++;
                        if ((panel.Children[i] as Rectangle).Height > (panel.Children[i + 1] as Rectangle).Height)
                        {
                            await Task.Delay(TimeSpan.FromTicks(SORT.TicksDelay / 2));

                            ElementsSelectionConf.Select(panel.Children[i] as Rectangle, panel.Children[i + 1] as Rectangle);
                            //(panel.Children[i] as Rectangle).Stroke = Brushes.Yellow;
                            //(panel.Children[i + 1] as Rectangle).Stroke = Brushes.Yellow;

                            await Task.Delay(TimeSpan.FromTicks(SORT.TicksDelay));

                            d = (panel.Children[i + 1] as Rectangle).Height;
                            (panel.Children[i + 1] as Rectangle).Height = (panel.Children[i] as Rectangle).Height;
                            (panel.Children[i] as Rectangle).Height = d;


                            ElementsSelectionConf.Back(panel.Children[i] as Rectangle, panel.Children[i + 1] as Rectangle);
                            //(panel.Children[i] as Rectangle).Stroke = Brushes.Red;
                            //(panel.Children[i + 1] as Rectangle).Stroke = Brushes.Red;
                        }
                    }
                    right--;

                    for (int i = right; i > left; i--)
                    {
                        count++;
                        if ((panel.Children[i - 1] as Rectangle).Height > (panel.Children[i] as Rectangle).Height)
                        {
                            await Task.Delay(TimeSpan.FromTicks(SORT.TicksDelay / 2));
                            ElementsSelectionConf.Select(panel.Children[i] as Rectangle, panel.Children[i - 1] as Rectangle);

                            //(panel.Children[i - 1] as Rectangle).Stroke = Brushes.Yellow;
                            //(panel.Children[i] as Rectangle).Stroke = Brushes.Yellow;

                            await Task.Delay(TimeSpan.FromTicks(SORT.TicksDelay));

                            d = (panel.Children[i - 1] as Rectangle).Height;
                            (panel.Children[i - 1] as Rectangle).Height = (panel.Children[i] as Rectangle).Height;
                            (panel.Children[i] as Rectangle).Height = d;

                            ElementsSelectionConf.Back(panel.Children[i] as Rectangle, panel.Children[i - 1] as Rectangle);
                            //(panel.Children[i - 1] as Rectangle).Stroke = Brushes.Red;
                            //(panel.Children[i] as Rectangle).Stroke = Brushes.Red;
                        }
                    }
                    left++;
                }
            }


            #endregion


            if (CombBoxInsertionSort.IsSelected)
            {
                await SORT.InsertionSort(panel.Children, SortOrder.Ascedning);
            }

            if (CombBoxQuickSort.IsSelected)
            {
                await SORT.QuickSort(panel.Children, SortOrder.Ascedning, 0, panel.Children.Count - 1);
            }

            if (ComboBoxGnomeSort.IsSelected)
            {
                await SORT.GnomeSort(panel.Children, SortOrder.Ascedning);
            }

            if (ComboBoxMergeSort.IsSelected)
            {

                await SORT.MergeSort(panel.Children, SortOrder.Ascedning, 0, panel.Children.Count - 1);
            }

            if (ComboBoxShellSort.IsSelected)
            {
                await SORT.ShellSort(panel.Children, SortOrder.Ascedning);
            }

            if (ComboBoxSelectionSort.IsSelected)
            {
                await SORT.SelectionSort(panel.Children, SortOrder.Ascedning);
            }

            if (ComboBoxCombSort.IsSelected)
            {
                await SORT.ComboSort(panel.Children, SortOrder.Ascedning);
            }

            if (ComboBoxPyramidSort.IsSelected)
            {
                await SORT.Pyramid_Sort(panel.Children, SortOrder.Ascedning);
            }

            if (ComboBoxStoogeSort.IsSelected)
            {
                await SORT.StoogeSort(panel.Children, 0, panel.Children.Count - 1, SortOrder.Ascedning);
            }
            if (ComboBoxBogoSort.IsSelected)
            {
                await SORT.BogoSort(panel.Children, SortOrder.Ascedning);
            }

            if (ComboBoxIntroSort.IsSelected)
            {
                await SORT.IntroSort(panel.Children, SortOrder.Ascedning);
            }

            if (ComboBoxPuncakeSort.IsSelected)
            {
                await SORT.PancakeSort(panel.Children, SortOrder.Ascedning);
            }

            await ElementsSelectionConf.OkFilling(panel.Children);

            #region UnLockButtons
            SortAscButton.IsEnabled = true;
            RandButton.IsEnabled = true;
            SortDescButton.IsEnabled = true;
            NumberValue.IsEnabled = true;
            StopButton.IsEnabled = false;
            ListOfSorts.IsEnabled = true;
            #endregion
        }



        private async void RepeatButton_Click_2(object sender, RoutedEventArgs e)
        {
           
            swaps.Content = "Swaps: 0";
            ElementsSelectionConf.Steps = 0;
            ElementsSelectionConf.Swaps = 0;
            #region LockButtons
            SortAscButton.IsEnabled = false;
            RandButton.IsEnabled = false;
            SortDescButton.IsEnabled = false;
            NumberValue.IsEnabled = false;
            StopButton.IsEnabled = true;
            ListOfSorts.IsEnabled = false;
            #endregion

            double d;

            #region BubbleSort
            if (CombBoxBubbleSort.IsSelected)
            {
                int high = panel.Children.Count - 1;


                for (int j = 0; j <= high - 1; j++)
                {
                    for (int i = 0; i < high - j; i++)
                    {

                        if ((panel.Children[i] as Rectangle).Height < (panel.Children[i + 1] as Rectangle).Height)
                        {
                            await Task.Delay(TimeSpan.FromTicks(SORT.TicksDelay / 2));

                            ElementsSelectionConf.Select(panel.Children[i] as Rectangle, panel.Children[i + 1] as Rectangle);

                            //SomeClass.SomeMethod(rectangle1,rectangle2);

                            await Task.Delay(TimeSpan.FromTicks(SORT.TicksDelay));
                            d = (panel.Children[i + 1] as Rectangle).Height;
                            (panel.Children[i + 1] as Rectangle).Height = (panel.Children[i] as Rectangle).Height;
                            (panel.Children[i] as Rectangle).Height = d;

                            ElementsSelectionConf.Back(panel.Children[i] as Rectangle, panel.Children[i + 1] as Rectangle);
                        }
                    }

                }
            }
            #endregion
            #region CocktailSort
            if (CombBoxCocktailSort.IsSelected)
            {
                int left = 0,
               right = panel.Children.Count - 1,
               count = 0;

                while (left < right)
                {
                    for (int i = left; i < right; i++)
                    {
                        count++;
                        if ((panel.Children[i] as Rectangle).Height < (panel.Children[i + 1] as Rectangle).Height)
                        {
                            await Task.Delay(TimeSpan.FromTicks(SORT.TicksDelay / 2));

                            ElementsSelectionConf.Select(panel.Children[i] as Rectangle, panel.Children[i + 1] as Rectangle);


                            await Task.Delay(TimeSpan.FromTicks(SORT.TicksDelay));

                            d = (panel.Children[i + 1] as Rectangle).Height;
                            (panel.Children[i + 1] as Rectangle).Height = (panel.Children[i] as Rectangle).Height;
                            (panel.Children[i] as Rectangle).Height = d;


                            ElementsSelectionConf.Back(panel.Children[i] as Rectangle, panel.Children[i + 1] as Rectangle);
                        }
                    }
                    right--;

                    for (int i = right; i > left; i--)
                    {
                        count++;
                        if ((panel.Children[i - 1] as Rectangle).Height < (panel.Children[i] as Rectangle).Height)
                        {
                            await Task.Delay(TimeSpan.FromTicks(SORT.TicksDelay / 2));

                            ElementsSelectionConf.Select(panel.Children[i] as Rectangle, panel.Children[i - 1] as Rectangle);


                            await Task.Delay(TimeSpan.FromTicks(SORT.TicksDelay));

                            d = (panel.Children[i - 1] as Rectangle).Height;
                            (panel.Children[i - 1] as Rectangle).Height = (panel.Children[i] as Rectangle).Height;
                            (panel.Children[i] as Rectangle).Height = d;


                            ElementsSelectionConf.Back(panel.Children[i] as Rectangle, panel.Children[i - 1] as Rectangle);
                        }
                    }
                    left++;
                }
            }
            #endregion

            if (CombBoxInsertionSort.IsSelected)
            {
                await SORT.InsertionSort(panel.Children, SortOrder.Descending);
            }

            if (CombBoxQuickSort.IsSelected)
            {
                await SORT.QuickSort(panel.Children, SortOrder.Descending, 0, panel.Children.Count - 1);
            }

            if (ComboBoxGnomeSort.IsSelected)
            {
                await SORT.GnomeSort(panel.Children, SortOrder.Descending);
            }

            if (ComboBoxMergeSort.IsSelected)
            {
                await SORT.MergeSort(panel.Children, SortOrder.Descending, 0, panel.Children.Count - 1);
            }

            if (ComboBoxShellSort.IsSelected)
            {
                await SORT.ShellSort(panel.Children, SortOrder.Descending);
            }

            if (ComboBoxSelectionSort.IsSelected)
            {
                await SORT.SelectionSort(panel.Children, SortOrder.Descending);
            }

            if (ComboBoxCombSort.IsSelected)
            {
                await SORT.ComboSort(panel.Children, SortOrder.Descending);
            }

            if (ComboBoxPyramidSort.IsSelected)
            {
                await SORT.Pyramid_Sort(panel.Children, SortOrder.Descending);
            }

            if (ComboBoxStoogeSort.IsSelected)
            {
                await SORT.StoogeSort(panel.Children, 0, panel.Children.Count - 1, SortOrder.Descending);
            }

            if (ComboBoxBogoSort.IsSelected)
            {
                await SORT.BogoSort(panel.Children, SortOrder.Descending);
            }

            if (ComboBoxIntroSort.IsSelected)
            {
                await SORT.IntroSort(panel.Children, SortOrder.Descending);
            }

            if (ComboBoxPuncakeSort.IsSelected)
            {
                await SORT.PancakeSort(panel.Children, SortOrder.Descending);
            }

            await ElementsSelectionConf.OkFilling(panel.Children);
            #region UnLockButtons
            SortAscButton.IsEnabled = true;
            RandButton.IsEnabled = true;
            SortDescButton.IsEnabled = true;
            NumberValue.IsEnabled = true;
            StopButton.IsEnabled = false;
            ListOfSorts.IsEnabled = true;
            #endregion
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            //StreamWriter file = new StreamWriter("BackUp.txt");
            //file.WriteLine(this.Height);
            //file.WriteLine(this.Width);
            //file.WriteLine(NumberValue.Text);
            //file.WriteLine(WidthValue.Text);
            //file.WriteLine(ListOfSorts.SelectedItem.ToString());
            //file.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //StreamReader file = new StreamReader("BackUp.txt");
            //Height = Convert.ToDouble(file.ReadLine());
            //Width = Convert.ToDouble(file.ReadLine());
            //PropertiesOfMembers.number = Convert.ToInt32(file.ReadLine());
            //PropertiesOfMembers.width = Convert.ToDouble(file.ReadLine());
            ////ListOfSorts.SelectedItem = file.ReadLine() as ComboBoxItem;

            //file.Close();
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {

            System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);
            Application.Current.Shutdown();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            ConfColorWindow win = new ConfColorWindow();
            win.ShowDialog();
            ElementsSelectionConf.Update(panel.Children);
            panel.Background = ElementsSelectionConf.BackgroundColor;
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int TicksDelay = 10000;
            if (SpeedSlider.Value == 0)
                SORT.TicksDelay = TicksDelay;
            else
                SORT.TicksDelay = TicksDelay * (int)Math.Round(SpeedSlider.Value);
            //SORT.TicksDelay = Math.ro SpeedSlider.Value* TicksDelay;
        }

        private void WidthStrokeValue_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox box = (TextBox)sender;
            try
            {

                if (box.Text != "")
                    ElementsSelectionConf.StrokeThickness = Convert.ToDouble(box.Text);
            }
            catch(Exception)
            {
                box.Text = ElementsSelectionConf.StrokeThickness.ToString();
            }
            ElementsSelectionConf.Update(panel.Children);
        }

        private void Skip_Checked(object sender, RoutedEventArgs e)
        {
            SORT.TicksDelay = 0;
        }

        private void Skip_Unchecked(object sender, RoutedEventArgs e)
        {
            SORT.TicksDelay = 10000;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //SoundPlayer player = new SoundPlayer("E:/VisualStudio2015/WPF_sandobx/WPF_sandobx/Jump.wav");
            //player.PlayLooping();
            //player.Play();
            //SystemSounds.Beep.Play();
            //SystemSounds.Asterisk.Play();

            Dispatcher.Invoke(() => Console.Beep(5000, 900));
            new Thread(() => Console.Beep(5000, 1000)).Start();

        }

        private void TrRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            PropertiesOfMembers.Valing = VerticalAlignment.Bottom;
            PropertiesOfMembers.UpdateAlligment(panel.Children);

        }

        private void RectRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            PropertiesOfMembers.Valing = VerticalAlignment.Center;
            PropertiesOfMembers.UpdateAlligment(panel.Children);
        }
    }




}
