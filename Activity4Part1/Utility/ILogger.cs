using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity1Part3.Utility
{
    interface ILogger
    {

        void Debug(string message);

        void Info(string message, string v);

        void Info(string message);

        void Warning(string message);

        void Error(string message, string error);


    }
}
