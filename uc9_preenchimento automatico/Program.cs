string[,] matriz = new string[9, 9];
int l, c;

for  (l = 0; l < 9; l++)
{
    for (c = 0; c < 9; c++)
    {
        if (l == c)
        {
            matriz[l, c] = "X";
        }
        else
        {
            matriz[l, c] = "0";
        }
    }
}

for (l = 0; l < 9; l++)
{
    for (c = 0; c < 9; c++)
    {
        Console.Write(matriz[l, c] + " ");
    }
    Console.WriteLine("");
}




