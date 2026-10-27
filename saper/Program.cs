
int size_x = 5;
int size_y = 5;
int[,] matrix = new int[5,5];
int player_x = 0;
int player_y = 0;

while (true)
{
    for (int i = 0; i < size_x; i++)
    {
        for (int j = 0; j < size_y; j++)
        {
            if (player_x == j && player_y == i)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write(matrix[i, j]);
                Console.Write(' ');
                Console.ResetColor();
            } else
            {
                Console.Write(matrix[i, j]);
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
            if (player_x>0) player_x--;
            else continue;
            break;
        case ConsoleKey.S:
            if (player_y<size_y - 1) player_y++;
            else continue;
            break;
        case ConsoleKey.D:
            if (player_x<size_x-1) player_x++;
            else continue;
            break;
    }
}
