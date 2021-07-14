using System;
using System.IO;

namespace JulMan.Logger
{
    public sealed class Logger
    {

        private StreamType st;
        private StreamWriter sw;
        private TextWriter tw;

        public Logger(Stream stream)
        {
            this.st = StreamType.Stream;
            this.sw = new StreamWriter(stream);
        }

        public Logger(StreamWriter stream)
        {
            this.st = StreamType.Stream;
            this.sw = stream;
        }

        public Logger(TextWriter stream)
        {
            this.st = StreamType.TextWriter;
            this.tw = stream;
        }

        public StreamWriter GetStream()
        {
            if (st == StreamType.Stream) return sw;
            return null;
        }

        public TextWriter GetTextWriter()
        {
            if (st == StreamType.TextWriter) return tw;
            return null;
        }

        public SubLogger CreateSubLogger(string prefix) => new SubLogger(this, st, prefix);

    }
}
