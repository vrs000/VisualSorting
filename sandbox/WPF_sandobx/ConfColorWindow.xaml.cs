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
using System.Windows.Shapes;

namespace WPF_sandobx
{
    /// <summary>
    /// Логика взаимодействия для ConfColorWindow.xaml
    /// </summary>
    public partial class ConfColorWindow : Window
    {
        public ConfColorWindow()
        {
            InitializeComponent();
            

            BackgroudRedSlider.Value = ElementsSelectionConf.Background.R;
            BackgroundGreenSlider.Value = ElementsSelectionConf.Background.G;
            BackgroundBlueSlider.Value = ElementsSelectionConf.Background.B;

            ForegroudRedSlider.Value = ElementsSelectionConf.Filling.R;
            ForegroundGreenSlider.Value = ElementsSelectionConf.Filling.G;
            ForegroundBlueSlider.Value = ElementsSelectionConf.Filling.B;

            StrokeRedSlider.Value = ElementsSelectionConf.Stroke.R;
            StrokeGreenSlider.Value = ElementsSelectionConf.Stroke.G;
            StrokeBlueSlider.Value = ElementsSelectionConf.Stroke.B;

            SelectRedSlider.Value = ElementsSelectionConf.Selection.R;
            SelectGreenSlider.Value = ElementsSelectionConf.Selection.G;
            SelectBlueSlider.Value = ElementsSelectionConf.Selection.B;
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {


            

            //
            ElementsSelectionConf.FillElements = new SolidColorBrush(Color.FromRgb(
                    Convert.ToByte(ForegroudRedSlider.Value),
                    Convert.ToByte(ForegroundGreenSlider.Value),
                    Convert.ToByte(ForegroundBlueSlider.Value)
                ));

            ElementsSelectionConf.Filling = new RGB(
                    Convert.ToByte(ForegroudRedSlider.Value),
                    Convert.ToByte(ForegroundGreenSlider.Value),
                    Convert.ToByte(ForegroundBlueSlider.Value));

            //BackgroundColor
            ElementsSelectionConf.BackgroundColor = new SolidColorBrush(Color.FromRgb(
                    Convert.ToByte(BackgroudRedSlider.Value),
                    Convert.ToByte(BackgroundGreenSlider.Value),
                    Convert.ToByte(BackgroundBlueSlider.Value)
                ));

            ElementsSelectionConf.Background = new RGB(
                    Convert.ToByte(BackgroudRedSlider.Value),
                    Convert.ToByte(BackgroundGreenSlider.Value),
                    Convert.ToByte(BackgroundBlueSlider.Value));

            //StrokeColor
            ElementsSelectionConf.StrokeColor = new SolidColorBrush(Color.FromRgb(
                    Convert.ToByte(StrokeRedSlider.Value),
                    Convert.ToByte(StrokeGreenSlider.Value),
                    Convert.ToByte(StrokeBlueSlider.Value)
                ));

            ElementsSelectionConf.Stroke = new RGB(
                    Convert.ToByte(StrokeRedSlider.Value),
                    Convert.ToByte(StrokeGreenSlider.Value),
                    Convert.ToByte(StrokeBlueSlider.Value)
                );

            //SelectColor
            ElementsSelectionConf.SelectedColor = new SolidColorBrush(Color.FromRgb(
                    Convert.ToByte(SelectRedSlider.Value),
                    Convert.ToByte(SelectGreenSlider.Value),
                    Convert.ToByte(SelectBlueSlider.Value)
                ));

            ElementsSelectionConf.Selection = new RGB(
                    Convert.ToByte(SelectRedSlider.Value),
                    Convert.ToByte(SelectGreenSlider.Value),
                    Convert.ToByte(SelectBlueSlider.Value));


            DialogResult = true;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            //MessageBox.Show(comboBox1.SelectedIndex.ToString());
            //ElementsSelectionConf.FillElements = comboBox1.
        }

        private void BackgroudRedSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            byte R, G, B;
            R = (byte)BackgroudRedSlider.Value;
            G = (byte)BackgroundGreenSlider.Value;
            B = (byte)BackgroundBlueSlider.Value;

            Rectangle1.Fill = new SolidColorBrush(Color.FromRgb(R, G, B));
        }

        private void BackgroundGreenSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            byte R, G, B;
            R = (byte)BackgroudRedSlider.Value;
            G = (byte)BackgroundGreenSlider.Value;
            B = (byte)BackgroundBlueSlider.Value;

            Rectangle1.Fill = new SolidColorBrush(Color.FromRgb(R, G, B));
        }

        private void BackgroundBlueSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            byte R, G, B;
            R = (byte)BackgroudRedSlider.Value;
            G = (byte)BackgroundGreenSlider.Value;
            B = (byte)BackgroundBlueSlider.Value;

            Rectangle1.Fill = new SolidColorBrush(Color.FromRgb(R, G, B));
        }

        void UpdateBackgroundSliders(double R, double G, double B)
        {
            BackgroudRedSlider.Value = R;
            BackgroundGreenSlider.Value = G;
            BackgroundBlueSlider.Value = B;

            //Rectangle1.Fill = new SolidColorBrush(Color.FromRgb(R, G, B));

        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (textbox1.Text != "")
                BackgroudRedSlider.Value = Convert.ToDouble(textbox1.Text);



            #region
            //byte r, g, b;
            //if (textbox1.Text != "")
            //{
            //    try
            //    {
            //        r = Convert.ToByte(textbox1.Text);
            //        g = Convert.ToByte(textbox2.Text);
            //        b = Convert.ToByte(textbox3.Text);
            //    }
            //    catch (Exception) { };
            //    UpdateBackgroundSliders(r, g, b);
            //}

            //BackgroudRedSlider.Value = Convert.ToDouble(textbox1.Text);
            //BackgroundGreenSlider.Value = Convert.ToDouble(textbox2.Text);
            //BackgroundBlueSlider.Value = Convert.ToDouble(textbox3.Text);

            //UpdateBackgroundSliders(
            //    Convert.ToDouble(textbox1.Text),
            //    Convert.ToDouble(textbox2.Text),
            //    Convert.ToDouble(textbox3.Text)
            //    );
            #endregion
        }

        private void ForegroudRedSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            byte R, G, B;
            try
            {
                R = (byte)ForegroudRedSlider.Value;
                G = (byte)ForegroundGreenSlider.Value;
                B = (byte)ForegroundBlueSlider.Value;
            }
            catch (NullReferenceException)
            {
                R = G = B = 255;
            }


            Rectangle2.Fill = new SolidColorBrush(Color.FromRgb(R, G, B));
        }

        private void ForegroundGreenSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            byte R, G, B;
            try
            {
                R = (byte)ForegroudRedSlider.Value;
                G = (byte)ForegroundGreenSlider.Value;
                B = (byte)ForegroundBlueSlider.Value;
            }
            catch (NullReferenceException)
            {
                R = G = B = 255;
            }


            Rectangle2.Fill = new SolidColorBrush(Color.FromRgb(R, G, B));
        }

        private void ForegroundBlueSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            byte R, G, B;
            try
            {
                R = (byte)ForegroudRedSlider.Value;
                G = (byte)ForegroundGreenSlider.Value;
                B = (byte)ForegroundBlueSlider.Value;
            }
            catch (NullReferenceException)
            {
                R = G = B = 255;
            }


            Rectangle2.Fill = new SolidColorBrush(Color.FromRgb(R, G, B));
        }

        private void StrokeRedSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            byte R, G, B;
            try
            {
                R = (byte)StrokeRedSlider.Value;
                G = (byte)StrokeGreenSlider.Value;
                B = (byte)StrokeBlueSlider.Value;
            }
            catch (NullReferenceException)
            {
                R = G = B = 0;
            }


            Rectangle3.Fill = new SolidColorBrush(Color.FromRgb(R, G, B));
        }

        private void StrokeGreenSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            byte R, G, B;
            try
            {
                R = (byte)StrokeRedSlider.Value;
                G = (byte)StrokeGreenSlider.Value;
                B = (byte)StrokeBlueSlider.Value;
            }
            catch (NullReferenceException)
            {
                R = G = B = 0;
            }


            Rectangle3.Fill = new SolidColorBrush(Color.FromRgb(R, G, B));
        }

        private void StrokeBlueSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            byte R, G, B;
            try
            {
                R = (byte)StrokeRedSlider.Value;
                G = (byte)StrokeGreenSlider.Value;
                B = (byte)StrokeBlueSlider.Value;
            }
            catch (NullReferenceException)
            {
                R = G = B = 0;
            }


            Rectangle3.Fill = new SolidColorBrush(Color.FromRgb(R, G, B));
        }

        private void SelectRedSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            byte R, G, B;
            try
            {
                R = (byte)SelectRedSlider.Value;
                G = (byte)SelectGreenSlider.Value;
                B = (byte)SelectBlueSlider.Value;
            }
            catch (NullReferenceException)
            {
                R = 255;
                G = 0;
                B = 0;
            }


            Rectangle4.Fill = new SolidColorBrush(Color.FromRgb(R, G, B));
        }

        private void SelectGreenSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            byte R, G, B;
            try
            {
                R = (byte)SelectRedSlider.Value;
                G = (byte)SelectGreenSlider.Value;
                B = (byte)SelectBlueSlider.Value;
            }
            catch (NullReferenceException)
            {
                R = 255;
                G = 0;
                B = 0;
            }


            Rectangle4.Fill = new SolidColorBrush(Color.FromRgb(R, G, B));
        }

        private void SelectBlueSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            byte R, G, B;
            try
            {
                R = (byte)SelectRedSlider.Value;
                G = (byte)SelectGreenSlider.Value;
                B = (byte)SelectBlueSlider.Value;
            }
            catch (NullReferenceException)
            {
                R = 255;
                G = 0;
                B = 0;
            }


            Rectangle4.Fill = new SolidColorBrush(Color.FromRgb(R, G, B));
        }

        private void textbox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (textbox2.Text != "")
                BackgroundGreenSlider.Value = Convert.ToDouble(textbox2.Text);
        }

        private void textbox3_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (textbox3.Text != "")
                BackgroundBlueSlider.Value = Convert.ToDouble(textbox3.Text);
        }

        private void textbox4_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (textbox4.Text != "")
                ForegroudRedSlider.Value = Convert.ToDouble(textbox4.Text);
            
        }

        private void textbox5_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (((TextBox)sender).Text!="")
                ForegroundGreenSlider.Value=Convert.ToDouble(((TextBox)sender).Text);

        }

        private void textbox6_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox box = (TextBox)sender;

            if (box.Text != "")
                ForegroundBlueSlider.Value = Convert.ToDouble(box.Text);
        }

        private void textbox7_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox box = (TextBox)sender;

            if (box.Text != "")
                StrokeRedSlider.Value = Convert.ToDouble(box.Text);
        }

        private void textbox8_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox box = (TextBox)sender;

            if (box.Text != "")
                StrokeGreenSlider.Value = Convert.ToDouble(box.Text);
        }

        private void textbox9_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox box = (TextBox)sender;

            if (box.Text != "")
                StrokeBlueSlider.Value = Convert.ToDouble(box.Text);
        }

        private void textbox10_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox box = (TextBox)sender;

            if (box.Text != "")
                SelectRedSlider.Value = Convert.ToDouble(box.Text);
        }

        private void textbox11_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox box = (TextBox)sender;

            if (box.Text != "")
                SelectGreenSlider.Value = Convert.ToDouble(box.Text);
        }

        private void textbox12_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox box = (TextBox)sender;

            if (box.Text != "")
                SelectBlueSlider.Value = Convert.ToDouble(box.Text);
        }
    }
}

