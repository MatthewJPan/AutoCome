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

namespace AutoComeV1
{
    /// <summary>
    /// Information.xaml 的交互逻辑
    /// </summary>
    public partial class Information : Window
    {
        Text txt;
        public Information(Text currentText)
        {
            InitializeComponent();
            txt = currentText;
            Record.stopTime=DateTimeOffset.Now.ToUnixTimeMilliseconds();
            timeBox.Text = Record.stopTime - Record.startTime+"";
        }

        private void UndoClick(object sender, RoutedEventArgs e)
        {
            //TO-DO: undo the actions;

            txt.Close();
            Text autoTXT = new Text(true);
            autoTXT.Show();
            autoTXT.Activate();
            autoTXT.Focus();
            autoTXT.Topmost = true;
            this.Close();
        }

        private void OKClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
