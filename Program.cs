Console.WriteLine("Введите размерность матрицы: ");
int razmer = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Змейка: ");
int[,] matrix = new int[razmer, razmer];

int start = 1;

for (int k = 1 - razmer; k <= razmer - 1; k++)
{
    for (int i = 0; i < razmer; i++)
    {
        int j = i - k;

        if (j < 0 || j >= razmer)
            continue;
        if ((k % 2) != 0)
        {
            matrix[i, razmer - 1 - j] = start++;
        }
        else
        {
            matrix[razmer - 1 - j, i] = start++;
        }

    }

}


for (int i = 0; i < razmer; i++)
{
    for (int j = 0; j < razmer; j++)

        Console.Write(matrix[i, j] + "\t");
    Console.WriteLine();
}

Console.ReadKey();