// See https://aka.ms/new-console-template for more information
//using System.Diagnostics;
//Savanna Dickie
//10/23/2024
//Lab 6 Typing Trainer

using System.Diagnostics;

Console.Clear();
//int cursorTop = Console.CursorTop;
//int cursorLeft = Console.CursorLeft;
Console.WriteLine("Welcome to typing practice!\nA challange message will be provided for you to type.\nClick ENTER to start.");
Console.ReadLine();

Console.Clear();
Stopwatch stopwatch = new Stopwatch();
string challengeText = "Don't give up what you want most for what you want now.";

Console.WriteLine(challengeText);

Console.SetCursorPosition(0, Console.CursorTop - 1);

int correct = 0;
int incorrect = 0;
stopwatch.Start();
for(int i = 0; i < challengeText.Length; i++)
{
    char temp = Console.ReadKey(true).KeyChar;

    if (temp == challengeText[i])
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(challengeText[i]);
        correct++;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(challengeText[i]);
        incorrect ++;
    }
     
}
stopwatch.Stop();
Console.ResetColor();

string[] words = challengeText.Split(' ');
int wordCount = words.Count();

Console.WriteLine();
Console.WriteLine($"Typing practice over!\n\nErrors: {incorrect}");
int speed = (int)((wordCount - incorrect) * 60 / (stopwatch.ElapsedMilliseconds/1000));
Console.WriteLine($"Words per minute: {speed}");