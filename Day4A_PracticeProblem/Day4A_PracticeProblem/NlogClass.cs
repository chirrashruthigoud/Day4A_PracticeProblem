using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4A_PracticeProblem
{
    public class NlogClass
    {
        //Nlog is open-source log platform 
        //download it from the nugget package in visual studio.
        //types of log-methods => 1.trance:detailed log 
        //2.debug:debugging information
        //3.info message:information
        //4.warning: warning message
        //5.error:error message
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        public void LogDebug(string s)
        {

            logger.Debug(s);
        }
        public void LogError(string s)
        {
            logger.Error(s);
        }
        public void LogInfo(string s)
        {
            logger.Info(s);
        }
        public void LogWarning(string s)
        {
            logger.Warn(s);
        }
    }
}
