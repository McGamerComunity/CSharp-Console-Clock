using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_clock
{
    class Program
    {
        static void dig(string dig, ConsoleColor color, int x, int y)
        {
            if (dig == "1")
            {
                digs.one(color, x, y);
            }
            else
            if (dig == "2")
            {
                digs.two(color, x, y);
            }
            else
            if (dig == "3")
            {
                digs.three(color, x, y);
            }
            else
            if (dig == "4")
            {
                digs.four(color, x, y);
            }
            else
            if (dig == "5")
            {
                digs.five(color, x, y);
            }
            else
            if (dig == "6")
            {
                digs.six(color, x, y);
            }
            else
            if (dig == "7")
            {
                digs.seven(color, x, y);
            }
            else
            if (dig == "8")
            {
                digs.eight(color, x, y);
            }
            else
            if (dig == "9")
            {
                digs.nine(color, x, y);
            }
            else
            if (dig == "0")
            {
                digs.zero(color, x, y);
            }
        }
        static void echo(string arg, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(arg);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        static void echoxy(string arg, ConsoleColor color, int x, int y)
        {
            int oldx = Console.CursorLeft;
            int oldy = Console.CursorTop;
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.Write(arg);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.SetCursorPosition(oldx, oldy);
        }

        static void Main(string[] args)
        { 

            Console.SetBufferSize(180, 40);
            Console.SetWindowSize(180, 40);
            Console.CursorVisible = false;
            Console.Title = "C# digital clock by McGamer_Comunity | for bug reportings use this email email: mcgamer@ragemail.tk";
            int cleared = 1;
            while (true)
            {
                /*
                Console.SetWindowSize(180, 40);
                Console.SetBufferSize(180, 40);
                */
                Console.CursorVisible = false;

                echoxy("DEBUG: " + DateTimeOffset.Now.Day + "/" + DateTimeOffset.Now.Month + "/" + DateTimeOffset.Now.Year + " " + DateTimeOffset.Now.Hour + ":" + DateTimeOffset.Now.Minute + ":" + DateTimeOffset.Now.Second + "." + DateTimeOffset.Now.Millisecond + "", ConsoleColor.Yellow, 149, 39);
                echoxy("if there are some displaybugs wait until the \nsecondtimer reached 00 or restart the programm", ConsoleColor.DarkCyan, 0, 38);

                string year = DateTimeOffset.Now.Year.ToString();
                string month = DateTimeOffset.Now.Month.ToString();
                string day = DateTimeOffset.Now.Day.ToString();
                string hour = DateTimeOffset.Now.Hour.ToString();
                string minute = DateTimeOffset.Now.Minute.ToString();
                string second = DateTimeOffset.Now.Second.ToString();
                string milisecond = DateTimeOffset.Now.Millisecond.ToString();

                
                if (second == "0" && cleared == 1) { Console.Clear(); cleared = 2; }
                if (second == "1" && cleared == 2) { cleared = 1; }
                

                int milisecondsdefx = 100;
                foreach (char c in milisecond)
                {
                    int milisecondsdefxedit = milisecondsdefx;
                    dig(c.ToString(), ConsoleColor.Cyan, milisecondsdefxedit, 2);
                    milisecondsdefx = milisecondsdefx + 8;

                }

                int secondsdefx = 80;
                foreach (char c in second) {
                    int secondsdefxedit = secondsdefx;
                    if (DateTimeOffset.Now.Second < 10) {
                        dig("0", ConsoleColor.Green, secondsdefxedit, 2);
                        dig(c.ToString(), ConsoleColor.Green, secondsdefxedit+8, 2);
                        secondsdefx = secondsdefx + 8;
                    } else {
                        dig(c.ToString(), ConsoleColor.Green, secondsdefxedit, 2);
                        secondsdefx = secondsdefx + 8;
                    }
                    
                    
                }

                int minutedefx = 60;
                foreach (char c in minute)
                {
                    int minutedefxedit = minutedefx;
                    if (DateTimeOffset.Now.Minute < 10)
                    {
                        dig("0", ConsoleColor.Magenta, minutedefxedit, 2);
                        dig(c.ToString(), ConsoleColor.Magenta, minutedefxedit+8, 2);
                        minutedefx = minutedefx + 8;
                    }
                    else
                    {
                        dig(c.ToString(), ConsoleColor.Magenta, minutedefxedit, 2);
                        minutedefx = minutedefx + 8;
                    }
                        

                }

                int hourdefx = 40;
                foreach (char c in hour)
                {
                    int hourdefxedit = hourdefx;
                    if (DateTimeOffset.Now.Hour < 10)
                    {
                        dig("0", ConsoleColor.Blue, hourdefxedit, 2);
                        dig(c.ToString(), ConsoleColor.Blue, hourdefxedit+8, 2);
                        hourdefx = hourdefx + 8;
                    }
                    else
                    {
                        dig(c.ToString(), ConsoleColor.Blue, hourdefxedit, 2);
                        hourdefx = hourdefx + 8;
                    }
                        

                }


                int daydefx = 44;
                foreach (char c in day)
                {
                    int daydefxedit = daydefx;
                    if (DateTimeOffset.Now.Day < 10)
                    {
                        dig("0", ConsoleColor.Red, daydefxedit, 12);
                        dig(c.ToString(), ConsoleColor.Red, daydefxedit + 8, 12);
                        daydefx = daydefx + 8;
                    }
                    else
                    {
                        dig(c.ToString(), ConsoleColor.Red, daydefxedit, 12);
                        daydefx = daydefx + 8;
                    }


                }

                int monthdefx = daydefx + 13;
                foreach (char c in month)
                {
                    int monthdefxedit = monthdefx;
                    if (DateTimeOffset.Now.Month < 10)
                    {
                        dig("0", ConsoleColor.Yellow, monthdefxedit, 12);
                        dig(c.ToString(), ConsoleColor.Yellow, monthdefxedit + 8, 12);
                        monthdefx = monthdefx + 8;
                    }
                    else
                    {
                        dig(c.ToString(), ConsoleColor.Yellow, monthdefxedit, 12);
                        monthdefx = monthdefx + 8;
                    }


                }

                int yeardefx = monthdefx + 13;
                foreach (char c in year)
                {
                    int yeardefxedit = yeardefx;
                    dig(c.ToString(), ConsoleColor.Gray, yeardefxedit, 12);
                    yeardefx = yeardefx + 8;


                }




            }
        }
    }
}
