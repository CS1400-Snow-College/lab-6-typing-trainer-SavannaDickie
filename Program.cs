// See https://aka.ms/new-console-template for more information
//using System.Diagnositcs;
//Savanna Dickie
//10/23/2024
//Lab 6 Typing Trainer

Console.Clear();
//int cursorTop = Console.CursorTop;
//int cursorLeft = Console.CursorLeft;
Console.WriteLine("Welcome to typing practice!\nA challange message will be provided for you to type.\nClick ENTER to start.");
Console.ReadLine();

//Console.Clear();

string challengeText = "Don't give up what you want most for what you want now.";

Console.WriteLine(challengeText);
//Console.WriteLine("Type the message above");
//Console.ReadLine();
//Console.SetCursorPosition(0, cursorTop -1 && 0, cursorLeft + 4);
//Console.SetCursorPosition(0, cursorLeft);
Console.SetCursorPosition(0, Console.CursorTop - 1);
//Console.Write(" ");
//Console.ReadLine();
Console.ForegroundColor =ConsoleColor.DarkMagenta;

//char temp;

int correct = 0;
int incorrect = 0;

//Console.Write("jhlkh ");
//temp = Console.ReadKey(true).KeyChar;
//Console.Write("Type the message above: ");
//char temp = Console.ReadKey(true).KeyChar;
for(int i = 0; i < challengeText.Length; i++)
{
    char temp = Console.ReadKey(true).KeyChar;
     //temp = Console.ReadKey(true).KeyChar;
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
    //temp = Console.ReadKey(true).KeyChar;
    
}
