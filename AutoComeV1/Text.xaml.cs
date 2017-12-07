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
    /// Text.xaml 的交互逻辑
    /// </summary>
    public partial class Text : Window
    {
        //public event Action<String> TXTcheck;
        //public event Action<String> TXTcontent;
        //String test = "test";
        //ArrayList files = new ArrayList();
        //ArrayList content = new ArrayList();
        String oldContenet = "";
        Boolean[] inputFlag = new Boolean[6];
        public Text()
        {
            InitializeComponent();
            for (int i = 0; i < inputFlag.Length; i++) {
                inputFlag[i] = false;
            }
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }
        public Text(Boolean isUndo)
        {
            InitializeComponent();
            content.Text = Record.previousContent;
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }
        public Text(ArrayList files, ArrayList types, int pre)
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            String Content = Record.content;
                //Console.WriteLine("!old!" + Content);
            Console.WriteLine("!files: " + files.Count);
            Console.WriteLine("!types: " + types.Count);
            for (int i = 0; i < files.Count; i++)
            {

                for (int j = 0; j < types.Count; j++)
                {
                    int file = (int)files[i];
                    String type = (String)types[j];
                    if (pre == -1)
                    {
                        Content = Content + "\r\n" +  Record.getText(file, type);
                    }
                    else if (pre==0)
                    {
                            //Console.WriteLine(file + "  " + type);
                        Content = Content + "\r\n" +(i+3)+". "+ Record.getText(file, type);
                            //Console.WriteLine("!" + Content);
                    }
                    else 
                    {
                        //Console.WriteLine(file + "  " + type);
                        Content = Content + "\r\n" + getCharOnType((i+2),pre) + ". " + Record.getText(file, type);
                        //Console.WriteLine("!" + Content);
                    }

                }
                }
                content.Text = Content;
            
            //}
            
        }
        private void CtrlDown(object sender, KeyEventArgs e)
        {
            if (Keyboard.Modifiers == ModifierKeys.Control)
            // || e.Key == Key.V
            {
                //if (TXTcheck != null)
                Record.addToOperationList("Paste to", "TXT file");
                //Console.WriteLine(test + "********");
            }
            //else
            //{   
            //    String keyValue = e.Key.ToString();
            //    if (keyValue == "A")
            //    {
            //        Record.addToOperationList("Keyboard input", "A");
            //    }
            //    else if (keyValue == "B")
            //    {
            //        Record.addToOperationList("Keyboard input", "B");
            //    }
            //    else if (keyValue == "D1")
            //    {
            //        Record.addToOperationList("Keyboard input", "1");
            //    }
            //    else if (keyValue == "D2")
            //    {
            //        Record.addToOperationList("Keyboard input", "2");
            //    }
            //    else if (keyValue == "OemPeriod")
            //    {
            //        Record.addToOperationList("Keyboard input", ".");
            //    }
            //    //Record.addToOperationList("Keyboard input", e.Key.ToString());
            //    Console.WriteLine(keyValue);
            //}
        }
        //public string getText(int number, string location)
        //{
        //    string content = " ";
        //    if (number == 0)
        //    {
        //        if (location == "title")
        //        {
        //            content = "ADAPTING A PSYCHOPHYSICAL METHOD TO MEASURE PERFORMANCE AND PREFERENCE TRADEOFFS IN HUMAN - COMPUTER INTERACTION";
        //        }
        //        else if (location == "abstract")
        //        {
        //            content = "An experimental methodology for contrasting certain design alternatives and quickly determining user preferences and performance tradeoffs is presented.It is shown how this experimental paradigm, used for psychophysical measurement, may be applied to the field of human - computer interaction.Where it can be applied, it promises a relatively quick determination of user preference.";

        //        }
        //        else if (location == "content0")
        //        {
        //            content = "Often there are no optimal design features -- most features involve tradeoffs.The usefulness of a given feature may depend critically upon parameters that change within or across applications. (For a theoretical treatment of this";
        //        }
        //        else
        //        {
        //            content = "However, the use of most standard experimental paradigms to determine the interacting influences of even a small number of variables may require a huge and often prohibitive investment of resources. A technique for collecting a large amount of data in as short a time as possible would obviously be highly desirable.This paper describes the adaptation to human - computer interaction of a technique designed to explore economically both performance and preference.The technique is in fact one of the oldest experimental paradigms in psychology-- psychophysical measurement. Although the method has theoretical and pragmatic limitations (e.g.see Poulton[2]), it can potentially be used to investigate many situations where a tradeoff exists along a particular dimension.In a field quite distant from human - computer";
        //        }
        //    }
        //    else if (number == 1)
        //    {
        //        if (location == "title")
        //        {
        //            content = "Agents that Reduce Work and Information Overload";
        //        }
        //        else if (location == "abstract")
        //        {
        //            content = "The information highway will present us with an explosion of new computer-based tasks and services, but the complexity of this new environment will demand a new style of human-computer interaction, where the computer becomes an intelligent, active and personalized collaborator.Interface agents are computer programs that employ Artificial Intelligence techniques to provide active assistance.";
        //        }
        //        else if (location == "content0")
        //        {
        //            content = "Computers are becoming the vehicle for an increasing range of everyday activities. Acquisition of news and information, mail and even social interactions and entertainment become more and more computer - based.At the same time,";
        //        }
        //        else
        //        {
        //            content = "Unfortunately, these technological developments are not going hand in hand with a change in the way people interact with computers. The currently dominant interaction metaphor of direct manipulation[21] requires the user to initiate all tasks explicitly and to monitor all events.This metaphor will have to change if untrained users are to make effective use of the computers and networks of tomorrow. Techniques from the field of Artificial Intelligence, in particular so-called autonomous agents, can be used to implement a complementary style of interaction, which has been referred to as indirect management[9].Instead of user-initiated interaction via commands and/ or direct manipulation, the user is engaged in a cooperative process in which human and computer agents both initiate communication, monitor events ";
        //        }
        //    }
        //    else if (number == 2)
        //    {
        //        if (location == "title")
        //        {
        //            content = "test2title";
        //        }
        //        else if (location == "abstract")
        //        {
        //            content = "test2abstract";
        //        }
        //        else if (location == "content0")
        //        {
        //            content = "";
        //        }
        //        else
        //        {
        //            content = "";
        //        }
        //    }
        //    else if (number == 3)
        //    {
        //        if (location == "title")
        //        {
        //            content = "test3title";
        //        }
        //        else if (location == "abstract")
        //        {
        //            content = "test3abstract";
        //        }
        //        else if (location == "content0")
        //        {
        //            content = "";
        //        }
        //        else
        //        {
        //            content = "";
        //        }
        //    }
        //    else if (number == 4)
        //    {
        //        if (location == "title")
        //        {
        //            content = "test4title";
        //        }
        //        else if (location == "abstract")
        //        {
        //            content = "test4abstract";
        //        }
        //        else if (location == "content0")
        //        {
        //            content = "";
        //        }
        //        else
        //        {
        //            content = "";
        //        }
        //    }
        //    if (number == 5)
        //    {
        //        if (location == "title")
        //        {
        //            content = "test5title";
        //        }
        //        else if (location == "abstract")
        //        {
        //            content = "test5abstract";
        //        }
        //        else if (location == "content0")
        //        {
        //            content = "";
        //        }
        //        else
        //        {
        //            content = "";
        //        }
        //    }
        //    if (number == 6)
        //    {
        //        if (location == "title")
        //        {
        //            content = "test6title";
        //        }
        //        else if (location == "abstract")
        //        {
        //            content = "";
        //        }
        //        else if (location == "content0")
        //        {
        //            content = "";
        //        }
        //        else
        //        {
        //            content = "";
        //        }
        //    }
        //    if (number == 7)
        //    {
        //        if (location == "title")
        //        {
        //            content = "test7title";
        //        }
        //        else if (location == "abstract")
        //        {
        //            content = "";
        //        }
        //        else if (location == "content0")
        //        {
        //            content = "";
        //        }
        //        else
        //        {
        //            content = "";
        //        }
        //    }
        //    if (number == 8)
        //    {
        //        if (location == "title")
        //        {
        //            content = "test8title";
        //        }
        //        else if (location == "abstract")
        //        {
        //            content = "";
        //        }
        //        else if (location == "content0")
        //        {
        //            content = "";
        //        }
        //        else
        //        {
        //            content = "";
        //        }
        //    }
        //    if (number == 9)
        //    {
        //        if (location == "title")
        //        {
        //            content = "test9title";
        //        }
        //        else if (location == "abstract")
        //        {
        //            content = "";
        //        }
        //        else if (location == "content0")
        //        {
        //            content = "";
        //        }
        //        else
        //        {
        //            content = "";
        //        }
        //    }
        //    return content;
        //}


        private void onClosed(object sender, EventArgs e)
        {
            Record.content = content.Text;
            //Record.previousContent = content.Text;
            //TXTcontent(currentContent);
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

        private void TextChanged(object sender, TextChangedEventArgs e)
        {
            if (content.Text.Contains("test9title"))
            {
                Record.stopTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();
                timeBox.Text = Record.stopTime - Record.startTime + "";
            }
            //String newText = content.Text;
            //if (oldContenet.Length != 0)
            //{
            //    newText = newText.Substring(oldContenet.Length - 1, newText.Length - 1);
            //    Console.WriteLine("new text: " + newText);
            //}
            //oldContenet = content.Text;
            
            if (content.Text.Contains("a.")&&inputFlag[0]==false)
            {
                inputFlag[0] = true;
                Record.addToOperationList("Keyboard input", "a.");
            }
            else if (content.Text.Contains("b.") && inputFlag[1] == false)
            {
                inputFlag[1] = true;
                Record.addToOperationList("Keyboard input", "b.");
            }
            else if (content.Text.Contains("A.") && inputFlag[2] == false)
            {
                inputFlag[2] = true;
                Record.addToOperationList("Keyboard input", "A.");
            }
            else if (content.Text.Contains("B.") && inputFlag[3] == false)
            {
                inputFlag[3] = true;
                Record.addToOperationList("Keyboard input", "B.");
            }
            else if (content.Text.Contains("1.") && inputFlag[4] == false)
            {
                inputFlag[4] = true;
                Record.addToOperationList("Keyboard input", "1.");
            }
            else if (content.Text.Contains("2.") && inputFlag[5] == false)
            {
                inputFlag[5] = true;
                Record.addToOperationList("Keyboard input", "2.");
            }

        }
        private void UndoKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Z)
            {
                Record.deleteFromOperationList();
            }
        }

        //private void newTextInput(object sender, TextCompositionEventArgs e)
        //{
        //    if (e.Text==("a"))
        //    {
        //        Record.addToOperationList("Keyboard input", "a.");
        //    }
        //    else if (e.Text==("b."))
        //    {
        //        Record.addToOperationList("Keyboard input", "b.");
        //    }
        //    else if (e.Text==("A."))
        //    {
        //        Record.addToOperationList("Keyboard input", "A.");
        //    }
        //    else if (content.Text==("B."))
        //    {
        //        Record.addToOperationList("Keyboard input", "B.");
        //    }
        //    else if (content.Text==("1."))
        //    {
        //        Record.addToOperationList("Keyboard input", "1.");
        //    }
        //    else if (e.Text==("2."))
        //    {
        //        Record.addToOperationList("Keyboard input", "2.");
        //    }

        //    }
        private String getCharOnType(int i, int type)
        {
            if (type == 1)
            {
                if (i == 0) { return "A"; }
                else if (i == 1) { return "B"; }
                else if (i == 2) { return "C"; }
                else if (i == 3) { return "D"; }
                else if (i == 4) { return "E"; }
                else if (i == 5) { return "F"; }
                else if (i == 6) { return "G"; }
                else if (i == 7) { return "H"; }
                else if (i == 8) { return "I"; }
                else  { return "J"; }
            }
            else
            {
                if (i == 0) { return "a"; }
                else if (i == 1) { return "b"; }
                else if (i == 2) { return "c"; }
                else if (i == 3) { return "d"; }
                else if (i == 4) { return "e"; }
                else if (i == 5) { return "f"; }
                else if (i == 6) { return "g"; }
                else if (i == 7) { return "h"; }
                else if (i == 8) { return "i"; }
                else { return "j"; }
            }
        }
    }
}
