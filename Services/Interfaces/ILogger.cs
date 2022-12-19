using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALogger.Services.Interfaces
{
    public interface ILogger
    {
        public string logInformation(string message, int line, string memberName);
        public string logDebug(string message, int line, string memberName);
        public string logTrace(string message, int line, string memberName);
        public string logWarning(string message, int line, string memberName);
        public string logError(string message, int line, string memberName);
    }
}
