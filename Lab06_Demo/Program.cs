using System.Text;

Console.CursorVisible = false;
Console.OutputEncoding = Encoding.UTF8;

string obstacle = "#";

int obstacle1X = 5;
int obstacle1Y = 5;

string person = "@";

int personX = 1;
int personY = 1;

while (true)
{
    Console.Clear();
    Console.CursorLeft = 0;
    Console.CursorTop = 0;

Console.WriteLine(@"+---------+
|         |
|         |
|         |
|         |
|         |
|         |
+---------+");

    Console.CursorLeft = personX;
    Console.CursorTop = personY;
    Console.Write(person);
    Console.CursorLeft = obstacle1X;
    Console.CursorTop = obstacle1Y;
    Console.Write(obstacle);

    ConsoleKeyInfo userInput = Console.ReadKey(true);
    if (userInput.KeyChar == 'd' || userInput.Key == ConsoleKey.RightArrow)
    {
        if ((personY != obstacle1Y || personX + 1 != obstacle1X) && (personX + 1 < 10) && (personX > 0))
            personX++;
    }
    else if (userInput.KeyChar == 'a'|| userInput.Key == ConsoleKey.LeftArrow)
    {
        if ((personY != obstacle1Y || personX - 1 != obstacle1X) && (personX < 10) && (personX - 1 > 0))
            personX--;
    }
    else if (userInput.KeyChar == 'w'|| userInput.Key == ConsoleKey.UpArrow)
    {
        if ((personX != obstacle1X || personY - 1 != obstacle1Y) && (personY < 7) && (personY - 1 > 0))
            personY--;
    }
    else if (userInput.KeyChar == 's'|| userInput.Key == ConsoleKey.DownArrow)
    {
        if ((personX != obstacle1X || personY + 1 != obstacle1Y) && (personY + 1 < 7) && (personY > 0))
            personY++;
    }
}