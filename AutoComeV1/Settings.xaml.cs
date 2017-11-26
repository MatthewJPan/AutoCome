using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
        Text txt;
        String[] steps;
        ArrayList files = new ArrayList();
        ArrayList types = new ArrayList();
        //MainWindow myMainWindow;
        //public event Action<Boolean> Settingscheck;
        int currentlyShown;

        public Settings(String [] predictedSteps, int predictedStart, int difference, Text TXTwindow)
        {
            InitializeComponent();
            //myMainWindow = mainWindow;
            progressing.Visibility = Visibility.Hidden;
            selectBrush = step1.Background;
            steps = predictedSteps;
            step1.Content = "Step1." + steps[0];
            step2.Content = "Step2." + steps[1];
            step3.Content = "Step3." + steps[2];
            step4.Content = "Step4." + steps[3];
            step5.Content = "Step5." + steps[4];
            step6.Content = "Step6." + steps[5];
            txt = TXTwindow;
            files1.Visibility = Visibility.Hidden;
            files2.Visibility = Visibility.Hidden;
            files3.Visibility = Visibility.Hidden;
            files4.Visibility = Visibility.Hidden;
            files5.Visibility = Visibility.Hidden;
            files6.Visibility = Visibility.Hidden;
            chooseButton1.Visibility = Visibility.Hidden;
            chooseButton2.Visibility = Visibility.Hidden;
            chooseButton3.Visibility = Visibility.Hidden;
            chooseButton4.Visibility = Visibility.Hidden;
            chooseButton5.Visibility = Visibility.Hidden;
            chooseButton6.Visibility = Visibility.Hidden;

            for (int i = 0; (predictedStart+i * difference) < 10; i++)
            {
                files.Add(predictedStart + i * difference);
            }
            if (steps[0].Contains("Open"))
            {
                files1.Text = showFileNmeas();
                chooseButton1.Visibility = Visibility.Visible;
                chooseButton1.IsEnabled = true;
                files1.Visibility = Visibility.Visible;
            }
            if (steps[1].Contains("Open"))
            {
                files2.Text = showFileNmeas();
                chooseButton2.Visibility = Visibility.Visible;
                files2.Visibility = Visibility.Visible;
            }
            if (steps[2].Contains("Open"))
            {
                files3.Text = showFileNmeas();
                chooseButton3.Visibility = Visibility.Visible;
                files3.Visibility = Visibility.Visible;
            }
            if (steps[3].Contains("Open"))
            {
                files4.Text = showFileNmeas();
                chooseButton4.Visibility = Visibility.Visible;
                files4.Visibility = Visibility.Visible;
            }
            if (steps[4].Contains("Open"))
            {
                files5.Text = showFileNmeas();
                chooseButton5.Visibility = Visibility.Visible;
                files5.Visibility = Visibility.Visible;
            }
            if (steps[5].Contains("Open"))
            {
                files6.Text = showFileNmeas();
                chooseButton6.Visibility = Visibility.Visible;
                files6.Visibility = Visibility.Visible;
            }

            if (steps[5] == "Null")
            {
                step6.Visibility = Visibility.Hidden;
                step6.IsEnabled = false;
                if (steps[4] == "Null")
                {
                    step5.Visibility = Visibility.Hidden;
                    step5.IsEnabled = false;
                    if (steps[3] == "Null")
                    {
                        step4.Visibility = Visibility.Hidden;
                        step4.IsEnabled = false;
                        if (steps[2] == "Null")
                        {
                            step3.Visibility = Visibility.Hidden;
                            step3.IsEnabled = false;
                            if (steps[1] == "Null")
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

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("steps!!!!" + steps[i]);
                if (stepFlag[i] == true)
                {
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
                }

            }
            Record.previousContent = txt.content.Text;
            txt.Close();
            Text autoTXT = new Text(files, types);
            autoTXT.Show();
            autoTXT.Activate();
            autoTXT.Focus();
            autoTXT.Topmost = true;

            Information newInformation = new Information(autoTXT);
            newInformation.Show();
            newInformation.Activate();
            newInformation.Focus();
            newInformation.Topmost = true;
            this.Close();
            //Thread t = new Thread(() =>
            //{
            //    Thread.Sleep(1000);//次线程休眠1秒
            //    Dispatcher.Invoke(new Action(() =>
            //    {
            //        Thread.Sleep(2000);
            //        Information newInformation = new Information();
            //        newInformation.Show();
            //        newInformation.Activate();
            //        newInformation.Focus();
            //        newInformation.Topmost = true;
            //        this.Close();
            //    }));
            //});
            //t.Start();

            //String oldContent = "";
            //txt.TXTcontent += value => oldContent = value;
            

            //TO-DO:add a pause 
            //Task.Factory.StartNew(() =>
            //{


            //});

            //await Task.Delay(1000);
            
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

        private void ChooseButtonClick(object sender, RoutedEventArgs e)
        {
            if (e.Source == chooseButton1)
            {
                currentlyShown = 1;
            }
            else if (e.Source == chooseButton2)
            {
                currentlyShown = 2;
            }
            else if (e.Source == chooseButton3)
            {
                currentlyShown = 3;
            }
            else if (e.Source == chooseButton4)
            {
                currentlyShown = 4;
            }
            else if (e.Source == chooseButton5)
            {
                currentlyShown = 5;
            }
            else if (e.Source == chooseButton6)
            {
                currentlyShown = 6;
            }
            ChooseFiles choose = new ChooseFiles(this);
            choose.FilesCheck += value => files = value;
            choose.Show();
            choose.Activate();
            choose.Focus();
            choose.Topmost = true;
            Console.WriteLine("try to open new window");
            
        }

        private void SettingsActivated(object sender, EventArgs e)
        {
            for(int i=0;i<files.Count;i++)
            {
                Console.WriteLine("*********"+files[i]);
            }
            
            if (currentlyShown == 1)
            {
                files1.Text= showFileNmeas();
            }
            else if (currentlyShown == 2)
            {
                files2.Text = showFileNmeas();
            }
            else if (currentlyShown == 3)
            {
                files3.Text = showFileNmeas();
            }
            else if (currentlyShown == 4)
            {
                files4.Text = showFileNmeas();
            }
            else if (currentlyShown == 5)
            {
                files5.Text = showFileNmeas();
            }
            else if (currentlyShown == 6)
            {
                files6.Text = showFileNmeas();
            }
        }

        private String showFileNmeas()
        {
            String fileNames = "";
            if (files.Count == 0)
            {
                fileNames = "No file";
            }
            else if (files.Count == 1)
            {
                fileNames = "A" + files[0];
            }
            else if (files.Count == 2)
            {
                fileNames = "A" + files[0] + "," + "A" + files[1];
            }
            else if (files.Count == 3)
            {
                fileNames = "A" + files[0] + "," + "A" + files[1] + "," + "A" + files[2];
            }
            else
            {
                fileNames= "A" + files[0] + "," + "A" + files[1] + "..." + "A" + files[files.Count - 1];
            }
            return fileNames;
        }
    }
}
