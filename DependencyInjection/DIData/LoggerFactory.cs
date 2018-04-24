using System;
using System.Collections.Generic;
using System.Text;

namespace DIData
{
   public  class LoggerFactory
    {
        INotify notify = null;

        public LoggerFactory(INotify concreteNotify)
        {
            notify = concreteNotify;
        }


        public void NotifyLog(string message)
        {
            notify.Notify(message);
        }

    }
}
