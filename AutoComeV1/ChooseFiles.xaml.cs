using System;
using System.Collections;
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

namespace AutoComeV1
{
    /// <summary>
    /// ChooseFiles.xaml 的交互逻辑
    /// </summary>
    public partial class ChooseFiles : Window
    {
        SolidColorBrush selectBrush = new SolidColorBrush(Color.FromArgb(30, 0, 0, 255));
        //SolidColorBrush predictBrush = new SolidColorBrush(Color.FromArgb(70, 0, 255, 0));
        ArrayList files = new ArrayList();
        public event Action<ArrayList> FilesCheck;
        Settings settingNow;
        public ChooseFiles(Settings setting)
        {
            InitializeComponent();
            settingNow = setting;
        }
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
        //private void DoubleClick(object sender, RoutedEventArgs e)
        //{
        //    if (e.Source==button0)
        //    {
        //        files.Clear();
        //        files.Add(0);
        //    }
        //    else if (e.Source == button1)
        //    {
        //        files.Clear();
        //        files.Add(1);
        //    }
        //    else if (e.Source == button2)
        //    {
        //        files.Clear();
        //        files.Add(2);
        //    }
        //    else if (e.Source == button3)
        //    {
        //        files.Clear();
        //        files.Add(3);
        //    }
        //    else if (e.Source == button4)
        //    {
        //        files.Clear();
        //        files.Add(4);
        //    }
        //    else if (e.Source == button5)
        //    {
        //        files.Clear();
        //        files.Add(5);
        //    }
        //    else if (e.Source == button6)
        //    {
        //        files.Clear();
        //        files.Add(6);
        //    }
        //    else if (e.Source == button7)
        //    {
        //        files.Clear();
        //        files.Add(7);
        //    }
        //    else if (e.Source == button8)
        //    {
        //        files.Clear();
        //        files.Add(8);
        //    }
        //    else if (e.Source == button9)
        //    {
        //        files.Clear();
        //        files.Add(9);
        //    }
        //}
        private void Click(object sender, RoutedEventArgs e)
        {
            if (e.Source == button0)
            {

                if ((Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control)
                {
                    if (!files.Contains(0))
                    {
                        back0.Fill = selectBrush;
                        files.Add(0);
                    }
                    else
                    {
                        back0.Fill = Brushes.Transparent;
                        files.Remove(0);
                    }
                    //Record.addToOperationList("Select", "A1.pdf");
                }
                else
                {
                    files.Clear();
                    files.Add(0);
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
                    //back10.Fill = Brushes.Transparent;
                }
            }
            else if (e.Source == button1)
            {
                if ((Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control)
                {
                    if (!files.Contains(1))
                    {
                        back1.Fill = selectBrush;
                        files.Add(1);
                    }
                    else
                    {
                        back1.Fill = Brushes.Transparent;
                        files.Remove(1);
                    }
                    //Record.addToOperationList("Select", "A2.pdf");
                }
                else
                {
                    files.Clear();
                    files.Add(1);
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
                    //back10.Fill = Brushes.Transparent;
                }
            }
            else if (e.Source == button2)
            {
                if ((Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control)
                {
                    if (!files.Contains(2))
                    {
                        back2.Fill = selectBrush;
                        files.Add(2);
                    }
                    else
                    {
                        back2.Fill = Brushes.Transparent;
                        files.Remove(2);
                    }
                    //Record.addToOperationList("Select", "A3.pdf");
                }
                else
                {
                    files.Clear();
                    files.Add(2);
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
                    //back10.Fill = Brushes.Transparent;
                }
            }
            else if (e.Source == button3)
            {
                if ((Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control)
                {
                    if (!files.Contains(3))
                    {
                        back3.Fill = selectBrush;
                        files.Add(3);
                    }
                    else
                    {
                        back3.Fill = Brushes.Transparent;
                        files.Remove(3);
                    }
                    // Record.addToOperationList("Select", "A4.pdf");
                }
                else
                {
                    files.Clear();
                    files.Add(3);
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
                    //back10.Fill = Brushes.Transparent;
                }
            }
            else if (e.Source == button4)
            {
                if ((Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control)
                {
                    if (!files.Contains(4))
                    {
                        back4.Fill = selectBrush;
                        files.Add(4);
                    }
                    else
                    {
                        back4.Fill = Brushes.Transparent;
                        files.Remove(4);
                    }
                    //Record.addToOperationList("Select", "A5.pdf");
                }
                else
                {
                    files.Clear();
                    files.Add(4);
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
                    //back10.Fill = Brushes.Transparent;
                }
            }
            else if (e.Source == button5)
            {
                if ((Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control)
                {
                    if (!files.Contains(5))
                    {
                        back5.Fill = selectBrush;
                        files.Add(5);
                    }
                    else
                    {
                        back5.Fill = Brushes.Transparent;
                        files.Remove(5);
                    }
                    //Record.addToOperationList("Select", "A6.pdf");
                }
                else
                {
                    files.Clear();
                    files.Add(5);
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
                    //back10.Fill = Brushes.Transparent;
                }
            }
            else if (e.Source == button6)
            {
                if ((Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control)
                {
                    if (!files.Contains(6))
                    {
                        back6.Fill = selectBrush;
                        files.Add(6);
                    }
                    else
                    {
                        back6.Fill = Brushes.Transparent;
                        files.Remove(6);
                    }
                    //Record.addToOperationList("Select", "A7.pdf");
                }
                else
                {
                    files.Clear();
                    files.Add(6);
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
                    //back10.Fill = Brushes.Transparent;
                }
            }
            else if (e.Source == button7)
            {
                if ((Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control)
                {
                    if (!files.Contains(7))
                    {
                        back7.Fill = selectBrush;
                        files.Add(7);
                    }
                    else
                    {
                        back7.Fill = Brushes.Transparent;
                        files.Remove(7);
                    }
                    //Record.addToOperationList("Select", "A8.pdf");
                }
                else
                {
                    files.Clear();
                    files.Add(7);
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
                    //back10.Fill = Brushes.Transparent;
                }
            }

            else if (e.Source == button8)
            {
                if ((Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control)
                {
                    if (!files.Contains(8))
                    {
                        back8.Fill = selectBrush;
                        files.Add(8);
                    }
                    else
                    {
                        back8.Fill = Brushes.Transparent;
                        files.Remove(8);
                    }
                    //Record.addToOperationList("Select", "A9.pdf");
                }
                else
                {
                    files.Clear();
                    files.Add(8);
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
                    //back10.Fill = Brushes.Transparent;
                }
            }
            else if (e.Source == button9)
            {
                if ((Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control)
                {
                    if (!files.Contains(9))
                    {
                        back9.Fill = selectBrush;
                        files.Add(9);
                    }
                    else
                    {
                        back9.Fill = Brushes.Transparent;
                        files.Remove(9);
                    }
                    //Record.addToOperationList("Select", "A10.pdf");
                }
                else
                {
                    files.Clear();
                    files.Add(9);
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
                    //back10.Fill = Brushes.Transparent;
                }

            }
            //else if (e.Source == button10)
            //{
            //    if ((Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control)
            //    {
            //        //back10.Fill = selectBrush;
            //        Record.addToOperationList("Select", "Untitled.pdf");
            //    }
            //    else
            //    {
            //        back0.Fill = Brushes.Transparent;
            //        back1.Fill = Brushes.Transparent;
            //        back2.Fill = Brushes.Transparent;
            //        back3.Fill = Brushes.Transparent;
            //        back4.Fill = Brushes.Transparent;
            //        back5.Fill = Brushes.Transparent;
            //        back6.Fill = Brushes.Transparent;
            //        back7.Fill = Brushes.Transparent;
            //        back8.Fill = Brushes.Transparent;
            //        back9.Fill = Brushes.Transparent;
            //        //back10.Fill = selectBrush;
            //    }

            //}
            else
            {
                files.Clear();
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
                //back10.Fill = Brushes.Transparent;
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

        private void openClick(object sender, RoutedEventArgs e)
        {
            FilesCheck(files);
            this.Close();
            settingNow.Activate();
            settingNow.Focus();
            settingNow.Topmost = true;
        }

        private void cancelClick(object sender, RoutedEventArgs e)
        {
            this.Close();
            settingNow.Activate();
            settingNow.Focus();
            settingNow.Topmost = true;
        }
    }
}
