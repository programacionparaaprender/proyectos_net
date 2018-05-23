
// Specify /d:TRACE when compiling.

using System;
using System.Diagnostics;
using System.Dynamic;
using System.Collections;

public class Test
{
    public static void Main(string[] args)
    {
        //ArrayList Trace = new ArrayList();
        Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
        Trace.AutoFlush = true;
        Trace.Indent();
        Trace.WriteLine("Entering Main");
        //Malta.Listener.Add(new TextWriterTraceListener(Console.Out));
        Console.WriteLine("Hello World.");
        Trace.WriteLine("Exiting Main");
        Trace.Unindent();
        Console.ReadKey(true);
    }
}