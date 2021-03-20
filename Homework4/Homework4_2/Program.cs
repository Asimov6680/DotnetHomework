using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4_2
{

    public delegate void TickHandler(object sender, TickEventArgs args);

    public class TickEventArgs
    {
        public int Hour { get; set; }
        public int Minute { get; set; }
        public int Second { get; set; }

        public int SetHour { get; set; }
        public int SetMinute { get; set; }
        public int SetSecond { get; set; }

        public static string AddZero(int num)
        {
            return num < 10 ? "0" : "";
        }
    }

    public class Clock
    {
        public event TickHandler OnTick;
        public event TickHandler OnAlarm;
        private TickEventArgs args=new TickEventArgs();

        public void SetClock(int hour, int minute, int second)
        {
            args.Hour = hour;
            args.Minute = minute;
            args.Second = second;
        }

        public void SetAlarm(int setHour, int setMinute, int setSecond)
        {
            args.SetHour = setHour;
            args.SetMinute = setMinute;
            args.SetSecond = setSecond;
        }
        public void Tick()
        {
            int h = args.Hour;
            int m = args.Minute;
            int s = args.Second;

            Console.WriteLine($"tick starts on {TickEventArgs.AddZero(h)}{h}:{TickEventArgs.AddZero(m)}{m}:{TickEventArgs.AddZero(s)}{s}");

            while (true)
            {

                System.Threading.Thread.Sleep(10);

                if (args.Second >= 59)
                {
                    args.Second = 0;
                }
                else
                {
                    args.Second++;
                }

                if (args.Second == 0)
                {
                    if (args.Minute < 59)
                    {
                        args.Minute++;
                    }
                    else
                    {
                        args.Minute = 0;
                    }
                }

                if (args.Minute == 0 &&args.Second==0)
                {
                    if (args.Hour < 23)
                    {
                        args.Hour++;
                    }
                    else
                    {
                        args.Hour = 0;
                    }
                }

                OnTick(this,args);
                if (args.Hour == args.SetHour && args.Minute == args.SetMinute && args.Second == args.SetSecond)
                {
                    OnAlarm(this, args);
                }
            }
        }
    }

    public class MyClock
    {
        public Clock clock1 = new Clock();

        public MyClock(int hour,int minute,int second)
        {
            clock1.SetClock(hour, minute, second);
            clock1.OnTick += Clock_Tick1;
            clock1.OnAlarm += Clock_Alarm1;
            
        }

        void Clock_Tick1(object sender,TickEventArgs args)
        {
            int s = args.Second;
            int m = args.Minute;
            int h = args.Hour;
            Console.WriteLine($"tick  {TickEventArgs.AddZero(h)}{h}:{TickEventArgs.AddZero(m)}{m}:{TickEventArgs.AddZero(s)}{s}");
                
        }

        void Clock_Alarm1(object sender,TickEventArgs args)
        {
            int s = args.Second;
            int m = args.Minute;
            int h = args.Hour;
            Console.WriteLine($"ALARM  {TickEventArgs.AddZero(h)}{h}:{TickEventArgs.AddZero(m)}{m}:{TickEventArgs.AddZero(s)}{s}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            int startHour = 23, startMinute = 59, startSecond = 55;
            MyClock mc = new MyClock(startHour, startMinute, startSecond);

            int setHour = 0, setMinute = 0, setSecond =8 ;
            mc.clock1.SetAlarm(setHour, setMinute, setSecond);

            mc.clock1.Tick();
           
        }
    }
}
