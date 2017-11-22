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
    /// Text.xaml 的交互逻辑
    /// </summary>
    public partial class Text : Window
    {
        public event Action<String> TXTcheck;
        public Text()
        {
            InitializeComponent();
        }

        private void CtrlDown(object sender, KeyEventArgs e)
        {
            if (Keyboard.Modifiers == ModifierKeys.Control || e.Key == Key.V)
            {
                if (TXTcheck != null)
                    TXTcheck("Paste");
            }
        }
    }
}
