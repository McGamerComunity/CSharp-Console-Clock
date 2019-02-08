using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_clock
{
    class digs
    {

        static void digint(int dig, ConsoleColor color, int x, int y)
        {
            if (dig == 1)
            {
                digs.one(color, x, y);
            }
            else
            if (dig == 2)
            {
                digs.two(color, x, y);
            }
            else
            if (dig == 3)
            {
                digs.three(color, x, y);
            }
            else
            if (dig == 4)
            {
                digs.four(color, x, y);
            }
            else
            if (dig == 5)
            {
                digs.five(color, x, y);
            }
            else
            if (dig == 6)
            {
                digs.six(color, x, y);
            }
            else
            if (dig == 7)
            {
                digs.seven(color, x, y);
            }
            else
            if (dig == 8)
            {
                digs.eight(color, x, y);
            }
            else
            if (dig == 9)
            {
                digs.nine(color, x, y);
            }
            else
            if (dig == 0)
            {
                digs.zero(color, x, y);
            }
        }

        public static void digchar(char dig, ConsoleColor color, int x, int y)
        {
            if (dig == 1)
            {
                digs.one(color, x, y);
            }
            else
            if (dig == 2)
            {
                digs.two(color, x, y);
            }
            else
            if (dig == 3)
            {
                digs.three(color, x, y);
            }
            else
            if (dig == 4)
            {
                digs.four(color, x, y);
            }
            else
            if (dig == 5)
            {
                digs.five(color, x, y);
            }
            else
            if (dig == 6)
            {
                digs.six(color, x, y);
            }
            else
            if (dig == 7)
            {
                digs.seven(color, x, y);
            }
            else
            if (dig == 8)
            {
                digs.eight(color, x, y);
            }
            else
            if (dig == 9)
            {
                digs.nine(color, x, y);
            }
            else
            if (dig == 0)
            {
                digs.zero(color, x, y);
            }
        }

        static void echo(string arg, ConsoleColor color, int x , int y)
        {
            Console.ForegroundColor = color;
            //Console.BackgroundColor = color;
            Console.SetCursorPosition(x, y);
            Console.WriteLine(arg);
            //Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public static void zero(ConsoleColor color, int x, int y)
        {
            int oldx = Console.CursorLeft;
            int oldy = Console.CursorTop;
            echo(" ## ## ", color, x , y);
            echo("#     #", color, x , y+1);
            echo("#     #", color, x , y+2);
            echo(" .. .. ", color, x , y+3);
            echo("#     #", color, x , y+4);
            echo("#     #", color, x , y+5);
            echo(" ## ## ", color, x , y+6);
            Console.SetCursorPosition(oldx, oldy);
        }

        public static void one(ConsoleColor color, int x, int y)
        {
            int oldx = Console.CursorLeft;
            int oldy = Console.CursorTop;
            echo(" .. .. ", color, x , y);
            echo(".     #", color, x , y+1);
            echo(".     #", color, x , y+2);
            echo(" .. .. ", color, x , y+3);
            echo(".     #", color, x , y+4);
            echo(".     #", color, x , y+5);
            echo(" .. .. ", color, x , y+6);
            Console.SetCursorPosition(oldx, oldy);
        }

        public static void two(ConsoleColor color, int x, int y)
        {
            int oldx = Console.CursorLeft;
            int oldy = Console.CursorTop;
            echo(" ## ## ", color, x , y);
            echo(".     #", color, x , y+1);
            echo(".     #", color, x , y+2);
            echo(" ## ## ", color, x , y+3);
            echo("#     .", color, x , y+4);
            echo("#     .", color, x , y+5);
            echo(" ## ## ", color, x , y+6);
            Console.SetCursorPosition(oldx, oldy);
        }

        public static void three(ConsoleColor color, int x, int y)
        {
            int oldx = Console.CursorLeft;
            int oldy = Console.CursorTop;
            echo(" ## ##", color, x , y);
            echo(".     #", color, x , y+1);
            echo(".     #", color, x , y+2);
            echo(" ## ## ", color, x , y+3);
            echo(".     #", color, x , y+4);
            echo(".     #", color, x , y+5);
            echo(" ## ## ", color, x , y+6);
            Console.SetCursorPosition(oldx, oldy);
        }

        public static void four(ConsoleColor color, int x, int y)
        {
            int oldx = Console.CursorLeft;
            int oldy = Console.CursorTop;
            echo(" .. .. ", color, x , y);
            echo("#     #", color, x , y+1);
            echo("#     #", color, x , y+2);
            echo(" ## ## ", color, x , y+3);
            echo(".     #", color, x , y+4);
            echo(".     #", color, x , y+5);
            echo(" .. .. ", color, x , y+6);
            Console.SetCursorPosition(oldx, oldy);
        }

        public static void five(ConsoleColor color, int x, int y)
        {
            int oldx = Console.CursorLeft;
            int oldy = Console.CursorTop;
            echo(" ## ## ", color, x , y);
            echo("#     .", color, x , y+1);
            echo("#     .", color, x , y+2);
            echo(" ## ## ", color, x , y+3);
            echo(".     #", color, x , y+4);
            echo(".     #", color, x , y+5);
            echo(" ## ## ", color, x , y+6);
            Console.SetCursorPosition(oldx, oldy);
        }

        public static void six(ConsoleColor color, int x, int y)
        {
            int oldx = Console.CursorLeft;
            int oldy = Console.CursorTop;
            echo(" .. .. ", color, x , y);
            echo("#     .", color, x , y+1);
            echo("#     .", color, x , y+2);
            echo(" ## ## ", color, x , y+3);
            echo("#     #", color, x , y+4);
            echo("#     #", color, x , y+5);
            echo(" ## ## ", color, x , y+6);
            Console.SetCursorPosition(oldx, oldy);
        }

        public static void seven(ConsoleColor color, int x, int y)
        {
            int oldx = Console.CursorLeft;
            int oldy = Console.CursorTop;
            echo(" ## ## ", color, x , y);
            echo(".     #", color, x , y+1);
            echo(".     #", color, x , y+2);
            echo(" .. .. ", color, x , y+3);
            echo(".     #", color, x , y+4);
            echo(".     #", color, x , y+5);
            echo(" .. .. ", color, x , y+6);
            Console.SetCursorPosition(oldx, oldy);
        }

        public static void eight(ConsoleColor color, int x, int y)
        {
            int oldx = Console.CursorLeft;
            int oldy = Console.CursorTop;
            echo(" ## ## ", color, x , y);
            echo("#     #", color, x , y+1);
            echo("#     #", color, x , y+2);
            echo(" ## ## ", color, x , y+3);
            echo("#     #", color, x , y+4);
            echo("#     #", color, x , y+5);
            echo(" ## ## ", color, x , y+6);
            Console.SetCursorPosition(oldx, oldy);
        }

        public static void nine(ConsoleColor color, int x, int y)
        {
            int oldx = Console.CursorLeft;
            int oldy = Console.CursorTop;
            echo(" ## ## ", color, x , y);
            echo("#     #", color, x , y+1);
            echo("#     #", color, x , y+2);
            echo(" ## ## ", color, x , y+3);
            echo(".     #", color, x , y+4);
            echo(".     #", color, x , y+5);
            echo(" .. .. ", color, x , y+6);
            Console.SetCursorPosition(oldx, oldy);
        }
    }
}
