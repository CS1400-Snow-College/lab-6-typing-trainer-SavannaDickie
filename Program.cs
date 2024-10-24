// See https://aka.ms/new-console-template for more information
//using System.Diagnositcs;
//Savanna Dickie
//10/23/2024
//Lab 6 Typing Trainer

Console.Clear();
int cursorTop = Console.CursorTop;
int cursorLeft = Console.CursorLeft;
Console.WriteLine("Welcome to typing practice!\nA challange message will be provided for you to type.\nClick ENTER to start.");
Console.ReadLine();

Console.Clear();

string challengeText = " Dont give up what you want most for what you want now.";

Console.WriteLine(challengeText);
//Console.WriteLine("Type the message above");
//Console.ReadLine();
//Console.SetCursorPosition(0, cursorTop -1 && 0, cursorLeft + 4);
//Console.SetCursorPosition(0, cursorLeft);
Console.SetCursorPosition(0, Console.CursorTop - 1);
Console.Write(" ");
Console.ReadLine();