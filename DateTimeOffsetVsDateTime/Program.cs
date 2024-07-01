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
Print("UtcNow  as DateTime", utcNow.DateTime);           // Kind=Unspecified
Print("UtcNow  as LocalDateTime", utcNow.LocalDateTime); // Kind=Local
Print("UtcNow  as UtcDateTime", utcNow.UtcDateTime);     // Kind=Utc
Print("Now     as DateTime", now.DateTime);              // Kind=Unspecified
Print("Now     as LocalDateTime", now.LocalDateTime);    // Kind=Local
Print("Now     as UtcDateTime", now.UtcDateTime);        // Kind=Utc


Console.WriteLine("\n\nPress any key to exit.");
Console.ReadKey();
