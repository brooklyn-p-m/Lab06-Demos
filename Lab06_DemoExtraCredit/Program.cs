using System.Text;

Console.CursorVisible = false;
Console.OutputEncoding = Encoding.UTF8;

string obstacle = "##";

int obstacle1X = 5;
int obstacle1Y = 5;

ConsoleColor randomConsoleColor = (ConsoleColor)new Random().Next(Enum.GetNames(typeof(ConsoleColor)).Length);

string person = "OO";

int personX = 1;
int personY = 1;

string color = "color";

int colorX = 3;
int colorY = 2;

string message = "";

while (true)
{
    Console.Clear();
    Console.CursorLeft = 0;
    Console.CursorTop = 0;

    Console.WriteLine(@$"+---------+
|         |
|         |
|         |
|         |
|         |
|         |
+---------+");
    Console.WriteLine(message);

    Console.CursorLeft = colorX;
    Console.CursorTop = colorY;
    Console.Write(color);
    Console.CursorLeft = personX;
    Console.CursorTop = personY;
    Console.Write(person);
    Console.CursorLeft = obstacle1X;
    Console.CursorTop = obstacle1Y;
    Console.Write(obstacle);


    ConsoleKeyInfo userInput = Console.ReadKey(true);
    if (userInput.KeyChar == 'd' /*|| userInput.Key == ConsoleKey.RightArrow*/)
    {
        if ((personY != obstacle1Y || personX + 2 != obstacle1X) && (personX + 2 < 10) && (personX > 0))
            personX++;
        message = $"You pressed '{userInput.KeyChar}' going right.";
    }
    else if (userInput.KeyChar == 'a' /*|| userInput.Key == ConsoleKey.LeftArrow*/)
    {
        if ((personY != obstacle1Y || personX - 2 != obstacle1X) && (personX < 10) && (personX - 1 > 0))
            personX--;
        message = $"You pressed '{userInput.KeyChar}' going left.";
    }
    else if (userInput.KeyChar == 'w' /*|| userInput.Key == ConsoleKey.UpArrow*/)
    {
        if (((personX != obstacle1X && personX != obstacle1X - 1 && personX != obstacle1X + 1) || personY - 1 != obstacle1Y) && (personY < 7) && (personY - 1 > 0))
            personY--;
        message = $"You pressed '{userInput.KeyChar}' going up.";
    }
    else if (userInput.KeyChar == 's' /*|| userInput.Key == ConsoleKey.DownArrow*/)
    {
        if (((personX != obstacle1X && personX != obstacle1X - 1 && personX != obstacle1X + 1) || personY + 1 != obstacle1Y) && (personY + 1 < 7) && (personY > 0))
            personY++;
        message = $"You pressed '{userInput.KeyChar}' going down.";
    }

    if ((personX == 2 || personX == 3 || personX == 4 || personX == 5 || personX == 6 || personX == 7) && personY == 2)
    {
        Console.ForegroundColor = (ConsoleColor)new Random().Next(Enum.GetNames(typeof(ConsoleColor)).Length);
    }

}