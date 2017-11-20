using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoComeV1
{
    public class WindowEventArgs : EventArgs
    {
        String[,] operations;

        public WindowEventArgs(String[,] operations)
        {
            this.operations = operations;
           
        }
    }
}
