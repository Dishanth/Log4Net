using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Log4Net
{
    class Program
    {
        public static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {
            log.Info("Display info msg");
            log.Debug("Display debug msg");
            log.Warn("Display warn msg");
            log.Error("Display Error msg");
            log.Fatal("Display fatal msg");
        }
    }
}
