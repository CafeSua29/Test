void inHinhThoi(int rows)
{
    if (rows % 2 == 0) return;

    for(int i = 0; i < rows; i++)
    {
        int spaces = Math.Abs(rows / 2 - i); 

        int stars = rows - 2 * spaces;

        for(int j = 0; j < spaces; j++)
        {
            Console.Write(" ");
        }

        for(int k = 0;  k < stars; k++)
        {
            Console.Write("*");
        }

        Console.WriteLine();
    }
}

inHinhThoi(9);
