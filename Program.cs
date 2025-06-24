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

var region = new GeographicRegion("ISR");
Console.WriteLine($"Region Name: {region.DisplayName}");
Console.WriteLine($"Region Code: {region.Code}");
Console.WriteLine($"Region Code 2 letter: {region.CodeTwoLetter}");
Console.WriteLine($"Region Code Three Letter: {region.CodeThreeLetter}");
Console.WriteLine($"Region Code Three Digit: {region.CodeThreeDigit}");

// Any of those properties work for the region.
var regionId = "001"; // or .Code, .CodeTwoLetter, .CodeThreeLetter, .CodeThreeDigit
var hebrew2Formatter = new DateTimeFormatter("longdate", ["he-IL"], regionId, CalendarIdentifiers.Hebrew, ClockIdentifiers.TwelveHour);
var formattedHebrew2Date = hebrew2Formatter.Format(calendar.GetDateTime());
Console.WriteLine(formattedHebrew2Date);