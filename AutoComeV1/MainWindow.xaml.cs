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
                back0.Fill = selectBrush;
            }
            else if (e.Source == button1)
            {
                back1.Fill = selectBrush;
            }
            else if (e.Source == button2)
            {
                back2.Fill = selectBrush;
            }
            else if (e.Source == button3)
            {
                back3.Fill = selectBrush;
            }
            else if (e.Source == button4)
            {
                back4.Fill = selectBrush;
            }
            else if (e.Source == button5)
            {
                back5.Fill = selectBrush;
            }
            else if (e.Source == button6)
            {
                back6.Fill = selectBrush;
            }
            else if (e.Source == button7)
            {
                back7.Fill = selectBrush;
            }

            else if (e.Source == button8)
            {
                back8.Fill = selectBrush;
            }
            else
            {
                back9.Fill = selectBrush;
            }

        }


    }

}
