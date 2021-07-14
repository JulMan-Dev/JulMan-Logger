using System;
using System.Collections.Generic;
using System.Text;

namespace JulMan.Logger
{
    public sealed class SubLogger
    {

        private Logger args0;
        private StreamType args1;
        private string args2;

        public SubLogger(Logger args0, StreamType args1, string args2)
        {
            this.args0 = args0;
            this.args1 = args1;
            this.args2 = args2;
        }

        private string ParseCurrentTime()
        {
            string r = "";
            DateTime dt = DateTime.Now;

            if (dt.Hour < 10) r += "0";
            r += dt.Hour + ":";

            if (dt.Minute < 10) r += "0";
            r += dt.Minute + ":";

            if (dt.Second < 10) r += "0";
            r += dt.Second;

            return r;
        }

        public void Info(string str)
        {
            if (args1 == StreamType.Stream) args0.GetStream().WriteLine("[" + args2 + "/INFO] [" + ParseCurrentTime() + "] " + str);
            else args0.GetTextWriter().WriteLine("[" + args2 + "/INFO] [" + ParseCurrentTime() + "] " + str);
        }

        public void Info(string str, params object[] obj) => Info(string.Format(str, obj));

        public void Warn(string str)
        {
            if (args1 == StreamType.Stream) args0.GetStream().WriteLine("[" + args2 + "/WARN] [" + ParseCurrentTime() + "] " + str);
            else args0.GetTextWriter().WriteLine("[" + args2 + "/WARN] [" + ParseCurrentTime() + "] " + str);
        }

        public void Warn(string str, params object[] obj) => Warn(string.Format(str, obj));

        public void Error(string str)
        {
            if (args1 == StreamType.Stream) args0.GetStream().WriteLine("[" + args2 + "/ERROR] [" + ParseCurrentTime() + "] " + str);
            else args0.GetTextWriter().WriteLine("[" + args2 + "/ERROR] [" + ParseCurrentTime() + "] " + str);
        }

        public void Error(string str, params object[] obj) => Error(string.Format(str, obj));

        public void Debug(string str)
        {
            if (args1 == StreamType.Stream) args0.GetStream().WriteLine("[" + args2 + "/DEBUG] [" + ParseCurrentTime() + "] " + str);
            else args0.GetTextWriter().WriteLine("[" + args2 + "/DEBUG] [" + ParseCurrentTime() + "] " + str);
        }

        public void Debug(string str, params object[] obj) => Debug(string.Format(str, obj));

        public void Verbose(string str)
        {
            if (args1 == StreamType.Stream) args0.GetStream().WriteLine("[" + args2 + "/VERBOSE] [" + ParseCurrentTime() + "] " + str);
            else args0.GetTextWriter().WriteLine("[" + args2 + "/VERBOSE] [" + ParseCurrentTime() + "] " + str);
        }

        public void Verbose(string str, params object[] obj) => Verbose(string.Format(str, obj));

        public void Failure(string str)
        {
            if (args1 == StreamType.Stream) args0.GetStream().WriteLine("[" + args2 + "/FAILURE] [" + ParseCurrentTime() + "] " + str);
            else args0.GetTextWriter().WriteLine("[" + args2 + "/FAILURE] [" + ParseCurrentTime() + "] " + str);
        }

        public void Failure(string str, params object[] obj) => Failure(string.Format(str, obj));

        public void Fatal(string str)
        {
            if (args1 == StreamType.Stream) args0.GetStream().WriteLine("[" + args2 + "/FATAL] [" + ParseCurrentTime() + "] " + str);
            else args0.GetTextWriter().WriteLine("[" + args2 + "/FATAL] [" + ParseCurrentTime() + "] " + str);
        }

        public void Fatal(string str, params object[] obj) => Verbose(string.Format(str, obj));

    }
}
