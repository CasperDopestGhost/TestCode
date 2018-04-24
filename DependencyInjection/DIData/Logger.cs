using System;

namespace DIData
{
    public class Logger:INotify
    {
        public int total { get; set; }

       private int _number;

        public int Number
        {
            get { return _number; }
            set {
                _number = value;
                total = total + value;
            }
        }


        public void Notify(string message)
        {
            //write to db 
        }
    }
}
