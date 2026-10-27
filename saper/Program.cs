
int size_x = int.Parse(Console.ReadLine());
int size_y = int.Parse(Console.ReadLine());
int[,] matrix = new int[size_x,size_y];
string[,] pole = new string[size_x, size_y];
int player_x = 0;
int player_y = 0;
for (int i = 0; i < size_y; i++)
{
    for (int j = 0; j < size_x; j++)
    {
        pole[j, i] = "*";
    }
}
while (true)
{
    for (int i = 0; i < size_y; i++)
    {
        for (int j = 0; j < size_x; j++)
        {
            if (player_x == j && player_y == i)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write(pole[j, i]);
                Console.Write(' ');
                Console.ResetColor();
            }
            else
            {
                Console.Write(pole[j, i]);
                Console.Write(' ');
            }

        }
        Console.WriteLine();
    }
    Console.WriteLine($"{player_x} {player_y}");
    ConsoleKey move = Console.ReadKey().Key;
    Console.Clear();
    switch (move)
    {
        case ConsoleKey.W:
            if (player_y > 0) player_y--;
            else continue;
            break;
        case ConsoleKey.A:
            if (player_x > 0) player_x--;
            else continue;
            break;
        case ConsoleKey.S:
            if (player_y < size_y - 1) player_y++;
            else continue;
            break;
        case ConsoleKey.D:
            if (player_x < size_x-1) player_x++;
            else continue;
            break;
        case ConsoleKey.Enter:
            pole[player_y, player_x] = matrix[player_y, player_x].ToString();
            break;
    }
}
