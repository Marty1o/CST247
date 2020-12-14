using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Activity1Part3.Utility
{
    public sealed class MyLogger1 : ILogger
    {
        public static MyLogger1 instance = new MyLogger1();

        Lazy<MyLogger1> Instance = new Lazy<MyLogger1>();

        private Lazy<Logger> log = new Lazy<Logger>();

        private Logger logg = LogManager.GetLogger("Example");

        private MyLogger1() { }


        public static MyLogger1 GetInstance()
        {

            return instance;


        }



        public void Debug(string message)
        {
            logg.Debug(message);
            //throw new NotImplementedException();
        }

        public void Info(string message, string v)
        {
            logg.Info(message, v);
            //throw new NotImplementedException();
        }

        public void Warning(string message)
        {
            logg.Warn(message);
            //throw new NotImplementedException();
        }

        public void Info(string v)
        {
            logg.Info(v);
            ///throw new NotImplementedException();
        }

        public void Error(string message, string error)
        {
            logg.Error(message, error);
            //throw new NotImplementedException();
        }
    }
}










