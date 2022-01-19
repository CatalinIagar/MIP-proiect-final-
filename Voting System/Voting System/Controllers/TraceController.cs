using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voting_System.Controllers {
   public class TraceController {

        private static TraceController _instance = null;
        private static FileStream _file;
        private static TextWriterTraceListener _traceListener;
        private BooleanSwitch _mySwitch;

        private TraceController() {

            string basePath = Environment.CurrentDirectory;
            string relativePath = @"data\logMessage.log";
            string fullPath = Path.Combine(basePath, relativePath);

            _file = new FileStream(fullPath, FileMode.OpenOrCreate);
            _traceListener = new TextWriterTraceListener(_file);
            Trace.Listeners.Add(_traceListener);
            Trace.AutoFlush = true;
            _mySwitch = new BooleanSwitch("SwitchTrace", "Trace Switch");
        }

        public static TraceController getInstance() {

            if (_instance == null) {
                _instance = new TraceController();
            }
            return _instance;

        }

        public void logMessage(string message) {
            Task.Run(() => {
                string logMsg = DateTime.Now.ToString("MM\\/dd\\/yyyyh\\:mm: ss tt");
                logMsg += " - ";
                logMsg += message;
                Trace.WriteLineIf(this._mySwitch.Enabled, logMsg);
            });
        }

    }
}
