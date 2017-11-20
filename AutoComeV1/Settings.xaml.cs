using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// Settings.xaml 的交互逻辑
    /// </summary>
    public partial class Settings : Window
    {
        Boolean[] stepFlag = new Boolean[6];
        Brush selectBrush;
        //SolidColorBrush selectBrush = new SolidColorBrush(Color.FromArgb(100, 0, 176, 240));
        SolidColorBrush unSelectBrush = new SolidColorBrush(Color.FromArgb(100, 208, 208, 208));

        public Settings(String step1string, String step2string, String step3string, String step4string, String step5string, String step6string)
        {
            InitializeComponent();
            progressing.Visibility = Visibility.Hidden;
            selectBrush = step1.Background;
            step1.Content = "Step1." + step1string;
            step2.Content = "Step2." + step2string;
            step3.Content = "Step3." + step3string;
            step4.Content = "Step4." + step4string;
            step5.Content = "Step5." + step5string;
            step6.Content = "Step6." + step6string;

            if (step6string == "Null")
            {
                step6.Visibility = Visibility.Hidden;
                step6.IsEnabled = false;
                if (step5string == "Null")
                {
                    step5.Visibility = Visibility.Hidden;
                    step5.IsEnabled = false;
                    if (step4string == "Null")
                    {
                        step4.Visibility = Visibility.Hidden;
                        step4.IsEnabled = false;
                        if (step3string == "Null")
                        {
                            step3.Visibility = Visibility.Hidden;
                            step3.IsEnabled = false;
                            if (step2string == "Null")
                            {
                                step2.Visibility = Visibility.Hidden;
                                step2.IsEnabled = false;
                            }
                        }

                    }
                }
            }
            for (int i = 0; i < 6; i++)
            {
                stepFlag[i] = true;
            }

        }

        private void Cancle_Click(object sender, RoutedEventArgs e)
        {
            //Application.Current.Shutdown();
            this.Close();
        }

        private void OperateClick(object sender, RoutedEventArgs e)
        {
            //TO-DO:automate operations
            informationText.Text = "Operating......";
            progressing.Visibility = Visibility.Visible;
            cancleButton.Content = "Stop Operation";
            step1.Visibility = Visibility.Hidden;
            step2.Visibility = Visibility.Hidden;
            step3.Visibility = Visibility.Hidden;
            step4.Visibility = Visibility.Hidden;
            step5.Visibility = Visibility.Hidden;
            step6.Visibility = Visibility.Hidden;
            step1.IsEnabled = false;
            step2.IsEnabled = false;
            step3.IsEnabled = false;
            step4.IsEnabled = false;
            step5.IsEnabled = false;
            step6.IsEnabled = false;
            operateButton.IsEnabled = false;

            //TO-DO:add a pause 
            //Task.Factory.StartNew(() =>
            //{
                Thread.Sleep(2000);
                Information newInformation = new Information();
                newInformation.Show();
                newInformation.Activate();
                newInformation.Focus();
                newInformation.Topmost = true;
                this.Close();

            //});

            

        }



        private void StepsClick(object sender, RoutedEventArgs e)
        {
            if (e.Source == step1) {
                if(stepFlag[0]==true)
                {
                    stepFlag[0] = false;
                    step1.Background = unSelectBrush;
                }
                else
                {
                    stepFlag[0] = true;
                    step1.Background = selectBrush;
                }

            }
            else if (e.Source == step2)
            {
                if (stepFlag[1] == true)
                {
                    stepFlag[1] = false;
                    step2.Background = unSelectBrush;
                }
                else
                {
                    stepFlag[1] = true;
                    step2.Background = selectBrush;
                }

            }
            else if (e.Source == step3)
            {
                if (stepFlag[2] == true)
                {
                    stepFlag[2] = false;
                    step3.Background = unSelectBrush;
                }
                else
                {
                    stepFlag[2] = true;
                    step3.Background = selectBrush;
                }

            }
            else if (e.Source == step4)
            {
                if (stepFlag[3] == true)
                {
                    stepFlag[3] = false;
                    step4.Background = unSelectBrush;
                }
                else
                {
                    stepFlag[3] = true;
                    step4.Background = selectBrush;
                }

            }
            else if (e.Source == step5)
            {
                if (stepFlag[4] == true)
                {
                    stepFlag[4] = false;
                    step5.Background = unSelectBrush;
                }
                else
                {
                    stepFlag[4] = true;
                    step5.Background = selectBrush;
                }

            }
            else 
            {
                if (stepFlag[5] == true)
                {
                    stepFlag[5] = false;
                    step6.Background = unSelectBrush;
                }
                else
                {
                    stepFlag[5] = true;
                    step6.Background = selectBrush;
                }

            }
        }
    }
}
