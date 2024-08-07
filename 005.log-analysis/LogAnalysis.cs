using System;

public static class LogAnalysis
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string input, string substring) => input.Split(substring)[1];

    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string input, string openingBracket, string closingBracket) => input.Split(openingBracket)[1].Split(closingBracket)[0];

    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this string input) => input.SubstringAfter(":").Trim();

    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this string s) => s.SubstringBetween("[", "]");


}




