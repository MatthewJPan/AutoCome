using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoComeV1
{
   public class Record
    {
        public static String [,] operations=new String [50,2];
        public static String content;
        public static String previousContent;
        public static long startTime;//open the first file
        public static long stopTime;//new txt file generated.

        public static void addToOperationList(String newOperaton, String newTarget)
        {
            for (int i = 0; i < 49; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    operations[i, j] = operations[i + 1, j];
                }

            }
            operations[49, 0] = newOperaton;
            operations[49, 1] = newTarget;
        }
        public static String DeleteFromOperationList()
        {
            String removedItem ="Removed operation: " + operations[49, 0] + operations[49, 1];
            Console.WriteLine("removed option: " + removedItem);
            for (int i = 49; i >0; i--)
            {
                for (int j = 0; j < 2; j++)
                {
                    operations[i, j] = operations[i-1 , j];
                }

            }
            return removedItem;
        }
        public static string getText(int number, string location)
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
                    content = "test6abstract";
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
                    content = "test7abstract";
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
                    content = "test8abstract";
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
                    content = "test9abstract";
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

        public static void clearOperations()
        {
            for (int i = 0; i < 49; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    operations[i, j] = "";
                }

            }
        }
    }
}
