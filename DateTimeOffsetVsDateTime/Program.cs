using static DateTimeOffsetVsDateTime.Printer;

Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("DateTimeOffset vs. DateTime");
Console.WriteLine("---------------------------");
Console.ForegroundColor = ConsoleColor.Gray;

var (utcNow, now) = (DateTimeOffset.UtcNow, DateTimeOffset.Now); // for DateTimeOffset

// DateTimeOffset
Console.WriteLine("\nDateTimeOffset (with offset):");
Print("UtcNow", utcNow);
Print("Now", now);

// DateTime
Console.WriteLine("\nDateTime (without offset):");
Print("UtcNow", DateTime.UtcNow);
Print("Now", DateTime.Now);

// Changing TimeZone
Console.WriteLine("\nChanging TimeZone:");
Print("UtcNow as LocalTime", utcNow.ToLocalTime());
Print("Now    as Utc", now.ToUniversalTime());
Print("Now    TimeZone changed", now.ToOffset(TimeSpan.FromHours(5)));

// Converting to DateTime
Console.WriteLine("\nConverting to DateTime:");
var utcNow_AsDateTime = utcNow.DateTime;           // Kind=Unspecified
var utcNow_AsLocalDateTime = utcNow.LocalDateTime; // Kind=Local
var utcNow_AsUtcDateTime = utcNow.UtcDateTime;     // Kind=Utc
var now_AsDateTime = now.DateTime;                 // Kind=Unspecified
var now_AsLocalDateTime = now.LocalDateTime;       // Kind=Local
var now_AsUtcDateTime = now.UtcDateTime;           // Kind=Utc
Print("UtcNow  as DateTime", utcNow_AsDateTime);
Print("UtcNow  as LocalDateTime", utcNow_AsLocalDateTime);
Print("UtcNow  as UtcDateTime", utcNow_AsUtcDateTime);
Print("Now     as DateTime", now_AsDateTime);
Print("Now     as LocalDateTime", now_AsLocalDateTime);
Print("Now     as UtcDateTime", now_AsUtcDateTime);


Console.WriteLine("\n\nPress any key to exit.");
Console.ReadKey();
