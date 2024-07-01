namespace DateTimeOffsetVsDateTime;

internal static class Printer
{
    internal static void Print(string info, DateTime d) => Console.WriteLine($"  {info + ":",-25}  {d}    (Kind = {d.Kind})");
    internal static void Print(string info, DateTimeOffset d) => Console.WriteLine($"  {info + ":",-25}  {d}");
}
