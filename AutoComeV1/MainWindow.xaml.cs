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
using System.Windows.Threading;

namespace AutoComeV1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        //int i = 0;
        public MainWindow()
        {
            InitializeComponent();
        }
       
        //Color color = Color.FromArgb(50, 0, 0, 255);
        SolidColorBrush selectBrush = new SolidColorBrush(Color.FromArgb(30, 0, 0, 255));

        private void DoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (e.Source == button0) {
                PDF pdf = new PDF(0);
                pdf.Show();
                pdf.Activate();
                pdf.Focus();
                pdf.Topmost = true;
            }
            else if (e.Source == button1)
            {
                PDF pdf = new PDF(1);
                pdf.Show();
                pdf.Activate();
                pdf.Focus();
                pdf.Topmost = true;
            }
            else if (e.Source == button2)
            {
                PDF pdf = new PDF(2);
                pdf.Show();
                pdf.Activate();
                pdf.Focus();
                pdf.Topmost = true;
            }
            else if (e.Source == button3)
            {
                PDF pdf = new PDF(3);
                pdf.Show();
                pdf.Activate();
                pdf.Focus();
                pdf.Topmost = true;
            }
            else if (e.Source == button4)
            {
                PDF pdf = new PDF(4);
                pdf.Show();
                pdf.Activate();
                pdf.Focus();
                pdf.Topmost = true;
            }
            else if (e.Source == button5)
            {
                PDF pdf = new PDF(5);
                pdf.Show();
                pdf.Activate();
                pdf.Focus();
                pdf.Topmost = true;
            }
            else if (e.Source == button6)
            {
                PDF pdf = new PDF(6);
                pdf.Show();
                pdf.Activate();
                pdf.Focus();
                pdf.Topmost = true;
            }
            else if (e.Source == button7)
            {
                PDF pdf = new PDF(7);
                pdf.Show();
                pdf.Activate();
                pdf.Focus();
                pdf.Topmost = true;
            }
            else if (e.Source == button8)
            {
                PDF pdf = new PDF(8);
                pdf.Show();
                pdf.Activate();
                pdf.Focus();
                pdf.Topmost = true;
            }
            else 
            {
                PDF pdf = new PDF(9);
                pdf.Show();
                pdf.Activate();
                pdf.Focus();
                pdf.Topmost = true;
            }
            //back0.Fill = Brushes.Black;
            //PDF pdf = new PDF();
            //pdf.Show();
            //pdf.Activate();
            //pdf.Focus();
            //pdf.Topmost = true;
            //{
            //    i += 1;
            //    DispatcherTimer timer = new DispatcherTimer();
            //    timer.Interval = new TimeSpan(0, 0, 0, 0, 300);
            //    timer.Tick += (s, e1) => { timer.IsEnabled = false; i = 0; };
            //    timer.IsEnabled = true;
            //    if (i == 2)
            //    {
            //        timer.IsEnabled = false;
            //        i = 0;
            //        /*button0.Background = myBrush;*/
            //    }
            //}
        }

        private void Click(object sender, RoutedEventArgs e)
        {
            if (e.Source == button0)
            {
                if ((Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control)
                {
                    back0.Fill = selectBrush;
                }
                else
                {
                    back0.Fill = selectBrush;
                    back1.Fill = Brushes.Transparent;
                    back2.Fill = Brushes.Transparent;
                    back3.Fill = Brushes.Transparent;
                    back4.Fill = Brushes.Transparent;
                    back5.Fill = Brushes.Transparent;
                    back6.Fill = Brushes.Transparent;
                    back7.Fill = Brushes.Transparent;
                    back8.Fill = Brushes.Transparent;
                    back9.Fill = Brushes.Transparent;
                }
            }
            else if (e.Source == button1)
            {
                if ((Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control)
                {
                    back1.Fill = selectBrush;
                }
                else
                {
                    back0.Fill = Brushes.Transparent;
                    back1.Fill = selectBrush;
                    back2.Fill = Brushes.Transparent;
                    back3.Fill = Brushes.Transparent;
                    back4.Fill = Brushes.Transparent;
                    back5.Fill = Brushes.Transparent;
                    back6.Fill = Brushes.Transparent;
                    back7.Fill = Brushes.Transparent;
                    back8.Fill = Brushes.Transparent;
                    back9.Fill = Brushes.Transparent;
                }
            }
            else if (e.Source == button2)
            {
                if ((Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control)
                {
                    back2.Fill = selectBrush;
                }
                else
                {
                    back0.Fill = Brushes.Transparent;
                    back1.Fill = Brushes.Transparent;
                    back2.Fill = selectBrush;
                    back3.Fill = Brushes.Transparent;
                    back4.Fill = Brushes.Transparent;
                    back5.Fill = Brushes.Transparent;
                    back6.Fill = Brushes.Transparent;
                    back7.Fill = Brushes.Transparent;
                    back8.Fill = Brushes.Transparent;
                    back9.Fill = Brushes.Transparent;
                }
            }
            else if (e.Source == button3)
            {
                if ((Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control)
                {
                    back3.Fill = selectBrush;
                }
                else
                {
                    back0.Fill = Brushes.Transparent;
                    back1.Fill = Brushes.Transparent;
                    back2.Fill = Brushes.Transparent;
                    back3.Fill = selectBrush;
                    back4.Fill = Brushes.Transparent;
                    back5.Fill = Brushes.Transparent;
                    back6.Fill = Brushes.Transparent;
                    back7.Fill = Brushes.Transparent;
                    back8.Fill = Brushes.Transparent;
                    back9.Fill = Brushes.Transparent;
                }
            }
            else if (e.Source == button4)
            {
                if ((Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control)
                {
                    back4.Fill = selectBrush;
                }
                else
                {
                    back0.Fill = Brushes.Transparent;
                    back1.Fill = Brushes.Transparent;
                    back2.Fill = Brushes.Transparent;
                    back3.Fill = Brushes.Transparent;
                    back4.Fill = selectBrush;
                    back5.Fill = Brushes.Transparent;
                    back6.Fill = Brushes.Transparent;
                    back7.Fill = Brushes.Transparent;
                    back8.Fill = Brushes.Transparent;
                    back9.Fill = Brushes.Transparent;
                }
            }
            else if (e.Source == button5)
            {
                if ((Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control)
                {
                    back5.Fill = selectBrush;
                }
                else
                {
                    back0.Fill = Brushes.Transparent;
                    back1.Fill = Brushes.Transparent;
                    back2.Fill = Brushes.Transparent;
                    back3.Fill = Brushes.Transparent;
                    back4.Fill = Brushes.Transparent;
                    back5.Fill = selectBrush;
                    back6.Fill = Brushes.Transparent;
                    back7.Fill = Brushes.Transparent;
                    back8.Fill = Brushes.Transparent;
                    back9.Fill = Brushes.Transparent;
                }
            }
            else if (e.Source == button6)
            {
                if ((Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control)
                {
                    back6.Fill = selectBrush;
                }
                else
                {
                    back0.Fill = Brushes.Transparent;
                    back1.Fill = Brushes.Transparent;
                    back2.Fill = Brushes.Transparent;
                    back3.Fill = Brushes.Transparent;
                    back4.Fill = Brushes.Transparent;
                    back5.Fill = Brushes.Transparent;
                    back6.Fill = selectBrush;
                    back7.Fill = Brushes.Transparent;
                    back8.Fill = Brushes.Transparent;
                    back9.Fill = Brushes.Transparent;
                }
            }
            else if (e.Source == button7)
            {
                if ((Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control)
                {
                    back7.Fill = selectBrush;
                }
                else
                {
                    back0.Fill = Brushes.Transparent;
                    back1.Fill = Brushes.Transparent;
                    back2.Fill = Brushes.Transparent;
                    back3.Fill = Brushes.Transparent;
                    back4.Fill = Brushes.Transparent;
                    back5.Fill = Brushes.Transparent;
                    back6.Fill = Brushes.Transparent;
                    back7.Fill = selectBrush;
                    back8.Fill = Brushes.Transparent;
                    back9.Fill = Brushes.Transparent;
                }
            }

            else if (e.Source == button8)
            {
                if ((Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control)
                {
                    back8.Fill = selectBrush;
                }
                else
                {
                    back0.Fill = Brushes.Transparent;
                    back1.Fill = Brushes.Transparent;
                    back2.Fill = Brushes.Transparent;
                    back3.Fill = Brushes.Transparent;
                    back4.Fill = Brushes.Transparent;
                    back5.Fill = Brushes.Transparent;
                    back6.Fill = Brushes.Transparent;
                    back7.Fill = Brushes.Transparent;
                    back8.Fill = selectBrush;
                    back9.Fill = Brushes.Transparent;
                }
            }
            else if (e.Source == button9)
            {
                if ((Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control)
                {
                    back9.Fill = selectBrush;
                }
                else
                {
                    back0.Fill = Brushes.Transparent;
                    back1.Fill = Brushes.Transparent;
                    back2.Fill = Brushes.Transparent;
                    back3.Fill = Brushes.Transparent;
                    back4.Fill = Brushes.Transparent;
                    back5.Fill = Brushes.Transparent;
                    back6.Fill = Brushes.Transparent;
                    back7.Fill = Brushes.Transparent;
                    back8.Fill = Brushes.Transparent;
                    back9.Fill = selectBrush;
                }
                
            }
            else
            {
                back0.Fill = Brushes.Transparent;
                back1.Fill = Brushes.Transparent;
                back2.Fill = Brushes.Transparent;
                back3.Fill = Brushes.Transparent;
                back4.Fill = Brushes.Transparent;
                back5.Fill = Brushes.Transparent;
                back6.Fill = Brushes.Transparent;
                back7.Fill = Brushes.Transparent;
                back8.Fill = Brushes.Transparent;
                back9.Fill = Brushes.Transparent;
            }

        }

        private void ApplyClick(object sender, RoutedEventArgs e)
        {
           //TO-DO：automatically copy all
        }

        private void SettingClick(object sender, RoutedEventArgs e)
        {
            Settings newSettings = new Settings("Open a PDF file","Highlight the title", "Copy the highlight part (Ctrl+C)","Paste to Untitiled.txt","Close the PDF file","Null");
            newSettings.Show();
            newSettings.Activate();
            newSettings.Focus();
            newSettings.Topmost = true;
        }
    }

}
