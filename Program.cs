// See https://aka.ms/new-console-template for more information
using Windows.Globalization;
using Windows.Globalization.DateTimeFormatting;

Console.WriteLine("Hello, World!");
// Windows.Globalization.ApplicationLanguages.PrimaryLanguageOverride = "en-US";

Windows.Globalization.Calendar calendar = new Windows.Globalization.Calendar();
var defaultFormatter = new DateTimeFormatter("longdate");
var formattedDate = defaultFormatter.Format(calendar.GetDateTime());
Console.WriteLine(formattedDate);

// var formatter = new Windows.Globalization.DateTimeFormatting.DateTimeFormatter("longdate", ["he-IL"], "he-IL", Windows.Globalization.CalendarIdentifiers.Hebrew, Windows.Globalization.ClockIdentifiers.TwelveHour);
var hebrewFormatter = new DateTimeFormatter("longdate", ["he-IL"]);
var formattedHebrewDate = hebrewFormatter.Format(calendar.GetDateTime());
Console.WriteLine(formattedHebrewDate);

var hebrew2Formatter = new DateTimeFormatter("longdate", ["he-IL"], "USA", CalendarIdentifiers.Hebrew, ClockIdentifiers.TwelveHour);
var formattedHebrew2Date = hebrew2Formatter.Format(calendar.GetDateTime());
Console.WriteLine(formattedHebrew2Date);