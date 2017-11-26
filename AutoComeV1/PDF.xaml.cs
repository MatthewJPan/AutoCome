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
    /// PDF.xaml 的交互逻辑
    /// </summary>
    public partial class PDF : Window
    {
        //FString[,] operations = new String[20, 2];
        //public event Action<String> Check;
        //public event Action<String> CheckTarget;

        //public event EventHandler<WindowEventArgs> DialogFinished;

        public PDF(int source)
        //String[,] passedOperations
        {
            InitializeComponent();
            //operations = passedOperations;
            
            //for (int i = 0; i < 20; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {
            //        operations[i, j] = passedOperations[i,j];
            //        //Console.Write(operations[i, j]);
                    
            //    }
            //}
            //Console.WriteLine();
            //title.Text = passedOperations[19,1];
            this.Activate();
            fileTitle.Text = ("A"+source.ToString()+".pdf");
            title.Text = getText(source, "title");
            _abstract.Text = getText(source, "abstract");
            content0.Text = getText(source, "content0");
            content1.Text = getText(source, "content1");

            //if (source == 0)
            //{
            //    title.Text = getText(0, "title");
            //    _abstract.Text = getText(0, "abstract");
            //    content0.Text = getText(0, "content0");
            //    content1.Text = getText(0, "content1");
            //}
            //else if (source == 1)
            //{
            //    title.Text = getText(1, "title");
            //    _abstract.Text = getText(1, "abstract");
            //    content0.Text = getText(1, "content0");
            //    content1.Text = getText(1, "content1");
            //}
            //else if (source == 2)
            //{
            //    title.Text = getText(2, "title");
            //    _abstract.Text = getText(2, "abstract");
            //    content0.Text = getText(2, "content0");
            //    content1.Text = getText(2, "content1");
            //}
            //else if (source == 3)
            //{
            //    title.Text = getText(3, "title");
            //    _abstract.Text = getText(3, "abstract");
            //    content0.Text = getText(3, "content0");
            //    content1.Text = getText(3, "content1");
            //}
            //else if (source == 4)
            //{
            //    title.Text = getText(4, "title");
            //    _abstract.Text = getText(4, "abstract");
            //    content0.Text = getText(4, "content0");
            //    content1.Text = getText(4, "content1");
            //}
            //else if (source == 5)
            //{
            //    title.Text = getText(5, "title");
            //    _abstract.Text = getText(5, "abstract");
            //    content0.Text = getText(5, "content0");
            //    content1.Text = getText(5, "content1");
            //}
            //else if (source == 6)
            //{
            //    title.Text = getText(6, "title");
            //    _abstract.Text = getText(6, "abstract");
            //    content0.Text = getText(6, "content0");
            //    content1.Text = getText(6, "content1");
            //}
            //else if (source == 7)
            //{
            //    title.Text = getText(7, "title");
            //    _abstract.Text = getText(7, "abstract");
            //    content0.Text = getText(7, "content0");
            //    content1.Text = getText(7, "content1");
            //}
            //else if (source == 8)
            //{
            //    title.Text = getText(8, "title");
            //    _abstract.Text = getText(8, "abstract");
            //    content0.Text = getText(8, "content0");
            //    content1.Text = getText(8, "content1");
            //}
            //else
            //{
            //    title.Text = getText(9, "title");
            //    _abstract.Text = getText(9, "abstract");
            //    content0.Text = getText(9, "content0");
            //    content1.Text = getText(9, "content1");
            //}
        }
        //private void CloseClick(object sender, RoutedEventArgs e)
        //{
        //    this.Close();
        //}
        //private void Move_MouseMove(object sender, MouseEventArgs e)
        //{
        //    if (e.LeftButton == MouseButtonState.Pressed)
        //    {
        //        this.DragMove();
        //    }
        //}
        public string getText(int number, string location)
        {
            string content = " ";
            if (number == 0)
            {
                if (location == "title")
                {
                    content = "ADAPTING A PSYCHOPHYSICAL METHOD TO MEASURE PERFORMANCE AND PREFERENCE TRADEOFFS IN HUMAN - COMPUTER INTERACTION";
                }
                else if (location == "abstract")
                {
                    content = "An experimental methodology for contrasting certain design alternatives and quickly determining user preferences and performance tradeoffs is presented.It is shown how this experimental paradigm, used for psychophysical measurement, may be applied to the field of human - computer interaction.Where it can be applied, it promises a relatively quick determination of user preference.";

                }
                else if (location == "content0")
                {
                    content = "Often there are no optimal design features -- most features involve tradeoffs.The usefulness of a given feature may depend critically upon parameters that change within or across applications. (For a theoretical treatment of this";
                }
                else
                {
                    content = "However, the use of most standard experimental paradigms to determine the interacting influences of even a small number of variables may require a huge and often prohibitive investment of resources. A technique for collecting a large amount of data in as short a time as possible would obviously be highly desirable.This paper describes the adaptation to human - computer interaction of a technique designed to explore economically both performance and preference.The technique is in fact one of the oldest experimental paradigms in psychology-- psychophysical measurement. Although the method has theoretical and pragmatic limitations (e.g.see Poulton[2]), it can potentially be used to investigate many situations where a tradeoff exists along a particular dimension.In a field quite distant from human - computer";
                }
            }
            else if (number == 1)
            {
                if (location == "title")
                {
                    content = "Agents that Reduce Work and Information Overload";
                }
                else if (location == "abstract")
                {
                    content = "The information highway will present us with an explosion of new computer-based tasks and services, but the complexity of this new environment will demand a new style of human-computer interaction, where the computer becomes an intelligent, active and personalized collaborator.Interface agents are computer programs that employ Artificial Intelligence techniques to provide active assistance.";
                }
                else if (location == "content0")
                {
                    content = "Computers are becoming the vehicle for an increasing range of everyday activities. Acquisition of news and information, mail and even social interactions and entertainment become more and more computer - based.At the same time,";
                }
                else
                {
                    content = "Unfortunately, these technological developments are not going hand in hand with a change in the way people interact with computers. The currently dominant interaction metaphor of direct manipulation[21] requires the user to initiate all tasks explicitly and to monitor all events.This metaphor will have to change if untrained users are to make effective use of the computers and networks of tomorrow. Techniques from the field of Artificial Intelligence, in particular so-called autonomous agents, can be used to implement a complementary style of interaction, which has been referred to as indirect management[9].Instead of user-initiated interaction via commands and/ or direct manipulation, the user is engaged in a cooperative process in which human and computer agents both initiate communication, monitor events ";
                }
            }
            else if (number == 2)
            {
                if (location == "title")
                {
                    content = "test2title";
                }
                else if (location == "abstract")
                {
                    content = "test2abstract";
                }
                else if (location == "content0")
                {
                    content = "";
                }
                else
                {
                    content = "";
                }
            }
            else if (number == 3)
            {
                if (location == "title")
                {
                    content = "test3title";
                }
                else if (location == "abstract")
                {
                    content = "test3abstract";
                }
                else if (location == "content0")
                {
                    content = "";
                }
                else
                {
                    content = "";
                }
            }
            else if (number == 4)
            {
                if (location == "title")
                {
                    content = "test4title";
                }
                else if (location == "abstract")
                {
                    content = "test4abstract";
                }
                else if (location == "content0")
                {
                    content = "";
                }
                else
                {
                    content = "";
                }
            }
            if (number == 5)
            {
                if (location == "title")
                {
                    content = "test5title";
                }
                else if (location == "abstract")
                {
                    content = "test5abstract";
                }
                else if (location == "content0")
                {
                    content = "";
                }
                else
                {
                    content = "";
                }
            }
            if (number == 6)
            {
                if (location == "title")
                {
                    content = "test6title";
                }
                else if (location == "abstract")
                {
                    content = "";
                }
                else if (location == "content0")
                {
                    content = "";
                }
                else
                {
                    content = "";
                }
            }
            if (number == 7)
            {
                if (location == "title")
                {
                    content = "test7title";
                }
                else if (location == "abstract")
                {
                    content = "";
                }
                else if (location == "content0")
                {
                    content = "";
                }
                else
                {
                    content = "";
                }
            }
            if (number == 8)
            {
                if (location == "title")
                {
                    content = "test8title";
                }
                else if (location == "abstract")
                {
                    content = "";
                }
                else if (location == "content0")
                {
                    content = "";
                }
                else
                {
                    content = "";
                }
            }
            if (number == 9)
            {
                if (location == "title")
                {
                    content = "test9title";
                }
                else if (location == "abstract")
                {
                    content = "";
                }
                else if (location == "content0")
                {
                    content = "";
                }
                else
                {
                    content = "";
                }
            }
            return content;
        }


        //private void addToOperationList(String newOperaton, String newTarget)
        //{
        //    for (int i = 0; i < 19; i++)
        //    {
        //        for (int j = 0; j < 2; j++)
        //        {
        //            operations[i, j] = operations[i + 1, j];
        //        }

        //    }
        //    operations[19, 0] = newOperaton;
        //    operations[19, 1] = newTarget;
        //}

        

        private void CtrlDown(object sender, KeyEventArgs e)
        {
            if (Keyboard.Modifiers == ModifierKeys.Control|| e.Key == Key.C)
            {

                if (title.SelectedText != "")
                {
                    Record.addToOperationList("Copy", "title");
                    //Check("Copy");
                    //CheckTarget("title");

                }
                else if (_abstract.SelectedText != "")
                {
                    Record.addToOperationList("Copy", "abstract");
                    //Check("Copy");
                    //CheckTarget("abstract");
                }
                else if (content0.SelectedText != "")
                {
                    Record.addToOperationList("Copy", "content0");
                    //Check("Copy");
                    //CheckTarget("content0");
                }
                else if (content1.SelectedText != "")
                {
                    Record.addToOperationList("Copy", "content1");
                    //Check("Copy");
                    //CheckTarget("content1");
                }
            }
            //else if (Keyboard.Modifiers == ModifierKeys.Control && e.Key == Key.V)
            //{
            //    addToOperationList("Paste to", "test.txt");
            //}
            ////for (int i = 0; i < 20; i++)
            ////{
            ////    for (int j = 0; j < 2; j++)
            ////    {
            ////        if(operations[i, j]!="Null")
            ////        {
            ////            Console.Write(operations[i, j]);

            ////        }
                    
                    
            ////    }
            ////}
            //Console.WriteLine();
        }

        private void PDF_Closed(object sender, EventArgs e)
        {
            ////if (Check != null)
            ////    Check(operations);


        }

        
        private void MouseCapture(object sender, MouseEventArgs e)
        {
            if (e.Source == title)
            {
                _abstract.Select(0, 0);
                content0.Select(0, 0);
                content1.Select(0, 0);
            }
            else if (e.Source == _abstract)
            {
                title.Select(0, 0);
                content0.Select(0, 0);
                content1.Select(0, 0);
            }
            else if (e.Source == content0)
            {
                title.Select(0, 0);
                _abstract.Select(0, 0);
                content1.Select(0, 0);
            }
            else
            {
                title.Select(0, 0);
                _abstract.Select(0, 0);
                content0.Select(0, 0);
            }
        }

       
    }

    
}
