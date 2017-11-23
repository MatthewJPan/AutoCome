using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AutoComeV1
{
    class WindowHelper
    {
        public WindowHelper() { }
        public static void CloseWindow(Window x)
        {
            Assembly currentAssembly = Assembly.GetExecutingAssembly();
            //  int count = Application.Current.Windows;
            foreach (Window w in Application.Current.Windows)
            {
                //Form f = Application.OpenForms[i];
                if (w.GetType().Assembly == currentAssembly && w == x)
                {
                    w.Close();
                }
            }
        }
    }
}
