using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        String[] steps = new String[10];
        int predictedStart = -1;
        int difference = 0;
        Text txt;
        Boolean isOn=true;

        public MainWindow()
        {
            InitializeComponent();
            operateButton.Visibility = Visibility.Hidden;
            settingButton.Visibility = Visibility.Hidden;
            cancelButton.Visibility = Visibility.Hidden;
            onButton.IsEnabled = false;
        }

        SolidColorBrush selectBrush = new SolidColorBrush(Color.FromArgb(30, 0, 0, 255));
        SolidColorBrush predictBrush = new SolidColorBrush(Color.FromArgb(70,0, 255, 0));

        private void CloseClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Move_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }
        private void DoubleClick(object sender, MouseButtonEventArgs e)
        {
            
            if (e.Source == button0) {
                Record.startTime= DateTimeOffset.Now.ToUnixTimeMilliseconds();
                Record.addToOperationList("Open PDF File A", "0");
                PDF pdf = new PDF(0);
               
                //pdf.Check += value => subOperation=value;
                //pdf.CheckTarget += value => subTarget = value;
                //addToOperationList(subOperation, subTarget);

                pdf.Show();
                pdf.Activate();
                pdf.Focus();
                pdf.Topmost = true;
                
                
            } 
            else if (e.Source == button1)
            {
                Record.addToOperationList("Open PDF File A", "1");
                PDF pdf = new PDF(1);
             
                //pdf.Check += value => subOperation = value;
                //pdf.CheckTarget += value => subTarget = value;
                //addToOperationList(subOperation, subTarget);
                pdf.Show();
                pdf.Activate();
                pdf.Focus();
                pdf.Topmost = true;
                
            }
            else if (e.Source == button2)
            {
                Record.addToOperationList("Open PDF File A", "2");
                PDF pdf = new PDF(2);
               
                //pdf.Check += value => subOperation = value;
                //pdf.CheckTarget += value => subTarget = value;
                //addToOperationList(subOperation, subTarget);
                pdf.Show();
                pdf.Activate();
                pdf.Focus();
                pdf.Topmost = true;
                
            }
            else if (e.Source == button3)
            {
                Record.addToOperationList("Open PDF File A", "3");
                PDF pdf = new PDF(3);
            
                //pdf.Check += value => subOperation = value;
                //pdf.CheckTarget += value => subTarget = value;
                //addToOperationList(subOperation, subTarget);
                pdf.Show();
                pdf.Activate();
                pdf.Focus();
                pdf.Topmost = true;
                
            }
            else if (e.Source == button4)
            {
                Record.addToOperationList("Open PDF File A", "4");
                PDF pdf = new PDF(4);
             
                //pdf.Check += value => subOperation = value;
                //pdf.CheckTarget += value => subTarget = value;
                //addToOperationList(subOperation, subTarget);
                pdf.Show();
                pdf.Activate();
                pdf.Focus();
                pdf.Topmost = true;
                
            }
            else if (e.Source == button5)
            {
                Record.addToOperationList("Open PDF File A", "5");
                PDF pdf = new PDF(5);
         
                //pdf.Check += value => subOperation = value;
                //pdf.CheckTarget += value => subTarget = value;
                //addToOperationList(subOperation, subTarget);
                pdf.Show();
                pdf.Activate();
                pdf.Focus();
                pdf.Topmost = true;
                
            }

            else if (e.Source == button6)
            {
                Record.addToOperationList("Open PDF File A", "6");
                PDF pdf = new PDF(6);
             
                //pdf.Check += value => subOperation = value;
                //pdf.CheckTarget += value => subTarget = value;
                //addToOperationList(subOperation, subTarget);
                pdf.Show();
                pdf.Activate();
                pdf.Focus();
                pdf.Topmost = true;
                
            }
            else if (e.Source == button7)
            {
                Record.addToOperationList("Open PDF File A", "7");
                PDF pdf = new PDF(7);
        
                //pdf.Check += value => subOperation = value;
                //pdf.CheckTarget += value => subTarget = value;
                //addToOperationList(subOperation, subTarget);
                pdf.Show();
                pdf.Activate();
                pdf.Focus();
                pdf.Topmost = true;
                
            }
            else if (e.Source == button8)
            {
                Record.addToOperationList("Open PDF File A", "8");
                PDF pdf = new PDF(8);
          
                //pdf.Check += value => subOperation = value;
                //pdf.CheckTarget += value => subTarget = value;
                //addToOperationList(subOperation, subTarget);
                pdf.Show();
                pdf.Activate();
                pdf.Focus();
                pdf.Topmost = true;
                
            }
            else if (e.Source == button9)
            {
                Record.addToOperationList("Open PDF File A", "9");
                PDF pdf = new PDF(9);
         
                //pdf.Check += value => subOperation = value;
                //pdf.CheckTarget += value => subTarget = value;
                //addToOperationList(subOperation, subTarget);
                pdf.Show();
                pdf.Activate();
                pdf.Focus();
                pdf.Topmost = true;
                
            }
            else 
            {
                Record.addToOperationList("Open TXT File", "Untitiled");
                txt = new Text();

                //txt.TXTcheck += value => newOperationTXT = value;

                //Console.WriteLine("******"+newOperationTXT);
                txt.Show();
                txt.Activate();
                txt.Focus();
                txt.Topmost = true;
                //addToOperationList(newOperationTXT, "Untitiled.txt");
            }

        }

        private void Click(object sender, RoutedEventArgs e)
        {
            if (e.Source == button0)
            {
                
                if ((Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control)
                {
                    back0.Fill = selectBrush;
                    Record.addToOperationList("Select", "A1.pdf");
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
                    back10.Fill = Brushes.Transparent;
                }
            }
            else if (e.Source == button1)
            {
                if ((Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control)
                {
                    back1.Fill = selectBrush;
                    Record.addToOperationList("Select", "A2.pdf");
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
                    back10.Fill = Brushes.Transparent;
                }
            }
            else if (e.Source == button2)
            {
                if ((Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control)
                {
                    back2.Fill = selectBrush;
                    Record.addToOperationList("Select", "A3.pdf");
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
                    back10.Fill = Brushes.Transparent;
                }
            }
            else if (e.Source == button3)
            {
                if ((Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control)
                {
                    back3.Fill = selectBrush;
                    Record.addToOperationList("Select", "A4.pdf");
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
                    back10.Fill = Brushes.Transparent;
                }
            }
            else if (e.Source == button4)
            {
                if ((Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control)
                {
                    back4.Fill = selectBrush;
                    Record.addToOperationList("Select", "A5.pdf");
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
                    back10.Fill = Brushes.Transparent;
                }
            }
            else if (e.Source == button5)
            {
                if ((Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control)
                {
                    back5.Fill = selectBrush;
                    Record.addToOperationList("Select", "A6.pdf");
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
                    back10.Fill = Brushes.Transparent;
                }
            }
            else if (e.Source == button6)
            {
                if ((Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control)
                {
                    back6.Fill = selectBrush;
                    Record.addToOperationList("Select", "A7.pdf");
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
                    back10.Fill = Brushes.Transparent;
                }
            }
            else if (e.Source == button7)
            {
                if ((Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control)
                {
                    back7.Fill = selectBrush;
                    Record.addToOperationList("Select", "A8.pdf");
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
                    back10.Fill = Brushes.Transparent;
                }
            }

            else if (e.Source == button8)
            {
                if ((Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control)
                {
                    back8.Fill = selectBrush;
                    Record.addToOperationList("Select", "A9.pdf");
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
                    back10.Fill = Brushes.Transparent;
                }
            }
            else if (e.Source == button9)
            {
                if ((Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control)
                {
                    back9.Fill = selectBrush;
                    Record.addToOperationList("Select", "A10.pdf");
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
                    back10.Fill = Brushes.Transparent;
                }
                
            }
            else if (e.Source == button10)
            {
                if ((Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control)
                {
                    back10.Fill = selectBrush;
                    Record.addToOperationList("Select", "Untitled.pdf");
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
                    back10.Fill = selectBrush;
                }

            }
            else
            {
                Record.addToOperationList("Unselect", "All");
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
                back10.Fill = Brushes.Transparent;
            }

            //for (int i = 0; i < 20; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {
            //        if (operations[i, j] != "Null")
            //        {
            //            Console.Write(operations[i, j]);

            //        }


            //    }
            //}
            //Console.WriteLine();

        }

        private void ApplyClick(object sender, RoutedEventArgs e)
        {
            //TO-DO：automatically copy all
            ArrayList files = new ArrayList();
            ArrayList types = new ArrayList();
            int preType=-1;
            for (int i = 0; (predictedStart + i * difference) < 10; i++)
            {
                files.Add(predictedStart + i * difference);
            }
            for (int i = 0; i < 10; i++)
            {
                //Console.WriteLine("steps!!!!" + steps[i]);
               
                    if (steps[i].Contains("title"))
                    {
                        //titleFlag  = true;
                        types.Add("title");
                    }
                    if (steps[i].Contains("abstract"))
                    {
                        //abstractFlag = true;
                        types.Add("abstract");
                    }
                    if (steps[i].Contains("content0"))
                    {
                        //content0Flag = true;
                        types.Add("content0");
                    }
                    if (steps[i].Contains("content1"))
                    {
                        //content1Flag = true;
                        types.Add("content1");
                    }
                if (steps[i].Contains("#."))
                {
                    preType = 0;
                }
                else if (steps[i].Contains("CHAR."))
                {
                    preType = 1;
                }
                else if (steps[i].Contains("char."))
                {
                    preType = 2;
                }

            }
            operateButton.Visibility = Visibility.Hidden;
            settingButton.Visibility = Visibility.Hidden;
            cancelButton.Visibility = Visibility.Hidden;
            Record.previousContent = txt.content.Text;
            txt.Close();
            Text autoTXT = new Text(files, types, preType);
            autoTXT.Show();
            autoTXT.Activate();
            autoTXT.Focus();
            autoTXT.Topmost = true;

            Information newInformation = new Information(autoTXT);
            newInformation.Owner = autoTXT;
            newInformation.Show();
            newInformation.Activate();
            newInformation.Focus();
            newInformation.Topmost = true;
            

        }

        private void SettingClick(object sender, RoutedEventArgs e)
        {
            //TO-DO: create instence based on the list of actions detected.
            operateButton.Visibility = Visibility.Hidden;
            settingButton.Visibility = Visibility.Hidden;
            cancelButton.Visibility = Visibility.Hidden;
            Settings newSettings = new Settings(steps,predictedStart,difference, txt);
            //newSettings.Settingscheck += value => SettingsIsOpened = value;
            newSettings.Show();
            newSettings.Activate();
            newSettings.Focus();
            newSettings.Topmost = true;
            
        }


        private void showMenu(int predictTarget)
        {
            if (predictTarget == 0)
            {
                operateButton.Margin = new Thickness(287, 303, 0, 0);
                settingButton.Margin = new Thickness(287, 346, 0, 0);
                cancelButton.Margin = new Thickness(287, 389, 0, 0);
                active0.Fill = predictBrush;
                active1.Fill = Brushes.Transparent;
                active2.Fill = Brushes.Transparent;
                active3.Fill = Brushes.Transparent;
                active4.Fill = Brushes.Transparent;
                active5.Fill = Brushes.Transparent;
                active6.Fill = Brushes.Transparent;
                active7.Fill = Brushes.Transparent;
                active8.Fill = Brushes.Transparent;
                active9.Fill = Brushes.Transparent;
                active10.Fill = Brushes.Transparent;
                operateButton.Visibility = Visibility.Visible;
                settingButton.Visibility = Visibility.Visible;
                cancelButton.Visibility = Visibility.Visible;


            }
            else if (predictTarget == 1)
            {
                operateButton.Margin = new Thickness(436, 303, 0, 0);
                settingButton.Margin = new Thickness(436, 346, 0, 0);
                cancelButton.Margin = new Thickness(436, 389, 0, 0);
                active1.Fill = predictBrush;
                active0.Fill = Brushes.Transparent;
                active2.Fill = Brushes.Transparent;
                active3.Fill = Brushes.Transparent;
                active4.Fill = Brushes.Transparent;
                active5.Fill = Brushes.Transparent;
                active6.Fill = Brushes.Transparent;
                active7.Fill = Brushes.Transparent;
                active8.Fill = Brushes.Transparent;
                active9.Fill = Brushes.Transparent;
                active10.Fill = Brushes.Transparent;
                operateButton.Visibility = Visibility.Visible;
                settingButton.Visibility = Visibility.Visible;
                cancelButton.Visibility = Visibility.Visible;

            }
            else if (predictTarget ==2)
            {
                operateButton.Margin = new Thickness(590, 303, 0, 0);
                settingButton.Margin = new Thickness(590, 346, 0, 0);
                cancelButton.Margin = new Thickness(590, 389, 0, 0);
                active2.Fill = predictBrush;
                active1.Fill = Brushes.Transparent;
                active0.Fill = Brushes.Transparent;
                active3.Fill = Brushes.Transparent;
                active4.Fill = Brushes.Transparent;
                active5.Fill = Brushes.Transparent;
                active6.Fill = Brushes.Transparent;
                active7.Fill = Brushes.Transparent;
                active8.Fill = Brushes.Transparent;
                active9.Fill = Brushes.Transparent;
                active10.Fill = Brushes.Transparent;
                operateButton.Visibility = Visibility.Visible;
                settingButton.Visibility = Visibility.Visible;
                cancelButton.Visibility = Visibility.Visible;
            }
            else if (predictTarget ==3)
            {
                operateButton.Margin = new Thickness(740, 303, 0, 0);
                settingButton.Margin = new Thickness(740, 346, 0, 0);
                cancelButton.Margin = new Thickness(740, 389, 0, 0);
                active3.Fill = predictBrush;
                active1.Fill = Brushes.Transparent;
                active2.Fill = Brushes.Transparent;
                active0.Fill = Brushes.Transparent;
                active4.Fill = Brushes.Transparent;
                active5.Fill = Brushes.Transparent;
                active6.Fill = Brushes.Transparent;
                active7.Fill = Brushes.Transparent;
                active8.Fill = Brushes.Transparent;
                active9.Fill = Brushes.Transparent;
                active10.Fill = Brushes.Transparent;
                operateButton.Visibility = Visibility.Visible;
                settingButton.Visibility = Visibility.Visible;
                cancelButton.Visibility = Visibility.Visible;
            }
            else if (predictTarget == 4)
            {
                operateButton.Margin = new Thickness(886, 303, 0, 0);
                settingButton.Margin = new Thickness(886, 346, 0, 0);
                cancelButton.Margin = new Thickness(886, 389, 0, 0);
                active4.Fill = predictBrush;
                active1.Fill = Brushes.Transparent;
                active2.Fill = Brushes.Transparent;
                active3.Fill = Brushes.Transparent;
                active0.Fill = Brushes.Transparent;
                active5.Fill = Brushes.Transparent;
                active6.Fill = Brushes.Transparent;
                active7.Fill = Brushes.Transparent;
                active8.Fill = Brushes.Transparent;
                active9.Fill = Brushes.Transparent;
                active10.Fill = Brushes.Transparent;
                operateButton.Visibility = Visibility.Visible;
                settingButton.Visibility = Visibility.Visible;
                cancelButton.Visibility = Visibility.Visible;
            }
            else if (predictTarget == 5)
            {
                operateButton.Margin = new Thickness(1040, 303, 0, 0);
                settingButton.Margin = new Thickness(1040, 346, 0, 0);
                cancelButton.Margin = new Thickness(1040, 389, 0, 0);
                active5.Fill = predictBrush;
                active1.Fill = Brushes.Transparent;
                active2.Fill = Brushes.Transparent;
                active3.Fill = Brushes.Transparent;
                active4.Fill = Brushes.Transparent;
                active0.Fill = Brushes.Transparent;
                active6.Fill = Brushes.Transparent;
                active7.Fill = Brushes.Transparent;
                active8.Fill = Brushes.Transparent;
                active9.Fill = Brushes.Transparent;
                active10.Fill = Brushes.Transparent;
                operateButton.Visibility = Visibility.Visible;
                settingButton.Visibility = Visibility.Visible;
                cancelButton.Visibility = Visibility.Visible;
            }
            else if (predictTarget == 6)
            {
                operateButton.Margin = new Thickness(1188, 303, 0, 0);
                settingButton.Margin = new Thickness(1188, 346, 0, 0);
                cancelButton.Margin = new Thickness(1188, 389, 0, 0);
                active6.Fill = predictBrush;
                active1.Fill = Brushes.Transparent;
                active2.Fill = Brushes.Transparent;
                active3.Fill = Brushes.Transparent;
                active4.Fill = Brushes.Transparent;
                active5.Fill = Brushes.Transparent;
                active0.Fill = Brushes.Transparent;
                active7.Fill = Brushes.Transparent;
                active8.Fill = Brushes.Transparent;
                active9.Fill = Brushes.Transparent;
                active10.Fill = Brushes.Transparent;
                operateButton.Visibility = Visibility.Visible;
                settingButton.Visibility = Visibility.Visible;
                cancelButton.Visibility = Visibility.Visible;
            }
            else if (predictTarget == 7)
            {
                operateButton.Margin = new Thickness(1328, 303, 0, 0);
                settingButton.Margin = new Thickness(1328, 346, 0, 0);
                cancelButton.Margin = new Thickness(1328, 389, 0, 0);
                active7.Fill = predictBrush;
                active1.Fill = Brushes.Transparent;
                active2.Fill = Brushes.Transparent;
                active3.Fill = Brushes.Transparent;
                active4.Fill = Brushes.Transparent;
                active5.Fill = Brushes.Transparent;
                active6.Fill = Brushes.Transparent;
                active0.Fill = Brushes.Transparent;
                active8.Fill = Brushes.Transparent;
                active9.Fill = Brushes.Transparent;
                active10.Fill = Brushes.Transparent;
                operateButton.Visibility = Visibility.Visible;
                settingButton.Visibility = Visibility.Visible;
                cancelButton.Visibility = Visibility.Visible;
            }
            else if (predictTarget ==8)
            {
                operateButton.Margin = new Thickness(287, 451, 0, 0);
                settingButton.Margin = new Thickness(287, 494, 0, 0);
                cancelButton.Margin = new Thickness(287, 527, 0, 0);
                active8.Fill = predictBrush;
                active1.Fill = Brushes.Transparent;
                active2.Fill = Brushes.Transparent;
                active3.Fill = Brushes.Transparent;
                active4.Fill = Brushes.Transparent;
                active5.Fill = Brushes.Transparent;
                active6.Fill = Brushes.Transparent;
                active7.Fill = Brushes.Transparent;
                active0.Fill = Brushes.Transparent;
                active9.Fill = Brushes.Transparent;
                active10.Fill = Brushes.Transparent;
                operateButton.Visibility = Visibility.Visible;
                settingButton.Visibility = Visibility.Visible;
                cancelButton.Visibility = Visibility.Visible;
            }
            else if (predictTarget == 9)
            {
                operateButton.Margin = new Thickness(436, 451, 0, 0);
                settingButton.Margin = new Thickness(436, 494, 0, 0);
                cancelButton.Margin = new Thickness(436, 527, 0, 0);
                active9.Fill = predictBrush;
                active1.Fill = Brushes.Transparent;
                active2.Fill = Brushes.Transparent;
                active3.Fill = Brushes.Transparent;
                active4.Fill = Brushes.Transparent;
                active5.Fill = Brushes.Transparent;
                active6.Fill = Brushes.Transparent;
                active7.Fill = Brushes.Transparent;
                active8.Fill = Brushes.Transparent;
                active0.Fill = Brushes.Transparent;
                active10.Fill = Brushes.Transparent;
                operateButton.Visibility = Visibility.Visible;
                settingButton.Visibility = Visibility.Visible;
                cancelButton.Visibility = Visibility.Visible;
            }

        }

        private void MainActivated(object sender, EventArgs e)
        {

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (Record.operations[i, j] != "Null")
                    {
                        Console.Write(Record.operations[i, j]+"; ");

                    }


                }
            }
            Console.WriteLine();
            //if (SettingsIsOpened == false)
            //{
            //}
            if (isOn)
            {
                CheckPattern();
            }
            
        }

        private void CheckPattern()
        {
            Boolean operationFlag = false;
            difference = 0;
            predictedStart = -1;
            int largestStep = 0;
            for (int i = 10; i >1; i--) {
                for (int j = 0; j< i; j++)
                {
                    if (Record.operations[19 - j, 0] == Record.operations[19 - i - j, 0])
                    {
                        operationFlag = true;
                        if (Record.operations[19 - j, 0] == "Open PDF File A")
                        {
                            difference = int.Parse(Record.operations[19 - j, 1]) - int.Parse(Record.operations[19 -i -j, 1]);
                            if (difference < 0)
                            {
                                operationFlag = false;
                            }
                            predictedStart = int.Parse(Record.operations[19 - j, 1]) + difference;
                        }    
                    }
                    else
                    {
                        operationFlag = false;
                    }
                    Console.WriteLine("*"+operationFlag);
                }
                if (operationFlag == true&&difference!=0)
                {
                    largestStep = i + 1;
                    Console.WriteLine(i + "***" + operationFlag);
                    Console.WriteLine(difference + "***" );
                    for (int x = 0; x < largestStep-1; x++)
                    {
                        if (Regex.IsMatch(Record.operations[19 - x, 1], @"^[+-]?\d*$"))
                        {
                            steps[largestStep - 2 - x] = Record.operations[19 - x, 0] + " " + "file";
                        }
                        else if (Record.operations[19 - x, 1] == "2.")
                        {
                            steps[largestStep - 2 - x] = Record.operations[19 - x, 0] + " " + "#.";
                        }
                        else if (Record.operations[19 - x, 1] == "b.")
                        {
                            steps[largestStep - 2 - x] = Record.operations[19 - x, 0] + " " + "char.";
                        }
                        else if (Record.operations[19 - x, 1] == "B.")
                        {
                            steps[largestStep - 2 - x] = Record.operations[19 - x, 0] + " " + "CHAR.";
                        }
                        else
                        {
                            steps[largestStep - 2 - x] = Record.operations[19 - x, 0] + " " + Record.operations[19 - x, 1];
                        }
                        
                    }
                    for (int y = largestStep-1; y < 10; y++)
                    {
                        steps[y] = "Null";
                    }
                    showMenu(predictedStart);

                    //unselectButton.IsEnabled = false;
                    break;
                }
                
            }
        }

        private void UndoKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Z)
            {
                Record.deleteFromOperationList();
            }
            else if (e.Key == Key.C)
            {
                CancelClick(cancelButton, new RoutedEventArgs());
            }
            else if (e.Key == Key.S)
            {
                if (isOn)
                {
                    AppOffClick(offButton, new RoutedEventArgs());
                }
                else
                {
                    AppOnClick(onButton, new RoutedEventArgs());
                  
                }
            }
        }

        private void CancelClick(object sender, RoutedEventArgs e)
        {
            active8.Fill = Brushes.Transparent;
            active1.Fill = Brushes.Transparent;
            active2.Fill = Brushes.Transparent;
            active3.Fill = Brushes.Transparent;
            active4.Fill = Brushes.Transparent;
            active5.Fill = Brushes.Transparent;
            active6.Fill = Brushes.Transparent;
            active7.Fill = Brushes.Transparent;
            active0.Fill = Brushes.Transparent;
            active9.Fill = Brushes.Transparent;
            active10.Fill = Brushes.Transparent;
            operateButton.Visibility = Visibility.Hidden;
            settingButton.Visibility = Visibility.Hidden;
            cancelButton.Visibility = Visibility.Hidden;
        }

        private void AppOnClick(object sender, RoutedEventArgs e)
        {
            isOn = true;
            onButton.IsEnabled = false;
            offButton.IsEnabled = true;
            Record.clearOperations();
        }

        private void AppOffClick(object sender, RoutedEventArgs e)
        {
            isOn = false;
            onButton.IsEnabled = true;
            offButton.IsEnabled = false;
            
        }

        private void OpenCustomize(object sender, RoutedEventArgs e)
        {
            Customize customize = new Customize();
            customize.Show();
            customize.Activate();
            customize.Focus();
            customize.Topmost = true;
        }
    }

}
