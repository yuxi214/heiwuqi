﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KumuTraderClient
{
    public class MsgActionInfo<T> : MsgActionInfo
    {
        public new Action<T> Action { get; internal set; }

        public new void Execute()
        {
            Execute(default(T));
        }

        public void Execute(T args)
        {
            if (Action != null)
                Action(args);
        }
    }
}