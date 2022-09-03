using System.Diagnostics;

// Print out the current working set size in megabytes
Console.WriteLine(Process.GetCurrentProcess().WorkingSet64 / 1024 / 1024);
