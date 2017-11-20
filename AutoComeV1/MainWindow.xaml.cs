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
        String[,] operations = new String[20, 2];

        public MainWindow()
        {
            InitializeComponent();
            
            showMenu("A4.pdf");
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    operations[i,j] = "Null";
                }
            }
            //operations = passedOperations;
        }
       
        //Color color = Color.FromArgb(50, 0, 0, 255);
        SolidColorBrush selectBrush = new SolidColorBrush(Color.FromArgb(30, 0, 0, 255));

        private void DoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (e.Source == button0) {
                PDF pdf = new PDF(0, operations);
                pdf.Check += value => operations = value;

                pdf.Show();
                pdf.Activate();
                pdf.Focus();
                pdf.Topmost = true;
                addToOperationList("Open PDF File","A1.pdf");
            } 
            else if (e.Source == button1)
            {
                PDF pdf = new PDF(1, operations);
                pdf.Show();
                pdf.Activate();
                pdf.Focus();
                pdf.Topmost = true;
                addToOperationList("Open PDF File", "A2.pdf");
            }
            else if (e.Source == button2)
            {
                PDF pdf = new PDF(2, operations);
                pdf.Show();
                pdf.Activate();
                pdf.Focus();
                pdf.Topmost = true;
                addToOperationList("Open PDF File", "A3.pdf");
            }
            else if (e.Source == button3)
            {
                PDF pdf = new PDF(3, operations);
                pdf.Show();
                pdf.Activate();
                pdf.Focus();
                pdf.Topmost = true;
                addToOperationList("Open PDF File", "A4.pdf");
            }
            else if (e.Source == button4)
            {
                PDF pdf = new PDF(4, operations);
                pdf.Show();
                pdf.Activate();
                pdf.Focus();
                pdf.Topmost = true;
                addToOperationList("Open PDF File", "A5.pdf");
            }
            else if (e.Source == button5)
            {
                PDF pdf = new PDF(5, operations);
                pdf.Show();
                pdf.Activate();
                pdf.Focus();
                pdf.Topmost = true;
                addToOperationList("Open PDF File", "A6.pdf");
            }

            else if (e.Source == button6)
            {
                PDF pdf = new PDF(6, operations);
                pdf.Show();
                pdf.Activate();
                pdf.Focus();
                pdf.Topmost = true;
                addToOperationList("Open PDF File", "A7.pdf");
            }
            else if (e.Source == button7)
            {
                PDF pdf = new PDF(7, operations);
                pdf.Show();
                pdf.Activate();
                pdf.Focus();
                pdf.Topmost = true;
                addToOperationList("Open PDF File", "A8.pdf");
            }
            else if (e.Source == button8)
            {
                PDF pdf = new PDF(8, operations);
                pdf.Show();
                pdf.Activate();
                pdf.Focus();
                pdf.Topmost = true;
                addToOperationList("Open PDF File", "A9.pdf");
            }
            else 
            {
                PDF pdf = new PDF(9, operations);
                pdf.Show();
                pdf.Activate();
                pdf.Focus();
                pdf.Topmost = true;
                addToOperationList("Open PDF File", "A10.pdf");
            }

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine(operations[i, j]);
                }
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
                    addToOperationList("Select", "A1.pdf");
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
                    addToOperationList("Select", "A2.pdf");
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
                    addToOperationList("Select", "A3.pdf");
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
                    addToOperationList("Select", "A4.pdf");
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
                    addToOperationList("Select", "A5.pdf");
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
                    addToOperationList("Select", "A6.pdf");
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
                    addToOperationList("Select", "A7.pdf");
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
                    addToOperationList("Select", "A8.pdf");
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
                    addToOperationList("Select", "A9.pdf");
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
                    addToOperationList("Select", "A10.pdf");
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
                addToOperationList("Unselect", "All");
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

            for (int i = 0; i < 20; i++)
            {
                for (int j=0;j<2;j++)
                {
                    Console.WriteLine(operations[i,j]);
                }
            }
            
        }

        private void ApplyClick(object sender, RoutedEventArgs e)
        {
           //TO-DO：automatically copy all
        }

        private void SettingClick(object sender, RoutedEventArgs e)
        {
            //TO-DO: create instence based on the list of actions detected.
            Settings newSettings = new Settings("Open a PDF file","Highlight the title", "Copy the highlight part (Ctrl+C)","Paste to Untitiled.txt","Close the PDF file","Null");
            newSettings.Show();
            newSettings.Activate();
            newSettings.Focus();
            newSettings.Topmost = true;
        }

        private void addToOperationList(String newOperaton, String newTarget)
        {
            for (int i = 0; i < 19; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    operations[i,j] = operations[i + 1,j];
                }
                
            }
            operations[19,0] = newOperaton;
            operations[19, 1] = newTarget;
        }

        private void showMenu(String predictTarget)
        {
            if (predictTarget == "A1.pdf")
            {
                operateButton.Margin = new Thickness(287, 303, 0, 0);
                settingButton.Margin = new Thickness(287, 346, 0, 0);
            }
            else if (predictTarget == "A2.pdf")
            {
                operateButton.Margin = new Thickness(436, 303, 0, 0);
                settingButton.Margin = new Thickness(436, 346, 0, 0);
            }
            else if (predictTarget == "A3.pdf")
            {
                operateButton.Margin = new Thickness(590, 303, 0, 0);
                settingButton.Margin = new Thickness(590, 346, 0, 0);
            }
            else if (predictTarget == "A4.pdf")
            {
                operateButton.Margin = new Thickness(740, 303, 0, 0);
                settingButton.Margin = new Thickness(740, 346, 0, 0);
            }
            else if (predictTarget == "A5.pdf")
            {
                operateButton.Margin = new Thickness(886, 303, 0, 0);
                settingButton.Margin = new Thickness(886, 346, 0, 0);
            }
            else if (predictTarget == "A6.pdf")
            {
                operateButton.Margin = new Thickness(1040, 303, 0, 0);
                settingButton.Margin = new Thickness(1040, 346, 0, 0);
            }
            else if (predictTarget == "A7.pdf")
            {
                operateButton.Margin = new Thickness(1188, 303, 0, 0);
                settingButton.Margin = new Thickness(1188, 346, 0, 0);
            }
            else if (predictTarget == "A8.pdf")
            {
                operateButton.Margin = new Thickness(1328, 303, 0, 0);
                settingButton.Margin = new Thickness(1328, 346, 0, 0);
            }
            else if (predictTarget == "A9.pdf")
            {
                operateButton.Margin = new Thickness(287, 451, 0, 0);
                settingButton.Margin = new Thickness(287, 494, 0, 0);
            }
            else if (predictTarget == "A10.pdf")
            {
                operateButton.Margin = new Thickness(436, 451, 0, 0);
                settingButton.Margin = new Thickness(436, 494, 0, 0);
            }

        }
    }

}
