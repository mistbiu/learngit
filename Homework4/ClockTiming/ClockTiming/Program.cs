using System;
using System.Timers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockTiming
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Timers.Timer aTimer = new System.Timers.Timer();
            aTimer.Elapsed += new ElapsedEventHandler(TimeEvent);
            // 设置引发时间的时间间隔 此处设置为１秒（１０００毫秒）
            aTimer.Interval = 1000;
            aTimer.Enabled = true;
            Console.WriteLine("按回车键结束计时。");
            Console.Read();
        }
        private static void TimeEvent(object source, ElapsedEventArgs e)
        {
            DateTime date1 = e.SignalTime;
            int intHour = e.SignalTime.Hour;
            int intMinute = e.SignalTime.Minute;
            int intSecond = e.SignalTime.Second;
            int iHour =16 ;
            int iMinute = 30;
            int iSecond = 00;
          
        

            // 设置 每天的１０：３０：００开始执行程序
            if (intHour == iHour && intMinute == iMinute && intSecond == iSecond)
            {
                Console.WriteLine("时间到！");
            }

        }
    }
}
