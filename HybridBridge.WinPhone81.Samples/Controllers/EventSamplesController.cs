﻿using System;
using System.Threading;

namespace HybridBridge.WinPhone81.Samples.Controllers
{
    internal class EventSamplesController
    {
        public static void StartTimer(int countTo)
        {
            var times = 0;
            Timer[] timer = {null};
            timer[0] = new Timer(state =>
            {
                times++;
                if (times > countTo)
                {
                    timer[0]?.Dispose();
                }
                else
                {
                    IntEvent?.Invoke(times);
                }
            }, null, 0, 1000);
        }

        public static event Action<int> IntEvent;
    }
}